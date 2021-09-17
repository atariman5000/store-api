using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbInformationType
    {
        public LtbInformationType()
        {
            InverseInformationTypeParent = new HashSet<LtbInformationType>();
            LtbInformationTypeAssociationTypeAssociation = new HashSet<LtbInformationTypeAssociationTypeAssociation>();
            LtbMishapCategoryGroupInformationTypeAssociation = new HashSet<LtbMishapCategoryGroupInformationTypeAssociation>();
        }

        public int InformationTypeId { get; set; }
        public string InformationTypeCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? InformationTypeParentId { get; set; }
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

        public virtual LtbInformationType InformationTypeParent { get; set; }
        public virtual ICollection<LtbInformationType> InverseInformationTypeParent { get; set; }
        public virtual ICollection<LtbInformationTypeAssociationTypeAssociation> LtbInformationTypeAssociationTypeAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupInformationTypeAssociation> LtbMishapCategoryGroupInformationTypeAssociation { get; set; }
    }
}
