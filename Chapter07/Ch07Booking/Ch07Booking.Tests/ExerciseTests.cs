using Xunit;
using Ch07Booking;

namespace Ch07Booking.Tests;

public class ExerciseTests
{
    [Fact]
    public void ExactCapacityAndThenRefusal()
    {
        var booking = new SeatBooking(5);
        Assert.Equal(5, booking.Capacity);
        Assert.Equal(0, booking.Reserved);
        booking.Reserve(3);
        Assert.Equal(3, booking.Reserved);
        Assert.Throws<BookingOperationException>(() => booking.Reserve(3));
        Assert.Equal(3, booking.Reserved);
        booking.Reserve(2);
        Assert.Equal(5, booking.Reserved);
        Assert.Throws<BookingOperationException>(() => booking.Reserve(1));
        Assert.Equal(5, booking.Reserved);
    }
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void InvalidRequestPreservesReserved(int seats)
    {
        var booking = new SeatBooking(5);
        booking.Reserve(2);
        Assert.Throws<BookingOperationException>(() => booking.Reserve(seats));
        Assert.Equal(2, booking.Reserved);
        booking.Reserve(1);
        Assert.Equal(3, booking.Reserved);
    }
    [Fact]
    public void CapacityValidationAndExceptionType()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new SeatBooking(-1));
        var empty = new SeatBooking(0);
        Assert.Throws<BookingOperationException>(() => empty.Reserve(1));
        Assert.Equal(0, empty.Reserved);
        Assert.IsAssignableFrom<Exception>(new BookingOperationException("Reason"));
        Assert.Equal("Reason", new BookingOperationException("Reason").Message);
    }

}
