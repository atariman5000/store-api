using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbInjuryCostFactorDateRange
    {
        public LtbInjuryCostFactorDateRange()
        {
            InverseInjuryCostFactorDateRangeParent = new HashSet<LtbInjuryCostFactorDateRange>();
            LtbInjuryCostStandard = new HashSet<LtbInjuryCostStandard>();
        }

        public int InjuryCostFactorDateRangeId { get; set; }
        public string InjuryCostFactorDateRangeCode { get; set; }
        public int? HospitalizedCostPerDay { get; set; }
        public int? DaysAwayFromWorkCostPerDay { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? InjuryCostFactorDateRangeParentId { get; set; }
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

        public virtual LtbInjuryCostFactorDateRange InjuryCostFactorDateRangeParent { get; set; }
        public virtual ICollection<LtbInjuryCostFactorDateRange> InverseInjuryCostFactorDateRangeParent { get; set; }
        public virtual ICollection<LtbInjuryCostStandard> LtbInjuryCostStandard { get; set; }
    }
}
