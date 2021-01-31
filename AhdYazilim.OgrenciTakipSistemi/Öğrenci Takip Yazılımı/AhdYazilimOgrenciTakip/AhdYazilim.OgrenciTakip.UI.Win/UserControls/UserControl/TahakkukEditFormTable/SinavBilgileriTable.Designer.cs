namespace AhdYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    partial class SinavBilgileriTable
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
            this.grid = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
            this.tablo = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
            this.colSinavAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colTarih = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colPuanTuru = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colPuan = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryItemPuan = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colSira = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryItemSira = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colDerece = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryItemYuzde = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemYuzde)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTarih,
            this.repositoryItemSira,
            this.repositoryItemPuan,
            this.repositoryItemYuzde});
            this.grid.Size = new System.Drawing.Size(627, 281);
            this.grid.TabIndex = 5;
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
            this.colSinavAdi,
            this.colTarih,
            this.colPuanTuru,
            this.colPuan,
            this.colSira,
            this.colDerece});
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
            this.tablo.StatusBarAciklama = "Öğrenciye Ait Sınav Bilgilerini Ve Puan / Sıra / Derecesini Giriniz.";
            this.tablo.StatusBarKisaYol = "Shift + Insert : ";
            this.tablo.StatusBarKisaYolAciklama = "Bilgi Gir";
            this.tablo.ViewCaption = "Sınav Bilgileri";
            // 
            // colSinavAdi
            // 
            this.colSinavAdi.Caption = "Sınav Adı";
            this.colSinavAdi.FieldName = "SinavAdi";
            this.colSinavAdi.Name = "colSinavAdi";
            this.colSinavAdi.StatusBarAciklama = "Sınav Adı Giriniz.";
            this.colSinavAdi.StatusBarKisaYol = null;
            this.colSinavAdi.StatusBarKisaYolAciklama = null;
            this.colSinavAdi.Visible = true;
            this.colSinavAdi.VisibleIndex = 0;
            this.colSinavAdi.Width = 120;
            // 
            // colTarih
            // 
            this.colTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarih.Caption = "Tarih";
            this.colTarih.ColumnEdit = this.repositoryItemTarih;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.StatusBarAciklama = "Öğrencinin Girdiği Sınavın Tarih Seçiniz.";
            this.colTarih.StatusBarKisaYol = "F4 : ";
            this.colTarih.StatusBarKisaYolAciklama = "Tarih Seç";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 1;
            this.colTarih.Width = 100;
            // 
            // repositoryItemTarih
            // 
            this.repositoryItemTarih.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemTarih.AutoHeight = false;
            this.repositoryItemTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemTarih.Name = "repositoryItemTarih";
            // 
            // colPuanTuru
            // 
            this.colPuanTuru.Caption = "Puan Türü";
            this.colPuanTuru.FieldName = "PuanTuru";
            this.colPuanTuru.Name = "colPuanTuru";
            this.colPuanTuru.StatusBarAciklama = "Öğrencinin Girdiği Sınavın Puan Türü Giriniz.";
            this.colPuanTuru.StatusBarKisaYol = null;
            this.colPuanTuru.StatusBarKisaYolAciklama = null;
            this.colPuanTuru.Visible = true;
            this.colPuanTuru.VisibleIndex = 2;
            this.colPuanTuru.Width = 100;
            // 
            // colPuan
            // 
            this.colPuan.Caption = "Puan";
            this.colPuan.ColumnEdit = this.repositoryItemPuan;
            this.colPuan.FieldName = "Puan";
            this.colPuan.Name = "colPuan";
            this.colPuan.StatusBarAciklama = "Öğrencinin Sınavdan Aldığı Puanı Giriniz.";
            this.colPuan.StatusBarKisaYol = null;
            this.colPuan.StatusBarKisaYolAciklama = null;
            this.colPuan.Visible = true;
            this.colPuan.VisibleIndex = 3;
            this.colPuan.Width = 100;
            // 
            // repositoryItemPuan
            // 
            this.repositoryItemPuan.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemPuan.AutoHeight = false;
            this.repositoryItemPuan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPuan.DisplayFormat.FormatString = "n5";
            this.repositoryItemPuan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemPuan.EditFormat.FormatString = "n5";
            this.repositoryItemPuan.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemPuan.Mask.EditMask = "n5";
            this.repositoryItemPuan.MaxValue = new decimal(new int[] {
            99999999,
            0,
            0,
            327680});
            this.repositoryItemPuan.Name = "repositoryItemPuan";
            // 
            // colSira
            // 
            this.colSira.Caption = "Sıra";
            this.colSira.ColumnEdit = this.repositoryItemSira;
            this.colSira.FieldName = "Sira";
            this.colSira.Name = "colSira";
            this.colSira.StatusBarAciklama = "Öğrencinin Sınavda Elde Ettiği Sırayı Giriniz.";
            this.colSira.StatusBarKisaYol = "F4 : ";
            this.colSira.StatusBarKisaYolAciklama = "Sıra Seç";
            this.colSira.Visible = true;
            this.colSira.VisibleIndex = 4;
            this.colSira.Width = 120;
            // 
            // repositoryItemSira
            // 
            this.repositoryItemSira.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemSira.AutoHeight = false;
            this.repositoryItemSira.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSira.DisplayFormat.FormatString = "n0";
            this.repositoryItemSira.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSira.EditFormat.FormatString = "n0";
            this.repositoryItemSira.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSira.Mask.EditMask = "n0";
            this.repositoryItemSira.Name = "repositoryItemSira";
            // 
            // colDerece
            // 
            this.colDerece.Caption = "Derece";
            this.colDerece.ColumnEdit = this.repositoryItemYuzde;
            this.colDerece.FieldName = "Yuzde";
            this.colDerece.Name = "colDerece";
            this.colDerece.StatusBarAciklama = "Öğrencinin Derecesini Giriniz.";
            this.colDerece.StatusBarKisaYol = "";
            this.colDerece.StatusBarKisaYolAciklama = "";
            this.colDerece.Visible = true;
            this.colDerece.VisibleIndex = 5;
            this.colDerece.Width = 120;
            // 
            // repositoryItemYuzde
            // 
            this.repositoryItemYuzde.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemYuzde.AutoHeight = false;
            this.repositoryItemYuzde.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemYuzde.DisplayFormat.FormatString = "n4";
            this.repositoryItemYuzde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemYuzde.EditFormat.FormatString = "n4";
            this.repositoryItemYuzde.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemYuzde.Mask.EditMask = "n4";
            this.repositoryItemYuzde.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repositoryItemYuzde.Name = "repositoryItemYuzde";
            // 
            // SinavBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "SinavBilgileriTable";
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemYuzde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colSinavAdi;
        private Grid.MyGridColumn colTarih;
        private Grid.MyGridColumn colPuanTuru;
        private Grid.MyGridColumn colPuan;
        private Grid.MyGridColumn colSira;
        private Grid.MyGridColumn colDerece;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemPuan;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemSira;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemYuzde;
    }
}
