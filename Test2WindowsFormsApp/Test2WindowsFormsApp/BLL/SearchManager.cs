using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2WindowsFormsApp.Repository;
using Test2WindowsFormsApp.Model;
using System.Data;
namespace Test2WindowsFormsApp.BLL
{
    public class SearchManager
    {
        SearchRepository _searchRepository = new SearchRepository();
        public DataTable Search(Customer customer)
        {
            return _searchRepository.Search(customer);
        }
    }
}
