using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Message;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.UI.Win.Interfaces;
using AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls;
using AhdYazilim.OgrenciTakip.UI.Win.UserControls.Grid;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Native;
using AhdYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using DevExpress.XtraBars.Navigation;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        #region Variables

        private bool _formSablonKayitEdilecek;
        protected MyDataLayoutControl DataLayoutControl;
        protected MyDataLayoutControl[] DataLayoutControls;
        protected IBaseBll Bll;
        protected KartTuru KartTuru;
        protected BaseEntity OldEntity;
        protected BaseEntity CurrentEntity;
        protected bool IsLoaded;
        protected bool KayitSonrasiFormuKapat = true;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected bool FarkliSubeIslemi;
        protected internal IslemTuru IslemTuru;
        protected internal long Id;
        protected internal bool RefreshYapilacak;

        #endregion

        public BaseEditForm()
        {
            InitializeComponent();
        }

        protected void EventsLoad()
        {
            // Button Events
            foreach (BarItem button in ribbonControl.Items)
                button.ItemClick += Button_ItemClick;

            // Form Events
            LocationChanged += BaseEditForm_LocationChanged;
            SizeChanged += BaseEditForm_SizeChanged;
            Load += BaseEditForm_Load;
            FormClosing += BaseEditForm_FormClosing;
            Shown += BaseEditForm_Shown;

            void ControlEvents(Control control)
            {
                control.KeyDown += Control_KeyDown;
                control.GotFocus += Control_GotFocus;
                control.Leave += Control_Leave;
                control.Enter += Control_Enter;

                switch (control)
                {
                    case FilterControl edit:
                        edit.FilterChanged += Control_EditValueChanged;
                        break;
                    case ComboBoxEdit edit:
                        edit.EditValueChanged += Control_EditValueChanged;
                        edit.SelectedValueChanged += Control_SelectedValueChanged;
                        break;
                    case MyButtonEdit edit:
                        edit.IdChanged += Control_IdChanged;
                        edit.EnabledChange += Control_EnabledChange;
                        edit.ButtonClick += Control_ButtonClick;
                        edit.DoubleClick += Control_DoubleClick;
                        break;
                    case BaseEdit edit:
                        edit.EditValueChanged += Control_EditValueChanged;
                        break;
                    case TabPane tab:
                        tab.SelectedPageChanged += Control_SelectedPageChanged;
                        break;
                }
            }

            if (DataLayoutControls == null)
            {
                if (DataLayoutControl == null) return;

                foreach (Control ctrl in DataLayoutControl.Controls)
                    ControlEvents(ctrl);
            }
            else
            {
                foreach (var layout in DataLayoutControls)
                    foreach (Control ctrl in layout.Controls)
                        ControlEvents(ctrl);
            }
        }

        // Private Methods
        protected virtual void EntityDelete()
        {
            if (!((IBaseCommonBll)Bll).Delete(OldEntity)) return;
            RefreshYapilacak = true;
            Close();
        }

        private void ButonGizleGoster()
        {
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }

        private void GeriAl()
        {
            if (Messages.HayirSeciliEvetHayir("Yapılan Değişiklikler Geri Alınacaktır. Onaylıyor Musunuz?", "Geri Al Onay") != DialogResult.Yes)
                return;

            if (IslemTuru == IslemTuru.EntityUpdate)
                Yukle();
            else
                Close();
        }

        private bool Kaydet(bool kapanis)
        {
            bool KayitIslemi()
            {
                Cursor.Current = Cursors.WaitCursor;
                switch (IslemTuru)
                {
                    case IslemTuru.EntityInsert:
                        if (EntityInsert())
                            return KayitSonrasiIslemler();
                        break;

                    case IslemTuru.EntityUpdate:
                        if (EntityUpdate())
                        {
                            Cursor.Current = DefaultCursor;
                            return KayitSonrasiIslemler();
                        }
                        break;
                }

                bool KayitSonrasiIslemler()
                {
                    OldEntity = CurrentEntity;
                    RefreshYapilacak = true;
                    ButonEnabledDurumu();

                    if (KayitSonrasiFormuKapat)
                        Close();
                    else
                        IslemTuru = IslemTuru == IslemTuru.EntityInsert ? IslemTuru.EntityUpdate : IslemTuru;

                    Cursor.Current = DefaultCursor;
                    return true;
                }

                Cursor.Current = DefaultCursor;
                return false;
            }

            var result = kapanis ? Messages.KapanisMesaj() : Messages.KayitMesaj();

            switch (result)
            {
                case DialogResult.Yes:
                    return KayitIslemi();

                case DialogResult.No:
                    if (kapanis)
                        btnKaydet.Enabled = false;
                    return true;

                case DialogResult.Cancel:
                    return false;
            }

            return false;
        }

        private void FarkliKaydet()
        {
            if (Messages.EvetSeciliEvetHayir("Bu Filtre Referans Alınarak Yeni Bir Filtre Oluşturulacaktır. Onaylıyor musunuz?", "Kayıt Onay") != DialogResult.Yes)
                return;
            IslemTuru = IslemTuru.EntityInsert;
            Yukle();
            if (Kaydet(true))
                Close();
        }

        private void SablonYukle()
        {
            Name.FormSablonYukle(this);
        }


        // Protected Methods
        protected void SablonKaydet()
        {
            if (_formSablonKayitEdilecek)
            {
                Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);
            }
        }


        // Protected Virtual Methods
        protected virtual void FiltreUygula() { }

        protected virtual void TaksitOlustur() { }

        protected virtual void BaskiOnIzleme() { }

        protected virtual void Yazdir() { }

        protected virtual void SecimYap(object sender) { }

        protected virtual bool EntityInsert()
        {
            return ((IBaseGenelBll)Bll).Insert(CurrentEntity);
        }

        protected virtual bool EntityUpdate()
        {
            return ((IBaseGenelBll)Bll).Update(OldEntity, CurrentEntity);
        }

        protected virtual void NesneyiKontrollereBagla() { }

        protected virtual void GuncelNesneOlustur() { }

        protected virtual void TabloYukle() { }

        protected virtual void BagliTabloYukle() { }

        protected virtual bool BagliTabloKaydet() { return false; }

        protected virtual bool BagliTabloHataliGirisKontrol() { return false; }


        // Protected Internal Methods
        protected internal virtual void Yukle() { }

        protected internal virtual IBaseEntity ReturnEntity() { return null; }

        protected internal virtual void ButonEnabledDurumu()
        {
            if (!IsLoaded)
                return;
            GeneralFunctions.ButonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity);
        }

        protected virtual void ResimDondur() { }


        // Full Events

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.Item == btnYeni)
            {
                // Yetki Kontrolü

                IslemTuru = IslemTuru.EntityInsert;
                Yukle();
            }
            else if (e.Item == btnKaydet)
            {
                Kaydet(false);
            }
            else if (e.Item == btnFarkliKaydet)
            {
                // Yetki Kontrolü

                FarkliKaydet();
            }
            else if (e.Item == btnGeriAl)
            {
                GeriAl();
            }
            else if (e.Item == btnSil)
            {
                // Yetki Kontrolü

                EntityDelete();
            }
            else if (e.Item == btnUygula)
            {
                FiltreUygula();
            }
            else if (e.Item == btnTaksitOlustur)
            {
                TaksitOlustur();
            }
            else if (e.Item == btnYazdir)
            {
                Yazdir();
            }
            else if (e.Item == btnBaskiOnizleme)
            {
                BaskiOnIzleme();
            }
            else if (e.Item == btnDondur)
            {
                ResimDondur();
            }
            else if (e.Item == btnCikis)
            {
                Close();
            }


            Cursor.Current = DefaultCursor;
        }


        // Form Events
        private void BaseEditForm_LocationChanged(object sender, EventArgs e)
        {
            _formSablonKayitEdilecek = true;
        }

        private void BaseEditForm_SizeChanged(object sender, EventArgs e)
        {
            _formSablonKayitEdilecek = true;
        }

        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
            GuncelNesneOlustur();
            SablonYukle();
            ButonGizleGoster();

            if (FarkliSubeIslemi)
                Messages.UyariMesaji("İşlem Yapılan Kart Çalışılan Şube Veya Dönemde Olmadığı İçin Yapılan Değişiklikler Kayıt Edilemez.");
        }

        protected virtual void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();

            if (btnKaydet.Visibility == BarItemVisibility.Never || !btnKaydet.Enabled) return;

            if (!Kaydet(true))
                e.Cancel = true;
        }

        protected virtual void BaseEditForm_Shown(object sender, EventArgs e) { }


        // Control Events
        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            if (sender is MyButtonEdit edit)
                switch (e.KeyCode)
                {
                    case Keys.Delete when e.Control && e.Shift:
                        edit.Id = null;
                        edit.EditValue = null;
                        break;

                    case Keys.F4:
                    case Keys.Down when e.Modifiers == Keys.Alt:
                        SecimYap(edit);
                        break;
                }
        }

        private void Control_GotFocus(object sender, EventArgs e)
        {
            var type = sender.GetType();
            if (type == typeof(MyButtonEdit) || type == typeof(MyGridView) || type == typeof(MyPictureEdit) || type == typeof(MyComboBoxEdit) || type == typeof(MyDateEdit) || type == typeof(MyCalcEdit))
            {
                statusBarKisaYol.Visibility = BarItemVisibility.Always;
                statusBarKisaYolAciklama.Visibility = BarItemVisibility.Always;

                statusBarAciklama.Caption = ((IStatusBarAciklama)sender).StatusBarAciklama;
                statusBarKisaYol.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYol;
                statusBarKisaYolAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYolAciklama;
            }
            else if (sender is IStatusBarAciklama control)
            {
                statusBarAciklama.Caption = control.StatusBarAciklama;
            }
        }

        private void Control_Leave(object sender, EventArgs e)
        {
            statusBarKisaYol.Visibility = BarItemVisibility.Never;
            statusBarKisaYolAciklama.Visibility = BarItemVisibility.Never;
        }

        protected virtual void Control_Enter(object sender, EventArgs e) { }


        // Other Events
        protected virtual void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;
            GuncelNesneOlustur();
        }

        protected virtual void Control_SelectedValueChanged(object sender, EventArgs e) { }

        protected virtual void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (!IsLoaded) return;
            GuncelNesneOlustur();
        }

        protected virtual void Control_EnabledChange(object sender, EventArgs e) { }

        private void Control_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SecimYap(sender);
        }

        private void Control_DoubleClick(object sender, EventArgs e)
        {
            SecimYap(sender);
        }

        protected virtual void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e) { }
    }
}