using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbWorldRegion
    {
        public LtbWorldRegion()
        {
            InverseWorldRegionParent = new HashSet<LtbWorldRegion>();
            LtbCountryWorldRegionAssociation = new HashSet<LtbCountryWorldRegionAssociation>();
            LtbDoDinstallation = new HashSet<LtbDoDinstallation>();
        }

        public int WorldRegionId { get; set; }
        public string WorldRegionCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? WorldRegionParentId { get; set; }
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

        public virtual LtbWorldRegion WorldRegionParent { get; set; }
        public virtual ICollection<LtbWorldRegion> InverseWorldRegionParent { get; set; }
        public virtual ICollection<LtbCountryWorldRegionAssociation> LtbCountryWorldRegionAssociation { get; set; }
        public virtual ICollection<LtbDoDinstallation> LtbDoDinstallation { get; set; }
    }
}
