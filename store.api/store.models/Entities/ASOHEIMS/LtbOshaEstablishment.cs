using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbOshaEstablishment
    {
        public LtbOshaEstablishment()
        {
            LtbEstablishmentNaicassociation = new HashSet<LtbEstablishmentNaicassociation>();
            LtbUic = new HashSet<LtbUic>();
            LtbUicdetail = new HashSet<LtbUicdetail>();
        }

        public int OshaEstablishmentId { get; set; }
        public string OshaEstablishmentCode { get; set; }
        public string MajorCommand { get; set; }
        public string CommandName { get; set; }
        public string Msc { get; set; }
        public string SubordinateReport1 { get; set; }
        public string SubordinateReport2 { get; set; }
        public string SubordinateReport3 { get; set; }
        public string BuildingStreetAddress { get; set; }
        public string City { get; set; }
        public int? UsstateId { get; set; }
        public int? CountryId { get; set; }
        public string Zipcode5Digit { get; set; }
        public string Zipcode4Digit { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
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
        public virtual ICollection<LtbEstablishmentNaicassociation> LtbEstablishmentNaicassociation { get; set; }
        public virtual ICollection<LtbUic> LtbUic { get; set; }
        public virtual ICollection<LtbUicdetail> LtbUicdetail { get; set; }
    }
}
