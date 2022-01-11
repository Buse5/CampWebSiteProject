using System;
using System.Collections.Generic;
using System.Text;

namespace CampModel
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            IsActive = true;
            CreateDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public Boolean IsActive { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
