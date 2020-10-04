namespace SystemMoniTTor.Core.Model
{
    public class MemoryMetrics
    {
        /// <summary>
        /// Gets or sets the total memory in MB.
        /// </summary>
        /// <value>
        /// The total.
        /// </value>
        public double Total { get; set; }

        /// <summary>
        /// Gets or sets the free memory in MB.
        /// </summary>
        /// <value>
        /// The free.
        /// </value>
        public double Free { get; set; }

        /// <summary>
        /// Gets the currently used memory in MB.
        /// </summary>
        /// <value>
        /// The used.
        /// </value>
        public double Used
        {
            get
            {
                return Total - Free;
            }
        }
    }
}
