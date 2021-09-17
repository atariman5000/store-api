using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbMishapCategory
    {
        public LtbMishapCategory()
        {
            InverseMishapCategoryParent = new HashSet<LtbMishapCategory>();
            LtbApplicationModuleMishapCategoryGroupDisplayOrder = new HashSet<LtbApplicationModuleMishapCategoryGroupDisplayOrder>();
            LtbDutyPositionDutyPositionRatingAssociation = new HashSet<LtbDutyPositionDutyPositionRatingAssociation>();
            LtbMishapCategoryGroupAircraftMdstypeAssociation = new HashSet<LtbMishapCategoryGroupAircraftMdstypeAssociation>();
            LtbMishapCategoryGroupAircraftMtdsassociation = new HashSet<LtbMishapCategoryGroupAircraftMtdsassociation>();
            LtbMishapCategoryGroupApplicationModuleAssociation = new HashSet<LtbMishapCategoryGroupApplicationModuleAssociation>();
            LtbMishapCategoryGroupCertificationTypeAssociation = new HashSet<LtbMishapCategoryGroupCertificationTypeAssociation>();
            LtbMishapCategoryGroupEnvironmentalDetailTypeAssociation = new HashSet<LtbMishapCategoryGroupEnvironmentalDetailTypeAssociation>();
            LtbMishapCategoryGroupEventTypeAssociation = new HashSet<LtbMishapCategoryGroupEventTypeAssociation>();
            LtbMishapCategoryGroupFireTypeAssociation = new HashSet<LtbMishapCategoryGroupFireTypeAssociation>();
            LtbMishapCategoryGroupGeneralMaterielObjectAssociation = new HashSet<LtbMishapCategoryGroupGeneralMaterielObjectAssociation>();
            LtbMishapCategoryGroupInformationTypeAssociation = new HashSet<LtbMishapCategoryGroupInformationTypeAssociation>();
            LtbMishapCategoryGroupMaterielObjectAssociation = new HashSet<LtbMishapCategoryGroupMaterielObjectAssociation>();
            LtbMishapCategoryGroupMishapCategoryAssociationMishapCategory = new HashSet<LtbMishapCategoryGroupMishapCategoryAssociation>();
            LtbMishapCategoryGroupMishapCategoryAssociationMishapCategoryGroup = new HashSet<LtbMishapCategoryGroupMishapCategoryAssociation>();
            LtbMishapCategoryGroupMissionTypeAssociation = new HashSet<LtbMishapCategoryGroupMissionTypeAssociation>();
            LtbMishapCategoryGroupMistakeAssociation = new HashSet<LtbMishapCategoryGroupMistakeAssociation>();
            LtbMishapCategoryGroupNarrativeTypeAssociation = new HashSet<LtbMishapCategoryGroupNarrativeTypeAssociation>();
            LtbMishapCategoryGroupNightVisionDeviceAssociation = new HashSet<LtbMishapCategoryGroupNightVisionDeviceAssociation>();
            LtbMishapCategoryGroupPersonnelActivityAssociation = new HashSet<LtbMishapCategoryGroupPersonnelActivityAssociation>();
            LtbMishapCategoryGroupPhaseOfOperationAssociation = new HashSet<LtbMishapCategoryGroupPhaseOfOperationAssociation>();
            LtbMishapCategoryGroupProtectiveEquipmentAssociation = new HashSet<LtbMishapCategoryGroupProtectiveEquipmentAssociation>();
            LtbMishapCategoryGroupTrainingTypeAssociation = new HashSet<LtbMishapCategoryGroupTrainingTypeAssociation>();
            LtbMishapInitialDueDateCriteria = new HashSet<LtbMishapInitialDueDateCriteria>();
        }

        public int MishapCategoryId { get; set; }
        public string MishapCategoryCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? MishapCategoryParentId { get; set; }
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

        public virtual LtbMishapCategory MishapCategoryParent { get; set; }
        public virtual ICollection<LtbMishapCategory> InverseMishapCategoryParent { get; set; }
        public virtual ICollection<LtbApplicationModuleMishapCategoryGroupDisplayOrder> LtbApplicationModuleMishapCategoryGroupDisplayOrder { get; set; }
        public virtual ICollection<LtbDutyPositionDutyPositionRatingAssociation> LtbDutyPositionDutyPositionRatingAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupAircraftMdstypeAssociation> LtbMishapCategoryGroupAircraftMdstypeAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupAircraftMtdsassociation> LtbMishapCategoryGroupAircraftMtdsassociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupApplicationModuleAssociation> LtbMishapCategoryGroupApplicationModuleAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupCertificationTypeAssociation> LtbMishapCategoryGroupCertificationTypeAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupEnvironmentalDetailTypeAssociation> LtbMishapCategoryGroupEnvironmentalDetailTypeAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupEventTypeAssociation> LtbMishapCategoryGroupEventTypeAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupFireTypeAssociation> LtbMishapCategoryGroupFireTypeAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupGeneralMaterielObjectAssociation> LtbMishapCategoryGroupGeneralMaterielObjectAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupInformationTypeAssociation> LtbMishapCategoryGroupInformationTypeAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupMaterielObjectAssociation> LtbMishapCategoryGroupMaterielObjectAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupMishapCategoryAssociation> LtbMishapCategoryGroupMishapCategoryAssociationMishapCategory { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupMishapCategoryAssociation> LtbMishapCategoryGroupMishapCategoryAssociationMishapCategoryGroup { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupMissionTypeAssociation> LtbMishapCategoryGroupMissionTypeAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupMistakeAssociation> LtbMishapCategoryGroupMistakeAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupNarrativeTypeAssociation> LtbMishapCategoryGroupNarrativeTypeAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupNightVisionDeviceAssociation> LtbMishapCategoryGroupNightVisionDeviceAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupPersonnelActivityAssociation> LtbMishapCategoryGroupPersonnelActivityAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupPhaseOfOperationAssociation> LtbMishapCategoryGroupPhaseOfOperationAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupProtectiveEquipmentAssociation> LtbMishapCategoryGroupProtectiveEquipmentAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupTrainingTypeAssociation> LtbMishapCategoryGroupTrainingTypeAssociation { get; set; }
        public virtual ICollection<LtbMishapInitialDueDateCriteria> LtbMishapInitialDueDateCriteria { get; set; }
    }
}
