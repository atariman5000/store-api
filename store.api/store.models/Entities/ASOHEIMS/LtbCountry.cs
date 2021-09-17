using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbCountry
    {
        public LtbCountry()
        {
            InverseCountryParent = new HashSet<LtbCountry>();
            LtbCountryWorldRegionAssociation = new HashSet<LtbCountryWorldRegionAssociation>();
            LtbCounty = new HashSet<LtbCounty>();
            LtbDoDdmismedicalTreatmentFacility = new HashSet<LtbDoDdmismedicalTreatmentFacility>();
            LtbDoDinstallation = new HashSet<LtbDoDinstallation>();
            LtbDoDinstallationMde = new HashSet<LtbDoDinstallationMde>();
            LtbDoDrealPropertyAsset = new HashSet<LtbDoDrealPropertyAsset>();
            LtbDoDuccommandAreaOfResponsibility = new HashSet<LtbDoDuccommandAreaOfResponsibility>();
            LtbGeographicLocation = new HashSet<LtbGeographicLocation>();
            LtbManufacturer = new HashSet<LtbManufacturer>();
            LtbOshaEstablishment = new HashSet<LtbOshaEstablishment>();
            LtbStation = new HashSet<LtbStation>();
            LtbZipCode = new HashSet<LtbZipCode>();
        }

        public int CountryId { get; set; }
        public string CountryCode3Char { get; set; }
        public string CountryCode2Char { get; set; }
        public string NumericCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int CountryUsrecognitionId { get; set; }
        public int CountryGencstatusId { get; set; }
        public int? CountryParentId { get; set; }
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

        public virtual LtbCountryGencstatus CountryGencstatus { get; set; }
        public virtual LtbCountry CountryParent { get; set; }
        public virtual LtbCountryUsrecognition CountryUsrecognition { get; set; }
        public virtual ICollection<LtbCountry> InverseCountryParent { get; set; }
        public virtual ICollection<LtbCountryWorldRegionAssociation> LtbCountryWorldRegionAssociation { get; set; }
        public virtual ICollection<LtbCounty> LtbCounty { get; set; }
        public virtual ICollection<LtbDoDdmismedicalTreatmentFacility> LtbDoDdmismedicalTreatmentFacility { get; set; }
        public virtual ICollection<LtbDoDinstallation> LtbDoDinstallation { get; set; }
        public virtual ICollection<LtbDoDinstallationMde> LtbDoDinstallationMde { get; set; }
        public virtual ICollection<LtbDoDrealPropertyAsset> LtbDoDrealPropertyAsset { get; set; }
        public virtual ICollection<LtbDoDuccommandAreaOfResponsibility> LtbDoDuccommandAreaOfResponsibility { get; set; }
        public virtual ICollection<LtbGeographicLocation> LtbGeographicLocation { get; set; }
        public virtual ICollection<LtbManufacturer> LtbManufacturer { get; set; }
        public virtual ICollection<LtbOshaEstablishment> LtbOshaEstablishment { get; set; }
        public virtual ICollection<LtbStation> LtbStation { get; set; }
        public virtual ICollection<LtbZipCode> LtbZipCode { get; set; }
    }
}
