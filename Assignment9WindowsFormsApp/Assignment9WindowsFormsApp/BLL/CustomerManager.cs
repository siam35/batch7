using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Assignment9WindowsFormsApp.Model;
using Assignment9WindowsFormsApp.Repository;
namespace Assignment9WindowsFormsApp.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        public bool Add(Customer customer)
        {
            return _customerRepository.Add(customer);
        }
       
        public bool IsContactExists(Customer customer)
        {
            return _customerRepository.IsContactExists(customer);
        }
        public bool IsCodeExists(Customer customer)
        {
            return _customerRepository.IsCodeExists(customer);
        }
        public DataTable Display()
        {
            return _customerRepository.Display();
        }
        public DataTable DistrictCombo()
        {
            return _customerRepository.DistrictCombo();
        }
        public bool Update(Customer customer)
        {
            return _customerRepository.Update(customer);
        }
        public DataTable Search(Customer customer)
        {
            return _customerRepository.Search(customer);
        }

    }
}
