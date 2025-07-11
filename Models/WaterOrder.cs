using System;

namespace SuqyaWaterSystem.Models
{
    public class WaterOrder
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int TankId { get; set; }
        public Tank Tank { get; set; }

        public int Quantity { get; set; } // عدد البراميل
        public DateTime OrderDate { get; set; }

        public string Status { get; set; } // Pending, InProgress, Done

        public int? DriverId { get; set; }
        public Driver Driver { get; set; }
    }
}
