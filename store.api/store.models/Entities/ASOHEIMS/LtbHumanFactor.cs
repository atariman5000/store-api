using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbHumanFactor
    {
        public LtbHumanFactor()
        {
            InverseHumanFactorParent = new HashSet<LtbHumanFactor>();
        }

        public int HumanFactorId { get; set; }
        public string HumanFactorCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? HumanFactorParentId { get; set; }
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

        public virtual LtbHumanFactor HumanFactorParent { get; set; }
        public virtual ICollection<LtbHumanFactor> InverseHumanFactorParent { get; set; }
    }
}
