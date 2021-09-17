﻿using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class CrtbA03mishapCategory
    {
        public int CrtbA03mishapCategoryId { get; set; }
        public int? MishapCategoryGroupId { get; set; }
        public int? PrimaryMaterielObjectId { get; set; }
        public int? MishapDutyStatusId { get; set; }
        public int? ObjectOwnershipId { get; set; }
        public int? NewMishapCategoryId { get; set; }
        public int? LocationTypeId { get; set; }
        public int? MaterielObjectId { get; set; }
        public int? L2materielObjectId { get; set; }
        public int? L3materielObjectId { get; set; }
        public int? L4materielObjectId { get; set; }
        public int? L5materielObjectId { get; set; }
        public int? PersonnelActivityId { get; set; }
        public string IsPrimaryMaterielCheck { get; set; }
        public string AssignmentRule { get; set; }
    }
}