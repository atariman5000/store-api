﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace store.dal.Models
{
    /// <summary>
    /// This table provides the way Human factor codes are identified (Act, Latent Failure).
    /// </summary>
    public partial class LtbHumanFactorNature
    {
        public LtbHumanFactorNature()
        {
            InverseHumanFactorNatureParent = new HashSet<LtbHumanFactorNature>();
        }

        /// <summary>
        /// Unique generated number for the record used for row identity.
        /// </summary>
        public int HumanFactorNatureId { get; set; }
        /// <summary>
        /// A code value for the current record.
        /// </summary>
        public string HumanFactorNatureCode { get; set; }
        /// <summary>
        /// A brief representation or account of the current value represented by the associated record.
        /// </summary>
        public string ShortDescription { get; set; }
        /// <summary>
        /// A detailed representation of the current value represented by the associated record.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Record Parent ID with Foreign key to the Primary key of the table.
        /// </summary>
        public int? HumanFactorNatureParentId { get; set; }
        /// <summary>
        /// The definition of the code value according to Regulatory Guidance or Business.
        /// </summary>
        public string ValueDefinition { get; set; }
        /// <summary>
        /// The Business Rule, Regulatory or Other Army/DoD Guidance that states the code use requirement.  If available, include the publish and effective dates.
        /// </summary>
        public string Guidance { get; set; }
        /// <summary>
        /// The date the code value was established for use.  This date may or may not be the same as the start collecting date.
        /// </summary>
        public DateTime? EstablishDate { get; set; }
        /// <summary>
        /// Date the code value was available to be assigned to a record.  Records assigned the code value must have a Date greater than or equal to the Start Collecting Date. Will default to the current date upon entry unless otherwise specified.  The time for start collecting date should always be 0000.
        /// </summary>
        public DateTime StartCollecting { get; set; }
        /// <summary>
        /// Date the code was taken out of circulation for collection.  Incidents assigned the code value must have a Date Occurred less than or equal to the End Collecting Date.  The time for end collecting date should always be 2359.
        /// </summary>
        public DateTime? EndCollecting { get; set; }
        /// <summary>
        /// A flag to indicate whether the code is active and assigned to action records. If no records have the code assigned and it is no longer active,  then the current value should be N. Valid values: Y/N
        /// </summary>
        public string Used { get; set; }
        /// <summary>
        /// Numeric sorting order to control the way the codes/types are listed in drop downs within the application or module.
        /// </summary>
        public int? DisplayOrder { get; set; }
        /// <summary>
        /// The user who created the record.
        /// </summary>
        public string CreatedByUser { get; set; }
        /// <summary>
        /// The date the record was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// Application used to create the record.
        /// </summary>
        public string CreatedByApp { get; set; }
        /// <summary>
        /// The user to last update the record.
        /// </summary>
        public string LastModifiedByUser { get; set; }
        /// <summary>
        /// The date the record was last updated.
        /// </summary>
        public DateTime LastModifiedDate { get; set; }
        /// <summary>
        /// Application used to last update the record.
        /// </summary>
        public string LastModifiedByApp { get; set; }

        public virtual LtbHumanFactorNature HumanFactorNatureParent { get; set; }
        public virtual ICollection<LtbHumanFactorNature> InverseHumanFactorNatureParent { get; set; }
    }
}