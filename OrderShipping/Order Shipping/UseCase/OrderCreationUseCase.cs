﻿using OrderShipping.Domain;
using OrderShipping.Repository;

namespace OrderShipping.UseCase
{
    public class OrderCreationUseCase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductCatalog _productCatalog;

        public OrderCreationUseCase(
            IOrderRepository orderRepository,
            IProductCatalog productCatalog)
        {
            _orderRepository = orderRepository;
            _productCatalog = productCatalog;
        }

        public void Run(SellItemsRequest request)
        {
            Order order = InitOrder();

            foreach (var itemRequest in request.Requests)
            {
                var product = _productCatalog.GetByName(itemRequest.ProductName);

                if (product == null)
                {
                    throw new UnknownProductException();
                }
                else
                {
                    CalculOrder(ref order, itemRequest, product);
                }
            }

            _orderRepository.Save(order);
        }

        private void CalculOrder(ref Order order, SellItemRequest itemRequest, Product product)
        {
            var unitaryTax = Round((product.Price / 100m) * product.Category.TaxPercentage);
            var unitaryTaxedAmount = Round(product.Price + unitaryTax);
            var taxedAmount = Round(unitaryTaxedAmount * itemRequest.Quantity);
            var taxAmount = Round(unitaryTax * itemRequest.Quantity);

            var orderItem = new OrderItem
            {
                Product = product,
                Quantity = itemRequest.Quantity,
                Tax = taxAmount,
                TaxedAmount = taxedAmount
            };

            order.AddItem(orderItem);
        }

        private Order InitOrder()
        {
            return new Order
            {
                Status = OrderStatus.Created,
                Items = new List<OrderItem>(),
                Currency = "EUR",
                Total = 0m,
                Tax = 0m
            };
        }

        private static decimal Round(decimal amount)
        {
            return decimal.Round(amount, 2, System.MidpointRounding.ToPositiveInfinity);
        }
    }
}