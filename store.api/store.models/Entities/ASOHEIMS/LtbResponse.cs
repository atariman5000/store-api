using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbResponse
    {
        public LtbResponse()
        {
            InverseResponseParent = new HashSet<LtbResponse>();
            LtbAircraft = new HashSet<LtbAircraft>();
            LtbEmploymentStatusArmyCountableInjuryAssociationArmyCountableInjuryResponse = new HashSet<LtbEmploymentStatusArmyCountableInjuryAssociation>();
            LtbEmploymentStatusArmyCountableInjuryAssociationIndividualInjuredResponse = new HashSet<LtbEmploymentStatusArmyCountableInjuryAssociation>();
            LtbEmploymentStatusArmyCountableInjuryAssociationReviewFlagResponse = new HashSet<LtbEmploymentStatusArmyCountableInjuryAssociation>();
            LtbEmploymentStatusInjuryDueToArmyOpsAssociationArmyRecordableMishapResponse = new HashSet<LtbEmploymentStatusInjuryDueToArmyOpsAssociation>();
            LtbEmploymentStatusInjuryDueToArmyOpsAssociationAssignedAttachedToArmyResponse = new HashSet<LtbEmploymentStatusInjuryDueToArmyOpsAssociation>();
            LtbInjuryCostCategoryMishapPersonAssociationArmyCountableInjuryResponse = new HashSet<LtbInjuryCostCategoryMishapPersonAssociation>();
            LtbInjuryCostCategoryMishapPersonAssociationFlightStatusResponse = new HashSet<LtbInjuryCostCategoryMishapPersonAssociation>();
            LtbMaterielObjectTacticalIndicatorAssociationNonTacticalResponse = new HashSet<LtbMaterielObjectTacticalIndicatorAssociation>();
            LtbMaterielObjectTacticalIndicatorAssociationTacticalResponse = new HashSet<LtbMaterielObjectTacticalIndicatorAssociation>();
            LtbMishapInitialDueDateCriteria = new HashSet<LtbMishapInitialDueDateCriteria>();
            LtbUicdetail = new HashSet<LtbUicdetail>();
        }

        public int ResponseId { get; set; }
        public string ResponseCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? ResponseParentId { get; set; }
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

        public virtual LtbResponse ResponseParent { get; set; }
        public virtual ICollection<LtbResponse> InverseResponseParent { get; set; }
        public virtual ICollection<LtbAircraft> LtbAircraft { get; set; }
        public virtual ICollection<LtbEmploymentStatusArmyCountableInjuryAssociation> LtbEmploymentStatusArmyCountableInjuryAssociationArmyCountableInjuryResponse { get; set; }
        public virtual ICollection<LtbEmploymentStatusArmyCountableInjuryAssociation> LtbEmploymentStatusArmyCountableInjuryAssociationIndividualInjuredResponse { get; set; }
        public virtual ICollection<LtbEmploymentStatusArmyCountableInjuryAssociation> LtbEmploymentStatusArmyCountableInjuryAssociationReviewFlagResponse { get; set; }
        public virtual ICollection<LtbEmploymentStatusInjuryDueToArmyOpsAssociation> LtbEmploymentStatusInjuryDueToArmyOpsAssociationArmyRecordableMishapResponse { get; set; }
        public virtual ICollection<LtbEmploymentStatusInjuryDueToArmyOpsAssociation> LtbEmploymentStatusInjuryDueToArmyOpsAssociationAssignedAttachedToArmyResponse { get; set; }
        public virtual ICollection<LtbInjuryCostCategoryMishapPersonAssociation> LtbInjuryCostCategoryMishapPersonAssociationArmyCountableInjuryResponse { get; set; }
        public virtual ICollection<LtbInjuryCostCategoryMishapPersonAssociation> LtbInjuryCostCategoryMishapPersonAssociationFlightStatusResponse { get; set; }
        public virtual ICollection<LtbMaterielObjectTacticalIndicatorAssociation> LtbMaterielObjectTacticalIndicatorAssociationNonTacticalResponse { get; set; }
        public virtual ICollection<LtbMaterielObjectTacticalIndicatorAssociation> LtbMaterielObjectTacticalIndicatorAssociationTacticalResponse { get; set; }
        public virtual ICollection<LtbMishapInitialDueDateCriteria> LtbMishapInitialDueDateCriteria { get; set; }
        public virtual ICollection<LtbUicdetail> LtbUicdetail { get; set; }
    }
}
