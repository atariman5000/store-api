using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbApplicationModule
    {
        public LtbApplicationModule()
        {
            InverseApplicationModuleParent = new HashSet<LtbApplicationModule>();
            LtbApplicationModuleElementAssociation = new HashSet<LtbApplicationModuleElementAssociation>();
            LtbApplicationModuleMishapCategoryGroupDisplayOrder = new HashSet<LtbApplicationModuleMishapCategoryGroupDisplayOrder>();
            LtbAsmisapplicationModuleAssociation = new HashSet<LtbAsmisapplicationModuleAssociation>();
            LtbMishapCategoryGroupApplicationModuleAssociation = new HashSet<LtbMishapCategoryGroupApplicationModuleAssociation>();
        }

        public int ApplicationModuleId { get; set; }
        public string ApplicationModuleCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? ApplicationModuleParentId { get; set; }
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

        public virtual LtbApplicationModule ApplicationModuleParent { get; set; }
        public virtual ICollection<LtbApplicationModule> InverseApplicationModuleParent { get; set; }
        public virtual ICollection<LtbApplicationModuleElementAssociation> LtbApplicationModuleElementAssociation { get; set; }
        public virtual ICollection<LtbApplicationModuleMishapCategoryGroupDisplayOrder> LtbApplicationModuleMishapCategoryGroupDisplayOrder { get; set; }
        public virtual ICollection<LtbAsmisapplicationModuleAssociation> LtbAsmisapplicationModuleAssociation { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupApplicationModuleAssociation> LtbMishapCategoryGroupApplicationModuleAssociation { get; set; }
    }
}
