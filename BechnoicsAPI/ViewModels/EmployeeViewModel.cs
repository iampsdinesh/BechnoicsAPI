namespace BechnoicsAPI.ViewModels
{
    /// <summary>
    /// Employee View Model for Get
    /// </summary>
    public class EmployeeViewModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the bench period in days.
        /// </summary>
        /// <value>
        /// The bench period in days.
        /// </value>
        public int BenchPeriodInDays { get; set; }

        /// <summary>
        /// Gets or sets the skillset.
        /// </summary>
        /// <value>
        /// The skillset.
        /// </value>
        public string Skillset { get; set; }
    }
}