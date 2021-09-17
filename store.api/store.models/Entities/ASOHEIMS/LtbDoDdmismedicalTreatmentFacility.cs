using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbDoDdmismedicalTreatmentFacility
    {
        public LtbDoDdmismedicalTreatmentFacility()
        {
            InverseDoDmedicalTreatmentFacilityDmisparent = new HashSet<LtbDoDdmismedicalTreatmentFacility>();
            InverseDoDmedicalTreatmentFacilityMeprsparent = new HashSet<LtbDoDdmismedicalTreatmentFacility>();
        }

        public int DoDdmismedicalTreatmentFacilityId { get; set; }
        public string Dmisid { get; set; }
        public string Dcwid { get; set; }
        public int? MeprsunitUicid { get; set; }
        public string MeprsunitUic { get; set; }
        public int? FacilityServiceId { get; set; }
        public int? DodfacilityTypeId { get; set; }
        public string DmisfacilityName { get; set; }
        public string FacilityName { get; set; }
        public int? DoDinstallationId { get; set; }
        public int? CountryId { get; set; }
        public int? UsstateId { get; set; }
        public string FacilityCityName { get; set; }
        public string Facility5DigitZipcode { get; set; }
        public string Facility4DigitZipcode { get; set; }
        public int? HealthServiceRegionId { get; set; }
        public string UsflagCode { get; set; }
        public int? DoDmedicalTreatmentFacilityDmisparentId { get; set; }
        public int? DoDmedicalTreatmentFacilityMeprsparentId { get; set; }
        public string ServiceAreaCode { get; set; }
        public string FacilityCommandAssignmentCode { get; set; }
        public string AuthorizedTricareenrollmentSite { get; set; }
        public string Dhpcode { get; set; }
        public int? BranchofServiceId { get; set; }
        public string Npi2required { get; set; }
        public string Npi2number { get; set; }
        public string Npi2hipaataxonomy { get; set; }
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

        public virtual LtbTcfacilityServiceBranch BranchofService { get; set; }
        public virtual LtbCountry Country { get; set; }
        public virtual LtbDoDinstallation DoDinstallation { get; set; }
        public virtual LtbDoDdmismedicalTreatmentFacility DoDmedicalTreatmentFacilityDmisparent { get; set; }
        public virtual LtbDoDdmismedicalTreatmentFacility DoDmedicalTreatmentFacilityMeprsparent { get; set; }
        public virtual LtbTcdoDmedicalFacilityType DodfacilityType { get; set; }
        public virtual LtbDoDservice FacilityService { get; set; }
        public virtual LtbHealthServiceRegion HealthServiceRegion { get; set; }
        public virtual LtbUic MeprsunitUicNavigation { get; set; }
        public virtual LtbUsstate Usstate { get; set; }
        public virtual ICollection<LtbDoDdmismedicalTreatmentFacility> InverseDoDmedicalTreatmentFacilityDmisparent { get; set; }
        public virtual ICollection<LtbDoDdmismedicalTreatmentFacility> InverseDoDmedicalTreatmentFacilityMeprsparent { get; set; }
    }
}
