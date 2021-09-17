using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbLikelyConsequence
    {
        public LtbLikelyConsequence()
        {
            InverseLikelyConsequenceParent = new HashSet<LtbLikelyConsequence>();
        }

        public int LikelyConsequenceId { get; set; }
        public string LikelyConsequenceCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? LikelyConsequenceParentId { get; set; }
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

        public virtual LtbLikelyConsequence LikelyConsequenceParent { get; set; }
        public virtual ICollection<LtbLikelyConsequence> InverseLikelyConsequenceParent { get; set; }
    }
}
