using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbPpequestionNarrativeAssociation
    {
        public LtbPpequestionNarrativeAssociation()
        {
            InverseQuestionNarrativeAssociationParent = new HashSet<LtbPpequestionNarrativeAssociation>();
        }

        public int PpequestionNarrativeAssociationId { get; set; }
        public string PpequestionNarrativeAssociationCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string AssociatedTable { get; set; }
        public string AssociatedColumn { get; set; }
        public int? RequiredResponseId { get; set; }
        public string NarrativeQuestion { get; set; }
        public int? QuestionNarrativeAssociationParentId { get; set; }
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

        public virtual LtbPpequestionNarrativeAssociation QuestionNarrativeAssociationParent { get; set; }
        public virtual ICollection<LtbPpequestionNarrativeAssociation> InverseQuestionNarrativeAssociationParent { get; set; }
    }
}
