using System;
using System.Collections.Generic;

namespace HomeAssistantGenerated
{
	public interface IEntities
	{
		AutomationEntities Automation { get; }

		BinarySensorEntities BinarySensor { get; }

		CameraEntities Camera { get; }

		ClimateEntities Climate { get; }

		CoverEntities Cover { get; }

		DeviceTrackerEntities DeviceTracker { get; }

		GroupEntities Group { get; }

		LightEntities Light { get; }

		LockEntities Lock { get; }

		MediaPlayerEntities MediaPlayer { get; }

		PersonEntities Person { get; }

		SceneEntities Scene { get; }

		SensorEntities Sensor { get; }

		SunEntities Sun { get; }

		SwitchEntities Switch { get; }

		WeatherEntities Weather { get; }

		ZoneEntities Zone { get; }
	}

	public class Entities : IEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public Entities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AutomationEntities Automation => new(_haContext);
		public BinarySensorEntities BinarySensor => new(_haContext);
		public CameraEntities Camera => new(_haContext);
		public ClimateEntities Climate => new(_haContext);
		public CoverEntities Cover => new(_haContext);
		public DeviceTrackerEntities DeviceTracker => new(_haContext);
		public GroupEntities Group => new(_haContext);
		public LightEntities Light => new(_haContext);
		public LockEntities Lock => new(_haContext);
		public MediaPlayerEntities MediaPlayer => new(_haContext);
		public PersonEntities Person => new(_haContext);
		public SceneEntities Scene => new(_haContext);
		public SensorEntities Sensor => new(_haContext);
		public SunEntities Sun => new(_haContext);
		public SwitchEntities Switch => new(_haContext);
		public WeatherEntities Weather => new(_haContext);
		public ZoneEntities Zone => new(_haContext);
	}

	public class AutomationEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public AutomationEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Alert when FTP folder stops updating</summary>
		public AutomationEntity AlertWhenFtpFolderStopsUpdating => new(_haContext, "automation.alert_when_ftp_folder_stops_updating");
		///<summary>Fetch today's tide data</summary>
		public AutomationEntity FetchTodaySTideData => new(_haContext, "automation.fetch_today_s_tide_data");
		///<summary>Lights on at sunset</summary>
		public AutomationEntity LightsOnAtSunset => new(_haContext, "automation.lights_on_at_sunset");
		///<summary>Low battery check</summary>
		public AutomationEntity LowBatteryCheck => new(_haContext, "automation.low_battery_check");
		///<summary>Notify on stale backups</summary>
		public AutomationEntity NotifyOnStaleBackups => new(_haContext, "automation.notify_on_stale_backups");
		///<summary>Turn off lights at midnight</summary>
		public AutomationEntity TurnOffLightsAtMidnight => new(_haContext, "automation.turn_off_lights_at_midnight");
	}

	public class BinarySensorEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public BinarySensorEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Backups Stale</summary>
		public BinarySensorEntity BackupsStale => new(_haContext, "binary_sensor.backups_stale");
		///<summary>Front Door contact</summary>
		public BinarySensorEntity FrontDoorContact => new(_haContext, "binary_sensor.front_door_contact");
		///<summary>Front door motion</summary>
		public BinarySensorEntity FrontDoorMotion => new(_haContext, "binary_sensor.front_door_motion");
		///<summary>Front Door tamper</summary>
		public BinarySensorEntity FrontDoorTamper => new(_haContext, "binary_sensor.front_door_tamper");
		///<summary>garage motion motion</summary>
		public BinarySensorEntity GarageMotionMotion => new(_haContext, "binary_sensor.garage_motion_motion");
		///<summary>Hive Hub Status</summary>
		public BinarySensorEntity HiveHubStatus => new(_haContext, "binary_sensor.hive_hub_status");
		///<summary>Kitchen Door contact</summary>
		public BinarySensorEntity KitchenDoorContact => new(_haContext, "binary_sensor.kitchen_door_contact");
		///<summary>Kitchen Door tamper</summary>
		public BinarySensorEntity KitchenDoorTamper => new(_haContext, "binary_sensor.kitchen_door_tamper");
		///<summary>Remote UI</summary>
		public BinarySensorEntity RemoteUi => new(_haContext, "binary_sensor.remote_ui");
		///<summary>RPi Power status</summary>
		public BinarySensorEntity RpiPowerStatus => new(_haContext, "binary_sensor.rpi_power_status");
		///<summary>Scott's XR Focus</summary>
		public BinarySensorEntity ScottSXrFocus => new(_haContext, "binary_sensor.scott_s_xr_focus");
		///<summary>Sun Room Door contact</summary>
		public BinarySensorEntity SunRoomDoorContact => new(_haContext, "binary_sensor.sun_room_door_contact");
		///<summary>Sun Room Door tamper</summary>
		public BinarySensorEntity SunRoomDoorTamper => new(_haContext, "binary_sensor.sun_room_door_tamper");
		///<summary>Updater</summary>
		public BinarySensorEntity Updater => new(_haContext, "binary_sensor.updater");
	}

	public class CameraEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CameraEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Front door</summary>
		public CameraEntity FrontDoor => new(_haContext, "camera.front_door");
	}

	public class ClimateEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ClimateEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Thermostat 1</summary>
		public ClimateEntity Thermostat1 => new(_haContext, "climate.thermostat_1");
	}

	public class CoverEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CoverEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Scott office blind</summary>
		public CoverEntity ScottOffice => new(_haContext, "cover.scott_office");
	}

	public class DeviceTrackerEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public DeviceTrackerEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Jo's iPhone</summary>
		public DeviceTrackerEntity JoSIphone => new(_haContext, "device_tracker.jo_s_iphone");
		///<summary>Scott's XR</summary>
		public DeviceTrackerEntity ScottSXr => new(_haContext, "device_tracker.scott_s_xr");
		///<summary>Theo’s iPhone 6S</summary>
		public DeviceTrackerEntity TheosIphone6s => new(_haContext, "device_tracker.theos_iphone_6s");
	}

	public class GroupEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public GroupEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Family</summary>
		public GroupEntity Family => new(_haContext, "group.family");
	}

	public class LightEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public LightEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Jo's lamp</summary>
		public LightEntity JoSLamp => new(_haContext, "light.jo_s_lamp");
		///<summary>LR Wall back</summary>
		public LightEntity LrWallBack => new(_haContext, "light.lr_wall_back");
		///<summary>LR Wall front</summary>
		public LightEntity LrWallFront => new(_haContext, "light.lr_wall_front");
		///<summary>LR Window back</summary>
		public LightEntity LrWindowBack => new(_haContext, "light.lr_window_back");
		///<summary>LR Window front</summary>
		public LightEntity LrWindowFront => new(_haContext, "light.lr_window_front");
		///<summary>Parents</summary>
		public LightEntity Parents => new(_haContext, "light.parents");
		///<summary>Scott's lamp</summary>
		public LightEntity ScottSLamp => new(_haContext, "light.scott_s_lamp");
		///<summary>Theo</summary>
		public LightEntity Theo => new(_haContext, "light.theo");
		///<summary>Z-Wave Extender</summary>
		public LightEntity ZWaveExtender => new(_haContext, "light.z_wave_extender");
	}

	public class LockEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public LockEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Front Door Lock</summary>
		public LockEntity FrontDoorLock => new(_haContext, "lock.front_door_lock");
	}

	public class MediaPlayerEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public MediaPlayerEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>LG webOS TV BA72</summary>
		public MediaPlayerEntity LgWebosTvBa72 => new(_haContext, "media_player.lg_webos_tv_ba72");
	}

	public class PersonEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public PersonEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Jo</summary>
		public PersonEntity Jo => new(_haContext, "person.jo");
		///<summary>Scott</summary>
		public PersonEntity Scott => new(_haContext, "person.scott");
		///<summary>Theo</summary>
		public PersonEntity Theo => new(_haContext, "person.theo");
	}

	public class SceneEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SceneEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Goodbye!</summary>
		public SceneEntity Goodbye => new(_haContext, "scene.goodbye");
		///<summary>I'm Back!</summary>
		public SceneEntity IMBack => new(_haContext, "scene.i_m_back");
		///<summary>Living room - Bright</summary>
		public SceneEntity LivingRoomBright => new(_haContext, "scene.living_room_bright");
		///<summary>Living room - Dimmed</summary>
		public SceneEntity LivingRoomDimmed => new(_haContext, "scene.living_room_dimmed");
		///<summary>Living room - Nightlight</summary>
		public SceneEntity LivingRoomNightlight => new(_haContext, "scene.living_room_nightlight");
		///<summary>Living room - Relax</summary>
		public SceneEntity LivingRoomRelax => new(_haContext, "scene.living_room_relax");
		///<summary>Parents room - Bright</summary>
		public SceneEntity ParentsRoomBright => new(_haContext, "scene.parents_room_bright");
		///<summary>Parents room - Dimmed</summary>
		public SceneEntity ParentsRoomDimmed => new(_haContext, "scene.parents_room_dimmed");
		///<summary>Parents room - Nightlight</summary>
		public SceneEntity ParentsRoomNightlight => new(_haContext, "scene.parents_room_nightlight");
		///<summary>Theo’s room - Arctic aurora</summary>
		public SceneEntity TheosRoomArcticAurora => new(_haContext, "scene.theos_room_arctic_aurora");
		///<summary>Theo’s room - Bright</summary>
		public SceneEntity TheosRoomBright => new(_haContext, "scene.theos_room_bright");
		///<summary>Theo’s room - Concentrate</summary>
		public SceneEntity TheosRoomConcentrate => new(_haContext, "scene.theos_room_concentrate");
		///<summary>Theo’s room - Dimmed</summary>
		public SceneEntity TheosRoomDimmed => new(_haContext, "scene.theos_room_dimmed");
		///<summary>Theo’s room - Energize</summary>
		public SceneEntity TheosRoomEnergize => new(_haContext, "scene.theos_room_energize");
		///<summary>Theo’s room - Nightlight</summary>
		public SceneEntity TheosRoomNightlight => new(_haContext, "scene.theos_room_nightlight");
		///<summary>Theo’s room - Read</summary>
		public SceneEntity TheosRoomRead => new(_haContext, "scene.theos_room_read");
		///<summary>Theo’s room - Relax</summary>
		public SceneEntity TheosRoomRelax => new(_haContext, "scene.theos_room_relax");
		///<summary>Theo’s room - Savanna sunset</summary>
		public SceneEntity TheosRoomSavannaSunset => new(_haContext, "scene.theos_room_savanna_sunset");
		///<summary>Theo’s room - Spring blossom</summary>
		public SceneEntity TheosRoomSpringBlossom => new(_haContext, "scene.theos_room_spring_blossom");
		///<summary>Theo’s room - Tropical twilight</summary>
		public SceneEntity TheosRoomTropicalTwilight => new(_haContext, "scene.theos_room_tropical_twilight");
	}

	public class SensorEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SensorEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Backup State</summary>
		public SensorEntity BackupState => new(_haContext, "sensor.backup_state");
		///<summary>home_occupancy</summary>
		public SensorEntity HomeOccupancy => new(_haContext, "sensor.home_occupancy");
		///<summary>HP ENVY 4520 series</summary>
		public SensorEntity HpEnvy4520Series => new(_haContext, "sensor.hp_envy_4520_series");
		///<summary>Jo's iPhone Activity</summary>
		public SensorEntity JoSIphoneActivity => new(_haContext, "sensor.jo_s_iphone_activity");
		///<summary>Jo's iPhone Battery State</summary>
		public SensorEntity JoSIphoneBatteryState => new(_haContext, "sensor.jo_s_iphone_battery_state");
		///<summary>Jo's iPhone BSSID</summary>
		public SensorEntity JoSIphoneBssid => new(_haContext, "sensor.jo_s_iphone_bssid");
		///<summary>Jo's iPhone Connection Type</summary>
		public SensorEntity JoSIphoneConnectionType => new(_haContext, "sensor.jo_s_iphone_connection_type");
		///<summary>Jo's iPhone Geocoded Location</summary>
		public SensorEntity JoSIphoneGeocodedLocation => new(_haContext, "sensor.jo_s_iphone_geocoded_location");
		///<summary>Jo's iPhone Last Update Trigger</summary>
		public SensorEntity JoSIphoneLastUpdateTrigger => new(_haContext, "sensor.jo_s_iphone_last_update_trigger");
		///<summary>Jo's iPhone SIM 1</summary>
		public SensorEntity JoSIphoneSim1 => new(_haContext, "sensor.jo_s_iphone_sim_1");
		///<summary>Jo's iPhone SIM 2</summary>
		public SensorEntity JoSIphoneSim2 => new(_haContext, "sensor.jo_s_iphone_sim_2");
		///<summary>Jo's iPhone SSID</summary>
		public SensorEntity JoSIphoneSsid => new(_haContext, "sensor.jo_s_iphone_ssid");
		///<summary>LeithTides</summary>
		public SensorEntity Leithtides => new(_haContext, "sensor.leithtides");
		///<summary>netdaemon_status</summary>
		public SensorEntity NetdaemonStatus => new(_haContext, "sensor.netdaemon_status");
		///<summary>Scott's XR Activity</summary>
		public SensorEntity ScottSXrActivity => new(_haContext, "sensor.scott_s_xr_activity");
		///<summary>Scott's XR Battery State</summary>
		public SensorEntity ScottSXrBatteryState => new(_haContext, "sensor.scott_s_xr_battery_state");
		///<summary>Scott's XR BSSID</summary>
		public SensorEntity ScottSXrBssid => new(_haContext, "sensor.scott_s_xr_bssid");
		///<summary>Scott's XR Connection Type</summary>
		public SensorEntity ScottSXrConnectionType => new(_haContext, "sensor.scott_s_xr_connection_type");
		///<summary>Scott's XR Geocoded Location</summary>
		public SensorEntity ScottSXrGeocodedLocation => new(_haContext, "sensor.scott_s_xr_geocoded_location");
		///<summary>Scott's XR Last Update Trigger</summary>
		public SensorEntity ScottSXrLastUpdateTrigger => new(_haContext, "sensor.scott_s_xr_last_update_trigger");
		///<summary>Scott's XR SIM 1</summary>
		public SensorEntity ScottSXrSim1 => new(_haContext, "sensor.scott_s_xr_sim_1");
		///<summary>Scott's XR SIM 2</summary>
		public SensorEntity ScottSXrSim2 => new(_haContext, "sensor.scott_s_xr_sim_2");
		///<summary>Scott's XR SSID</summary>
		public SensorEntity ScottSXrSsid => new(_haContext, "sensor.scott_s_xr_ssid");
		///<summary>Theo’s iPhone 6S Activity</summary>
		public SensorEntity TheosIphone6sActivity => new(_haContext, "sensor.theos_iphone_6s_activity");
		///<summary>Theo’s iPhone 6S Battery State</summary>
		public SensorEntity TheosIphone6sBatteryState => new(_haContext, "sensor.theos_iphone_6s_battery_state");
		///<summary>Theo’s iPhone 6S BSSID</summary>
		public SensorEntity TheosIphone6sBssid => new(_haContext, "sensor.theos_iphone_6s_bssid");
		///<summary>Theo’s iPhone 6S Connection Type</summary>
		public SensorEntity TheosIphone6sConnectionType => new(_haContext, "sensor.theos_iphone_6s_connection_type");
		///<summary>Theo’s iPhone 6S Geocoded Location</summary>
		public SensorEntity TheosIphone6sGeocodedLocation => new(_haContext, "sensor.theos_iphone_6s_geocoded_location");
		///<summary>Theo’s iPhone 6S Last Update Trigger</summary>
		public SensorEntity TheosIphone6sLastUpdateTrigger => new(_haContext, "sensor.theos_iphone_6s_last_update_trigger");
		///<summary>Theo’s iPhone 6S SIM 1</summary>
		public SensorEntity TheosIphone6sSim1 => new(_haContext, "sensor.theos_iphone_6s_sim_1");
		///<summary>Theo’s iPhone 6S SSID</summary>
		public SensorEntity TheosIphone6sSsid => new(_haContext, "sensor.theos_iphone_6s_ssid");
		///<summary>Camera FTP</summary>
		public NumericSensorEntity CameraFtp => new(_haContext, "sensor.camera_ftp");
		///<summary>CPU Temperature</summary>
		public NumericSensorEntity CpuTemperature => new(_haContext, "sensor.cpu_temperature");
		///<summary>Front Door Battery</summary>
		public NumericSensorEntity FrontDoorBattery => new(_haContext, "sensor.front_door_battery");
		///<summary>Front Door Lock Battery</summary>
		public NumericSensorEntity FrontDoorLockBattery => new(_haContext, "sensor.front_door_lock_battery");
		///<summary>garage motion Battery</summary>
		public NumericSensorEntity GarageMotionBattery => new(_haContext, "sensor.garage_motion_battery");
		///<summary>garage motion Temperature Measurement</summary>
		public NumericSensorEntity GarageMotionTemperatureMeasurement => new(_haContext, "sensor.garage_motion_temperature_measurement");
		///<summary>hacs</summary>
		public NumericSensorEntity Hacs => new(_haContext, "sensor.hacs");
		///<summary>HP ENVY 4520 series black ink</summary>
		public NumericSensorEntity HpEnvy4520SeriesBlackInk => new(_haContext, "sensor.hp_envy_4520_series_black_ink");
		///<summary>HP ENVY 4520 series tri-color ink</summary>
		public NumericSensorEntity HpEnvy4520SeriesTriColorInk => new(_haContext, "sensor.hp_envy_4520_series_tri_color_ink");
		///<summary>Jo's iPhone Average Active Pace</summary>
		public NumericSensorEntity JoSIphoneAverageActivePace => new(_haContext, "sensor.jo_s_iphone_average_active_pace");
		///<summary>Jo's iPhone Battery Level</summary>
		public NumericSensorEntity JoSIphoneBatteryLevel => new(_haContext, "sensor.jo_s_iphone_battery_level");
		///<summary>Jo's iPhone Distance</summary>
		public NumericSensorEntity JoSIphoneDistance => new(_haContext, "sensor.jo_s_iphone_distance");
		///<summary>Jo's iPhone Floors Ascended</summary>
		public NumericSensorEntity JoSIphoneFloorsAscended => new(_haContext, "sensor.jo_s_iphone_floors_ascended");
		///<summary>Jo's iPhone Floors Descended</summary>
		public NumericSensorEntity JoSIphoneFloorsDescended => new(_haContext, "sensor.jo_s_iphone_floors_descended");
		///<summary>Jo's iPhone Steps</summary>
		public NumericSensorEntity JoSIphoneSteps => new(_haContext, "sensor.jo_s_iphone_steps");
		///<summary>Jo's iPhone Storage</summary>
		public NumericSensorEntity JoSIphoneStorage => new(_haContext, "sensor.jo_s_iphone_storage");
		///<summary>Kitchen Door Battery</summary>
		public NumericSensorEntity KitchenDoorBattery => new(_haContext, "sensor.kitchen_door_battery");
		///<summary>Memory free</summary>
		public NumericSensorEntity MemoryFree => new(_haContext, "sensor.memory_free");
		///<summary>Parents switch Battery</summary>
		public NumericSensorEntity ParentsSwitchBatteryLevel => new(_haContext, "sensor.parents_switch_battery_level");
		///<summary>Processor temperature</summary>
		public NumericSensorEntity ProcessorTemperature => new(_haContext, "sensor.processor_temperature");
		///<summary>Processor use</summary>
		public NumericSensorEntity ProcessorUse => new(_haContext, "sensor.processor_use");
		///<summary>scott office battery level</summary>
		public NumericSensorEntity ScottOfficeBatteryLevel => new(_haContext, "sensor.scott_office_battery_level");
		///<summary>Scott's XR Average Active Pace</summary>
		public NumericSensorEntity ScottSXrAverageActivePace => new(_haContext, "sensor.scott_s_xr_average_active_pace");
		///<summary>Scott's XR Battery Level</summary>
		public NumericSensorEntity ScottSXrBatteryLevel => new(_haContext, "sensor.scott_s_xr_battery_level");
		///<summary>Scott's XR Distance</summary>
		public NumericSensorEntity ScottSXrDistance => new(_haContext, "sensor.scott_s_xr_distance");
		///<summary>Scott's XR Floors Ascended</summary>
		public NumericSensorEntity ScottSXrFloorsAscended => new(_haContext, "sensor.scott_s_xr_floors_ascended");
		///<summary>Scott's XR Floors Descended</summary>
		public NumericSensorEntity ScottSXrFloorsDescended => new(_haContext, "sensor.scott_s_xr_floors_descended");
		///<summary>Scott's XR Steps</summary>
		public NumericSensorEntity ScottSXrSteps => new(_haContext, "sensor.scott_s_xr_steps");
		///<summary>Scott's XR Storage</summary>
		public NumericSensorEntity ScottSXrStorage => new(_haContext, "sensor.scott_s_xr_storage");
		///<summary>Sun Room Door Battery</summary>
		public NumericSensorEntity SunRoomDoorBattery => new(_haContext, "sensor.sun_room_door_battery");
		///<summary>Theo dimmer switch Battery</summary>
		public NumericSensorEntity TheoDimmerSwitchBatteryLevel => new(_haContext, "sensor.theo_dimmer_switch_battery_level");
		///<summary>Theo’s iPhone 6S Average Active Pace</summary>
		public NumericSensorEntity TheosIphone6sAverageActivePace => new(_haContext, "sensor.theos_iphone_6s_average_active_pace");
		///<summary>Theo’s iPhone 6S Battery Level</summary>
		public NumericSensorEntity TheosIphone6sBatteryLevel => new(_haContext, "sensor.theos_iphone_6s_battery_level");
		///<summary>Theo’s iPhone 6S Distance</summary>
		public NumericSensorEntity TheosIphone6sDistance => new(_haContext, "sensor.theos_iphone_6s_distance");
		///<summary>Theo’s iPhone 6S Floors Ascended</summary>
		public NumericSensorEntity TheosIphone6sFloorsAscended => new(_haContext, "sensor.theos_iphone_6s_floors_ascended");
		///<summary>Theo’s iPhone 6S Floors Descended</summary>
		public NumericSensorEntity TheosIphone6sFloorsDescended => new(_haContext, "sensor.theos_iphone_6s_floors_descended");
		///<summary>Theo’s iPhone 6S Steps</summary>
		public NumericSensorEntity TheosIphone6sSteps => new(_haContext, "sensor.theos_iphone_6s_steps");
		///<summary>Theo’s iPhone 6S Storage</summary>
		public NumericSensorEntity TheosIphone6sStorage => new(_haContext, "sensor.theos_iphone_6s_storage");
		///<summary>Thermostat 1 Battery Level</summary>
		public NumericSensorEntity Thermostat1BatteryLevel => new(_haContext, "sensor.thermostat_1_battery_level");
	}

	public class SunEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SunEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sun</summary>
		public SunEntity Sun => new(_haContext, "sun.sun");
	}

	public class SwitchEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SwitchEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Front door email</summary>
		public SwitchEntity FrontDoorEmail => new(_haContext, "switch.front_door_email");
		///<summary>Front door FTP</summary>
		public SwitchEntity FrontDoorFtp => new(_haContext, "switch.front_door_ftp");
		///<summary>Front door IR lights</summary>
		public SwitchEntity FrontDoorIrLights => new(_haContext, "switch.front_door_ir_lights");
		///<summary>Front door record audio</summary>
		public SwitchEntity FrontDoorRecordAudio => new(_haContext, "switch.front_door_record_audio");
		///<summary>Front door recording</summary>
		public SwitchEntity FrontDoorRecording => new(_haContext, "switch.front_door_recording");
		///<summary>netdaemon_devmodeapp</summary>
		public SwitchEntity NetdaemonDevmodeapp => new(_haContext, "switch.netdaemon_devmodeapp");
		///<summary>netdaemon_frontdoorlocker</summary>
		public SwitchEntity NetdaemonFrontdoorlocker => new(_haContext, "switch.netdaemon_frontdoorlocker");
		///<summary>netdaemon_hello_world_app</summary>
		public SwitchEntity NetdaemonHelloWorldApp => new(_haContext, "switch.netdaemon_hello_world_app");
		///<summary>netdaemon_helloappcontext</summary>
		public SwitchEntity NetdaemonHelloappcontext => new(_haContext, "switch.netdaemon_helloappcontext");
		///<summary>netdaemon_helloworldapp</summary>
		public SwitchEntity NetdaemonHelloworldapp => new(_haContext, "switch.netdaemon_helloworldapp");
		///<summary>netdaemon_lightonmovement</summary>
		public SwitchEntity NetdaemonLightonmovement => new(_haContext, "switch.netdaemon_lightonmovement");
		///<summary>netdaemon_livingroomlightsscheduler</summary>
		public SwitchEntity NetdaemonLivingroomlightsscheduler => new(_haContext, "switch.netdaemon_livingroomlightsscheduler");
		///<summary>netdaemon_livingroomlightsservice</summary>
		public SwitchEntity NetdaemonLivingroomlightsservice => new(_haContext, "switch.netdaemon_livingroomlightsservice");
		///<summary>netdaemon_personhomeupdater</summary>
		public SwitchEntity NetdaemonPersonhomeupdater => new(_haContext, "switch.netdaemon_personhomeupdater");
		///<summary>netdaemon_schedulingapp</summary>
		public SwitchEntity NetdaemonSchedulingapp => new(_haContext, "switch.netdaemon_schedulingapp");
		///<summary>netdaemon_tidesfetcher</summary>
		public SwitchEntity NetdaemonTidesfetcher => new(_haContext, "switch.netdaemon_tidesfetcher");
		///<summary>netdaemon_tidesfetcherservice</summary>
		public SwitchEntity NetdaemonTidesfetcherservice => new(_haContext, "switch.netdaemon_tidesfetcherservice");
		///<summary>netdaemon_yaml_config_app</summary>
		public SwitchEntity NetdaemonYamlConfigApp => new(_haContext, "switch.netdaemon_yaml_config_app");
		///<summary>On air lamp</summary>
		public SwitchEntity OnAirLampSocket1 => new(_haContext, "switch.on_air_lamp_socket_1");
		///<summary>Studio light</summary>
		public SwitchEntity StudioLightSocket1 => new(_haContext, "switch.studio_light_socket_1");
		///<summary>Thermostat 1 Heat on Demand</summary>
		public SwitchEntity Thermostat1HeatOnDemand => new(_haContext, "switch.thermostat_1_heat_on_demand");
	}

	public class WeatherEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public WeatherEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Home</summary>
		public WeatherEntity Home => new(_haContext, "weather.home");
	}

	public class ZoneEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ZoneEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Home</summary>
		public ZoneEntity Home => new(_haContext, "zone.home");
	}

	public record AutomationEntity : NetDaemon.HassModel.Entities.Entity<AutomationEntity, NetDaemon.HassModel.Entities.EntityState<AutomationAttributes>, AutomationAttributes>
	{
		public AutomationEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public AutomationEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record BinarySensorEntity : NetDaemon.HassModel.Entities.Entity<BinarySensorEntity, NetDaemon.HassModel.Entities.EntityState<BinarySensorAttributes>, BinarySensorAttributes>
	{
		public BinarySensorEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public BinarySensorEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record CameraEntity : NetDaemon.HassModel.Entities.Entity<CameraEntity, NetDaemon.HassModel.Entities.EntityState<CameraAttributes>, CameraAttributes>
	{
		public CameraEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CameraEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record ClimateEntity : NetDaemon.HassModel.Entities.Entity<ClimateEntity, NetDaemon.HassModel.Entities.EntityState<ClimateAttributes>, ClimateAttributes>
	{
		public ClimateEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ClimateEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record CoverEntity : NetDaemon.HassModel.Entities.Entity<CoverEntity, NetDaemon.HassModel.Entities.EntityState<CoverAttributes>, CoverAttributes>
	{
		public CoverEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CoverEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record DeviceTrackerEntity : NetDaemon.HassModel.Entities.Entity<DeviceTrackerEntity, NetDaemon.HassModel.Entities.EntityState<DeviceTrackerAttributes>, DeviceTrackerAttributes>
	{
		public DeviceTrackerEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public DeviceTrackerEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record GroupEntity : NetDaemon.HassModel.Entities.Entity<GroupEntity, NetDaemon.HassModel.Entities.EntityState<GroupAttributes>, GroupAttributes>
	{
		public GroupEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public GroupEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record LightEntity : NetDaemon.HassModel.Entities.Entity<LightEntity, NetDaemon.HassModel.Entities.EntityState<LightAttributes>, LightAttributes>
	{
		public LightEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LightEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record LockEntity : NetDaemon.HassModel.Entities.Entity<LockEntity, NetDaemon.HassModel.Entities.EntityState<LockAttributes>, LockAttributes>
	{
		public LockEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LockEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record MediaPlayerEntity : NetDaemon.HassModel.Entities.Entity<MediaPlayerEntity, NetDaemon.HassModel.Entities.EntityState<MediaPlayerAttributes>, MediaPlayerAttributes>
	{
		public MediaPlayerEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public MediaPlayerEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record PersonEntity : NetDaemon.HassModel.Entities.Entity<PersonEntity, NetDaemon.HassModel.Entities.EntityState<PersonAttributes>, PersonAttributes>
	{
		public PersonEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersonEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record SceneEntity : NetDaemon.HassModel.Entities.Entity<SceneEntity, NetDaemon.HassModel.Entities.EntityState<SceneAttributes>, SceneAttributes>
	{
		public SceneEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SceneEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record SensorEntity : NetDaemon.HassModel.Entities.Entity<SensorEntity, NetDaemon.HassModel.Entities.EntityState<SensorAttributes>, SensorAttributes>
	{
		public SensorEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SensorEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record NumericSensorEntity : NetDaemon.HassModel.Entities.NumericEntity<NumericSensorEntity, NetDaemon.HassModel.Entities.NumericEntityState<NumericSensorAttributes>, NumericSensorAttributes>
	{
		public NumericSensorEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumericSensorEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record SunEntity : NetDaemon.HassModel.Entities.Entity<SunEntity, NetDaemon.HassModel.Entities.EntityState<SunAttributes>, SunAttributes>
	{
		public SunEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SunEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record SwitchEntity : NetDaemon.HassModel.Entities.Entity<SwitchEntity, NetDaemon.HassModel.Entities.EntityState<SwitchAttributes>, SwitchAttributes>
	{
		public SwitchEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SwitchEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record WeatherEntity : NetDaemon.HassModel.Entities.Entity<WeatherEntity, NetDaemon.HassModel.Entities.EntityState<WeatherAttributes>, WeatherAttributes>
	{
		public WeatherEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public WeatherEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record ZoneEntity : NetDaemon.HassModel.Entities.Entity<ZoneEntity, NetDaemon.HassModel.Entities.EntityState<ZoneAttributes>, ZoneAttributes>
	{
		public ZoneEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ZoneEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record AutomationAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("current")]
		public double? Current { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
		public string? Id { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("last_triggered")]
		public string? LastTriggered { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
		public string? Mode { get; init; }
	}

	public record BinarySensorAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("bus_event_id")]
		public string? BusEventId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("device_class")]
		public string? DeviceClass { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
		public object? Mode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("newest_version")]
		public string? NewestVersion { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("release_notes")]
		public string? ReleaseNotes { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
		public bool? Restored { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record CameraAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("access_token")]
		public string? AccessToken { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("backlight_state")]
		public string? BacklightState { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("daynight_state")]
		public string? DaynightState { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("entity_picture")]
		public string? EntityPicture { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("frontend_stream_type")]
		public string? FrontendStreamType { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("sensitivity")]
		public object? Sensitivity { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record ClimateAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("current_temperature")]
		public double? CurrentTemperature { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("hvac_action")]
		public string? HvacAction { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("hvac_modes")]
		public object? HvacModes { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("max_temp")]
		public double? MaxTemp { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("min_temp")]
		public double? MinTemp { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("preset_mode")]
		public string? PresetMode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("preset_modes")]
		public object? PresetModes { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("temperature")]
		public double? Temperature { get; init; }
	}

	public record CoverAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("current_position")]
		public double? CurrentPosition { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record DeviceTrackerAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("altitude")]
		public double? Altitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("battery_level")]
		public double? BatteryLevel { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("latitude")]
		public double? Latitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("longitude")]
		public double? Longitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("source_type")]
		public string? SourceType { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("vertical_accuracy")]
		public double? VerticalAccuracy { get; init; }
	}

	public record GroupAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("entity_id")]
		public object? EntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("order")]
		public double? Order { get; init; }
	}

	public record LightAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("dynamics")]
		public string? Dynamics { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("max_mireds")]
		public double? MaxMireds { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("min_mireds")]
		public double? MinMireds { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
		public string? Mode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_color_modes")]
		public object? SupportedColorModes { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record LockAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("lock_state")]
		public string? LockState { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("method")]
		public string? Method { get; init; }
	}

	public record MediaPlayerAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("device_class")]
		public string? DeviceClass { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("source_list")]
		public object? SourceList { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record PersonAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
		public bool? Editable { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("entity_picture")]
		public string? EntityPicture { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
		public string? Id { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("latitude")]
		public double? Latitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("longitude")]
		public double? Longitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("source")]
		public string? Source { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("user_id")]
		public string? UserId { get; init; }
	}

	public record SceneAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("brightness")]
		public double? Brightness { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("color")]
		public object? Color { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("group_name")]
		public string? GroupName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("group_type")]
		public string? GroupType { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("is_dynamic")]
		public bool? IsDynamic { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("location_id")]
		public string? LocationId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
		public string? Name { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("speed")]
		public double? Speed { get; init; }
	}

	public record SensorAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Administrative Area")]
		public string? AdministrativeArea { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Allows VoIP")]
		public bool? AllowsVoIP { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Areas Of Interest")]
		public string? AreasOfInterest { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("backups")]
		public object? Backups { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("backups_in_google_drive")]
		public double? BackupsInGoogleDrive { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("backups_in_home_assistant")]
		public double? BackupsInHomeAssistant { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Carrier ID")]
		public string? CarrierID { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Carrier Name")]
		public string? CarrierName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Cellular Technology")]
		public string? CellularTechnology { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("command_set")]
		public string? CommandSet { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Confidence")]
		public string? Confidence { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Country")]
		public string? Country { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Current Radio Technology")]
		public string? CurrentRadioTechnology { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("info")]
		public string? Info { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Inland Water")]
		public string? InlandWater { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("integration")]
		public string? Integration { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("ISO Country Code")]
		public string? ISOCountryCode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("last_backup")]
		public string? LastBackup { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("last_uploaded")]
		public string? LastUploaded { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Locality")]
		public string? Locality { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("location")]
		public string? Location_0 { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Location")]
		public object? Location_1 { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Low Power Mode")]
		public bool? LowPowerMode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Mobile Country Code")]
		public string? MobileCountryCode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Mobile Network Code")]
		public string? MobileNetworkCode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Name")]
		public string? Name { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("number_of_loaded_apps")]
		public double? NumberOfLoadedApps { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("number_of_running_apps")]
		public double? NumberOfRunningApps { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Ocean")]
		public string? Ocean { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Postal Code")]
		public string? PostalCode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
		public bool? Restored { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("serial")]
		public string? Serial { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("size_in_google_drive")]
		public string? SizeInGoogleDrive { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("size_in_home_assistant")]
		public string? SizeInHomeAssistant { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("state_message")]
		public string? StateMessage { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("state_reason")]
		public object? StateReason { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Sub Administrative Area")]
		public string? SubAdministrativeArea { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Sub Locality")]
		public string? SubLocality { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Sub Thoroughfare")]
		public string? SubThoroughfare { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Thoroughfare")]
		public string? Thoroughfare { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Time Zone")]
		public string? TimeZone { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Types")]
		public object? Types { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("uri_supported")]
		public object? UriSupported { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
		public string? Version { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Zones")]
		public object? Zones { get; init; }
	}

	public record NumericSensorAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Available")]
		public string? Available { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Available (Important)")]
		public string? AvailableImportant { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Available (Opportunistic)")]
		public string? AvailableOpportunistic { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("battery_state")]
		public string? BatteryState { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("device_class")]
		public string? DeviceClass { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("marker_high_level")]
		public double? MarkerHighLevel { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("marker_low_level")]
		public double? MarkerLowLevel { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("marker_type")]
		public string? MarkerType { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("repositories")]
		public object? Repositories { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
		public bool? Restored { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("state_class")]
		public string? StateClass { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Total")]
		public string? Total { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }
	}

	public record SunAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("azimuth")]
		public double? Azimuth { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("elevation")]
		public double? Elevation { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_dawn")]
		public string? NextDawn { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_dusk")]
		public string? NextDusk { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_midnight")]
		public string? NextMidnight { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_noon")]
		public string? NextNoon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_rising")]
		public string? NextRising { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_setting")]
		public string? NextSetting { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("rising")]
		public bool? Rising { get; init; }
	}

	public record SwitchAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("device_class")]
		public string? DeviceClass { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("integration")]
		public string? Integration { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
		public object? Mode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("runtime_info")]
		public object? RuntimeInfo { get; init; }
	}

	public record WeatherAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("attribution")]
		public string? Attribution { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("forecast")]
		public object? Forecast { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("humidity")]
		public double? Humidity { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("pressure")]
		public double? Pressure { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("temperature")]
		public double? Temperature { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("wind_bearing")]
		public double? WindBearing { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("wind_speed")]
		public double? WindSpeed { get; init; }
	}

	public record ZoneAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
		public bool? Editable { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("latitude")]
		public double? Latitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("longitude")]
		public double? Longitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("passive")]
		public bool? Passive { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("radius")]
		public double? Radius { get; init; }
	}

	public interface IServices
	{
		AutomationServices Automation { get; }

		ButtonServices Button { get; }

		CameraServices Camera { get; }

		ClimateServices Climate { get; }

		CloudServices Cloud { get; }

		CommandLineServices CommandLine { get; }

		CounterServices Counter { get; }

		CoverServices Cover { get; }

		DeviceTrackerServices DeviceTracker { get; }

		FanServices Fan { get; }

		FfmpegServices Ffmpeg { get; }

		FrontendServices Frontend { get; }

		GroupServices Group { get; }

		HassioServices Hassio { get; }

		HiveServices Hive { get; }

		HomeassistantServices Homeassistant { get; }

		HueServices Hue { get; }

		HumidifierServices Humidifier { get; }

		InputBooleanServices InputBoolean { get; }

		InputDatetimeServices InputDatetime { get; }

		InputNumberServices InputNumber { get; }

		InputSelectServices InputSelect { get; }

		InputTextServices InputText { get; }

		LightServices Light { get; }

		LockServices Lock { get; }

		LogbookServices Logbook { get; }

		LoggerServices Logger { get; }

		MediaPlayerServices MediaPlayer { get; }

		MqttServices Mqtt { get; }

		NetdaemonServices Netdaemon { get; }

		NotifyServices Notify { get; }

		NumberServices Number { get; }

		PersistentNotificationServices PersistentNotification { get; }

		PersonServices Person { get; }

		RecorderServices Recorder { get; }

		ReolinkDevServices ReolinkDev { get; }

		SceneServices Scene { get; }

		ScriptServices Script { get; }

		SelectServices Select { get; }

		SirenServices Siren { get; }

		SwitchServices Switch { get; }

		SystemLogServices SystemLog { get; }

		TimerServices Timer { get; }

		TtsServices Tts { get; }

		VacuumServices Vacuum { get; }

		ZoneServices Zone { get; }
	}

	public class Services : IServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public Services(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AutomationServices Automation => new(_haContext);
		public ButtonServices Button => new(_haContext);
		public CameraServices Camera => new(_haContext);
		public ClimateServices Climate => new(_haContext);
		public CloudServices Cloud => new(_haContext);
		public CommandLineServices CommandLine => new(_haContext);
		public CounterServices Counter => new(_haContext);
		public CoverServices Cover => new(_haContext);
		public DeviceTrackerServices DeviceTracker => new(_haContext);
		public FanServices Fan => new(_haContext);
		public FfmpegServices Ffmpeg => new(_haContext);
		public FrontendServices Frontend => new(_haContext);
		public GroupServices Group => new(_haContext);
		public HassioServices Hassio => new(_haContext);
		public HiveServices Hive => new(_haContext);
		public HomeassistantServices Homeassistant => new(_haContext);
		public HueServices Hue => new(_haContext);
		public HumidifierServices Humidifier => new(_haContext);
		public InputBooleanServices InputBoolean => new(_haContext);
		public InputDatetimeServices InputDatetime => new(_haContext);
		public InputNumberServices InputNumber => new(_haContext);
		public InputSelectServices InputSelect => new(_haContext);
		public InputTextServices InputText => new(_haContext);
		public LightServices Light => new(_haContext);
		public LockServices Lock => new(_haContext);
		public LogbookServices Logbook => new(_haContext);
		public LoggerServices Logger => new(_haContext);
		public MediaPlayerServices MediaPlayer => new(_haContext);
		public MqttServices Mqtt => new(_haContext);
		public NetdaemonServices Netdaemon => new(_haContext);
		public NotifyServices Notify => new(_haContext);
		public NumberServices Number => new(_haContext);
		public PersistentNotificationServices PersistentNotification => new(_haContext);
		public PersonServices Person => new(_haContext);
		public RecorderServices Recorder => new(_haContext);
		public ReolinkDevServices ReolinkDev => new(_haContext);
		public SceneServices Scene => new(_haContext);
		public ScriptServices Script => new(_haContext);
		public SelectServices Select => new(_haContext);
		public SirenServices Siren => new(_haContext);
		public SwitchServices Switch => new(_haContext);
		public SystemLogServices SystemLog => new(_haContext);
		public TimerServices Timer => new(_haContext);
		public TtsServices Tts => new(_haContext);
		public VacuumServices Vacuum => new(_haContext);
		public ZoneServices Zone => new(_haContext);
	}

	public class AutomationServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public AutomationServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the automation configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("automation", "reload", null);
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("automation", "toggle", target);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Trigger(NetDaemon.HassModel.Entities.ServiceTarget target, AutomationTriggerParameters data)
		{
			_haContext.CallService("automation", "trigger", target, data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public void Trigger(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @skipCondition = null)
		{
			_haContext.CallService("automation", "trigger", target, new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target, AutomationTurnOffParameters data)
		{
			_haContext.CallService("automation", "turn_off", target, data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @stopActions = null)
		{
			_haContext.CallService("automation", "turn_off", target, new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("automation", "turn_on", target);
		}
	}

	public record AutomationTriggerParameters
	{
		///<summary>Whether or not the conditions will be skipped.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("skip_condition")]
		public bool? SkipCondition { get; init; }
	}

	public record AutomationTurnOffParameters
	{
		///<summary>Stop currently running actions.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("stop_actions")]
		public bool? StopActions { get; init; }
	}

	public class ButtonServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ButtonServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Press the button entity.</summary>
		///<param name="target">The target for this service call</param>
		public void Press(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("button", "press", target);
		}
	}

	public class CameraServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CameraServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Disable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void DisableMotionDetection(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("camera", "disable_motion_detection", target);
		}

		///<summary>Enable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void EnableMotionDetection(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("camera", "enable_motion_detection", target);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayStream(NetDaemon.HassModel.Entities.ServiceTarget target, CameraPlayStreamParameters data)
		{
			_haContext.CallService("camera", "play_stream", target, data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public void PlayStream(NetDaemon.HassModel.Entities.ServiceTarget target, string @mediaPlayer, string? @format = null)
		{
			_haContext.CallService("camera", "play_stream", target, new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		public void Record(NetDaemon.HassModel.Entities.ServiceTarget target, CameraRecordParameters data)
		{
			_haContext.CallService("camera", "record", target, data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public void Record(NetDaemon.HassModel.Entities.ServiceTarget target, string @filename, long? @duration = null, long? @lookback = null)
		{
			_haContext.CallService("camera", "record", target, new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void Snapshot(NetDaemon.HassModel.Entities.ServiceTarget target, CameraSnapshotParameters data)
		{
			_haContext.CallService("camera", "snapshot", target, data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public void Snapshot(NetDaemon.HassModel.Entities.ServiceTarget target, string @filename)
		{
			_haContext.CallService("camera", "snapshot", target, new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_off", target);
		}

		///<summary>Turn on camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_on", target);
		}
	}

	public record CameraPlayStreamParameters
	{
		///<summary>Name(s) of media player to stream to.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("media_player")]
		public string? MediaPlayer { get; init; }

		///<summary>Stream format supported by media player.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("format")]
		public string? Format { get; init; }
	}

	public record CameraRecordParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</summary>
		[System.Text.Json.Serialization.JsonPropertyName("filename")]
		public string? Filename { get; init; }

		///<summary>Target recording length.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("lookback")]
		public long? Lookback { get; init; }
	}

	public record CameraSnapshotParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</summary>
		[System.Text.Json.Serialization.JsonPropertyName("filename")]
		public string? Filename { get; init; }
	}

	public class ClimateServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ClimateServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetAuxHeat(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetAuxHeatParameters data)
		{
			_haContext.CallService("climate", "set_aux_heat", target, data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public void SetAuxHeat(NetDaemon.HassModel.Entities.ServiceTarget target, bool @auxHeat)
		{
			_haContext.CallService("climate", "set_aux_heat", target, new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetFanModeParameters data)
		{
			_haContext.CallService("climate", "set_fan_mode", target, data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public void SetFanMode(NetDaemon.HassModel.Entities.ServiceTarget target, string @fanMode)
		{
			_haContext.CallService("climate", "set_fan_mode", target, new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetHumidityParameters data)
		{
			_haContext.CallService("climate", "set_humidity", target, data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public void SetHumidity(NetDaemon.HassModel.Entities.ServiceTarget target, long @humidity)
		{
			_haContext.CallService("climate", "set_humidity", target, new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHvacMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetHvacModeParameters data)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public void SetHvacMode(NetDaemon.HassModel.Entities.ServiceTarget target, string? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetPresetModeParameters data)
		{
			_haContext.CallService("climate", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public void SetPresetMode(NetDaemon.HassModel.Entities.ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("climate", "set_preset_mode", target, new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSwingMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetSwingModeParameters data)
		{
			_haContext.CallService("climate", "set_swing_mode", target, data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public void SetSwingMode(NetDaemon.HassModel.Entities.ServiceTarget target, string @swingMode)
		{
			_haContext.CallService("climate", "set_swing_mode", target, new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetTemperature(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetTemperatureParameters data)
		{
			_haContext.CallService("climate", "set_temperature", target, data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public void SetTemperature(NetDaemon.HassModel.Entities.ServiceTarget target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, string? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_temperature", target, new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_off", target);
		}

		///<summary>Turn climate device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_on", target);
		}
	}

	public record ClimateSetAuxHeatParameters
	{
		///<summary>New value of auxiliary heater.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("aux_heat")]
		public bool? AuxHeat { get; init; }
	}

	public record ClimateSetFanModeParameters
	{
		///<summary>New value of fan mode. eg: low</summary>
		[System.Text.Json.Serialization.JsonPropertyName("fan_mode")]
		public string? FanMode { get; init; }
	}

	public record ClimateSetHumidityParameters
	{
		///<summary>New target humidity for climate device.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record ClimateSetHvacModeParameters
	{
		///<summary>New value of operation mode.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("hvac_mode")]
		public string? HvacMode { get; init; }
	}

	public record ClimateSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: away</summary>
		[System.Text.Json.Serialization.JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record ClimateSetSwingModeParameters
	{
		///<summary>New value of swing mode. eg: horizontal</summary>
		[System.Text.Json.Serialization.JsonPropertyName("swing_mode")]
		public string? SwingMode { get; init; }
	}

	public record ClimateSetTemperatureParameters
	{
		///<summary>New target temperature for HVAC.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		///<summary>New target high temperature for HVAC.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("target_temp_high")]
		public double? TargetTempHigh { get; init; }

		///<summary>New target low temperature for HVAC.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("target_temp_low")]
		public double? TargetTempLow { get; init; }

		///<summary>HVAC operation mode to set temperature to.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("hvac_mode")]
		public string? HvacMode { get; init; }
	}

	public class CloudServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CloudServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Make instance UI available outside over NabuCasa cloud</summary>
		public void RemoteConnect()
		{
			_haContext.CallService("cloud", "remote_connect", null);
		}

		///<summary>Disconnect UI from NabuCasa cloud</summary>
		public void RemoteDisconnect()
		{
			_haContext.CallService("cloud", "remote_disconnect", null);
		}
	}

	public class CommandLineServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CommandLineServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all command_line entities</summary>
		public void Reload()
		{
			_haContext.CallService("command_line", "reload", null);
		}
	}

	public class CounterServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CounterServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		public void Configure(NetDaemon.HassModel.Entities.ServiceTarget target, CounterConfigureParameters data)
		{
			_haContext.CallService("counter", "configure", target, data);
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
		///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
		///<param name="step">New value for step.</param>
		///<param name="initial">New value for initial.</param>
		///<param name="value">New state value.</param>
		public void Configure(NetDaemon.HassModel.Entities.ServiceTarget target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			_haContext.CallService("counter", "configure", target, new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Decrement a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("counter", "decrement", target);
		}

		///<summary>Increment a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("counter", "increment", target);
		}

		///<summary>Reset a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Reset(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("counter", "reset", target);
		}
	}

	public record CounterConfigureParameters
	{
		///<summary>New minimum value for the counter or None to remove minimum.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("minimum")]
		public long? Minimum { get; init; }

		///<summary>New maximum value for the counter or None to remove maximum.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("maximum")]
		public long? Maximum { get; init; }

		///<summary>New value for step.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("step")]
		public long? Step { get; init; }

		///<summary>New value for initial.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("initial")]
		public long? Initial { get; init; }

		///<summary>New state value.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("value")]
		public long? Value { get; init; }
	}

	public class CoverServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CoverServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Close all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCover(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover", target);
		}

		///<summary>Close all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCoverTilt(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover_tilt", target);
		}

		///<summary>Open all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCover(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover", target);
		}

		///<summary>Open all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCoverTilt(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover_tilt", target);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverPosition(NetDaemon.HassModel.Entities.ServiceTarget target, CoverSetCoverPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_position", target, data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="position">Position of the cover</param>
		public void SetCoverPosition(NetDaemon.HassModel.Entities.ServiceTarget target, long @position)
		{
			_haContext.CallService("cover", "set_cover_position", target, new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverTiltPosition(NetDaemon.HassModel.Entities.ServiceTarget target, CoverSetCoverTiltPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public void SetCoverTiltPosition(NetDaemon.HassModel.Entities.ServiceTarget target, long @tiltPosition)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCover(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover", target);
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCoverTilt(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover_tilt", target);
		}

		///<summary>Toggle a cover open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle", target);
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void ToggleCoverTilt(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle_cover_tilt", target);
		}
	}

	public record CoverSetCoverPositionParameters
	{
		///<summary>Position of the cover</summary>
		[System.Text.Json.Serialization.JsonPropertyName("position")]
		public long? Position { get; init; }
	}

	public record CoverSetCoverTiltPositionParameters
	{
		///<summary>Tilt position of the cover.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("tilt_position")]
		public long? TiltPosition { get; init; }
	}

	public class DeviceTrackerServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public DeviceTrackerServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Control tracked device.</summary>
		public void See(DeviceTrackerSeeParameters data)
		{
			_haContext.CallService("device_tracker", "see", null, data);
		}

		///<summary>Control tracked device.</summary>
		///<param name="mac">MAC address of device eg: FF:FF:FF:FF:FF:FF</param>
		///<param name="devId">Id of device (find id in known_devices.yaml). eg: phonedave</param>
		///<param name="hostName">Hostname of device eg: Dave</param>
		///<param name="locationName">Name of location where device is located (not_home is away). eg: home</param>
		///<param name="gps">GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</param>
		///<param name="gpsAccuracy">Accuracy of GPS coordinates.</param>
		///<param name="battery">Battery level of device.</param>
		public void See(string? @mac = null, string? @devId = null, string? @hostName = null, string? @locationName = null, object? @gps = null, long? @gpsAccuracy = null, long? @battery = null)
		{
			_haContext.CallService("device_tracker", "see", null, new DeviceTrackerSeeParameters{Mac = @mac, DevId = @devId, HostName = @hostName, LocationName = @locationName, Gps = @gps, GpsAccuracy = @gpsAccuracy, Battery = @battery});
		}
	}

	public record DeviceTrackerSeeParameters
	{
		///<summary>MAC address of device eg: FF:FF:FF:FF:FF:FF</summary>
		[System.Text.Json.Serialization.JsonPropertyName("mac")]
		public string? Mac { get; init; }

		///<summary>Id of device (find id in known_devices.yaml). eg: phonedave</summary>
		[System.Text.Json.Serialization.JsonPropertyName("dev_id")]
		public string? DevId { get; init; }

		///<summary>Hostname of device eg: Dave</summary>
		[System.Text.Json.Serialization.JsonPropertyName("host_name")]
		public string? HostName { get; init; }

		///<summary>Name of location where device is located (not_home is away). eg: home</summary>
		[System.Text.Json.Serialization.JsonPropertyName("location_name")]
		public string? LocationName { get; init; }

		///<summary>GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("gps")]
		public object? Gps { get; init; }

		///<summary>Accuracy of GPS coordinates.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("gps_accuracy")]
		public long? GpsAccuracy { get; init; }

		///<summary>Battery level of device.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("battery")]
		public long? Battery { get; init; }
	}

	public class FanServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public FanServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void DecreaseSpeed(NetDaemon.HassModel.Entities.ServiceTarget target, FanDecreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "decrease_speed", target, data);
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Decrease speed by a percentage.</param>
		public void DecreaseSpeed(NetDaemon.HassModel.Entities.ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "decrease_speed", target, new FanDecreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void IncreaseSpeed(NetDaemon.HassModel.Entities.ServiceTarget target, FanIncreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "increase_speed", target, data);
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Increase speed by a percentage.</param>
		public void IncreaseSpeed(NetDaemon.HassModel.Entities.ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "increase_speed", target, new FanIncreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		public void Oscillate(NetDaemon.HassModel.Entities.ServiceTarget target, FanOscillateParameters data)
		{
			_haContext.CallService("fan", "oscillate", target, data);
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="oscillating">Flag to turn on/off oscillation.</param>
		public void Oscillate(NetDaemon.HassModel.Entities.ServiceTarget target, bool @oscillating)
		{
			_haContext.CallService("fan", "oscillate", target, new FanOscillateParameters{Oscillating = @oscillating});
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDirection(NetDaemon.HassModel.Entities.ServiceTarget target, FanSetDirectionParameters data)
		{
			_haContext.CallService("fan", "set_direction", target, data);
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="direction">The direction to rotate.</param>
		public void SetDirection(NetDaemon.HassModel.Entities.ServiceTarget target, string @direction)
		{
			_haContext.CallService("fan", "set_direction", target, new FanSetDirectionParameters{Direction = @direction});
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPercentage(NetDaemon.HassModel.Entities.ServiceTarget target, FanSetPercentageParameters data)
		{
			_haContext.CallService("fan", "set_percentage", target, data);
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentage">Percentage speed setting.</param>
		public void SetPercentage(NetDaemon.HassModel.Entities.ServiceTarget target, long @percentage)
		{
			_haContext.CallService("fan", "set_percentage", target, new FanSetPercentageParameters{Percentage = @percentage});
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(NetDaemon.HassModel.Entities.ServiceTarget target, FanSetPresetModeParameters data)
		{
			_haContext.CallService("fan", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: auto</param>
		public void SetPresetMode(NetDaemon.HassModel.Entities.ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("fan", "set_preset_mode", target, new FanSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set fan speed.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSpeed(NetDaemon.HassModel.Entities.ServiceTarget target, FanSetSpeedParameters data)
		{
			_haContext.CallService("fan", "set_speed", target, data);
		}

		///<summary>Set fan speed.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="speed">Speed setting. eg: low</param>
		public void SetSpeed(NetDaemon.HassModel.Entities.ServiceTarget target, string @speed)
		{
			_haContext.CallService("fan", "set_speed", target, new FanSetSpeedParameters{Speed = @speed});
		}

		///<summary>Toggle the fan on/off.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("fan", "toggle", target);
		}

		///<summary>Turn fan off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("fan", "turn_off", target);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, FanTurnOnParameters data)
		{
			_haContext.CallService("fan", "turn_on", target, data);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="speed">Speed setting. eg: high</param>
		///<param name="percentage">Percentage speed setting.</param>
		///<param name="presetMode">Preset mode setting. eg: auto</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, string? @speed = null, long? @percentage = null, string? @presetMode = null)
		{
			_haContext.CallService("fan", "turn_on", target, new FanTurnOnParameters{Speed = @speed, Percentage = @percentage, PresetMode = @presetMode});
		}
	}

	public record FanDecreaseSpeedParameters
	{
		///<summary>Decrease speed by a percentage.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanIncreaseSpeedParameters
	{
		///<summary>Increase speed by a percentage.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanOscillateParameters
	{
		///<summary>Flag to turn on/off oscillation.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("oscillating")]
		public bool? Oscillating { get; init; }
	}

	public record FanSetDirectionParameters
	{
		///<summary>The direction to rotate.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("direction")]
		public string? Direction { get; init; }
	}

	public record FanSetPercentageParameters
	{
		///<summary>Percentage speed setting.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("percentage")]
		public long? Percentage { get; init; }
	}

	public record FanSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: auto</summary>
		[System.Text.Json.Serialization.JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record FanSetSpeedParameters
	{
		///<summary>Speed setting. eg: low</summary>
		[System.Text.Json.Serialization.JsonPropertyName("speed")]
		public string? Speed { get; init; }
	}

	public record FanTurnOnParameters
	{
		///<summary>Speed setting. eg: high</summary>
		[System.Text.Json.Serialization.JsonPropertyName("speed")]
		public string? Speed { get; init; }

		///<summary>Percentage speed setting.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("percentage")]
		public long? Percentage { get; init; }

		///<summary>Preset mode setting. eg: auto</summary>
		[System.Text.Json.Serialization.JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public class FfmpegServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public FfmpegServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send a restart command to a ffmpeg based sensor.</summary>
		public void Restart(FfmpegRestartParameters data)
		{
			_haContext.CallService("ffmpeg", "restart", null, data);
		}

		///<summary>Send a restart command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will restart. Platform dependent.</param>
		public void Restart(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "restart", null, new FfmpegRestartParameters{EntityId = @entityId});
		}

		///<summary>Send a start command to a ffmpeg based sensor.</summary>
		public void Start(FfmpegStartParameters data)
		{
			_haContext.CallService("ffmpeg", "start", null, data);
		}

		///<summary>Send a start command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will start. Platform dependent.</param>
		public void Start(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "start", null, new FfmpegStartParameters{EntityId = @entityId});
		}

		///<summary>Send a stop command to a ffmpeg based sensor.</summary>
		public void Stop(FfmpegStopParameters data)
		{
			_haContext.CallService("ffmpeg", "stop", null, data);
		}

		///<summary>Send a stop command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will stop. Platform dependent.</param>
		public void Stop(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "stop", null, new FfmpegStopParameters{EntityId = @entityId});
		}
	}

	public record FfmpegRestartParameters
	{
		///<summary>Name of entity that will restart. Platform dependent.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record FfmpegStartParameters
	{
		///<summary>Name of entity that will start. Platform dependent.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record FfmpegStopParameters
	{
		///<summary>Name of entity that will stop. Platform dependent.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public class FrontendServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public FrontendServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload themes from YAML configuration.</summary>
		public void ReloadThemes()
		{
			_haContext.CallService("frontend", "reload_themes", null);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		public void SetTheme(FrontendSetThemeParameters data)
		{
			_haContext.CallService("frontend", "set_theme", null, data);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		///<param name="name">Name of a predefined theme, 'default' or 'none'. eg: default</param>
		///<param name="mode">The mode the theme is for.</param>
		public void SetTheme(string @name, string? @mode = null)
		{
			_haContext.CallService("frontend", "set_theme", null, new FrontendSetThemeParameters{Name = @name, Mode = @mode});
		}
	}

	public record FrontendSetThemeParameters
	{
		///<summary>Name of a predefined theme, 'default' or 'none'. eg: default</summary>
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>The mode the theme is for.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public class GroupServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public GroupServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload group configuration, entities, and notify services.</summary>
		public void Reload()
		{
			_haContext.CallService("group", "reload", null);
		}

		///<summary>Remove a user group.</summary>
		public void Remove(GroupRemoveParameters data)
		{
			_haContext.CallService("group", "remove", null, data);
		}

		///<summary>Remove a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		public void Remove(object @objectId)
		{
			_haContext.CallService("group", "remove", null, new GroupRemoveParameters{ObjectId = @objectId});
		}

		///<summary>Create/Update a user group.</summary>
		public void Set(GroupSetParameters data)
		{
			_haContext.CallService("group", "set", null, data);
		}

		///<summary>Create/Update a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		///<param name="name">Name of group eg: My test group</param>
		///<param name="icon">Name of icon for the group. eg: mdi:camera</param>
		///<param name="entities">List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="addEntities">List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="all">Enable this option if the group should only turn on when all entities are on.</param>
		public void Set(string @objectId, string? @name = null, string? @icon = null, object? @entities = null, object? @addEntities = null, bool? @all = null)
		{
			_haContext.CallService("group", "set", null, new GroupSetParameters{ObjectId = @objectId, Name = @name, Icon = @icon, Entities = @entities, AddEntities = @addEntities, All = @all});
		}
	}

	public record GroupRemoveParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[System.Text.Json.Serialization.JsonPropertyName("object_id")]
		public object? ObjectId { get; init; }
	}

	public record GroupSetParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[System.Text.Json.Serialization.JsonPropertyName("object_id")]
		public string? ObjectId { get; init; }

		///<summary>Name of group eg: My test group</summary>
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Name of icon for the group. eg: mdi:camera</summary>
		[System.Text.Json.Serialization.JsonPropertyName("icon")]
		public string? Icon { get; init; }

		///<summary>List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</summary>
		[System.Text.Json.Serialization.JsonPropertyName("add_entities")]
		public object? AddEntities { get; init; }

		///<summary>Enable this option if the group should only turn on when all entities are on.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("all")]
		public bool? All { get; init; }
	}

	public class HassioServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public HassioServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Restart add-on.</summary>
		public void AddonRestart(HassioAddonRestartParameters data)
		{
			_haContext.CallService("hassio", "addon_restart", null, data);
		}

		///<summary>Restart add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonRestart(string @addon)
		{
			_haContext.CallService("hassio", "addon_restart", null, new HassioAddonRestartParameters{Addon = @addon});
		}

		///<summary>Start add-on.</summary>
		public void AddonStart(HassioAddonStartParameters data)
		{
			_haContext.CallService("hassio", "addon_start", null, data);
		}

		///<summary>Start add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStart(string @addon)
		{
			_haContext.CallService("hassio", "addon_start", null, new HassioAddonStartParameters{Addon = @addon});
		}

		///<summary>Write data to add-on stdin.</summary>
		public void AddonStdin(HassioAddonStdinParameters data)
		{
			_haContext.CallService("hassio", "addon_stdin", null, data);
		}

		///<summary>Write data to add-on stdin.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStdin(string @addon)
		{
			_haContext.CallService("hassio", "addon_stdin", null, new HassioAddonStdinParameters{Addon = @addon});
		}

		///<summary>Stop add-on.</summary>
		public void AddonStop(HassioAddonStopParameters data)
		{
			_haContext.CallService("hassio", "addon_stop", null, data);
		}

		///<summary>Stop add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStop(string @addon)
		{
			_haContext.CallService("hassio", "addon_stop", null, new HassioAddonStopParameters{Addon = @addon});
		}

		///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
		public void AddonUpdate(HassioAddonUpdateParameters data)
		{
			_haContext.CallService("hassio", "addon_update", null, data);
		}

		///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonUpdate(string @addon)
		{
			_haContext.CallService("hassio", "addon_update", null, new HassioAddonUpdateParameters{Addon = @addon});
		}

		///<summary>Create a full backup.</summary>
		public void BackupFull(HassioBackupFullParameters data)
		{
			_haContext.CallService("hassio", "backup_full", null, data);
		}

		///<summary>Create a full backup.</summary>
		///<param name="name">Optional (default = current date and time). eg: Backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		public void BackupFull(string? @name = null, string? @password = null)
		{
			_haContext.CallService("hassio", "backup_full", null, new HassioBackupFullParameters{Name = @name, Password = @password});
		}

		///<summary>Create a partial backup.</summary>
		public void BackupPartial(HassioBackupPartialParameters data)
		{
			_haContext.CallService("hassio", "backup_partial", null, data);
		}

		///<summary>Create a partial backup.</summary>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh", "core_samba", "core_mosquitto"]</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant", "share"]</param>
		///<param name="name">Optional (default = current date and time). eg: Partial backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		public void BackupPartial(object? @addons = null, object? @folders = null, string? @name = null, string? @password = null)
		{
			_haContext.CallService("hassio", "backup_partial", null, new HassioBackupPartialParameters{Addons = @addons, Folders = @folders, Name = @name, Password = @password});
		}

		///<summary>Reboot the host system.</summary>
		public void HostReboot()
		{
			_haContext.CallService("hassio", "host_reboot", null);
		}

		///<summary>Poweroff the host system.</summary>
		public void HostShutdown()
		{
			_haContext.CallService("hassio", "host_shutdown", null);
		}

		///<summary>Restore from full backup.</summary>
		public void RestoreFull(HassioRestoreFullParameters data)
		{
			_haContext.CallService("hassio", "restore_full", null, data);
		}

		///<summary>Restore from full backup.</summary>
		///<param name="slug">Slug of backup to restore from.</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestoreFull(string @slug, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_full", null, new HassioRestoreFullParameters{Slug = @slug, Password = @password});
		}

		///<summary>Restore from partial backup.</summary>
		public void RestorePartial(HassioRestorePartialParameters data)
		{
			_haContext.CallService("hassio", "restore_partial", null, data);
		}

		///<summary>Restore from partial backup.</summary>
		///<param name="slug">Slug of backup to restore from.</param>
		///<param name="homeassistant">Restore Home Assistant</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant", "share"]</param>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh", "core_samba", "core_mosquitto"]</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestorePartial(string @slug, bool? @homeassistant = null, object? @folders = null, object? @addons = null, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_partial", null, new HassioRestorePartialParameters{Slug = @slug, Homeassistant = @homeassistant, Folders = @folders, Addons = @addons, Password = @password});
		}
	}

	public record HassioAddonRestartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[System.Text.Json.Serialization.JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[System.Text.Json.Serialization.JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStdinParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[System.Text.Json.Serialization.JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStopParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[System.Text.Json.Serialization.JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonUpdateParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[System.Text.Json.Serialization.JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioBackupFullParameters
	{
		///<summary>Optional (default = current date and time). eg: Backup 1</summary>
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[System.Text.Json.Serialization.JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public record HassioBackupPartialParameters
	{
		///<summary>Optional list of add-on slugs. eg: ["core_ssh", "core_samba", "core_mosquitto"]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant", "share"]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional (default = current date and time). eg: Partial backup 1</summary>
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[System.Text.Json.Serialization.JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public record HassioRestoreFullParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Optional password. eg: password</summary>
		[System.Text.Json.Serialization.JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public record HassioRestorePartialParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Restore Home Assistant</summary>
		[System.Text.Json.Serialization.JsonPropertyName("homeassistant")]
		public bool? Homeassistant { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant", "share"]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional list of add-on slugs. eg: ["core_ssh", "core_samba", "core_mosquitto"]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional password. eg: password</summary>
		[System.Text.Json.Serialization.JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public class HiveServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public HiveServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>To be deprecated please use boost_heating_on.</summary>
		///<param name="target">The target for this service call</param>
		public void BoostHeating(NetDaemon.HassModel.Entities.ServiceTarget target, HiveBoostHeatingParameters data)
		{
			_haContext.CallService("hive", "boost_heating", target, data);
		}

		///<summary>To be deprecated please use boost_heating_on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="timePeriod">Set the time period for the boost. eg: 01:30:00</param>
		///<param name="temperature">Set the target temperature for the boost period.</param>
		public void BoostHeating(NetDaemon.HassModel.Entities.ServiceTarget target, DateTime @timePeriod, double? @temperature = null)
		{
			_haContext.CallService("hive", "boost_heating", target, new HiveBoostHeatingParameters{TimePeriod = @timePeriod, Temperature = @temperature});
		}

		///<summary>Set the boost mode OFF.</summary>
		public void BoostHeatingOff(HiveBoostHeatingOffParameters data)
		{
			_haContext.CallService("hive", "boost_heating_off", null, data);
		}

		///<summary>Set the boost mode OFF.</summary>
		///<param name="entityId">Select entity_id to turn boost off.</param>
		public void BoostHeatingOff(string @entityId)
		{
			_haContext.CallService("hive", "boost_heating_off", null, new HiveBoostHeatingOffParameters{EntityId = @entityId});
		}

		///<summary>Set the boost mode ON defining the period of time and the desired target temperature for the boost.</summary>
		///<param name="target">The target for this service call</param>
		public void BoostHeatingOn(NetDaemon.HassModel.Entities.ServiceTarget target, HiveBoostHeatingOnParameters data)
		{
			_haContext.CallService("hive", "boost_heating_on", target, data);
		}

		///<summary>Set the boost mode ON defining the period of time and the desired target temperature for the boost.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="timePeriod">Set the time period for the boost. eg: 01:30:00</param>
		///<param name="temperature">Set the target temperature for the boost period.</param>
		public void BoostHeatingOn(NetDaemon.HassModel.Entities.ServiceTarget target, DateTime @timePeriod, double? @temperature = null)
		{
			_haContext.CallService("hive", "boost_heating_on", target, new HiveBoostHeatingOnParameters{TimePeriod = @timePeriod, Temperature = @temperature});
		}
	}

	public record HiveBoostHeatingParameters
	{
		///<summary>Set the time period for the boost. eg: 01:30:00</summary>
		[System.Text.Json.Serialization.JsonPropertyName("time_period")]
		public DateTime? TimePeriod { get; init; }

		///<summary>Set the target temperature for the boost period.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("temperature")]
		public double? Temperature { get; init; }
	}

	public record HiveBoostHeatingOffParameters
	{
		///<summary>Select entity_id to turn boost off.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record HiveBoostHeatingOnParameters
	{
		///<summary>Set the time period for the boost. eg: 01:30:00</summary>
		[System.Text.Json.Serialization.JsonPropertyName("time_period")]
		public DateTime? TimePeriod { get; init; }

		///<summary>Set the target temperature for the boost period.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("temperature")]
		public double? Temperature { get; init; }
	}

	public class HomeassistantServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public HomeassistantServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Check the Home Assistant configuration files for errors. Errors will be displayed in the Home Assistant log.</summary>
		public void CheckConfig()
		{
			_haContext.CallService("homeassistant", "check_config", null);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		public void ReloadConfigEntry(NetDaemon.HassModel.Entities.ServiceTarget target, HomeassistantReloadConfigEntryParameters data)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, data);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entryId">A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</param>
		public void ReloadConfigEntry(NetDaemon.HassModel.Entities.ServiceTarget target, string? @entryId = null)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, new HomeassistantReloadConfigEntryParameters{EntryId = @entryId});
		}

		///<summary>Reload the core configuration.</summary>
		public void ReloadCoreConfig()
		{
			_haContext.CallService("homeassistant", "reload_core_config", null);
		}

		///<summary>Restart the Home Assistant service.</summary>
		public void Restart()
		{
			_haContext.CallService("homeassistant", "restart", null);
		}

		///<summary>Save the persistent states (for entities derived from RestoreEntity) immediately. Maintain the normal periodic saving interval.</summary>
		public void SavePersistentStates()
		{
			_haContext.CallService("homeassistant", "save_persistent_states", null);
		}

		///<summary>Update the Home Assistant location.</summary>
		public void SetLocation(HomeassistantSetLocationParameters data)
		{
			_haContext.CallService("homeassistant", "set_location", null, data);
		}

		///<summary>Update the Home Assistant location.</summary>
		///<param name="latitude">Latitude of your location. eg: 32.87336</param>
		///<param name="longitude">Longitude of your location. eg: 117.22743</param>
		public void SetLocation(string @latitude, string @longitude)
		{
			_haContext.CallService("homeassistant", "set_location", null, new HomeassistantSetLocationParameters{Latitude = @latitude, Longitude = @longitude});
		}

		///<summary>Stop the Home Assistant service.</summary>
		public void Stop()
		{
			_haContext.CallService("homeassistant", "stop", null);
		}

		///<summary>Generic service to toggle devices on/off under any domain</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "toggle", target);
		}

		///<summary>Generic service to turn devices off under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_off", target);
		}

		///<summary>Generic service to turn devices on under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_on", target);
		}

		///<summary>Force one or more entities to update its data</summary>
		///<param name="target">The target for this service call</param>
		public void UpdateEntity(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "update_entity", target);
		}
	}

	public record HomeassistantReloadConfigEntryParameters
	{
		///<summary>A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entry_id")]
		public string? EntryId { get; init; }
	}

	public record HomeassistantSetLocationParameters
	{
		///<summary>Latitude of your location. eg: 32.87336</summary>
		[System.Text.Json.Serialization.JsonPropertyName("latitude")]
		public string? Latitude { get; init; }

		///<summary>Longitude of your location. eg: 117.22743</summary>
		[System.Text.Json.Serialization.JsonPropertyName("longitude")]
		public string? Longitude { get; init; }
	}

	public class HueServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public HueServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Activate a hue scene stored in the hue hub.</summary>
		public void HueActivateScene(HueHueActivateSceneParameters data)
		{
			_haContext.CallService("hue", "hue_activate_scene", null, data);
		}

		///<summary>Activate a hue scene stored in the hue hub.</summary>
		///<param name="groupName">Name of hue group/room from the hue app. eg: Living Room</param>
		///<param name="sceneName">Name of hue scene from the hue app. eg: Energize</param>
		///<param name="dynamic">Enable dynamic mode of the scene (V2 bridges and supported scenes only).</param>
		public void HueActivateScene(string? @groupName = null, string? @sceneName = null, bool? @dynamic = null)
		{
			_haContext.CallService("hue", "hue_activate_scene", null, new HueHueActivateSceneParameters{GroupName = @groupName, SceneName = @sceneName, Dynamic = @dynamic});
		}
	}

	public record HueHueActivateSceneParameters
	{
		///<summary>Name of hue group/room from the hue app. eg: Living Room</summary>
		[System.Text.Json.Serialization.JsonPropertyName("group_name")]
		public string? GroupName { get; init; }

		///<summary>Name of hue scene from the hue app. eg: Energize</summary>
		[System.Text.Json.Serialization.JsonPropertyName("scene_name")]
		public string? SceneName { get; init; }

		///<summary>Enable dynamic mode of the scene (V2 bridges and supported scenes only).</summary>
		[System.Text.Json.Serialization.JsonPropertyName("dynamic")]
		public bool? Dynamic { get; init; }
	}

	public class HumidifierServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public HumidifierServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(NetDaemon.HassModel.Entities.ServiceTarget target, HumidifierSetHumidityParameters data)
		{
			_haContext.CallService("humidifier", "set_humidity", target, data);
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for humidifier device.</param>
		public void SetHumidity(NetDaemon.HassModel.Entities.ServiceTarget target, long @humidity)
		{
			_haContext.CallService("humidifier", "set_humidity", target, new HumidifierSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetMode(NetDaemon.HassModel.Entities.ServiceTarget target, HumidifierSetModeParameters data)
		{
			_haContext.CallService("humidifier", "set_mode", target, data);
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mode">New mode eg: away</param>
		public void SetMode(NetDaemon.HassModel.Entities.ServiceTarget target, string @mode)
		{
			_haContext.CallService("humidifier", "set_mode", target, new HumidifierSetModeParameters{Mode = @mode});
		}

		///<summary>Toggles a humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("humidifier", "toggle", target);
		}

		///<summary>Turn humidifier device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("humidifier", "turn_off", target);
		}

		///<summary>Turn humidifier device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("humidifier", "turn_on", target);
		}
	}

	public record HumidifierSetHumidityParameters
	{
		///<summary>New target humidity for humidifier device.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record HumidifierSetModeParameters
	{
		///<summary>New mode eg: away</summary>
		[System.Text.Json.Serialization.JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public class InputBooleanServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputBooleanServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_boolean configuration</summary>
		public void Reload()
		{
			_haContext.CallService("input_boolean", "reload", null);
		}

		///<summary>Toggle an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "toggle", target);
		}

		///<summary>Turn off an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_off", target);
		}

		///<summary>Turn on an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_on", target);
		}
	}

	public class InputDatetimeServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputDatetimeServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_datetime configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_datetime", "reload", null);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDatetime(NetDaemon.HassModel.Entities.ServiceTarget target, InputDatetimeSetDatetimeParameters data)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public void SetDatetime(NetDaemon.HassModel.Entities.ServiceTarget target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public record InputDatetimeSetDatetimeParameters
	{
		///<summary>The target date the entity should be set to. eg: "2019-04-20"</summary>
		[System.Text.Json.Serialization.JsonPropertyName("date")]
		public string? Date { get; init; }

		///<summary>The target time the entity should be set to. eg: "05:04:20"</summary>
		[System.Text.Json.Serialization.JsonPropertyName("time")]
		public DateTime? Time { get; init; }

		///<summary>The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</summary>
		[System.Text.Json.Serialization.JsonPropertyName("datetime")]
		public string? Datetime { get; init; }

		///<summary>The target date & time the entity should be set to as expressed by a UNIX timestamp.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("timestamp")]
		public long? Timestamp { get; init; }
	}

	public class InputNumberServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputNumberServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_number", "decrement", target);
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_number", "increment", target);
		}

		///<summary>Reload the input_number configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_number", "reload", null);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, InputNumberSetValueParameters data)
		{
			_haContext.CallService("input_number", "set_value", target, data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to.</param>
		public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, double @value)
		{
			_haContext.CallService("input_number", "set_value", target, new InputNumberSetValueParameters{Value = @value});
		}
	}

	public record InputNumberSetValueParameters
	{
		///<summary>The target value the entity should be set to.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("value")]
		public double? Value { get; init; }
	}

	public class InputSelectServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputSelectServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_select configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_select", "reload", null);
		}

		///<summary>Select the first option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectFirst(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_first", target);
		}

		///<summary>Select the last option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectLast(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_last", target);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectNext(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSelectNextParameters data)
		{
			_haContext.CallService("input_select", "select_next", target, data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public void SelectNext(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_next", target, new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSelectOptionParameters data)
		{
			_haContext.CallService("input_select", "select_option", target, data);
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(NetDaemon.HassModel.Entities.ServiceTarget target, string @option)
		{
			_haContext.CallService("input_select", "select_option", target, new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectPrevious(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSelectPreviousParameters data)
		{
			_haContext.CallService("input_select", "select_previous", target, data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public void SelectPrevious(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_previous", target, new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetOptions(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSetOptionsParameters data)
		{
			_haContext.CallService("input_select", "set_options", target, data);
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public void SetOptions(NetDaemon.HassModel.Entities.ServiceTarget target, object @options)
		{
			_haContext.CallService("input_select", "set_options", target, new InputSelectSetOptionsParameters{Options = @options});
		}
	}

	public record InputSelectSelectNextParameters
	{
		///<summary>If the option should cycle from the last to the first.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[System.Text.Json.Serialization.JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public record InputSelectSelectPreviousParameters
	{
		///<summary>If the option should cycle from the first to the last.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSetOptionsParameters
	{
		///<summary>Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class InputTextServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputTextServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_text configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_text", "reload", null);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, InputTextSetValueParameters data)
		{
			_haContext.CallService("input_text", "set_value", target, data);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, string @value)
		{
			_haContext.CallService("input_text", "set_value", target, new InputTextSetValueParameters{Value = @value});
		}
	}

	public record InputTextSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: This is an example text</summary>
		[System.Text.Json.Serialization.JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class LightServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public LightServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target, LightToggleParameters data)
		{
			_haContext.CallService("light", "toggle", target, data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target, long? @transition = null, object? @rgbColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "toggle", target, new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target, LightTurnOffParameters data)
		{
			_haContext.CallService("light", "turn_off", target, data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target, long? @transition = null, string? @flash = null)
		{
			_haContext.CallService("light", "turn_off", target, new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, LightTurnOnParameters data)
		{
			_haContext.CallService("light", "turn_on", target, data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "turn_on", target, new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public record LightToggleParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>Color for the light in RGB-format. eg: [255, 100, 100]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A human readable color name.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("color_name")]
		public string? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("color_temp")]
		public long? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating level of white.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("white_value")]
		public long? WhiteValue { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[System.Text.Json.Serialization.JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("flash")]
		public string? Flash { get; init; }

		///<summary>Light effect.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public record LightTurnOffParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>If the light should flash.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("flash")]
		public string? Flash { get; init; }
	}

	public record LightTurnOnParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("rgbw_color")]
		public object? RgbwColor { get; init; }

		///<summary>A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("rgbww_color")]
		public object? RgbwwColor { get; init; }

		///<summary>A human readable color name.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("color_name")]
		public string? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("color_temp")]
		public long? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Change brightness by an amount.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("brightness_step")]
		public long? BrightnessStep { get; init; }

		///<summary>Change brightness by a percentage.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("brightness_step_pct")]
		public long? BrightnessStepPct { get; init; }

		///<summary>Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("white")]
		public long? White { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[System.Text.Json.Serialization.JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("flash")]
		public string? Flash { get; init; }

		///<summary>Light effect.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public class LockServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public LockServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Lock(NetDaemon.HassModel.Entities.ServiceTarget target, LockLockParameters data)
		{
			_haContext.CallService("lock", "lock", target, data);
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public void Lock(NetDaemon.HassModel.Entities.ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "lock", target, new LockLockParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Open(NetDaemon.HassModel.Entities.ServiceTarget target, LockOpenParameters data)
		{
			_haContext.CallService("lock", "open", target, data);
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public void Open(NetDaemon.HassModel.Entities.ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "open", target, new LockOpenParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Unlock(NetDaemon.HassModel.Entities.ServiceTarget target, LockUnlockParameters data)
		{
			_haContext.CallService("lock", "unlock", target, data);
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public void Unlock(NetDaemon.HassModel.Entities.ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "unlock", target, new LockUnlockParameters{Code = @code});
		}
	}

	public record LockLockParameters
	{
		///<summary>An optional code to lock the lock with. eg: 1234</summary>
		[System.Text.Json.Serialization.JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockOpenParameters
	{
		///<summary>An optional code to open the lock with. eg: 1234</summary>
		[System.Text.Json.Serialization.JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockUnlockParameters
	{
		///<summary>An optional code to unlock the lock with. eg: 1234</summary>
		[System.Text.Json.Serialization.JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class LogbookServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public LogbookServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create a custom entry in your logbook.</summary>
		public void Log(LogbookLogParameters data)
		{
			_haContext.CallService("logbook", "log", null, data);
		}

		///<summary>Create a custom entry in your logbook.</summary>
		///<param name="name">Custom name for an entity, can be referenced with entity_id. eg: Kitchen</param>
		///<param name="message">Message of the custom logbook entry. eg: is being used</param>
		///<param name="entityId">Entity to reference in custom logbook entry.</param>
		///<param name="domain">Icon of domain to display in custom logbook entry. eg: light</param>
		public void Log(string @name, string @message, string? @entityId = null, string? @domain = null)
		{
			_haContext.CallService("logbook", "log", null, new LogbookLogParameters{Name = @name, Message = @message, EntityId = @entityId, Domain = @domain});
		}
	}

	public record LogbookLogParameters
	{
		///<summary>Custom name for an entity, can be referenced with entity_id. eg: Kitchen</summary>
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Message of the custom logbook entry. eg: is being used</summary>
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Entity to reference in custom logbook entry.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Icon of domain to display in custom logbook entry. eg: light</summary>
		[System.Text.Json.Serialization.JsonPropertyName("domain")]
		public string? Domain { get; init; }
	}

	public class LoggerServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public LoggerServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set the default log level for integrations.</summary>
		public void SetDefaultLevel(LoggerSetDefaultLevelParameters data)
		{
			_haContext.CallService("logger", "set_default_level", null, data);
		}

		///<summary>Set the default log level for integrations.</summary>
		///<param name="level">Default severity level for all integrations.</param>
		public void SetDefaultLevel(string? @level = null)
		{
			_haContext.CallService("logger", "set_default_level", null, new LoggerSetDefaultLevelParameters{Level = @level});
		}

		///<summary>Set log level for integrations.</summary>
		public void SetLevel()
		{
			_haContext.CallService("logger", "set_level", null);
		}
	}

	public record LoggerSetDefaultLevelParameters
	{
		///<summary>Default severity level for all integrations.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("level")]
		public string? Level { get; init; }
	}

	public class MediaPlayerServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public MediaPlayerServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearPlaylist(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "clear_playlist", target);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Join(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerJoinParameters data)
		{
			_haContext.CallService("media_player", "join", target, data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2", "media_player.multiroom_player3"]</param>
		public void Join(NetDaemon.HassModel.Entities.ServiceTarget target, object? @groupMembers = null)
		{
			_haContext.CallService("media_player", "join", target, new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaNextTrack(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_next_track", target);
		}

		///<summary>Send the media player the command for pause.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPause(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_pause", target);
		}

		///<summary>Send the media player the command for play.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlay(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play", target);
		}

		///<summary>Toggle media player play/pause state.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlayPause(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play_pause", target);
		}

		///<summary>Send the media player the command for previous track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPreviousTrack(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_previous_track", target);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaSeek(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerMediaSeekParameters data)
		{
			_haContext.CallService("media_player", "media_seek", target, data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public void MediaSeek(NetDaemon.HassModel.Entities.ServiceTarget target, double @seekPosition)
		{
			_haContext.CallService("media_player", "media_seek", target, new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaStop(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_stop", target);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayMedia(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerPlayMediaParameters data)
		{
			_haContext.CallService("media_player", "play_media", target, data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		public void PlayMedia(NetDaemon.HassModel.Entities.ServiceTarget target, string @mediaContentId, string @mediaContentType)
		{
			_haContext.CallService("media_player", "play_media", target, new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		public void RepeatSet(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerRepeatSetParameters data)
		{
			_haContext.CallService("media_player", "repeat_set", target, data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		///<param name="repeat">Repeat mode to set.</param>
		public void RepeatSet(NetDaemon.HassModel.Entities.ServiceTarget target, string @repeat)
		{
			_haContext.CallService("media_player", "repeat_set", target, new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSoundMode(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerSelectSoundModeParameters data)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public void SelectSoundMode(NetDaemon.HassModel.Entities.ServiceTarget target, string? @soundMode = null)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSource(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerSelectSourceParameters data)
		{
			_haContext.CallService("media_player", "select_source", target, data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public void SelectSource(NetDaemon.HassModel.Entities.ServiceTarget target, string @source)
		{
			_haContext.CallService("media_player", "select_source", target, new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		public void ShuffleSet(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerShuffleSetParameters data)
		{
			_haContext.CallService("media_player", "shuffle_set", target, data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public void ShuffleSet(NetDaemon.HassModel.Entities.ServiceTarget target, bool @shuffle)
		{
			_haContext.CallService("media_player", "shuffle_set", target, new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "toggle", target);
		}

		///<summary>Turn a media player power off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_off", target);
		}

		///<summary>Turn a media player power on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_on", target);
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Unjoin(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "unjoin", target);
		}

		///<summary>Turn a media player volume down.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeDown(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_down", target);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeMute(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerVolumeMuteParameters data)
		{
			_haContext.CallService("media_player", "volume_mute", target, data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public void VolumeMute(NetDaemon.HassModel.Entities.ServiceTarget target, bool @isVolumeMuted)
		{
			_haContext.CallService("media_player", "volume_mute", target, new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeSet(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerVolumeSetParameters data)
		{
			_haContext.CallService("media_player", "volume_set", target, data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public void VolumeSet(NetDaemon.HassModel.Entities.ServiceTarget target, double @volumeLevel)
		{
			_haContext.CallService("media_player", "volume_set", target, new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeUp(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_up", target);
		}
	}

	public record MediaPlayerJoinParameters
	{
		///<summary>The players which will be synced with the target player. eg: ["media_player.multiroom_player2", "media_player.multiroom_player3"]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("group_members")]
		public object? GroupMembers { get; init; }
	}

	public record MediaPlayerMediaSeekParameters
	{
		///<summary>Position to seek to. The format is platform dependent.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("seek_position")]
		public double? SeekPosition { get; init; }
	}

	public record MediaPlayerPlayMediaParameters
	{
		///<summary>The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</summary>
		[System.Text.Json.Serialization.JsonPropertyName("media_content_id")]
		public string? MediaContentId { get; init; }

		///<summary>The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</summary>
		[System.Text.Json.Serialization.JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }
	}

	public record MediaPlayerRepeatSetParameters
	{
		///<summary>Repeat mode to set.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("repeat")]
		public string? Repeat { get; init; }
	}

	public record MediaPlayerSelectSoundModeParameters
	{
		///<summary>Name of the sound mode to switch to. eg: Music</summary>
		[System.Text.Json.Serialization.JsonPropertyName("sound_mode")]
		public string? SoundMode { get; init; }
	}

	public record MediaPlayerSelectSourceParameters
	{
		///<summary>Name of the source to switch to. Platform dependent. eg: video1</summary>
		[System.Text.Json.Serialization.JsonPropertyName("source")]
		public string? Source { get; init; }
	}

	public record MediaPlayerShuffleSetParameters
	{
		///<summary>True/false for enabling/disabling shuffle.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }
	}

	public record MediaPlayerVolumeMuteParameters
	{
		///<summary>True/false for mute/unmute.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }
	}

	public record MediaPlayerVolumeSetParameters
	{
		///<summary>Volume level to set as float.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public class MqttServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public MqttServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
		public void Dump(MqttDumpParameters data)
		{
			_haContext.CallService("mqtt", "dump", null, data);
		}

		///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
		///<param name="topic">topic to listen to eg: OpenZWave/#</param>
		///<param name="duration">how long we should listen for messages in seconds</param>
		public void Dump(string? @topic = null, long? @duration = null)
		{
			_haContext.CallService("mqtt", "dump", null, new MqttDumpParameters{Topic = @topic, Duration = @duration});
		}

		///<summary>Publish a message to an MQTT topic.</summary>
		public void Publish(MqttPublishParameters data)
		{
			_haContext.CallService("mqtt", "publish", null, data);
		}

		///<summary>Publish a message to an MQTT topic.</summary>
		///<param name="topic">Topic to publish payload. eg: /homeassistant/hello</param>
		///<param name="payload">Payload to publish. eg: This is great</param>
		///<param name="payloadTemplate">Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</param>
		///<param name="qos">Quality of Service to use.</param>
		///<param name="retain">If message should have the retain flag set.</param>
		public void Publish(string @topic, string? @payload = null, object? @payloadTemplate = null, string? @qos = null, bool? @retain = null)
		{
			_haContext.CallService("mqtt", "publish", null, new MqttPublishParameters{Topic = @topic, Payload = @payload, PayloadTemplate = @payloadTemplate, Qos = @qos, Retain = @retain});
		}

		///<summary>Reload all MQTT entities from YAML.</summary>
		public void Reload()
		{
			_haContext.CallService("mqtt", "reload", null);
		}
	}

	public record MqttDumpParameters
	{
		///<summary>topic to listen to eg: OpenZWave/#</summary>
		[System.Text.Json.Serialization.JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>how long we should listen for messages in seconds</summary>
		[System.Text.Json.Serialization.JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record MqttPublishParameters
	{
		///<summary>Topic to publish payload. eg: /homeassistant/hello</summary>
		[System.Text.Json.Serialization.JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>Payload to publish. eg: This is great</summary>
		[System.Text.Json.Serialization.JsonPropertyName("payload")]
		public string? Payload { get; init; }

		///<summary>Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</summary>
		[System.Text.Json.Serialization.JsonPropertyName("payload_template")]
		public object? PayloadTemplate { get; init; }

		///<summary>Quality of Service to use.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("qos")]
		public string? Qos { get; init; }

		///<summary>If message should have the retain flag set.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("retain")]
		public bool? Retain { get; init; }
	}

	public class NetdaemonServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public NetdaemonServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create an entity</summary>
		public void EntityCreate(NetdaemonEntityCreateParameters data)
		{
			_haContext.CallService("netdaemon", "entity_create", null, data);
		}

		///<summary>Create an entity</summary>
		///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
		///<param name="state">The state of the entity eg: Lorem ipsum</param>
		///<param name="icon">The icon for the entity eg: mdi:rocket-launch-outline</param>
		///<param name="unit">The unit of measurement for the entity</param>
		///<param name="attributes">The attributes of the entity</param>
		public void EntityCreate(string? @entityId = null, string? @state = null, string? @icon = null, string? @unit = null, string? @attributes = null)
		{
			_haContext.CallService("netdaemon", "entity_create", null, new NetdaemonEntityCreateParameters{EntityId = @entityId, State = @state, Icon = @icon, Unit = @unit, Attributes = @attributes});
		}

		///<summary>Remove an entity</summary>
		public void EntityRemove(NetdaemonEntityRemoveParameters data)
		{
			_haContext.CallService("netdaemon", "entity_remove", null, data);
		}

		///<summary>Remove an entity</summary>
		///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
		public void EntityRemove(string? @entityId = null)
		{
			_haContext.CallService("netdaemon", "entity_remove", null, new NetdaemonEntityRemoveParameters{EntityId = @entityId});
		}

		///<summary>Update an entity</summary>
		public void EntityUpdate(NetdaemonEntityUpdateParameters data)
		{
			_haContext.CallService("netdaemon", "entity_update", null, data);
		}

		///<summary>Update an entity</summary>
		///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
		///<param name="state">The state of the entity eg: Lorem ipsum</param>
		///<param name="icon">The icon for the entity eg: mdi:rocket-launch-outline</param>
		///<param name="unit">The unit of measurement for the entity</param>
		///<param name="attributes">The attributes of the entity</param>
		public void EntityUpdate(string? @entityId = null, string? @state = null, string? @icon = null, string? @unit = null, string? @attributes = null)
		{
			_haContext.CallService("netdaemon", "entity_update", null, new NetdaemonEntityUpdateParameters{EntityId = @entityId, State = @state, Icon = @icon, Unit = @unit, Attributes = @attributes});
		}

		public void GetTidalEvents()
		{
			_haContext.CallService("netdaemon", "get_tidal_events", null);
		}

		public void LivingroomLightsOff()
		{
			_haContext.CallService("netdaemon", "livingroom_lights_off", null);
		}

		public void LivingroomLightsOn()
		{
			_haContext.CallService("netdaemon", "livingroom_lights_on", null);
		}

		///<summary>Register a new service for netdaemon, used by the daemon and not to be used by users</summary>
		public void RegisterService(NetdaemonRegisterServiceParameters data)
		{
			_haContext.CallService("netdaemon", "register_service", null, data);
		}

		///<summary>Register a new service for netdaemon, used by the daemon and not to be used by users</summary>
		///<param name="service">The name of the service to register</param>
		///<param name="class">The class that implements the service call</param>
		///<param name="method">The method to call</param>
		public void RegisterService(string? @service = null, string? @class = null, string? @method = null)
		{
			_haContext.CallService("netdaemon", "register_service", null, new NetdaemonRegisterServiceParameters{Service = @service, Class = @class, Method = @method});
		}

		public void ReloadApps()
		{
			_haContext.CallService("netdaemon", "reload_apps", null);
		}
	}

	public record NetdaemonEntityCreateParameters
	{
		///<summary>The entity ID of the entity eg: sensor.awesome</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>The state of the entity eg: Lorem ipsum</summary>
		[System.Text.Json.Serialization.JsonPropertyName("state")]
		public string? State { get; init; }

		///<summary>The icon for the entity eg: mdi:rocket-launch-outline</summary>
		[System.Text.Json.Serialization.JsonPropertyName("icon")]
		public string? Icon { get; init; }

		///<summary>The unit of measurement for the entity</summary>
		[System.Text.Json.Serialization.JsonPropertyName("unit")]
		public string? Unit { get; init; }

		///<summary>The attributes of the entity</summary>
		[System.Text.Json.Serialization.JsonPropertyName("attributes")]
		public string? Attributes { get; init; }
	}

	public record NetdaemonEntityRemoveParameters
	{
		///<summary>The entity ID of the entity eg: sensor.awesome</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record NetdaemonEntityUpdateParameters
	{
		///<summary>The entity ID of the entity eg: sensor.awesome</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>The state of the entity eg: Lorem ipsum</summary>
		[System.Text.Json.Serialization.JsonPropertyName("state")]
		public string? State { get; init; }

		///<summary>The icon for the entity eg: mdi:rocket-launch-outline</summary>
		[System.Text.Json.Serialization.JsonPropertyName("icon")]
		public string? Icon { get; init; }

		///<summary>The unit of measurement for the entity</summary>
		[System.Text.Json.Serialization.JsonPropertyName("unit")]
		public string? Unit { get; init; }

		///<summary>The attributes of the entity</summary>
		[System.Text.Json.Serialization.JsonPropertyName("attributes")]
		public string? Attributes { get; init; }
	}

	public record NetdaemonRegisterServiceParameters
	{
		///<summary>The name of the service to register</summary>
		[System.Text.Json.Serialization.JsonPropertyName("service")]
		public string? Service { get; init; }

		///<summary>The class that implements the service call</summary>
		[System.Text.Json.Serialization.JsonPropertyName("class")]
		public string? Class { get; init; }

		///<summary>The method to call</summary>
		[System.Text.Json.Serialization.JsonPropertyName("method")]
		public string? Method { get; init; }
	}

	public class NotifyServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public NotifyServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sends a notification message using the mobile_app_jo_s_iphone integration.</summary>
		public void MobileAppJoSIphone(NotifyMobileAppJoSIphoneParameters data)
		{
			_haContext.CallService("notify", "mobile_app_jo_s_iphone", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_jo_s_iphone integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppJoSIphone(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_jo_s_iphone", null, new NotifyMobileAppJoSIphoneParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_scott_s_xr integration.</summary>
		public void MobileAppScottSXr(NotifyMobileAppScottSXrParameters data)
		{
			_haContext.CallService("notify", "mobile_app_scott_s_xr", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_scott_s_xr integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppScottSXr(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_scott_s_xr", null, new NotifyMobileAppScottSXrParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_theos_iphone_6s integration.</summary>
		public void MobileAppTheosIphone6s(NotifyMobileAppTheosIphone6sParameters data)
		{
			_haContext.CallService("notify", "mobile_app_theos_iphone_6s", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_theos_iphone_6s integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppTheosIphone6s(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_theos_iphone_6s", null, new NotifyMobileAppTheosIphone6sParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the notify service.</summary>
		public void Notify(NotifyNotifyParameters data)
		{
			_haContext.CallService("notify", "notify", null, data);
		}

		///<summary>Sends a notification message using the notify service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void Notify(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "notify", null, new NotifyNotifyParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification to the visible in the front-end.</summary>
		public void PersistentNotification(NotifyPersistentNotificationParameters data)
		{
			_haContext.CallService("notify", "persistent_notification", null, data);
		}

		///<summary>Sends a notification to the visible in the front-end.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		public void PersistentNotification(string @message, string? @title = null)
		{
			_haContext.CallService("notify", "persistent_notification", null, new NotifyPersistentNotificationParameters{Message = @message, Title = @title});
		}
	}

	public record NotifyMobileAppJoSIphoneParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[System.Text.Json.Serialization.JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[System.Text.Json.Serialization.JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppScottSXrParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[System.Text.Json.Serialization.JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[System.Text.Json.Serialization.JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppTheosIphone6sParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[System.Text.Json.Serialization.JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[System.Text.Json.Serialization.JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyNotifyParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[System.Text.Json.Serialization.JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[System.Text.Json.Serialization.JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyPersistentNotificationParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public class NumberServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public NumberServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, NumberSetValueParameters data)
		{
			_haContext.CallService("number", "set_value", target, data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, string? @value = null)
		{
			_haContext.CallService("number", "set_value", target, new NumberSetValueParameters{Value = @value});
		}
	}

	public record NumberSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: 42</summary>
		[System.Text.Json.Serialization.JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class PersistentNotificationServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public PersistentNotificationServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Show a notification in the frontend.</summary>
		public void Create(PersistentNotificationCreateParameters data)
		{
			_haContext.CallService("persistent_notification", "create", null, data);
		}

		///<summary>Show a notification in the frontend.</summary>
		///<param name="message">Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</param>
		///<param name="title">Optional title for your notification. [Templates accepted] eg: Test notification</param>
		///<param name="notificationId">Target ID of the notification, will replace a notification with the same ID. eg: 1234</param>
		public void Create(string @message, string? @title = null, string? @notificationId = null)
		{
			_haContext.CallService("persistent_notification", "create", null, new PersistentNotificationCreateParameters{Message = @message, Title = @title, NotificationId = @notificationId});
		}

		///<summary>Remove a notification from the frontend.</summary>
		public void Dismiss(PersistentNotificationDismissParameters data)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, data);
		}

		///<summary>Remove a notification from the frontend.</summary>
		///<param name="notificationId">Target ID of the notification, which should be removed. eg: 1234</param>
		public void Dismiss(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, new PersistentNotificationDismissParameters{NotificationId = @notificationId});
		}

		///<summary>Mark a notification read.</summary>
		public void MarkRead(PersistentNotificationMarkReadParameters data)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, data);
		}

		///<summary>Mark a notification read.</summary>
		///<param name="notificationId">Target ID of the notification, which should be mark read. eg: 1234</param>
		public void MarkRead(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, new PersistentNotificationMarkReadParameters{NotificationId = @notificationId});
		}
	}

	public record PersistentNotificationCreateParameters
	{
		///<summary>Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Optional title for your notification. [Templates accepted] eg: Test notification</summary>
		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>Target ID of the notification, will replace a notification with the same ID. eg: 1234</summary>
		[System.Text.Json.Serialization.JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationDismissParameters
	{
		///<summary>Target ID of the notification, which should be removed. eg: 1234</summary>
		[System.Text.Json.Serialization.JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationMarkReadParameters
	{
		///<summary>Target ID of the notification, which should be mark read. eg: 1234</summary>
		[System.Text.Json.Serialization.JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public class PersonServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public PersonServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the person configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("person", "reload", null);
		}
	}

	public class RecorderServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public RecorderServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Stop the recording of events and state changes</summary>
		public void Disable()
		{
			_haContext.CallService("recorder", "disable", null);
		}

		///<summary>Start the recording of events and state changes</summary>
		public void Enable()
		{
			_haContext.CallService("recorder", "enable", null);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		public void Purge(RecorderPurgeParameters data)
		{
			_haContext.CallService("recorder", "purge", null, data);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		///<param name="keepDays">Number of history days to keep in database after purge.</param>
		///<param name="repack">Attempt to save disk space by rewriting the entire database file.</param>
		///<param name="applyFilter">Apply entity_id and event_type filter in addition to time based purge.</param>
		public void Purge(long? @keepDays = null, bool? @repack = null, bool? @applyFilter = null)
		{
			_haContext.CallService("recorder", "purge", null, new RecorderPurgeParameters{KeepDays = @keepDays, Repack = @repack, ApplyFilter = @applyFilter});
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		public void PurgeEntities(NetDaemon.HassModel.Entities.ServiceTarget target, RecorderPurgeEntitiesParameters data)
		{
			_haContext.CallService("recorder", "purge_entities", target, data);
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="domains">List the domains that need to be removed from the recorder database. eg: sun</param>
		///<param name="entityGlobs">List the regular expressions to select entities for removal from the recorder database. eg: domain*.object_id*</param>
		public void PurgeEntities(NetDaemon.HassModel.Entities.ServiceTarget target, object? @domains = null, object? @entityGlobs = null)
		{
			_haContext.CallService("recorder", "purge_entities", target, new RecorderPurgeEntitiesParameters{Domains = @domains, EntityGlobs = @entityGlobs});
		}
	}

	public record RecorderPurgeParameters
	{
		///<summary>Number of history days to keep in database after purge.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("keep_days")]
		public long? KeepDays { get; init; }

		///<summary>Attempt to save disk space by rewriting the entire database file.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("repack")]
		public bool? Repack { get; init; }

		///<summary>Apply entity_id and event_type filter in addition to time based purge.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("apply_filter")]
		public bool? ApplyFilter { get; init; }
	}

	public record RecorderPurgeEntitiesParameters
	{
		///<summary>List the domains that need to be removed from the recorder database. eg: sun</summary>
		[System.Text.Json.Serialization.JsonPropertyName("domains")]
		public object? Domains { get; init; }

		///<summary>List the regular expressions to select entities for removal from the recorder database. eg: domain*.object_id*</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entity_globs")]
		public object? EntityGlobs { get; init; }
	}

	public class ReolinkDevServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ReolinkDevServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Execute a PTZ command.</summary>
		///<param name="target">The target for this service call</param>
		public void PtzControl(NetDaemon.HassModel.Entities.ServiceTarget target, ReolinkDevPtzControlParameters data)
		{
			_haContext.CallService("reolink_dev", "ptz_control", target, data);
		}

		///<summary>Execute a PTZ command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="command">Command to execute. Possible values are: AUTO DOWN FOCUSDEC FOCUSINC LEFT LEFTDOWN LEFTUP RIGHT RIGHTDOWN RIGHTUP STOP TOPOS UP ZOOMDEC ZOOMINC eg: LEFTUP</param>
		///<param name="preset">(Optional) In case of the command TOPOS. The available presets are listed as attribute on the camera. eg: HOME</param>
		///<param name="speed">(Optional) Speed at which the movement takes place. eg: 25</param>
		public void PtzControl(NetDaemon.HassModel.Entities.ServiceTarget target, string? @entityId = null, string? @command = null, string? @preset = null, string? @speed = null)
		{
			_haContext.CallService("reolink_dev", "ptz_control", target, new ReolinkDevPtzControlParameters{EntityId = @entityId, Command = @command, Preset = @preset, Speed = @speed});
		}

		///<summary>For cameras that have Video-On-Demand Playback capability, this will query the camera and emit an reolink_dev-vod-data event for each matching VoD that matches the search parameters, it will also provide the thumbail path for the expected thumbnail.</summary>
		///<param name="target">The target for this service call</param>
		public void QueryVods(NetDaemon.HassModel.Entities.ServiceTarget target, ReolinkDevQueryVodsParameters data)
		{
			_haContext.CallService("reolink_dev", "query_vods", target, data);
		}

		///<summary>For cameras that have Video-On-Demand Playback capability, this will query the camera and emit an reolink_dev-vod-data event for each matching VoD that matches the search parameters, it will also provide the thumbail path for the expected thumbnail.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="eventId">Event to emit as eg: VoD-query</param>
		///<param name="start">Start of date range, if not provided will use the month playback range eg: 1/1/2021</param>
		///<param name="end">End of date range, if not provided will use the current date and time eg: 1/31/2021</param>
		public void QueryVods(NetDaemon.HassModel.Entities.ServiceTarget target, string? @entityId = null, string? @eventId = null, string? @start = null, string? @end = null)
		{
			_haContext.CallService("reolink_dev", "query_vods", target, new ReolinkDevQueryVodsParameters{EntityId = @entityId, EventId = @eventId, Start = @start, End = @end});
		}

		///<summary>Optimizing brightness and contrast levels to compensate for differences between dark and bright objects using either BLC or WDR mode. This may improve image clarity in high contrast situations, but it should be tested at different times of the day and night to ensure there is no negative effect.</summary>
		///<param name="target">The target for this service call</param>
		public void SetBacklight(NetDaemon.HassModel.Entities.ServiceTarget target, ReolinkDevSetBacklightParameters data)
		{
			_haContext.CallService("reolink_dev", "set_backlight", target, data);
		}

		///<summary>Optimizing brightness and contrast levels to compensate for differences between dark and bright objects using either BLC or WDR mode. This may improve image clarity in high contrast situations, but it should be tested at different times of the day and night to ensure there is no negative effect.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="mode">The backlight parameter supports the following values:   BACKLIGHTCONTROL: use Backlight Control   DYNAMICRANGECONTROL: use Dynamic Range Control   OFF: no optimization eg: DYNAMICRANGECONTROL</param>
		public void SetBacklight(NetDaemon.HassModel.Entities.ServiceTarget target, string? @entityId = null, string? @mode = null)
		{
			_haContext.CallService("reolink_dev", "set_backlight", target, new ReolinkDevSetBacklightParameters{EntityId = @entityId, Mode = @mode});
		}

		///<summary>Set day and night parameter.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDaynight(NetDaemon.HassModel.Entities.ServiceTarget target, ReolinkDevSetDaynightParameters data)
		{
			_haContext.CallService("reolink_dev", "set_daynight", target, data);
		}

		///<summary>Set day and night parameter.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="mode">The day and night mode parameter supports the following values:   AUTO: Auto switch between black & white mode   COLOR: Always record videos in color mode   BLACKANDWHITE: Always record videos in black & white mode eg: AUTO</param>
		public void SetDaynight(NetDaemon.HassModel.Entities.ServiceTarget target, string? @entityId = null, string? @mode = null)
		{
			_haContext.CallService("reolink_dev", "set_daynight", target, new ReolinkDevSetDaynightParameters{EntityId = @entityId, Mode = @mode});
		}

		///<summary>Set the motion detection sensitivity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSensitivity(NetDaemon.HassModel.Entities.ServiceTarget target, ReolinkDevSetSensitivityParameters data)
		{
			_haContext.CallService("reolink_dev", "set_sensitivity", target, data);
		}

		///<summary>Set the motion detection sensitivity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="sensitivity">New sensitivity, value between 1 (low sensitivity) and 50 (high sensitivity) eg: 25</param>
		///<param name="preset">(Optional) Set the sensitivity of a specific preset (time schedule). When no value is supplied, all presets will be changed.</param>
		public void SetSensitivity(NetDaemon.HassModel.Entities.ServiceTarget target, string? @entityId = null, string? @sensitivity = null, string? @preset = null)
		{
			_haContext.CallService("reolink_dev", "set_sensitivity", target, new ReolinkDevSetSensitivityParameters{EntityId = @entityId, Sensitivity = @sensitivity, Preset = @preset});
		}
	}

	public record ReolinkDevPtzControlParameters
	{
		///<summary>Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Command to execute. Possible values are: AUTO DOWN FOCUSDEC FOCUSINC LEFT LEFTDOWN LEFTUP RIGHT RIGHTDOWN RIGHTUP STOP TOPOS UP ZOOMDEC ZOOMINC eg: LEFTUP</summary>
		[System.Text.Json.Serialization.JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>(Optional) In case of the command TOPOS. The available presets are listed as attribute on the camera. eg: HOME</summary>
		[System.Text.Json.Serialization.JsonPropertyName("preset")]
		public string? Preset { get; init; }

		///<summary>(Optional) Speed at which the movement takes place. eg: 25</summary>
		[System.Text.Json.Serialization.JsonPropertyName("speed")]
		public string? Speed { get; init; }
	}

	public record ReolinkDevQueryVodsParameters
	{
		///<summary>Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Event to emit as eg: VoD-query</summary>
		[System.Text.Json.Serialization.JsonPropertyName("event_id")]
		public string? EventId { get; init; }

		///<summary>Start of date range, if not provided will use the month playback range eg: 1/1/2021</summary>
		[System.Text.Json.Serialization.JsonPropertyName("start")]
		public string? Start { get; init; }

		///<summary>End of date range, if not provided will use the current date and time eg: 1/31/2021</summary>
		[System.Text.Json.Serialization.JsonPropertyName("end")]
		public string? End { get; init; }
	}

	public record ReolinkDevSetBacklightParameters
	{
		///<summary>Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>The backlight parameter supports the following values:   BACKLIGHTCONTROL: use Backlight Control   DYNAMICRANGECONTROL: use Dynamic Range Control   OFF: no optimization eg: DYNAMICRANGECONTROL</summary>
		[System.Text.Json.Serialization.JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public record ReolinkDevSetDaynightParameters
	{
		///<summary>Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>The day and night mode parameter supports the following values:   AUTO: Auto switch between black & white mode   COLOR: Always record videos in color mode   BLACKANDWHITE: Always record videos in black & white mode eg: AUTO</summary>
		[System.Text.Json.Serialization.JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public record ReolinkDevSetSensitivityParameters
	{
		///<summary>Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>New sensitivity, value between 1 (low sensitivity) and 50 (high sensitivity) eg: 25</summary>
		[System.Text.Json.Serialization.JsonPropertyName("sensitivity")]
		public string? Sensitivity { get; init; }

		///<summary>(Optional) Set the sensitivity of a specific preset (time schedule). When no value is supplied, all presets will be changed.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("preset")]
		public string? Preset { get; init; }
	}

	public class SceneServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SceneServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Activate a scene with configuration.</summary>
		public void Apply(SceneApplyParameters data)
		{
			_haContext.CallService("scene", "apply", null, data);
		}

		///<summary>Activate a scene with configuration.</summary>
		///<param name="entities">The entities and the state that they need to be. eg: {"light.kitchen": "on", "light.ceiling": {"state": "on", "brightness": 80}}</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void Apply(object @entities, long? @transition = null)
		{
			_haContext.CallService("scene", "apply", null, new SceneApplyParameters{Entities = @entities, Transition = @transition});
		}

		///<summary>Creates a new scene.</summary>
		public void Create(SceneCreateParameters data)
		{
			_haContext.CallService("scene", "create", null, data);
		}

		///<summary>Creates a new scene.</summary>
		///<param name="sceneId">The entity_id of the new scene. eg: all_lights</param>
		///<param name="entities">The entities to control with the scene. eg: {"light.tv_back_light": "on", "light.ceiling": {"state": "on", "brightness": 200}}</param>
		///<param name="snapshotEntities">The entities of which a snapshot is to be taken eg: ["light.ceiling", "light.kitchen"]</param>
		public void Create(string @sceneId, object? @entities = null, object? @snapshotEntities = null)
		{
			_haContext.CallService("scene", "create", null, new SceneCreateParameters{SceneId = @sceneId, Entities = @entities, SnapshotEntities = @snapshotEntities});
		}

		///<summary>Reload the scene configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("scene", "reload", null);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, SceneTurnOnParameters data)
		{
			_haContext.CallService("scene", "turn_on", target, data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, long? @transition = null)
		{
			_haContext.CallService("scene", "turn_on", target, new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public record SceneApplyParameters
	{
		///<summary>The entities and the state that they need to be. eg: {"light.kitchen": "on", "light.ceiling": {"state": "on", "brightness": 80}}</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public record SceneCreateParameters
	{
		///<summary>The entity_id of the new scene. eg: all_lights</summary>
		[System.Text.Json.Serialization.JsonPropertyName("scene_id")]
		public string? SceneId { get; init; }

		///<summary>The entities to control with the scene. eg: {"light.tv_back_light": "on", "light.ceiling": {"state": "on", "brightness": 200}}</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>The entities of which a snapshot is to be taken eg: ["light.ceiling", "light.kitchen"]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("snapshot_entities")]
		public object? SnapshotEntities { get; init; }
	}

	public record SceneTurnOnParameters
	{
		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public class ScriptServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ScriptServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all the available scripts</summary>
		public void Reload()
		{
			_haContext.CallService("script", "reload", null);
		}

		///<summary>Toggle script</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("script", "toggle", target);
		}

		///<summary>Turn off script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("script", "turn_off", target);
		}

		///<summary>Turn on script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("script", "turn_on", target);
		}
	}

	public class SelectServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SelectServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(NetDaemon.HassModel.Entities.ServiceTarget target, SelectSelectOptionParameters data)
		{
			_haContext.CallService("select", "select_option", target, data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(NetDaemon.HassModel.Entities.ServiceTarget target, string @option)
		{
			_haContext.CallService("select", "select_option", target, new SelectSelectOptionParameters{Option = @option});
		}
	}

	public record SelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[System.Text.Json.Serialization.JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public class SirenServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SirenServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a siren.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("siren", "toggle", target);
		}

		///<summary>Turn siren off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("siren", "turn_off", target);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, SirenTurnOnParameters data)
		{
			_haContext.CallService("siren", "turn_on", target, data);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tone">The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</param>
		///<param name="volumeLevel">The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0.5</param>
		///<param name="duration">The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, string? @tone = null, double? @volumeLevel = null, string? @duration = null)
		{
			_haContext.CallService("siren", "turn_on", target, new SirenTurnOnParameters{Tone = @tone, VolumeLevel = @volumeLevel, Duration = @duration});
		}
	}

	public record SirenTurnOnParameters
	{
		///<summary>The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</summary>
		[System.Text.Json.Serialization.JsonPropertyName("tone")]
		public string? Tone { get; init; }

		///<summary>The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0.5</summary>
		[System.Text.Json.Serialization.JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }

		///<summary>The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</summary>
		[System.Text.Json.Serialization.JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class SwitchServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SwitchServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a switch state</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("switch", "toggle", target);
		}

		///<summary>Turn a switch off</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_off", target);
		}

		///<summary>Turn a switch on</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_on", target);
		}
	}

	public class SystemLogServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SystemLogServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear all log entries.</summary>
		public void Clear()
		{
			_haContext.CallService("system_log", "clear", null);
		}

		///<summary>Write log entry.</summary>
		public void Write(SystemLogWriteParameters data)
		{
			_haContext.CallService("system_log", "write", null, data);
		}

		///<summary>Write log entry.</summary>
		///<param name="message">Message to log. eg: Something went wrong</param>
		///<param name="level">Log level.</param>
		///<param name="logger">Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</param>
		public void Write(string @message, string? @level = null, string? @logger = null)
		{
			_haContext.CallService("system_log", "write", null, new SystemLogWriteParameters{Message = @message, Level = @level, Logger = @logger});
		}
	}

	public record SystemLogWriteParameters
	{
		///<summary>Message to log. eg: Something went wrong</summary>
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Log level.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("level")]
		public string? Level { get; init; }

		///<summary>Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</summary>
		[System.Text.Json.Serialization.JsonPropertyName("logger")]
		public string? Logger { get; init; }
	}

	public class TimerServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public TimerServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Cancel a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Cancel(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("timer", "cancel", target);
		}

		///<summary>Finish a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Finish(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("timer", "finish", target);
		}

		///<summary>Pause a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("timer", "pause", target);
		}

		public void Reload()
		{
			_haContext.CallService("timer", "reload", null);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		public void Start(NetDaemon.HassModel.Entities.ServiceTarget target, TimerStartParameters data)
		{
			_haContext.CallService("timer", "start", target, data);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public void Start(NetDaemon.HassModel.Entities.ServiceTarget target, string? @duration = null)
		{
			_haContext.CallService("timer", "start", target, new TimerStartParameters{Duration = @duration});
		}
	}

	public record TimerStartParameters
	{
		///<summary>Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</summary>
		[System.Text.Json.Serialization.JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class TtsServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public TtsServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Remove all text-to-speech cache files and RAM cache.</summary>
		public void ClearCache()
		{
			_haContext.CallService("tts", "clear_cache", null);
		}

		///<summary>Say something using text-to-speech on a media player with cloud.</summary>
		public void CloudSay(TtsCloudSayParameters data)
		{
			_haContext.CallService("tts", "cloud_say", null, data);
		}

		///<summary>Say something using text-to-speech on a media player with cloud.</summary>
		///<param name="entityId">Name(s) of media player entities.</param>
		///<param name="message">Text to speak on devices. eg: My name is hanna</param>
		///<param name="cache">Control file cache of this message.</param>
		///<param name="language">Language to use for speech generation. eg: ru</param>
		///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
		public void CloudSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
		{
			_haContext.CallService("tts", "cloud_say", null, new TtsCloudSayParameters{EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options});
		}

		///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
		public void GoogleTranslateSay(TtsGoogleTranslateSayParameters data)
		{
			_haContext.CallService("tts", "google_translate_say", null, data);
		}

		///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
		///<param name="entityId">Name(s) of media player entities.</param>
		///<param name="message">Text to speak on devices. eg: My name is hanna</param>
		///<param name="cache">Control file cache of this message.</param>
		///<param name="language">Language to use for speech generation. eg: ru</param>
		///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
		public void GoogleTranslateSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
		{
			_haContext.CallService("tts", "google_translate_say", null, new TtsGoogleTranslateSayParameters{EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options});
		}
	}

	public record TtsCloudSayParameters
	{
		///<summary>Name(s) of media player entities.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Text to speak on devices. eg: My name is hanna</summary>
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Control file cache of this message.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("cache")]
		public bool? Cache { get; init; }

		///<summary>Language to use for speech generation. eg: ru</summary>
		[System.Text.Json.Serialization.JsonPropertyName("language")]
		public string? Language { get; init; }

		///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
		[System.Text.Json.Serialization.JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public record TtsGoogleTranslateSayParameters
	{
		///<summary>Name(s) of media player entities.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Text to speak on devices. eg: My name is hanna</summary>
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Control file cache of this message.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("cache")]
		public bool? Cache { get; init; }

		///<summary>Language to use for speech generation. eg: ru</summary>
		[System.Text.Json.Serialization.JsonPropertyName("language")]
		public string? Language { get; init; }

		///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
		[System.Text.Json.Serialization.JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class VacuumServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public VacuumServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		///<param name="target">The target for this service call</param>
		public void CleanSpot(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "clean_spot", target);
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		///<param name="target">The target for this service call</param>
		public void Locate(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "locate", target);
		}

		///<summary>Pause the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "pause", target);
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		///<param name="target">The target for this service call</param>
		public void ReturnToBase(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "return_to_base", target);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(NetDaemon.HassModel.Entities.ServiceTarget target, VacuumSendCommandParameters data)
		{
			_haContext.CallService("vacuum", "send_command", target, data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public void SendCommand(NetDaemon.HassModel.Entities.ServiceTarget target, string @command, object? @params = null)
		{
			_haContext.CallService("vacuum", "send_command", target, new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanSpeed(NetDaemon.HassModel.Entities.ServiceTarget target, VacuumSetFanSpeedParameters data)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public void SetFanSpeed(NetDaemon.HassModel.Entities.ServiceTarget target, string @fanSpeed)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Start(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start", target);
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void StartPause(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start_pause", target);
		}

		///<summary>Stop the current cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Stop(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "stop", target);
		}

		public void Toggle()
		{
			_haContext.CallService("vacuum", "toggle", null);
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_off", target);
		}

		///<summary>Start a new cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_on", target);
		}
	}

	public record VacuumSendCommandParameters
	{
		///<summary>Command to execute. eg: set_dnd_timer</summary>
		[System.Text.Json.Serialization.JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>Parameters for the command. eg: { "key": "value" }</summary>
		[System.Text.Json.Serialization.JsonPropertyName("params")]
		public object? Params { get; init; }
	}

	public record VacuumSetFanSpeedParameters
	{
		///<summary>Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</summary>
		[System.Text.Json.Serialization.JsonPropertyName("fan_speed")]
		public string? FanSpeed { get; init; }
	}

	public class ZoneServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ZoneServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the YAML-based zone configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("zone", "reload", null);
		}
	}

	public static class AutomationEntityExtensionMethods
	{
		///<summary>Toggle (enable / disable) an automation.</summary>
		public static void Toggle(this AutomationEntity entity)
		{
			entity.CallService("toggle");
		}

		///<summary>Trigger the actions of an automation.</summary>
		public static void Trigger(this AutomationEntity entity, AutomationTriggerParameters data)
		{
			entity.CallService("trigger", data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="entity">The AutomationEntity to call this service for</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public static void Trigger(this AutomationEntity entity, bool? @skipCondition = null)
		{
			entity.CallService("trigger", new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		public static void TurnOff(this AutomationEntity entity, AutomationTurnOffParameters data)
		{
			entity.CallService("turn_off", data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="entity">The AutomationEntity to call this service for</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public static void TurnOff(this AutomationEntity entity, bool? @stopActions = null)
		{
			entity.CallService("turn_off", new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		public static void TurnOn(this AutomationEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class CameraEntityExtensionMethods
	{
		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this CameraEntity entity)
		{
			entity.CallService("disable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this CameraEntity entity)
		{
			entity.CallService("enable_motion_detection");
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this CameraEntity entity, CameraPlayStreamParameters data)
		{
			entity.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="entity">The CameraEntity to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this CameraEntity entity, string @mediaPlayer, string? @format = null)
		{
			entity.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this CameraEntity entity, CameraRecordParameters data)
		{
			entity.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="entity">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this CameraEntity entity, string @filename, long? @duration = null, long? @lookback = null)
		{
			entity.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this CameraEntity entity, CameraSnapshotParameters data)
		{
			entity.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="entity">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this CameraEntity entity, string @filename)
		{
			entity.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this CameraEntity entity)
		{
			entity.CallService("turn_off");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this CameraEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class ClimateEntityExtensionMethods
	{
		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this ClimateEntity entity, ClimateSetAuxHeatParameters data)
		{
			entity.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="entity">The ClimateEntity to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this ClimateEntity entity, bool @auxHeat)
		{
			entity.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this ClimateEntity entity, ClimateSetFanModeParameters data)
		{
			entity.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="entity">The ClimateEntity to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this ClimateEntity entity, string @fanMode)
		{
			entity.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this ClimateEntity entity, ClimateSetHumidityParameters data)
		{
			entity.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="entity">The ClimateEntity to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this ClimateEntity entity, long @humidity)
		{
			entity.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this ClimateEntity entity, ClimateSetHvacModeParameters data)
		{
			entity.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="entity">The ClimateEntity to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this ClimateEntity entity, string? @hvacMode = null)
		{
			entity.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this ClimateEntity entity, ClimateSetPresetModeParameters data)
		{
			entity.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="entity">The ClimateEntity to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this ClimateEntity entity, string @presetMode)
		{
			entity.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this ClimateEntity entity, ClimateSetSwingModeParameters data)
		{
			entity.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="entity">The ClimateEntity to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this ClimateEntity entity, string @swingMode)
		{
			entity.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this ClimateEntity entity, ClimateSetTemperatureParameters data)
		{
			entity.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="entity">The ClimateEntity to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this ClimateEntity entity, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, string? @hvacMode = null)
		{
			entity.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this ClimateEntity entity)
		{
			entity.CallService("turn_off");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this ClimateEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class CoverEntityExtensionMethods
	{
		///<summary>Close all or specified cover.</summary>
		public static void CloseCover(this CoverEntity entity)
		{
			entity.CallService("close_cover");
		}

		///<summary>Close all or specified cover tilt.</summary>
		public static void CloseCoverTilt(this CoverEntity entity)
		{
			entity.CallService("close_cover_tilt");
		}

		///<summary>Open all or specified cover.</summary>
		public static void OpenCover(this CoverEntity entity)
		{
			entity.CallService("open_cover");
		}

		///<summary>Open all or specified cover tilt.</summary>
		public static void OpenCoverTilt(this CoverEntity entity)
		{
			entity.CallService("open_cover_tilt");
		}

		///<summary>Move to specific position all or specified cover.</summary>
		public static void SetCoverPosition(this CoverEntity entity, CoverSetCoverPositionParameters data)
		{
			entity.CallService("set_cover_position", data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="entity">The CoverEntity to call this service for</param>
		///<param name="position">Position of the cover</param>
		public static void SetCoverPosition(this CoverEntity entity, long @position)
		{
			entity.CallService("set_cover_position", new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		public static void SetCoverTiltPosition(this CoverEntity entity, CoverSetCoverTiltPositionParameters data)
		{
			entity.CallService("set_cover_tilt_position", data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="entity">The CoverEntity to call this service for</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public static void SetCoverTiltPosition(this CoverEntity entity, long @tiltPosition)
		{
			entity.CallService("set_cover_tilt_position", new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCover(this CoverEntity entity)
		{
			entity.CallService("stop_cover");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCoverTilt(this CoverEntity entity)
		{
			entity.CallService("stop_cover_tilt");
		}

		///<summary>Toggle a cover open/closed.</summary>
		public static void Toggle(this CoverEntity entity)
		{
			entity.CallService("toggle");
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		public static void ToggleCoverTilt(this CoverEntity entity)
		{
			entity.CallService("toggle_cover_tilt");
		}
	}

	public static class HiveEntityExtensionMethods
	{
		///<summary>To be deprecated please use boost_heating_on.</summary>
		public static void BoostHeating(this ClimateEntity entity, HiveBoostHeatingParameters data)
		{
			entity.CallService("boost_heating", data);
		}

		///<summary>To be deprecated please use boost_heating_on.</summary>
		///<param name="entity">The ClimateEntity to call this service for</param>
		///<param name="timePeriod">Set the time period for the boost. eg: 01:30:00</param>
		///<param name="temperature">Set the target temperature for the boost period.</param>
		public static void BoostHeating(this ClimateEntity entity, DateTime @timePeriod, double? @temperature = null)
		{
			entity.CallService("boost_heating", new HiveBoostHeatingParameters{TimePeriod = @timePeriod, Temperature = @temperature});
		}

		///<summary>Set the boost mode ON defining the period of time and the desired target temperature for the boost.</summary>
		public static void BoostHeatingOn(this ClimateEntity entity, HiveBoostHeatingOnParameters data)
		{
			entity.CallService("boost_heating_on", data);
		}

		///<summary>Set the boost mode ON defining the period of time and the desired target temperature for the boost.</summary>
		///<param name="entity">The ClimateEntity to call this service for</param>
		///<param name="timePeriod">Set the time period for the boost. eg: 01:30:00</param>
		///<param name="temperature">Set the target temperature for the boost period.</param>
		public static void BoostHeatingOn(this ClimateEntity entity, DateTime @timePeriod, double? @temperature = null)
		{
			entity.CallService("boost_heating_on", new HiveBoostHeatingOnParameters{TimePeriod = @timePeriod, Temperature = @temperature});
		}
	}

	public static class LightEntityExtensionMethods
	{
		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this LightEntity entity, LightToggleParameters data)
		{
			entity.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="entity">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this LightEntity entity, long? @transition = null, object? @rgbColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			entity.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this LightEntity entity, LightTurnOffParameters data)
		{
			entity.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="entity">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this LightEntity entity, long? @transition = null, string? @flash = null)
		{
			entity.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this LightEntity entity, LightTurnOnParameters data)
		{
			entity.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="entity">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this LightEntity entity, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			entity.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public static class LockEntityExtensionMethods
	{
		///<summary>Lock all or specified locks.</summary>
		public static void Lock(this LockEntity entity, LockLockParameters data)
		{
			entity.CallService("lock", data);
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="entity">The LockEntity to call this service for</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public static void Lock(this LockEntity entity, string? @code = null)
		{
			entity.CallService("lock", new LockLockParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		public static void Open(this LockEntity entity, LockOpenParameters data)
		{
			entity.CallService("open", data);
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="entity">The LockEntity to call this service for</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public static void Open(this LockEntity entity, string? @code = null)
		{
			entity.CallService("open", new LockOpenParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		public static void Unlock(this LockEntity entity, LockUnlockParameters data)
		{
			entity.CallService("unlock", data);
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="entity">The LockEntity to call this service for</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public static void Unlock(this LockEntity entity, string? @code = null)
		{
			entity.CallService("unlock", new LockUnlockParameters{Code = @code});
		}
	}

	public static class MediaPlayerEntityExtensionMethods
	{
		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this MediaPlayerEntity entity)
		{
			entity.CallService("clear_playlist");
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this MediaPlayerEntity entity, MediaPlayerJoinParameters data)
		{
			entity.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="entity">The MediaPlayerEntity to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2", "media_player.multiroom_player3"]</param>
		public static void Join(this MediaPlayerEntity entity, object? @groupMembers = null)
		{
			entity.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this MediaPlayerEntity entity)
		{
			entity.CallService("media_next_track");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this MediaPlayerEntity entity)
		{
			entity.CallService("media_pause");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this MediaPlayerEntity entity)
		{
			entity.CallService("media_play");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this MediaPlayerEntity entity)
		{
			entity.CallService("media_play_pause");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this MediaPlayerEntity entity)
		{
			entity.CallService("media_previous_track");
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this MediaPlayerEntity entity, MediaPlayerMediaSeekParameters data)
		{
			entity.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="entity">The MediaPlayerEntity to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this MediaPlayerEntity entity, double @seekPosition)
		{
			entity.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this MediaPlayerEntity entity)
		{
			entity.CallService("media_stop");
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this MediaPlayerEntity entity, MediaPlayerPlayMediaParameters data)
		{
			entity.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="entity">The MediaPlayerEntity to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		public static void PlayMedia(this MediaPlayerEntity entity, string @mediaContentId, string @mediaContentType)
		{
			entity.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this MediaPlayerEntity entity, MediaPlayerRepeatSetParameters data)
		{
			entity.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="entity">The MediaPlayerEntity to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this MediaPlayerEntity entity, string @repeat)
		{
			entity.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this MediaPlayerEntity entity, MediaPlayerSelectSoundModeParameters data)
		{
			entity.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="entity">The MediaPlayerEntity to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this MediaPlayerEntity entity, string? @soundMode = null)
		{
			entity.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this MediaPlayerEntity entity, MediaPlayerSelectSourceParameters data)
		{
			entity.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="entity">The MediaPlayerEntity to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this MediaPlayerEntity entity, string @source)
		{
			entity.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this MediaPlayerEntity entity, MediaPlayerShuffleSetParameters data)
		{
			entity.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="entity">The MediaPlayerEntity to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this MediaPlayerEntity entity, bool @shuffle)
		{
			entity.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this MediaPlayerEntity entity)
		{
			entity.CallService("toggle");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this MediaPlayerEntity entity)
		{
			entity.CallService("turn_off");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this MediaPlayerEntity entity)
		{
			entity.CallService("turn_on");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this MediaPlayerEntity entity)
		{
			entity.CallService("unjoin");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this MediaPlayerEntity entity)
		{
			entity.CallService("volume_down");
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this MediaPlayerEntity entity, MediaPlayerVolumeMuteParameters data)
		{
			entity.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="entity">The MediaPlayerEntity to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this MediaPlayerEntity entity, bool @isVolumeMuted)
		{
			entity.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this MediaPlayerEntity entity, MediaPlayerVolumeSetParameters data)
		{
			entity.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="entity">The MediaPlayerEntity to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this MediaPlayerEntity entity, double @volumeLevel)
		{
			entity.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this MediaPlayerEntity entity)
		{
			entity.CallService("volume_up");
		}
	}

	public static class ReolinkDevEntityExtensionMethods
	{
		///<summary>Execute a PTZ command.</summary>
		public static void PtzControl(this CameraEntity entity, ReolinkDevPtzControlParameters data)
		{
			entity.CallService("ptz_control", data);
		}

		///<summary>Execute a PTZ command.</summary>
		///<param name="entity">The CameraEntity to call this service for</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="command">Command to execute. Possible values are: AUTO DOWN FOCUSDEC FOCUSINC LEFT LEFTDOWN LEFTUP RIGHT RIGHTDOWN RIGHTUP STOP TOPOS UP ZOOMDEC ZOOMINC eg: LEFTUP</param>
		///<param name="preset">(Optional) In case of the command TOPOS. The available presets are listed as attribute on the camera. eg: HOME</param>
		///<param name="speed">(Optional) Speed at which the movement takes place. eg: 25</param>
		public static void PtzControl(this CameraEntity entity, string? @entityId = null, string? @command = null, string? @preset = null, string? @speed = null)
		{
			entity.CallService("ptz_control", new ReolinkDevPtzControlParameters{EntityId = @entityId, Command = @command, Preset = @preset, Speed = @speed});
		}

		///<summary>For cameras that have Video-On-Demand Playback capability, this will query the camera and emit an reolink_dev-vod-data event for each matching VoD that matches the search parameters, it will also provide the thumbail path for the expected thumbnail.</summary>
		public static void QueryVods(this CameraEntity entity, ReolinkDevQueryVodsParameters data)
		{
			entity.CallService("query_vods", data);
		}

		///<summary>For cameras that have Video-On-Demand Playback capability, this will query the camera and emit an reolink_dev-vod-data event for each matching VoD that matches the search parameters, it will also provide the thumbail path for the expected thumbnail.</summary>
		///<param name="entity">The CameraEntity to call this service for</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="eventId">Event to emit as eg: VoD-query</param>
		///<param name="start">Start of date range, if not provided will use the month playback range eg: 1/1/2021</param>
		///<param name="end">End of date range, if not provided will use the current date and time eg: 1/31/2021</param>
		public static void QueryVods(this CameraEntity entity, string? @entityId = null, string? @eventId = null, string? @start = null, string? @end = null)
		{
			entity.CallService("query_vods", new ReolinkDevQueryVodsParameters{EntityId = @entityId, EventId = @eventId, Start = @start, End = @end});
		}

		///<summary>Optimizing brightness and contrast levels to compensate for differences between dark and bright objects using either BLC or WDR mode. This may improve image clarity in high contrast situations, but it should be tested at different times of the day and night to ensure there is no negative effect.</summary>
		public static void SetBacklight(this CameraEntity entity, ReolinkDevSetBacklightParameters data)
		{
			entity.CallService("set_backlight", data);
		}

		///<summary>Optimizing brightness and contrast levels to compensate for differences between dark and bright objects using either BLC or WDR mode. This may improve image clarity in high contrast situations, but it should be tested at different times of the day and night to ensure there is no negative effect.</summary>
		///<param name="entity">The CameraEntity to call this service for</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="mode">The backlight parameter supports the following values:   BACKLIGHTCONTROL: use Backlight Control   DYNAMICRANGECONTROL: use Dynamic Range Control   OFF: no optimization eg: DYNAMICRANGECONTROL</param>
		public static void SetBacklight(this CameraEntity entity, string? @entityId = null, string? @mode = null)
		{
			entity.CallService("set_backlight", new ReolinkDevSetBacklightParameters{EntityId = @entityId, Mode = @mode});
		}

		///<summary>Set day and night parameter.</summary>
		public static void SetDaynight(this CameraEntity entity, ReolinkDevSetDaynightParameters data)
		{
			entity.CallService("set_daynight", data);
		}

		///<summary>Set day and night parameter.</summary>
		///<param name="entity">The CameraEntity to call this service for</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="mode">The day and night mode parameter supports the following values:   AUTO: Auto switch between black & white mode   COLOR: Always record videos in color mode   BLACKANDWHITE: Always record videos in black & white mode eg: AUTO</param>
		public static void SetDaynight(this CameraEntity entity, string? @entityId = null, string? @mode = null)
		{
			entity.CallService("set_daynight", new ReolinkDevSetDaynightParameters{EntityId = @entityId, Mode = @mode});
		}

		///<summary>Set the motion detection sensitivity.</summary>
		public static void SetSensitivity(this CameraEntity entity, ReolinkDevSetSensitivityParameters data)
		{
			entity.CallService("set_sensitivity", data);
		}

		///<summary>Set the motion detection sensitivity.</summary>
		///<param name="entity">The CameraEntity to call this service for</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="sensitivity">New sensitivity, value between 1 (low sensitivity) and 50 (high sensitivity) eg: 25</param>
		///<param name="preset">(Optional) Set the sensitivity of a specific preset (time schedule). When no value is supplied, all presets will be changed.</param>
		public static void SetSensitivity(this CameraEntity entity, string? @entityId = null, string? @sensitivity = null, string? @preset = null)
		{
			entity.CallService("set_sensitivity", new ReolinkDevSetSensitivityParameters{EntityId = @entityId, Sensitivity = @sensitivity, Preset = @preset});
		}
	}

	public static class SceneEntityExtensionMethods
	{
		///<summary>Activate a scene.</summary>
		public static void TurnOn(this SceneEntity entity, SceneTurnOnParameters data)
		{
			entity.CallService("turn_on", data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="entity">The SceneEntity to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public static void TurnOn(this SceneEntity entity, long? @transition = null)
		{
			entity.CallService("turn_on", new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public static class SwitchEntityExtensionMethods
	{
		///<summary>Toggles a switch state</summary>
		public static void Toggle(this SwitchEntity entity)
		{
			entity.CallService("toggle");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this SwitchEntity entity)
		{
			entity.CallService("turn_off");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this SwitchEntity entity)
		{
			entity.CallService("turn_on");
		}
	}
}