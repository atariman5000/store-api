using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbMishapStatusDwprocessingStageAssociation
    {
        public int MishapStatusDwprocessingStageAssociationId { get; set; }
        public int MishapSourceId { get; set; }
        public int MishapStatusId { get; set; }
        public int? DwprocessingStageId { get; set; }
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

        public virtual LtbDwprocessingStage DwprocessingStage { get; set; }
        public virtual LtbMishapStatus MishapStatus { get; set; }
    }
}
