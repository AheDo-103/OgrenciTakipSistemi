using AhdYazilim.OgrenciTakip.Bll.Base;
using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using AhdYazilim.OgrenciTakip.Common.Enums;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.Bll.General
{
    public class SubeBll : BaseGenelBll<Sube>, IBaseCommonBll, IBaseGenelBll
    {
        public SubeBll() : base(KartTuru.Sube) { }

        public SubeBll(Control ctrl) : base(ctrl, KartTuru.Sube) { }

        public override BaseEntity Single(Expression<Func<Sube, bool>> filter)
        {
            return BaseSingle(filter, x => new SubeS
            {
                Id = x.Id,
                Kod = x.Kod,
                SubeAdi = x.SubeAdi,
                Telefon = x.Telefon,
                Fax = x.Fax,
                IbanNo = x.IbanNo,
                Logo = x.Logo,
                GrupAdi = x.GrupAdi,
                SiraNo = x.SiraNo,
                Adres = x.Adres,
                AdresIlId = x.AdresIlId,
                AdresIlAdi = x.AdresIl.IlAdi,
                AdresIlceId = x.AdresIlceId,
                AdresIlceAdi = x.AdresIlce.IlceAdi,
                Durum = x.Durum,
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Sube, bool>> filter)
        {
            return BaseList(filter, x => new SubeL
            {
                Id = x.Id,
                Kod = x.Kod,
                SubeAdi = x.SubeAdi,
                Telefon = x.Telefon,
                Fax = x.Fax,
                IbanNo = x.IbanNo,
                GrupAdi = x.GrupAdi,
                SiraNo = x.SiraNo,
                Adres = x.Adres,
                AdresIlAdi = x.AdresIl.IlAdi,
                AdresIlceAdi = x.AdresIlce.IlceAdi,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
