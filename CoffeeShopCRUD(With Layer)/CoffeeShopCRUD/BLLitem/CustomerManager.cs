using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopCRUD.Repositoryitem;
using System.Data;
using CoffeeShopCRUD.Model;

namespace CoffeeShopCRUD.BLLitem
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        public bool AddMethod(Customer customer)
        {
            return _customerRepository.AddMethod(customer);
        }
        public bool IsNameExists(Customer customer)
        {
            return _customerRepository.IsNameExists(customer);
        }
        public DataTable ShowMethod()
        {
            return _customerRepository.ShowMethod();
        }
        public bool DeleteMethod(Customer customer)
        {
            return _customerRepository.DeleteMethod(customer);
        }
        public bool UpdateMethod(Customer customer)
        {
            return _customerRepository.UpdateMethod(customer);
        }
        public DataTable SearchMethod(Customer customer)
        {
            return _customerRepository.SearchMethod(customer);
        }
        public DataTable CustomerCombo()
        {
            return _customerRepository.CustomerCombo();
        }
    }
}
