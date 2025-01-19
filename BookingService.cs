namespace EasyInvoice;

public class BookingService
{
    private readonly List<Booking> _bookings =
    [
       new Booking
       {
           Type = BookingType.HalfBoard,
           StartDate = DateTime.Now.AddDays(1),
           EndDate = DateTime.Now.AddDays(2),
           Price = 0.00m,
       }
    ];

    private List<Booking> _clearedBookings =
     [
       new Booking
        {
            Type = BookingType.HalfBoard,
            StartDate = DateTime.Now.AddDays(1),
            EndDate = DateTime.Now.AddDays(2),
            Price = 0.00m,
        }
     ];

    private bool _isCleared = false;
    public bool IsCleared
    {
        get => _isCleared;
        set
        {
            _isCleared = value;
            if (_isCleared)
            {
                _clearedBookings = [GetEmptyBooking()];
            }
        }
    }

    public void AddBooking(Booking booking)
    {
        if (IsCleared)
            _clearedBookings.Add(booking);
        else
            _bookings.Add(booking);
    }

    public void RemoveBooking(Booking booking)
    {
        if (IsCleared)
            _clearedBookings.Remove(booking);
        else
            _bookings.Remove(booking);
    }

    public List<Booking> GetBookings() => IsCleared ? _clearedBookings : _bookings;

    public Booking GetEmptyBooking() =>
       new()
       {
           Type = BookingType.HalfBoard,
           StartDate = DateTime.Now.AddDays(1),
           EndDate = DateTime.Now.AddDays(2),
           Price = 0.00m,
       };
}
