using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Attributes;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls;
using System;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.SubeForms
{
    public partial class SubeEditForm : BaseEditForm
    {
        public SubeEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new SubeBll(myDataLayoutControl);
            KartTuru = KartTuru.Sube;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new SubeS() : ((SubeBll)Bll).Single(FilterFunctions.Filter<Sube>(Id));
            NesneyiKontrollereBagla();

            if (IslemTuru != IslemTuru.EntityInsert) return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SubeBll)Bll).YeniKodVer();
            txtSubeAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SubeS)OldEntity;

            txtKod.Text = entity.Kod;
            txtSubeAdi.Text = entity.SubeAdi;
            txtGrupAdi.Text = entity.GrupAdi;
            txtSiraNo.EditValue = entity.SiraNo;
            txtTelefon.Text = entity.Telefon;
            txtFaks.Text = entity.Fax;
            txtIbanNo.Text = entity.IbanNo;
            txtAdres.Text = entity.Adres;
            txtAdresIl.Id = entity.AdresIlId;
            txtAdresIl.Text = entity.AdresIlAdi;
            txtAdresIlce.Id = entity.AdresIlceId;
            txtAdresIlce.Text = entity.AdresIlceAdi;

            tgwDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Sube
            {
                Id = Id,
                Kod = txtKod.Text,
                SubeAdi = txtSubeAdi.Text,
                GrupAdi = txtGrupAdi.Text,
                Telefon = txtTelefon.Text,
                Fax = txtFaks.Text,
                Adres = txtAdres.Text,
                AdresIlId = Convert.ToInt64(txtAdresIl.Id),
                AdresIlceId = Convert.ToInt64(txtAdresIlce.Id),
                IbanNo = txtIbanNo.Text,
                Logo = (byte[])picLogo.EditValue,
                SiraNo = (int?)txtSiraNo.Value,
                Durum = tgwDurum.IsOn,
            };

            ButonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is MyButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtAdresIl)
                    sec.Sec(txtAdresIl);
                else if (sender == txtAdresIlce)
                    sec.Sec(txtAdresIlce, txtAdresIl);
            }
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtAdresIl) return;
            txtAdresIl.ControlEnabledChanged(txtAdresIlce);
        }

        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit resim)) return;
            resim.Sec(ResimMenu);
        }
    }
}