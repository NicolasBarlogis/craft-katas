namespace SOLID.A___Book_reservation.domain.booking
{
    public class BookingOutcome {
        private readonly bool successful;

        public BookingOutcome(bool successful) {
            this.successful = successful;
        }

        public bool IsSuccessful() {
            return successful;
        }

    }
}
