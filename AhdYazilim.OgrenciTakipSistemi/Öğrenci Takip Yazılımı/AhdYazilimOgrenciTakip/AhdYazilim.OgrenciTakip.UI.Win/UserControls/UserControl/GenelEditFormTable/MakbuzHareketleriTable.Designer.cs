namespace AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.GenelEditFormTable
{
    partial class MakbuzHareketleriTable
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
            this.btnOgrenciBilgileri = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOgrenciNo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colOgrenciAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colOgrenciSoyadi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colSinifAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colOgrenciSubeAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.bndBelgeGenelBilgileri = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPortfoyNo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colBelgeSubeAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colOdemeTuruAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colBankaHesapAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colTakipNo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colGirisTarihi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colVade = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colHesabaGecisTarihi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colTutar = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.repositoryDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colIslemOncesiTutar = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colIslemTutari = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colBelgeDurumu = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.bndBelgeDetayBilgiler = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colBankaAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colBankaSubeAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colBelgeNo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colHesapNo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colAsilBorclu = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            this.colCiranta = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl.MyBandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // insUptNavigator
            // 
            this.insUptNavigator.Location = new System.Drawing.Point(0, 550);
            this.insUptNavigator.Size = new System.Drawing.Size(898, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTarih,
            this.repositoryDecimal});
            this.grid.Size = new System.Drawing.Size(898, 550);
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
            this.tablo.BandPanelRowHeight = 25;
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.btnOgrenciBilgileri,
            this.bndBelgeGenelBilgileri,
            this.bndBelgeDetayBilgiler});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colOgrenciNo,
            this.colOgrenciAdi,
            this.colOgrenciSoyadi,
            this.colSinifAdi,
            this.colOgrenciSubeAdi,
            this.colBelgeSubeAdi,
            this.colOdemeTuruAdi,
            this.colBankaHesapAdi,
            this.colTakipNo,
            this.colPortfoyNo,
            this.colGirisTarihi,
            this.colVade,
            this.colHesabaGecisTarihi,
            this.colTutar,
            this.colIslemOncesiTutar,
            this.colIslemTutari,
            this.colBankaAdi,
            this.colBankaSubeAdi,
            this.colBelgeNo,
            this.colHesapNo,
            this.colAsilBorclu,
            this.colCiranta,
            this.colBelgeDurumu});
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
            this.tablo.OptionsView.ShowFooter = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "İşlem Yapılacak Belgeleri Seçiniz.";
            this.tablo.StatusBarKisaYol = "Shift+ Insert : ";
            this.tablo.StatusBarKisaYolAciklama = "Seçim Yap";
            this.tablo.ViewCaption = "Makbuz Hareketleri";
            // 
            // btnOgrenciBilgileri
            // 
            this.btnOgrenciBilgileri.Caption = "Öğrenci Bilgileri";
            this.btnOgrenciBilgileri.Columns.Add(this.colOgrenciNo);
            this.btnOgrenciBilgileri.Columns.Add(this.colOgrenciAdi);
            this.btnOgrenciBilgileri.Columns.Add(this.colOgrenciSoyadi);
            this.btnOgrenciBilgileri.Columns.Add(this.colSinifAdi);
            this.btnOgrenciBilgileri.Columns.Add(this.colOgrenciSubeAdi);
            this.btnOgrenciBilgileri.Name = "btnOgrenciBilgileri";
            this.btnOgrenciBilgileri.VisibleIndex = 0;
            this.btnOgrenciBilgileri.Width = 660;
            // 
            // colOgrenciNo
            // 
            this.colOgrenciNo.AppearanceCell.Options.UseTextOptions = true;
            this.colOgrenciNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOgrenciNo.Caption = "No";
            this.colOgrenciNo.FieldName = "OgrenciNo";
            this.colOgrenciNo.Name = "colOgrenciNo";
            this.colOgrenciNo.OptionsColumn.AllowEdit = false;
            this.colOgrenciNo.StatusBarAciklama = null;
            this.colOgrenciNo.StatusBarKisaYol = null;
            this.colOgrenciNo.StatusBarKisaYolAciklama = null;
            this.colOgrenciNo.Visible = true;
            this.colOgrenciNo.Width = 100;
            // 
            // colOgrenciAdi
            // 
            this.colOgrenciAdi.Caption = "Adı";
            this.colOgrenciAdi.FieldName = "Adi";
            this.colOgrenciAdi.Name = "colOgrenciAdi";
            this.colOgrenciAdi.OptionsColumn.AllowEdit = false;
            this.colOgrenciAdi.StatusBarAciklama = null;
            this.colOgrenciAdi.StatusBarKisaYol = null;
            this.colOgrenciAdi.StatusBarKisaYolAciklama = null;
            this.colOgrenciAdi.Visible = true;
            this.colOgrenciAdi.Width = 120;
            // 
            // colOgrenciSoyadi
            // 
            this.colOgrenciSoyadi.Caption = "Soyadı";
            this.colOgrenciSoyadi.FieldName = "Soyadi";
            this.colOgrenciSoyadi.Name = "colOgrenciSoyadi";
            this.colOgrenciSoyadi.OptionsColumn.AllowEdit = false;
            this.colOgrenciSoyadi.StatusBarAciklama = null;
            this.colOgrenciSoyadi.StatusBarKisaYol = null;
            this.colOgrenciSoyadi.StatusBarKisaYolAciklama = null;
            this.colOgrenciSoyadi.Visible = true;
            this.colOgrenciSoyadi.Width = 120;
            // 
            // colSinifAdi
            // 
            this.colSinifAdi.Caption = "Sınıf";
            this.colSinifAdi.FieldName = "SinifAdi";
            this.colSinifAdi.Name = "colSinifAdi";
            this.colSinifAdi.OptionsColumn.AllowEdit = false;
            this.colSinifAdi.StatusBarAciklama = null;
            this.colSinifAdi.StatusBarKisaYol = null;
            this.colSinifAdi.StatusBarKisaYolAciklama = null;
            this.colSinifAdi.Visible = true;
            this.colSinifAdi.Width = 120;
            // 
            // colOgrenciSubeAdi
            // 
            this.colOgrenciSubeAdi.Caption = "Şube Adı";
            this.colOgrenciSubeAdi.CustomizationCaption = "Öğrenci Şube Adı";
            this.colOgrenciSubeAdi.FieldName = "OgrenciSubeAdi";
            this.colOgrenciSubeAdi.Name = "colOgrenciSubeAdi";
            this.colOgrenciSubeAdi.OptionsColumn.AllowEdit = false;
            this.colOgrenciSubeAdi.StatusBarAciklama = null;
            this.colOgrenciSubeAdi.StatusBarKisaYol = null;
            this.colOgrenciSubeAdi.StatusBarKisaYolAciklama = null;
            this.colOgrenciSubeAdi.Visible = true;
            this.colOgrenciSubeAdi.Width = 200;
            // 
            // bndBelgeGenelBilgileri
            // 
            this.bndBelgeGenelBilgileri.Caption = "Belge Genel Bilgiler";
            this.bndBelgeGenelBilgileri.Columns.Add(this.colPortfoyNo);
            this.bndBelgeGenelBilgileri.Columns.Add(this.colBelgeSubeAdi);
            this.bndBelgeGenelBilgileri.Columns.Add(this.colOdemeTuruAdi);
            this.bndBelgeGenelBilgileri.Columns.Add(this.colBankaHesapAdi);
            this.bndBelgeGenelBilgileri.Columns.Add(this.colTakipNo);
            this.bndBelgeGenelBilgileri.Columns.Add(this.colGirisTarihi);
            this.bndBelgeGenelBilgileri.Columns.Add(this.colVade);
            this.bndBelgeGenelBilgileri.Columns.Add(this.colHesabaGecisTarihi);
            this.bndBelgeGenelBilgileri.Columns.Add(this.colTutar);
            this.bndBelgeGenelBilgileri.Columns.Add(this.colIslemOncesiTutar);
            this.bndBelgeGenelBilgileri.Columns.Add(this.colIslemTutari);
            this.bndBelgeGenelBilgileri.Columns.Add(this.colBelgeDurumu);
            this.bndBelgeGenelBilgileri.Name = "bndBelgeGenelBilgileri";
            this.bndBelgeGenelBilgileri.VisibleIndex = 1;
            this.bndBelgeGenelBilgileri.Width = 1680;
            // 
            // colPortfoyNo
            // 
            this.colPortfoyNo.Caption = "Portföy No";
            this.colPortfoyNo.FieldName = "OdemeBilgileriId";
            this.colPortfoyNo.Name = "colPortfoyNo";
            this.colPortfoyNo.OptionsColumn.AllowEdit = false;
            this.colPortfoyNo.StatusBarAciklama = null;
            this.colPortfoyNo.StatusBarKisaYol = null;
            this.colPortfoyNo.StatusBarKisaYolAciklama = null;
            this.colPortfoyNo.Visible = true;
            this.colPortfoyNo.Width = 120;
            // 
            // colBelgeSubeAdi
            // 
            this.colBelgeSubeAdi.Caption = "Şube Adı";
            this.colBelgeSubeAdi.CustomizationCaption = "Belge Şube Adı";
            this.colBelgeSubeAdi.FieldName = "BelgeSubeAdi";
            this.colBelgeSubeAdi.Name = "colBelgeSubeAdi";
            this.colBelgeSubeAdi.OptionsColumn.AllowEdit = false;
            this.colBelgeSubeAdi.StatusBarAciklama = null;
            this.colBelgeSubeAdi.StatusBarKisaYol = null;
            this.colBelgeSubeAdi.StatusBarKisaYolAciklama = null;
            this.colBelgeSubeAdi.Visible = true;
            this.colBelgeSubeAdi.Width = 200;
            // 
            // colOdemeTuruAdi
            // 
            this.colOdemeTuruAdi.Caption = "Ödeme Türü";
            this.colOdemeTuruAdi.FieldName = "OdemeTuruAdi";
            this.colOdemeTuruAdi.Name = "colOdemeTuruAdi";
            this.colOdemeTuruAdi.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruAdi.StatusBarAciklama = null;
            this.colOdemeTuruAdi.StatusBarKisaYol = null;
            this.colOdemeTuruAdi.StatusBarKisaYolAciklama = null;
            this.colOdemeTuruAdi.Visible = true;
            this.colOdemeTuruAdi.Width = 120;
            // 
            // colBankaHesapAdi
            // 
            this.colBankaHesapAdi.Caption = "Hesap Adı";
            this.colBankaHesapAdi.CustomizationCaption = "Banka Hesap Adı";
            this.colBankaHesapAdi.FieldName = "BankaHesapAdi";
            this.colBankaHesapAdi.Name = "colBankaHesapAdi";
            this.colBankaHesapAdi.OptionsColumn.AllowEdit = false;
            this.colBankaHesapAdi.StatusBarAciklama = null;
            this.colBankaHesapAdi.StatusBarKisaYol = null;
            this.colBankaHesapAdi.StatusBarKisaYolAciklama = null;
            this.colBankaHesapAdi.Visible = true;
            this.colBankaHesapAdi.Width = 200;
            // 
            // colTakipNo
            // 
            this.colTakipNo.Caption = "Takip No";
            this.colTakipNo.FieldName = "TakipNo";
            this.colTakipNo.Name = "colTakipNo";
            this.colTakipNo.OptionsColumn.AllowEdit = false;
            this.colTakipNo.StatusBarAciklama = null;
            this.colTakipNo.StatusBarKisaYol = null;
            this.colTakipNo.StatusBarKisaYolAciklama = null;
            this.colTakipNo.Visible = true;
            this.colTakipNo.Width = 120;
            // 
            // colGirisTarihi
            // 
            this.colGirisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colGirisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGirisTarihi.Caption = "Giriş Tarihi";
            this.colGirisTarihi.ColumnEdit = this.repositoryTarih;
            this.colGirisTarihi.FieldName = "GirisTarihi";
            this.colGirisTarihi.Name = "colGirisTarihi";
            this.colGirisTarihi.OptionsColumn.AllowEdit = false;
            this.colGirisTarihi.StatusBarAciklama = null;
            this.colGirisTarihi.StatusBarKisaYol = null;
            this.colGirisTarihi.StatusBarKisaYolAciklama = null;
            this.colGirisTarihi.Visible = true;
            this.colGirisTarihi.Width = 120;
            // 
            // repositoryTarih
            // 
            this.repositoryTarih.Appearance.Options.UseTextOptions = true;
            this.repositoryTarih.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryTarih.AutoHeight = false;
            this.repositoryTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryTarih.Name = "repositoryTarih";
            // 
            // colVade
            // 
            this.colVade.AppearanceCell.Options.UseTextOptions = true;
            this.colVade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVade.Caption = "Vade";
            this.colVade.ColumnEdit = this.repositoryTarih;
            this.colVade.FieldName = "Vade";
            this.colVade.Name = "colVade";
            this.colVade.OptionsColumn.AllowEdit = false;
            this.colVade.StatusBarAciklama = null;
            this.colVade.StatusBarKisaYol = null;
            this.colVade.StatusBarKisaYolAciklama = null;
            this.colVade.Visible = true;
            this.colVade.Width = 120;
            // 
            // colHesabaGecisTarihi
            // 
            this.colHesabaGecisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colHesabaGecisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHesabaGecisTarihi.Caption = "H. Geçiş Tarihi";
            this.colHesabaGecisTarihi.ColumnEdit = this.repositoryTarih;
            this.colHesabaGecisTarihi.FieldName = "HesabaGecisTarihi";
            this.colHesabaGecisTarihi.Name = "colHesabaGecisTarihi";
            this.colHesabaGecisTarihi.OptionsColumn.AllowEdit = false;
            this.colHesabaGecisTarihi.StatusBarAciklama = null;
            this.colHesabaGecisTarihi.StatusBarKisaYol = null;
            this.colHesabaGecisTarihi.StatusBarKisaYolAciklama = null;
            this.colHesabaGecisTarihi.Visible = true;
            this.colHesabaGecisTarihi.Width = 120;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.ColumnEdit = this.repositoryDecimal;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.StatusBarAciklama = null;
            this.colTutar.StatusBarKisaYol = null;
            this.colTutar.StatusBarKisaYolAciklama = null;
            this.colTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "{0:n2}")});
            this.colTutar.Visible = true;
            this.colTutar.Width = 120;
            // 
            // repositoryDecimal
            // 
            this.repositoryDecimal.AutoHeight = false;
            this.repositoryDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDecimal.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.EditFormat.FormatString = "{0:n2}";
            this.repositoryDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.Mask.EditMask = "n2";
            this.repositoryDecimal.Name = "repositoryDecimal";
            // 
            // colIslemOncesiTutar
            // 
            this.colIslemOncesiTutar.Caption = "Kalan";
            this.colIslemOncesiTutar.ColumnEdit = this.repositoryDecimal;
            this.colIslemOncesiTutar.FieldName = "IslemOncesiTutar";
            this.colIslemOncesiTutar.Name = "colIslemOncesiTutar";
            this.colIslemOncesiTutar.OptionsColumn.AllowEdit = false;
            this.colIslemOncesiTutar.StatusBarAciklama = null;
            this.colIslemOncesiTutar.StatusBarKisaYol = null;
            this.colIslemOncesiTutar.StatusBarKisaYolAciklama = null;
            this.colIslemOncesiTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IslemOncesiTutar", "{0:n2}")});
            this.colIslemOncesiTutar.Visible = true;
            this.colIslemOncesiTutar.Width = 120;
            // 
            // colIslemTutari
            // 
            this.colIslemTutari.Caption = "İşlem Tutarı";
            this.colIslemTutari.ColumnEdit = this.repositoryDecimal;
            this.colIslemTutari.FieldName = "IslemTutari";
            this.colIslemTutari.Name = "colIslemTutari";
            this.colIslemTutari.OptionsColumn.AllowEdit = false;
            this.colIslemTutari.StatusBarAciklama = "Tutar Giriniz.";
            this.colIslemTutari.StatusBarKisaYol = "F4 : ";
            this.colIslemTutari.StatusBarKisaYolAciklama = "Hesap Makinesi";
            this.colIslemTutari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IslemTutari", "{0:n2}")});
            this.colIslemTutari.Visible = true;
            this.colIslemTutari.Width = 120;
            // 
            // colBelgeDurumu
            // 
            this.colBelgeDurumu.Caption = "Durum";
            this.colBelgeDurumu.FieldName = "BelgeDurumu";
            this.colBelgeDurumu.Name = "colBelgeDurumu";
            this.colBelgeDurumu.OptionsColumn.AllowEdit = false;
            this.colBelgeDurumu.StatusBarAciklama = null;
            this.colBelgeDurumu.StatusBarKisaYol = null;
            this.colBelgeDurumu.StatusBarKisaYolAciklama = null;
            this.colBelgeDurumu.Visible = true;
            this.colBelgeDurumu.Width = 200;
            // 
            // bndBelgeDetayBilgiler
            // 
            this.bndBelgeDetayBilgiler.Caption = "Belge Detay Bilgiler";
            this.bndBelgeDetayBilgiler.Columns.Add(this.colBankaAdi);
            this.bndBelgeDetayBilgiler.Columns.Add(this.colBankaSubeAdi);
            this.bndBelgeDetayBilgiler.Columns.Add(this.colBelgeNo);
            this.bndBelgeDetayBilgiler.Columns.Add(this.colHesapNo);
            this.bndBelgeDetayBilgiler.Columns.Add(this.colAsilBorclu);
            this.bndBelgeDetayBilgiler.Columns.Add(this.colCiranta);
            this.bndBelgeDetayBilgiler.Name = "bndBelgeDetayBilgiler";
            this.bndBelgeDetayBilgiler.VisibleIndex = 2;
            this.bndBelgeDetayBilgiler.Width = 1040;
            // 
            // colBankaAdi
            // 
            this.colBankaAdi.Caption = "Banka";
            this.colBankaAdi.FieldName = "BankaAdi";
            this.colBankaAdi.Name = "colBankaAdi";
            this.colBankaAdi.OptionsColumn.AllowEdit = false;
            this.colBankaAdi.StatusBarAciklama = null;
            this.colBankaAdi.StatusBarKisaYol = null;
            this.colBankaAdi.StatusBarKisaYolAciklama = null;
            this.colBankaAdi.Visible = true;
            this.colBankaAdi.Width = 200;
            // 
            // colBankaSubeAdi
            // 
            this.colBankaSubeAdi.Caption = "Banka Şube";
            this.colBankaSubeAdi.FieldName = "BankaSubeAdi";
            this.colBankaSubeAdi.Name = "colBankaSubeAdi";
            this.colBankaSubeAdi.OptionsColumn.AllowEdit = false;
            this.colBankaSubeAdi.StatusBarAciklama = null;
            this.colBankaSubeAdi.StatusBarKisaYol = null;
            this.colBankaSubeAdi.StatusBarKisaYolAciklama = null;
            this.colBankaSubeAdi.Visible = true;
            this.colBankaSubeAdi.Width = 200;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.Caption = "Belge No";
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.OptionsColumn.AllowEdit = false;
            this.colBelgeNo.StatusBarAciklama = null;
            this.colBelgeNo.StatusBarKisaYol = null;
            this.colBelgeNo.StatusBarKisaYolAciklama = null;
            this.colBelgeNo.Visible = true;
            this.colBelgeNo.Width = 120;
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
            this.colHesapNo.Width = 120;
            // 
            // colAsilBorclu
            // 
            this.colAsilBorclu.Caption = "Asıl Borçlu";
            this.colAsilBorclu.FieldName = "AsilBorclu";
            this.colAsilBorclu.Name = "colAsilBorclu";
            this.colAsilBorclu.OptionsColumn.AllowEdit = false;
            this.colAsilBorclu.StatusBarAciklama = null;
            this.colAsilBorclu.StatusBarKisaYol = null;
            this.colAsilBorclu.StatusBarKisaYolAciklama = null;
            this.colAsilBorclu.Visible = true;
            this.colAsilBorclu.Width = 200;
            // 
            // colCiranta
            // 
            this.colCiranta.Caption = "Ciranta";
            this.colCiranta.FieldName = "Ciranta";
            this.colCiranta.Name = "colCiranta";
            this.colCiranta.OptionsColumn.AllowEdit = false;
            this.colCiranta.StatusBarAciklama = null;
            this.colCiranta.StatusBarKisaYol = null;
            this.colCiranta.StatusBarKisaYolAciklama = null;
            this.colCiranta.Visible = true;
            this.colCiranta.Width = 200;
            // 
            // MakbuzHareketleriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "MakbuzHareketleriTable";
            this.Size = new System.Drawing.Size(898, 574);
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyBandedGridControl grid;
        private Grid.MyBandedGridControl.MyBandedGridView tablo;
        private Grid.MyBandedGridControl.MyBandedGridColumn colOgrenciNo;
        private Grid.MyBandedGridControl.MyBandedGridColumn colOgrenciAdi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colOgrenciSoyadi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colSinifAdi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colOgrenciSubeAdi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colBelgeSubeAdi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colOdemeTuruAdi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colBankaHesapAdi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colTakipNo;
        private Grid.MyBandedGridControl.MyBandedGridColumn colPortfoyNo;
        private Grid.MyBandedGridControl.MyBandedGridColumn colGirisTarihi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colVade;
        private Grid.MyBandedGridControl.MyBandedGridColumn colHesabaGecisTarihi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colTutar;
        private Grid.MyBandedGridControl.MyBandedGridColumn colIslemOncesiTutar;
        private Grid.MyBandedGridControl.MyBandedGridColumn colBankaAdi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colBankaSubeAdi;
        private Grid.MyBandedGridControl.MyBandedGridColumn colBelgeNo;
        private Grid.MyBandedGridControl.MyBandedGridColumn colHesapNo;
        private Grid.MyBandedGridControl.MyBandedGridColumn colAsilBorclu;
        private Grid.MyBandedGridControl.MyBandedGridColumn colCiranta;
        private Grid.MyBandedGridControl.MyBandedGridColumn colBelgeDurumu;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand btnOgrenciBilgileri;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bndBelgeGenelBilgileri;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryDecimal;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bndBelgeDetayBilgiler;
        protected internal Grid.MyBandedGridControl.MyBandedGridColumn colIslemTutari;
    }
}
