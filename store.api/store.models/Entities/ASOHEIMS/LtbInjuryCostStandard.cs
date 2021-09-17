using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbInjuryCostStandard
    {
        public int InjuryCostStandardId { get; set; }
        public int InjuryCostFactorDateRangeId { get; set; }
        public int InjurySeverityId { get; set; }
        public int InjuryCostCategoryId { get; set; }
        public int Cost { get; set; }
        public string ValueDefinition { get; set; }
        public string Guidance { get; set; }
        public DateTime? EstablishDate { get; set; }
        public DateTime StartCollecting { get; set; }
        public DateTime? EndCollecting { get; set; }
        public string Used { get; set; }
        public int? DisplayOrder { get; set; }
        public string CreatedByUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByApp { get; set; }
        public string LastModifiedByUser { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedByApp { get; set; }

        public virtual LtbInjuryCostCategory InjuryCostCategory { get; set; }
        public virtual LtbInjuryCostFactorDateRange InjuryCostFactorDateRange { get; set; }
        public virtual LtbInjurySeverity InjurySeverity { get; set; }
    }
}
