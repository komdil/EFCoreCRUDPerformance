using System;

namespace EFCoreCRUDPerformance.Model
{
    public class TeacherClassLink : Entity
    {
        public Guid TeacherGuid { get; set; }
        public virtual Teacher Teacher { get; set; }

        public Guid ClassGuid { get; set; }
        public virtual Class Class { get; set; }
    }
}
