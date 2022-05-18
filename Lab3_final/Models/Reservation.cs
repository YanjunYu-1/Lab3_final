namespace Lab3_final.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public bool IsReservation { get; set; }

        //Many-to-one with ParkingSpace
        public int ParkingSpaceId { get; set; }
        public ParkingSpace? ParkingSpace { get; set; }


        //One-To-Many with Vehicle
        public ICollection<Vehicle> vehicles { get; set; }

        public Reservation()
        {
            vehicles=new HashSet<Vehicle>();
        }
    }
}
