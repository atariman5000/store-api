using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbInjuryCostCategoryMishapPersonAssociation
    {
        public int InjuryCostCategoryMishapPersonAssociationId { get; set; }
        public int InjuryCostCategoryId { get; set; }
        public int? EmploymentStatusId { get; set; }
        public int? PayGradeId { get; set; }
        public int? ArmyCountableInjuryResponseId { get; set; }
        public int? JobTitleId { get; set; }
        public int? FlightStatusResponseId { get; set; }
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
        public virtual LtbEmploymentStatus EmploymentStatus { get; set; }
        public virtual LtbResponse FlightStatusResponse { get; set; }
        public virtual LtbInjuryCostCategory InjuryCostCategory { get; set; }
        public virtual LtbJobTitle JobTitle { get; set; }
        public virtual LtbPayGrade PayGrade { get; set; }
    }
}
