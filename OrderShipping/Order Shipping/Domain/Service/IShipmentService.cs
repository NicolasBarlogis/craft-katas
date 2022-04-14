
namespace OrderShipping.Domain.Service
{
    public interface IShipmentService
    {
        void Ship(Order order);
    }
}