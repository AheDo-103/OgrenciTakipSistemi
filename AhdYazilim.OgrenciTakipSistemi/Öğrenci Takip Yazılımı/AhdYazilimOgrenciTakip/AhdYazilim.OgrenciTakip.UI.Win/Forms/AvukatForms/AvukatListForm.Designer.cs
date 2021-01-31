namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.AvukatForms
{
    partial class AvukatListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvukatListForm));
            this.longNavigator = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
            this.tablo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colKod = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colAvukatAdiSoyadi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSozlesmeNo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colSozlesmeBaslamaTarihi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colSozlesmeBitisTarihi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOzelKod1 = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colOzelKod2 = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAciklama = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colId = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Size = new System.Drawing.Size(1115, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 492);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1115, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTarih});
            this.grid.Size = new System.Drawing.Size(1115, 390);
            this.grid.TabIndex = 3;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.tablo.Appearance.BandPanel.Options.UseFont = true;
            this.tablo.Appearance.BandPanel.Options.UseForeColor = true;
            this.tablo.Appearance.BandPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.BandPanelRowHeight = 40;
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colAvukatAdiSoyadi,
            this.colSozlesmeNo,
            this.colSozlesmeBaslamaTarihi,
            this.colSozlesmeBitisTarihi,
            this.colOzelKod1,
            this.colOzelKod2,
            this.colAciklama});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Avukat Kartı";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Avukat Bilgileri";
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colAvukatAdiSoyadi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 420;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.OptionsColumn.ShowInCustomizationForm = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYol = null;
            this.colKod.StatusBarKisaYolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.Width = 150;
            // 
            // colAvukatAdiSoyadi
            // 
            this.colAvukatAdiSoyadi.Caption = "Adı Soyadı";
            this.colAvukatAdiSoyadi.CustomizationCaption = "Avukat Adı Soyadı";
            this.colAvukatAdiSoyadi.FieldName = "AdiSoyadi";
            this.colAvukatAdiSoyadi.Name = "colAvukatAdiSoyadi";
            this.colAvukatAdiSoyadi.OptionsColumn.AllowEdit = false;
            this.colAvukatAdiSoyadi.StatusBarAciklama = null;
            this.colAvukatAdiSoyadi.StatusBarKisaYol = null;
            this.colAvukatAdiSoyadi.StatusBarKisaYolAciklama = null;
            this.colAvukatAdiSoyadi.Visible = true;
            this.colAvukatAdiSoyadi.Width = 270;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Sözleşme Bilgileri";
            this.gridBand2.Columns.Add(this.colSozlesmeNo);
            this.gridBand2.Columns.Add(this.colSozlesmeBaslamaTarihi);
            this.gridBand2.Columns.Add(this.colSozlesmeBitisTarihi);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 410;
            // 
            // colSozlesmeNo
            // 
            this.colSozlesmeNo.Caption = "Sözleşme No";
            this.colSozlesmeNo.FieldName = "SozlesmeNo";
            this.colSozlesmeNo.Name = "colSozlesmeNo";
            this.colSozlesmeNo.OptionsColumn.AllowEdit = false;
            this.colSozlesmeNo.StatusBarAciklama = null;
            this.colSozlesmeNo.StatusBarKisaYol = null;
            this.colSozlesmeNo.StatusBarKisaYolAciklama = null;
            this.colSozlesmeNo.Visible = true;
            this.colSozlesmeNo.Width = 170;
            // 
            // colSozlesmeBaslamaTarihi
            // 
            this.colSozlesmeBaslamaTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colSozlesmeBaslamaTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSozlesmeBaslamaTarihi.Caption = "Başlama Tarihi";
            this.colSozlesmeBaslamaTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colSozlesmeBaslamaTarihi.CustomizationCaption = "Sözleşme Başlama Tarihi";
            this.colSozlesmeBaslamaTarihi.FieldName = "SozlesmeBaslamaTarihi";
            this.colSozlesmeBaslamaTarihi.Name = "colSozlesmeBaslamaTarihi";
            this.colSozlesmeBaslamaTarihi.OptionsColumn.AllowEdit = false;
            this.colSozlesmeBaslamaTarihi.StatusBarAciklama = null;
            this.colSozlesmeBaslamaTarihi.StatusBarKisaYol = null;
            this.colSozlesmeBaslamaTarihi.StatusBarKisaYolAciklama = null;
            this.colSozlesmeBaslamaTarihi.Visible = true;
            this.colSozlesmeBaslamaTarihi.Width = 120;
            // 
            // repositoryItemTarih
            // 
            this.repositoryItemTarih.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTarih.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemTarih.AutoHeight = false;
            this.repositoryItemTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemTarih.Name = "repositoryItemTarih";
            // 
            // colSozlesmeBitisTarihi
            // 
            this.colSozlesmeBitisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colSozlesmeBitisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSozlesmeBitisTarihi.Caption = "Bitiş Tarihi";
            this.colSozlesmeBitisTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colSozlesmeBitisTarihi.CustomizationCaption = "Sözleşme Bitiş Tarihi";
            this.colSozlesmeBitisTarihi.FieldName = "SozlesmeBitisTarihi";
            this.colSozlesmeBitisTarihi.Name = "colSozlesmeBitisTarihi";
            this.colSozlesmeBitisTarihi.OptionsColumn.AllowEdit = false;
            this.colSozlesmeBitisTarihi.StatusBarAciklama = null;
            this.colSozlesmeBitisTarihi.StatusBarKisaYol = null;
            this.colSozlesmeBitisTarihi.StatusBarKisaYolAciklama = null;
            this.colSozlesmeBitisTarihi.Visible = true;
            this.colSozlesmeBitisTarihi.Width = 120;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Özel Kod Bilgileri";
            this.gridBand3.Columns.Add(this.colOzelKod1);
            this.gridBand3.Columns.Add(this.colOzelKod2);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 360;
            // 
            // colOzelKod1
            // 
            this.colOzelKod1.Caption = "Özel Kod-1";
            this.colOzelKod1.FieldName = "OzelKod1Adi";
            this.colOzelKod1.Name = "colOzelKod1";
            this.colOzelKod1.OptionsColumn.AllowEdit = false;
            this.colOzelKod1.StatusBarAciklama = null;
            this.colOzelKod1.StatusBarKisaYol = null;
            this.colOzelKod1.StatusBarKisaYolAciklama = null;
            this.colOzelKod1.Visible = true;
            this.colOzelKod1.Width = 180;
            // 
            // colOzelKod2
            // 
            this.colOzelKod2.Caption = "Özel Kod-2";
            this.colOzelKod2.FieldName = "OzelKod2Adi";
            this.colOzelKod2.Name = "colOzelKod2";
            this.colOzelKod2.OptionsColumn.AllowEdit = false;
            this.colOzelKod2.StatusBarAciklama = null;
            this.colOzelKod2.StatusBarKisaYol = null;
            this.colOzelKod2.StatusBarKisaYolAciklama = null;
            this.colOzelKod2.Visible = true;
            this.colOzelKod2.Width = 180;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Ek Bilgiler";
            this.gridBand4.Columns.Add(this.colAciklama);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 350;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisaYol = null;
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.Width = 350;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisaYol = null;
            this.colId.StatusBarKisaYolAciklama = null;
            // 
            // AvukatListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 547);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "AvukatListForm";
            this.Text = "Avukat Kartı";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyBandedGridControl grid;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridView tablo;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colId;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colKod;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colAvukatAdiSoyadi;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colSozlesmeNo;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colOzelKod1;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colOzelKod2;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colSozlesmeBaslamaTarihi;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colSozlesmeBitisTarihi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colAciklama;
    }
}