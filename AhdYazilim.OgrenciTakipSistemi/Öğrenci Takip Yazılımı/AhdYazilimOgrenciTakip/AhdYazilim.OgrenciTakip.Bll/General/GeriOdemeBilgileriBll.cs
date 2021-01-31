using AhdYazilim.OgrenciTakip.Bll.Base;
using AhdYazilim.OgrenciTakip.Bll.Interfaces;
using AhdYazilim.OgrenciTakip.Common.Enums;
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
    public class GeriOdemeBilgileriBll : BaseHareketBll<GeriOdemeBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<GeriOdemeBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<GeriOdemeBilgileri, bool>> filter)
        {
            return List(filter, x => new GeriOdemeBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Tarih = x.Tarih,
                GeriOdemeHesapTuru = x.GeriOdemeHesapTuru,
                HesapId = x.GeriOdemeHesapTuru == GeriOdemeHesapTuru.Kasa ? x.KasaId : x.BankaHesapId,
                HesapAdi = x.GeriOdemeHesapTuru == GeriOdemeHesapTuru.Kasa ? x.Kasa.KasaAdi : x.BankaHesap.HesapAdi,
                BankaHesapId = x.BankaHesapId,
                KasaId = x.KasaId,
                Tutar = x.Tutar,
                Aciklama = x.Aciklama,
            }).ToList();
        }
    }
}