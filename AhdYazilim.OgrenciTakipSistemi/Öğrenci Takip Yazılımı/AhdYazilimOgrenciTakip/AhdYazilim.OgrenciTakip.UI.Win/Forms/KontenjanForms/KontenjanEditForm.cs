using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.KontenjanForms
{
    public partial class KontenjanEditForm : BaseEditForm
    {
        public KontenjanEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new KontenjanBll(myDataLayoutControl);
            KartTuru = KartTuru.Kontenjan;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new Kontenjan() : ((KontenjanBll)Bll).Single(FilterFunctions.Filter<Kontenjan>(Id));
            NesneyiKontrollereBagla();

            if (IslemTuru != IslemTuru.EntityInsert)
                return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((KontenjanBll)Bll).YeniKodVer();
            txtKontenjanAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Kontenjan)OldEntity;
            
            txtKod.Text = entity.Kod;
            txtKontenjanAdi.Text = entity.KontenjanAdi;
            txtAciklama.Text = entity.Aciklama;
            tgwDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Kontenjan
            {
                Id = Id,
                Kod = txtKod.Text,
                KontenjanAdi = txtKontenjanAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tgwDurum.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}