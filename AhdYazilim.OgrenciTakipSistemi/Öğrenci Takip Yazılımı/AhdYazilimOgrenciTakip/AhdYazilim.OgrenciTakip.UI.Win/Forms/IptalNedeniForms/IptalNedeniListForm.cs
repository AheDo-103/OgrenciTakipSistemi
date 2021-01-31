using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AhdYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AhdYazilim.OgrenciTakip.Bll.General;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.UI.Win.Show;
using AhdYazilim.OgrenciTakip.UI.Win.Functions;
using AhdYazilim.OgrenciTakip.Model.Entities;

namespace AhdYazilim.OgrenciTakip.UI.Win.Forms.IptalNedeniForms
{
    public partial class IptalNedeniListForm : BaseKartlarForm
    {
        public IptalNedeniListForm()
        {
            InitializeComponent();

            Bll = new IptalNedeniBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            KartTuru = KartTuru.IptalNedeni;
            FormShow = new ShowEditForms<IptalNedeniEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IptalNedeniBll)Bll).List(FilterFunctions.Filter<IptalNedeni>(AktifKartlariGoster));
        }
    }
}