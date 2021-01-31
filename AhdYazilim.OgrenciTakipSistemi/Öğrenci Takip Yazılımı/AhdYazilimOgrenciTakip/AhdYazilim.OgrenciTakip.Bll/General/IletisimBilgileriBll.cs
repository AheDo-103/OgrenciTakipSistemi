using AhdYazilim.OgrenciTakip.Bll.Base;
using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using AhdYazilim.OgrenciTakip.Data.Contexts;
using AhdYazilim.OgrenciTakip.Model.Dto;
using AhdYazilim.OgrenciTakip.Model.Entities;
using AhdYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AhdYazilim.OgrenciTakip.Bll.General
{
    public class IletisimBilgileriBll : BaseHareketBll<IletisimBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<IletisimBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<IletisimBilgileri, bool>> filter)
        {
            return List(filter, x => new IletisimBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                IletisimId = x.IletisimId,
                YakinlikId = x.YakinlikId,
                TcKimlikNo = x.Iletisim.TcKimlikNo,
                Adi = x.Iletisim.Adi,
                Soyadi = x.Iletisim.Soyadi,
                EvTel = x.Iletisim.EvTelefonu,
                IsTel1 = x.Iletisim.IsTelefonu1,
                IsTel2 = x.Iletisim.IsTelefonu2,
                CepTel1 = x.Iletisim.CepTelefonu1,
                CepTel2 = x.Iletisim.CepTelefonu2,
                EvAdresi = x.Iletisim.EvAdresi,
                EvAdresiIlAdi = x.Iletisim.EvAdresIl.IlAdi,
                EvAdresIlceAdi = x.Iletisim.EvAdresIlce.IlceAdi,
                IsAdresi = x.Iletisim.IsAdres,
                IsAdresiIlAdi = x.Iletisim.IsAdresIl.IlAdi,
                IsAdresiIlceAdi = x.Iletisim.IsAdresIlce.IlceAdi,
                YakinlikAdi = x.Yakinlik.YakinlikAdi,
                MeslekAdi = x.Iletisim.Meslek.MeslekAdi,
                IsyeriAdi = x.Iletisim.Isyeri.IsyeriAdi,
                GorevAdi = x.Iletisim.Gorev.GorevAdi,
                Veli = x.Veli,
                AdresTuru = x.AdresTuru,
            }).ToList();
        }
    }
}