using Moq;
using SOLID.A___Book_reservation.domain.booking;
using SOLID.A___Book_reservation.infrastructure;
using Xunit;

namespace SOLID.A___Book_reservation
{
    public class BookingTest
    {
        private Mock<AvailabilityDaoImpl> availabilities;
        private BookingService booking;

        public BookingTest()
        {
            availabilities = new Mock<AvailabilityDaoImpl>();
            booking = new BookingService(availabilities.Object);
        }

        [Fact]
        public void should_book_when_available()
        {
            availabilities.Setup(a => a.IsAvailable()).Returns(true);
            BookingOutcome outcome = booking.Book();

            Assert.True(outcome.IsSuccessful());
        }

        [Fact]
        public void should_not_book_when_not_available()
        {
            availabilities.Setup(a => a.IsAvailable()).Returns(false);

            BookingOutcome outcome = booking.Book();

            Assert.False(outcome.IsSuccessful());
        }
    }
}