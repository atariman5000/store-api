using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbDutyStatusLevel2Association
    {
        public int DutyStatusLevel2AssociationId { get; set; }
        public int DutyStatusId { get; set; }
        public int DutyStatusLevel2Id { get; set; }
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

        public virtual LtbDutyStatus DutyStatus { get; set; }
        public virtual LtbDutyStatusLevel2 DutyStatusLevel2 { get; set; }
    }
}
