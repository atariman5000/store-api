using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbAircraftDesignationPersonnelActivityAssociation
    {
        public int AircraftDesignationPersonnelActivityAssociationId { get; set; }
        public int AircraftDesignationId { get; set; }
        public int PersonnelActivityId { get; set; }
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

        public virtual LtbAircraftDesignation AircraftDesignation { get; set; }
        public virtual LtbPersonnelActivity PersonnelActivity { get; set; }
    }
}
