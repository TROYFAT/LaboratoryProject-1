using LS.Application.Common.Interfaces.Repositories.Base;
using LS.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Infrastracture.Persistence.Repositories.Base
{
    public class BaseRepository<T>:IBaseRepository<T>
        where T:Document
    {
        protected static List<T> _objectList = new List<T>();
        public T Add(T entity)
        {
            _objectList.Add(entity);
            return entity;
        }

        public T? GetById(Guid Id)
        {
            //LINQ
            return _objectList.
                Where(m => m.Id == Id).FirstOrDefault();
        }

        public void Remove(T entity)
        {
            _objectList.Remove(entity);
        }

        public T Update(T entity)
        {
            var index = _objectList.IndexOf(entity);
            if (index >= 0)
            {
                return _objectList[index] = entity;
            }
            return entity;
        }
        
    }
}
