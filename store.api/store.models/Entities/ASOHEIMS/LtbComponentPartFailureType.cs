using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbComponentPartFailureType
    {
        public LtbComponentPartFailureType()
        {
            InverseComponentPartFailureTypeParent = new HashSet<LtbComponentPartFailureType>();
        }

        public int ComponentPartFailureTypeId { get; set; }
        public string ComponentPartFailureTypeCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? ComponentPartFailureTypeParentId { get; set; }
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

        public virtual LtbComponentPartFailureType ComponentPartFailureTypeParent { get; set; }
        public virtual ICollection<LtbComponentPartFailureType> InverseComponentPartFailureTypeParent { get; set; }
    }
}
