using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Common.Functions;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BankaForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BankaHesapForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BankaSubeForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.IptalNedeniForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.KasaForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.OkulForms;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.YakinlikForms;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.UI.Win.Functions
{
    public static class SelectRepositoryFunctions
    {
        #region Variables

        private static GridView _tablo;
        private static ControlNavigator _navigator;
        private static RepositoryItemButtonEdit _buttonEdit;
        private static GridColumn _idColumn;
        private static GridColumn _nameColumn;
        private static GridColumn _prmIdColumn;
        private static GridColumn _prmNameColumn;

        #endregion

        private static void RemoveEvents()
        {
            if (_buttonEdit == null) return;

            // RepositoryItemButtonEdit Events Clear/Remove Process
            _buttonEdit.ButtonClick -= ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown -= ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick -= ButtonEdit_DoubleClick;

            // GridView Events Clear/Remove Process
            _tablo.KeyDown -= Tablo_KeyDown;
        }

        public static void Sec(this GridColumn nameColumn, GridView tablo, ControlNavigator navigator, RepositoryItemButtonEdit buttonEdit, GridColumn idColumn)
        {
            RemoveEvents();

            _tablo = tablo;
            _navigator = navigator;
            _buttonEdit = buttonEdit;
            _idColumn = idColumn;
            _nameColumn = nameColumn;

            // RepositoryItemButtonEdit Events Add Process
            _buttonEdit.ButtonClick += ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown += ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick += ButtonEdit_DoubleClick;

            // GridView Events Add Process
            _tablo.KeyDown += Tablo_KeyDown;
        }

        public static void Sec(this GridColumn nameColumn, GridView tablo, ControlNavigator navigator, RepositoryItemButtonEdit buttonEdit, GridColumn idColumn, GridColumn prmNameColumn, GridColumn prmIdColumn)
        {
            RemoveEvents();

            _tablo = tablo;
            _navigator = navigator;
            _buttonEdit = buttonEdit;
            _idColumn = idColumn;
            _nameColumn = nameColumn;
            _prmIdColumn = prmIdColumn;
            _prmNameColumn = prmNameColumn;

            // RepositoryItemButtonEdit Events Add Process
            _buttonEdit.ButtonClick += ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown += ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick += ButtonEdit_DoubleClick;

            // GridView Events Add Process
            _tablo.KeyDown += Tablo_KeyDown;
        }

        private static void SecimYap()
        {
            switch (_buttonEdit.Name)
            {
                case "repositoryYakinlik":
                    {
                        long? id = _tablo.GetRowCellId(_idColumn); // Kendi Yazdığımız Exstansion Method İle Verilen Columndaki Id Değerini Return Ettiriyoruz.
                        var entity = (Yakinlik)ShowListForms<YakinlikListForm>.ShowDialogListForm(KartTuru.Yakinlik, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.YakinlikAdi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;
                case "repositoryBanka":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;

                        var id = _tablo.GetRowCellId(_idColumn); // Kendi Yazdığımız Exstansion Method İle Verilen Columndaki Id Değerini Return Ettiriyoruz.
                        var entity = (BankaL)ShowListForms<BankaListForm>.ShowDialogListForm(KartTuru.Banka, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.BankaAdi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;
                case "repositoryBankaSube":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;

                        long id = Convert.ToInt64(_tablo.GetRowCellId(_idColumn));
                        long bankaId = Convert.ToInt64(_tablo.GetRowCellId(_prmIdColumn));
                        var bankaAdi = _tablo.GetFocusedRowCellValue(_prmNameColumn).ToString();

                        var entity = (BankaSube)ShowListForms<BankaSubeListForm>.ShowDialogListForm(KartTuru.BankaSube, id, bankaId, bankaAdi);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.SubeAdi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;
                case "repositoryIptalNedeni":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;

                        var id = _tablo.GetRowCellId(_idColumn);
                        var entity = (IptalNedeni)ShowListForms<IptalNedeniListForm>.ShowDialogListForm(KartTuru.IptalNedeni, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.IptalNedeniAdi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;
                case "repositoryGittigiOkul":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;

                        var id = _tablo.GetRowCellId(_idColumn);
                        var entity = (OkulL)ShowListForms<OkulListForm>.ShowDialogListForm(KartTuru.Okul, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.OkulAdi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;
                case "repositoryBankaHesap":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;

                        var id = _tablo.GetRowCellId(_idColumn);
                        var odemeTipi = _tablo.GetFocusedRowCellValue("OdemeTipi").ToString().GetEnum<OdemeTipi>();

                        /*
                         * Mola verme zorudayım şuanda uykum var ve o yüzden anlayamıyorum
                         * Hatta Anlamayı Bırak Klavyeyi Bile Şuanda Düzgün Kullanıyorum
                         * Bunu Yazarken Bi 15 Hata Falan Yaptım. Uyumam Lazım
                         * Yarın Devam
                         * 19.11.2020 22:22
                         * Video : 32.40
                         * Biraz video izler uyurum
                         * İyi Geceler.
                         */

                        var entity = (BankaHesapL)ShowListForms<BankaHesapListForm>.ShowDialogListForm(KartTuru.BankaHesap, id, odemeTipi);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.HesapAdi);
                            _tablo.SetFocusedRowCellValue("BlokeGunSayisi", entity.BlokeGunSayisi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;
                case "repositoryHesap":
                    {
                        var id = _tablo.GetRowCellId(_idColumn);

                        switch (_tablo.GetRow<GeriOdemeBilgileriL>().GeriOdemeHesapTuru)
                        {
                            case GeriOdemeHesapTuru.Banka:
                                var bankaEntity = (BankaHesapL)ShowListForms<BankaHesapListForm>.ShowDialogListForm(KartTuru.BankaHesap, id, OdemeTipi.Elden);
                                if (bankaEntity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, bankaEntity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, bankaEntity.HesapAdi);
                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                                break;
                            case GeriOdemeHesapTuru.Kasa:
                                var kasaEntity = (KasaL)ShowListForms<KasaListForm>.ShowDialogListForm(KartTuru.Kasa, id);
                                if (kasaEntity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, kasaEntity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, kasaEntity.KasaAdi);
                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                                break;
                        }
                    }
                    break;
            }
        }

        private static void ButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            SecimYap();
        }

        private static void ButtonEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                // Eğer Ctrl + Shift + Delete Tuşuna Basılırsa Çalışıcak.
                case Keys.Delete when e.Control && e.Shift:
                    _tablo.SetFocusedRowCellValue(_idColumn, null); // Verilen IdColumn'unun Değerini Null Yapar.
                    _tablo.SetFocusedRowCellValue(_nameColumn, null); // Verilen NameColumn'un Değerini Null Yapar.
                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit); // Navigatordan EndEdit Tuşuna Basılmasını İşlemini Gerçekleştirir.
                    break;

                // F4 veya Down + Alt Tuşuna Basıldığında Çalışıcak Kod Bloğu.
                case Keys.F4:
                case Keys.Down when e.Alt:
                    SecimYap();
                    break;
            }
        }

        private static void ButtonEdit_DoubleClick(object sender, EventArgs e)
        {
            SecimYap();
        }

        private static void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            if (_tablo.FocusedColumn.ColumnEdit == null) return;

            var type = _tablo.FocusedColumn.ColumnEdit.GetType();
            if (type != typeof(RepositoryItemButtonEdit)) return;

            switch (e.KeyCode)
            {
                case Keys.Delete when e.Control && e.Shift:
                    _tablo.SetFocusedRowCellValue(_idColumn, null);
                    _tablo.SetFocusedRowCellValue(_nameColumn, null);
                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                    break;
                case Keys.F4:
                case Keys.Down when e.Alt:
                    SecimYap();
                    break;
            }
        }
    }
}