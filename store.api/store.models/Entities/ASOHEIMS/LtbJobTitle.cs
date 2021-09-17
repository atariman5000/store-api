using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbJobTitle
    {
        public LtbJobTitle()
        {
            InverseJobTitleParent = new HashSet<LtbJobTitle>();
            LtbInjuryCostCategoryMishapPersonAssociation = new HashSet<LtbInjuryCostCategoryMishapPersonAssociation>();
        }

        public int JobTitleId { get; set; }
        public string JobTitleCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? JobTitleParentId { get; set; }
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

        public virtual LtbJobTitle JobTitleParent { get; set; }
        public virtual ICollection<LtbJobTitle> InverseJobTitleParent { get; set; }
        public virtual ICollection<LtbInjuryCostCategoryMishapPersonAssociation> LtbInjuryCostCategoryMishapPersonAssociation { get; set; }
    }
}
