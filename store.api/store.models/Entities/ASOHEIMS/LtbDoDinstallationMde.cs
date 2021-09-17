using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbDoDinstallationMde
    {
        public LtbDoDinstallationMde()
        {
            InverseDodinstallationMdeparent = new HashSet<LtbDoDinstallationMde>();
        }

        public int DoDinstallationMdeid { get; set; }
        public string DoDinstallationMdecode { get; set; }
        public string DoDinstallationName { get; set; }
        public string ZipCode5Digit { get; set; }
        public string City { get; set; }
        public int? UsstateId { get; set; }
        public int? CountryId { get; set; }
        public int? DoDserviceId { get; set; }
        public int? DoDserviceComponentId { get; set; }
        public int? DodinstallationMdeparentId { get; set; }
        public int? InstallationTypeId { get; set; }
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

        public virtual LtbCountry Country { get; set; }
        public virtual LtbDoDservice DoDservice { get; set; }
        public virtual LtbDoDserviceComponent DoDserviceComponent { get; set; }
        public virtual LtbDoDinstallationMde DodinstallationMdeparent { get; set; }
        public virtual LtbDoDinstallationType InstallationType { get; set; }
        public virtual LtbUsstate Usstate { get; set; }
        public virtual ICollection<LtbDoDinstallationMde> InverseDodinstallationMdeparent { get; set; }
    }
}
