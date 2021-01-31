using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Message;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.Utils.Extensions;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.HizmetForms
{
    public partial class HizmetListForm : BaseKartlarForm
    {
        private readonly Expression<Func<Hizmet, bool>> _filter;
        public HizmetListForm()
        {
            InitializeComponent();

            Bll = new HizmetBll();
            _filter = x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
        }

        public HizmetListForm(params object[] prm) : this()
        {
            if (prm != null)
            {
                var panelGoster = (bool)prm[0];
                ustPanel.Visible = DateTime.Now.Date > AnaForm.EgitimBaslamaTarihi && panelGoster;
            }

            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<HizmetEditForm>();
            KartTuru = KartTuru.Hizmet;
            TarihAyarla();
        }

        protected override void Listele()
        {
            var list = ((HizmetBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaj("Kart");
        }

        private void TarihAyarla()
        {
            txtHizmetBaslamaTarihi.Properties.MinValue = AnaForm.GunTarihininOncesineHizmetBaslamaTarihiGirilebilir ? AnaForm.EgitimBaslamaTarihi : DateTime.Now.Date < AnaForm.EgitimBaslamaTarihi ? AnaForm.EgitimBaslamaTarihi : DateTime.Now.Date;
            txtHizmetBaslamaTarihi.Properties.MaxValue = AnaForm.GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir ? AnaForm.DonemBitisTarihi : DateTime.Now.Date < AnaForm.EgitimBaslamaTarihi ? AnaForm.EgitimBaslamaTarihi : DateTime.Now.Date > AnaForm.DonemBitisTarihi ? AnaForm.DonemBitisTarihi : DateTime.Now.Date;
            txtHizmetBaslamaTarihi.DateTime = DateTime.Now.Date <= AnaForm.EgitimBaslamaTarihi ? AnaForm.EgitimBaslamaTarihi : DateTime.Now.Date > AnaForm.EgitimBaslamaTarihi && DateTime.Now.Date <= AnaForm.DonemBitisTarihi ? DateTime.Now.Date : DateTime.Now.Date > AnaForm.DonemBitisTarihi ? AnaForm.DonemBitisTarihi : DateTime.Now.Date;
        }

        protected override void SelectEntity()
        {
            base.SelectEntity();
            
            if (MultiSelect)
                SelectedEntities.ForEach(x => ((HizmetL)x).BaslamaTarihi = txtHizmetBaslamaTarihi.DateTime.Date);
        }
    }
}