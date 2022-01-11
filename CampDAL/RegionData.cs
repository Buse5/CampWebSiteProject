using CampData;
using CampData.Abstract;
using CampData.EntityFrameWork;
using CampModel.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CampData
{
    public class RegionData : EFRepositoryBase<Region, CampDbContext>,IRegionData
    {

    }
}
