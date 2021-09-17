using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbDoDinstallationType
    {
        public LtbDoDinstallationType()
        {
            InverseDodinstallationTypeParent = new HashSet<LtbDoDinstallationType>();
            LtbDoDinstallation = new HashSet<LtbDoDinstallation>();
            LtbDoDinstallationMde = new HashSet<LtbDoDinstallationMde>();
        }

        public int DoDinstallationTypeId { get; set; }
        public string DoDinstallationTypeCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? DodinstallationTypeParentId { get; set; }
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

        public virtual LtbDoDinstallationType DodinstallationTypeParent { get; set; }
        public virtual ICollection<LtbDoDinstallationType> InverseDodinstallationTypeParent { get; set; }
        public virtual ICollection<LtbDoDinstallation> LtbDoDinstallation { get; set; }
        public virtual ICollection<LtbDoDinstallationMde> LtbDoDinstallationMde { get; set; }
    }
}
