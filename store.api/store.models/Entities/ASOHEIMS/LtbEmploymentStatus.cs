using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbEmploymentStatus
    {
        public LtbEmploymentStatus()
        {
            InverseEmploymentStatusParent = new HashSet<LtbEmploymentStatus>();
            LtbEmploymentStatusArmyCountableInjuryAssociation = new HashSet<LtbEmploymentStatusArmyCountableInjuryAssociation>();
            LtbEmploymentStatusDutyStatusAssociation = new HashSet<LtbEmploymentStatusDutyStatusAssociation>();
            LtbEmploymentStatusInjuryDueToArmyOpsAssociation = new HashSet<LtbEmploymentStatusInjuryDueToArmyOpsAssociation>();
            LtbEmploymentStatusPayGradeAssociation = new HashSet<LtbEmploymentStatusPayGradeAssociation>();
            LtbInjuryCostCategoryMishapPersonAssociation = new HashSet<LtbInjuryCostCategoryMishapPersonAssociation>();
        }

        public int EmploymentStatusId { get; set; }
        public string EmploymentStatusCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? EmploymentStatusParentId { get; set; }
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

        public virtual LtbEmploymentStatus EmploymentStatusParent { get; set; }
        public virtual ICollection<LtbEmploymentStatus> InverseEmploymentStatusParent { get; set; }
        public virtual ICollection<LtbEmploymentStatusArmyCountableInjuryAssociation> LtbEmploymentStatusArmyCountableInjuryAssociation { get; set; }
        public virtual ICollection<LtbEmploymentStatusDutyStatusAssociation> LtbEmploymentStatusDutyStatusAssociation { get; set; }
        public virtual ICollection<LtbEmploymentStatusInjuryDueToArmyOpsAssociation> LtbEmploymentStatusInjuryDueToArmyOpsAssociation { get; set; }
        public virtual ICollection<LtbEmploymentStatusPayGradeAssociation> LtbEmploymentStatusPayGradeAssociation { get; set; }
        public virtual ICollection<LtbInjuryCostCategoryMishapPersonAssociation> LtbInjuryCostCategoryMishapPersonAssociation { get; set; }
    }
}
