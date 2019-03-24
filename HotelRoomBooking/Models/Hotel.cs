using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelRoomBooking.Models
{
    public class Hotel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public string HotelDistrict { get; set; }
        public string HotelCity { get; set; }
        public string HotelState { get; set; }
        public string HotelEmailId { get; set; }
        public int HotelStar { get; set; }
        public long HotelContactNumber { get; set; }

        //Relationship
        public List <HotelRoom> HotelRooms { get; set; }
        // public string HotelType {get; set;}
    }
}
