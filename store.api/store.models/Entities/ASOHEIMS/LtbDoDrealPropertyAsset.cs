using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbDoDrealPropertyAsset
    {
        public LtbDoDrealPropertyAsset()
        {
            InverseDodrealPropertyAssetParent = new HashSet<LtbDoDrealPropertyAsset>();
        }

        public int DoDrealPropertyAssetId { get; set; }
        public string DoDrealPropertyAssetCode { get; set; }
        public string SiteName { get; set; }
        public string City { get; set; }
        public int? UsstateId { get; set; }
        public int? CountryId { get; set; }
        public string ZipCode5Digit { get; set; }
        public int? InstallationId { get; set; }
        public int? DodrealPropertyAssetParentId { get; set; }
        public string ValueDefinition { get; set; }
        public string Guidance { get; set; }
        public DateTime? EstablishDate { get; set; }
        public DateTime StartCollecting { get; set; }
        public DateTime? EndCollecting { get; set; }
        public string Used { get; set; }
        public int? DisplayOrder { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByUser { get; set; }
        public string CreatedByApp { get; set; }
        public string LastModifiedByUser { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedByApp { get; set; }

        public virtual LtbCountry Country { get; set; }
        public virtual LtbDoDrealPropertyAsset DodrealPropertyAssetParent { get; set; }
        public virtual LtbDoDinstallation Installation { get; set; }
        public virtual LtbUsstate Usstate { get; set; }
        public virtual ICollection<LtbDoDrealPropertyAsset> InverseDodrealPropertyAssetParent { get; set; }
    }
}
