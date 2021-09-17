using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbApplicationForm
    {
        public LtbApplicationForm()
        {
            InverseApplicationFormParent = new HashSet<LtbApplicationForm>();
            LtbApplicationQuestion = new HashSet<LtbApplicationQuestion>();
        }

        public int ApplicationFormId { get; set; }
        public string ApplicationFormCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? ApplicationFormParentId { get; set; }
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

        public virtual LtbApplicationForm ApplicationFormParent { get; set; }
        public virtual ICollection<LtbApplicationForm> InverseApplicationFormParent { get; set; }
        public virtual ICollection<LtbApplicationQuestion> LtbApplicationQuestion { get; set; }
    }
}
