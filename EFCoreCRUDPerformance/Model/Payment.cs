using System;

namespace EFCoreCRUDPerformance.Model
{
    public class Payment : Entity
    {
        public Guid AccountWhichIsPayingGuid { get; set; }
        public virtual Account AccountWhichIsPaying { get; set; }

        public decimal Price { get; set; }

        public DateTime Date { get; set; }

        public Guid AccountantGuid { get; set; }
        public virtual Accountant Accountant { get; set; }
    }
}
