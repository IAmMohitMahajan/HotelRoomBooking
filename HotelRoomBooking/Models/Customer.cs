using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelRoomBooking.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmailId { get; set; }
        public string CustomerGender { get; set; }
        public long CustomerContactNumber { get; set; }
        public DateTime CustomerDateOfBirth { get; set; }
        public string CustomerPassword { get; set; }

        //Relationship
        public List <Booking> Bookings { get; set; }
    }
}
