using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbUicunitDescriptor
    {
        public LtbUicunitDescriptor()
        {
            InverseUicunitDescriptiorParent = new HashSet<LtbUicunitDescriptor>();
            LtbUicdetail = new HashSet<LtbUicdetail>();
        }

        public int UicunitDescriptorId { get; set; }
        public string UicunitDescriptorCode { get; set; }
        public int UicunitPrimaryMissionId { get; set; }
        public int UicunitGeneralMissionId { get; set; }
        public int DoDserviceComponentId { get; set; }
        public bool IsActiveDuty { get; set; }
        public int? UicunitDescriptiorParentId { get; set; }
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

        public virtual LtbDoDserviceComponent DoDserviceComponent { get; set; }
        public virtual LtbUicunitDescriptor UicunitDescriptiorParent { get; set; }
        public virtual LtbUicunitGeneralMission UicunitGeneralMission { get; set; }
        public virtual LtbUicunitPrimaryMission UicunitPrimaryMission { get; set; }
        public virtual ICollection<LtbUicunitDescriptor> InverseUicunitDescriptiorParent { get; set; }
        public virtual ICollection<LtbUicdetail> LtbUicdetail { get; set; }
    }
}
