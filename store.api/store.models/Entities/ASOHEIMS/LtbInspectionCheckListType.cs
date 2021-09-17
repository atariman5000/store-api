using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbInspectionCheckListType
    {
        public LtbInspectionCheckListType()
        {
            InverseInspectionCheckListTypeParent = new HashSet<LtbInspectionCheckListType>();
        }

        public int InspectionCheckListTypeId { get; set; }
        public string InspectionCheckListTypeCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? InspectionCheckListTypeParentId { get; set; }
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

        public virtual LtbInspectionCheckListType InspectionCheckListTypeParent { get; set; }
        public virtual ICollection<LtbInspectionCheckListType> InverseInspectionCheckListTypeParent { get; set; }
    }
}
