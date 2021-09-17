using System;
using System.Collections.Generic;
using store.models.Interfaces;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbUicdetail : IAsoheimsBaseEntity
    {
        public LtbUicdetail()
        {
            InverseUicdetailParent = new HashSet<LtbUicdetail>();
        }

        public int Id { get; set; }
        public string UnitIdentificationCode { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public int Uicid { get; set; }
        public int? MajorArmyCommandUicid { get; set; }
        public string Uicabbreviation { get; set; }
        public int? UicarmyCommandTypeId { get; set; }
        public int? UicactivityStatusId { get; set; }
        public int? UicfunctionalAreaId { get; set; }
        public int? UiccommandAssignmentId { get; set; }
        public int? UicunitDescriptorId { get; set; }
        public string UicunitDescriptorCode { get; set; }
        public int? UicunitTypeConstructionId { get; set; }
        public int? HomeGeographicLocationId { get; set; }
        public int? PresentGeographicLocationId { get; set; }
        public string UnitPresentLocationZipCode { get; set; }
        public int? MobilizedResponseId { get; set; }
        public string Tpsn5 { get; set; }
        public int? UicunitLevelId { get; set; }
        public int? DoDunifiedCombatantCommandId { get; set; }
        public int? DoDserviceId { get; set; }
        public int? DoDserviceComponentId { get; set; }
        public int? ArmyBranchId { get; set; }
        public int? ArmyOrganizationTypeId { get; set; }
        public int? UicorganizationEntityStatusId { get; set; }
        public DateTime? OrganizationDate { get; set; }
        public int? OshaEstablishmentId { get; set; }
        public int? InstallationStationId { get; set; }
        public int? DrrsAsortsId { get; set; }
        public bool ManuallyChanged { get; set; }
        public DateTime? DateManuallyChanged { get; set; }
        public int? UicdetailParentId { get; set; }
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

        public virtual LtbArmyBranch ArmyBranch { get; set; }
        public virtual LtbUicarmyOrganizationType ArmyOrganizationType { get; set; }
        public virtual LtbDoDservice DoDservice { get; set; }
        public virtual LtbDoDserviceComponent DoDserviceComponent { get; set; }
        public virtual LtbDoDunifiedCombatantCommand DoDunifiedCombatantCommand { get; set; }
        public virtual LtbGeographicLocation HomeGeographicLocation { get; set; }
        public virtual LtbStation InstallationStation { get; set; }
        public virtual LtbUic MajorArmyCommandUic { get; set; }
        public virtual LtbResponse MobilizedResponse { get; set; }
        public virtual LtbOshaEstablishment OshaEstablishment { get; set; }
        public virtual LtbGeographicLocation PresentGeographicLocation { get; set; }
        public virtual LtbUic Uic { get; set; }
        public virtual LtbUicactivityStatus UicactivityStatus { get; set; }
        public virtual LtbUicarmyCommandType UicarmyCommandType { get; set; }
        public virtual LtbUiccommandAssignment UiccommandAssignment { get; set; }
        public virtual LtbUicdetail UicdetailParent { get; set; }
        public virtual LtbUicfunctionalArea UicfunctionalArea { get; set; }
        public virtual LtbUicorganizationEntityStatus UicorganizationEntityStatus { get; set; }
        public virtual LtbUicunitDescriptor UicunitDescriptor { get; set; }
        public virtual LtbUicunitLevel UicunitLevel { get; set; }
        public virtual LtbUicunitTypeConstruction UicunitTypeConstruction { get; set; }
        public virtual ICollection<LtbUicdetail> InverseUicdetailParent { get; set; }
    }
}
