using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2WindowsFormsApp.Model;
using Test2WindowsFormsApp.Repository;
namespace Test2WindowsFormsApp.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        public bool Add(Customer customer)
        {
            return _customerRepository.Add(customer);
        }

        public bool IsAccountExists(Customer customer)
        {
            return _customerRepository.IsAccountExists(customer);
        }
    }
}
