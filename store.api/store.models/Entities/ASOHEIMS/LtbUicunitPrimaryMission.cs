using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbUicunitPrimaryMission
    {
        public LtbUicunitPrimaryMission()
        {
            InverseUicunitPrimaryMissionParent = new HashSet<LtbUicunitPrimaryMission>();
            LtbUicunitDescriptor = new HashSet<LtbUicunitDescriptor>();
        }

        public int UicunitPrimaryMissionId { get; set; }
        public string UicunitPrimaryMissionCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? UicunitPrimaryMissionParentId { get; set; }
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

        public virtual LtbUicunitPrimaryMission UicunitPrimaryMissionParent { get; set; }
        public virtual ICollection<LtbUicunitPrimaryMission> InverseUicunitPrimaryMissionParent { get; set; }
        public virtual ICollection<LtbUicunitDescriptor> LtbUicunitDescriptor { get; set; }
    }
}
