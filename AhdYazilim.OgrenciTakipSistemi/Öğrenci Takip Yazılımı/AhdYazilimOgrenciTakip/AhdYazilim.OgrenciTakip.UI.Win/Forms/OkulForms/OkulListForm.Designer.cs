﻿namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.OkulForms
{
    partial class OkulListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OkulListForm));
            this.grid = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
            this.tablo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
            this.colId = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colKod = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colOkulAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIlAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIlceAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colAciklama = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.longNavigator = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.barKolonlar = new DevExpress.XtraBars.BarStaticItem();
            this.barKolonlarAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.barYazdir = new DevExpress.XtraBars.BarStaticItem();
            this.barYazdirAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.barCikis = new DevExpress.XtraBars.BarStaticItem();
            this.barCikisAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.barGonder = new DevExpress.XtraBars.BarStaticItem();
            this.barGonderAciklama = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barKolonlar,
            this.barKolonlarAciklama,
            this.barYazdir,
            this.barYazdirAciklama,
            this.barCikis,
            this.barCikisAciklama,
            this.barGonder,
            this.barGonderAciklama});
            this.ribbonControl.MaxItemId = 37;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Size = new System.Drawing.Size(1090, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // btnYeniMakbuz
            // 
            this.btnYeniMakbuz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniMakbuz.ImageOptions.Image")));
            this.btnYeniMakbuz.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYeniMakbuz.ImageOptions.LargeImage")));
            // 
            // btnYeniRapor
            // 
            this.btnYeniRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniRapor.ImageOptions.Image")));
            this.btnYeniRapor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYeniRapor.ImageOptions.LargeImage")));
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1090, 442);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
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
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKod,
            this.colOkulAdi,
            this.colIlAdi,
            this.colIlceAdi,
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
            this.tablo.ViewCaption = "Okul Kartları";
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
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYol = null;
            this.colKod.StatusBarKisaYolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 130;
            // 
            // colOkulAdi
            // 
            this.colOkulAdi.Caption = "Okul Adı";
            this.colOkulAdi.FieldName = "OkulAdi";
            this.colOkulAdi.Name = "colOkulAdi";
            this.colOkulAdi.OptionsColumn.AllowEdit = false;
            this.colOkulAdi.StatusBarAciklama = null;
            this.colOkulAdi.StatusBarKisaYol = null;
            this.colOkulAdi.StatusBarKisaYolAciklama = null;
            this.colOkulAdi.Visible = true;
            this.colOkulAdi.VisibleIndex = 1;
            this.colOkulAdi.Width = 283;
            // 
            // colIlAdi
            // 
            this.colIlAdi.Caption = "İl";
            this.colIlAdi.FieldName = "IlAdi";
            this.colIlAdi.Name = "colIlAdi";
            this.colIlAdi.OptionsColumn.AllowEdit = false;
            this.colIlAdi.StatusBarAciklama = null;
            this.colIlAdi.StatusBarKisaYol = null;
            this.colIlAdi.StatusBarKisaYolAciklama = null;
            this.colIlAdi.Visible = true;
            this.colIlAdi.VisibleIndex = 2;
            this.colIlAdi.Width = 130;
            // 
            // colIlceAdi
            // 
            this.colIlceAdi.Caption = "İlçe";
            this.colIlceAdi.FieldName = "IlceAdi";
            this.colIlceAdi.Name = "colIlceAdi";
            this.colIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIlceAdi.StatusBarAciklama = null;
            this.colIlceAdi.StatusBarKisaYol = null;
            this.colIlceAdi.StatusBarKisaYolAciklama = null;
            this.colIlceAdi.Visible = true;
            this.colIlceAdi.VisibleIndex = 3;
            this.colIlceAdi.Width = 130;
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
            this.colAciklama.VisibleIndex = 4;
            this.colAciklama.Width = 450;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 544);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1090, 24);
            this.longNavigator.TabIndex = 3;
            // 
            // barKolonlar
            // 
            this.barKolonlar.Caption = "Ctrl+O : ";
            this.barKolonlar.Id = 29;
            this.barKolonlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barKolonlar.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barKolonlar.ItemAppearance.Normal.Options.UseFont = true;
            this.barKolonlar.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barKolonlar.Name = "barKolonlar";
            // 
            // barKolonlarAciklama
            // 
            this.barKolonlarAciklama.Caption = "Kolonlar";
            this.barKolonlarAciklama.Id = 30;
            this.barKolonlarAciklama.Name = "barKolonlarAciklama";
            // 
            // barYazdir
            // 
            this.barYazdir.Caption = "Ctrl+P : ";
            this.barYazdir.Id = 31;
            this.barYazdir.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barYazdir.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barYazdir.ItemAppearance.Normal.Options.UseFont = true;
            this.barYazdir.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barYazdir.Name = "barYazdir";
            // 
            // barYazdirAciklama
            // 
            this.barYazdirAciklama.Caption = "Yazdır";
            this.barYazdirAciklama.Id = 32;
            this.barYazdirAciklama.Name = "barYazdirAciklama";
            // 
            // barCikis
            // 
            this.barCikis.Caption = "Esc : ";
            this.barCikis.Id = 33;
            this.barCikis.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barCikis.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barCikis.ItemAppearance.Normal.Options.UseFont = true;
            this.barCikis.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barCikis.Name = "barCikis";
            // 
            // barCikisAciklama
            // 
            this.barCikisAciklama.Caption = "Çıkış";
            this.barCikisAciklama.Id = 34;
            this.barCikisAciklama.Name = "barCikisAciklama";
            // 
            // barGonder
            // 
            this.barGonder.Caption = "F12 : ";
            this.barGonder.Id = 35;
            this.barGonder.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barGonder.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barGonder.ItemAppearance.Normal.Options.UseFont = true;
            this.barGonder.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barGonder.Name = "barGonder";
            // 
            // barGonderAciklama
            // 
            this.barGonderAciklama.Caption = "Gönder";
            this.barGonderAciklama.Id = 36;
            this.barGonderAciklama.Name = "barGonderAciklama";
            // 
            // OkulListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 599);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "OkulListForm";
            this.Text = "Okul Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colKod;
        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyGridColumn colIlAdi;
        private UserControls.Grid.MyGridColumn colIlceAdi;
        private UserControls.Grid.MyGridColumn colAciklama;
        private DevExpress.XtraBars.BarStaticItem barKolonlar;
        private DevExpress.XtraBars.BarStaticItem barKolonlarAciklama;
        private DevExpress.XtraBars.BarStaticItem barYazdir;
        private DevExpress.XtraBars.BarStaticItem barYazdirAciklama;
        private DevExpress.XtraBars.BarStaticItem barCikis;
        private DevExpress.XtraBars.BarStaticItem barCikisAciklama;
        private DevExpress.XtraBars.BarStaticItem barGonder;
        private DevExpress.XtraBars.BarStaticItem barGonderAciklama;
        private UserControls.Grid.MyGridColumn colOkulAdi;
    }
}