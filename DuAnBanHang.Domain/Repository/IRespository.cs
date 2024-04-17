using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnBanHang.Domain.Repository
{
    public interface IRespository<T> where T : class
    {
        public IQueryable<T> GetAll();
        public T GetById(dynamic id);
        public bool Create(T entity);
        public bool Update(T entity);
        public bool UpdateRange(List<T> LstEntity);
        public bool Delete(dynamic id);
    }
}
