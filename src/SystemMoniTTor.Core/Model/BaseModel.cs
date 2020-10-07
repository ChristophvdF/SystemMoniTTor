using System;

namespace SystemMoniTTor.Core.Model
{
    public abstract class BaseModel
    {
        public BaseModel()
        {
            TimeStamp = DateTime.Now;
        }

        /// <summary>
        /// Gets or sets the time stamp.
        /// </summary>
        /// <value>
        /// The time stamp.
        /// </value>
        public DateTime TimeStamp { get; set; }
    }
}
