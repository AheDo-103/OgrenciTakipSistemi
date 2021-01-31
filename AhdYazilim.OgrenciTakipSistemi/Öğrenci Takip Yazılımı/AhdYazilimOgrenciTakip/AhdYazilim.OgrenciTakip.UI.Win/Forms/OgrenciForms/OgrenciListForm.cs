using AhdYazilim.OgrenciTakip.Bll.Functions;
using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.Tahakkuk_Forms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.OgrenciForms
{
    public partial class OgrenciListForm : BaseKartlarForm
    {
        public OgrenciListForm()
        {
            InitializeComponent();

            Bll = new OgrenciBll();
            ShowItems = new BarItem[] { btnTahakkukYap };
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<OgrenciEditForm>();
            KartTuru = KartTuru.Ogrenci;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((OgrenciBll)Bll).List(FilterFunctions.Filter<Ogrenci>(AktifKartlariGoster));
        }

        protected override void TahakkukYap()
        {
            var entity = Tablo.GetRow<OgrenciL>().EntityConvert<Ogrenci>();
            using (var bll = new TahakkukBll())
            {
                var tahakkuk = bll.SingleSummary(x => x.OgrenciId == entity.Id && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
                if (tahakkuk != null)
                    ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, tahakkuk.Id);
                else
                    ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, -1, entity);
            }
        }
    }
}