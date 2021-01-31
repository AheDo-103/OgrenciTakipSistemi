namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.RehberForms
{
    partial class RehberEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.txtAciklama = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyMemoEdit();
            this.tgwDurum = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyToogleSwitch();
            this.txtTelefon2 = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyTelefonNoTextEdit();
            this.txtTelefon1 = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyTelefonNoTextEdit();
            this.txtAdiSoyadi = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
            this.txtKod = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyKodTextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtTelefonRow = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgwDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdiSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefonRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(436, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.txtAciklama);
            this.myDataLayoutControl.Controls.Add(this.tgwDurum);
            this.myDataLayoutControl.Controls.Add(this.txtTelefon2);
            this.myDataLayoutControl.Controls.Add(this.txtTelefon1);
            this.myDataLayoutControl.Controls.Add(this.txtAdiSoyadi);
            this.myDataLayoutControl.Controls.Add(this.txtKod);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 102);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(436, 180);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // txtAciklama
            // 
            this.txtAciklama.EnterMoveNextControl = true;
            this.txtAciklama.Location = new System.Drawing.Point(65, 108);
            this.txtAciklama.MenuManager = this.ribbonControl;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAciklama.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAciklama.Properties.MaxLength = 500;
            this.txtAciklama.Size = new System.Drawing.Size(359, 60);
            this.txtAciklama.StatusBarAciklama = "Açıklama Giriniz.";
            this.txtAciklama.StyleController = this.myDataLayoutControl;
            this.txtAciklama.TabIndex = 3;
            // 
            // tgwDurum
            // 
            this.tgwDurum.EnterMoveNextControl = true;
            this.tgwDurum.Location = new System.Drawing.Point(329, 12);
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
            // txtTelefon2
            // 
            this.txtTelefon2.EnterMoveNextControl = true;
            this.txtTelefon2.Location = new System.Drawing.Point(65, 84);
            this.txtTelefon2.MenuManager = this.ribbonControl;
            this.txtTelefon2.Name = "txtTelefon2";
            this.txtTelefon2.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTelefon2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTelefon2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtTelefon2.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtTelefon2.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.txtTelefon2.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d?\\d?\\d? \\d?\\d? \\d?\\d?";
            this.txtTelefon2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelefon2.Properties.MaxLength = 50;
            this.txtTelefon2.Size = new System.Drawing.Size(143, 20);
            this.txtTelefon2.StatusBarAciklama = "Telefon No Giriniz.";
            this.txtTelefon2.StyleController = this.myDataLayoutControl;
            this.txtTelefon2.TabIndex = 2;
            // 
            // txtTelefon1
            // 
            this.txtTelefon1.EnterMoveNextControl = true;
            this.txtTelefon1.Location = new System.Drawing.Point(65, 60);
            this.txtTelefon1.MenuManager = this.ribbonControl;
            this.txtTelefon1.Name = "txtTelefon1";
            this.txtTelefon1.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTelefon1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTelefon1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtTelefon1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtTelefon1.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.txtTelefon1.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d?\\d?\\d? \\d?\\d? \\d?\\d?";
            this.txtTelefon1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelefon1.Properties.MaxLength = 50;
            this.txtTelefon1.Size = new System.Drawing.Size(143, 20);
            this.txtTelefon1.StatusBarAciklama = "Telefon No Giriniz.";
            this.txtTelefon1.StyleController = this.myDataLayoutControl;
            this.txtTelefon1.TabIndex = 1;
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.EnterMoveNextControl = true;
            this.txtAdiSoyadi.Location = new System.Drawing.Point(65, 36);
            this.txtAdiSoyadi.MenuManager = this.ribbonControl;
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAdiSoyadi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAdiSoyadi.Properties.MaxLength = 50;
            this.txtAdiSoyadi.Size = new System.Drawing.Size(359, 20);
            this.txtAdiSoyadi.StatusBarAciklama = "Rehber Adı Soyadı Giriniz.";
            this.txtAdiSoyadi.StyleController = this.myDataLayoutControl;
            this.txtAdiSoyadi.TabIndex = 0;
            // 
            // txtKod
            // 
            this.txtKod.EnterMoveNextControl = true;
            this.txtKod.Location = new System.Drawing.Point(65, 12);
            this.txtKod.MenuManager = this.ribbonControl;
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtKod.Properties.Appearance.Options.UseBackColor = true;
            this.txtKod.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKod.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKod.Properties.MaxLength = 20;
            this.txtKod.Size = new System.Drawing.Size(143, 20);
            this.txtKod.StatusBarAciklama = "Kod Giriniz.";
            this.txtKod.StyleController = this.myDataLayoutControl;
            this.txtKod.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.txtTelefonRow,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 99D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 100D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.Root.Size = new System.Drawing.Size(436, 180);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtKod;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.Text = "Kod";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtAdiSoyadi;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(416, 24);
            this.layoutControlItem2.Text = "Adı Soyadı";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(50, 13);
            // 
            // txtTelefonRow
            // 
            this.txtTelefonRow.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.txtTelefonRow.AppearanceItemCaption.Options.UseForeColor = true;
            this.txtTelefonRow.Control = this.txtTelefon1;
            this.txtTelefonRow.Location = new System.Drawing.Point(0, 48);
            this.txtTelefonRow.Name = "txtTelefonRow";
            this.txtTelefonRow.OptionsTableLayoutItem.RowIndex = 2;
            this.txtTelefonRow.Size = new System.Drawing.Size(200, 24);
            this.txtTelefonRow.Text = "Telefon-1";
            this.txtTelefonRow.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtTelefon2;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.Text = "Telefon-2";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.tgwDurum;
            this.layoutControlItem5.Location = new System.Drawing.Point(317, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem5.Size = new System.Drawing.Size(99, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.txtAciklama;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem6.Size = new System.Drawing.Size(416, 64);
            this.layoutControlItem6.Text = "Açıklama";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(50, 13);
            // 
            // RehberEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 313);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(440, 314);
            this.Name = "RehberEditForm";
            this.Text = "Rehber Kartı";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgwDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdiSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefonRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UserControls.Controls.MyMemoEdit txtAciklama;
        private UserControls.Controls.MyToogleSwitch tgwDurum;
        private UserControls.Controls.MyTelefonNoTextEdit txtTelefon2;
        private UserControls.Controls.MyTelefonNoTextEdit txtTelefon1;
        private UserControls.Controls.MyTextEdit txtAdiSoyadi;
        private UserControls.Controls.MyKodTextEdit txtKod;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem txtTelefonRow;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}