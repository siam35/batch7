using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopCRUD.Repositoryitem;

namespace CoffeeShopCRUD.BLLitem
{
    public class ItemManager
    {
        ItemRepository _itemRepository = new ItemRepository();
        public bool AddMethod(string name, double price)
        {
            return _itemRepository.AddMethod(name, price);
        }
        public bool IsNameExists(string name)
        {
          return _itemRepository.IsNameExists(name);
        }
        public bool DeleteMethod(int id)
        {
            return _itemRepository.DeleteMethod(id);
        }
        public bool UpdateMethod(string name, double price, int id)
        {
            return _itemRepository.UpdateMethod(name, price, id);
        }
        public DataTable ShowMethod()
        {
            return _itemRepository.ShowMethod();
        }
        public DataTable SearchMethod(string name)
        {
            return _itemRepository.SearchMethod(name);
        }
    }
}
