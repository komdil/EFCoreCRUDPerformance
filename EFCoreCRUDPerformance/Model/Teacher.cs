using System.Collections.Generic;

namespace EFCoreCRUDPerformance.Model
{
    public class Teacher : Account
    {
        public virtual List<ExamStudentLink> AssistantToExams { get; set; }
        public virtual List<Backpack> Backpacks { get; set; }
        public virtual List<ExamTable> ExamTables { get; set; }
        public virtual List<Mark> Marks { get; set; }
    }
}
