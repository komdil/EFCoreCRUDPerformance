using System.Collections.Generic;

namespace EFCoreCRUDPerformance.Model
{
    public class Parent : Person
    {
        public virtual List<Student> Childrens { get; set; }
    }
}
