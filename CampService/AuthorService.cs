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
    public class AuthorService : IAuthorServices
    {
        IAuthorData _author;

        public AuthorService()
        {
        }

        public AuthorService(IAuthorData author)
        {
            _author = author;
        }
        public ICollection<Author> GetAll()
        {
            var data = _author.GetAll();
            return data;
        }

        public Author GetById(int entityID)
        {
            var data = _author.GetById(a => a.Id== entityID);
            return data;
        }

        public void Insert(Author entity)
        {
            _author.Add(entity);
        }

        public void Remove(Author entity)
        {
            var data = _author.GetById(a => a.Id == entity.Id);
            _author.Delete(data);
        }

        public void Update(Author entity)
        {
            _author.Update(entity);
        }
    }
}
