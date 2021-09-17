using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbOshasubPartStandard
    {
        public LtbOshasubPartStandard()
        {
            InverseOshasubPartStandardParent = new HashSet<LtbOshasubPartStandard>();
        }

        public int OshasubPartStandardId { get; set; }
        public int? InspectionGoverningDocumentId { get; set; }
        public string OshasubPartStandardCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? OshasubPartStandardParentId { get; set; }
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

        public virtual LtbInspectionGoverningDocument InspectionGoverningDocument { get; set; }
        public virtual LtbOshasubPartStandard OshasubPartStandardParent { get; set; }
        public virtual ICollection<LtbOshasubPartStandard> InverseOshasubPartStandardParent { get; set; }
    }
}
