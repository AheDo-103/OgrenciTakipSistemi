namespace AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    partial class IletisimBilgiTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
            this.tablo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridView();
            this.colVeli = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.repositoryVeli = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colFaturaAdresi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.repositoryAdres = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colYakinlikAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.repositoryYakinlik = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colTcKimlikNo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colSoyadi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colMeslekAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colCepTel1 = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colEvTel = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colIsTel1 = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colEvAdresi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colEvAdresiIlAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colEvAdresiIlceAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colIsAdresi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colIsAdresiIlAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colIsAdresiIlceAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colIsyeriAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colGorevAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colYakinlikId = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryVeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryYakinlik)).BeginInit();
            this.SuspendLayout();
            // 
            // insUptNavigator
            // 
            this.insUptNavigator.Location = new System.Drawing.Point(0, 457);
            this.insUptNavigator.Size = new System.Drawing.Size(1091, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryYakinlik,
            this.repositoryAdres,
            this.repositoryVeli});
            this.grid.Size = new System.Drawing.Size(1091, 457);
            this.grid.TabIndex = 5;
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
            this.tablo.BandPanelRowHeight = 20;
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colVeli,
            this.colFaturaAdresi,
            this.colYakinlikId,
            this.colYakinlikAdi,
            this.colTcKimlikNo,
            this.colAdi,
            this.colSoyadi,
            this.colCepTel1,
            this.colEvTel,
            this.colIsTel1,
            this.colEvAdresi,
            this.colEvAdresiIlAdi,
            this.colEvAdresiIlceAdi,
            this.colIsAdresi,
            this.colIsAdresiIlAdi,
            this.colIsAdresiIlceAdi,
            this.colMeslekAdi,
            this.colIsyeriAdi,
            this.colGorevAdi});
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
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "İletişim Bilgileri Seçiniz.";
            this.tablo.StatusBarKisaYol = "Shift + Insert : ";
            this.tablo.StatusBarKisaYolAciklama = "Seçim Yap";
            this.tablo.ViewCaption = "İletişim Bilgileri";
            // 
            // colVeli
            // 
            this.colVeli.Caption = "Veli";
            this.colVeli.ColumnEdit = this.repositoryVeli;
            this.colVeli.FieldName = "Veli";
            this.colVeli.Name = "colVeli";
            this.colVeli.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colVeli.OptionsFilter.AllowAutoFilter = false;
            this.colVeli.OptionsFilter.AllowFilter = false;
            this.colVeli.StatusBarAciklama = "Kişi Öğrenci Velisi İse İşaretleyiniz.";
            this.colVeli.StatusBarKisaYol = "Space : ";
            this.colVeli.StatusBarKisaYolAciklama = "İşaretle";
            this.colVeli.Visible = true;
            this.colVeli.Width = 100;
            // 
            // repositoryVeli
            // 
            this.repositoryVeli.AutoHeight = false;
            this.repositoryVeli.Name = "repositoryVeli";
            // 
            // colFaturaAdresi
            // 
            this.colFaturaAdresi.Caption = "Fatura Adresi";
            this.colFaturaAdresi.ColumnEdit = this.repositoryAdres;
            this.colFaturaAdresi.FieldName = "AdresTuru";
            this.colFaturaAdresi.Name = "colFaturaAdresi";
            this.colFaturaAdresi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFaturaAdresi.OptionsFilter.AllowAutoFilter = false;
            this.colFaturaAdresi.OptionsFilter.AllowFilter = false;
            this.colFaturaAdresi.StatusBarAciklama = "Adres Türü Seçiniz.";
            this.colFaturaAdresi.StatusBarKisaYol = "F4 : ";
            this.colFaturaAdresi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colFaturaAdresi.Visible = true;
            this.colFaturaAdresi.Width = 150;
            // 
            // repositoryAdres
            // 
            this.repositoryAdres.AutoHeight = false;
            this.repositoryAdres.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryAdres.Name = "repositoryAdres";
            // 
            // colYakinlikAdi
            // 
            this.colYakinlikAdi.Caption = "Yakınlık";
            this.colYakinlikAdi.ColumnEdit = this.repositoryYakinlik;
            this.colYakinlikAdi.FieldName = "YakinlikAdi";
            this.colYakinlikAdi.Name = "colYakinlikAdi";
            this.colYakinlikAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colYakinlikAdi.OptionsFilter.AllowAutoFilter = false;
            this.colYakinlikAdi.OptionsFilter.AllowFilter = false;
            this.colYakinlikAdi.StatusBarAciklama = "Yakınlık Türü Seçiniz.";
            this.colYakinlikAdi.StatusBarKisaYol = "F4 : ";
            this.colYakinlikAdi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colYakinlikAdi.Visible = true;
            this.colYakinlikAdi.Width = 150;
            // 
            // repositoryYakinlik
            // 
            this.repositoryYakinlik.AutoHeight = false;
            this.repositoryYakinlik.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryYakinlik.Name = "repositoryYakinlik";
            this.repositoryYakinlik.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.Caption = "TC Kimlik No";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTcKimlikNo.OptionsFilter.AllowAutoFilter = false;
            this.colTcKimlikNo.OptionsFilter.AllowFilter = false;
            this.colTcKimlikNo.StatusBarAciklama = null;
            this.colTcKimlikNo.StatusBarKisaYol = null;
            this.colTcKimlikNo.StatusBarKisaYolAciklama = null;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.Width = 150;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAdi.OptionsFilter.AllowAutoFilter = false;
            this.colAdi.OptionsFilter.AllowFilter = false;
            this.colAdi.StatusBarAciklama = null;
            this.colAdi.StatusBarKisaYol = null;
            this.colAdi.StatusBarKisaYolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.Width = 160;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSoyadi.OptionsFilter.AllowAutoFilter = false;
            this.colSoyadi.OptionsFilter.AllowFilter = false;
            this.colSoyadi.StatusBarAciklama = null;
            this.colSoyadi.StatusBarKisaYol = null;
            this.colSoyadi.StatusBarKisaYolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.Width = 160;
            // 
            // colMeslekAdi
            // 
            this.colMeslekAdi.Caption = "Meslek";
            this.colMeslekAdi.FieldName = "MeslekAdi";
            this.colMeslekAdi.Name = "colMeslekAdi";
            this.colMeslekAdi.OptionsColumn.AllowEdit = false;
            this.colMeslekAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMeslekAdi.OptionsFilter.AllowAutoFilter = false;
            this.colMeslekAdi.OptionsFilter.AllowFilter = false;
            this.colMeslekAdi.StatusBarAciklama = null;
            this.colMeslekAdi.StatusBarKisaYol = null;
            this.colMeslekAdi.StatusBarKisaYolAciklama = null;
            this.colMeslekAdi.Visible = true;
            this.colMeslekAdi.Width = 160;
            // 
            // colCepTel1
            // 
            this.colCepTel1.Caption = "Cep Telefonu";
            this.colCepTel1.FieldName = "CepTel1";
            this.colCepTel1.Name = "colCepTel1";
            this.colCepTel1.OptionsColumn.AllowEdit = false;
            this.colCepTel1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCepTel1.OptionsFilter.AllowAutoFilter = false;
            this.colCepTel1.OptionsFilter.AllowFilter = false;
            this.colCepTel1.StatusBarAciklama = null;
            this.colCepTel1.StatusBarKisaYol = null;
            this.colCepTel1.StatusBarKisaYolAciklama = null;
            this.colCepTel1.Visible = true;
            this.colCepTel1.Width = 160;
            // 
            // colEvTel
            // 
            this.colEvTel.Caption = "Ev Telefonu";
            this.colEvTel.FieldName = "EvTel";
            this.colEvTel.Name = "colEvTel";
            this.colEvTel.OptionsColumn.AllowEdit = false;
            this.colEvTel.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvTel.OptionsFilter.AllowAutoFilter = false;
            this.colEvTel.OptionsFilter.AllowFilter = false;
            this.colEvTel.StatusBarAciklama = null;
            this.colEvTel.StatusBarKisaYol = null;
            this.colEvTel.StatusBarKisaYolAciklama = null;
            this.colEvTel.Visible = true;
            this.colEvTel.Width = 160;
            // 
            // colIsTel1
            // 
            this.colIsTel1.Caption = "İş Telefonu";
            this.colIsTel1.FieldName = "IsTel1";
            this.colIsTel1.Name = "colIsTel1";
            this.colIsTel1.OptionsColumn.AllowEdit = false;
            this.colIsTel1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsTel1.OptionsFilter.AllowAutoFilter = false;
            this.colIsTel1.OptionsFilter.AllowFilter = false;
            this.colIsTel1.StatusBarAciklama = null;
            this.colIsTel1.StatusBarKisaYol = null;
            this.colIsTel1.StatusBarKisaYolAciklama = null;
            this.colIsTel1.Visible = true;
            this.colIsTel1.Width = 160;
            // 
            // colEvAdresi
            // 
            this.colEvAdresi.Caption = "Ev Adresi";
            this.colEvAdresi.FieldName = "EvAdresi";
            this.colEvAdresi.Name = "colEvAdresi";
            this.colEvAdresi.OptionsColumn.AllowEdit = false;
            this.colEvAdresi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvAdresi.OptionsFilter.AllowAutoFilter = false;
            this.colEvAdresi.OptionsFilter.AllowFilter = false;
            this.colEvAdresi.StatusBarAciklama = null;
            this.colEvAdresi.StatusBarKisaYol = null;
            this.colEvAdresi.StatusBarKisaYolAciklama = null;
            this.colEvAdresi.Visible = true;
            this.colEvAdresi.Width = 200;
            // 
            // colEvAdresiIlAdi
            // 
            this.colEvAdresiIlAdi.Caption = "İl Adı";
            this.colEvAdresiIlAdi.CustomizationCaption = "Ev Adresi İl Adı";
            this.colEvAdresiIlAdi.FieldName = "EvAdresiIlAdi";
            this.colEvAdresiIlAdi.Name = "colEvAdresiIlAdi";
            this.colEvAdresiIlAdi.OptionsColumn.AllowEdit = false;
            this.colEvAdresiIlAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvAdresiIlAdi.OptionsFilter.AllowAutoFilter = false;
            this.colEvAdresiIlAdi.OptionsFilter.AllowFilter = false;
            this.colEvAdresiIlAdi.StatusBarAciklama = null;
            this.colEvAdresiIlAdi.StatusBarKisaYol = null;
            this.colEvAdresiIlAdi.StatusBarKisaYolAciklama = null;
            this.colEvAdresiIlAdi.Visible = true;
            this.colEvAdresiIlAdi.Width = 160;
            // 
            // colEvAdresiIlceAdi
            // 
            this.colEvAdresiIlceAdi.Caption = "İlçe Adı";
            this.colEvAdresiIlceAdi.CustomizationCaption = "Ev Adresi İlçe Adı";
            this.colEvAdresiIlceAdi.FieldName = "EvAdresiIlceAdi";
            this.colEvAdresiIlceAdi.Name = "colEvAdresiIlceAdi";
            this.colEvAdresiIlceAdi.OptionsColumn.AllowEdit = false;
            this.colEvAdresiIlceAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvAdresiIlceAdi.OptionsFilter.AllowAutoFilter = false;
            this.colEvAdresiIlceAdi.OptionsFilter.AllowFilter = false;
            this.colEvAdresiIlceAdi.StatusBarAciklama = null;
            this.colEvAdresiIlceAdi.StatusBarKisaYol = null;
            this.colEvAdresiIlceAdi.StatusBarKisaYolAciklama = null;
            this.colEvAdresiIlceAdi.Visible = true;
            this.colEvAdresiIlceAdi.Width = 160;
            // 
            // colIsAdresi
            // 
            this.colIsAdresi.Caption = "İş Adresi";
            this.colIsAdresi.FieldName = "IsAdresi";
            this.colIsAdresi.Name = "colIsAdresi";
            this.colIsAdresi.OptionsColumn.AllowEdit = false;
            this.colIsAdresi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsAdresi.OptionsFilter.AllowAutoFilter = false;
            this.colIsAdresi.OptionsFilter.AllowFilter = false;
            this.colIsAdresi.StatusBarAciklama = null;
            this.colIsAdresi.StatusBarKisaYol = null;
            this.colIsAdresi.StatusBarKisaYolAciklama = null;
            this.colIsAdresi.Visible = true;
            this.colIsAdresi.Width = 200;
            // 
            // colIsAdresiIlAdi
            // 
            this.colIsAdresiIlAdi.Caption = "İl Adı";
            this.colIsAdresiIlAdi.CustomizationCaption = "İş Adresi İl Adı";
            this.colIsAdresiIlAdi.FieldName = "IsAdresiIlAdi";
            this.colIsAdresiIlAdi.Name = "colIsAdresiIlAdi";
            this.colIsAdresiIlAdi.OptionsColumn.AllowEdit = false;
            this.colIsAdresiIlAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsAdresiIlAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIsAdresiIlAdi.OptionsFilter.AllowFilter = false;
            this.colIsAdresiIlAdi.StatusBarAciklama = null;
            this.colIsAdresiIlAdi.StatusBarKisaYol = null;
            this.colIsAdresiIlAdi.StatusBarKisaYolAciklama = null;
            this.colIsAdresiIlAdi.Visible = true;
            this.colIsAdresiIlAdi.Width = 160;
            // 
            // colIsAdresiIlceAdi
            // 
            this.colIsAdresiIlceAdi.Caption = "İlçe Adı";
            this.colIsAdresiIlceAdi.CustomizationCaption = "İş Adresi İlçe Adı";
            this.colIsAdresiIlceAdi.FieldName = "IsAdresiIlceAdi";
            this.colIsAdresiIlceAdi.Name = "colIsAdresiIlceAdi";
            this.colIsAdresiIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIsAdresiIlceAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsAdresiIlceAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIsAdresiIlceAdi.OptionsFilter.AllowFilter = false;
            this.colIsAdresiIlceAdi.StatusBarAciklama = null;
            this.colIsAdresiIlceAdi.StatusBarKisaYol = null;
            this.colIsAdresiIlceAdi.StatusBarKisaYolAciklama = null;
            this.colIsAdresiIlceAdi.Visible = true;
            this.colIsAdresiIlceAdi.Width = 160;
            // 
            // colIsyeriAdi
            // 
            this.colIsyeriAdi.Caption = "İşyeri";
            this.colIsyeriAdi.FieldName = "IsyeriAdi";
            this.colIsyeriAdi.Name = "colIsyeriAdi";
            this.colIsyeriAdi.OptionsColumn.AllowEdit = false;
            this.colIsyeriAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsyeriAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIsyeriAdi.OptionsFilter.AllowFilter = false;
            this.colIsyeriAdi.StatusBarAciklama = null;
            this.colIsyeriAdi.StatusBarKisaYol = null;
            this.colIsyeriAdi.StatusBarKisaYolAciklama = null;
            this.colIsyeriAdi.Visible = true;
            this.colIsyeriAdi.Width = 160;
            // 
            // colGorevAdi
            // 
            this.colGorevAdi.Caption = "Görev";
            this.colGorevAdi.FieldName = "GorevAdi";
            this.colGorevAdi.Name = "colGorevAdi";
            this.colGorevAdi.OptionsColumn.AllowEdit = false;
            this.colGorevAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGorevAdi.OptionsFilter.AllowAutoFilter = false;
            this.colGorevAdi.OptionsFilter.AllowFilter = false;
            this.colGorevAdi.StatusBarAciklama = null;
            this.colGorevAdi.StatusBarKisaYol = null;
            this.colGorevAdi.StatusBarKisaYolAciklama = null;
            this.colGorevAdi.Visible = true;
            this.colGorevAdi.Width = 160;
            // 
            // colYakinlikId
            // 
            this.colYakinlikId.Caption = "YakinlikId";
            this.colYakinlikId.FieldName = "YakinlikId";
            this.colYakinlikId.Name = "colYakinlikId";
            this.colYakinlikId.OptionsColumn.AllowEdit = false;
            this.colYakinlikId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colYakinlikId.OptionsColumn.ShowInCustomizationForm = false;
            this.colYakinlikId.OptionsFilter.AllowAutoFilter = false;
            this.colYakinlikId.OptionsFilter.AllowFilter = false;
            this.colYakinlikId.StatusBarAciklama = null;
            this.colYakinlikId.StatusBarKisaYol = null;
            this.colYakinlikId.StatusBarKisaYolAciklama = null;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Genel Bilgiler";
            this.gridBand1.Columns.Add(this.colVeli);
            this.gridBand1.Columns.Add(this.colFaturaAdresi);
            this.gridBand1.Columns.Add(this.colYakinlikAdi);
            this.gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 400;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Kimlik Bilgileri";
            this.gridBand2.Columns.Add(this.colTcKimlikNo);
            this.gridBand2.Columns.Add(this.colAdi);
            this.gridBand2.Columns.Add(this.colSoyadi);
            this.gridBand2.Columns.Add(this.colMeslekAdi);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 630;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Telefon";
            this.gridBand3.Columns.Add(this.colCepTel1);
            this.gridBand3.Columns.Add(this.colEvTel);
            this.gridBand3.Columns.Add(this.colIsTel1);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 480;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Ev Adres";
            this.gridBand4.Columns.Add(this.colEvAdresi);
            this.gridBand4.Columns.Add(this.colEvAdresiIlAdi);
            this.gridBand4.Columns.Add(this.colEvAdresiIlceAdi);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 520;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "İş Adres";
            this.gridBand5.Columns.Add(this.colIsAdresi);
            this.gridBand5.Columns.Add(this.colIsAdresiIlAdi);
            this.gridBand5.Columns.Add(this.colIsAdresiIlceAdi);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 520;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "Çalıştığı veya Sahibi Olduğu İşyeri Bilgisi";
            this.gridBand6.Columns.Add(this.colIsyeriAdi);
            this.gridBand6.Columns.Add(this.colGorevAdi);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 5;
            this.gridBand6.Width = 320;
            // 
            // IletisimBilgiTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "IletisimBilgiTable";
            this.Size = new System.Drawing.Size(1091, 481);
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryVeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryYakinlik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyBandedGridControl grid;
        private Grid.MyBandedGridControl.MyBandedGridView tablo;
        private Grid.MyBandedGridControl.MyBandedGridColumn colVeli;
        private Grid.MyBandedGridControl.MyBandedGridColumn colFaturaAdresi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colYakinlikId;
        private Grid.MyBandedGridControl.MyBandedGridColumn colYakinlikAdi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colTcKimlikNo;
        private Grid.MyBandedGridControl.MyBandedGridColumn colAdi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colSoyadi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colCepTel1;
        private Grid.MyBandedGridControl.MyBandedGridColumn colEvTel;
        private Grid.MyBandedGridControl.MyBandedGridColumn colIsTel1;
        private Grid.MyBandedGridControl.MyBandedGridColumn colEvAdresi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colEvAdresiIlAdi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colEvAdresiIlceAdi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colIsAdresi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colIsAdresiIlAdi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colIsAdresiIlceAdi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colMeslekAdi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colIsyeriAdi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colGorevAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryVeli;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryAdres;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryYakinlik;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
    }
}
