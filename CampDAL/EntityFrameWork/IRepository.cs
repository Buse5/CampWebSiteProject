using CampModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CampData.EntityFrameWork
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);

        TEntity GetById(Expression<Func<TEntity, bool>> filter);
    }
}
