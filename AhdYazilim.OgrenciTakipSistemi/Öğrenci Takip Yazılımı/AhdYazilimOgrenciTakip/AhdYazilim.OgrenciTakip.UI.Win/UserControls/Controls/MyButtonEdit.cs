﻿using AhdYazilim.OgrenciTakip.UI.Win.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Drawing;

namespace AhdYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyButtonEdit : ButtonEdit, IStatusBarKisaYol
    {
        private long? _id;

        public MyButtonEdit()
        {
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }
        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; }

        #region Events
        [Browsable(false)]
        public long? Id
        {
            get => _id;
            set
            {
                var oldValue = _id;
                var newValue = value;

                if (newValue.HasValue && oldValue.HasValue && newValue == oldValue) return;
                _id = value;


                IdChanged(this, new IdChangedEventArgs(oldValue, newValue));
                EnabledChange(this, EventArgs.Empty);
            }
        }

        public event EventHandler<IdChangedEventArgs> IdChanged = delegate { };
        public event EventHandler EnabledChange = delegate { };

        #endregion
    }

    public class IdChangedEventArgs : EventArgs
    {
        public IdChangedEventArgs(long? oldValue, long? newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        public long? OldValue { get; }
        public long? NewValue { get; set; }
    }
}