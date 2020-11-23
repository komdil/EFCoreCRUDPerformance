using System;

namespace EFCoreCRUDPerformance.Model
{
    public class Payment : ModelItem
    {
        public Guid AccountWhichIsPayingGuid { get; set; }
        public virtual Account AccountWhichIsPaying { get; set; }

        public double Price { get; set; }

        public DateTime Date { get; set; }

        public string Comment { get; set; }

        public Guid AccountantGuid { get; set; }
        public virtual Accountant Accountant { get; set; }
    }
}
