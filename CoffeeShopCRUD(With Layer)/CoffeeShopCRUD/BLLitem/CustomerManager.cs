using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopCRUD.Repositoryitem;
using System.Data;

namespace CoffeeShopCRUD.BLLitem
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        public bool AddMethod(string name, string address, string contact)
        {
            return _customerRepository.AddMethod(name, address, contact);
        }
        public bool IsNameExists(string name)
        {
            return _customerRepository.IsNameExists(name);
        }
        public DataTable ShowMethod()
        {
            return _customerRepository.ShowMethod();
        }
        public bool DeleteMethod(int id)
        {
            return _customerRepository.DeleteMethod(id);
        }
        public bool UpdateMethod(string name, string address, string contact, int id)
        {
            return _customerRepository.UpdateMethod(name, address, contact, id);
        }
        public DataTable SearchMethod(string name)
        {
            return _customerRepository.SearchMethod(name);
        }
    }
}
