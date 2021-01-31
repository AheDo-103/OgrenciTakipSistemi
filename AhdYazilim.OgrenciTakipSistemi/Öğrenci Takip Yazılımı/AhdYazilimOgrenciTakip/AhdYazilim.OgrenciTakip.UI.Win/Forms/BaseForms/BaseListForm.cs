using DevExpress.XtraBars;
using AhdYazilim.OgrenciTakip.UI.Win.Show.Interfaces;
using AhdYazilim.OgrenciTakip.Common.Enums;
using DevExpress.XtraGrid.Views.Grid;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using System;
using System.Windows.Forms;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using DevExpress.Utils.Extensions;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.FiltreForms;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.Common.Message;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using System.Collections.Generic;
using DevExpress.XtraBars.Ribbon;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseKartlarForm : RibbonForm
    {
        #region Variables

        private long _filtreId;
        private bool _formSablonKayitEdilecek;
        private bool _tabloSablonKayitEdilecek;

        protected IBaseFormShow FormShow;
        protected KartTuru KartTuru;
        protected bool AktifKartlariGoster = true;
        protected IBaseBll Bll;
        protected ControlNavigator Navigator;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;

        protected internal bool MultiSelect;
        protected internal BaseEntity SelectedEntity;
        protected internal IList<BaseEntity> SelectedEntities;
        protected internal GridView Tablo;
        protected internal bool AktifPasifButonGoster = false;
        protected internal long? SeciliGelecekId;
        protected internal IList<long> ListeDisiTutulacakKayitlar;
        protected internal SelectRowFunctions RowSelect;
        protected internal bool EklenebilecekEntityVar = false;

        #endregion

        public BaseKartlarForm()
        {
            InitializeComponent();
        }

        private void EventsLoad()
        {
            // Button Events
            foreach (BarItem button in ribbonControl.Items)
                button.ItemClick += Button_ItemClick;

            // Table Events
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.KeyDown += Tablo_KeyDown;
            Tablo.MouseUp += Tablo_MouseUp;
            Tablo.ColumnWidthChanged += Tablo_ColumnWidthChanged;
            Tablo.ColumnPositionChanged += Tablo_ColumnPositionChanged;
            Tablo.EndSorting += Tablo_EndSorting;
            Tablo.FilterEditorCreated += Tablo_FilterEditorCreated;
            Tablo.ColumnFilterChanged += Tablo_ColumnFilterChanged;
            Tablo.CustomDrawFooterCell += Tablo_CustomDrawFooterCell;
            Tablo.FocusedRowObjectChanged += Tablo_FocusedRowObjectChanged;
            Tablo.RowDeleted += Tablo_RowDeleted;

            // Form Events
            Shown += BaseKartlarForm_Shown;
            Load += BaseKartlarForm_Load;
            FormClosing += BaseKartlarForm_FormClosing;
            LocationChanged += BaseKartlarForm_LocationChanged;
            SizeChanged += BaseKartlarForm_SizeChanged;
        }


        // Private Methods

        private void ButonGizleGoster()
        {
            btnSec.Visibility = AktifPasifButonGoster ? BarItemVisibility.Never : IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barEnter.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barEnterAciklama.Visibility = IsMdiChild == true ? BarItemVisibility.Never : BarItemVisibility.Always;
            btnAktifPasifKartlar.Visibility = AktifPasifButonGoster ? BarItemVisibility.Always : !IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;

            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }

        private void SablonKaydet()
        {
            if (_formSablonKayitEdilecek)
                Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);

            if (_tabloSablonKayitEdilecek)
                Tablo.TabloSablonKaydet(IsMdiChild ? Name + " Tablosu" : Name + " TablosuMDI");
        }

        private void SablonYukle()
        {
            if (IsMdiChild)
                Tablo.TabloSablonYukle(Name + " Tablosu");
            else
            {
                Name.FormSablonYukle(this);
                Tablo.TabloSablonYukle(Name + " TablosuMDI");
            }
        }

        private void FormCaptionAyarla()
        {
            if (btnAktifPasifKartlar == null)
            {
                Listele();
                return;
            }

            if (AktifKartlariGoster)
            {
                btnAktifPasifKartlar.Caption = "Pasif Kartlar";
                Tablo.ViewCaption = Text;
            }
            else
            {
                btnAktifPasifKartlar.Caption = "Aktif Kartlar";
                Tablo.ViewCaption = Text + " - Pasif Kartlar";
            }
            Listele();
        }

        private void IslemTuruSec()
        {
            if (!IsMdiChild)
            {
                // Güncellenecek

                SelectEntity();
            }
            else
            {
                btnDuzelt.PerformClick();
            }
        }

        private void FiltreSec()
        {
            var entity = (Filtre)ShowListForms<FiltreListForm>.ShowDialogListForm(KartTuru.Filtre, _filtreId, KartTuru, Tablo.GridControl);
            if (entity == null) return;

            _filtreId = entity.Id;
            Tablo.ActiveFilterString = entity.FiltreMetni;
        }


        // Protected Methods
        protected void ShowEditFormDefault(long id)
        {
            if (id <= 0) return;
            AktifKartlariGoster = true;
            FormCaptionAyarla();
            Tablo.RowFocus("Id", id);
        }


        // Protected Virtual Methods
        protected virtual void SelectEntity()
        {
            if (MultiSelect)
            {
                SelectedEntities = new List<BaseEntity>();
                if (RowSelect.SelectedRowCount <= 0)
                {
                    Messages.KartSecmemeUyariMesaji(); return;
                }
                else
                    SelectedEntities = RowSelect.GetSelectedRows();
            }
            else
                SelectedEntity = Tablo.GetRow<BaseEntity>();

            DialogResult = DialogResult.OK;
            Close();
        }

        protected virtual void DegiskenleriDoldur() { }

        protected virtual void ShowEditForm(long id)
        {
            var result = FormShow.ShowDialogEditForm(KartTuru, id);
            ShowEditFormDefault(result);
        }

        protected virtual void EntityDelete()
        {
            var entity = Tablo.GetRow<BaseEntity>();

            if (entity == null)
                return;

            if (!((IBaseCommonBll)Bll).Delete(entity)) return;

            Tablo.DeleteSelectedRows();
            Tablo.RowFocus(Tablo.FocusedRowHandle);
        }

        protected virtual void Listele() { }

        protected virtual void Yazdir()
        {
            TablePrintingFunctions.Yazdir(Tablo, Tablo.ViewCaption, AnaForm.SubeAdi);
        }

        protected virtual void BaskiOnizleme() { }

        protected virtual void BagliKartAc() { }

        protected virtual void BelgeHareketleri() { }

        protected virtual void Duzelt() { }

        protected virtual void ColumnShowHide() { }


        // Protected Internal Methods
        protected internal void Yukle()
        {
            DegiskenleriDoldur();
            EventsLoad();

            //Tablo.OptionsMenu.ShowAutoFilterRowItem = false;
            //Tablo.OptionsView.ShowAutoFilterRow = false;
            Tablo.OptionsSelection.MultiSelect = MultiSelect;
            Navigator.NavigatableControl = Tablo.GridControl;

            Cursor.Current = Cursors.WaitCursor;
            Listele();
            Cursor.Current = DefaultCursor;

            // Güncellenecek
        }

        protected virtual void TahakkukYap() { }


        // Full Events

        protected virtual void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.Item == btnGonder)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item == btnStandartExcelDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.ExcelStandart, e.Item.Caption, Text);

            else if (e.Item == btnFormatliExcelDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.ExcelFormatli, e.Item.Caption, Text);

            else if (e.Item == btnFormatsizExcelDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.ExcelFormatsiz, e.Item.Caption, Text);

            else if (e.Item == btnWordDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.WordDosyasi, e.Item.Caption);

            else if (e.Item == btnPdfDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.PdfDosyayi, e.Item.Caption);

            else if (e.Item == btnTxtDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.TxtDosyasi, e.Item.Caption);

            else if (e.Item == btnYeni)
            {
                // Yetki Kontrolü
                ShowEditForm(-1);
            }
            else if (e.Item == btnDuzelt)
            {
                ShowEditForm(Tablo.GetRowId());
            }
            else if (e.Item == btnSil)
            {
                // Yetki Kontrolü
                EntityDelete();
            }
            else if (e.Item == btnSec)
            {
                SelectEntity();
            }
            else if (e.Item == btnYenile)
            {
                Listele();
            }
            else if (e.Item == btnFiltrele)
                FiltreSec();
            else if (e.Item == btnKolonlar)
            {
                if (Tablo.CustomizationForm == null)
                    Tablo.ShowCustomization();
                else
                    Tablo.HideCustomization();
            }
            else if (e.Item == btnTahakkukYap)
            {
                TahakkukYap();
            }
            else if (e.Item == btnBelgeHareketleri)
            {
                BelgeHareketleri();
            }
            else if (e.Item == btnBagliKartlar)
            {
                BagliKartAc();
            }
            else if (e.Item == btnYazdir)
            {
                Yazdir();
            }
            else if (e.Item == btnTabloYazdir)
            {
                TablePrintingFunctions.Yazdir(Tablo, Tablo.ViewCaption, AnaForm.SubeAdi);
            }
            else if (e.Item == btnBaskiOnizleme)
            {
                BaskiOnizleme();
            }
            else if (e.Item == btnTasarimDegistir)
            {
                Duzelt();
            }
            else if (e.Item == btnCikis)
            {
                Close();
            }
            else if (e.Item == btnAktifPasifKartlar)
            {
                AktifKartlariGoster = !AktifKartlariGoster;
                FormCaptionAyarla();
            }

            Cursor.Current = DefaultCursor;
        }


        // Table Events
        private void Tablo_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            IslemTuruSec();
            Cursor.Current = DefaultCursor;
        }

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    IslemTuruSec();
                    break;

                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            e.SagMenuGoster(sagMenu);
        }

        private void Tablo_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        private void Tablo_ColumnPositionChanged(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        private void Tablo_EndSorting(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        private void Tablo_FilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e)
        {
            e.ShowFilterEditor = false;
            ShowEditForms<FiltreEditForm>.ShowDialogEditForm(KartTuru.Filtre, _filtreId, KartTuru, Tablo.GridControl);
        }

        private void Tablo_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tablo.ActiveFilterString))
                _filtreId = 0;
        }

        private void Tablo_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (!Tablo.OptionsView.ShowFooter) return;
            if (e.Column.Summary.Count > 0)
            {
                e.Appearance.TextOptions.HAlignment = e.Column.ColumnEdit.Appearance.HAlignment;
            }
        }

        private void Tablo_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            ColumnShowHide();
        }

        private void Tablo_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            ColumnShowHide();
        }


        // Form Events
        private void BaseKartlarForm_Shown(object sender, EventArgs e)
        {
            Tablo.Focus();
            ButonGizleGoster();
            ColumnShowHide();

            if (IsMdiChild || !SeciliGelecekId.HasValue) return;
            Tablo.RowFocus("Id", SeciliGelecekId);
        } // Güncellenecek

        private void BaseKartlarForm_Load(object sender, EventArgs e)
        {
            SablonYukle();
        }

        private void BaseKartlarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
        }

        private void BaseKartlarForm_LocationChanged(object sender, EventArgs e)
        {
            if (!IsMdiChild)
                _formSablonKayitEdilecek = true;
        }

        private void BaseKartlarForm_SizeChanged(object sender, EventArgs e)
        {
            if (!IsMdiChild)
                _formSablonKayitEdilecek = true;
        }
    }
}