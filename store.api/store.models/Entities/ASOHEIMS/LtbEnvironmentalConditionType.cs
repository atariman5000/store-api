using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbEnvironmentalConditionType
    {
        public LtbEnvironmentalConditionType()
        {
            InverseEnvironmentalConditionTypeParent = new HashSet<LtbEnvironmentalConditionType>();
        }

        public int EnvironmentalConditionTypeId { get; set; }
        public string EnvironmentalConditionTypeCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? EnvironmentalConditionTypeParentId { get; set; }
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

        public virtual LtbEnvironmentalConditionType EnvironmentalConditionTypeParent { get; set; }
        public virtual ICollection<LtbEnvironmentalConditionType> InverseEnvironmentalConditionTypeParent { get; set; }
    }
}
