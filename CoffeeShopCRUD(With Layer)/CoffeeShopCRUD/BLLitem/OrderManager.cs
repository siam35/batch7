using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopCRUD.Repositoryitem;
using System.Data;

namespace CoffeeShopCRUD.BLLitem
{
    public class OrderManager
    {
        OrderRepository _orderRepository = new OrderRepository();
        public bool AddMethod(int customer_id, int item_id, int quantity)
        {
           return _orderRepository.AddMethod(customer_id, item_id, quantity);
        }
        public DataTable ShowMethod()
        {
            return _orderRepository.ShowMethod();
        }
        public bool DeleteMethod(int id)
        {
            return _orderRepository.DeleteMethod(id);
        }
        public bool UpdateMethod(int customer_id, int item_id, int quantity, int order_id)
        {
            return _orderRepository.UpdateMethod(customer_id, item_id, quantity, order_id);
        }
        public DataTable SearchMethod(string name)
        {
            return _orderRepository.SearchMethod(name);
        }


    }
}
