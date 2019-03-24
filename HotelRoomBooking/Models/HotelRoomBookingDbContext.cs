using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelRoomBooking.Models
{
    public class HotelRoomBookingDbContext : DbContext
    {
        public DbSet<UserDetail> UserDetails { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<HotelFacility> HotelFacilities { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<HotelRoom> HotelRooms { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public HotelRoomBookingDbContext(DbContextOptions<HotelRoomBookingDbContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-CVPECQF\SQLEXPRESS;Initial Catalog=HotelRoomBookingDb;Integrated Security=true;");
        }
    }
}
