namespace Core.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime ReservationEnd { get; set; }
    }
}
