using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbNaindustryClassification
    {
        public LtbNaindustryClassification()
        {
            InverseNaindustryClassificationParent = new HashSet<LtbNaindustryClassification>();
            LtbEstablishmentNaicassociation = new HashSet<LtbEstablishmentNaicassociation>();
        }

        public int NaindustryClassificationId { get; set; }
        public string NaindustryClassificationCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? NaindustryClassificationParentId { get; set; }
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

        public virtual LtbNaindustryClassification NaindustryClassificationParent { get; set; }
        public virtual ICollection<LtbNaindustryClassification> InverseNaindustryClassificationParent { get; set; }
        public virtual ICollection<LtbEstablishmentNaicassociation> LtbEstablishmentNaicassociation { get; set; }
    }
}
