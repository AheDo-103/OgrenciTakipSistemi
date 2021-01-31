using AhdYazilim.OgrenciTakip.Common.Enums;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.UI.Win.Show
{
    public class ShowRibbonForms<TForm> where TForm : RibbonForm
    {
        public static void ShowForm(bool dialog, params object[] prm)
        {
            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);
            if (dialog)
                using (frm)
                    frm.ShowDialog();
            else
                frm.Show();
        }

        public static long ShowDialogForm(KartTuru kartTuru, params object[] prm)
        {
            // Yetki Kontrolü

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                //frm.KartTuru = kartTuru;
                frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? (long)frm.Tag : 0;
            }
        }
    }
}