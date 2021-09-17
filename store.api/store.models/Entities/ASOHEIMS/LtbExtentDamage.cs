using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbExtentDamage
    {
        public LtbExtentDamage()
        {
            InverseExtentDamageParent = new HashSet<LtbExtentDamage>();
        }

        public int ExtentDamageId { get; set; }
        public string ExtentDamageCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? ExtentDamageParentId { get; set; }
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

        public virtual LtbExtentDamage ExtentDamageParent { get; set; }
        public virtual ICollection<LtbExtentDamage> InverseExtentDamageParent { get; set; }
    }
}
