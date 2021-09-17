using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbUicunitLevel
    {
        public LtbUicunitLevel()
        {
            InverseUicunitLevelParent = new HashSet<LtbUicunitLevel>();
            LtbUicdetail = new HashSet<LtbUicdetail>();
        }

        public int UicunitLevelId { get; set; }
        public string UicunitLevelCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? UicunitLevelParentId { get; set; }
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

        public virtual LtbUicunitLevel UicunitLevelParent { get; set; }
        public virtual ICollection<LtbUicunitLevel> InverseUicunitLevelParent { get; set; }
        public virtual ICollection<LtbUicdetail> LtbUicdetail { get; set; }
    }
}
