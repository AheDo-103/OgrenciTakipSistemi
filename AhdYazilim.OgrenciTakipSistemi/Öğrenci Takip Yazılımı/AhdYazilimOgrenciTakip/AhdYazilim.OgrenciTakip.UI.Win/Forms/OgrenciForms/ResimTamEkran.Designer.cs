namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.OgrenciForms
{
    partial class ResimTamEkran
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl1 = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.pictureEditOgrenciResimTamEkran = new AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyPictureEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResimMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditOgrenciResimTamEkran.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(519, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.pictureEditOgrenciResimTamEkran);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(0, 102);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(519, 519);
            this.myDataLayoutControl1.TabIndex = 2;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // pictureEditOgrenciResimTamEkran
            // 
            this.pictureEditOgrenciResimTamEkran.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEditOgrenciResimTamEkran.EnterMoveNextControl = true;
            this.pictureEditOgrenciResimTamEkran.Location = new System.Drawing.Point(12, 12);
            this.pictureEditOgrenciResimTamEkran.MenuManager = this.ribbonControl;
            this.pictureEditOgrenciResimTamEkran.Name = "pictureEditOgrenciResimTamEkran";
            this.pictureEditOgrenciResimTamEkran.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.pictureEditOgrenciResimTamEkran.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEditOgrenciResimTamEkran.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.pictureEditOgrenciResimTamEkran.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.pictureEditOgrenciResimTamEkran.Properties.NullText = "Resim Yok";
            this.pictureEditOgrenciResimTamEkran.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditOgrenciResimTamEkran.Properties.ShowMenu = false;
            this.pictureEditOgrenciResimTamEkran.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEditOgrenciResimTamEkran.Size = new System.Drawing.Size(495, 495);
            this.pictureEditOgrenciResimTamEkran.StatusBarAciklama = "Öğrencinin Resmini Detaylı Görüntülemek İçin Büyük Formatta Açar.";
            this.pictureEditOgrenciResimTamEkran.StatusBarKisaYol = "";
            this.pictureEditOgrenciResimTamEkran.StatusBarKisaYolAciklama = null;
            this.pictureEditOgrenciResimTamEkran.StyleController = this.myDataLayoutControl1;
            this.pictureEditOgrenciResimTamEkran.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition2});
            rowDefinition2.Height = 100D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition2});
            this.Root.Size = new System.Drawing.Size(519, 519);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.pictureEditOgrenciResimTamEkran;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(499, 499);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ResimTamEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 652);
            this.Controls.Add(this.myDataLayoutControl1);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(529, 653);
            this.Name = "ResimTamEkran";
            this.Text = "Öğrenci Resim Büyük Ekran";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResimMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditOgrenciResimTamEkran.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UserControls.Controls.MyPictureEdit pictureEditOgrenciResimTamEkran;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}