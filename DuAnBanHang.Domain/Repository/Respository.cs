using DuAnBanHang.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DuAnBanHang.Domain.Repository
{
    public class Respository<T> : IRespository<T> where T : class
    {
        WebBanHangContext context;
      
        public Respository( WebBanHangContext context)
        {
            this.context = context;
        }
        public async Task<bool> CreateObj(T obj)
        {
            try
            {
                await context.Set<T>().AddAsync(obj);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteObj(dynamic id)
        {
            try
            {
                var obj = await context.Set<T>().FindAsync(id);
                if (obj == null) return false;
                context.Set<T>().Remove(obj);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<T> FirstOrDefault(Expression<Func<T, bool>> filter = null)
        {
            if (filter != null)
            {
                return await context.Set<T>().FirstOrDefaultAsync(filter);
            }
            return await context.Set<T>().FirstOrDefaultAsync();
        }
        public async Task<IQueryable<T>> GetAll(Expression<Func<T, bool>> filter = null)
        {
            if (filter != null)
            {
                return (IQueryable<T>)await context.Set<T>().Where(filter).ToListAsync();
            }
            return (IQueryable<T>)await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(dynamic id)
        {
            return await context.Set<T>().FindAsync(id);
        }


        public async Task<bool> UpdateObj(T obj)
        {
            try
            {
                context.Set<T>().Update(obj);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception) { return false; }
        }

        public bool UpdateRange(List<T> LstEntity)
        {
            throw new NotImplementedException();
        }

   
    }
}
