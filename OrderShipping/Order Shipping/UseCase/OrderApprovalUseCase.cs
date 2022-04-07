using OrderShipping.Repository;

namespace OrderShipping.UseCase
{
    // Todo: Move repository to domain 
    public class OrderApprovalUseCase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderApprovalUseCase(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Run(OrderApprovalRequest request)
        {
            var order = _orderRepository.GetById(request.OrderId);

            if (request.Approved)
            {
                order.Approving();
            }
            else
            {
                order.Rejecting();
            }

            _orderRepository.Save(order);
        }
    }
}