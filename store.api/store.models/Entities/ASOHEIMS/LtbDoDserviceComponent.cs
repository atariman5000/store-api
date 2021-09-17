using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbDoDserviceComponent
    {
        public LtbDoDserviceComponent()
        {
            InverseDoDserviceComponentParent = new HashSet<LtbDoDserviceComponent>();
            LtbDoDinstallation = new HashSet<LtbDoDinstallation>();
            LtbDoDinstallationMde = new HashSet<LtbDoDinstallationMde>();
            LtbDoDserviceComponentAssociation = new HashSet<LtbDoDserviceComponentAssociation>();
            LtbStation = new HashSet<LtbStation>();
            LtbUicdetail = new HashSet<LtbUicdetail>();
            LtbUicunitDescriptor = new HashSet<LtbUicunitDescriptor>();
        }

        public int DoDserviceComponentId { get; set; }
        public string DoDserviceComponentCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? DoDserviceComponentParentId { get; set; }
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

        public virtual LtbDoDserviceComponent DoDserviceComponentParent { get; set; }
        public virtual ICollection<LtbDoDserviceComponent> InverseDoDserviceComponentParent { get; set; }
        public virtual ICollection<LtbDoDinstallation> LtbDoDinstallation { get; set; }
        public virtual ICollection<LtbDoDinstallationMde> LtbDoDinstallationMde { get; set; }
        public virtual ICollection<LtbDoDserviceComponentAssociation> LtbDoDserviceComponentAssociation { get; set; }
        public virtual ICollection<LtbStation> LtbStation { get; set; }
        public virtual ICollection<LtbUicdetail> LtbUicdetail { get; set; }
        public virtual ICollection<LtbUicunitDescriptor> LtbUicunitDescriptor { get; set; }
    }
}
