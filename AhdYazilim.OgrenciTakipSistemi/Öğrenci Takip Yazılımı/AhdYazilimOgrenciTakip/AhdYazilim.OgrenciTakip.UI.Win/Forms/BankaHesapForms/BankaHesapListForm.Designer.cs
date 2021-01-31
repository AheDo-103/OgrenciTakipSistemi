namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.BankaHesapForms
{
    partial class BankaHesapListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankaHesapListForm));
            this.longNavigator = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
            this.tablo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colKod = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colHesapAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colHesapTuru = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colBankaAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colBankaSubeAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colHesapAcilisTarihi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBlokeGunSayisi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colHesapNo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colIbanNo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colIsYeriNo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colTerminalNo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
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
            this.longNavigator.Location = new System.Drawing.Point(0, 442);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1124, 24);
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
            this.grid.Size = new System.Drawing.Size(1124, 340);
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
            this.colHesapAdi,
            this.colHesapTuru,
            this.colBankaAdi,
            this.colBankaSubeAdi,
            this.colHesapAcilisTarihi,
            this.colHesapNo,
            this.colIbanNo,
            this.colBlokeGunSayisi,
            this.colIsYeriNo,
            this.colTerminalNo,
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
            this.tablo.ViewCaption = "Banka Hesap Kartları";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Hesap Bilgileri";
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colHesapAdi);
            this.gridBand1.Columns.Add(this.colHesapTuru);
            this.gridBand1.Columns.Add(this.colBankaAdi);
            this.gridBand1.Columns.Add(this.colBankaSubeAdi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 820;
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
            // colHesapAdi
            // 
            this.colHesapAdi.Caption = "Hesap Adı";
            this.colHesapAdi.CustomizationCaption = "Banka Hesap Adı";
            this.colHesapAdi.FieldName = "HesapAdi";
            this.colHesapAdi.Name = "colHesapAdi";
            this.colHesapAdi.OptionsColumn.AllowEdit = false;
            this.colHesapAdi.StatusBarAciklama = null;
            this.colHesapAdi.StatusBarKisaYol = null;
            this.colHesapAdi.StatusBarKisaYolAciklama = null;
            this.colHesapAdi.Visible = true;
            this.colHesapAdi.Width = 220;
            // 
            // colHesapTuru
            // 
            this.colHesapTuru.Caption = "Hesap Türü";
            this.colHesapTuru.CustomizationCaption = "Banka Hesap Türü";
            this.colHesapTuru.FieldName = "HesapTuru";
            this.colHesapTuru.Name = "colHesapTuru";
            this.colHesapTuru.OptionsColumn.AllowEdit = false;
            this.colHesapTuru.StatusBarAciklama = null;
            this.colHesapTuru.StatusBarKisaYol = null;
            this.colHesapTuru.StatusBarKisaYolAciklama = null;
            this.colHesapTuru.Visible = true;
            this.colHesapTuru.Width = 150;
            // 
            // colBankaAdi
            // 
            this.colBankaAdi.Caption = "Banka Adı";
            this.colBankaAdi.FieldName = "BankaAdi";
            this.colBankaAdi.Name = "colBankaAdi";
            this.colBankaAdi.OptionsColumn.AllowEdit = false;
            this.colBankaAdi.StatusBarAciklama = null;
            this.colBankaAdi.StatusBarKisaYol = null;
            this.colBankaAdi.StatusBarKisaYolAciklama = null;
            this.colBankaAdi.Visible = true;
            this.colBankaAdi.Width = 150;
            // 
            // colBankaSubeAdi
            // 
            this.colBankaSubeAdi.Caption = "Banka Şube Adı";
            this.colBankaSubeAdi.FieldName = "BankaSubeAdi";
            this.colBankaSubeAdi.Name = "colBankaSubeAdi";
            this.colBankaSubeAdi.OptionsColumn.AllowEdit = false;
            this.colBankaSubeAdi.StatusBarAciklama = null;
            this.colBankaSubeAdi.StatusBarKisaYol = null;
            this.colBankaSubeAdi.StatusBarKisaYolAciklama = null;
            this.colBankaSubeAdi.Visible = true;
            this.colBankaSubeAdi.Width = 150;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Hesap Detay Bilgileri";
            this.gridBand2.Columns.Add(this.colHesapAcilisTarihi);
            this.gridBand2.Columns.Add(this.colBlokeGunSayisi);
            this.gridBand2.Columns.Add(this.colHesapNo);
            this.gridBand2.Columns.Add(this.colIbanNo);
            this.gridBand2.Columns.Add(this.colIsYeriNo);
            this.gridBand2.Columns.Add(this.colTerminalNo);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 790;
            // 
            // colHesapAcilisTarihi
            // 
            this.colHesapAcilisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colHesapAcilisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHesapAcilisTarihi.Caption = "Açılış Tarihi";
            this.colHesapAcilisTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colHesapAcilisTarihi.CustomizationCaption = "Hesap Açılış Tarihi";
            this.colHesapAcilisTarihi.FieldName = "HesapAcilisTarihi";
            this.colHesapAcilisTarihi.Name = "colHesapAcilisTarihi";
            this.colHesapAcilisTarihi.OptionsColumn.AllowEdit = false;
            this.colHesapAcilisTarihi.StatusBarAciklama = null;
            this.colHesapAcilisTarihi.StatusBarKisaYol = null;
            this.colHesapAcilisTarihi.StatusBarKisaYolAciklama = null;
            this.colHesapAcilisTarihi.Visible = true;
            this.colHesapAcilisTarihi.Width = 120;
            // 
            // repositoryItemTarih
            // 
            this.repositoryItemTarih.AutoHeight = false;
            this.repositoryItemTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemTarih.Name = "repositoryItemTarih";
            // 
            // colBlokeGunSayisi
            // 
            this.colBlokeGunSayisi.Caption = "Bloke Gün Sayısı";
            this.colBlokeGunSayisi.FieldName = "BlokeGunSayisi";
            this.colBlokeGunSayisi.Name = "colBlokeGunSayisi";
            this.colBlokeGunSayisi.OptionsColumn.AllowEdit = false;
            this.colBlokeGunSayisi.StatusBarAciklama = null;
            this.colBlokeGunSayisi.StatusBarKisaYol = null;
            this.colBlokeGunSayisi.StatusBarKisaYolAciklama = null;
            this.colBlokeGunSayisi.Visible = true;
            this.colBlokeGunSayisi.Width = 120;
            // 
            // colHesapNo
            // 
            this.colHesapNo.Caption = "Hesap No";
            this.colHesapNo.FieldName = "HesapNo";
            this.colHesapNo.Name = "colHesapNo";
            this.colHesapNo.OptionsColumn.AllowEdit = false;
            this.colHesapNo.StatusBarAciklama = null;
            this.colHesapNo.StatusBarKisaYol = null;
            this.colHesapNo.StatusBarKisaYolAciklama = null;
            this.colHesapNo.Visible = true;
            this.colHesapNo.Width = 150;
            // 
            // colIbanNo
            // 
            this.colIbanNo.Caption = "İban No";
            this.colIbanNo.FieldName = "IbanNo";
            this.colIbanNo.Name = "colIbanNo";
            this.colIbanNo.OptionsColumn.AllowEdit = false;
            this.colIbanNo.StatusBarAciklama = null;
            this.colIbanNo.StatusBarKisaYol = null;
            this.colIbanNo.StatusBarKisaYolAciklama = null;
            this.colIbanNo.Visible = true;
            this.colIbanNo.Width = 200;
            // 
            // colIsYeriNo
            // 
            this.colIsYeriNo.Caption = "İşyeri No";
            this.colIsYeriNo.FieldName = "IsYeriNo";
            this.colIsYeriNo.Name = "colIsYeriNo";
            this.colIsYeriNo.OptionsColumn.AllowEdit = false;
            this.colIsYeriNo.StatusBarAciklama = null;
            this.colIsYeriNo.StatusBarKisaYol = null;
            this.colIsYeriNo.StatusBarKisaYolAciklama = null;
            this.colIsYeriNo.Visible = true;
            this.colIsYeriNo.Width = 100;
            // 
            // colTerminalNo
            // 
            this.colTerminalNo.Caption = "Terminal No";
            this.colTerminalNo.FieldName = "TerminalNo";
            this.colTerminalNo.Name = "colTerminalNo";
            this.colTerminalNo.OptionsColumn.AllowEdit = false;
            this.colTerminalNo.StatusBarAciklama = null;
            this.colTerminalNo.StatusBarKisaYol = null;
            this.colTerminalNo.StatusBarKisaYolAciklama = null;
            this.colTerminalNo.Visible = true;
            this.colTerminalNo.Width = 100;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Özel Kod";
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
            // BankaHesapListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 497);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "BankaHesapListForm";
            this.Text = "Banka Hesap Kartları";
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
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colHesapAdi;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colHesapTuru;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colBankaAdi;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colBankaSubeAdi;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colHesapAcilisTarihi;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colHesapNo;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colIbanNo;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colBlokeGunSayisi;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colIsYeriNo;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colTerminalNo;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colAciklama;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colOzelKod1;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colOzelKod2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
    }
}