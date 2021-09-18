﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace store.dal.Models
{
    /// <summary>
    /// This table contains DoD Medical Treatment Facilities from the Defense Medical Information System (DMIS) a service of DoD which identifies past and current DoD Medical Facilities.   External Data Source.
    /// </summary>
    public partial class LtbDoDdmismedicalTreatmentFacility
    {
        /// <summary>
        /// Unique generated number for the record used for row identity.
        /// </summary>
        public int DoDdmismedicalTreatmentFacilityId { get; set; }
        /// <summary>
        /// The DMIS unique ID for medical treatment facility.
        /// </summary>
        public string Dmisid { get; set; }
        /// <summary>
        /// DCWID for the DMIC medical treatment facility.
        /// </summary>
        public string Dcwid { get; set; }
        /// <summary>
        /// The MEPRS Unit UIC ID for the DMIS medical treatment facility.
        /// </summary>
        public int? MeprsunitUicid { get; set; }
        /// <summary>
        /// The MEPRS Unit UIC for the DMIS medical treatment facility.
        /// </summary>
        public string MeprsunitUic { get; set; }
        /// <summary>
        /// Unique ID representing the facility service of the medical treatment facility.
        /// </summary>
        public int? FacilityServiceId { get; set; }
        /// <summary>
        /// Unique ID representing the facility type for the DMIS medical treatment facility.
        /// </summary>
        public int? DodfacilityTypeId { get; set; }
        /// <summary>
        /// The facility name for the DMIS medical treatment facility.
        /// </summary>
        public string DmisfacilityName { get; set; }
        /// <summary>
        /// Facility name of the medical treatment facility.
        /// </summary>
        public string FacilityName { get; set; }
        /// <summary>
        /// Unique ID representing the DoD Installation for the Medical treatment facility.
        /// </summary>
        public int? DoDinstallationId { get; set; }
        /// <summary>
        /// Country of the DoD DMIS Medical Treatment Facility. Unique ID representing Country.
        /// </summary>
        public int? CountryId { get; set; }
        /// <summary>
        /// Unique ID representing US State location.
        /// </summary>
        public int? UsstateId { get; set; }
        /// <summary>
        /// City of the medical treatment facility.
        /// </summary>
        public string FacilityCityName { get; set; }
        /// <summary>
        /// A code value for the current record.
        /// </summary>
        public string Facility5DigitZipcode { get; set; }
        /// <summary>
        /// A code value for the current record.
        /// </summary>
        public string Facility4DigitZipcode { get; set; }
        /// <summary>
        /// Unique ID representing the Health service region of the Medical Treatment facility.
        /// </summary>
        public int? HealthServiceRegionId { get; set; }
        /// <summary>
        /// A code value for the current record.
        /// </summary>
        public string UsflagCode { get; set; }
        /// <summary>
        /// Record Parent ID with Foreign key to the Primary key of the table.
        /// </summary>
        public int? DoDmedicalTreatmentFacilityDmisparentId { get; set; }
        /// <summary>
        /// Record Parent ID with Foreign key to the Primary key of the table.
        /// </summary>
        public int? DoDmedicalTreatmentFacilityMeprsparentId { get; set; }
        /// <summary>
        /// A code value for the current record.
        /// </summary>
        public string ServiceAreaCode { get; set; }
        /// <summary>
        /// A code value for the current record.
        /// </summary>
        public string FacilityCommandAssignmentCode { get; set; }
        /// <summary>
        /// Authorized TRICARE Enrollment Site for the DMIS medical treatment facility.
        /// </summary>
        public string AuthorizedTricareenrollmentSite { get; set; }
        /// <summary>
        /// A code value for the current record.
        /// </summary>
        public string Dhpcode { get; set; }
        /// <summary>
        /// Unique ID representing the branch of service for DMIS medical treatment facility.
        /// </summary>
        public int? BranchofServiceId { get; set; }
        /// <summary>
        /// NPI2Required value for the DMIS Medical Treatment Facility.
        /// </summary>
        public string Npi2required { get; set; }
        /// <summary>
        /// NPI2Number value for the DMIS Medical Treatment Facility.
        /// </summary>
        public string Npi2number { get; set; }
        /// <summary>
        /// NPI2HIPAATaxonomy value for the DMIS Medical Treatment Facility.
        /// </summary>
        public string Npi2hipaataxonomy { get; set; }
        /// <summary>
        /// The definition of the code value according to Regulatory Guidance or Business.
        /// </summary>
        public string ValueDefinition { get; set; }
        /// <summary>
        /// The Business Rule, Regulatory or Other Army/DoD Guidance that states the code use requirement.  If available, include the publish and effective dates.
        /// </summary>
        public string Guidance { get; set; }
        /// <summary>
        /// The date the code value was established for use.  This date may or may not be the same as the start collecting date.
        /// </summary>
        public DateTime? EstablishDate { get; set; }
        /// <summary>
        /// Date the code value was available to be assigned to a record.  Records assigned the code value must have a Date greater than or equal to the Start Collecting Date. Will default to the current date upon entry unless otherwise specified.  The time for start collecting date should always be 0000.
        /// </summary>
        public DateTime StartCollecting { get; set; }
        /// <summary>
        /// Date the code was taken out of circulation for collection.  Incidents assigned the code value must have a Date Occurred less than or equal to the End Collecting Date.  The time for end collecting date should always be 2359.
        /// </summary>
        public DateTime? EndCollecting { get; set; }
        /// <summary>
        /// A flag to indicate whether the code is active and assigned to action records. If no records have the code assigned and it is no longer active,  then the current value should be N. Valid values: Y/N
        /// </summary>
        public string Used { get; set; }
        /// <summary>
        /// Numeric sorting order to control the way the codes/types are listed in drop downs within the application or module.
        /// </summary>
        public int? DisplayOrder { get; set; }
        /// <summary>
        /// The user who created the record.
        /// </summary>
        public string CreatedByUser { get; set; }
        /// <summary>
        /// The date the record was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// Application used to create the record.
        /// </summary>
        public string CreatedByApp { get; set; }
        /// <summary>
        /// The user to last update the record.
        /// </summary>
        public string LastModifiedByUser { get; set; }
        /// <summary>
        /// The date the record was last updated.
        /// </summary>
        public DateTime LastModifiedDate { get; set; }
        /// <summary>
        /// Application used to last update the record.
        /// </summary>
        public string LastModifiedByApp { get; set; }

        public virtual LtbTcfacilityServiceBranch BranchofService { get; set; }
        public virtual LtbCountry Country { get; set; }
        public virtual LtbDoDinstallation DoDinstallation { get; set; }
        public virtual LtbHealthServiceRegion HealthServiceRegion { get; set; }
        public virtual LtbUic MeprsunitUicNavigation { get; set; }
        public virtual LtbUsstate Usstate { get; set; }
    }
}