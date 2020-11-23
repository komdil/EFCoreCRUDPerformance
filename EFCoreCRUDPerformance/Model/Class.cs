using System.Collections.Generic;

namespace EFCoreCRUDPerformance.Model
{
    public class Class : Entity
    {
        public string Name { get; set; }

        public string ClassType { get; set; }

        public virtual List<TeacherClassLink> TeachersCanTechThisClass { get; set; }

        public virtual List<Mark> Marks { get; set; }

        public virtual List<ExamTable> InExamLists { get; set; }
    }
}
