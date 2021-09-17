using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbAircraft
    {
        public int AircraftId { get; set; }
        public string Lin { get; set; }
        public string Eic { get; set; }
        public string AircraftSerialNumber { get; set; }
        public int? AircraftMtdsid { get; set; }
        public string Nomenclature { get; set; }
        public int? CockpitAirbagInstalledResponseId { get; set; }
        public DateTime? DateCockpitAirbagInstalled { get; set; }
        public string NationalItemIdentificationNumber { get; set; }
        public int? ReportingUicid { get; set; }
        public int? StationId { get; set; }
        public string UnitLocation { get; set; }
        public int? AssignmentFunctionId { get; set; }
        public int? AircraftStatusId { get; set; }
        public int? AircraftStatusReasonId { get; set; }
        public DateTime? ArmyAcceptanceDate { get; set; }
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

        public virtual LtbAircraftMtds AircraftMtds { get; set; }
        public virtual LtbAircraftStatus AircraftStatus { get; set; }
        public virtual LtbAircraftStatusReason AircraftStatusReason { get; set; }
        public virtual LtbAircraftAssignmentFunction AssignmentFunction { get; set; }
        public virtual LtbResponse CockpitAirbagInstalledResponse { get; set; }
        public virtual LtbUic ReportingUic { get; set; }
        public virtual LtbStation Station { get; set; }
    }
}
