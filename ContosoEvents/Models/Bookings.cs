using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContosoEvents.Models
{
    public class Bookings
    {
        [Table("Booking_Details")]
        public class Booking
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int BookingID { get; set; }
            public int EventID { get; set; }
            public int UserID { get; set; }
            public decimal? BookingAmount { get; set; }
            public int NumberofTickets { get; set; }
            public decimal? SingleUnitPrice { get; set; }
        }
    }
}
