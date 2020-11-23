using System.Collections.Generic;

namespace EFCoreCRUDPerformance.Model
{
    public class Teacher : Account
    {
        public virtual List<ExamTable> AssistantToExams { get; set; }
        public virtual List<Mark> Marks { get; set; }
        public virtual List<TeacherClassLink> TeacherClassLinks { get; set; }
    }
}
