using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbMaterielObject
    {
        public LtbMaterielObject()
        {
            InverseMaterielObjectParent = new HashSet<LtbMaterielObject>();
            LtbMaterielObjectTacticalIndicatorAssociation = new HashSet<LtbMaterielObjectTacticalIndicatorAssociation>();
            LtbMishapCategoryGroupGeneralMaterielObjectAssociation = new HashSet<LtbMishapCategoryGroupGeneralMaterielObjectAssociation>();
            LtbMishapCategoryGroupMaterielObjectAssociation = new HashSet<LtbMishapCategoryGroupMaterielObjectAssociation>();
            LtbMishapCategoryGroupNightVisionDeviceAssociation = new HashSet<LtbMishapCategoryGroupNightVisionDeviceAssociation>();
            LtbMishapCategoryGroupProtectiveEquipmentAssociation = new HashSet<LtbMishapCategoryGroupProtectiveEquipmentAssociation>();
            LtbParachuteEquipmentMaterielObjectAssociation = new HashSet<LtbParachuteEquipmentMaterielObjectAssociation>();
        }

        public int MaterielObjectId { get; set; }
        public string MaterielObjectCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? MaterielObjectParentId { get; set; }
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

        public virtual LtbMaterielObject MaterielObjectParent { get; set; }
        public virtual ICollection<LtbMaterielObject> InverseMaterielObjectParent { get; set; }
        public virtual ICollection<LtbMaterielObjectTacticalIndicatorAssociation> LtbMaterielObjectTacticalIndicatorAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupGeneralMaterielObjectAssociation> LtbMishapCategoryGroupGeneralMaterielObjectAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupMaterielObjectAssociation> LtbMishapCategoryGroupMaterielObjectAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupNightVisionDeviceAssociation> LtbMishapCategoryGroupNightVisionDeviceAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupProtectiveEquipmentAssociation> LtbMishapCategoryGroupProtectiveEquipmentAssociation { get; set; }
        public virtual ICollection<LtbParachuteEquipmentMaterielObjectAssociation> LtbParachuteEquipmentMaterielObjectAssociation { get; set; }
    }
}
