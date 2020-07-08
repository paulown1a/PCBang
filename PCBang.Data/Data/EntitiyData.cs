using PC_Project.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PC_Project.Data
{
    public class EntitiyData<T> where T:class 
    {
        protected PCBangEntities CreateContext() 
        {
            PCBangEntities context = new PCBangEntities();
            context.Configuration.ProxyCreationEnabled = false;
            return context;
        }

        public List<T> GetAll()
        {
            PCBangEntities context = CreateContext();
            return context.Set<T>().ToList();
        }

        public int GetCount()
        {
            PCBangEntities context = CreateContext();
            return context.Set<T>().Count();
        }

        public void Insert(T entity)
        {
            PCBangEntities context = CreateContext();
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            PCBangEntities context = CreateContext();
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            PCBangEntities context = CreateContext();
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}