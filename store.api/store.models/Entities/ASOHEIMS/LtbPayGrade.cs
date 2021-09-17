using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbPayGrade
    {
        public LtbPayGrade()
        {
            InversePayGradeParent = new HashSet<LtbPayGrade>();
            LtbEmploymentStatusPayGradeAssociation = new HashSet<LtbEmploymentStatusPayGradeAssociation>();
            LtbInjuryCostCategoryMishapPersonAssociation = new HashSet<LtbInjuryCostCategoryMishapPersonAssociation>();
            LtbPayGradeCivilianJobSeriesAssociation = new HashSet<LtbPayGradeCivilianJobSeriesAssociation>();
            LtbPayGradeMilitaryOccupationSpecialityAssociation = new HashSet<LtbPayGradeMilitaryOccupationSpecialityAssociation>();
            LtbRankPayGradeAssociation = new HashSet<LtbRankPayGradeAssociation>();
        }

        public int PayGradeId { get; set; }
        public string PayGradeCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? PayGradeParentId { get; set; }
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

        public virtual LtbPayGrade PayGradeParent { get; set; }
        public virtual ICollection<LtbPayGrade> InversePayGradeParent { get; set; }
        public virtual ICollection<LtbEmploymentStatusPayGradeAssociation> LtbEmploymentStatusPayGradeAssociation { get; set; }
        public virtual ICollection<LtbInjuryCostCategoryMishapPersonAssociation> LtbInjuryCostCategoryMishapPersonAssociation { get; set; }
        public virtual ICollection<LtbPayGradeCivilianJobSeriesAssociation> LtbPayGradeCivilianJobSeriesAssociation { get; set; }
        public virtual ICollection<LtbPayGradeMilitaryOccupationSpecialityAssociation> LtbPayGradeMilitaryOccupationSpecialityAssociation { get; set; }
        public virtual ICollection<LtbRankPayGradeAssociation> LtbRankPayGradeAssociation { get; set; }
    }
}
