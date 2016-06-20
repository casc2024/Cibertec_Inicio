using WebDeveloper.Model;
using System.Linq;
using System.Collections.Generic;

namespace WebDeveloper.DataAccess
{
    public class OrderData : BaseDataAccess<Order>
    {
        public List<Order_Details> getOrderDetails(int id) {
            using(var context = new WebContextDb())
            {
                var query = (from a in context.Order
                            join b in context.Order_Details on a.Id equals b.OrderID
                            where
                                a.Id == id
                            select new Order_Details {
                                OrderID = a.Id,
                                ProductID = b.ProductID,
                                Quantity = b.Quantity,
                                UnitPrice = b.UnitPrice,
                                Discount = b.Discount
                            }).ToList();
                return query;
            }
            
        }
    }
}
