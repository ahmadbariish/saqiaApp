namespace SuqyaWaterSystem.Models
{
    public class Tank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Capacity { get; set; }
        public string Location { get; set; }
        public string WaterType { get; set; }
        public decimal PricePerBarrel { get; set; }

        public int AreaId { get; set; }
        public Area Area { get; set; }
    }
}
