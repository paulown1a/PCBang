using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Dbdata
{
    public class EntitiyData<T> where T:class 
    {
        protected PCUIEntities CreateContext() 
        {
            PCUIEntities context = new PCUIEntities();
            context.Configuration.ProxyCreationEnabled = false;
            return context;
        }

        public List<T> GetAll()
        {
            PCUIEntities context = CreateContext();
            return context.Set<T>().ToList();
        }

        public int GetCount()
        {
            PCUIEntities context = CreateContext();
            return context.Set<T>().Count();
        }

        public void Insert(T entity)
        {
            PCUIEntities context = CreateContext();
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            PCUIEntities context = CreateContext();
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            PCUIEntities context = CreateContext();
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}