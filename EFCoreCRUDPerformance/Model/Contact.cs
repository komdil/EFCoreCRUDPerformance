using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreCRUDPerformance.Model
{
    public class Contact : ModelItem
    {
        public string Address { get; set; }

        public string Country { get; set; }

        public string PhoneNumber { get; set; }

        public virtual List<Account> PrimaryAccounts { get; set; }
        public virtual List<Account> SecondaryAccounts { get; set; }
    }
}
