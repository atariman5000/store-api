using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbMishapClassification
    {
        public LtbMishapClassification()
        {
            InverseMishapClassificationParent = new HashSet<LtbMishapClassification>();
        }

        public int MishapClassificationId { get; set; }
        public string MishapClassificationCode { get; set; }
        public int? MishapClassificationTypeId { get; set; }
        public long? LowCost { get; set; }
        public long? HighCost { get; set; }
        public string InjurySeverity { get; set; }
        public short? PersonnelHospitalizedLimit { get; set; }
        public short? DaysLostLimit { get; set; }
        public short? DaysRestrictedLimit { get; set; }
        public string PrimaryEvent { get; set; }
        public string ArmyAccountable { get; set; }
        public string MistakesMade { get; set; }
        public string TotalLoss { get; set; }
        public string Category { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? MishapClassificationParentId { get; set; }
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

        public virtual LtbMishapClassification MishapClassificationParent { get; set; }
        public virtual LtbMishapClassificationType MishapClassificationType { get; set; }
        public virtual ICollection<LtbMishapClassification> InverseMishapClassificationParent { get; set; }
    }
}
