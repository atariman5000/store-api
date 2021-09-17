using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbUicprofileStatus
    {
        public LtbUicprofileStatus()
        {
            InverseUicprofileStatusParent = new HashSet<LtbUicprofileStatus>();
        }

        public int UicprofileStatusId { get; set; }
        public string UicprofileStatusCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? UicprofileStatusParentId { get; set; }
        public string ValueDefinition { get; set; }
        public string Guidance { get; set; }
        public DateTime? EstablishDate { get; set; }
        public string Used { get; set; }
        public int? DisplayOrder { get; set; }
        public string CreatedByUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByApp { get; set; }
        public string LastModifiedByUser { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedByApp { get; set; }

        public virtual LtbUicprofileStatus UicprofileStatusParent { get; set; }
        public virtual ICollection<LtbUicprofileStatus> InverseUicprofileStatusParent { get; set; }
    }
}
