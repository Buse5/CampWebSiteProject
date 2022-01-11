using System;
using System.Collections.Generic;
using System.Text;

namespace CampModel.Entity
{
   public class Author : BaseEntity
    {
        public string Surname { get; set; }
        public string  Email { get; set; }
        public string Password { get; set; }


    }
}
