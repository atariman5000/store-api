﻿using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbOshaappealStatus
    {
        public LtbOshaappealStatus()
        {
            InverseOshaappealStatusParent = new HashSet<LtbOshaappealStatus>();
        }

        public int OshaappealStatusId { get; set; }
        public string OshaappealStatusCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? OshaappealStatusParentId { get; set; }
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

        public virtual LtbOshaappealStatus OshaappealStatusParent { get; set; }
        public virtual ICollection<LtbOshaappealStatus> InverseOshaappealStatusParent { get; set; }
    }
}