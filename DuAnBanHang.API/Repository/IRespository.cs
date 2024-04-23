using System.Linq.Expressions;

namespace DuAnBanHang.Domain.Repository
{
    public interface IRespository<T> where T : class
    {
        public Task<IQueryable<T>> GetAll(Expression<Func<T, bool>> filter = null);
        public Task<T> FirstOrDefault(Expression<Func<T, bool>> filter = null);
        public Task<T> GetById(dynamic id);
        public Task<bool> CreateObj(T obj);
        public Task<bool> UpdateObj(T obj);
        public Task<bool> DeleteObj(dynamic id);
    }
}
