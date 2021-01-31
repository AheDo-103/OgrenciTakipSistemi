using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using AhdYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.UI.Win.Show
{
    public class ShowListForms<TForm> where TForm : BaseKartlarForm
    {
        public static void ShowListForm(KartTuru kartTuru)
        {
            // Yetki Kontrolü

            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();
        }

        public static void ShowListForm(KartTuru kartTuru, params object[] prm)
        {
            // Yetki Kontrolü

            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();
        }

        //public static void ShowDialogListForm(KartTuru kartTuru, params object[] prm)
        //{
        //    // Yetki Kontrolü

        //    using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
        //    {
        //        frm.Yukle();
        //        frm.ShowDialog();
        //    }
        //}

        public static BaseEntity ShowDialogListForm(KartTuru kartTuru, long? seciliGelecekId, params object[] prm)
        {
            // Yetki Kontrolü

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.SeciliGelecekId = seciliGelecekId;

                frm.Yukle();
                if (!frm.IsDisposed)
                    frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntity : null;
            }
        }

        public static IEnumerable<IBaseEntity> ShowDialogListForm(KartTuru kartTuru, IList<long> listeDisiTutulacakKayitlar, bool multiSelect, params object[] prm)
        {
            // Yetki Kontrolü

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.ListeDisiTutulacakKayitlar = listeDisiTutulacakKayitlar;
                frm.MultiSelect = multiSelect;
                frm.Yukle();
                frm.RowSelect = new SelectRowFunctions(frm.Tablo);

                if (frm.EklenebilecekEntityVar)
                    frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            }
        }

        public static IEnumerable<IBaseEntity> ShowDialogListForm(KartTuru kartTuru, bool multiSelect, params object[] prm)
        {
            // Yetki Kontrolü

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.MultiSelect = multiSelect;
                frm.Yukle();
                frm.RowSelect = new SelectRowFunctions(frm.Tablo);

                if (frm.Tablo.DataRowCount != -1)
                    frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            }
        }
    }
}
