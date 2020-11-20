using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreCRUDPerformance.Model
{
    public class ExamStudentLink
    {
        public Guid Guid { get; set; }

        public Guid StudentGuid { get; set; }
        public virtual Student Student { get; set; }

        public Guid ExamGuid { get; set; }
        public virtual ExamTable Exam { get; set; }
    }
}
