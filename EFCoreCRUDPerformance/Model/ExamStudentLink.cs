using System;

namespace EFCoreCRUDPerformance.Model
{
    public class ExamStudentLink
    {
        public Guid Guid { get; set; }

        public Guid StudentGuid { get; set; }
        public virtual Student Student { get; set; }

        public Guid ExamTableGuid { get; set; }
        public virtual ExamTable ExamTable { get; set; }
    }
}
