using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbAsmisapplicationModuleAssociation
    {
        public int AsmisapplicationModuleAssociationId { get; set; }
        public int? AsmisapplicationId { get; set; }
        public int? ApplicationModuleId { get; set; }
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

        public virtual LtbApplicationModule ApplicationModule { get; set; }
        public virtual LtbAsmisapplication Asmisapplication { get; set; }
    }
}
