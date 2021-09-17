using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbMishapStatus
    {
        public LtbMishapStatus()
        {
            InverseMishapStatusParent = new HashSet<LtbMishapStatus>();
            LtbMishapStatusDwprocessingStageAssociation = new HashSet<LtbMishapStatusDwprocessingStageAssociation>();
        }

        public int MishapStatusId { get; set; }
        public string MishapStatusCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? MishapStatusParentId { get; set; }
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

        public virtual LtbMishapStatus MishapStatusParent { get; set; }
        public virtual ICollection<LtbMishapStatus> InverseMishapStatusParent { get; set; }
        public virtual ICollection<LtbMishapStatusDwprocessingStageAssociation> LtbMishapStatusDwprocessingStageAssociation { get; set; }
    }
}
