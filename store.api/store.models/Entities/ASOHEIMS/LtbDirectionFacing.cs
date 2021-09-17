using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbDirectionFacing
    {
        public LtbDirectionFacing()
        {
            InverseDirectionFacingParent = new HashSet<LtbDirectionFacing>();
        }

        public int DirectionFacingId { get; set; }
        public string DirectionFacingCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? DirectionFacingParentId { get; set; }
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

        public virtual LtbDirectionFacing DirectionFacingParent { get; set; }
        public virtual ICollection<LtbDirectionFacing> InverseDirectionFacingParent { get; set; }
    }
}
