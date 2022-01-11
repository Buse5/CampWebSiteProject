using System;
using System.Collections.Generic;
using System.Text;

namespace CampModel.Entity
{
   public class Region :BaseEntity
    {
        public virtual ICollection<City> citys  { get; set; }
        
    }
}
