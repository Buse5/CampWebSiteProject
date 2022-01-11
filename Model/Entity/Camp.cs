using System;
using System.Collections.Generic;
using System.Text;

namespace CampModel.Entity
{
   public class Camp : BaseEntity
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public bool IsPublish { get; set; }

        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public Region Region { get; set; }
        public int RegionId { get; set; }
    }
}
