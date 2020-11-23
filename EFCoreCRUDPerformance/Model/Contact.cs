using System.Collections.Generic;

namespace EFCoreCRUDPerformance.Model
{
    public class Contact : Entity
    {
        public string Address { get; set; }

        public string Country { get; set; }

        public string PhoneNumber { get; set; }

        public virtual List<Account> PrimaryAccounts { get; set; }
    }
}
