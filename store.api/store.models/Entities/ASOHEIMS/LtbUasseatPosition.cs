using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbUasseatPosition
    {
        public LtbUasseatPosition()
        {
            InverseUasseatPositionParent = new HashSet<LtbUasseatPosition>();
            LtbDutyPositionDutyPositionRatingAssociation = new HashSet<LtbDutyPositionDutyPositionRatingAssociation>();
            LtbPersonnelActivityUasseatPositionAssociation = new HashSet<LtbPersonnelActivityUasseatPositionAssociation>();
        }

        public int UasseatPositionId { get; set; }
        public string UasseatPositionCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? UasseatPositionParentId { get; set; }
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

        public virtual LtbUasseatPosition UasseatPositionParent { get; set; }
        public virtual ICollection<LtbUasseatPosition> InverseUasseatPositionParent { get; set; }
        public virtual ICollection<LtbDutyPositionDutyPositionRatingAssociation> LtbDutyPositionDutyPositionRatingAssociation { get; set; }
        public virtual ICollection<LtbPersonnelActivityUasseatPositionAssociation> LtbPersonnelActivityUasseatPositionAssociation { get; set; }
    }
}
