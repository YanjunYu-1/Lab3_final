using System.ComponentModel.DataAnnotations;

namespace Lab3_final.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Display(Name = "Is Reservation")]
        public bool IsReservation { get; set; }

        //Many-to-one with ParkingSpace、Vehicle
        public int ParkingSpaceId { get; set; }
        public ParkingSpace? ParkingSpace { get; set; }

        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
