using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbMishapInitialDueDateCriteria
    {
        public int MishapInitialDueDateCriteriaId { get; set; }
        public string MishapClassification { get; set; }
        public int MishapCategoryGroupId { get; set; }
        public int MishapDutyStatusId { get; set; }
        public int MissionTypeId { get; set; }
        public int MishapSourceId { get; set; }
        public int InvestigationRequiredResponseId { get; set; }
        public int Days { get; set; }
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

        public virtual LtbResponse InvestigationRequiredResponse { get; set; }
        public virtual LtbMishapCategory MishapCategoryGroup { get; set; }
        public virtual LtbDutyStatus MishapDutyStatus { get; set; }
        public virtual LtbMishapSource MishapSource { get; set; }
        public virtual LtbMissionType MissionType { get; set; }
    }
}
