using SOLID.A___Book_reservation.infrastructure;

namespace SOLID.A___Book_reservation.domain.booking
{
    public class BookingService
    {
        private readonly AvailabilityDaoImpl bookings;

        public BookingService(AvailabilityDaoImpl bookings)
        {
            this.bookings = bookings;
        }

        public BookingOutcome Book()
        {
            bool successful = bookings.IsAvailable();
            return new BookingOutcome(successful);
        }
    }
}