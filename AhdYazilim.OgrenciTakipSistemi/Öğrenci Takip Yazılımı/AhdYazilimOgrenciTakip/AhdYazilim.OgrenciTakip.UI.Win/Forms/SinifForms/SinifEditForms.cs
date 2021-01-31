using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls;
using System;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.SinifForms
{
    public partial class SinifEditForms : BaseEditForm
    {
        public SinifEditForms()
        {
            InitializeComponent();

            Bll = new SinifBll(myDataLayoutControl);
            DataLayoutControl = myDataLayoutControl;
            KartTuru = KartTuru.Sinif;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new SinifS() : ((SinifBll)Bll).Single(FilterFunctions.Filter<Sinif>(Id));
            NesneyiKontrollereBagla();

            if (IslemTuru != IslemTuru.EntityInsert)
                return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SinifBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId);
            txtSinifAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SinifS)OldEntity;
            
            txtKod.Text = entity.Kod;
            txtSinifAdi.Text = entity.SinifAdi;
            txtGrup.Id = entity.GrupId;
            txtGrup.Text = entity.GrupAdi;
            txtHedefOgrenciSayisi.Value = entity.HedefOgrenciSayisi;
            txtHedefCiro.Value = entity.HedefCiro;
            txtAciklama.Text = entity.Aciklama;
            tgwDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Sinif
            {
                Id = Id,
                Kod = txtKod.Text,
                SinifAdi = txtSinifAdi.Text,
                GrupId = Convert.ToInt64(txtGrup.Id),
                HedefOgrenciSayisi = (int)txtHedefOgrenciSayisi.Value,
                HedefCiro = txtHedefCiro.Value,
                Aciklama = txtAciklama.Text,
                SubeId = AnaForm.SubeId,
                Durum = tgwDurum.IsOn
            };

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((SinifBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);
        }

        protected override bool EntityUpdate()
        {
            return ((SinifBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is MyButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtGrup)
                    sec.Sec(txtGrup);
        }
    }
}