using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbSubUic
    {
        public LtbSubUic()
        {
            InverseSubUicparent = new HashSet<LtbSubUic>();
        }

        public int Subuicid { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public int Uicid { get; set; }
        public int? SubUicparentId { get; set; }
        public string ValueDefinition { get; set; }
        public string Guidance { get; set; }
        public string Used { get; set; }
        public int? DisplayOrder { get; set; }
        public DateTime? EstablishDate { get; set; }
        public DateTime StartCollecting { get; set; }
        public DateTime? EndCollecting { get; set; }
        public string CreatedByUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByApp { get; set; }
        public string LastModifiedByUser { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedByApp { get; set; }
        public bool ManuallyChanged { get; set; }
        public DateTime? DateManuallyChanged { get; set; }

        public virtual LtbSubUic SubUicparent { get; set; }
        public virtual LtbUic Uic { get; set; }
        public virtual ICollection<LtbSubUic> InverseSubUicparent { get; set; }
    }
}
