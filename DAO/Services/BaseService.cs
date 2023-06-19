using DAO.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Services
{
    public class BaseService<T> where T : class
    {
        CoffeeManagementContext context;
        DbSet<T> dbSet;

        public BaseService()
        {
            context = new CoffeeManagementContext();
            dbSet = context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public void Create(T entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public bool Delete(T entity)
        {
            try
            {
                dbSet.Remove(entity);
                context.SaveChanges(true);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Update(T entity)
        {
            var tracker = context.Attach(entity);
            tracker.State = EntityState.Modified;
            context.SaveChanges();
        }

    }
}
