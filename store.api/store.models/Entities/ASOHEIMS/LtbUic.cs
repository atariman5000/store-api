using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbUic
    {
        public LtbUic()
        {
            InverseUicparent = new HashSet<LtbUic>();
            LtbAircraft = new HashSet<LtbAircraft>();
            LtbDoDdmismedicalTreatmentFacility = new HashSet<LtbDoDdmismedicalTreatmentFacility>();
            LtbSubUic = new HashSet<LtbSubUic>();
            LtbUicadministrativeParentParentUic = new HashSet<LtbUicadministrativeParent>();
            LtbUicadministrativeParentUic = new HashSet<LtbUicadministrativeParent>();
            LtbUicdetailMajorArmyCommandUic = new HashSet<LtbUicdetail>();
            LtbUicdetailUic = new HashSet<LtbUicdetail>();
            LtbUichierarchyChild = new HashSet<LtbUichierarchy>();
            LtbUichierarchyParent = new HashSet<LtbUichierarchy>();
            LtbUicoperationalParentParentUic = new HashSet<LtbUicoperationalParent>();
            LtbUicoperationalParentUic = new HashSet<LtbUicoperationalParent>();
        }

        public int Uicid { get; set; }
        public string UnitIdentificationCode { get; set; }
        public bool ManuallyChanged { get; set; }
        public DateTime? DateManuallyChanged { get; set; }
        public int? OshaEstablishmentId { get; set; }
        public int? UicparentId { get; set; }
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

        public virtual LtbOshaEstablishment OshaEstablishment { get; set; }
        public virtual LtbUic Uicparent { get; set; }
        public virtual ICollection<LtbUic> InverseUicparent { get; set; }
        public virtual ICollection<LtbAircraft> LtbAircraft { get; set; }
        public virtual ICollection<LtbDoDdmismedicalTreatmentFacility> LtbDoDdmismedicalTreatmentFacility { get; set; }
        public virtual ICollection<LtbSubUic> LtbSubUic { get; set; }
        public virtual ICollection<LtbUicadministrativeParent> LtbUicadministrativeParentParentUic { get; set; }
        public virtual ICollection<LtbUicadministrativeParent> LtbUicadministrativeParentUic { get; set; }
        public virtual ICollection<LtbUicdetail> LtbUicdetailMajorArmyCommandUic { get; set; }
        public virtual ICollection<LtbUicdetail> LtbUicdetailUic { get; set; }
        public virtual ICollection<LtbUichierarchy> LtbUichierarchyChild { get; set; }
        public virtual ICollection<LtbUichierarchy> LtbUichierarchyParent { get; set; }
        public virtual ICollection<LtbUicoperationalParent> LtbUicoperationalParentParentUic { get; set; }
        public virtual ICollection<LtbUicoperationalParent> LtbUicoperationalParentUic { get; set; }
    }
}
