using accounting.DataLayar.Repository;
using accounting.DataLayar.Services;
using accounting.DataLayar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accounting.DataLayar.Contex
{
    //after this for working by database i have to use UnitOfWork
    //UnitOfwork is our Context
    //each time by instatciating of it  a context and  a handler to Database will made and 
    //all of accounting_DBEntities entities will become in memory
    public class UnitOFWork:IDisposable
    {
        accounting_DBEntities db = new accounting_DBEntities();

        GenericRepository<Accounting> _AccountingRepository;
        ICustomerRepository _customerRepsitory;  //= new CustomerRepository();

        public GenericRepository<Accounting> AccountingRepository
        {
            get
            {
                if(_AccountingRepository == null)
                {
                    _AccountingRepository = new GenericRepository<Accounting>(db);
                }
                return _AccountingRepository;
            }
                
        }

        public ICustomerRepository CustomerConnection
        {
            get
            {
                if (_customerRepsitory == null)
                {
                    _customerRepsitory = new CustomerRepository(db);

                }
                return _customerRepsitory;
                ;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
