using DellFanManagement.App.FanControllers;
using DellFanManagement.App.TemperatureReaders;
using System;
using System.Collections.Generic;

namespace DellFanManagement.App.ConsistencyModeHandlers
{
    /// <summary>
    /// Used when full fan control is possible to "lock" the fan speed when conditions are right.
    /// </summary>
    public class LegacyConsistencyModeHandler : ConsistencyModeHandler
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="core">Core object.</param>
        /// <param name="state">State object.</param>
        /// <param name="fanController">The fan controller currently in use.</param>
        public LegacyConsistencyModeHandler(Core core, State state, FanController fanController) : base(core, state, fanController)
        {
            // No action here.
        }

        /// <summary>
        /// Consistency mode logic; lock the fans if temperature and RPM thresholds are met.
        /// </summary>
        public override void RunConsistencyModeLogic()
        {
            if (_core.LowerTemperatureThreshold != null && _core.UpperTemperatureThreshold != null && _core.RpmThreshold != null)
            {
                bool thresholdsMet = true;
                ulong? rpmLowerThreshold = _core.RpmThreshold - 400;
                bool is_cpu_warm = false;
                bool is_cpu_cool = false;

                // Is the fan speed too low?
                if (_state.Fan1Rpm < rpmLowerThreshold || (_state.Fan2Present && _state.Fan2Rpm < rpmLowerThreshold))
                {
                    if (_state.Fan1Rpm == 0 && (!_state.Fan2Present || _state.Fan2Rpm == 0))
                    {
                        thresholdsMet = false;
                        _state.ConsistencyModeStatus = string.Format("风扇未启动，等待EC激活{0}风扇", _state.Fan2Present ? "全部": "");// Waiting for embedded controller to activate the fan{0}", _state.Fan2Present ? "s" : string.Empty);
                    }
                    else
                    {
                        _state.ConsistencyModeStatus = "等待EC提高风扇速度"; // "Waiting for embedded controller to raise the fan speed";
                    }

                    //thresholdsMet = false;

                    if (!_state.EcFanControlEnabled)
                    {
                        Log.Write(string.Format("EC fan control disabled, but fan speed is too low: [{0}] [{1}]", _state.Fan1Rpm, _state.Fan2Present ? _state.Fan2Rpm : "N/A"));
                    }
                }

                // Is the CPU or GPU too hot?
                if (thresholdsMet)
                {
                    foreach (TemperatureComponent component in _state.Temperatures.Keys)
                    {
                        foreach (KeyValuePair<string, int> temperature in _state.Temperatures[component])
                        {
                            if (temperature.Value > _core.UpperTemperatureThreshold) //(_state.EcFanControlEnabled ?: _core.LowerTemperatureThreshold : _core.UpperTemperatureThreshold))
                            {
                                _state.ConsistencyModeStatus = string.Format("等待{0}温度下降", component);// Waiting for {0} temperature to fall", component);
                                thresholdsMet = false;
                                is_cpu_cool = false;
                                is_cpu_warm = false;
                                break;
                            }
                            else
                            {
                                if (temperature.Value > _core.LowerTemperatureThreshold)
                                {
                                    is_cpu_cool = false;
                                }
                                else
                                {
                                    is_cpu_cool = true;
                                }
                            }
                        }

                        if (!thresholdsMet)
                        {
                            break;
                        }
                    }
                }

                if (thresholdsMet)
                {
                        if (!is_cpu_cool) is_cpu_warm = true;
                }

                 // Is the fan speed too high?
                if (thresholdsMet && (_state.Fan1Rpm > _core.RpmThreshold || (_state.Fan2Present && _state.Fan2Rpm > _core.RpmThreshold)))
                {
                    if (_state.Fan1Rpm < Core.RpmSanityCheck && (!_state.Fan2Present || _state.Fan2Rpm < Core.RpmSanityCheck))
                    {
                        _state.ConsistencyModeStatus = "风速过高, 等待EC减小风速";// "Waiting for embedded controller to reduce the fan speed";
                        //thresholdsMet = false;

                        if (!_state.EcFanControlEnabled)
                        {
                            Log.Write(string.Format("EC fan control disabled, but fan speed is too high: [{0}] [{1}]", _state.Fan1Rpm, _state.Fan2Present ? _state.Fan2Rpm : "N/A"));
                        }
                    }
                    else
                    {
                        Log.Write(string.Format("Recorded fan speed above sanity check level: [{0}] [{1}]", _state.Fan1Rpm, _state.Fan2Present ? _state.Fan2Rpm : "N/A"));
                    }

                    if (!is_cpu_cool && !is_cpu_warm) thresholdsMet = false;
                    if (!_state.EcFanControlEnabled) // cpu is warm / cool but fan speed is too high
                    {
                            //_fanController.DisableAutomaticFanControl();
                            if (is_cpu_warm)
                            {
                                _fanController.SetFanLevel(FanLevel.Medium, FanIndex.AllFans);
                                _state.ConsistencyModeStatus = "温度在设定范围内，但风扇速度超过设定限值，尝试保持中速";
                            }
                            else if (is_cpu_cool)
                            {
                                _fanController.SetFanLevel(FanLevel.Off, FanIndex.AllFans);
                                _state.ConsistencyModeStatus = "温度低于下限，但风扇速度超过设定限值，尝试关闭风扇";
                            }

                            Log.Write("Disabled EC fan control – consistency mode – thresholds met");
                    }
                }

                //if (is_cpu_cool) thresholdsMet = false;

                if (thresholdsMet)
                {
                    if (!is_cpu_cool)
                    {
                        if (_state.EcFanControlEnabled)
                        {
                            _state.EcFanControlEnabled = false;
                            _fanController.DisableAutomaticFanControl();
                            Log.Write("Disabled EC fan control – consistency mode – thresholds met");
                        }

                        if (!_state.ConsistencyModeStatus.StartsWith("风扇速度锁定"))//("Fan speed locked"))
                        {
                            _state.ConsistencyModeStatus = string.Format("风扇速度锁定 {0}", DateTime.Now); //"("Fan speed locked since {0}", DateTime.Now);
                        }

                        _core.TrayIconColor = TrayIconColor.Blue;
                    }
                    else
                    {
                        if (!_state.EcFanControlEnabled)
                        {
                            _state.EcFanControlEnabled = true;
                            _fanController.EnableAutomaticFanControl();
                            _state.ConsistencyModeStatus = "温度低于下限，等待减小风速";
                        }
                    }
                }
                else if (!_state.EcFanControlEnabled && !thresholdsMet && !is_cpu_cool)
                {
                    _state.EcFanControlEnabled = true;
                    _fanController.EnableAutomaticFanControl();
                    Log.Write(string.Format("Enabled EC fan control – consistency mode – {0}", _state.ConsistencyModeStatus));
                    _core.TrayIconColor = TrayIconColor.Red;
                }
                else
                {
                    if (_state.Fan1Rpm > 0 || (_state.Fan2Present && _state.Fan2Rpm > 0))
                        _core.TrayIconColor = TrayIconColor.Red;
                    else
                        _core.TrayIconColor = TrayIconColor.Gray;
                }
            }
        }
    }
}
