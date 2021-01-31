using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BankaSubeForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.BankaForms
{
    public partial class BankaListForm : BaseKartlarForm
    {
        public BankaListForm()
        {
            InitializeComponent();

            Bll = new BankaBll();
            btnBagliKartlar.Caption = "Şube Kartları";
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            KartTuru = KartTuru.Banka;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<BankaEditForm>();

            if (IsMdiChild)
                ShowItems = new BarItem[] { btnBagliKartlar };
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((BankaBll)Bll).List(FilterFunctions.Filter<Banka>(AktifKartlariGoster));
        }

        protected override void BagliKartAc()
        {
            var entity = Tablo.GetRow<BankaL>();
            if (entity == null) return;
            ShowListForms<BankaSubeListForm>.ShowListForm(KartTuru.BankaSube, entity.Id, entity.BankaAdi);
        }
    }
}