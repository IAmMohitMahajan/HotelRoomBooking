using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelRoomBooking.Models
{
    public class HotelFacility
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HotelFacilityId { get; set; }
        public bool IsAvilable { get; set; }
        public bool Wifi { get; set; }
        public bool Ac { get; set; }
        public bool Ekettle { get; set; }
        public bool Refrigerator { get; set; }
        public int RoomId { get; set; }

        //Relationship
        public HotelRoom HotelRoom { get; set; }
    }
}
