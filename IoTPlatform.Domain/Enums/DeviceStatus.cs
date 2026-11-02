namespace IoTPlatform.Domain.Enums
{
    /// <summary>
    /// This enum represents the status of a device asset. 
    /// I'm using an enum to clearly define which statuses a device 
    /// can have and to enforce valid transitions between them.
    /// </summary>
    public enum DeviceStatus
    {
        /// <summary>
        /// The device has been registered but is not yet active.
        /// This is the default status when a device is first created.
        /// </summary>
        Registered,

        /// <summary>
        /// The device is currently active and operational.
        /// </summary>
        Active,

        /// <summary>
        /// The device is under maintenance.
        /// </summary>
        Maintenance,

        /// <summary>
        /// The device has been retired and is no longer in use.
        /// Once a device is retired, it cannot transition to any 
        /// other status. 
        /// </summary>
        Retired
    }
}