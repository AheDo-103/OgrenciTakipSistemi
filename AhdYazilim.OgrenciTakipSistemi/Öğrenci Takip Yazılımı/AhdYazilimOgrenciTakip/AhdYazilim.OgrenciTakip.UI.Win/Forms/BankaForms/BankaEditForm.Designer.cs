namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.BankaForms
{
    partial class BankaEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition6 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition8 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition9 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition10 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tgwDurum = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyToogleSwitch();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtAciklama = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyMemoEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtKod = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyKodTextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtOzelKod1 = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyButtonEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtOzelKod2 = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyButtonEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtBankaAdi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgwDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOzelKod1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOzelKod2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.OptionsPageCategories.ShowCaptions = false;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Size = new System.Drawing.Size(416, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.txtBankaAdi);
            this.myDataLayoutControl.Controls.Add(this.txtOzelKod2);
            this.myDataLayoutControl.Controls.Add(this.txtOzelKod1);
            this.myDataLayoutControl.Controls.Add(this.txtKod);
            this.myDataLayoutControl.Controls.Add(this.txtAciklama);
            this.myDataLayoutControl.Controls.Add(this.tgwDurum);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 102);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(416, 180);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 200D;
            columnDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition5.Width = 100D;
            columnDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition6.Width = 99D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition4,
            columnDefinition5,
            columnDefinition6});
            rowDefinition6.Height = 24D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition7.Height = 24D;
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition8.Height = 24D;
            rowDefinition8.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition9.Height = 24D;
            rowDefinition9.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition10.Height = 100D;
            rowDefinition10.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition6,
            rowDefinition7,
            rowDefinition8,
            rowDefinition9,
            rowDefinition10});
            this.Root.Size = new System.Drawing.Size(416, 180);
            this.Root.TextVisible = false;
            // 
            // tgwDurum
            // 
            this.tgwDurum.EnterMoveNextControl = true;
            this.tgwDurum.Location = new System.Drawing.Point(309, 12);
            this.tgwDurum.MenuManager = this.ribbonControl;
            this.tgwDurum.Name = "tgwDurum";
            this.tgwDurum.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.tgwDurum.Properties.Appearance.Options.UseForeColor = true;
            this.tgwDurum.Properties.AutoHeight = false;
            this.tgwDurum.Properties.AutoWidth = true;
            this.tgwDurum.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tgwDurum.Properties.OffText = "Pasif";
            this.tgwDurum.Properties.OnText = "Aktif";
            this.tgwDurum.Size = new System.Drawing.Size(97, 20);
            this.tgwDurum.StatusBarAciklama = "Kartın Kullanım Durumunu Seçiniz.";
            this.tgwDurum.StyleController = this.myDataLayoutControl;
            this.tgwDurum.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.tgwDurum;
            this.layoutControlItem1.Location = new System.Drawing.Point(297, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem1.Size = new System.Drawing.Size(99, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // txtAciklama
            // 
            this.txtAciklama.EnterMoveNextControl = true;
            this.txtAciklama.Location = new System.Drawing.Point(68, 108);
            this.txtAciklama.MenuManager = this.ribbonControl;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAciklama.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAciklama.Properties.MaxLength = 500;
            this.txtAciklama.Size = new System.Drawing.Size(336, 60);
            this.txtAciklama.StatusBarAciklama = "Açıklama Giriniz.";
            this.txtAciklama.StyleController = this.myDataLayoutControl;
            this.txtAciklama.TabIndex = 3;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtAciklama;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem2.Size = new System.Drawing.Size(396, 64);
            this.layoutControlItem2.Text = "Açıklama";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 13);
            // 
            // txtKod
            // 
            this.txtKod.EnterMoveNextControl = true;
            this.txtKod.Location = new System.Drawing.Point(68, 12);
            this.txtKod.MenuManager = this.ribbonControl;
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtKod.Properties.Appearance.Options.UseBackColor = true;
            this.txtKod.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKod.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKod.Properties.MaxLength = 20;
            this.txtKod.Size = new System.Drawing.Size(140, 20);
            this.txtKod.StatusBarAciklama = "Kod Giriniz.";
            this.txtKod.StyleController = this.myDataLayoutControl;
            this.txtKod.TabIndex = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtKod;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.Text = "Kod";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 13);
            // 
            // txtOzelKod1
            // 
            this.txtOzelKod1.EnterMoveNextControl = true;
            this.txtOzelKod1.Id = null;
            this.txtOzelKod1.Location = new System.Drawing.Point(68, 60);
            this.txtOzelKod1.MenuManager = this.ribbonControl;
            this.txtOzelKod1.Name = "txtOzelKod1";
            this.txtOzelKod1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtOzelKod1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtOzelKod1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtOzelKod1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtOzelKod1.Size = new System.Drawing.Size(140, 20);
            this.txtOzelKod1.StatusBarAciklama = "Özel Kod Seçiniz.";
            this.txtOzelKod1.StatusBarKisaYol = "F4 :";
            this.txtOzelKod1.StatusBarKisaYolAciklama = "Seçim Yap";
            this.txtOzelKod1.StyleController = this.myDataLayoutControl;
            this.txtOzelKod1.TabIndex = 1;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtOzelKod1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.Text = "Özel Kod-1";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 13);
            // 
            // txtOzelKod2
            // 
            this.txtOzelKod2.EnterMoveNextControl = true;
            this.txtOzelKod2.Id = null;
            this.txtOzelKod2.Location = new System.Drawing.Point(68, 84);
            this.txtOzelKod2.MenuManager = this.ribbonControl;
            this.txtOzelKod2.Name = "txtOzelKod2";
            this.txtOzelKod2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtOzelKod2.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtOzelKod2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtOzelKod2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtOzelKod2.Size = new System.Drawing.Size(140, 20);
            this.txtOzelKod2.StatusBarAciklama = "Özel Kod Seçiniz.";
            this.txtOzelKod2.StatusBarKisaYol = "F4 :";
            this.txtOzelKod2.StatusBarKisaYolAciklama = "Seçim Yap";
            this.txtOzelKod2.StyleController = this.myDataLayoutControl;
            this.txtOzelKod2.TabIndex = 2;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtOzelKod2;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem5.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.Text = "Özel Kod-2";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(52, 13);
            // 
            // txtBankaAdi
            // 
            this.txtBankaAdi.EnterMoveNextControl = true;
            this.txtBankaAdi.Location = new System.Drawing.Point(68, 36);
            this.txtBankaAdi.MenuManager = this.ribbonControl;
            this.txtBankaAdi.Name = "txtBankaAdi";
            this.txtBankaAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtBankaAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBankaAdi.Properties.MaxLength = 50;
            this.txtBankaAdi.Size = new System.Drawing.Size(336, 20);
            this.txtBankaAdi.StatusBarAciklama = "Banka Adı Giriniz.";
            this.txtBankaAdi.StyleController = this.myDataLayoutControl;
            this.txtBankaAdi.TabIndex = 0;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.txtBankaAdi;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem6.Size = new System.Drawing.Size(396, 24);
            this.layoutControlItem6.Text = "Banka Adı";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(52, 13);
            // 
            // BankaEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 313);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(426, 314);
            this.Name = "BankaEditForm";
            this.Text = "Banka Kartı";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgwDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOzelKod1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOzelKod2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UserControls.Controls.MyTextEdit txtBankaAdi;
        private UserControls.Controls.MyButtonEdit txtOzelKod2;
        private UserControls.Controls.MyButtonEdit txtOzelKod1;
        private UserControls.Controls.MyKodTextEdit txtKod;
        private UserControls.Controls.MyMemoEdit txtAciklama;
        private UserControls.Controls.MyToogleSwitch tgwDurum;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}