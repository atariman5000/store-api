using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbCounty
    {
        public LtbCounty()
        {
            InverseCountyParent = new HashSet<LtbCounty>();
            LtbZipCode = new HashSet<LtbZipCode>();
        }

        public int CountyId { get; set; }
        public string CountyCode { get; set; }
        public int? UsstateId { get; set; }
        public int CountryId { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? CountyParentId { get; set; }
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
        public virtual LtbCounty CountyParent { get; set; }
        public virtual LtbUsstate Usstate { get; set; }
        public virtual ICollection<LtbCounty> InverseCountyParent { get; set; }
        public virtual ICollection<LtbZipCode> LtbZipCode { get; set; }
    }
}
