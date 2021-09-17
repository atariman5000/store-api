using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbFireType
    {
        public LtbFireType()
        {
            InverseFireTypeParent = new HashSet<LtbFireType>();
            LtbMishapCategoryGroupFireTypeAssociation = new HashSet<LtbMishapCategoryGroupFireTypeAssociation>();
        }

        public int FireTypeId { get; set; }
        public string FireTypeCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? FireTypeParentId { get; set; }
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

        public virtual LtbFireType FireTypeParent { get; set; }
        public virtual ICollection<LtbFireType> InverseFireTypeParent { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupFireTypeAssociation> LtbMishapCategoryGroupFireTypeAssociation { get; set; }
    }
}
