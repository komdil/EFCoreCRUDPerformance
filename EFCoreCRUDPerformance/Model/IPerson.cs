using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreCRUDPerformance.Model
{
    public interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
