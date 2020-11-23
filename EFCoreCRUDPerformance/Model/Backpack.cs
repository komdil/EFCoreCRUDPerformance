using System;

namespace EFCoreCRUDPerformance.Model
{
    public class Backpack : Entity
    {
        public string Logo { get; set; }
        public string Color { get; set; }
        public decimal Weight { get; set; }

        public Guid StudentGuid { get; set; }
        public virtual Student Student { get; set; }
    }
}
