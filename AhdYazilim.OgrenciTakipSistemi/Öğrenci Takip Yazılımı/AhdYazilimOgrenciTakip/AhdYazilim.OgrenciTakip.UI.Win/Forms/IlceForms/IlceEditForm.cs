using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.IlceForms
{
    public partial class IlceEditForm : BaseEditForm
    {
         #region Variables

        private readonly long _ilId;
        private readonly string _ilAdi; 

        #endregion

        public IlceEditForm(params object[] prm)
        {
            InitializeComponent();
            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IlceBll(myDataLayoutControl);
            KartTuru = KartTuru.Ilce;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new Ilce() : ((IlceBll)Bll).Single(FilterFunctions.Filter<Ilce>(Id));
            NesneyiKontrollereBagla();

            Text = Text + $" - ( {_ilAdi} )";

            if (IslemTuru != IslemTuru.EntityInsert) return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IlceBll)Bll).YeniKodVer(x => x.IlId == _ilId);
            txtIlceAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var result = (Ilce)OldEntity;

            txtKod.Text = result.Kod;
            txtIlceAdi.Text = result.IlceAdi;
            txtAciklama.Text = result.Aciklama;
            tgwDurum.IsOn = result.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Ilce
            {
                Id = Id,
                Kod = txtKod.Text,
                IlceAdi = txtIlceAdi.Text,
                IlId = _ilId,
                Aciklama = txtAciklama.Text,
                Durum = tgwDurum.IsOn
            };

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((IlceBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.IlId == _ilId);
        }

        protected override bool EntityUpdate()
        {
            return ((IlceBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.IlId == _ilId);
        }
    }
}