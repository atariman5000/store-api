using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbCountryGencstatus
    {
        public LtbCountryGencstatus()
        {
            InverseCountryGencstatusParent = new HashSet<LtbCountryGencstatus>();
            LtbCountry = new HashSet<LtbCountry>();
        }

        public int CountryGencstatusId { get; set; }
        public string CountryGencstatusCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? CountryGencstatusParentId { get; set; }
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

        public virtual LtbCountryGencstatus CountryGencstatusParent { get; set; }
        public virtual ICollection<LtbCountryGencstatus> InverseCountryGencstatusParent { get; set; }
        public virtual ICollection<LtbCountry> LtbCountry { get; set; }
    }
}
