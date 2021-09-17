using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbEnvironmentalDetailType
    {
        public LtbEnvironmentalDetailType()
        {
            InverseEnvironmentalDetailTypeParent = new HashSet<LtbEnvironmentalDetailType>();
            LtbMishapCategoryGroupEnvironmentalDetailTypeAssociation = new HashSet<LtbMishapCategoryGroupEnvironmentalDetailTypeAssociation>();
        }

        public int EnvironmentalDetailTypeId { get; set; }
        public string EnvironmentalDetailTypeCode { get; set; }
        public string ColumnName { get; set; }
        public int? MinValue { get; set; }
        public int? MaxValue { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? EnvironmentalDetailTypeParentId { get; set; }
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

        public virtual LtbEnvironmentalDetailType EnvironmentalDetailTypeParent { get; set; }
        public virtual ICollection<LtbEnvironmentalDetailType> InverseEnvironmentalDetailTypeParent { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupEnvironmentalDetailTypeAssociation> LtbMishapCategoryGroupEnvironmentalDetailTypeAssociation { get; set; }
    }
}
