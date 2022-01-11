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
    public class RegionService : IRegionServices
    {
        IRegionData _region;

        public RegionService( IRegionData region)
        {
            _region = region;
        }
        public ICollection<Region> GetAll()
        {
            var data = _region.GetAll();
            return data;
        }

        public Region GetById(int entityID)
        {
            var data = _region.GetById(a => a.Id == entityID);
            return data;
        }

        public void Insert(Region entity)
        {
            _region.Add(entity);
        }

        public void Remove(Region entity)
        {
            var data = _region.GetById(a => a.Id == entity.Id);
            _region.Delete(data);
        }

        public void Update(Region entity)
        {
            _region.Update(entity);
        }
    }
}
