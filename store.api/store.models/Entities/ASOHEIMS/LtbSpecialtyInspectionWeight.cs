using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbSpecialtyInspectionWeight
    {
        public LtbSpecialtyInspectionWeight()
        {
            InverseSpecialtyInspectionWeightParent = new HashSet<LtbSpecialtyInspectionWeight>();
        }

        public int SpecialtyInspectionWeightId { get; set; }
        public string SpecialtyInspectionWeightCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? SpecialtyInspectionWeightParentId { get; set; }
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

        public virtual LtbSpecialtyInspectionWeight SpecialtyInspectionWeightParent { get; set; }
        public virtual ICollection<LtbSpecialtyInspectionWeight> InverseSpecialtyInspectionWeightParent { get; set; }
    }
}
