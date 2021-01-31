using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Message;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.MakbuzForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.Tahakkuk_Forms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class OdemeBilgiTable : BaseTablo
    {
        public OdemeBilgiTable()
        {
            InitializeComponent();

            Bll = new OdemeBilgileriBll();
            Tablo = tablo;
            ShowItems = new BarItem[] { btnBelgeHareketleri };
            EventsLoad();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((OdemeBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<OdemeBilgileriL>();
        }

        protected override void HareketEkle()
        {
            decimal BakiyeHesapla()
            {
                var bakiye = ((TahakkukEditForm)OwnerForm).txtFarkToplami.Value;
                return bakiye <= 0 ? 0 : bakiye;
            }

            var source = tablo.DataController.ListSource;
            var dahaOnceGirilenTaksitSayisi = source.Cast<OdemeBilgileriL>().Count(x => !x.Delete && x.BelgeDurumu != BelgeDurumu.MusteriyeGeriIade);

            if (!ShowEditForms<TopluOdemePlaniEditForm>.ShowDialogEditForm(source, OwnerForm.Id, BakiyeHesapla(), ((TahakkukEditForm)OwnerForm).txtKayitTarihi.DateTime.Date, dahaOnceGirilenTaksitSayisi))
                return;

            tablo.GridControl.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colOdemeTuruAdi;

            ButonEnabledDurumu(true);
        }

        protected override void ColumnShowHide()
        {
            if (tablo.DataRowCount == 0) return;
            var entity = tablo.GetRow<OdemeBilgileriL>();
            if (entity == null) return;

            colBankaHesapAdi.VisibleIndex = 11;
            colTakipNo.VisibleIndex = 12;
            colBlokeGunSayisi.VisibleIndex = 13;
            colBankaAdi.VisibleIndex = 14;
            colBankaSubeAdi.VisibleIndex = 15;
            colHesapNo.VisibleIndex = 16;
            colBelgeNo.VisibleIndex = 17;
            colAsilBorclu.VisibleIndex = 18;
            colCiranta.VisibleIndex = 19;
            colAciklama.VisibleIndex = 20;

            colBankaHesapAdi.Visible = entity.OdemeTipi == OdemeTipi.Epos || entity.OdemeTipi == OdemeTipi.Ots || entity.OdemeTipi == OdemeTipi.Pos;
            colTakipNo.Visible = entity.OdemeTipi == OdemeTipi.Pos;
            colBlokeGunSayisi.Visible = entity.OdemeTipi == OdemeTipi.Epos || entity.OdemeTipi == OdemeTipi.Ots || entity.OdemeTipi == OdemeTipi.Pos;
            colBankaAdi.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colBankaSubeAdi.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colHesapNo.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colBelgeNo.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colAsilBorclu.Visible = entity.OdemeTipi == OdemeTipi.Cek || entity.OdemeTipi == OdemeTipi.Senet;
            colCiranta.Visible = entity.OdemeTipi == OdemeTipi.Cek || entity.OdemeTipi == OdemeTipi.Senet;
        }

        protected override void RowCellAllowEdit()
        {
            if (tablo.DataRowCount == 0) return;
            var entity = tablo.GetRow<OdemeBilgileriL>();
            if (entity == null) return;

            colBankaHesapAdi.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colVade.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colTutar.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colTakipNo.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colBankaAdi.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colBankaSubeAdi.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colHesapNo.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colBelgeNo.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colAsilBorclu.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colCiranta.OptionsColumn.AllowEdit = entity.SonHareketId == null;
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<OdemeBilgileriL>(i);
                if (entity.Tutar == 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colTutar;
                    tablo.SetColumnError(colTutar, "Belge Tutarı Sıfır(0) Olamaz.");
                }

                switch (entity.OdemeTipi)
                {
                    case OdemeTipi.Cek:
                        if (entity.BankaId == null)
                        {
                            tablo.FocusedRowHandle = i;
                            tablo.FocusedColumn = colBankaAdi;
                            tablo.SetColumnError(colBankaAdi, "Banka Seçimi Yapmalısınız.");
                        }

                        if (entity.BankaSubeAdi == null)
                        {
                            tablo.FocusedRowHandle = i;
                            tablo.FocusedColumn = colBankaSubeAdi;
                            tablo.SetColumnError(colBankaSubeAdi, "Banka Şube Seçimi Yapmalısınız.");
                        }

                        if (string.IsNullOrEmpty(entity.BelgeNo))
                        {
                            tablo.FocusedRowHandle = i;
                            tablo.FocusedColumn = colBelgeNo;
                            tablo.SetColumnError(colBelgeNo, "Belge No Alanaına Geçerli Bir Değer Giriniz.");
                        }

                        if (string.IsNullOrEmpty(entity.AsilBorclu))
                        {
                            tablo.FocusedRowHandle = i;
                            tablo.FocusedColumn = colAsilBorclu;
                            tablo.SetColumnError(colAsilBorclu, "Asıl Borçlu Alanına Geçerli Bir Değer Giriniz.");
                        }
                        break;

                    case OdemeTipi.Senet:
                        if (string.IsNullOrEmpty(entity.AsilBorclu))
                        {
                            tablo.FocusedRowHandle = i;
                            tablo.FocusedColumn = colAsilBorclu;
                            tablo.SetColumnError(colAsilBorclu, "Asıl Borçlu Alanına Geçerli Bir Değer Giriniz.");
                        }
                        break;

                    case OdemeTipi.Epos:
                    case OdemeTipi.Ots:
                    case OdemeTipi.Pos:
                        if (entity.BankaHesapId == null)
                        {
                            tablo.FocusedRowHandle = i;
                            tablo.FocusedColumn = colBankaHesapAdi;
                            tablo.SetColumnError(colBankaHesapAdi, "Hesap Seçimi Yapmalısınız.");
                        }

                        break;
                }

                if (!tablo.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }

        protected override void HareketSil()
        {
            if (tablo.DataRowCount == 0) return;
            if (Messages.SilMesaj("Ödeme Bilgisi") != DialogResult.Yes) return;

            var entity = tablo.GetRow<OdemeBilgileriL>();
            if (entity.SonHareketId != null)
            {
                Messages.OdemeBilgisiSilinemezMesaj(false);
                return;
            }

            entity.Delete = true;
            tablo.RefreshDataSource();
            ButonEnabledDurumu(true);
        }

        protected override void BelgeHareketleri()
        {
            var entity = tablo.GetRow<OdemeBilgileriL>();
            if (entity == null) return;
            ShowListForms<BelgeHareketleriListForm>.ShowDialogListForm(KartTuru.BelgeSecim, -1, entity.Id);
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            var entity = tablo.GetRow<OdemeBilgileriL>();

            if (e.Column == colVade)
            {
                entity.VadeYazi = ((DateTime)e.Value).YaziIleVade();
                entity.HesabaGecisTarihi = entity.Vade.AddDays(entity.BlokeGunSayisi);
            }
            else if (e.Column == colTutar)
                entity.TutarYazi = ((decimal)e.Value).YaziIleTutar();
            else if (e.Column == colBlokeGunSayisi)
                entity.HesabaGecisTarihi = entity.Vade.AddDays(entity.BlokeGunSayisi);

            else if (e.Column == colBankaId)
            {
                entity.BankaSubeId = null;
                entity.BankaSubeAdi = null;
                colBankaSubeAdi.OptionsColumn.AllowEdit = entity.BankaId != null;
            }
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colBankaHesapAdi)
                e.FocusedColumn.Sec(tablo, insUptNavigator.Navigator, repositoryBankaHesap, colBankaHesapId);

            else if (e.FocusedColumn == colBankaAdi)
                e.FocusedColumn.Sec(tablo, insUptNavigator.Navigator, repositoryBanka, colBankaId);

            else if (e.FocusedColumn == colBankaSubeAdi)
                e.FocusedColumn.Sec(tablo, insUptNavigator.Navigator, repositoryBankaSube, colBankaSubeId, colBankaAdi, colBankaId);

            else if (e.FocusedColumn == colVade)
            {
                repositoryVade.MinValue = ((TahakkukEditForm)OwnerForm).txtKayitTarihi.DateTime.Date;
                repositoryVade.MaxValue = AnaForm.MaksimumTaksitTarihi;
                //repositoryVade.MinValue = OwnerForm.CastTo<TahakkukEditForm>().txtKayitTarihi.DateTime.Date;
            }
        }
    }
}
