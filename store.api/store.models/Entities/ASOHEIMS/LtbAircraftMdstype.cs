using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbAircraftMdstype
    {
        public LtbAircraftMdstype()
        {
            InverseAircraftMdstypeParent = new HashSet<LtbAircraftMdstype>();
            LtbAircraftMtds = new HashSet<LtbAircraftMtds>();
            LtbMishapCategoryGroupAircraftMdstypeAssociation = new HashSet<LtbMishapCategoryGroupAircraftMdstypeAssociation>();
        }

        public int AircraftMdstypeId { get; set; }
        public string AircraftMdstypeCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? AircraftMdstypeParentId { get; set; }
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

        public virtual LtbAircraftMdstype AircraftMdstypeParent { get; set; }
        public virtual ICollection<LtbAircraftMdstype> InverseAircraftMdstypeParent { get; set; }
        public virtual ICollection<LtbAircraftMtds> LtbAircraftMtds { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupAircraftMdstypeAssociation> LtbMishapCategoryGroupAircraftMdstypeAssociation { get; set; }
    }
}
