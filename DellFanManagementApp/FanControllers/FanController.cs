﻿namespace DellFanManagement.App.FanControllers
{
    /// <summary>
    /// Interface for fan speed controller implementations.
    /// </summary>
    abstract class FanController
    {
        /// <summary>
        /// Whether or not the system fans may be individually controlled.
        /// </summary>
        public bool IsIndividualFanControlSupported { get; protected set; }

        /// <summary>
        /// Disable automatic fan control.
        /// </summary>
        /// <returns>True on success, false on failure.</returns>
        public abstract bool DisableAutomaticFanControl();

        /// <summary>
        /// Enable automatic fan control.
        /// </summary>
        /// <returns>True on success, false on failure.</returns>
        public abstract bool EnableAutomaticFanControl();

        /// <summary>
        /// Set the fan speed.
        /// </summary>
        /// <param name="level">Speed level to set.</param>
        /// <param name="fanIndex">Which fan to set.</param>
        /// <returns>True on succes, false on failure.</returns>
        public abstract bool SetFanLevel(FanLevel level, FanIndex fanIndex);
    }
}