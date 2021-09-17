﻿using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbInspectionQuestionRac
    {
        public LtbInspectionQuestionRac()
        {
            InverseInspectionQuestionRacparent = new HashSet<LtbInspectionQuestionRac>();
        }

        public int InspectionQuestionRacid { get; set; }
        public int? InspectionQuestionProbabilityId { get; set; }
        public int? InspectionQuestionSeverityId { get; set; }
        public int? InspectionQuestionRatingId { get; set; }
        public int? InspectionQuestionRacparentId { get; set; }
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

        public virtual LtbInspectionQuestionProbability InspectionQuestionProbability { get; set; }
        public virtual LtbInspectionQuestionRac InspectionQuestionRacparent { get; set; }
        public virtual LtbInspectionQuestionRating InspectionQuestionRating { get; set; }
        public virtual LtbInspectionQuestionSeverity InspectionQuestionSeverity { get; set; }
        public virtual ICollection<LtbInspectionQuestionRac> InverseInspectionQuestionRacparent { get; set; }
    }
}