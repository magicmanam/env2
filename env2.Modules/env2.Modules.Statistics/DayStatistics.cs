using System;
using System.Collections.Generic;

namespace env2.Modules.Statistics
{
    /// <summary>
    /// Represents the specified day statistics.
    /// </summary>
    public class DayStatistics
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DayStatistics"/> class for the current day.
        /// </summary>
        public DayStatistics() : this(DateTime.Now.Day) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="DayStatistics"/> class for specified day.
        /// </summary>
        /// <param name="day">Day associated with the statistics instance.</param>
        public DayStatistics(int day)
        {
            RequestsCount = 0;
            Day = day;
            UniqueIps = new List<string>();
            UniqueUsers = new List<string>();
        }

        /// <summary>
        /// Gets or sets requests count for the current day.
        /// </summary>
        public int RequestsCount { get; set; }

        /// <summary>
        /// Gets day associated with statictics instance.
        /// </summary>
        public int Day { get; private set; }

        /// <summary>
        /// Gets or sets the list of unique IPs for the current day statistics instance.
        /// </summary>
        public IList<string> UniqueIps { get; set; }

        /// <summary>
        /// Gets or sets the list of unique IPs for the current day statistics instance.
        /// </summary>
        public IList<string> UniqueUsers { get; set; }
    }
}
