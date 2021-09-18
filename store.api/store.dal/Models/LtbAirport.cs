﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace store.dal.Models
{
    public partial class LtbAirport
    {
        /// <summary>
        /// Primary key of the Airport table.
        /// </summary>
        public int AirportId { get; set; }
        /// <summary>
        /// The Country ID where the airport is located
        /// </summary>
        public int CountryId { get; set; }
        /// <summary>
        /// The city where the airport located
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// The Airport Name
        /// </summary>
        public string Airport { get; set; }
        /// <summary>
        ///  International Air Transport Association Code
        /// </summary>
        public string IataCode { get; set; }
        /// <summary>
        /// International Civil Aviation Organization Code
        /// </summary>
        public string IcaoCode { get; set; }
        /// <summary>
        /// The user who created the record
        /// </summary>
        public string CreatedByUser { get; set; }
        /// <summary>
        /// the dat time when the record was created
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// The application that created the record
        /// </summary>
        public string CreatedByApp { get; set; }
        /// <summary>
        /// the user who last modified the record
        /// </summary>
        public string LastModifiedByUser { get; set; }
        /// <summary>
        /// The date time when the record was last modifiied
        /// </summary>
        public DateTime LastModifiedDate { get; set; }
        /// <summary>
        /// The application that last modified the record
        /// </summary>
        public string LastModifiedByApp { get; set; }

        public virtual LtbCountry Country { get; set; }
    }
}