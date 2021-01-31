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
    public class SinifBll : BaseGenelBll<Sinif>, IBaseCommonBll
    {
        public SinifBll() : base(KartTuru.Sinif) { }

        public SinifBll(Control ctrl) : base(ctrl, KartTuru.Sinif) { }

        public override BaseEntity Single(Expression<Func<Sinif, bool>> filter)
        {
            return BaseSingle(filter, x => new SinifS
            {
                Id = x.Id,
                Kod = x.Kod,
                SinifAdi = x.SinifAdi,
                GrupId = x.GrupId,
                GrupAdi = x.Grup.GrupAdi,
                HedefOgrenciSayisi = x.HedefOgrenciSayisi,
                HedefCiro = x.HedefCiro,
                Aciklama = x.Aciklama,
                Durum = x.Durum,
                SubeId = x.SubeId
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Sinif, bool>> filter)
        {
            return BaseList(filter, x => new SinifL
            {
                Id = x.Id,
                Kod = x.Kod,
                SinifAdi = x.SinifAdi,
                HedefOgrenciSayisi = x.HedefOgrenciSayisi,
                GrupAdi = x.Grup.GrupAdi,
                HedefCiro = x.HedefCiro,
                Aciklama = x.Aciklama,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
