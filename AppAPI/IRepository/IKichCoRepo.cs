﻿using AppData.Model;

namespace AppAPI.IRepository
{
    public interface IKichCoRepo
    {
        List<KichCo> GetKichCo(string? name);
        KichCo GetKichCoById(Guid id);
        bool Create(KichCo kichCo);
        bool Update(KichCo kichCo);
        bool Delete(Guid id);
    }
}