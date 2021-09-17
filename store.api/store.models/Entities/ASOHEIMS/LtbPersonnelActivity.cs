using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbPersonnelActivity
    {
        public LtbPersonnelActivity()
        {
            InversePersonnelActivityParent = new HashSet<LtbPersonnelActivity>();
            LtbAircraftDesignationPersonnelActivityAssociation = new HashSet<LtbAircraftDesignationPersonnelActivityAssociation>();
            LtbDutyPositionDutyPositionRatingAssociation = new HashSet<LtbDutyPositionDutyPositionRatingAssociation>();
            LtbDutyPostionExperienceCollected = new HashSet<LtbDutyPostionExperienceCollected>();
            LtbMishapCategoryGroupPersonnelActivityAssociation = new HashSet<LtbMishapCategoryGroupPersonnelActivityAssociation>();
            LtbPersonnelActivityUasseatPositionAssociation = new HashSet<LtbPersonnelActivityUasseatPositionAssociation>();
        }

        public int PersonnelActivityId { get; set; }
        public string PersonnelActivityCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? PersonnelActivityParentId { get; set; }
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

        public virtual LtbPersonnelActivity PersonnelActivityParent { get; set; }
        public virtual ICollection<LtbPersonnelActivity> InversePersonnelActivityParent { get; set; }
        public virtual ICollection<LtbAircraftDesignationPersonnelActivityAssociation> LtbAircraftDesignationPersonnelActivityAssociation { get; set; }
        public virtual ICollection<LtbDutyPositionDutyPositionRatingAssociation> LtbDutyPositionDutyPositionRatingAssociation { get; set; }
        public virtual ICollection<LtbDutyPostionExperienceCollected> LtbDutyPostionExperienceCollected { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupPersonnelActivityAssociation> LtbMishapCategoryGroupPersonnelActivityAssociation { get; set; }
        public virtual ICollection<LtbPersonnelActivityUasseatPositionAssociation> LtbPersonnelActivityUasseatPositionAssociation { get; set; }
    }
}
