using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbDutyStatusLevel2
    {
        public LtbDutyStatusLevel2()
        {
            InverseDutyStatusLevel2Parent = new HashSet<LtbDutyStatusLevel2>();
            LtbDutyStatusLevel2Association = new HashSet<LtbDutyStatusLevel2Association>();
        }

        public int DutyStatusLevel2Id { get; set; }
        public string DutyStatusLevel2Code { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? DutyStatusLevel2ParentId { get; set; }
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

        public virtual LtbDutyStatusLevel2 DutyStatusLevel2Parent { get; set; }
        public virtual ICollection<LtbDutyStatusLevel2> InverseDutyStatusLevel2Parent { get; set; }
        public virtual ICollection<LtbDutyStatusLevel2Association> LtbDutyStatusLevel2Association { get; set; }
    }
}
