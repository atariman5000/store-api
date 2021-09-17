using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbInspectionQuestionRating
    {
        public LtbInspectionQuestionRating()
        {
            InverseInspectionQuestionRatingParent = new HashSet<LtbInspectionQuestionRating>();
            LtbInspectionQuestionRac = new HashSet<LtbInspectionQuestionRac>();
        }

        public int InspectionQuestionRatingId { get; set; }
        public string InspectionQuestionRatingCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? InspectionQuestionRatingParentId { get; set; }
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

        public virtual LtbInspectionQuestionRating InspectionQuestionRatingParent { get; set; }
        public virtual ICollection<LtbInspectionQuestionRating> InverseInspectionQuestionRatingParent { get; set; }
        public virtual ICollection<LtbInspectionQuestionRac> LtbInspectionQuestionRac { get; set; }
    }
}
