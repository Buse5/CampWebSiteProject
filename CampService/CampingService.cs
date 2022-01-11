using CampData;
using CampData.Abstract;
using CampData.EntityFrameWork;
using CampModel.Entity;
using CampService.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CampService
{
    public class CampingService :ICampingServices
    {
        ICampingData _camp;

        public CampingService(ICampingData camp)
        {
            _camp = camp;
        }
        public ICollection<Camp> GetAll()
        {
            var data = _camp.GetAll();
            return data;
        }

        public Camp GetById(int entityID)
        {
            var data = _camp.GetById(a => a.Id == entityID);
            return data;
        }

        public void Insert(Camp entity)
        {
            _camp.Add(entity);
        }

        public void Remove(Camp entity)
        {
            var data = _camp.GetById(a => a.Id == entity.Id);
            _camp.Delete(data);
        }

        public void Update(Camp entity)
        {
            _camp.Update(entity);
        }
    }
}
