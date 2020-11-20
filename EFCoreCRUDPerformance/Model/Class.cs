using System.Collections.Generic;

namespace EFCoreCRUDPerformance.Model
{
    public class Class : ModelItem
    {
        public string Name { get; set; }

        public string ClassType { get; set; }

        public List<TeacherClassLink> TeachersCanTechThisClass { get; set; }
    }
}
