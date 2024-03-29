using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Application.Common.Interfaces.Repositories.Base
{
    public interface IBaseRepository<T>
    {
        T Add(T entity);
        T Update(T entity);
        void Remove(T entity);
        T? GetById(Guid Id);
    }
}
