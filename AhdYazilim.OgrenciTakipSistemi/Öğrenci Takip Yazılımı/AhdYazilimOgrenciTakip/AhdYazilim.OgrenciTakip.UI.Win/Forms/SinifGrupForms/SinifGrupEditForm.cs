using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.SinifGrupForms
{
    public partial class SinifGrupEditForm : BaseEditForm
    {
        public SinifGrupEditForm()
        {
            InitializeComponent();

            Bll = new SinifGrupBll(myDataLayoutControl);
            DataLayoutControl = myDataLayoutControl;
            KartTuru = KartTuru.SinifGrup;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new SinifGrup() : ((SinifGrupBll)Bll).Single(FilterFunctions.Filter<SinifGrup>(Id));
            NesneyiKontrollereBagla();

            if (IslemTuru != IslemTuru.EntityInsert)
                return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SinifGrupBll)Bll).YeniKodVer();
            txtGrupAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SinifGrup)OldEntity;

            txtKod.Text = entity.Kod;
            txtGrupAdi.Text = entity.GrupAdi;
            txtAciklama.Text = entity.Aciklama;
            tgwDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new SinifGrup
            {
                Id = Id,
                Kod = txtKod.Text,
                GrupAdi = txtGrupAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tgwDurum.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}