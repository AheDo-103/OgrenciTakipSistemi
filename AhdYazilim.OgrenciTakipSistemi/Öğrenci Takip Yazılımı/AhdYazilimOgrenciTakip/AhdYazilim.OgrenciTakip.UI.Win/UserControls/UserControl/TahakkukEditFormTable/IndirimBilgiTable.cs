﻿using AhdYazilim.OgrenciTakip.Bll.Functions;
using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Message;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.IndirimForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.IptalNedeniForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.Tahakkuk_Forms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class IndirimBilgiTable : BaseTablo
    {
        public IndirimBilgiTable()
        {
            InitializeComponent();

            Bll = new IndirimBilgileriBll();
            Tablo = tablo;
            ShowItems = new BarItem[] { btnIptalEt, btnIptalGeriAl };
            EventsLoad();
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IndirimBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<IndirimBilgileriL>();
        }

        protected override void HareketEkle()
        {
            bool HizmetAlindi(long hizmetId)
            {
                var hizmetToplami = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriL>().Where(x => x.HizmetId == hizmetId && !x.IptalEdildi && !x.Delete).Sum(x => x.BrutUcret);
                var indirimToplami = tablo.DataController.ListSource.Cast<IndirimBilgileriL>().Where(x => x.HizmetId == hizmetId && !x.ManuelGirilenTutar && !x.IptalEdildi && !x.Delete).Sum(x => x.BrutIndirim);
                return hizmetToplami == 0 ? false : hizmetToplami - indirimToplami > 0;
            }

            bool AyniHizmetKartinaAyniIndirimUygulandi(IndiriminUygulanacagiHizmetBilgileriL hizmet)
            {
                return tablo.DataController.ListSource.Cast<IndirimBilgileriL>().Any(x => x.HizmetId == hizmet.HizmetId && x.IndirimId == hizmet.IndirimId && !x.ManuelGirilenTutar && !x.IptalEdildi && !x.Delete);
            }

            var indirimList = ShowListForms<IndirimListForm>.ShowDialogListForm(KartTuru.Indirim, true).EntityListConvert<IndirimL>();
            if (indirimList == null) return;

            using (var indiriminUygulanacagiHizmetBll = new IndiriminUygulanacagiHizmetBilgileriBll())
            {
                var source = tablo.DataController.ListSource;
                var sabitTutarliIndirimGirildi = false;
                var eklenenKayitSayisi = 0;

                foreach (var indirim in indirimList)
                {
                    var hizmetList = indiriminUygulanacagiHizmetBll.List(x => x.IndirimId == indirim.Id && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId).Cast<IndiriminUygulanacagiHizmetBilgileriL>();

                    foreach (var hizmet in hizmetList)
                    {
                        if (!HizmetAlindi(hizmet.HizmetId)) continue;
                        if (AyniHizmetKartinaAyniIndirimUygulandi(hizmet)) continue;

                        if (!sabitTutarliIndirimGirildi)
                            sabitTutarliIndirimGirildi = hizmet.IndirimTutari > 0;

                        var (brutIndirim, kistDonemDusulenUcret) = IndirimHesapla(hizmet.IndirimId, hizmet.HizmetId);

                        var row = new IndirimBilgileriL
                        {
                            TahakkukId = OwnerForm.Id,
                            IndirimId = indirim.Id,
                            IndirimAdi = indirim.IndirimAdi,
                            HizmetId = hizmet.HizmetId,
                            HizmetAdi = hizmet.HizmetAdi,
                            IslemTarihi = DateTime.Now.Date,
                            BrutIndirim = brutIndirim,
                            KistDonemDusulenIndirim = kistDonemDusulenUcret,
                            NetIndirim = brutIndirim - kistDonemDusulenUcret,
                            OranliIndirim = hizmet.IndirimOrani > 0,
                            ManuelGirilenTutar = hizmet.IndirimOrani == 0 && hizmet.IndirimTutari == 0,
                            Insert = true,
                        };

                        source.Add(row);
                        eklenenKayitSayisi++;

                        if (hizmet.IndirimOrani == 0 && hizmet.IndirimTutari == 0)
                            tablo.FocusedColumn = colBrutIndirim;
                    }
                }

                if (eklenenKayitSayisi == 0) return;
                if (sabitTutarliIndirimGirildi)
                    TopluIndirimHesapla();
            }


            tablo.GridControl.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            //tablo.FocusedColumn = colIndirimAdi;

            ButonEnabledDurumu(true);
        }

        private (decimal brutIndirim, decimal kistDonemDusulenUcret) IndirimHesapla(long indirimId, long hizmetId)
        {
            decimal HizmetToplamiAl(bool iptalEdildi)
            {
                var hizmetToplami = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriL>().Where(x => x.HizmetId == hizmetId && x.IptalEdildi == iptalEdildi && !x.Delete).Sum(x => x.BrutUcret);
                var indirimToplami = tablo.DataController.ListSource.Cast<IndirimBilgileriL>().Where(x => x.HizmetId == hizmetId && !x.ManuelGirilenTutar && x.IptalEdildi == iptalEdildi && !x.Delete).Sum(x => x.BrutIndirim);
                return hizmetToplami == 0 ? 0 : hizmetToplami - indirimToplami;
            }

            using (var bll = new IndiriminUygulanacagiHizmetBilgileriBll())
            {
                var hizmetSource = bll.List(x => x.IndirimId == indirimId && x.HizmetId == hizmetId).Cast<IndiriminUygulanacagiHizmetBilgileriL>().FirstOrDefault();
                if (hizmetSource == null) return (0, 0);

                var egitimBitisTarihi = AnaForm.DonemBitisTarihi;
                var hizmetEntity = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriL>().FirstOrDefault(x => x.HizmetId == hizmetId && !x.Delete);
                var indirimEntity = Tablo.DataController.ListSource.Cast<IndirimBilgileriL>().FirstOrDefault(x => x.IndirimId == indirimId && x.HizmetId == hizmetId && !x.Delete);
                var hizmetToplami = hizmetEntity.IptalEdildi ? HizmetToplamiAl(true) : HizmetToplamiAl(false);
                //var hizmetToplami = hizmetEntity.IptalEdildi ? HizmetToplamiAl(false) : HizmetToplamiAl(true);

                var toplamGunSayisi = hizmetEntity.EgitimDonemiGunSayisi;
                var hizmetGunSayisi = indirimEntity?.IptalTarihi == null ? (int)(egitimBitisTarihi - hizmetEntity.BaslamaTarihi).TotalDays + 1 : (int)(indirimEntity.IptalTarihi - hizmetEntity.BaslamaTarihi).Value.TotalDays + 1;

                var brutIndirim = hizmetSource.IndirimTutari > 0 ? hizmetSource.IndirimTutari : (hizmetToplami * hizmetSource.IndirimOrani) / 100;
                var gunlukIndirim = brutIndirim / toplamGunSayisi;
                var kistDonemDusulenIndirim = (toplamGunSayisi - hizmetGunSayisi) * gunlukIndirim;
                brutIndirim = Math.Round(brutIndirim, AnaForm.IndirimTahakkukKurusKullan ? 2 : 0);
                kistDonemDusulenIndirim = Math.Round(kistDonemDusulenIndirim, AnaForm.IndirimTahakkukKurusKullan ? 2 : 0);

                return (brutIndirim, kistDonemDusulenIndirim);
            }
        }

        protected internal void TopluIndirimHesapla()
        {
            var source = tablo.DataController.ListSource.Cast<IndirimBilgileriL>().ToList();

            //var source = 

            source.ForEach(x =>
            {
                if (!x.OranliIndirim || x.ManuelGirilenTutar || x.Delete) return;
                x.BrutIndirim = 0;
                x.KistDonemDusulenIndirim = 0;
            });

            source.ForEach(x =>
            {
                if (x.ManuelGirilenTutar || x.Delete) return;

                var indirimler = IndirimHesapla(x.IndirimId, x.HizmetId);
                x.BrutIndirim = indirimler.brutIndirim;
                x.KistDonemDusulenIndirim = indirimler.kistDonemDusulenUcret;
                x.NetIndirim = indirimler.brutIndirim - indirimler.kistDonemDusulenUcret;

                if (!x.Insert) x.Update = true;
            });

            Tablo.UpdateSummary();
        }

        protected override void HareketSil()
        {
            if (tablo.FocusedRowHandle < 0) return;
            if (Messages.SilMesaj("İndirim Bilgisi") != DialogResult.Yes) return;

            var entity = tablo.GetRow<IndirimBilgileriL>(tablo.FocusedRowHandle);

            if (entity.IptalEdildi)
            {
                Messages.IptalHareketSilinemezMesaji();
                return;
            }

            entity.Delete = true;
            tablo.RefreshDataSource();
            TopluIndirimHesapla();

            ButonEnabledDurumu(true);
        }

        protected internal void TopluHareketSil(long hizmetId)
        {
            var source = tablo.DataController.ListSource.Cast<IndirimBilgileriL>();
            if (source == null) return;

            var silinenKayitVarmi = false;

            source.ForEach(x =>
            {
                if (x.IptalEdildi || x.HizmetId != hizmetId) return;
                x.Delete = true;
                silinenKayitVarmi = true;
            });

            if (!silinenKayitVarmi) return;
            tablo.RefreshDataSource();
            ButonEnabledDurumu(true);
        }

        protected override void IptalEt()
        {
            var indirimEntity = tablo.GetRow<IndirimBilgileriL>();
            if (indirimEntity == null || indirimEntity.IptalEdildi || indirimEntity.Insert) return;
            if (Messages.IptalMesaji("İndirim Bilgisi") != DialogResult.Yes) return;

            var hizmetEntity = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriL>().FirstOrDefault(x => !x.IptalEdildi && x.HizmetId == indirimEntity.HizmetId);
            if (hizmetEntity == null) return;

            var gunlukIndirim = indirimEntity.BrutIndirim / hizmetEntity.EgitimDonemiGunSayisi;
            var alinanHizmetGunSayisi = (int)(DateTime.Now.Date - hizmetEntity.BaslamaTarihi).TotalDays + 1;
            var brutIndirim = gunlukIndirim * alinanHizmetGunSayisi;
            var kistDonemDusulenIndirim = indirimEntity.BrutIndirim - brutIndirim;
            kistDonemDusulenIndirim = Math.Round(kistDonemDusulenIndirim, AnaForm.IndirimTahakkukKurusKullan ? 2 : 0);

            var iptalNedeni = (IptalNedeni)ShowListForms<IptalNedeniListForm>.ShowDialogListForm(KartTuru.IptalNedeni, -1);
            if (iptalNedeni != null)
            {
                indirimEntity.IptalNedeniId = Convert.ToInt64(iptalNedeni?.Id);
                indirimEntity.IptalNedeniAdi = iptalNedeni?.IptalNedeniAdi;
            }

            indirimEntity.IndirimAdi = $"{indirimEntity.IndirimAdi} - ( *** İptal Edildi *** )";

            if (!indirimEntity.ManuelGirilenTutar)
                indirimEntity.KistDonemDusulenIndirim = kistDonemDusulenIndirim > 0 ? kistDonemDusulenIndirim : 0;
            indirimEntity.NetIndirim = indirimEntity.BrutIndirim - indirimEntity.KistDonemDusulenIndirim;
            indirimEntity.IptalTarihi = DateTime.Now.Date;
            indirimEntity.IptalEdildi = true;
            indirimEntity.Update = true;

            TopluIndirimHesapla();
            Tablo.RowCellEnabled();
            tablo.FocusedColumn = colIptalAciklama;
            tablo.UpdateSummary();
            ButonEnabledDurumu(true);
        }

        protected internal void TopluIptalEt(HizmetBilgileriL entity)
        {
            var source = tablo.DataController.ListSource.Cast<IndirimBilgileriL>();

            if (source == null) return;

            source.ForEach(x =>
            {
                if (x.HizmetId != entity.HizmetId || x.IptalEdildi) return;

                var gunlukIndirim = x.BrutIndirim / entity.EgitimDonemiGunSayisi;
                var brutIndirim = gunlukIndirim * entity.AlinanHizmetGunSayisi;
                var kistDonemDusulenIndirim = x.BrutIndirim - brutIndirim;
                kistDonemDusulenIndirim = Math.Round(kistDonemDusulenIndirim, AnaForm.IndirimTahakkukKurusKullan ? 2 : 0);

                x.IndirimAdi = $"{x.IndirimAdi} - ( *** İptal Edildi *** )";
                if (!x.ManuelGirilenTutar) x.KistDonemDusulenIndirim = kistDonemDusulenIndirim > 0 ? kistDonemDusulenIndirim : 0;
                x.NetIndirim = x.BrutIndirim - x.KistDonemDusulenIndirim;
                x.IptalTarihi = DateTime.Now.Date;
                x.IptalEdildi = true;
                x.HizmetHareketId = entity.Id;
                x.IptalNedeniId = entity.IptalNedeniId;
                x.IptalNedeniAdi = entity.IptalNedeniAdi;

                if (!x.Insert) x.Update = true;
            });

            TopluIndirimHesapla();
            tablo.UpdateSummary();
        }

        protected override void IptalGeriAl()
        {
            bool HizmetAlindi(long hizmetId)
            {
                return ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriL>().Any(x => x.HizmetId == hizmetId && !x.IptalEdildi);
            }

            bool AyniIndirimAlindi(long indirimId, long hizmetId)
            {
                return tablo.DataController.ListSource.Cast<IndirimBilgileriL>().Any(x => x.IndirimId == indirimId && x.HizmetId == hizmetId && !x.IptalEdildi && !x.Delete);
            }

            var entity = tablo.GetRow<IndirimBilgileriL>();
            if (entity == null && !entity.IptalEdildi) return;
            if (Messages.IptalGeriAlMesaj(entity.IndirimAdi.Remove(entity.IndirimAdi.Length - 27, 27)) != DialogResult.Yes) return;

            if (entity.HizmetHareketId == null && !HizmetAlindi(entity.HizmetId))
            {
                Messages.HataMesaji("İndirimin Uygulandığı Hizmet Kartı İptal Edilmiş. İptal Edilen Hizmet Kartı Geri Alınmadan Veya Yeni Bir Hizmet Alınmadan, İptal İşlemi Geri Alınamaz.");
                return;
            }

            if (entity.HizmetHareketId != null)
            {
                Messages.HataMesaji("İptal Edilen İndirim, Hizmet Hareketleri Tablosundan Geri Alınabilir.");
                return;
            }

            if (AyniIndirimAlindi(entity.IndirimId, entity.HizmetId))
            {
                Messages.HataMesaji("İptal İşleminin Geri Alınması Durumunda Aynı İndirimden Birden Fazla Alım Durumu Oluşuyor.");
                return;
            }

            entity.IndirimAdi = entity.IndirimAdi.Remove(entity.IndirimAdi.Length - 27, 27);
            entity.IptalEdildi = false;
            entity.IptalTarihi = null;
            entity.IptalNedeniId = null;
            entity.IptalNedeniAdi = null;
            entity.IptalAciklama = null;
            entity.HizmetHareketId = null;
            entity.Update = true;

            TopluIndirimHesapla();
            tablo.RefreshDataSource();
            tablo.UpdateSummary();
            Tablo.RowCellEnabled();
            ButonEnabledDurumu(true);
        }

        protected internal void TopluIptalGeriAl(int hizmetHareketId)
        {
            var source = tablo.DataController.ListSource.Cast<IndirimBilgileriL>().Where(x => x.HizmetHareketId == hizmetHareketId);

            source.ForEach(x =>
            {
                x.IndirimAdi = x.IndirimAdi.Remove(x.IndirimAdi.Length - 27, 27);
                x.IptalEdildi = false;
                x.IptalTarihi = null;
                x.IptalNedeniId = null;
                x.IptalNedeniAdi = null;
                x.IptalAciklama = null;
                x.HizmetHareketId = null;
                x.Update = true;
            });

            TopluIndirimHesapla();
            tablo.RefreshDataSource();
            tablo.UpdateSummary();
        }

        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            base.Tablo_MouseUp(sender, e);

            var entity = (IndirimBilgileriL)tablo.GetRow(Tablo.FocusedRowHandle);
            if (entity == null) return;

            btnHareketSil.Enabled = !entity.IptalEdildi;
            btnIptalEt.Enabled = !entity.IptalEdildi && !entity.Insert;
            btnIptalGeriAl.Enabled = entity.IptalEdildi;
        }
        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colIptalNedeniAdi)
                e.FocusedColumn.Sec(tablo, insUptNavigator.Navigator, repositoryIptalNedeni, colIptalNedeniId);

            else if (e.FocusedColumn == colIptalTarihi)
            {
                var entity = tablo.GetRow<IndirimBilgileriL>(tablo.FocusedRowHandle);
                if (entity.IptalTarihi == null) return;

                repositoryIptalTarihi.MinValue = AnaForm.GunTarihininOncesineIptalTarihiGirilebilir ? entity.IslemTarihi : DateTime.Now.Date;
                repositoryIptalTarihi.MaxValue = AnaForm.GunTarihininSonrasinaIptalTarihiGirilebilir ? AnaForm.DonemBitisTarihi.AddDays(-1) : DateTime.Now.Date;
            }
        }

        protected override void RowCellAllowEdit()
        {
            if (tablo.DataRowCount == 0) return;
            var entity = tablo.GetRow<IndirimBilgileriL>();

            colIptalTarihi.OptionsColumn.AllowEdit = entity.IptalEdildi && entity.HizmetHareketId == null;
            colIptalNedeniAdi.OptionsColumn.AllowEdit = entity.IptalEdildi && entity.HizmetHareketId == null;
            colIptalAciklama.OptionsColumn.AllowEdit = entity.IptalEdildi && entity.HizmetHareketId == null;

            if (entity.Insert)
            {
                colBrutIndirim.OptionsColumn.AllowEdit = entity.ManuelGirilenTutar && !entity.IptalEdildi;
                colKistDonemDusulenIndirim.OptionsColumn.AllowEdit = entity.ManuelGirilenTutar && entity.IptalEdildi;
            }
            else
            {
                colBrutIndirim.OptionsColumn.AllowEdit = false;
                colKistDonemDusulenIndirim.OptionsColumn.AllowEdit = entity.ManuelGirilenTutar;
            }
        }

        //protected override void ColumnShowHide()
        //{
        //    base.ColumnShowHide();
        //}

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            if (e.Column == colIptalTarihi)
                TopluIndirimHesapla();
            else if (e.Column == colBrutIndirim || e.Column == colKistDonemDusulenIndirim)
            {
                var entity = tablo.GetRow<IndirimBilgileriL>();
                entity.NetIndirim = entity.BrutIndirim - entity.KistDonemDusulenIndirim;
            }
        }
    }
}