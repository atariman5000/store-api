using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbApplicationElement
    {
        public LtbApplicationElement()
        {
            InverseApplicationElementParent = new HashSet<LtbApplicationElement>();
            LtbApplicationModuleElementAssociation = new HashSet<LtbApplicationModuleElementAssociation>();
        }

        public int ApplicationElementId { get; set; }
        public string ApplicationElementCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? ApplicationElementParentId { get; set; }
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

        public virtual LtbApplicationElement ApplicationElementParent { get; set; }
        public virtual ICollection<LtbApplicationElement> InverseApplicationElementParent { get; set; }
        public virtual ICollection<LtbApplicationModuleElementAssociation> LtbApplicationModuleElementAssociation { get; set; }
    }
}
