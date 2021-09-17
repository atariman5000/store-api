using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbDoDunifiedCombatantCommand
    {
        public LtbDoDunifiedCombatantCommand()
        {
            InverseDoDunifiedCombatantCommandParent = new HashSet<LtbDoDunifiedCombatantCommand>();
            LtbDoDuccommandAreaOfResponsibility = new HashSet<LtbDoDuccommandAreaOfResponsibility>();
            LtbUicdetail = new HashSet<LtbUicdetail>();
        }

        public int DoDunifiedCombatantCommandId { get; set; }
        public string DoDunifiedCombatantCommandCode { get; set; }
        public int DoDunifiedCombatantRoleId { get; set; }
        public int? DoDinstallationId { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? DoDunifiedCombatantCommandParentId { get; set; }
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

        public virtual LtbDoDinstallation DoDinstallation { get; set; }
        public virtual LtbDoDunifiedCombatantCommand DoDunifiedCombatantCommandParent { get; set; }
        public virtual LtbDoDunifiedCombatantRole DoDunifiedCombatantRole { get; set; }
        public virtual ICollection<LtbDoDunifiedCombatantCommand> InverseDoDunifiedCombatantCommandParent { get; set; }
        public virtual ICollection<LtbDoDuccommandAreaOfResponsibility> LtbDoDuccommandAreaOfResponsibility { get; set; }
        public virtual ICollection<LtbUicdetail> LtbUicdetail { get; set; }
    }
}
