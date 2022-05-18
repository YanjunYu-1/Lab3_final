namespace Lab3_final.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsState { get; set; }

        //Many-to-one with Pass,
        public int PassId { get; set; }
        public Pass? Pass { get; set; }

        //One-to-Many with Reservation
        public ICollection<Reservation> reservations { get; set; }

        public Vehicle()
        {
            reservations = new HashSet<Reservation>();
        }
    }
}
