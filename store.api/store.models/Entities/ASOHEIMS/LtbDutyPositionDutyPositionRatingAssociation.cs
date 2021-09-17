using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbDutyPositionDutyPositionRatingAssociation
    {
        public int DutyPositionDutyPositionRatingAssociationId { get; set; }
        public int DutyPositionId { get; set; }
        public int? UasseatPositionId { get; set; }
        public int DutyPositionRatingId { get; set; }
        public int MishapCategoryGroupId { get; set; }
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

        public virtual LtbPersonnelActivity DutyPosition { get; set; }
        public virtual LtbDutyPositionRating DutyPositionRating { get; set; }
        public virtual LtbMishapCategory MishapCategoryGroup { get; set; }
        public virtual LtbUasseatPosition UasseatPosition { get; set; }
    }
}
