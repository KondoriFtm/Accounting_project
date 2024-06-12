using accounting.DataLayar;
using Accounting.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accounting.DataLayar.Repository
{
    public interface ICustomerRepository
    {
        // insert delete update selectall slectrow
        bool AddCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);

        bool DeleteCustomer(Customer customer);
        bool DeleteCustomer(int CustomerID);

        IList<CusomerViewModel> GetCustomerFullname(string filter = "");

        List<Customer> SelectAllCustomers();

        Customer SelectCustomer(int CustomerID);

        IQueryable<Customer> search(string srch);


    }
}
