using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreCRUDPerformance.Model
{
    public class Student : Account
    {
        public virtual List<Backpack> Backpacks { get; set; }
        public virtual List<ExamStudentLink> ExamStudentLinks { get; set; }

        public virtual List<Mark> Marks { get; set; }

        public Guid ParentGuid { get; set; }
        public virtual Parent Parent { get; set; }
    }
}
