using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;
using System;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.IndirimForms
{
    public partial class IndirimEditForm : BaseEditForm
    {
        public IndirimEditForm()
        {
            InitializeComponent();

            Bll = new IndirimBll(myDataLayoutControl);
            DataLayoutControl = myDataLayoutControl;
            KartTuru = KartTuru.Indirim;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new IndirimS() : ((IndirimBll)Bll).Single(FilterFunctions.Filter<Indirim>(Id));
            NesneyiKontrollereBagla();
            TabloYukle();

            if (IslemTuru != IslemTuru.EntityInsert) return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IndirimBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtIndirimAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IndirimS)OldEntity;
            
            txtKod.Text = entity.Kod;
            txtIndirimAdi.Text = entity.IndirimAdi;
            txtIndirimTuru.Id = entity.IndirimTuruId;
            txtIndirimTuru.Text = entity.IndirimTuruAdi;
            txtAciklama.Text = entity.Aciklama;
            tgwDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Indirim
            {
                Id = Id,
                Kod = txtKod.Text,
                IndirimAdi = txtIndirimAdi.Text,
                IndirimTuruId = Convert.ToInt64(txtIndirimTuru.Id),
                Aciklama = txtAciklama.Text,
                Durum = tgwDurum.IsOn,
                DonemId = AnaForm.DonemId,
                SubeId = AnaForm.SubeId,
            };

            ButonEnabledDurumu();
        }

        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity, hizmetTablo.TableValueChanged);
        }

        protected override bool EntityInsert()
        {
            if (hizmetTablo.HataliGiris()) return false;
            return ((IndirimBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && hizmetTablo.Kaydet();
        }

        protected override bool EntityUpdate()
        {
            if (hizmetTablo.HataliGiris()) return false;
            return ((IndirimBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && hizmetTablo.Kaydet();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtIndirimTuru)
                    sec.Sec(txtIndirimTuru);
        }

        protected override void TabloYukle()
        {
            hizmetTablo.OwnerForm = this;
            hizmetTablo.Yukle();
        }
    }
}