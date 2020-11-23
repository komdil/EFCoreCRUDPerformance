using System.Collections.Generic;

namespace EFCoreCRUDPerformance.Model
{
    public class School
    {
        public string Name { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
        public virtual List<Class> Classes { get; set; }
        public virtual List<Room> Rooms { get; set; }
        public virtual List<Accountant> Accountants { get; set; }
    }
}
