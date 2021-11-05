using HaberPortal.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortal.Model.Repository
{
    public class GenericRepository<C> where C : class, new()
    {
        // CRUD işlemleri yapılacak 
        // Create, Read, Update , Delete -> CRUD
        HaberlerEntities1 db = new HaberlerEntities1();

        //object _object;

        //public GenericRepository()
        //{
        //    _object = db.Set<C>();
        //}
        public List<C> List()
        {
            // Koşulsuz bütün classları getirme
            return db.Set<C>().ToList();
        }

        public C GetById(int id)
        {
            // Id ye göre Class'ı getirme
            return db.Set<C>().Find(id);
        }

        public void Add(C p)
        {
            // Class ekleme
            db.Set<C>().Add(p);
            db.SaveChanges();
        }

        public void Delete(C p)
        {
            // Clası silme
            db.Set<C>().Remove(p);
            db.SaveChanges();
        }

        public void Update(C p)
        {
            // Class güncelleme
            db.SaveChanges();
        }

        public C Find(Expression<Func<C, bool>> kosul)
        {
            // Koşullu class donme
            return db.Set<C>().FirstOrDefault(kosul);
        }


    }
}
