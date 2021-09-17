using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbDmdcpersonnelListing
    {
        public int DmdcpersonnelListingId { get; set; }
        public string Edipi { get; set; }
        public string Ssn { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Cadency { get; set; }
        public string BirthDate { get; set; }
        public string EmailId { get; set; }
        public int? Age { get; set; }
        public int? GenderId { get; set; }
        public int? DoDserviceId { get; set; }
        public string UniformedServiceOrganizationComponentCode { get; set; }
        public int? PayGradeId { get; set; }
        public string PayGradeModifierCode { get; set; }
        public string UscitizenStatusCode { get; set; }
        public int? PrimaryMoscivJobSeriesJobTitleId { get; set; }
        public int? DutyMoscivJobSeriesJobTitleId { get; set; }
        public int? SecondaryMoscivJobSeriesJobTitleId { get; set; }
        public int? PrimaryDoDoccupationalJobTitleId { get; set; }
        public int? DutyDoDoccupationalJobTitleId { get; set; }
        public int? SecondaryDoDoccupationalJobTitleId { get; set; }
        public string MilAeronauticalRatingCode { get; set; }
        public string MilFlyingStatusIndicatorCode { get; set; }
        public int? AssignedUicid { get; set; }
        public int? AssignedLocationStateId { get; set; }
        public int? AssignedLocationCountryId { get; set; }
        public string AssignedLocationZipCode5Digit { get; set; }
        public string AssignedLocationZipCode4Digit { get; set; }
        public string AssignedLocationCountyCode { get; set; }
        public string AssignedMajorCommandCode { get; set; }
        public int? AssignedDoDinstallationId { get; set; }
        public int? DutyUicid { get; set; }
        public int? DutyLocationStateId { get; set; }
        public int? DutyLocationCountryId { get; set; }
        public string DutyLocationZipCode5Digit { get; set; }
        public string DutyLocationZipCode4Digit { get; set; }
        public string DutyLocationCountyCode { get; set; }
        public string DutyMajorCommandCode { get; set; }
        public int? DutyDoDinstallationId { get; set; }
        public string StartDate { get; set; }
        public string Dmdcresponse { get; set; }
        public Guid OrigUniqueIdentifier { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string CreatedByUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByApp { get; set; }
        public string LastModifiedByUser { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedByApp { get; set; }
    }
}
