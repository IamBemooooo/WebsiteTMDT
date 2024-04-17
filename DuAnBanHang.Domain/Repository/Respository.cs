using DuAnBanHang.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnBanHang.Domain.Repository
{
    public class Respository<G> : IRespository<G> where G : class
    {
        WebBanHangContext context;
        DbSet<G> dbSet; // CRUD trên DBset vì nó đại diện cho bảng
        // Khi cần gọi lại va dùng thật thì cần chính xác nó là DBSet nào
        //Lúc đó ta sẽ gán DbSet = DBSet cần dùng 
        public Respository(DbSet<G> dbset, WebBanHangContext context)
        {
            dbSet = dbset; //gán lại khi dùng
            this.context = context;
        }
        public bool Create(G obj)
        {
            try
            {
                dbSet.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(dynamic id)
        {
            try
            {
                var deleteObj = dbSet.Find(id);// Find truyền vào thuộc tính
                // chỉ sử dụng với PK
                dbSet.Remove(deleteObj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ICollection<G> GetAll()
        {
            return dbSet.ToList();
        }

        public G GetById(dynamic id)
        {
            return dbSet.Find(id);
        }

        public bool Update(G obj)
        {
            try
            {
                // chỉ sử dụng với PK
                dbSet.Update(obj);//Sửa
                context.SaveChanges();//Lưu lại
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateRange(List<G> LstEntity)
        {
            throw new NotImplementedException();
        }

        IQueryable<G> IRespository<G>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
