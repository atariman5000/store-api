using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbAircraftMtds
    {
        public LtbAircraftMtds()
        {
            LtbAircraft = new HashSet<LtbAircraft>();
            LtbMishapCategoryGroupAircraftMtdsassociation = new HashSet<LtbMishapCategoryGroupAircraftMtdsassociation>();
        }

        public int AircraftMtdsid { get; set; }
        public string AircraftMtdscode { get; set; }
        public int? AircraftMdswingTypeId { get; set; }
        public int? StatusPrefixId { get; set; }
        public int? ModifiedMissionId { get; set; }
        public int? BasicMissionId { get; set; }
        public int? AircraftDesignationId { get; set; }
        public int? VehicleTypeId { get; set; }
        public int? ManufacturerId { get; set; }
        public int? DoDserviceId { get; set; }
        public int? AircraftMdstypeId { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
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

        public virtual LtbAircraftDesignation AircraftDesignation { get; set; }
        public virtual LtbAircraftMdstype AircraftMdstype { get; set; }
        public virtual LtbAircraftMdswingType AircraftMdswingType { get; set; }
        public virtual LtbAircraftMdsbasicMission BasicMission { get; set; }
        public virtual LtbDoDservice DoDservice { get; set; }
        public virtual LtbManufacturer Manufacturer { get; set; }
        public virtual LtbAircraftMdsmodifiedMission ModifiedMission { get; set; }
        public virtual LtbAircraftMdsstatusPrefix StatusPrefix { get; set; }
        public virtual LtbAircraftMdsvehicleType VehicleType { get; set; }
        public virtual ICollection<LtbAircraft> LtbAircraft { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupAircraftMtdsassociation> LtbMishapCategoryGroupAircraftMtdsassociation { get; set; }
    }
}
