using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbUicoperationalParent
    {
        public int UicoperationalParentId { get; set; }
        public int Uicid { get; set; }
        public int? ParentUicid { get; set; }
        public bool ManuallyChanged { get; set; }
        public DateTime? DateManuallyChanged { get; set; }
        public DateTime StartCollecting { get; set; }
        public DateTime? EndCollecting { get; set; }
        public string Used { get; set; }
        public string CreatedByUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByApp { get; set; }
        public string LastModifiedByUser { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedByApp { get; set; }

        public virtual LtbUic ParentUic { get; set; }
        public virtual LtbUic Uic { get; set; }
    }
}
