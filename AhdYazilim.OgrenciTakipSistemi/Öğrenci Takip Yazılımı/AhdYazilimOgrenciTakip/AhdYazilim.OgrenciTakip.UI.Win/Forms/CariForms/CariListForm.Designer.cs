namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.CariForms
{
    partial class CariListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariListForm));
            this.longNavigator = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
            this.tablo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colKod = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colTcKimlikNo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colCariAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colTelefon1 = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colTelefon2 = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colTelefon3 = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colTelefon4 = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colFaks = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colWeb = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colEmail = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colVergiDairesi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colVergiNo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colAdres = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOzelKod1 = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colOzelKod2 = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAciklama = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colId = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(1107, 102);
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
            this.longNavigator.Location = new System.Drawing.Point(0, 504);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1107, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1107, 402);
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
            this.gridBand3});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colCariAdi,
            this.colTcKimlikNo,
            this.colTelefon1,
            this.colTelefon2,
            this.colTelefon3,
            this.colTelefon4,
            this.colFaks,
            this.colWeb,
            this.colEmail,
            this.colVergiDairesi,
            this.colVergiNo,
            this.colAdres,
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
            this.tablo.ViewCaption = "Cari Kartları";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Cari Bilgileri";
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colTcKimlikNo);
            this.gridBand1.Columns.Add(this.colCariAdi);
            this.gridBand1.Columns.Add(this.colTelefon1);
            this.gridBand1.Columns.Add(this.colTelefon2);
            this.gridBand1.Columns.Add(this.colTelefon3);
            this.gridBand1.Columns.Add(this.colTelefon4);
            this.gridBand1.Columns.Add(this.colFaks);
            this.gridBand1.Columns.Add(this.colWeb);
            this.gridBand1.Columns.Add(this.colEmail);
            this.gridBand1.Columns.Add(this.colVergiDairesi);
            this.gridBand1.Columns.Add(this.colVergiNo);
            this.gridBand1.Columns.Add(this.colAdres);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 810;
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
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.AppearanceCell.Options.UseTextOptions = true;
            this.colTcKimlikNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTcKimlikNo.Caption = "Tc Kimlik No";
            this.colTcKimlikNo.CustomizationCaption = "Tc Kimlik Numarsı";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.StatusBarAciklama = null;
            this.colTcKimlikNo.StatusBarKisaYol = null;
            this.colTcKimlikNo.StatusBarKisaYolAciklama = null;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.Width = 150;
            // 
            // colCariAdi
            // 
            this.colCariAdi.Caption = "Cari Adı";
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.OptionsColumn.AllowEdit = false;
            this.colCariAdi.StatusBarAciklama = null;
            this.colCariAdi.StatusBarKisaYol = null;
            this.colCariAdi.StatusBarKisaYolAciklama = null;
            this.colCariAdi.Visible = true;
            this.colCariAdi.Width = 270;
            // 
            // colTelefon1
            // 
            this.colTelefon1.AppearanceCell.Options.UseTextOptions = true;
            this.colTelefon1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTelefon1.Caption = "Telefon-1";
            this.colTelefon1.FieldName = "Telefon1";
            this.colTelefon1.Name = "colTelefon1";
            this.colTelefon1.OptionsColumn.AllowEdit = false;
            this.colTelefon1.StatusBarAciklama = null;
            this.colTelefon1.StatusBarKisaYol = null;
            this.colTelefon1.StatusBarKisaYolAciklama = null;
            this.colTelefon1.Visible = true;
            this.colTelefon1.Width = 120;
            // 
            // colTelefon2
            // 
            this.colTelefon2.AppearanceCell.Options.UseTextOptions = true;
            this.colTelefon2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTelefon2.Caption = "Telefon-2";
            this.colTelefon2.FieldName = "Telefon2";
            this.colTelefon2.Name = "colTelefon2";
            this.colTelefon2.OptionsColumn.AllowEdit = false;
            this.colTelefon2.StatusBarAciklama = null;
            this.colTelefon2.StatusBarKisaYol = null;
            this.colTelefon2.StatusBarKisaYolAciklama = null;
            this.colTelefon2.Visible = true;
            this.colTelefon2.Width = 120;
            // 
            // colTelefon3
            // 
            this.colTelefon3.AppearanceCell.Options.UseTextOptions = true;
            this.colTelefon3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTelefon3.Caption = "Telefon-3";
            this.colTelefon3.FieldName = "Telefon3";
            this.colTelefon3.Name = "colTelefon3";
            this.colTelefon3.OptionsColumn.AllowEdit = false;
            this.colTelefon3.StatusBarAciklama = null;
            this.colTelefon3.StatusBarKisaYol = null;
            this.colTelefon3.StatusBarKisaYolAciklama = null;
            this.colTelefon3.Width = 120;
            // 
            // colTelefon4
            // 
            this.colTelefon4.AppearanceCell.Options.UseTextOptions = true;
            this.colTelefon4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTelefon4.Caption = "Telefon-4";
            this.colTelefon4.FieldName = "Telefon4";
            this.colTelefon4.Name = "colTelefon4";
            this.colTelefon4.OptionsColumn.AllowEdit = false;
            this.colTelefon4.StatusBarAciklama = null;
            this.colTelefon4.StatusBarKisaYol = null;
            this.colTelefon4.StatusBarKisaYolAciklama = null;
            this.colTelefon4.Width = 120;
            // 
            // colFaks
            // 
            this.colFaks.AppearanceCell.Options.UseTextOptions = true;
            this.colFaks.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFaks.Caption = "Faks";
            this.colFaks.FieldName = "Faks";
            this.colFaks.Name = "colFaks";
            this.colFaks.OptionsColumn.AllowEdit = false;
            this.colFaks.StatusBarAciklama = null;
            this.colFaks.StatusBarKisaYol = null;
            this.colFaks.StatusBarKisaYolAciklama = null;
            this.colFaks.Width = 120;
            // 
            // colWeb
            // 
            this.colWeb.Caption = "Web";
            this.colWeb.FieldName = "Web";
            this.colWeb.Name = "colWeb";
            this.colWeb.OptionsColumn.AllowEdit = false;
            this.colWeb.StatusBarAciklama = null;
            this.colWeb.StatusBarKisaYol = null;
            this.colWeb.StatusBarKisaYolAciklama = null;
            this.colWeb.Width = 270;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.StatusBarAciklama = null;
            this.colEmail.StatusBarKisaYol = null;
            this.colEmail.StatusBarKisaYolAciklama = null;
            this.colEmail.Width = 270;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.Caption = "Vergi Dairesi";
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.OptionsColumn.AllowEdit = false;
            this.colVergiDairesi.StatusBarAciklama = null;
            this.colVergiDairesi.StatusBarKisaYol = null;
            this.colVergiDairesi.StatusBarKisaYolAciklama = null;
            this.colVergiDairesi.Width = 250;
            // 
            // colVergiNo
            // 
            this.colVergiNo.Caption = "Vergi Numarası";
            this.colVergiNo.FieldName = "VergiNo";
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.OptionsColumn.AllowEdit = false;
            this.colVergiNo.StatusBarAciklama = null;
            this.colVergiNo.StatusBarKisaYol = null;
            this.colVergiNo.StatusBarKisaYolAciklama = null;
            this.colVergiNo.Width = 180;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            this.colAdres.StatusBarAciklama = null;
            this.colAdres.StatusBarKisaYol = null;
            this.colAdres.StatusBarKisaYolAciklama = null;
            this.colAdres.Width = 300;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Özel Kod";
            this.gridBand2.Columns.Add(this.colOzelKod1);
            this.gridBand2.Columns.Add(this.colOzelKod2);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 400;
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
            this.colOzelKod1.Width = 200;
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
            this.colOzelKod2.Width = 200;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Ek Bilgiler";
            this.gridBand3.Columns.Add(this.colAciklama);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 350;
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
            // CariListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 559);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "CariListForm";
            this.Text = "Cari Kartları";
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

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyBandedGridControl grid;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridView tablo;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colId;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colKod;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colCariAdi;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colTcKimlikNo;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colTelefon1;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colTelefon2;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colTelefon3;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colTelefon4;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colFaks;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colWeb;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colEmail;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colVergiDairesi;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colVergiNo;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colAdres;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colOzelKod1;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colOzelKod2;
        private UserControls.Grid.MyBandedGridControl.MyBandedGridColumn colAciklama;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
    }
}