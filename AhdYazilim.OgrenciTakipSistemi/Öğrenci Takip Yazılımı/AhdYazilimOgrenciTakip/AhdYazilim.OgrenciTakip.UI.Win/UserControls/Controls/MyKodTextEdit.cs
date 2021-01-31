using AhdYazilim.OgrenciTakip.UI.Win.Interfaces;
using DevExpress.Utils;
using System.ComponentModel;
using System.Drawing;

namespace AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyKodTextEdit : MyTextEdit, IStatusBarAciklama
    {
        public MyKodTextEdit()
        {
            Properties.Appearance.BackColor = Color.PaleGoldenrod;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.MaxLength = 20;

            StatusBarAciklama = "Kod Giriniz.";
        }
    }
}
