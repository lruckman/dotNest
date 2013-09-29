using System;

namespace dotNest
{
    public class Device : BaseNestObject
    {
        internal Device(dynamic device)
        {
//            $timestamp	1379370476380	System.Int64
//        $version	-205550659	System.Int32
            AltHeatDelivery = device.alt_heat_delivery;
            AltHeatSource = device.alt_heat_source;
            AltHeatX2Delivery = device.alt_heat_x2_delivery;
            AltHeatX2Source = device.alt_heat_x2_source;
            AutoAwayEnable = device.auto_away_enable;
            AutoAwayReset = device.auto_away_reset;
            AutoDehumEnabled = device.auto_dehum_enabled;
            AutoDehumState = device.auto_dehum_state;
            AuxHeatDelivery = device.aux_heat_delivery;
            AuxHeatSource = device.aux_heat_source;
            AuxLockoutLeaf = device.aux_lockout_leaf;
            AvailableLocales = (device.available_locales ?? "").Split(',');
            AwayTemperatureHigh = device.away_temperature_high;
            AwayTemperatureHighEnabled = device.away_temperature_high_enabled;
            AwayTemperatureLow = device.away_temperature_low;
            AwayTemperatureLowEnabled = device.away_temperature_low_enabled;
            BackplateBslInfo = device.backplate_bsl_info;
            BackplateBslVersion = device.backplate_bsl_version;
            BackplateModel = device.backplate_model;
            BackplateMonoInfo = device.backplate_mono_info;
            BackplateMonoVersion = device.backplate_mono_version;
            BackplateSerialNumber = device.backplate_serial_number;
            BatteryLevel = device.battery_level;
            CapabilityLevel = device.capability_level;
            ClickSound = device.click_sound;
            CompressorLockoutLeaf = device.compressor_lockout_leaf;
            CoolingDelivery = device.cooling_delivery;
            CoolingSource = device.cooling_source;
            CoolingX2Delivery = device.cooling_x2_delivery;
            CoolingX2Source = device.cooling_x2_source;
            CountryCode = device.country_code;
            CreationTime = new DateTime(device.creation_time);
            CurrentHumidity = device.current_humidity;
            CurrentScheduleMode = device.current_schedule_mode;
            CurrentVersion = device.current_version;
            DehumidifierOperationSelected = device.dehumidifier_orientation_selected;
            DehumidifierState = device.dehumidifier_state;
            DehumidifierType = device.dehumidifier_type;
            DeviceLocale = device.device_locale;
            DualFuelBreakpoint = device.dual_fuel_breakpoint;
            DualFuelBreakpointOverride = device.dual_fuel_breakpoint_override;
            EmerHeatDelivery = device.emer_heat_delivery;
            EmerHeatEnable = device.emer_heat_enable;
            EmerHeatSource = device.emer_heat_source;
            EquipmentType = device.equipment_type;
            ErrorCode = device.error_code;
            FanControlState = device.fan_control_state;
            FanCoolingEnabled = device.fan_cooling_enabled;
            FanCoolingReadiness = device.fan_cooling_readiness;
            FanCoolingState = device.fan_cooling_state;
            FanDutyCycle = device.fan_duty_cycle;
            FanDutyEndTime = device.fan_duty_end_time;
            FanDutyStartTime = device.fan_duty_start_time;
            FanMode = device.fan_mode;
            FanTimerDuration = device.fan_timer_duration;
            FanTimerTimeout = device.fan_timer_timeout;
            FilterChangedDate = device.filter_changed_date;
            FilterChangedSetDate = device.filter_changed_set_date;
            FilterReminderEnabled = device.filter_reminder_enabled;
            FilterReminderLevel = device.filter_reminder_level;
            ForcedAir = device.forced_air;
            GearThresholdHigh = device.gear_threshold_high;
            GearThresholdLow = device.gear_threshold_low;
            HasAirFilter = device.has_air_filter;
            HasAltHeat = device.has_alt_heat;
            HasAuxHeat = device.has_aux_heat;
            HasDehumidifier = device.has_dehumidifier;
            HasDualFuel = device.has_dual_fuel;
            HasEmerHeat = device.has_emer_heat;
            HasFan = device.has_fan;
            HasHeatPump = device.has_heat_pump;
            HasHumidifier = device.has_humidifier;
            HasX2AltHeat = device.has_x2_alt_heat;
            HasX2Cool = device.has_x2_cool;
            HasX2Heat = device.has_x2_heat;
            HasX3Heat = device.has_x3_heat;
            HeatPumpAuxThreshold = device.heat_pump_aux_threshold;
            HeatPumpAuxThresholdEnabled = device.heat_pump_aux_threshold_enabled;
            HeatPumpCompThreshold = device.heat_pump_comp_threshold;
            HeatPumpCompThresholdEnabled = device.heat_pump_comp_threshold_enabled;
            HeatX2Delivery = device.heat_x2_delivery;
            HeatX2Source = device.heat_x2_source;
            HeatX3Delivery = device.heat_x3_delivery;
            HeatX3Source = device.heat_x3_source;
            HeaterDelivery = device.heater_delivery;
            HeaterSource = device.heater_source;
            HeatpumpReady = device.heatpump_ready;
            HeatpumpSavings = device.heatpump_savings;
            HeatpumpSetbackActive = device.heatpump_setback_active;
            HumidifierState = device.humidifier_state;
            HumidifierType = device.humidifier_type;
            HvacPins = (device.hvac_pins ?? "").Split(',');
            HvacWires = (device.hvac_wires ?? "").Split(',');
            Leaf = device.leaf;
            LeafAwayHigh = device.leaf_away_high;
            LeafAwayLow = device.leaf_away_low;
            LeafLearning = device.leaf_learning;
            LeafScheduleDelta = device.leaf_schedule_delta;
            LeafThresholdCool = device.leaf_threshold_cool;
            LeafThresholdHeat = device.leaf_threshold_heat;
            LearningDaysCompletedCool = device.learning_days_completed_cool;
            LearningDaysCompletedHeat = device.learning_days_completed_heat;
            LearningDaysCompletedRange = device.learning_days_completed_range;
            LearningMode = device.learning_mode;
            LearningState = device.learning_state;
            LearningTime = device.learning_time;
            LocalIp = device.local_ip;
            LoggingPriority = device.logging_priority;
            LowerSafetyTemp = device.lower_safety_temp;
            LowerSafetyTempEnabled = device.lower_safety_temp_enabled;
            MacAddress = device.mac_address;
            MaintBandLower = device.maint_band_lower;
            MaintBandUpper = device.maint_band_upper;
            ModelVersion = device.model_version;
            NlclientState = device.nlclient_state;
            ObOrientation = device.ob_orientation;
            ObPersistence = device.ob_persistence;
            PinCDescription = device.pin_c_description;
            PinGDescription = device.pin_g_description;
            PinObDescription = device.pin_ob_description;
            PinRcDescription = device.pin_rc_description;
            PinRhDescription = device.pin_rh_description;
            PinStarDescription = device.pin_star_description;
            PinW1Description = device.pin_w1_description;
            PinW2AuxDescription = device.pin_w2aux_description;
            PinY1Description = device.pin_y1_description;
            PinY2Description = device.pin_y2_description;
            PostalCode = device.postal_code;
            PreconditioningActive = device.preconditioning_active;
            PreconditioningEnabled = device.preconditioning_enabled;
            PreconditioningReady = device.preconditioning_ready;
            RadiantControlEnabled = device.radiant_control_enabled;
            RangeEnable = device.range_enable;
            Rssi = device.rssi;
            ScheduleLearningReset = device.schedule_learning_reset;
            SerialNumber = device.serial_number;
            StarType = device.star_type;
            SunlightCorrectionActive = device.sunlight_correction_active;
            SunlightCorrectionEnabled = device.sunlight_correction_enabled;
            SunlightCorrectionReady = device.sunlight_correction_ready;
            SwitchSystemOff = device.switch_system_off;
            TargetHumidity = device.target_humidity;
            TargetHumidityEnabled = device.target_humidity_enabled;
            TargetTimeConfidence = device.target_time_confidence;
            TemperatureLock = device.temperature_lock;
            TemperatureLockHighTemp = device.temperature_lock_high_temp;
            TemperatureLockLowTemp = device.temperature_lock_low_temp;
            TemperatureLockPinHash = device.temperature_lock_pin_hash;
            TemperatureScale = device.temperature_scale;
            TimeToTarget = device.time_to_target;
            TimeToTargetTraining = device.time_to_target_training;
            Type = device.type;
            UpperSafetyTemp = device.upper_safety_temp;
            UpperSafetyTempEnabled = device.upper_safety_temp_enabled;
            UserBrightness = device.user_brightness;
            Y2Type = device.y2_type;
        }

        public string AltHeatDelivery { get; private set; }
        public string AltHeatSource { get; private set; }
        public string AltHeatX2Delivery { get; private set; }
        public string AltHeatX2Source { get; private set; }
        public bool AutoAwayEnable { get; private set; }
        public bool AutoAwayReset { get; private set; }
        public bool AutoDehumEnabled { get; private set; }
        public bool AutoDehumState { get; private set; }
        public string AuxHeatDelivery { get; private set; }
        public string AuxHeatSource { get; private set; }
        public decimal AuxLockoutLeaf { get; private set; }
        public string[] AvailableLocales { get; private set; }
        public decimal AwayTemperatureHigh { get; private set; }
        public bool AwayTemperatureHighEnabled { get; private set; }
        public decimal AwayTemperatureLow { get; private set; }
        public bool AwayTemperatureLowEnabled { get; private set; }
        public string BackplateBslInfo { get; private set; }
        public string BackplateBslVersion { get; private set; }
        public string BackplateModel { get; private set; }
        public string BackplateMonoInfo { get; private set; }
        public string BackplateMonoVersion { get; private set; }
        public string BackplateSerialNumber { get; private set; }
        public decimal BatteryLevel { get; private set; }
        public decimal CapabilityLevel { get; private set; }
        public string ClickSound { get; private set; }
        public decimal CompressorLockoutLeaf { get; private set; }
        public string CoolingDelivery { get; private set; }
        public string CoolingSource { get; private set; }
        public string CoolingX2Delivery { get; private set; }
        public string CoolingX2Source { get; private set; }
        public string CountryCode { get; private set; }
        public DateTime CreationTime { get; private set; }
        public int CurrentHumidity { get; private set; }
        public string CurrentScheduleMode { get; private set; }
        public string CurrentVersion { get; private set; }
        public string DehumidifierOperationSelected { get; private set; }
        public bool DehumidifierState { get; private set; }
        public string DehumidifierType { get; private set; }
        public string DeviceLocale { get; private set; }
        public decimal DualFuelBreakpoint { get; private set; }
        public string DualFuelBreakpointOverride { get; private set; }
        public string EmerHeatDelivery { get; private set; }
        public bool EmerHeatEnable { get; private set; }
        public string EmerHeatSource { get; private set; }
        public string EquipmentType { get; private set; }
        public string ErrorCode { get; private set; }
        public bool FanControlState { get; private set; }
        public bool FanCoolingEnabled { get; private set; }
        public string FanCoolingReadiness { get; private set; }
        public bool FanCoolingState { get; private set; }
        public int FanDutyCycle { get; private set; }
        public int FanDutyEndTime { get; private set; }
        public int FanDutyStartTime { get; private set; }
        public string FanMode { get; private set; }
        public int FanTimerDuration { get; private set; }
        public int FanTimerTimeout { get; private set; }
        public int FilterChangedDate { get; private set; }
        public int FilterChangedSetDate { get; private set; }
        public bool FilterReminderEnabled { get; private set; }
        public int FilterReminderLevel { get; private set; }
        public bool ForcedAir { get; private set; }
        public decimal GearThresholdHigh { get; private set; }
        public decimal GearThresholdLow { get; private set; }
        public bool HasAirFilter { get; private set; }
        public bool HasAltHeat { get; private set; }
        public bool HasAuxHeat { get; private set; }
        public bool HasDehumidifier { get; private set; }
        public bool HasDualFuel { get; private set; }
        public bool HasEmerHeat { get; private set; }
        public bool HasFan { get; private set; }
        public bool HasHeatPump { get; private set; }
        public bool HasHumidifier { get; private set; }
        public bool HasX2AltHeat { get; private set; }
        public bool HasX2Cool { get; private set; }
        public bool HasX2Heat { get; private set; }
        public bool HasX3Heat { get; private set; }
        public decimal HeatPumpAuxThreshold { get; private set; }
        public bool HeatPumpAuxThresholdEnabled { get; private set; }
        public decimal HeatPumpCompThreshold { get; private set; }
        public bool HeatPumpCompThresholdEnabled { get; private set; }
        public string HeatX2Delivery { get; private set; }
        public string HeatX2Source { get; private set; }
        public string HeatX3Delivery { get; private set; }
        public string HeatX3Source { get; private set; }
        public string HeaterDelivery { get; private set; }
        public string HeaterSource { get; private set; }
        public bool HeatpumpReady { get; private set; }
        public string HeatpumpSavings { get; private set; }
        public bool HeatpumpSetbackActive { get; private set; }
        public bool HumidifierState { get; private set; }
        public string HumidifierType { get; private set; }
        public string[] HvacPins { get; private set; }
        public string[] HvacWires { get; private set; }
        public bool Leaf { get; private set; }
        public decimal LeafAwayHigh { get; private set; }
        public decimal LeafAwayLow { get; private set; }
        public string LeafLearning { get; private set; }
        public decimal LeafScheduleDelta { get; private set; }
        public decimal LeafThresholdCool { get; private set; }
        public decimal LeafThresholdHeat { get; private set; }
        public int LearningDaysCompletedCool { get; private set; }
        public int LearningDaysCompletedHeat { get; private set; }
        public int LearningDaysCompletedRange { get; private set; }
        public bool LearningMode { get; private set; }
        public string LearningState { get; private set; }
        public int LearningTime { get; private set; }
        public string LocalIp { get; private set; }
        public string LoggingPriority { get; private set; }
        public decimal LowerSafetyTemp { get; private set; }
        public bool LowerSafetyTempEnabled { get; private set; }
        public string MacAddress { get; private set; }
        public decimal MaintBandLower { get; private set; }
        public decimal MaintBandUpper { get; private set; }
        public string ModelVersion { get; private set; }
        public string NlclientState { get; private set; }

        //note_codes

        public string ObOrientation { get; private set; }
        public bool ObPersistence { get; private set; }
        public string PinCDescription { get; private set; }
        public string PinGDescription { get; private set; }
        public string PinObDescription { get; private set; }
        public string PinRcDescription { get; private set; }
        public string PinRhDescription { get; private set; }
        public string PinStarDescription { get; private set; }
        public string PinW1Description { get; private set; }
        public string PinW2AuxDescription { get; private set; }
        public string PinY1Description { get; private set; }
        public string PinY2Description { get; private set; }
        public string PostalCode { get; private set; }
        public bool PreconditioningActive { get; private set; }
        public bool PreconditioningEnabled { get; private set; }
        public bool PreconditioningReady { get; private set; }
        public bool RadiantControlEnabled { get; private set; }
        public bool RangeEnable { get; private set; }
        public decimal Rssi { get; private set; }
        public bool ScheduleLearningReset { get; private set; }
        public string SerialNumber { get; private set; }
        public string StarType { get; private set; }
        public bool SunlightCorrectionActive { get; private set; }
        public bool SunlightCorrectionEnabled { get; private set; }
        public bool SunlightCorrectionReady { get; private set; }
        public bool SwitchSystemOff { get; private set; }
        public decimal TargetHumidity { get; private set; }
        public bool TargetHumidityEnabled { get; private set; }
        public decimal TargetTimeConfidence { get; private set; }
        public bool TemperatureLock { get; private set; }
        public decimal TemperatureLockHighTemp { get; private set; }
        public decimal TemperatureLockLowTemp { get; private set; }
        public string TemperatureLockPinHash { get; private set; }
        public string TemperatureScale { get; private set; }
        public int TimeToTarget { get; private set; }
        public string TimeToTargetTraining { get; private set; }

        // touched_by
        public string Type { get; private set; }
        public decimal UpperSafetyTemp { get; private set; }
        public bool UpperSafetyTempEnabled { get; private set; }
        public string UserBrightness { get; private set; }
        public string Y2Type { get; private set; }
    }
}