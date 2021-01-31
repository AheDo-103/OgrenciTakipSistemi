using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;
using System;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.IletisimForms
{
    public partial class IletisimEditForm : BaseEditForm
    {
        public IletisimEditForm()
        {
            InitializeComponent();

            txtKanGrubu.Properties.Items.AddRange(new string[] { "Boş", "A+", "A-", "B+", "B-", "AB+", "AB-", "0+", "0-" });

            Bll = new IletisimBll(myDataLayoutControl);
            DataLayoutControl = myDataLayoutControl;
            KartTuru = KartTuru.Iletisim;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new IletisimS() : ((IletisimBll)Bll).Single(FilterFunctions.Filter<Iletisim>(Id));
            NesneyiKontrollereBagla();

            if (IslemTuru != IslemTuru.EntityInsert) return;
            txtKanGrubu.SelectedIndex = 0;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IletisimBll)Bll).YeniKodVer();
            txtTcKimlikNo.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IletisimS)OldEntity;

            txtKod.Text = entity.Kod;
            txtTcKimlikNo.Text = entity.TcKimlikNo;
            txtAdi.Text = entity.Adi;
            txtSoyadi.Text = entity.Soyadi;
            txtEvTelefonu.Text = entity.EvTelefonu;
            txtIsTelefonu1.Text = entity.IsTelefonu1;
            txtIsTelefonu2.Text = entity.IsTelefonu2;
            txtDahili1.Text = entity.Dahili1;
            txtDahili2.Text = entity.Dahili2;
            txtCepTelefonu1.Text = entity.CepTelefonu1;
            txtCepTelefonu2.Text = entity.CepTelefonu2;
            txtWeb.Text = entity.Web;
            txtEmail.Text = entity.Mail;
            txtIbanNo.Text = entity.IbanNo;
            txtKartNo.Text = entity.KartNo;
            txtEvAdres.Text = entity.EvAdresi;
            txtEvAdresIl.Id = entity.EvAdresIlId;
            txtEvAdresIl.Text = entity.EvAdresIlAdi;
            txtEvAdresIlce.Id = entity.EvAdresIlceId;
            txtEvAdresIlce.Text = entity.EvAdresIlceAdi;
            txtIsAdres.Text = entity.IsAdres;
            txtIsAdresIl.Id = entity.IsAdresIlId;
            txtIsAdresIl.Text = entity.IsAdresIlAdi;
            txtIsAdresIlce.Id = entity.IsAdresIlceId;
            txtIsAdresIlce.Text = entity.IsAdresIlceAdi;

            txtMeslek.Id = entity.MeslekId;
            txtMeslek.Text = entity.MeslekAdi;
            txtIsyeri.Id = entity.IsyeriId;
            txtIsyeri.Text = entity.IsyeriAdi;
            txtGorev.Id = entity.GorevId;
            txtGorev.Text = entity.GorevAdi;
            txtBabaAdi.Text = entity.BabaAdi;
            txtAnaAdi.Text = entity.AnaAdi;
            txtDogumYeri.Text = entity.DogumYeri;
            txtDogumTarihi.EditValue = entity.DogumTarihi;
            txtKanGrubu.SelectedItem = entity.KanGrubu;
            txtSeriNo.Text = entity.KimlikSeri;
            txtSiraNo.Text = entity.KimlikSiraNo;
            txtNufusIl.Id = entity.KimlikIlId;
            txtNufusIl.Text = entity.KimlikIlAdi;
            txtNufusIlce.Id = entity.KimlikIlceId;
            txtNufusIlce.Text = entity.KimlikIlceAdi;
            txtMahalleKoy.Text = entity.KimlikMahalleKoy;
            txtCiltNo.Text = entity.KimlikCiltNo;
            txtAileSiraNo.Text = entity.KimlikAileSiraNo;
            txtBireySiraNo.Text = entity.KimlikBireySiraNo;
            txtVerildigiYer.Text = entity.KimlikVerildigiYer;
            txtVerilisNedeni.Text = entity.KimlikVerilisNedeni;
            txtKayitNo.Text = entity.KimlikKayitNo;
            txtVerilisTarihi.EditValue = entity.KimlikVerilisTarihi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;

            txtAciklama.Text = entity.Aciklama;
            tgwDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Iletisim
            {
                Id = Id,
                Kod = txtKod.Text,
                TcKimlikNo = txtTcKimlikNo.Text,
                Adi = txtAdi.Text,
                Soyadi = txtSoyadi.Text,
                EvTelefonu = txtEvTelefonu.Text,
                IsTelefonu1 = txtIsTelefonu1.Text,
                IsTelefonu2 = txtIsTelefonu2.Text,
                Dahili1 = txtDahili1.Text,
                Dahili2 = txtDahili2.Text,
                CepTelefonu1 = txtCepTelefonu1.Text,
                CepTelefonu2 = txtCepTelefonu2.Text,
                Web = txtWeb.Text,
                Mail = txtEmail.Text,
                IbanNo = txtIbanNo.Text,
                KartNo = txtKartNo.Text,
                EvAdresi = txtEvAdres.Text,
                EvAdresIlId = Convert.ToInt64(txtEvAdresIl.Id),
                EvAdresIlceId = Convert.ToInt64(txtEvAdresIlce.Id),
                IsAdres = txtIsAdres.Text,
                IsAdresIlId = Convert.ToInt64(txtIsAdresIl.Id),
                IsAdresIlceId = Convert.ToInt64(txtIsAdresIlce.Id),
                MeslekId = Convert.ToInt64(txtMeslek.Id),
                IsyeriId = Convert.ToInt64(txtIsyeri.Id),
                GorevId = Convert.ToInt64(txtGorev.Id),
                BabaAdi = txtBabaAdi.Text,
                AnaAdi = txtAnaAdi.Text,
                DogumYeri = txtDogumYeri.Text,
                DogumTarihi = (DateTime?)txtDogumTarihi.EditValue,
                KanGrubu = txtKanGrubu.Text,
                KimlikSeri = txtSeriNo.Text,
                KimlikSiraNo = txtSiraNo.Text,
                KimlikIlId = txtNufusIl.Id,
                KimlikIlceId = txtNufusIlce.Id,
                KimlikMahalleKoy = txtMahalleKoy.Text,
                KimlikCiltNo = txtCiltNo.Text,
                KimlikAileSiraNo = txtAileSiraNo.Text,
                KimlikBireySiraNo = txtBireySiraNo.Text,
                KimlikVerildigiYer = txtVerildigiYer.Text,
                KimlikVerilisNedeni = txtVerilisNedeni.Text,
                KimlikKayitNo = txtKayitNo.Text,
                KimlikVerilisTarihi = (DateTime?)txtVerilisTarihi.EditValue,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                Durum = tgwDurum.IsOn,
            };

            ButonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtEvAdresIl)
                    sec.Sec(txtEvAdresIl);
                else if (sender == txtEvAdresIlce)
                    sec.Sec(txtEvAdresIlce, txtEvAdresIl);
                else if (sender == txtIsAdresIl)
                    sec.Sec(txtIsAdresIl);
                else if (sender == txtIsAdresIlce)
                    sec.Sec(txtIsAdresIlce, txtIsAdresIl);
                else if (sender == txtNufusIl)
                    sec.Sec(txtNufusIl);
                else if (sender == txtNufusIlce)
                    sec.Sec(txtNufusIlce, txtNufusIl);
                else if (sender == txtMeslek)
                    sec.Sec(txtMeslek);
                else if (sender == txtIsyeri)
                    sec.Sec(txtIsyeri);
                else if (sender == txtGorev)
                    sec.Sec(txtGorev);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Iletisim);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Iletisim);
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtEvAdresIl && sender != txtIsAdresIl && sender != txtNufusIl) return;

            if (sender == txtEvAdresIl) txtEvAdresIl.ControlEnabledChanged(txtEvAdresIlce);
            else if (sender == txtIsAdresIl) txtIsAdresIl.ControlEnabledChanged(txtIsAdresIlce);
            else if (sender == txtNufusIl) txtNufusIl.ControlEnabledChanged(txtNufusIlce);
        }
    }
}