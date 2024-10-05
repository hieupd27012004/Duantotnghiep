using AppAPI.Repository;
using AppData.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppAPI.Service
{
    public class Servicegiaygiay : IServicegiaygiay
    {
        private readonly IRepogiaygiay _repository;

        public Servicegiaygiay(IRepogiaygiay repository)
        {
            _repository = repository;
        }
        public bool Create(DayGiay dayGiay)
        {
            return _repository.Create(dayGiay);
        }

        public bool Delete(Guid id)
        {
            return _repository.Delete(id);
        }

        public DayGiay GetDayGiayById(Guid id)
        {
            return _repository.GetDayGiayById(id);
        }

        public List<DayGiay> GetDayGiay()
        {
            return _repository.GetDayGiay();
        }

        public bool Update(DayGiay dayGiay)
        {
            return _repository.Update(dayGiay);
        }
    }
}