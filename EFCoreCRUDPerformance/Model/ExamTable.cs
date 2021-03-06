﻿using System;
using System.Collections.Generic;

namespace EFCoreCRUDPerformance.Model
{
    public class ExamTable : Entity
    {
        public Guid ClassGuid { get; set; }
        public virtual Class Class { get; set; }
        public DateTime Time { get; set; }

        public Guid AssistantGuid { get; set; }
        public virtual Teacher Assistant { get; set; }

        public virtual List<ExamStudentLink> ExamStudentLinks { get; set; }
    }
}
