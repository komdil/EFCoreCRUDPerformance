using System;
using System.Collections.Generic;

namespace EFCoreCRUDPerformance.Model
{
    public abstract class Account : User, IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid PrimaryContactGuid { get; set; }
        public virtual Contact PrimaryContact { get; set; }
        public virtual List<Payment> Payments { get; set; }
    }
}
