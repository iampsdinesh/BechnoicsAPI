﻿using System;

namespace BechnoicsAPI.Models
{
    /// <summary>
    /// Employee Class
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the name of the family.
        /// </summary>
        /// <value>
        /// The name of the family.
        /// </value>
        public string FamilyName { get; set; }

        /// <summary>
        /// Gets or sets the start date at bench.
        /// </summary>
        /// <value>
        /// The start date at bench.
        /// </value>
        public DateTime StartDateAtBench { get; set; }

        /// <summary>
        /// Gets or sets the end date at bench.
        /// </summary>
        /// <value>
        /// The end date at bench.
        /// </value>
        public DateTime? EndDateAtBench { get; set; }

        /// <summary>
        /// Gets or sets the skillset.
        /// </summary>
        /// <value>
        /// The skillset.
        /// </value>
        public string Skillset { get; set; }
    }
}