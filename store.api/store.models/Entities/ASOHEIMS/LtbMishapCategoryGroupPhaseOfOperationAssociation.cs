using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbMishapCategoryGroupPhaseOfOperationAssociation
    {
        public int MishapCategoryGroupPhaseOfOperationAssociationId { get; set; }
        public int MishapCategoryGroupId { get; set; }
        public int PhaseOfOperationId { get; set; }
        public int FlightDataTypeId { get; set; }
        public int AircraftDesignationId { get; set; }
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
        public virtual LtbFlightDataType FlightDataType { get; set; }
        public virtual LtbMishapCategory MishapCategoryGroup { get; set; }
        public virtual LtbPhaseofOperation PhaseOfOperation { get; set; }
    }
}
