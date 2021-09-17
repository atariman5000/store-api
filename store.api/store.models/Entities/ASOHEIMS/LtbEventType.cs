using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbEventType
    {
        public LtbEventType()
        {
            InverseEventTypeParent = new HashSet<LtbEventType>();
            LtbMishapCategoryGroupEventTypeAssociation = new HashSet<LtbMishapCategoryGroupEventTypeAssociation>();
        }

        public int EventTypeId { get; set; }
        public string EventTypeCode { get; set; }
        public bool? PrimaryEvent { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? EventTypeParentId { get; set; }
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

        public virtual LtbEventType EventTypeParent { get; set; }
        public virtual ICollection<LtbEventType> InverseEventTypeParent { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupEventTypeAssociation> LtbMishapCategoryGroupEventTypeAssociation { get; set; }
    }
}
