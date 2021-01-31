using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using DevExpress.XtraBars;
using System.Drawing;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.OgrenciForms
{
    public partial class ResimTamEkran : BaseEditForm
    {
        #region Variables

        private byte[] _resimByte;
        private string _adSoyad;

        #endregion

        public ResimTamEkran()
        {
            InitializeComponent();

            ShowItems = new BarItem[] { btnDondur };
            HideItems = new BarItem[] { btnYeni, btnSil, btnGeriAl, btnUygula, btnBaskiOnizleme, btnYazdir, btnKaydet, btnFarkliKaydet, btnTaksitOlustur };
            EventsLoad();
        }

        public ResimTamEkran(params object[] prm) : this()
        {
            _resimByte = (byte[])prm[0];
            _adSoyad = prm[1].ToString();

            ResimYukle(_resimByte);
            this.Text = $"{Text} - {_adSoyad}";
        }

        private void ResimYukle(byte[] array)
        {
            pictureEditOgrenciResimTamEkran.EditValue = array;
        }

        protected override void ResimDondur()
        {
            pictureEditOgrenciResimTamEkran.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }
    }
}