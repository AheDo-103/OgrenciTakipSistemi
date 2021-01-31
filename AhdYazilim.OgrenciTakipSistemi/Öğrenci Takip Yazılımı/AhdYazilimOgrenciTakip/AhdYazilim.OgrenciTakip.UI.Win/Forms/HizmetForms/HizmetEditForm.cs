using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;
using System;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.HizmetForms
{
    public partial class HizmetEditForm : BaseEditForm
    {
        public HizmetEditForm()
        {
            InitializeComponent();

            Bll = new HizmetBll(myDataLayoutControl);
            DataLayoutControl = myDataLayoutControl;
            KartTuru = KartTuru.Hizmet;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new HizmetS() : ((HizmetBll)Bll).Single(FilterFunctions.Filter<Hizmet>(Id));
            NesneyiKontrollereBagla();

            if (IslemTuru != IslemTuru.EntityInsert)
                return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((HizmetBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtBaslamaTarihi.DateTime = txtBaslamaTarihi.Properties.MinValue;
            txtBitisTarihi.DateTime = txtBaslamaTarihi.Properties.MaxValue;
            txtHizmetAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (HizmetS)OldEntity;

            txtKod.Text = entity.Kod;
            txtHizmetAdi.Text = entity.HizmetAdi;
            txtHizmetTuru.Id = entity.HizmetTuruId;
            txtHizmetTuru.Text = entity.HizmetTuruAdi;
            txtBaslamaTarihi.DateTime = entity.BaslamaTarihi;
            txtBitisTarihi.DateTime = entity.BitisTarihi;
            txtUcret.Value = entity.Ucret;
            txtAciklama.Text = entity.Aciklama;
            tgwDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Hizmet
            {
                Id = Id,
                Kod = txtKod.Text,
                HizmetAdi = txtHizmetAdi.Text,
                HizmetTuruId = Convert.ToInt64(txtHizmetTuru.Id),
                BaslamaTarihi = txtBaslamaTarihi.DateTime,
                BitisTarihi = txtBitisTarihi.DateTime,
                Ucret = txtUcret.Value,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId,
                Aciklama = txtAciklama.Text,
                Durum = tgwDurum.IsOn,
            };

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((HizmetBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

        protected override bool EntityUpdate()
        {
            return ((HizmetBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == x.DonemId);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit))
                return;

            using (var sec = new SelectFunctions())
                if (sender == txtHizmetTuru)
                    sec.Sec(txtHizmetTuru);
        }

        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
            base.Control_EditValueChanged(sender, e);

            txtBaslamaTarihi.Properties.MinValue = AnaForm.EgitimBaslamaTarihi;
            txtBaslamaTarihi.Properties.MaxValue = AnaForm.DonemBitisTarihi;

            txtBitisTarihi.Properties.MinValue = txtBaslamaTarihi.DateTime.Date;
            txtBitisTarihi.Properties.MaxValue = AnaForm.DonemBitisTarihi;
        }
    }
}