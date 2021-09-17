using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbMissionType
    {
        public LtbMissionType()
        {
            InverseMissionTypeParent = new HashSet<LtbMissionType>();
            LtbMishapCategoryGroupMissionTypeAssociation = new HashSet<LtbMishapCategoryGroupMissionTypeAssociation>();
            LtbMishapInitialDueDateCriteria = new HashSet<LtbMishapInitialDueDateCriteria>();
        }

        public int MissionTypeId { get; set; }
        public string MissionTypeCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? MissionTypeParentId { get; set; }
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

        public virtual LtbMissionType MissionTypeParent { get; set; }
        public virtual ICollection<LtbMissionType> InverseMissionTypeParent { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupMissionTypeAssociation> LtbMishapCategoryGroupMissionTypeAssociation { get; set; }
        public virtual ICollection<LtbMishapInitialDueDateCriteria> LtbMishapInitialDueDateCriteria { get; set; }
    }
}
