using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbInjuryCostCategory
    {
        public LtbInjuryCostCategory()
        {
            InverseInjuryCostCategoryParent = new HashSet<LtbInjuryCostCategory>();
            LtbInjuryCostCategoryMishapPersonAssociation = new HashSet<LtbInjuryCostCategoryMishapPersonAssociation>();
            LtbInjuryCostStandard = new HashSet<LtbInjuryCostStandard>();
        }

        public int InjuryCostCategoryId { get; set; }
        public string InjuryCostCategoryCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? InjuryCostCategoryParentId { get; set; }
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

        public virtual LtbInjuryCostCategory InjuryCostCategoryParent { get; set; }
        public virtual ICollection<LtbInjuryCostCategory> InverseInjuryCostCategoryParent { get; set; }
        public virtual ICollection<LtbInjuryCostCategoryMishapPersonAssociation> LtbInjuryCostCategoryMishapPersonAssociation { get; set; }
        public virtual ICollection<LtbInjuryCostStandard> LtbInjuryCostStandard { get; set; }
    }
}
