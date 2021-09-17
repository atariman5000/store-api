﻿using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbMishapCategoryGroupGeneralMaterielObjectAssociation
    {
        public int MishapCategoryGroupMaterielObjectAssociationId { get; set; }
        public int MishapCategoryGroupId { get; set; }
        public int MaterielObjectId { get; set; }
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

        public virtual LtbMaterielObject MaterielObject { get; set; }
        public virtual LtbMishapCategory MishapCategoryGroup { get; set; }
    }
}
