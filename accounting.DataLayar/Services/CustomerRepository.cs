using accounting.DataLayar.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using accounting.DataLayar;
using Accounting.ViewModel;
namespace accounting.DataLayar.Services
{
    //i made it inernal to only UnitOFWorks access it 
    // not bre able to access in another layers
    internal class CustomerRepository : ICustomerRepository
    {
        accounting_DBEntities conn;

        //dependancy injection 
        public CustomerRepository(accounting_DBEntities db)  //get the db from UnitOFWork
        {
            conn = db;
        }


        public bool AddCustomer(Customer customer)
        {
            try
            {
                conn.Customers.Add(customer);
                return true;
            }
            catch { return false; }
        }

        public bool UpdateCustomer(Customer customer)
        {
            try
            {

                var local = conn.Set<Customer>().Local.FirstOrDefault(x => x.CustomerID == customer.CustomerID);
                if (local != null) { conn.Entry(local).State = EntityState.Detached; }
                conn.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(Customer customer)
        {
            try
            {
                conn.Entry(customer).State = EntityState.Deleted;
                //conn.Customers.Remove(customer);
                return true;
            }
            catch { return false; }
        }

        public bool DeleteCustomer(int CustomerID)
        {
            try
            {
                Customer cus = SelectCustomer(CustomerID);
                //Customer cus = conn.Customers.Single(C => C.CustomerID == CustomerID);
                DeleteCustomer(cus);
                return true;
            }
            catch { return false; }
        }


        public IList<CusomerViewModel> GetCustomerFullname(string filter = null)
        {
            if(filter == "")
            {

                return  conn.Customers.Select(p=> new CusomerViewModel() { FullName= p.FullName , CustomerID=p.CustomerID }).ToList();
                
            }

            return conn.Customers.Where(p => p.FullName.Contains(filter)).Select(p => new CusomerViewModel() { FullName = p.FullName, CustomerID = p.CustomerID }).ToList();
        }
        public IQueryable<Customer> search(string srch)
        {
            IQueryable<Customer> customer = conn.Customers.Where(p => p.FullName.Contains(srch) || p.Address.Contains(srch) || p.PhoneNumber.Contains(srch)).Select(p => p);
            return customer;
        }

        public List<Customer> SelectAllCustomers()
        {
            List<Customer> cuses = conn.Customers.ToList();
            return cuses;
        }

        public Customer SelectCustomer(int CustomerID)
        {
            //Customer cus = conn.Customers.Find(CustomerID);
            Customer cus = conn.Customers.SingleOrDefault(C => C.CustomerID == CustomerID);
            return cus;
        }

        
    }
}
