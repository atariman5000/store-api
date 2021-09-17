using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbPhaseofOperation
    {
        public LtbPhaseofOperation()
        {
            InversePhaseofOperationParent = new HashSet<LtbPhaseofOperation>();
            LtbMishapCategoryGroupPhaseOfOperationAssociation = new HashSet<LtbMishapCategoryGroupPhaseOfOperationAssociation>();
        }

        public int PhaseofOperationId { get; set; }
        public string PhaseofOperationCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? PhaseofOperationParentId { get; set; }
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

        public virtual LtbPhaseofOperation PhaseofOperationParent { get; set; }
        public virtual ICollection<LtbPhaseofOperation> InversePhaseofOperationParent { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupPhaseOfOperationAssociation> LtbMishapCategoryGroupPhaseOfOperationAssociation { get; set; }
    }
}
