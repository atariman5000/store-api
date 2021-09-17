﻿using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbEmploymentStatusArmyCountableInjuryAssociation
    {
        public int EmploymentStatusArmyCountableInjuryAssociationId { get; set; }
        public int ArmyCountableInjuryResponseId { get; set; }
        public int? IndividualInjuredResponseId { get; set; }
        public int EmploymentStatusId { get; set; }
        public int? DutyStatusId { get; set; }
        public int? ArmyRecordableMishapResponseId { get; set; }
        public int? AssignedAttachedToArmyResponseId { get; set; }
        public int? InjuryDueToArmyOperationsResponseId { get; set; }
        public int? ArmyResponsibleInjuryCostResponseId { get; set; }
        public int? InjuryCostResponsibleDoDserviceId { get; set; }
        public int? InjuryCostResponsibleDoDserviceComponentId { get; set; }
        public int? ReviewFlagResponseId { get; set; }
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

        public virtual LtbResponse ArmyCountableInjuryResponse { get; set; }
        public virtual LtbDutyStatus DutyStatus { get; set; }
        public virtual LtbEmploymentStatus EmploymentStatus { get; set; }
        public virtual LtbResponse IndividualInjuredResponse { get; set; }
        public virtual LtbResponse ReviewFlagResponse { get; set; }
    }
}