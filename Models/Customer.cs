using System.ComponentModel.DataAnnotations;

namespace SuqyaWaterSystem.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public int AreaId { get; set; }
        public Area Area { get; set; }

        public ICollection<WaterOrder> Orders { get; set; }
    }
}
