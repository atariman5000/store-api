using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbInspectionGoverningDocument
    {
        public LtbInspectionGoverningDocument()
        {
            InverseInspectionGoverningDocumentParent = new HashSet<LtbInspectionGoverningDocument>();
            LtbOshasubPartStandard = new HashSet<LtbOshasubPartStandard>();
        }

        public int InspectionGoverningDocumentId { get; set; }
        public string InspectionGoverningDocumentCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? InspectionGoverningDocumentParentId { get; set; }
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

        public virtual LtbInspectionGoverningDocument InspectionGoverningDocumentParent { get; set; }
        public virtual ICollection<LtbInspectionGoverningDocument> InverseInspectionGoverningDocumentParent { get; set; }
        public virtual ICollection<LtbOshasubPartStandard> LtbOshasubPartStandard { get; set; }
    }
}
