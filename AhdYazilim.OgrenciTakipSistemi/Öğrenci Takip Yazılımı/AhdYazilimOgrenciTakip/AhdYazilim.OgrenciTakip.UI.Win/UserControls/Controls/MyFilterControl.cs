using AhdYazilim.OgrenciTakip.UI.Win.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyFilterControl : FilterControl, IStatusBarAciklama
    {
        public MyFilterControl()
        {
            ShowGroupCommandsIcon = true;
        }

        public string StatusBarAciklama { get; set; } = "Filtre Metni Giriniz.";
    }
}
