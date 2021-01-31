using AhdYazilim.OgrenciTakip.UI.Win.Interfaces;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using System.ComponentModel;
using System.Drawing;

namespace AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid
{
    [ToolboxItem(true)]
    public class MyBandedGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            /*
              * Banded Grid Control form ekranına sürüklendiği zaman default view'ı kullanıcak. 
              * Bizde kendimize yeni bir view açarak onu kullanmasını sağlıycağız.
            */
            var view = (MyBandedGridView)CreateView("MyBandedGridView");


            // View Ayarlamaları
            view.Appearance.BandPanel.ForeColor = Color.DarkBlue;
            view.Appearance.BandPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);
            view.Appearance.BandPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.BandPanelRowHeight = 40;

            view.Appearance.ViewCaption.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;

            view.Appearance.FooterPanel.ForeColor = Color.Maroon;
            view.Appearance.FooterPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);

            view.OptionsMenu.EnableColumnMenu = false;
            view.OptionsMenu.EnableFooterMenu = false;
            view.OptionsMenu.EnableGroupPanelMenu = false;

            view.OptionsNavigation.EnterMoveNextColumn = true;

            view.OptionsPrint.AutoWidth = false;
            view.OptionsPrint.PrintFooter = false;
            view.OptionsPrint.PrintGroupFooter = false;

            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowViewCaption = true;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.ColumnAutoWidth = false;
            view.OptionsView.RowAutoHeight = true;
            view.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button;

            var columns = new[]
            {
                new MyBandedGridColumn
                {
                    Caption = "Id",
                    FieldName = "Id",
                    OptionsColumn = { AllowEdit = false, ShowInCustomizationForm = false }

                },
                new MyBandedGridColumn
                {
                    Caption = "Kod",
                    FieldName = "Kod",
                    Visible = true,
                    OptionsColumn = { AllowEdit = false, ShowInCustomizationForm = false },
                    AppearanceCell = { TextOptions = { HAlignment = HorzAlignment.Center }, Options = { UseTextOptions = true } }
                }
            };

            view.Columns.AddRange(columns);

            return view;
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyBandedGridInfoRegister());
        }

        private class MyBandedGridInfoRegister : BandedGridInfoRegistrator
        {
            public override string ViewName => "MyBandedGridView";
            public override BaseView CreateView(GridControl grid) => new MyBandedGridView(grid);
        }

        public class MyBandedGridView : BandedGridView, IStatusBarKisaYol
        {
            #region Properties
            public string StatusBarKisaYol { get; set; }
            public string StatusBarKisaYolAciklama { get; set; }
            public string StatusBarAciklama { get; set; }
            #endregion

            public MyBandedGridView() { }

            public MyBandedGridView(GridControl ownerGrid) : base(ownerGrid)
            {
            }

            protected override void OnColumnChangedCore(GridColumn column)
            {
                base.OnColumnChangedCore(column);

                if (column.ColumnEdit == null) return;
                if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
                {
                    column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                    ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
                }
            }

            protected override GridColumnCollection CreateColumnCollection()
            {
                return new MyGridColumnCollection(this);
            }

            private class MyGridColumnCollection : BandedGridColumnCollection
            {
                public MyGridColumnCollection(ColumnView view) : base(view) { }

                protected override GridColumn CreateColumn()
                {
                    // Yeni oluşucak kolon ve o kolonun özellikleri
                    var column = new MyBandedGridColumn();
                    column.OptionsColumn.AllowEdit = false;

                    return column;
                }
            }
        }

        public class MyBandedGridColumn : BandedGridColumn, IStatusBarKisaYol
        {
            #region Properties
            public string StatusBarKisaYol { get; set; }
            public string StatusBarKisaYolAciklama { get; set; }
            public string StatusBarAciklama { get; set; }
            #endregion
        }
    }
}
