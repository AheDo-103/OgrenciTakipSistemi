using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.ServisForms
{
    public partial class ServisEditForm : BaseEditForm
    {
        public ServisEditForm()
        {
            InitializeComponent();

            Bll = new ServisBll(myDataLayoutControl);
            DataLayoutControl = myDataLayoutControl;
            KartTuru = KartTuru.Servis;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new Servis() : ((ServisBll)Bll).Single(FilterFunctions.Filter<Servis>(Id));
            NesneyiKontrollereBagla();

            if (IslemTuru != IslemTuru.EntityInsert)
                return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((ServisBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtServisYeri.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Servis)OldEntity;

            txtKod.Text = entity.Kod;
            txtServisYeri.Text = entity.ServisYeriAdi;
            txtUcret.Value = entity.Ucret;
            txtAciklama.Text = entity.Aciklama;
            tgwDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Servis
            {
                Id = Id,
                Kod = txtKod.Text,
                ServisYeriAdi = txtServisYeri.Text,
                Ucret = txtUcret.Value,
                Aciklama = txtAciklama.Text,
                Durum = tgwDurum.IsOn,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId
            };

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((ServisBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

        protected override bool EntityUpdate()
        {
            return ((ServisBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
    }
}