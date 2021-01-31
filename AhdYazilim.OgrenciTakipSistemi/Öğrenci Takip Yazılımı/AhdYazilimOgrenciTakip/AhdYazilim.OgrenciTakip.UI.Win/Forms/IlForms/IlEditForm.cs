using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.IlForms
{
    public partial class IlEditForm : BaseEditForm
    {
        public IlEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IlBll(DataLayoutControl);
            KartTuru = KartTuru.Il;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new Il() : ((IlBll)Bll).Single(FilterFunctions.Filter<Il>(Id));
            NesneyiKontrollereBagla();

            if (IslemTuru != IslemTuru.EntityInsert) return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IlBll)Bll).YeniKodVer();
            txtIlAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Il)OldEntity;

            txtKod.Text = entity.Kod;
            txtIlAdi.Text = entity.IlAdi;
            txtAciklama.Text = entity.Aciklama;
            tgwDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Il
            {
                Id = Id,
                Kod = txtKod.Text,
                IlAdi = txtIlAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tgwDurum.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}