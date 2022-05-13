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

        internal void AddItems(OrderItem orderItem)
        {
            Items.Add(orderItem);
            Total += orderItem.TaxedAmount;
            Tax += orderItem.Tax;
        }
    }
}