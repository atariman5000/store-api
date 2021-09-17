using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbAircraftMdsmodifiedMission
    {
        public LtbAircraftMdsmodifiedMission()
        {
            InverseAircraftMdsmodifiedMissionParent = new HashSet<LtbAircraftMdsmodifiedMission>();
            LtbAircraftMtds = new HashSet<LtbAircraftMtds>();
        }

        public int AircraftMdsmodifiedMissionId { get; set; }
        public string AircraftMdsmodifiedMission { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? AircraftMdsmodifiedMissionParentId { get; set; }
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

        public virtual LtbAircraftMdsmodifiedMission AircraftMdsmodifiedMissionParent { get; set; }
        public virtual ICollection<LtbAircraftMdsmodifiedMission> InverseAircraftMdsmodifiedMissionParent { get; set; }
        public virtual ICollection<LtbAircraftMtds> LtbAircraftMtds { get; set; }
    }
}
