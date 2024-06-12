using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace accounting.DataLayar.Services
{
    // a GEneric class means our class can work with different types 
    //the type will be proved when instaniating from class
    public class GenericRepository<TEntity> where TEntity : class
    {
        accounting_DBEntities _db;
        DbSet<TEntity> _dbSet;

        public GenericRepository(accounting_DBEntities db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }

        public void insert(TEntity entity)
        {
            _dbSet.Add(entity);
            //_db.Entry(entity).State = EntityState.Added;
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity) //delete a given entity
        { _db.Entry(entity).State = EntityState.Deleted; }

        public void Delete (object Key) //delete an entity by it's primary key
        {
            var entity = GetByKey(Key);
            Delete(entity);

        }

        public IQueryable<TEntity> GetByFilter(Expression<Func<TEntity,bool>> where=null)
        {

            //IQueryable<TEntity> Query = _dbSet.Where(where);  //IQueryable is lazy load
            //                                         //means till it is not itrated it is not executed
            //                                         //i think here it dose not loat all entities of the table to memory
            //                                         //if (where != null)
            //                                         //{
            //                                         //    Query = Query.w
            //                                         //}
            //                                         //return Query.ToList();

            //return Query;


            return _dbSet.Where(where);
        }
       public TEntity GetByKey(Object obj)
        {
            return _dbSet.Find(obj);
        }

        public IEnumerable<TEntity> SelectAll()
        {
            return _dbSet.ToList();
        }







    }
}
