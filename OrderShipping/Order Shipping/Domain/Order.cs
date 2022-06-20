using OrderShipping.Domain.Exception;

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

        public void AddItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
            Total += orderItem.TaxedAmount;
            Tax += orderItem.Tax;
        }
        
        public void Approve()
        {
            Status = Status switch
            {
                OrderStatus.Shipped => throw new ShippedOrdersCannotBeChangedException(),
                OrderStatus.Rejected => throw new RejectedOrderCannotBeApprovedException(),
                _ => OrderStatus.Approved
            };
        }

        public void Reject()
        {
            Status = Status switch
            {
                OrderStatus.Shipped => throw new ShippedOrdersCannotBeChangedException(),
                OrderStatus.Approved => throw new ApprovedOrderCannotBeRejectedException(),
                _ => OrderStatus.Rejected
            };
        }

        public void CheckCannotBeShiped()
        {
            if (Status is OrderStatus.Created or OrderStatus.Rejected)
            {
                throw new OrderCannotBeShippedException();
            }
            else if(Status == OrderStatus.Shipped)
            {
                throw new OrderCannotBeShippedTwiceException();
            }
        }

        public void ShipOrder()
        {
            CheckCannotBeShiped();

            Status = OrderStatus.Shipped;
        }
    }
}