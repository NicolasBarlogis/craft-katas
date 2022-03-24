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
            // Todo : Make a builder
            var order = new Order
            {
                Status = OrderStatus.Created,
                Items = new List<OrderItem>(),
                Currency = "EUR",
                Total = 0m,
                Tax = 0m
            };

            foreach (var itemRequest in request.Requests)
            {
                /*
                * Todo: GetByNames with multiple names can be better for optimization
                * Todo: Change GetByName definition for nullable.
                */
                var product = _productCatalog.GetByName(itemRequest.ProductName);
                if (product == null)
                {
                    throw new UnknownProductException();
                }

                var orderItem = new OrderItem(product, itemRequest.Quantity);

                order.AddOrderItem(orderItem);
            }

            _orderRepository.Save(order);
        }
    }
}