using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbDoDinstallation
    {
        public LtbDoDinstallation()
        {
            InverseDodinstallationParent = new HashSet<LtbDoDinstallation>();
            LtbDoDdmismedicalTreatmentFacility = new HashSet<LtbDoDdmismedicalTreatmentFacility>();
            LtbDoDrealPropertyAsset = new HashSet<LtbDoDrealPropertyAsset>();
            LtbDoDunifiedCombatantCommand = new HashSet<LtbDoDunifiedCombatantCommand>();
        }

        public int DoDinstallationId { get; set; }
        public string DoDinstallationCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? UsstateId { get; set; }
        public int? CountryId { get; set; }
        public int? DodinstallationTypeId { get; set; }
        public string InstallationStatus { get; set; }
        public int? PrimaryDoDserviceId { get; set; }
        public int? ComponentId { get; set; }
        public string NearestCityName { get; set; }
        public string ZipCode5Digit { get; set; }
        public string ZipCode4Digit { get; set; }
        public string FullCountryName { get; set; }
        public string FullStateName { get; set; }
        public int? WorldRegionId { get; set; }
        public string Vppstatus { get; set; }
        public int? DodinstallationParentId { get; set; }
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

        public virtual LtbDoDserviceComponent Component { get; set; }
        public virtual LtbCountry Country { get; set; }
        public virtual LtbDoDinstallation DodinstallationParent { get; set; }
        public virtual LtbDoDinstallationType DodinstallationType { get; set; }
        public virtual LtbDoDservice PrimaryDoDservice { get; set; }
        public virtual LtbUsstate Usstate { get; set; }
        public virtual LtbWorldRegion WorldRegion { get; set; }
        public virtual ICollection<LtbDoDinstallation> InverseDodinstallationParent { get; set; }
        public virtual ICollection<LtbDoDdmismedicalTreatmentFacility> LtbDoDdmismedicalTreatmentFacility { get; set; }
        public virtual ICollection<LtbDoDrealPropertyAsset> LtbDoDrealPropertyAsset { get; set; }
        public virtual ICollection<LtbDoDunifiedCombatantCommand> LtbDoDunifiedCombatantCommand { get; set; }
    }
}
