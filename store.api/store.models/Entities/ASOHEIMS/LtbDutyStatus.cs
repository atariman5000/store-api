using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbDutyStatus
    {
        public LtbDutyStatus()
        {
            InverseDutyStatusParent = new HashSet<LtbDutyStatus>();
            LtbDutyStatusLevel2Association = new HashSet<LtbDutyStatusLevel2Association>();
            LtbEmploymentStatusArmyCountableInjuryAssociation = new HashSet<LtbEmploymentStatusArmyCountableInjuryAssociation>();
            LtbEmploymentStatusDutyStatusAssociation = new HashSet<LtbEmploymentStatusDutyStatusAssociation>();
            LtbEmploymentStatusInjuryDueToArmyOpsAssociation = new HashSet<LtbEmploymentStatusInjuryDueToArmyOpsAssociation>();
            LtbMishapCategoryGroupNightVisionDeviceAssociation = new HashSet<LtbMishapCategoryGroupNightVisionDeviceAssociation>();
            LtbMishapInitialDueDateCriteria = new HashSet<LtbMishapInitialDueDateCriteria>();
        }

        public int DutyStatusId { get; set; }
        public string DutyStatusCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? DutyStatusParentId { get; set; }
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

        public virtual LtbDutyStatus DutyStatusParent { get; set; }
        public virtual ICollection<LtbDutyStatus> InverseDutyStatusParent { get; set; }
        public virtual ICollection<LtbDutyStatusLevel2Association> LtbDutyStatusLevel2Association { get; set; }
        public virtual ICollection<LtbEmploymentStatusArmyCountableInjuryAssociation> LtbEmploymentStatusArmyCountableInjuryAssociation { get; set; }
        public virtual ICollection<LtbEmploymentStatusDutyStatusAssociation> LtbEmploymentStatusDutyStatusAssociation { get; set; }
        public virtual ICollection<LtbEmploymentStatusInjuryDueToArmyOpsAssociation> LtbEmploymentStatusInjuryDueToArmyOpsAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupNightVisionDeviceAssociation> LtbMishapCategoryGroupNightVisionDeviceAssociation { get; set; }
        public virtual ICollection<LtbMishapInitialDueDateCriteria> LtbMishapInitialDueDateCriteria { get; set; }
    }
}
