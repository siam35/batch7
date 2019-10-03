using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopCRUD.Repositoryitem;
using CoffeeShopCRUD.Model;

namespace CoffeeShopCRUD.BLLitem
{
    public class ItemManager
    {
        ItemRepository _itemRepository = new ItemRepository();
        public bool AddMethod(Item item)
        {
            return _itemRepository.AddMethod(item);
        }
        public bool IsNameExists(Item item)
        {
          return _itemRepository.IsNameExists(item);
        }
        public bool DeleteMethod(Item item)
        {
            return _itemRepository.DeleteMethod(item);
        }
        public bool UpdateMethod(Item item)
        {
            return _itemRepository.UpdateMethod(item);
        }
        public DataTable ShowMethod()
        {
            return _itemRepository.ShowMethod();
        }
        public DataTable SearchMethod(Item item)
        {
            return _itemRepository.SearchMethod(item);
        }
        public DataTable ItemCombo()
        {
            return _itemRepository.ItemCombo();
        }
    }
}
