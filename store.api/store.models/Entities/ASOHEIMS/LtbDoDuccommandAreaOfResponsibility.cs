using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbDoDuccommandAreaOfResponsibility
    {
        public LtbDoDuccommandAreaOfResponsibility()
        {
            InverseDoDuccommandAreaOfResponsibilityParent = new HashSet<LtbDoDuccommandAreaOfResponsibility>();
        }

        public int DoDuccommandAreaOfResponsibilityId { get; set; }
        public int CountryId { get; set; }
        public int DoDunifiedCombatantCommandId { get; set; }
        public int? DoDuccommandAreaOfResponsibilityParentId { get; set; }
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
        public virtual LtbDoDuccommandAreaOfResponsibility DoDuccommandAreaOfResponsibilityParent { get; set; }
        public virtual LtbDoDunifiedCombatantCommand DoDunifiedCombatantCommand { get; set; }
        public virtual ICollection<LtbDoDuccommandAreaOfResponsibility> InverseDoDuccommandAreaOfResponsibilityParent { get; set; }
    }
}
