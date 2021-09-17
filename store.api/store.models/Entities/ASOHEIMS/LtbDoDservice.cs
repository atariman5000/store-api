using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbDoDservice
    {
        public LtbDoDservice()
        {
            InverseDoDserviceParent = new HashSet<LtbDoDservice>();
            LtbAircraftMtds = new HashSet<LtbAircraftMtds>();
            LtbDoDdmismedicalTreatmentFacility = new HashSet<LtbDoDdmismedicalTreatmentFacility>();
            LtbDoDinstallation = new HashSet<LtbDoDinstallation>();
            LtbDoDinstallationMde = new HashSet<LtbDoDinstallationMde>();
            LtbDoDserviceComponentAssociation = new HashSet<LtbDoDserviceComponentAssociation>();
            LtbStation = new HashSet<LtbStation>();
            LtbUicdetail = new HashSet<LtbUicdetail>();
        }

        public int DoDserviceId { get; set; }
        public string DoDserviceCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? DoDserviceParentId { get; set; }
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

        public virtual LtbDoDservice DoDserviceParent { get; set; }
        public virtual ICollection<LtbDoDservice> InverseDoDserviceParent { get; set; }
        public virtual ICollection<LtbAircraftMtds> LtbAircraftMtds { get; set; }
        public virtual ICollection<LtbDoDdmismedicalTreatmentFacility> LtbDoDdmismedicalTreatmentFacility { get; set; }
        public virtual ICollection<LtbDoDinstallation> LtbDoDinstallation { get; set; }
        public virtual ICollection<LtbDoDinstallationMde> LtbDoDinstallationMde { get; set; }
        public virtual ICollection<LtbDoDserviceComponentAssociation> LtbDoDserviceComponentAssociation { get; set; }
        public virtual ICollection<LtbStation> LtbStation { get; set; }
        public virtual ICollection<LtbUicdetail> LtbUicdetail { get; set; }
    }
}
