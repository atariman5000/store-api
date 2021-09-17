using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbInspectionQuestionSeverity
    {
        public LtbInspectionQuestionSeverity()
        {
            InverseInspectionQuestionSeverityParent = new HashSet<LtbInspectionQuestionSeverity>();
            LtbInspectionQuestionRac = new HashSet<LtbInspectionQuestionRac>();
        }

        public int InspectionQuestionSeverityId { get; set; }
        public string InspectionQuestionSeverityCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? InspectionQuestionSeverityParentId { get; set; }
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

        public virtual LtbInspectionQuestionSeverity InspectionQuestionSeverityParent { get; set; }
        public virtual ICollection<LtbInspectionQuestionSeverity> InverseInspectionQuestionSeverityParent { get; set; }
        public virtual ICollection<LtbInspectionQuestionRac> LtbInspectionQuestionRac { get; set; }
    }
}
