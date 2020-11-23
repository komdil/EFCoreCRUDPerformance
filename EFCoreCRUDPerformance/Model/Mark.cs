using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreCRUDPerformance.Model
{
    public class Mark : ModelItem
    {
        public Guid ClassGuid { get; set; }
        public virtual Class Class { get; set; }

        public Guid StudentGuid { get; set; }
        public Student Student { get; set; }

        public Guid TeacherGuid { get; set; }
        public Teacher Teacher { get; set; }

        public int MarkValue { get; set; }
    }
}
