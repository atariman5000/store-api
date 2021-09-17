using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class LtbFlightDataType
    {
        public LtbFlightDataType()
        {
            InverseFlightDataTypeParent = new HashSet<LtbFlightDataType>();
            LtbMishapCategoryGroupPhaseOfOperationAssociation = new HashSet<LtbMishapCategoryGroupPhaseOfOperationAssociation>();
        }

        public int FlightDataTypeId { get; set; }
        public string FlightDataTypeCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? FlightDataTypeParentId { get; set; }
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

        public virtual LtbFlightDataType FlightDataTypeParent { get; set; }
        public virtual ICollection<LtbFlightDataType> InverseFlightDataTypeParent { get; set; }
        public virtual ICollection<LtbMishapCategoryGroupPhaseOfOperationAssociation> LtbMishapCategoryGroupPhaseOfOperationAssociation { get; set; }
    }
}
