using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Message;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;
using System.Linq;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.MakbuzForms
{
    public partial class BelgeHareketleriListForm : BaseKartlarForm
    {
        #region Variables

        private readonly int _odemeBilgileriId;

        #endregion


        public BelgeHareketleriListForm(params object[] prm)
        {
            InitializeComponent();

            HideItems = new BarItem[] { btnYeni, btnSil, btnSec, barInsert, barInsertAciklama, barDelete, barDeleteAciklama, barEnter, barEnterAciklama };
            _odemeBilgileriId = (int)prm[0];
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            KartTuru = KartTuru.BelgeHareketleri;
            Navigator = longNavigator.Navigator;
            Navigator.TextStringFormat = "Belge Hareketleri ( {0} / {1} )";
        }

        protected override void Listele()
        {
            using (var bll = new BelgeHareketleriBll())
            {
                var list = bll.List(x => x.OdemeBilgileriId == _odemeBilgileriId).Cast<BelgeHareketleriL>().ToList();
                if (!list.Any())
                {
                    Messages.UyariMesaji("Seçmiş Olduğunuz Ödeme Belgesine Ait Hareket Bulunmamaktadır.");
                    Close();
                    return;
                }

                var entity = list[0];
                txtNo.Text = entity.OgrenciNo;
                txtAdi.Text = entity.Adi;
                txtSoyadi.Text = entity.Soyadi;
                txtSinif.Text = entity.SinifAdi;
                txtSube.Text = entity.OgrenciSubeAdi;
                txtPortfoyNo.EditValue = entity.OdemeBilgileriId;
                txtOdemeTuru.Text = entity.OdemeTuruAdi;
                txtGirisTarihi.EditValue = entity.GirisTarihi;
                txtVade.EditValue = entity.Vade;
                txtHesabaGecisTarihi.EditValue = entity.HesabaGecisTarihi;
                txtIslemTutari.Value = entity.Tutar;
                txtAsilBorclu.Text = entity.AsilBorclu;
                txtCiranta.Text = entity.Ciranta;
                txtBanka.Text = entity.BankaAdi;
                txtBankaSube.Text = entity.BankaSubeAdi;
                txtHesapNo.Text = entity.HesapNo;
                txtBelgeNo.Text = entity.BelgeNo;

                tablo.GridControl.DataSource = list;
            }
        }

        protected override void ShowEditForm(long id)
        {
            var entity = tablo.GetRow<BelgeHareketleriL>();
            if (entity == null) return;

            if (entity.SubeId != AnaForm.SubeId)
                ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, entity.Id, entity.MakbuzTuru, entity.HesapTuru, true);
            else
            {
                var result = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, entity.Id, entity.MakbuzTuru, entity.HesapTuru);
                ShowEditFormDefault(result);
            }
        }

        protected override void SelectEntity() { return; }
    }
}