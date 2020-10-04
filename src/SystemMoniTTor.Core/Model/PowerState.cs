namespace SystemMoniTTor.Core.Model
{
    /// <summary>
    /// The power state of the machine.
    /// </summary>
    /// <seealso cref="SystemMoniTTor.Core.Model.BaseModel" />
    public class PowerState : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PowerState"/> class.
        /// </summary>
        /// <param name="isPoweredOn">if set to <c>true</c> [is powered on].</param>
        public PowerState(bool isPoweredOn)
        {
            IsPoweredOn = isPoweredOn;
        }

        /// <summary>
        /// Gets a value indicating whether this instance is powered on.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is powered on; otherwise, <c>false</c>.
        /// </value>
        public bool IsPoweredOn { get; }
    }
}
