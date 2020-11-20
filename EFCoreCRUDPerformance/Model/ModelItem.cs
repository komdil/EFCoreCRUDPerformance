using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreCRUDPerformance.Model
{
    public abstract class ModelItem : Entity
    {
        public virtual string Title { get; set; }

        public virtual string Subtitle { get; set; }
    }
}
