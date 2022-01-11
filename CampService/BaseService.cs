using CampModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CampService
{
   public interface BaseService<T> where T:BaseEntity
    {
       public void Insert(T entity);
       public void Remove(T entity);
       public void Update(T entity);
       public T GetById(int entityID);
       public ICollection<T> GetAll();
    }
}
