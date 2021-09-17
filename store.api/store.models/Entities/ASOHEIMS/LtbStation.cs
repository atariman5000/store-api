using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbStation
    {
        public LtbStation()
        {
            InverseStationParent = new HashSet<LtbStation>();
            LtbAircraft = new HashSet<LtbAircraft>();
            LtbUicdetail = new HashSet<LtbUicdetail>();
        }

        public int StationId { get; set; }
        public string StationCode { get; set; }
        public string GeographicLocationCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? DoDserviceId { get; set; }
        public int? DoDserviceComponentId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int? UsstateId { get; set; }
        public string ZipCode { get; set; }
        public int? CountryId { get; set; }
        public int? InstallationLocationTypeId { get; set; }
        public string StationAbbreviatedName { get; set; }
        public string GeographicLocationName { get; set; }
        public string Gridcoordinates { get; set; }
        public string GeographicPointLocation { get; set; }
        public string LatitudeLongitudeDescription { get; set; }
        public string LatitudeDirection { get; set; }
        public int? LatitudeDegrees { get; set; }
        public int? LatitudeMinutes { get; set; }
        public int? LatitudeSeconds { get; set; }
        public string LongitudeDirection { get; set; }
        public int? LongitudeDegrees { get; set; }
        public int? LongitudeMinutes { get; set; }
        public int? LongitudeSeconds { get; set; }
        public int? Latitude { get; set; }
        public int? Longitude { get; set; }
        public string Xcoordinate { get; set; }
        public string Ycoordinate { get; set; }
        public int? StationParentId { get; set; }
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

        public virtual LtbCountry Country { get; set; }
        public virtual LtbDoDservice DoDservice { get; set; }
        public virtual LtbDoDserviceComponent DoDserviceComponent { get; set; }
        public virtual LtbInstallationLocationType InstallationLocationType { get; set; }
        public virtual LtbStation StationParent { get; set; }
        public virtual LtbUsstate Usstate { get; set; }
        public virtual ICollection<LtbStation> InverseStationParent { get; set; }
        public virtual ICollection<LtbAircraft> LtbAircraft { get; set; }
        public virtual ICollection<LtbUicdetail> LtbUicdetail { get; set; }
    }
}
