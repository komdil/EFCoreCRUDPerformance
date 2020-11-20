using System.Collections.Generic;

namespace EFCoreCRUDPerformance.Model
{
    public class Backpack
    {
        public string Logo { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
    }
}
