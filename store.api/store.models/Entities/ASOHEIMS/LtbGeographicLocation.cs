using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbGeographicLocation
    {
        public LtbGeographicLocation()
        {
            LtbUicdetailHomeGeographicLocation = new HashSet<LtbUicdetail>();
            LtbUicdetailPresentGeographicLocation = new HashSet<LtbUicdetail>();
        }

        public int GeographicLocationId { get; set; }
        public string GeographicLocationCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? UsstateId { get; set; }
        public int? CountryId { get; set; }
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
        public virtual LtbUsstate Usstate { get; set; }
        public virtual ICollection<LtbUicdetail> LtbUicdetailHomeGeographicLocation { get; set; }
        public virtual ICollection<LtbUicdetail> LtbUicdetailPresentGeographicLocation { get; set; }
    }
}
