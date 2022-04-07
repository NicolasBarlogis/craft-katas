using System.Collections.Generic;
using System.Linq;
using OrderShipping.Domain;
using OrderShipping.Repository;
using OrderShipping.UseCase;

namespace OrderShippingTest.Doubles
{
    public class TestOrderRepository : IOrderRepository
    {
        private Order _insertedOrder;
        private IList<Order> _orders = new List<Order>();

        public void Save(Order order)
        {
            _insertedOrder = order;
        }

        public Order GetById(int orderId)
        {
            var order = _orders.FirstOrDefault(o => o.Id == orderId);
            if (order == null) throw new UnknownOrderException();

            return order;

        }

        public Order GetSavedOrder()
        {
            return _insertedOrder;
        }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }
    }
}