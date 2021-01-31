using AhdYazilim.OgrenciTakip.Model.Entities.Base;

namespace AhdYazilim.OgrenciTakip.Bll.Interfaces
{
    public interface IBaseGenelBll
    {
        bool Insert(BaseEntity entity);

        bool Update(BaseEntity oldEntity, BaseEntity currentEntity);

        string YeniKodVer();
    }
}