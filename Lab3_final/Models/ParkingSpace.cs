using System.ComponentModel.DataAnnotations;

namespace Lab3_final.Models
{
    public class ParkingSpace
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name ="Is Parked")]
        public bool IsParked { get; set; }

        //One-To-Many with Reservation
        public ICollection<Reservation> Reservations { get; set; }
        public ParkingSpace()
        {
            Reservations = new HashSet<Reservation>();
        }
    }
}
