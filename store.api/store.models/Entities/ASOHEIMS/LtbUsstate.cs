using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbUsstate
    {
        public LtbUsstate()
        {
            InverseUsstateParent = new HashSet<LtbUsstate>();
            LtbCounty = new HashSet<LtbCounty>();
            LtbDoDdmismedicalTreatmentFacility = new HashSet<LtbDoDdmismedicalTreatmentFacility>();
            LtbDoDinstallation = new HashSet<LtbDoDinstallation>();
            LtbDoDinstallationMde = new HashSet<LtbDoDinstallationMde>();
            LtbDoDrealPropertyAsset = new HashSet<LtbDoDrealPropertyAsset>();
            LtbGeographicLocation = new HashSet<LtbGeographicLocation>();
            LtbManufacturer = new HashSet<LtbManufacturer>();
            LtbOshaEstablishment = new HashSet<LtbOshaEstablishment>();
            LtbReserveRegionUsstateAssociation = new HashSet<LtbReserveRegionUsstateAssociation>();
            LtbStation = new HashSet<LtbStation>();
            LtbZipCode = new HashSet<LtbZipCode>();
        }

        public int UsstateId { get; set; }
        public string UsstateCode { get; set; }
        public string Abbreviation { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? UsstateParentId { get; set; }
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

        public virtual LtbUsstate UsstateParent { get; set; }
        public virtual ICollection<LtbUsstate> InverseUsstateParent { get; set; }
        public virtual ICollection<LtbCounty> LtbCounty { get; set; }
        public virtual ICollection<LtbDoDdmismedicalTreatmentFacility> LtbDoDdmismedicalTreatmentFacility { get; set; }
        public virtual ICollection<LtbDoDinstallation> LtbDoDinstallation { get; set; }
        public virtual ICollection<LtbDoDinstallationMde> LtbDoDinstallationMde { get; set; }
        public virtual ICollection<LtbDoDrealPropertyAsset> LtbDoDrealPropertyAsset { get; set; }
        public virtual ICollection<LtbGeographicLocation> LtbGeographicLocation { get; set; }
        public virtual ICollection<LtbManufacturer> LtbManufacturer { get; set; }
        public virtual ICollection<LtbOshaEstablishment> LtbOshaEstablishment { get; set; }
        public virtual ICollection<LtbReserveRegionUsstateAssociation> LtbReserveRegionUsstateAssociation { get; set; }
        public virtual ICollection<LtbStation> LtbStation { get; set; }
        public virtual ICollection<LtbZipCode> LtbZipCode { get; set; }
    }
}
