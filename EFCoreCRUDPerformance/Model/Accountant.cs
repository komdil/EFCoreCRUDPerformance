using System;
using System.Collections.Generic;

namespace EFCoreCRUDPerformance.Model
{
    public class Accountant : Account
    {
        public string WorkExperince { get; set; }
        public virtual List<Payment> ReceivedPayments { get; set; }

        public Guid CabinetGuid { get; set; }
        public virtual Room Cabinet { get; set; }
    }
}
