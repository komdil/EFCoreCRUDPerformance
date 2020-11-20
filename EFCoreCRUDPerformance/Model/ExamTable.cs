using System;
using System.Collections.Generic;

namespace EFCoreCRUDPerformance.Model
{
    public class ExamTable
    {
        public Guid ClassGuid { get; set; }
        public virtual Class Class { get; set; }
        public DateTime Time { get; set; }
        public virtual List<Student> Students { get; set; }
        public Guid AssistantGuid { get; set; }
        public virtual Teacher Assistant { get; set; }
    }
}
