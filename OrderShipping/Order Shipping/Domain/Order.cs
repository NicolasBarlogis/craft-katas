using OrderShipping.Service;
using OrderShipping.UseCase;

namespace OrderShipping.Domain
{
    public class Order
    {
        public decimal Total { get; set; }
        public string Currency { get; set; }
        public IList<OrderItem> Items { get; set; }
        public decimal Tax { get; set; }
        public OrderStatus Status { get; set; }
        public int Id { get; set; }

        public Order()
        {
            Status = OrderStatus.Created;
            Items = new List<OrderItem>();
            Currency = "EUR";
            Total = 0m;
            Tax = 0m;
        }

        public void Ship(IShipmentService shipmentService)
        {
            if (Status == OrderStatus.Created || Status == OrderStatus.Rejected)
            {
                throw new OrderCannotBeShippedException();
            }

            if (Status == OrderStatus.Shipped)
            {
                throw new OrderCannotBeShippedTwiceException();
            }

            shipmentService.Ship(this);

            Status = OrderStatus.Shipped;
        }

        internal void Approving(OrderApprovalRequest request)
        {
            Status = request.Approved ? OrderStatus.Approved : OrderStatus.Rejected;
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            Total += orderItem.TaxedAmount;
            Tax += orderItem.Tax;

            Items.Add(orderItem);
        }
    }
}