using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbRecommendationCondition
    {
        public LtbRecommendationCondition()
        {
            InverseRecommendationConditionParent = new HashSet<LtbRecommendationCondition>();
            LtbRecommendationConditionRecStatusAssociation = new HashSet<LtbRecommendationConditionRecStatusAssociation>();
        }

        public int RecommendationConditionId { get; set; }
        public string RecommendationConditionCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? RecommendationConditionParentId { get; set; }
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

        public virtual LtbRecommendationCondition RecommendationConditionParent { get; set; }
        public virtual ICollection<LtbRecommendationCondition> InverseRecommendationConditionParent { get; set; }
        public virtual ICollection<LtbRecommendationConditionRecStatusAssociation> LtbRecommendationConditionRecStatusAssociation { get; set; }
    }
}
