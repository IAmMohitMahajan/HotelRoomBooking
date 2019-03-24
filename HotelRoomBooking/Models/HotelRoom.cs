using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelRoomBooking.Models
{
    public class HotelRoom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomId { get; set; }
        public string RoomType { get; set; }
        public int RoomPrice { get; set; }
        public int HotelId { get; set; }

        //Relationship
        public HotelFacility HotelFacility { get; set; }
        public Hotel Hotel { get; set; }
        public Booking Booking { get; set; }
    }
}
