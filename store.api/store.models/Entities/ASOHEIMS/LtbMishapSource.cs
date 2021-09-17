using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbMishapSource
    {
        public LtbMishapSource()
        {
            InverseMishapSourceParent = new HashSet<LtbMishapSource>();
            LtbMishapInitialDueDateCriteria = new HashSet<LtbMishapInitialDueDateCriteria>();
        }

        public int MishapSourceId { get; set; }
        public string MishapSourceCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? MishapSourceParentId { get; set; }
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

        public virtual LtbMishapSource MishapSourceParent { get; set; }
        public virtual ICollection<LtbMishapSource> InverseMishapSourceParent { get; set; }
        public virtual ICollection<LtbMishapInitialDueDateCriteria> LtbMishapInitialDueDateCriteria { get; set; }
    }
}
