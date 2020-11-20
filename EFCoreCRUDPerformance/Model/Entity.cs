using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreCRUDPerformance.Model
{
    public abstract class Entity
    {
        public Guid Guid { get; set; }
    }
}
