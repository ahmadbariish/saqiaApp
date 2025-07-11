namespace SuqyaWaterSystem.Models
{
    public class Area
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Customer> Customers { get; set; }
        public ICollection<Tank> Tanks { get; set; }
    }
}
