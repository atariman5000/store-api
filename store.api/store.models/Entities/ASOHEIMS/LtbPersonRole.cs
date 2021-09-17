using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbPersonRole
    {
        public LtbPersonRole()
        {
            InversePersonRoleParent = new HashSet<LtbPersonRole>();
            LtbMishapCategoryGroupPersonnelActivityAssociation = new HashSet<LtbMishapCategoryGroupPersonnelActivityAssociation>();
            LtbNotificationType = new HashSet<LtbNotificationType>();
        }

        public int PersonRoleId { get; set; }
        public string PersonRoleCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? PersonRoleParentId { get; set; }
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

        public virtual LtbPersonRole PersonRoleParent { get; set; }
        public virtual ICollection<LtbPersonRole> InversePersonRoleParent { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupPersonnelActivityAssociation> LtbMishapCategoryGroupPersonnelActivityAssociation { get; set; }
        public virtual ICollection<LtbNotificationType> LtbNotificationType { get; set; }
    }
}
