using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbNoteType
    {
        public LtbNoteType()
        {
            InverseNoteTypeParent = new HashSet<LtbNoteType>();
        }

        public int NoteTypeId { get; set; }
        public string NoteTypeCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? NoteTypeParentId { get; set; }
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

        public virtual LtbNoteType NoteTypeParent { get; set; }
        public virtual ICollection<LtbNoteType> InverseNoteTypeParent { get; set; }
    }
}
