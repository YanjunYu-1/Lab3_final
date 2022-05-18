namespace Lab3_final.Models
{
    public class Pass
    {
        public int Id { get; set; }
        public string Name { get; set; }


        //One-to-many with Vehicle
        public ICollection<Vehicle> vehicles { get; set; }
        public Pass()
        {
            vehicles = new HashSet<Vehicle>();
        }
    }
}
