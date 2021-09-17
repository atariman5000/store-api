using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbManufacturer
    {
        public LtbManufacturer()
        {
            InverseManufacturerParent = new HashSet<LtbManufacturer>();
            LtbAircraftMtds = new HashSet<LtbAircraftMtds>();
        }

        public int ManufacturerId { get; set; }
        public string ManufacturerCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? ManufacturerParentId { get; set; }
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
        public virtual LtbManufacturer ManufacturerParent { get; set; }
        public virtual LtbUsstate Usstate { get; set; }
        public virtual ICollection<LtbManufacturer> InverseManufacturerParent { get; set; }
        public virtual ICollection<LtbAircraftMtds> LtbAircraftMtds { get; set; }
    }
}
