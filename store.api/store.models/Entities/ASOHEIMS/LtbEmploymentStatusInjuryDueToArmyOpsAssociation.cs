using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbEmploymentStatusInjuryDueToArmyOpsAssociation
    {
        public int EmploymentStatusInjuryDueToArmyOpsAssociationId { get; set; }
        public int EmploymentStatusId { get; set; }
        public int DutyStatusId { get; set; }
        public int? ArmyRecordableMishapResponseId { get; set; }
        public int? AssignedAttachedToArmyResponseId { get; set; }
        public bool? DisplayInjuryDueArmyOpsQuestion { get; set; }
        public string Guidance { get; set; }
        public DateTime? EstablishDate { get; set; }
        public DateTime StartCollecting { get; set; }
        public DateTime? EndCollecting { get; set; }
        public string Used { get; set; }
        public string CreatedByUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByApp { get; set; }
        public string LastModifiedByUser { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedByApp { get; set; }
        public int? DisplayOrder { get; set; }

        public virtual LtbResponse ArmyRecordableMishapResponse { get; set; }
        public virtual LtbResponse AssignedAttachedToArmyResponse { get; set; }
        public virtual LtbDutyStatus DutyStatus { get; set; }
        public virtual LtbEmploymentStatus EmploymentStatus { get; set; }
    }
}
