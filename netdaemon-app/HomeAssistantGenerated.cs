using System;
using System.Collections.Generic;
using NetDaemon.HassModel;
using NetDaemon.HassModel.Entities;
using NetDaemon.HassModel.Entities.Core;
using System.Text.Json.Serialization;

namespace HomeAssistantGenerated
{
	public interface IEntities
	{
		AutomationEntities Automation { get; }

		BinarySensorEntities BinarySensor { get; }

		ButtonEntities Button { get; }

		CameraEntities Camera { get; }

		ClimateEntities Climate { get; }

		CoverEntities Cover { get; }

		DeviceTrackerEntities DeviceTracker { get; }

		GroupEntities Group { get; }

		InputBooleanEntities InputBoolean { get; }

		LightEntities Light { get; }

		LockEntities Lock { get; }

		MediaPlayerEntities MediaPlayer { get; }

		NumberEntities Number { get; }

		PersonEntities Person { get; }

		SceneEntities Scene { get; }

		SensorEntities Sensor { get; }

		SunEntities Sun { get; }

		SwitchEntities Switch { get; }

		UpdateEntities Update { get; }

		WeatherEntities Weather { get; }

		ZoneEntities Zone { get; }
	}

	public partial class Entities : IEntities
	{
		private readonly IHaContext _haContext;
		public Entities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AutomationEntities Automation => new(_haContext);
		public BinarySensorEntities BinarySensor => new(_haContext);
		public ButtonEntities Button => new(_haContext);
		public CameraEntities Camera => new(_haContext);
		public ClimateEntities Climate => new(_haContext);
		public CoverEntities Cover => new(_haContext);
		public DeviceTrackerEntities DeviceTracker => new(_haContext);
		public GroupEntities Group => new(_haContext);
		public InputBooleanEntities InputBoolean => new(_haContext);
		public LightEntities Light => new(_haContext);
		public LockEntities Lock => new(_haContext);
		public MediaPlayerEntities MediaPlayer => new(_haContext);
		public NumberEntities Number => new(_haContext);
		public PersonEntities Person => new(_haContext);
		public SceneEntities Scene => new(_haContext);
		public SensorEntities Sensor => new(_haContext);
		public SunEntities Sun => new(_haContext);
		public SwitchEntities Switch => new(_haContext);
		public UpdateEntities Update => new(_haContext);
		public WeatherEntities Weather => new(_haContext);
		public ZoneEntities Zone => new(_haContext);
	}

	public partial class AutomationEntities
	{
		private readonly IHaContext _haContext;
		public AutomationEntities(IHaContext haContext)
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
		///<summary>Set frost sensor</summary>
		public AutomationEntity SetFrostSensor => new(_haContext, "automation.set_frost_sensor");
		///<summary>Turn off lights at midnight</summary>
		public AutomationEntity TurnOffLightsAtMidnight => new(_haContext, "automation.turn_off_lights_at_midnight");
	}

	public partial class BinarySensorEntities
	{
		private readonly IHaContext _haContext;
		public BinarySensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Backups Stale</summary>
		public BinarySensorEntity BackupsStale => new(_haContext, "binary_sensor.backups_stale");
		///<summary>ESPresense Downstairs</summary>
		public BinarySensorEntity EspresenseDownstairs => new(_haContext, "binary_sensor.espresense_downstairs");
		///<summary>ESPresense Scott Office</summary>
		public BinarySensorEntity EspresenseScottOffice => new(_haContext, "binary_sensor.espresense_scott_office");
		///<summary>Front Door contact</summary>
		public BinarySensorEntity FrontDoorContact => new(_haContext, "binary_sensor.front_door_contact");
		///<summary>Front door motion</summary>
		public BinarySensorEntity FrontDoorMotion => new(_haContext, "binary_sensor.front_door_motion");
		///<summary>Front Door tamper</summary>
		public BinarySensorEntity FrontDoorTamper => new(_haContext, "binary_sensor.front_door_tamper");
		///<summary>Frost forecast</summary>
		public BinarySensorEntity FrostForecast => new(_haContext, "binary_sensor.frost_forecast");
		///<summary>Hive Hub Status</summary>
		public BinarySensorEntity HiveHubStatus => new(_haContext, "binary_sensor.hive_hub_status");
		///<summary>Jo's iPhone Focus</summary>
		public BinarySensorEntity JoSIphoneFocus => new(_haContext, "binary_sensor.jo_s_iphone_focus");
		///<summary>Kitchen Door contact</summary>
		public BinarySensorEntity KitchenDoorContact => new(_haContext, "binary_sensor.kitchen_door_contact");
		///<summary>Kitchen Door tamper</summary>
		public BinarySensorEntity KitchenDoorTamper => new(_haContext, "binary_sensor.kitchen_door_tamper");
		///<summary>Remote UI</summary>
		public BinarySensorEntity RemoteUi => new(_haContext, "binary_sensor.remote_ui");
		///<summary>Scott's XR Focus</summary>
		public BinarySensorEntity ScottSXrFocus => new(_haContext, "binary_sensor.scott_s_xr_focus");
		///<summary>Sun Room Door contact</summary>
		public BinarySensorEntity SunRoomDoorContact => new(_haContext, "binary_sensor.sun_room_door_contact");
		///<summary>Sun Room Door tamper</summary>
		public BinarySensorEntity SunRoomDoorTamper => new(_haContext, "binary_sensor.sun_room_door_tamper");
		///<summary>Updater</summary>
		public BinarySensorEntity Updater => new(_haContext, "binary_sensor.updater");
	}

	public partial class ButtonEntities
	{
		private readonly IHaContext _haContext;
		public ButtonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>ESPresense Downstairs Restart</summary>
		public ButtonEntity EspresenseDownstairsRestart => new(_haContext, "button.espresense_downstairs_restart");
		///<summary>ESPresense Scott Office Restart</summary>
		public ButtonEntity EspresenseScottOfficeRestart => new(_haContext, "button.espresense_scott_office_restart");
		///<summary>LG webOS TV BA72 Identify</summary>
		public ButtonEntity LgWebosTvBa72Identify => new(_haContext, "button.lg_webos_tv_ba72_identify");
	}

	public partial class CameraEntities
	{
		private readonly IHaContext _haContext;
		public CameraEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Front door</summary>
		public CameraEntity FrontDoor => new(_haContext, "camera.front_door");
	}

	public partial class ClimateEntities
	{
		private readonly IHaContext _haContext;
		public ClimateEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Thermostat</summary>
		public ClimateEntity Thermostat => new(_haContext, "climate.thermostat");
	}

	public partial class CoverEntities
	{
		private readonly IHaContext _haContext;
		public CoverEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Scott office blind</summary>
		public CoverEntity ScottOffice => new(_haContext, "cover.scott_office");
	}

	public partial class DeviceTrackerEntities
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerEntities(IHaContext haContext)
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

	public partial class GroupEntities
	{
		private readonly IHaContext _haContext;
		public GroupEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Family</summary>
		public GroupEntity Family => new(_haContext, "group.family");
	}

	public partial class InputBooleanEntities
	{
		private readonly IHaContext _haContext;
		public InputBooleanEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>dev_netdaemon_apps_concurrency_test_app</summary>
		public InputBooleanEntity DevNetdaemonAppsConcurrencyTestApp => new(_haContext, "input_boolean.dev_netdaemon_apps_concurrency_test_app");
		///<summary>dev_netdaemon_apps_concurrency_test_app2</summary>
		public InputBooleanEntity DevNetdaemonAppsConcurrencyTestApp2 => new(_haContext, "input_boolean.dev_netdaemon_apps_concurrency_test_app2");
		///<summary>dev_netdaemon_apps_config_app</summary>
		public InputBooleanEntity DevNetdaemonAppsConfigApp => new(_haContext, "input_boolean.dev_netdaemon_apps_config_app");
		///<summary>dev_netdaemon_apps_hello_app</summary>
		public InputBooleanEntity DevNetdaemonAppsHelloApp => new(_haContext, "input_boolean.dev_netdaemon_apps_hello_app");
		///<summary>dev_netdaemon_apps_yaml_app</summary>
		public InputBooleanEntity DevNetdaemonAppsYamlApp => new(_haContext, "input_boolean.dev_netdaemon_apps_yaml_app");
		///<summary>dev_netdaemon_debug_host_apps_extensions_mqtt_entity_manager_app</summary>
		public InputBooleanEntity DevNetdaemonDebugHostAppsExtensionsMqttEntityManagerApp => new(_haContext, "input_boolean.dev_netdaemon_debug_host_apps_extensions_mqtt_entity_manager_app");
		///<summary>dev_netdaemon_debug_host_apps_extensions_mtt_entity_subscription_app</summary>
		public InputBooleanEntity DevNetdaemonDebugHostAppsExtensionsMttEntitySubscriptionApp => new(_haContext, "input_boolean.dev_netdaemon_debug_host_apps_extensions_mtt_entity_subscription_app");
		///<summary>FrostySense</summary>
		public InputBooleanEntity Frostysense => new(_haContext, "input_boolean.frostysense");
		///<summary>netdaemon_daemonapp_apps_scott_home_front_door_locker</summary>
		public InputBooleanEntity NetdaemonDaemonappAppsScottHomeFrontDoorLocker => new(_haContext, "input_boolean.netdaemon_daemonapp_apps_scott_home_front_door_locker");
		///<summary>netdaemon_daemonapp_apps_scott_home_frost_sensor_notifications</summary>
		public InputBooleanEntity NetdaemonDaemonappAppsScottHomeFrostSensorNotifications => new(_haContext, "input_boolean.netdaemon_daemonapp_apps_scott_home_frost_sensor_notifications");
		///<summary>netdaemon_daemonapp_apps_scott_home_ha_services_living_room_lights_service</summary>
		public InputBooleanEntity NetdaemonDaemonappAppsScottHomeHaServicesLivingRoomLightsService => new(_haContext, "input_boolean.netdaemon_daemonapp_apps_scott_home_ha_services_living_room_lights_service");
		///<summary>netdaemon_daemonapp_apps_scott_home_ha_services_mqtt_delete_debug_entities_service</summary>
		public InputBooleanEntity NetdaemonDaemonappAppsScottHomeHaServicesMqttDeleteDebugEntitiesService => new(_haContext, "input_boolean.netdaemon_daemonapp_apps_scott_home_ha_services_mqtt_delete_debug_entities_service");
		///<summary>netdaemon_daemonapp_apps_scott_home_ha_services_set_frost_expected_sensor_service</summary>
		public InputBooleanEntity NetdaemonDaemonappAppsScottHomeHaServicesSetFrostExpectedSensorService => new(_haContext, "input_boolean.netdaemon_daemonapp_apps_scott_home_ha_services_set_frost_expected_sensor_service");
		///<summary>netdaemon_daemonapp_apps_scott_home_ha_services_tides_fetcher_service</summary>
		public InputBooleanEntity NetdaemonDaemonappAppsScottHomeHaServicesTidesFetcherService => new(_haContext, "input_boolean.netdaemon_daemonapp_apps_scott_home_ha_services_tides_fetcher_service");
		///<summary>netdaemon_daemonapp_apps_scott_home_heating_based_on_presence</summary>
		public InputBooleanEntity NetdaemonDaemonappAppsScottHomeHeatingBasedOnPresence => new(_haContext, "input_boolean.netdaemon_daemonapp_apps_scott_home_heating_based_on_presence");
		///<summary>netdaemon_daemonapp_apps_scott_home_person_home_updater</summary>
		public InputBooleanEntity NetdaemonDaemonappAppsScottHomePersonHomeUpdater => new(_haContext, "input_boolean.netdaemon_daemonapp_apps_scott_home_person_home_updater");
	}

	public partial class LightEntities
	{
		private readonly IHaContext _haContext;
		public LightEntities(IHaContext haContext)
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
		///<summary>On air lamp</summary>
		public LightEntity OnAirLamp => new(_haContext, "light.on_air_lamp");
		///<summary>Parents</summary>
		public LightEntity Parents => new(_haContext, "light.parents");
		///<summary>Scott's lamp</summary>
		public LightEntity ScottSLamp => new(_haContext, "light.scott_s_lamp");
		///<summary>Studio light</summary>
		public LightEntity StudioLight => new(_haContext, "light.studio_light");
		///<summary>Theo</summary>
		public LightEntity Theo => new(_haContext, "light.theo");
		///<summary>Z-Wave Extender</summary>
		public LightEntity ZWaveExtender => new(_haContext, "light.z_wave_extender");
	}

	public partial class LockEntities
	{
		private readonly IHaContext _haContext;
		public LockEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Front Door Lock</summary>
		public LockEntity FrontDoorLock => new(_haContext, "lock.front_door_lock");
	}

	public partial class MediaPlayerEntities
	{
		private readonly IHaContext _haContext;
		public MediaPlayerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Everywhere</summary>
		public MediaPlayerEntity Everywhere => new(_haContext, "media_player.everywhere");
		///<summary>Fire TV</summary>
		public MediaPlayerEntity FireTv => new(_haContext, "media_player.fire_tv");
		///<summary>Garage echo dot</summary>
		public MediaPlayerEntity GarageEchoDot => new(_haContext, "media_player.garage_echo_dot");
		///<summary>Jo's echo</summary>
		public MediaPlayerEntity JoSEcho => new(_haContext, "media_player.jo_s_echo");
		///<summary>Kitchen echo</summary>
		public MediaPlayerEntity KitchenEcho => new(_haContext, "media_player.kitchen_echo");
		///<summary>LG webOS TV BA72</summary>
		public MediaPlayerEntity LgWebosTvBa72 => new(_haContext, "media_player.lg_webos_tv_ba72");
		///<summary>[LG] webOS TV OLED55A16LA</summary>
		public MediaPlayerEntity LgWebosTvOled55a16la => new(_haContext, "media_player.lg_webos_tv_oled55a16la");
		///<summary>Parents room echo</summary>
		public MediaPlayerEntity ScottS2ndEchoDot => new(_haContext, "media_player.scott_s_2nd_echo_dot");
		///<summary>Scott's 3rd Fire</summary>
		public MediaPlayerEntity ScottS3rdFire => new(_haContext, "media_player.scott_s_3rd_fire");
		///<summary>Scott's Echo Show</summary>
		public MediaPlayerEntity ScottSEchoShow => new(_haContext, "media_player.scott_s_echo_show");
		///<summary>Scott's FireTVStick</summary>
		public MediaPlayerEntity ScottSFiretvstick => new(_haContext, "media_player.scott_s_firetvstick");
		///<summary>Sunroom Echo Dot</summary>
		public MediaPlayerEntity SunroomEchoDot => new(_haContext, "media_player.sunroom_echo_dot");
		///<summary>Theo's Echo</summary>
		public MediaPlayerEntity TheoSEcho => new(_haContext, "media_player.theo_s_echo");
		///<summary>TV home connect</summary>
		public MediaPlayerEntity TvHomeConnect => new(_haContext, "media_player.tv_home_connect");
		///<summary>XboxOne</summary>
		public MediaPlayerEntity Xboxone => new(_haContext, "media_player.xboxone");
	}

	public partial class NumberEntities
	{
		private readonly IHaContext _haContext;
		public NumberEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>ESPresense Downstairs Absorption</summary>
		public NumberEntity EspresenseDownstairsAbsorption => new(_haContext, "number.espresense_downstairs_absorption");
		///<summary>ESPresense Downstairs Max Distance</summary>
		public NumberEntity EspresenseDownstairsMaxDistance => new(_haContext, "number.espresense_downstairs_max_distance");
		///<summary>ESPresense Scott Office Absorption</summary>
		public NumberEntity EspresenseScottOfficeAbsorption => new(_haContext, "number.espresense_scott_office_absorption");
		///<summary>ESPresense Scott Office Max Distance</summary>
		public NumberEntity EspresenseScottOfficeMaxDistance => new(_haContext, "number.espresense_scott_office_max_distance");
	}

	public partial class PersonEntities
	{
		private readonly IHaContext _haContext;
		public PersonEntities(IHaContext haContext)
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

	public partial class SceneEntities
	{
		private readonly IHaContext _haContext;
		public SceneEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Living room - Dog sleep</summary>
		public SceneEntity DogLights => new(_haContext, "scene.dog_lights");
		///<summary>Goodbye!</summary>
		public SceneEntity Goodbye => new(_haContext, "scene.goodbye");
		///<summary>I'm Back!</summary>
		public SceneEntity IMBack => new(_haContext, "scene.i_m_back");
		///<summary>Living room - all off</summary>
		public SceneEntity LivingRoomAllOff => new(_haContext, "scene.living_room_all_off");
		///<summary>Living room - bright</summary>
		public SceneEntity LivingRoomBright2 => new(_haContext, "scene.living_room_bright_2");
		///<summary>Living room Nightlight</summary>
		public SceneEntity LivingRoomNightlight => new(_haContext, "scene.living_room_nightlight");
		///<summary>Living room Relax</summary>
		public SceneEntity LivingRoomRelax => new(_haContext, "scene.living_room_relax");
		///<summary>Parents room Bright</summary>
		public SceneEntity ParentsRoomBright => new(_haContext, "scene.parents_room_bright");
		///<summary>Parents room Dimmed</summary>
		public SceneEntity ParentsRoomDimmed => new(_haContext, "scene.parents_room_dimmed");
		///<summary>Parents room Nightlight</summary>
		public SceneEntity ParentsRoomNightlight => new(_haContext, "scene.parents_room_nightlight");
		///<summary>Theo’s room Arctic aurora</summary>
		public SceneEntity TheosRoomArcticAurora => new(_haContext, "scene.theos_room_arctic_aurora");
		///<summary>Theo’s room Bright</summary>
		public SceneEntity TheosRoomBright => new(_haContext, "scene.theos_room_bright");
		///<summary>Theo’s room Concentrate</summary>
		public SceneEntity TheosRoomConcentrate => new(_haContext, "scene.theos_room_concentrate");
		///<summary>Theo’s room Dimmed</summary>
		public SceneEntity TheosRoomDimmed => new(_haContext, "scene.theos_room_dimmed");
		///<summary>Theo’s room Energize</summary>
		public SceneEntity TheosRoomEnergize => new(_haContext, "scene.theos_room_energize");
		///<summary>Theo’s room Nightlight</summary>
		public SceneEntity TheosRoomNightlight => new(_haContext, "scene.theos_room_nightlight");
		///<summary>Theo’s room Read</summary>
		public SceneEntity TheosRoomRead => new(_haContext, "scene.theos_room_read");
		///<summary>Theo’s room Relax</summary>
		public SceneEntity TheosRoomRelax => new(_haContext, "scene.theos_room_relax");
		///<summary>Theo’s room Savanna sunset</summary>
		public SceneEntity TheosRoomSavannaSunset => new(_haContext, "scene.theos_room_savanna_sunset");
		///<summary>Theo’s room Spring blossom</summary>
		public SceneEntity TheosRoomSpringBlossom => new(_haContext, "scene.theos_room_spring_blossom");
		///<summary>Theo’s room Tropical twilight</summary>
		public SceneEntity TheosRoomTropicalTwilight => new(_haContext, "scene.theos_room_tropical_twilight");
		///<summary>Living room - Watching TV</summary>
		public SceneEntity WatchingTv => new(_haContext, "scene.watching_tv");
	}

	public partial class SensorEntities
	{
		private readonly IHaContext _haContext;
		public SensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>ADS1115 Channel A0-GND</summary>
		public NumericSensorEntity Ads1115ChannelA0Gnd => new(_haContext, "sensor.ads1115_channel_a0_gnd");
		///<summary>Camera FTP</summary>
		public NumericSensorEntity CameraFtp => new(_haContext, "sensor.camera_ftp");
		///<summary>CPU Temperature</summary>
		public NumericSensorEntity CpuTemperature => new(_haContext, "sensor.cpu_temperature");
		///<summary>current</summary>
		public NumericSensorEntity Current => new(_haContext, "sensor.current");
		///<summary>ESPresense Downstairs Free Mem</summary>
		public NumericSensorEntity EspresenseDownstairsFreeMem => new(_haContext, "sensor.espresense_downstairs_free_mem");
		///<summary>ESPresense Downstairs Uptime</summary>
		public NumericSensorEntity EspresenseDownstairsUptime => new(_haContext, "sensor.espresense_downstairs_uptime");
		///<summary>ESPresense Scott Office Free Mem</summary>
		public NumericSensorEntity EspresenseScottOfficeFreeMem => new(_haContext, "sensor.espresense_scott_office_free_mem");
		///<summary>ESPresense Scott Office Uptime</summary>
		public NumericSensorEntity EspresenseScottOfficeUptime => new(_haContext, "sensor.espresense_scott_office_uptime");
		///<summary>Front Door Battery</summary>
		public NumericSensorEntity FrontDoorBattery => new(_haContext, "sensor.front_door_battery");
		///<summary>Front Door Lock Battery</summary>
		public NumericSensorEntity FrontDoorLockBattery => new(_haContext, "sensor.front_door_lock_battery");
		///<summary>garage motion Battery</summary>
		public NumericSensorEntity GarageMotionBattery => new(_haContext, "sensor.garage_motion_battery");
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
		///<summary>Measured Current</summary>
		public NumericSensorEntity MeasuredCurrent => new(_haContext, "sensor.measured_current");
		///<summary>Memory free</summary>
		public NumericSensorEntity MemoryFree => new(_haContext, "sensor.memory_free");
		///<summary>Parents switch Battery</summary>
		public NumericSensorEntity ParentsSwitchBatteryLevel => new(_haContext, "sensor.parents_switch_battery_level");
		///<summary>power</summary>
		public NumericSensorEntity Power => new(_haContext, "sensor.power");
		///<summary>Processor use</summary>
		public NumericSensorEntity ProcessorUse => new(_haContext, "sensor.processor_use");
		///<summary>Queensferry (Edinburgh) Probability of Precipitation 3-Hourly</summary>
		public NumericSensorEntity QueensferryEdinburghProbabilityOfPrecipitation3Hourly => new(_haContext, "sensor.queensferry_edinburgh_probability_of_precipitation_3_hourly");
		///<summary>Queensferry (Edinburgh) Temperature 3-Hourly</summary>
		public NumericSensorEntity QueensferryEdinburghTemperature3Hourly => new(_haContext, "sensor.queensferry_edinburgh_temperature_3_hourly");
		///<summary>Queensferry (Edinburgh) UV Index 3-Hourly</summary>
		public NumericSensorEntity QueensferryEdinburghUvIndex3Hourly => new(_haContext, "sensor.queensferry_edinburgh_uv_index_3_hourly");
		///<summary>Queensferry (Edinburgh) Wind Speed 3-Hourly</summary>
		public NumericSensorEntity QueensferryEdinburghWindSpeed3Hourly => new(_haContext, "sensor.queensferry_edinburgh_wind_speed_3_hourly");
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
		///<summary>Thermostat Battery Level</summary>
		public NumericSensorEntity ThermostatBatteryLevel => new(_haContext, "sensor.thermostat_battery_level");
		///<summary>Backup State</summary>
		public SensorEntity BackupState => new(_haContext, "sensor.backup_state");
		///<summary>Fire TV next Alarm</summary>
		public SensorEntity FireTvNextAlarm => new(_haContext, "sensor.fire_tv_next_alarm");
		///<summary>Fire TV next Reminder</summary>
		public SensorEntity FireTvNextReminder => new(_haContext, "sensor.fire_tv_next_reminder");
		///<summary>Fire TV next Timer</summary>
		public SensorEntity FireTvNextTimer => new(_haContext, "sensor.fire_tv_next_timer");
		///<summary>Garage echo dot next Alarm</summary>
		public SensorEntity GarageEchoDotNextAlarm => new(_haContext, "sensor.garage_echo_dot_next_alarm");
		///<summary>Garage echo dot next Reminder</summary>
		public SensorEntity GarageEchoDotNextReminder => new(_haContext, "sensor.garage_echo_dot_next_reminder");
		///<summary>Garage echo dot next Timer</summary>
		public SensorEntity GarageEchoDotNextTimer => new(_haContext, "sensor.garage_echo_dot_next_timer");
		///<summary>hacs</summary>
		public SensorEntity Hacs => new(_haContext, "sensor.hacs");
		///<summary>Home occupancy</summary>
		public SensorEntity HomeOccupancy => new(_haContext, "sensor.home_occupancy");
		///<summary>HP ENVY 4520 series</summary>
		public SensorEntity HpEnvy4520Series => new(_haContext, "sensor.hp_envy_4520_series");
		///<summary>Jo's echo next Alarm</summary>
		public SensorEntity JoSEchoNextAlarm => new(_haContext, "sensor.jo_s_echo_next_alarm");
		///<summary>Jo's echo next Reminder</summary>
		public SensorEntity JoSEchoNextReminder => new(_haContext, "sensor.jo_s_echo_next_reminder");
		///<summary>Jo's echo next Timer</summary>
		public SensorEntity JoSEchoNextTimer => new(_haContext, "sensor.jo_s_echo_next_timer");
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
		///<summary>Kitchen echo next Alarm</summary>
		public SensorEntity KitchenEchoNextAlarm => new(_haContext, "sensor.kitchen_echo_next_alarm");
		///<summary>Kitchen echo next Reminder</summary>
		public SensorEntity KitchenEchoNextReminder => new(_haContext, "sensor.kitchen_echo_next_reminder");
		///<summary>Kitchen echo next Timer</summary>
		public SensorEntity KitchenEchoNextTimer => new(_haContext, "sensor.kitchen_echo_next_timer");
		///<summary>Leith Tides</summary>
		public SensorEntity LeithTides => new(_haContext, "sensor.leith_tides");
		///<summary>Queensferry (Edinburgh) Weather 3-Hourly</summary>
		public SensorEntity QueensferryEdinburghWeather3Hourly => new(_haContext, "sensor.queensferry_edinburgh_weather_3_hourly");
		///<summary>Scott iPhone</summary>
		public SensorEntity ScottIphone => new(_haContext, "sensor.scott_iphone");
		///<summary>Parents room echo next Alarm</summary>
		public SensorEntity ScottS2ndEchoDotNextAlarm => new(_haContext, "sensor.scott_s_2nd_echo_dot_next_alarm");
		///<summary>Parents room echo next Reminder</summary>
		public SensorEntity ScottS2ndEchoDotNextReminder => new(_haContext, "sensor.scott_s_2nd_echo_dot_next_reminder");
		///<summary>Parents room echo next Timer</summary>
		public SensorEntity ScottS2ndEchoDotNextTimer => new(_haContext, "sensor.scott_s_2nd_echo_dot_next_timer");
		///<summary>Scott's 3rd Fire next Alarm</summary>
		public SensorEntity ScottS3rdFireNextAlarm => new(_haContext, "sensor.scott_s_3rd_fire_next_alarm");
		///<summary>Scott's 3rd Fire next Reminder</summary>
		public SensorEntity ScottS3rdFireNextReminder => new(_haContext, "sensor.scott_s_3rd_fire_next_reminder");
		///<summary>Scott's 3rd Fire next Timer</summary>
		public SensorEntity ScottS3rdFireNextTimer => new(_haContext, "sensor.scott_s_3rd_fire_next_timer");
		///<summary>Scott's Echo Show next Alarm</summary>
		public SensorEntity ScottSEchoShowNextAlarm => new(_haContext, "sensor.scott_s_echo_show_next_alarm");
		///<summary>Scott's Echo Show next Reminder</summary>
		public SensorEntity ScottSEchoShowNextReminder => new(_haContext, "sensor.scott_s_echo_show_next_reminder");
		///<summary>Scott's Echo Show next Timer</summary>
		public SensorEntity ScottSEchoShowNextTimer => new(_haContext, "sensor.scott_s_echo_show_next_timer");
		///<summary>Scott's FireTVStick next Alarm</summary>
		public SensorEntity ScottSFiretvstickNextAlarm => new(_haContext, "sensor.scott_s_firetvstick_next_alarm");
		///<summary>Scott's FireTVStick next Reminder</summary>
		public SensorEntity ScottSFiretvstickNextReminder => new(_haContext, "sensor.scott_s_firetvstick_next_reminder");
		///<summary>Scott's FireTVStick next Timer</summary>
		public SensorEntity ScottSFiretvstickNextTimer => new(_haContext, "sensor.scott_s_firetvstick_next_timer");
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
		///<summary>Sunroom Echo Dot next Alarm</summary>
		public SensorEntity SunroomEchoDotNextAlarm => new(_haContext, "sensor.sunroom_echo_dot_next_alarm");
		///<summary>Sunroom Echo Dot next Reminder</summary>
		public SensorEntity SunroomEchoDotNextReminder => new(_haContext, "sensor.sunroom_echo_dot_next_reminder");
		///<summary>Sunroom Echo Dot next Timer</summary>
		public SensorEntity SunroomEchoDotNextTimer => new(_haContext, "sensor.sunroom_echo_dot_next_timer");
		///<summary>Theo's Echo next Alarm</summary>
		public SensorEntity TheoSEchoNextAlarm => new(_haContext, "sensor.theo_s_echo_next_alarm");
		///<summary>Theo's Echo next Reminder</summary>
		public SensorEntity TheoSEchoNextReminder => new(_haContext, "sensor.theo_s_echo_next_reminder");
		///<summary>Theo's Echo next Timer</summary>
		public SensorEntity TheoSEchoNextTimer => new(_haContext, "sensor.theo_s_echo_next_timer");
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
		///<summary>TV home connect next Alarm</summary>
		public SensorEntity TvHomeConnectNextAlarm => new(_haContext, "sensor.tv_home_connect_next_alarm");
		///<summary>TV home connect next Reminder</summary>
		public SensorEntity TvHomeConnectNextReminder => new(_haContext, "sensor.tv_home_connect_next_reminder");
		///<summary>TV home connect next Timer</summary>
		public SensorEntity TvHomeConnectNextTimer => new(_haContext, "sensor.tv_home_connect_next_timer");
	}

	public partial class SunEntities
	{
		private readonly IHaContext _haContext;
		public SunEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sun</summary>
		public SunEntity Sun => new(_haContext, "sun.sun");
	}

	public partial class SwitchEntities
	{
		private readonly IHaContext _haContext;
		public SwitchEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>ESPresense Downstairs Active Scan</summary>
		public SwitchEntity EspresenseDownstairsActiveScan => new(_haContext, "switch.espresense_downstairs_active_scan");
		///<summary>ESPresense Downstairs Arduino OTA</summary>
		public SwitchEntity EspresenseDownstairsArduinoOta => new(_haContext, "switch.espresense_downstairs_arduino_ota");
		///<summary>ESPresense Downstairs Auto Update</summary>
		public SwitchEntity EspresenseDownstairsAutoUpdate => new(_haContext, "switch.espresense_downstairs_auto_update");
		///<summary>ESPresense Downstairs OTA Update</summary>
		public SwitchEntity EspresenseDownstairsOtaUpdate => new(_haContext, "switch.espresense_downstairs_ota_update");
		///<summary>ESPresense Downstairs Prerelease</summary>
		public SwitchEntity EspresenseDownstairsPrerelease => new(_haContext, "switch.espresense_downstairs_prerelease");
		///<summary>ESPresense Downstairs Status LED</summary>
		public SwitchEntity EspresenseDownstairsStatusLed => new(_haContext, "switch.espresense_downstairs_status_led");
		///<summary>ESPresense Scott Office Active Scan</summary>
		public SwitchEntity EspresenseScottOfficeActiveScan => new(_haContext, "switch.espresense_scott_office_active_scan");
		///<summary>ESPresense Scott Office Arduino OTA</summary>
		public SwitchEntity EspresenseScottOfficeArduinoOta => new(_haContext, "switch.espresense_scott_office_arduino_ota");
		///<summary>ESPresense Scott Office Auto Update</summary>
		public SwitchEntity EspresenseScottOfficeAutoUpdate => new(_haContext, "switch.espresense_scott_office_auto_update");
		///<summary>ESPresense Scott Office OTA Update</summary>
		public SwitchEntity EspresenseScottOfficeOtaUpdate => new(_haContext, "switch.espresense_scott_office_ota_update");
		///<summary>ESPresense Scott Office Prerelease</summary>
		public SwitchEntity EspresenseScottOfficePrerelease => new(_haContext, "switch.espresense_scott_office_prerelease");
		///<summary>ESPresense Scott Office Status LED</summary>
		public SwitchEntity EspresenseScottOfficeStatusLed => new(_haContext, "switch.espresense_scott_office_status_led");
		///<summary>Everywhere do not disturb switch</summary>
		public SwitchEntity EverywhereDoNotDisturbSwitch => new(_haContext, "switch.everywhere_do_not_disturb_switch");
		///<summary>Everywhere repeat switch</summary>
		public SwitchEntity EverywhereRepeatSwitch => new(_haContext, "switch.everywhere_repeat_switch");
		///<summary>Everywhere shuffle switch</summary>
		public SwitchEntity EverywhereShuffleSwitch => new(_haContext, "switch.everywhere_shuffle_switch");
		///<summary>Fire TV do not disturb switch</summary>
		public SwitchEntity FireTvDoNotDisturbSwitch => new(_haContext, "switch.fire_tv_do_not_disturb_switch");
		///<summary>Front door email</summary>
		public SwitchEntity FrontDoorEmail => new(_haContext, "switch.front_door_email");
		///<summary>Front door FTP</summary>
		public SwitchEntity FrontDoorFtp => new(_haContext, "switch.front_door_ftp");
		///<summary>Front door IR lights</summary>
		public SwitchEntity FrontDoorIrLights => new(_haContext, "switch.front_door_ir_lights");
		///<summary>Front door push notifications</summary>
		public SwitchEntity FrontDoorPushNotifications => new(_haContext, "switch.front_door_push_notifications");
		///<summary>Front door record audio</summary>
		public SwitchEntity FrontDoorRecordAudio => new(_haContext, "switch.front_door_record_audio");
		///<summary>Front door recording</summary>
		public SwitchEntity FrontDoorRecording => new(_haContext, "switch.front_door_recording");
		///<summary>Garage echo dot do not disturb switch</summary>
		public SwitchEntity GarageEchoDotDoNotDisturbSwitch => new(_haContext, "switch.garage_echo_dot_do_not_disturb_switch");
		///<summary>Garage echo dot repeat switch</summary>
		public SwitchEntity GarageEchoDotRepeatSwitch => new(_haContext, "switch.garage_echo_dot_repeat_switch");
		///<summary>Garage echo dot shuffle switch</summary>
		public SwitchEntity GarageEchoDotShuffleSwitch => new(_haContext, "switch.garage_echo_dot_shuffle_switch");
		///<summary>Jo's echo do not disturb switch</summary>
		public SwitchEntity JoSEchoDoNotDisturbSwitch => new(_haContext, "switch.jo_s_echo_do_not_disturb_switch");
		///<summary>Jo's echo repeat switch</summary>
		public SwitchEntity JoSEchoRepeatSwitch => new(_haContext, "switch.jo_s_echo_repeat_switch");
		///<summary>Jo's echo shuffle switch</summary>
		public SwitchEntity JoSEchoShuffleSwitch => new(_haContext, "switch.jo_s_echo_shuffle_switch");
		///<summary>Kitchen echo do not disturb switch</summary>
		public SwitchEntity KitchenEchoDoNotDisturbSwitch => new(_haContext, "switch.kitchen_echo_do_not_disturb_switch");
		///<summary>Kitchen echo repeat switch</summary>
		public SwitchEntity KitchenEchoRepeatSwitch => new(_haContext, "switch.kitchen_echo_repeat_switch");
		///<summary>Kitchen echo shuffle switch</summary>
		public SwitchEntity KitchenEchoShuffleSwitch => new(_haContext, "switch.kitchen_echo_shuffle_switch");
		///<summary>On air lamp</summary>
		public SwitchEntity OnAirLampSocket1 => new(_haContext, "switch.on_air_lamp_socket_1");
		///<summary>Parents room echo do not disturb switch</summary>
		public SwitchEntity ScottS2ndEchoDotDoNotDisturbSwitch => new(_haContext, "switch.scott_s_2nd_echo_dot_do_not_disturb_switch");
		///<summary>Parents room echo repeat switch</summary>
		public SwitchEntity ScottS2ndEchoDotRepeatSwitch => new(_haContext, "switch.scott_s_2nd_echo_dot_repeat_switch");
		///<summary>Parents room echo shuffle switch</summary>
		public SwitchEntity ScottS2ndEchoDotShuffleSwitch => new(_haContext, "switch.scott_s_2nd_echo_dot_shuffle_switch");
		///<summary>Scott's 3rd Fire do not disturb switch</summary>
		public SwitchEntity ScottS3rdFireDoNotDisturbSwitch => new(_haContext, "switch.scott_s_3rd_fire_do_not_disturb_switch");
		///<summary>Scott's Echo Show do not disturb switch</summary>
		public SwitchEntity ScottSEchoShowDoNotDisturbSwitch => new(_haContext, "switch.scott_s_echo_show_do_not_disturb_switch");
		///<summary>Scott's Echo Show repeat switch</summary>
		public SwitchEntity ScottSEchoShowRepeatSwitch => new(_haContext, "switch.scott_s_echo_show_repeat_switch");
		///<summary>Scott's Echo Show shuffle switch</summary>
		public SwitchEntity ScottSEchoShowShuffleSwitch => new(_haContext, "switch.scott_s_echo_show_shuffle_switch");
		///<summary>Scott's FireTVStick do not disturb switch</summary>
		public SwitchEntity ScottSFiretvstickDoNotDisturbSwitch => new(_haContext, "switch.scott_s_firetvstick_do_not_disturb_switch");
		///<summary>Studio light</summary>
		public SwitchEntity StudioLightSocket1 => new(_haContext, "switch.studio_light_socket_1");
		///<summary>Sunroom Echo Dot do not disturb switch</summary>
		public SwitchEntity SunroomEchoDotDoNotDisturbSwitch => new(_haContext, "switch.sunroom_echo_dot_do_not_disturb_switch");
		///<summary>Sunroom Echo Dot repeat switch</summary>
		public SwitchEntity SunroomEchoDotRepeatSwitch => new(_haContext, "switch.sunroom_echo_dot_repeat_switch");
		///<summary>Sunroom Echo Dot shuffle switch</summary>
		public SwitchEntity SunroomEchoDotShuffleSwitch => new(_haContext, "switch.sunroom_echo_dot_shuffle_switch");
		///<summary>Theo's Echo do not disturb switch</summary>
		public SwitchEntity TheoSEchoDoNotDisturbSwitch => new(_haContext, "switch.theo_s_echo_do_not_disturb_switch");
		///<summary>Theo's Echo repeat switch</summary>
		public SwitchEntity TheoSEchoRepeatSwitch => new(_haContext, "switch.theo_s_echo_repeat_switch");
		///<summary>Theo's Echo shuffle switch</summary>
		public SwitchEntity TheoSEchoShuffleSwitch => new(_haContext, "switch.theo_s_echo_shuffle_switch");
		///<summary>Thermostat Heat on Demand</summary>
		public SwitchEntity ThermostatHeatOnDemand => new(_haContext, "switch.thermostat_heat_on_demand");
		///<summary>TV home connect do not disturb switch</summary>
		public SwitchEntity TvHomeConnectDoNotDisturbSwitch => new(_haContext, "switch.tv_home_connect_do_not_disturb_switch");
		///<summary>TV home connect repeat switch</summary>
		public SwitchEntity TvHomeConnectRepeatSwitch => new(_haContext, "switch.tv_home_connect_repeat_switch");
		///<summary>TV home connect shuffle switch</summary>
		public SwitchEntity TvHomeConnectShuffleSwitch => new(_haContext, "switch.tv_home_connect_shuffle_switch");
	}

	public partial class UpdateEntities
	{
		private readonly IHaContext _haContext;
		public UpdateEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>ESPHome: Update</summary>
		public UpdateEntity EsphomeUpdate => new(_haContext, "update.esphome_update");
		///<summary>File editor: Update</summary>
		public UpdateEntity FileEditorUpdate => new(_haContext, "update.file_editor_update");
		///<summary>Home Assistant Core: Update</summary>
		public UpdateEntity HomeAssistantCoreUpdate => new(_haContext, "update.home_assistant_core_update");
		///<summary>Home Assistant Google Drive Backup: Update</summary>
		public UpdateEntity HomeAssistantGoogleDriveBackupUpdate => new(_haContext, "update.home_assistant_google_drive_backup_update");
		///<summary>Home Assistant Operating System: Update</summary>
		public UpdateEntity HomeAssistantOperatingSystemUpdate => new(_haContext, "update.home_assistant_operating_system_update");
		///<summary>Home Assistant Supervisor: Update</summary>
		public UpdateEntity HomeAssistantSupervisorUpdate => new(_haContext, "update.home_assistant_supervisor_update");
		///<summary>MariaDB: Update</summary>
		public UpdateEntity MariadbUpdate => new(_haContext, "update.mariadb_update");
		///<summary>Mosquitto broker: Update</summary>
		public UpdateEntity MosquittoBrokerUpdate => new(_haContext, "update.mosquitto_broker_update");
		///<summary>NetDaemon V3 - beta: Update</summary>
		public UpdateEntity NetdaemonV3BetaUpdate => new(_haContext, "update.netdaemon_v3_beta_update");
		///<summary>Samba share: Update</summary>
		public UpdateEntity SambaShareUpdate => new(_haContext, "update.samba_share_update");
		///<summary>SSH & Web Terminal: Update</summary>
		public UpdateEntity SshWebTerminalUpdate => new(_haContext, "update.ssh_web_terminal_update");
		///<summary>Z-Wave JS: Update</summary>
		public UpdateEntity ZWaveJsUpdate => new(_haContext, "update.z_wave_js_update");
	}

	public partial class WeatherEntities
	{
		private readonly IHaContext _haContext;
		public WeatherEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Met Office Queensferry (Edinburgh) 3-Hourly</summary>
		public WeatherEntity MetOfficeQueensferryEdinburgh3Hourly => new(_haContext, "weather.met_office_queensferry_edinburgh_3_hourly");
		///<summary>Met Office Queensferry (Edinburgh) Daily</summary>
		public WeatherEntity MetOfficeQueensferryEdinburghDaily => new(_haContext, "weather.met_office_queensferry_edinburgh_daily");
	}

	public partial class ZoneEntities
	{
		private readonly IHaContext _haContext;
		public ZoneEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Home</summary>
		public ZoneEntity Home => new(_haContext, "zone.home");
	}

	public partial record AutomationEntity : Entity<AutomationEntity, EntityState<AutomationAttributes>, AutomationAttributes>
	{
		public AutomationEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public AutomationEntity(Entity entity) : base(entity)
		{
		}
	}

	public record AutomationAttributes
	{
		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("last_triggered")]
		public string? LastTriggered { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public partial record BinarySensorEntity : Entity<BinarySensorEntity, EntityState<BinarySensorAttributes>, BinarySensorAttributes>
	{
		public BinarySensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public BinarySensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record BinarySensorAttributes
	{
		[JsonPropertyName("bus_event_id")]
		public string? BusEventId { get; init; }

		[JsonPropertyName("clearDate")]
		public string? ClearDate { get; init; }

		[JsonPropertyName("clearTemp")]
		public double? ClearTemp { get; init; }

		[JsonPropertyName("coldDate")]
		public string? ColdDate { get; init; }

		[JsonPropertyName("coldTemp")]
		public double? ColdTemp { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("updated")]
		public string? Updated { get; init; }
	}

	public partial record ButtonEntity : Entity<ButtonEntity, EntityState<ButtonAttributes>, ButtonAttributes>
	{
		public ButtonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ButtonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ButtonAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }
	}

	public partial record CameraEntity : Entity<CameraEntity, EntityState<CameraAttributes>, CameraAttributes>
	{
		public CameraEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CameraEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CameraAttributes
	{
		[JsonPropertyName("access_token")]
		public string? AccessToken { get; init; }

		[JsonPropertyName("backlight_state")]
		public string? BacklightState { get; init; }

		[JsonPropertyName("daynight_state")]
		public string? DaynightState { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("frontend_stream_type")]
		public string? FrontendStreamType { get; init; }

		[JsonPropertyName("sensitivity")]
		public IReadOnlyList<object>? Sensitivity { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record ClimateEntity : Entity<ClimateEntity, EntityState<ClimateAttributes>, ClimateAttributes>
	{
		public ClimateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ClimateEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ClimateAttributes
	{
		[JsonPropertyName("current_temperature")]
		public double? CurrentTemperature { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hvac_action")]
		public string? HvacAction { get; init; }

		[JsonPropertyName("hvac_modes")]
		public IReadOnlyList<string>? HvacModes { get; init; }

		[JsonPropertyName("max_temp")]
		public double? MaxTemp { get; init; }

		[JsonPropertyName("min_temp")]
		public double? MinTemp { get; init; }

		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }

		[JsonPropertyName("preset_modes")]
		public IReadOnlyList<string>? PresetModes { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }
	}

	public partial record CoverEntity : Entity<CoverEntity, EntityState<CoverAttributes>, CoverAttributes>
	{
		public CoverEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CoverEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CoverAttributes
	{
		[JsonPropertyName("current_position")]
		public double? CurrentPosition { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record DeviceTrackerEntity : Entity<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>, DeviceTrackerAttributes>
	{
		public DeviceTrackerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public DeviceTrackerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record DeviceTrackerAttributes
	{
		[JsonPropertyName("altitude")]
		public double? Altitude { get; init; }

		[JsonPropertyName("battery_level")]
		public double? BatteryLevel { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("source_type")]
		public string? SourceType { get; init; }

		[JsonPropertyName("vertical_accuracy")]
		public double? VerticalAccuracy { get; init; }
	}

	public partial record GroupEntity : Entity<GroupEntity, EntityState<GroupAttributes>, GroupAttributes>
	{
		public GroupEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public GroupEntity(Entity entity) : base(entity)
		{
		}
	}

	public record GroupAttributes
	{
		[JsonPropertyName("entity_id")]
		public IReadOnlyList<string>? EntityId { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("order")]
		public double? Order { get; init; }
	}

	public partial record InputBooleanEntity : Entity<InputBooleanEntity, EntityState<InputBooleanAttributes>, InputBooleanAttributes>
	{
		public InputBooleanEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputBooleanEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputBooleanAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }
	}

	public partial record LightEntity : Entity<LightEntity, EntityState<LightAttributes>, LightAttributes>
	{
		public LightEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LightEntity(Entity entity) : base(entity)
		{
		}
	}

	public record LightAttributes
	{
		[JsonPropertyName("dynamics")]
		public string? Dynamics { get; init; }

		[JsonPropertyName("effect_list")]
		public IReadOnlyList<string>? EffectList { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("max_mireds")]
		public double? MaxMireds { get; init; }

		[JsonPropertyName("min_mireds")]
		public double? MinMireds { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("supported_color_modes")]
		public IReadOnlyList<string>? SupportedColorModes { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record LockEntity : Entity<LockEntity, EntityState<LockAttributes>, LockAttributes>
	{
		public LockEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LockEntity(Entity entity) : base(entity)
		{
		}
	}

	public record LockAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("lock_state")]
		public string? LockState { get; init; }

		[JsonPropertyName("method")]
		public string? Method { get; init; }
	}

	public partial record MediaPlayerEntity : Entity<MediaPlayerEntity, EntityState<MediaPlayerAttributes>, MediaPlayerAttributes>
	{
		public MediaPlayerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public MediaPlayerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record MediaPlayerAttributes
	{
		[JsonPropertyName("assumed_state")]
		public bool? AssumedState { get; init; }

		[JsonPropertyName("available")]
		public bool? Available { get; init; }

		[JsonPropertyName("bluetooth_list")]
		public IReadOnlyList<string>? BluetoothList { get; init; }

		[JsonPropertyName("connected_bluetooth")]
		public object? ConnectedBluetooth { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("entity_picture_local")]
		public string? EntityPictureLocal { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }

		[JsonPropertyName("last_called")]
		public bool? LastCalled { get; init; }

		[JsonPropertyName("last_called_summary")]
		public string? LastCalledSummary { get; init; }

		[JsonPropertyName("last_called_timestamp")]
		public double? LastCalledTimestamp { get; init; }

		[JsonPropertyName("media_album_name")]
		public string? MediaAlbumName { get; init; }

		[JsonPropertyName("media_artist")]
		public string? MediaArtist { get; init; }

		[JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }

		[JsonPropertyName("media_duration")]
		public double? MediaDuration { get; init; }

		[JsonPropertyName("media_position")]
		public double? MediaPosition { get; init; }

		[JsonPropertyName("media_position_updated_at")]
		public string? MediaPositionUpdatedAt { get; init; }

		[JsonPropertyName("media_title")]
		public string? MediaTitle { get; init; }

		[JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("source_list")]
		public IReadOnlyList<string>? SourceList { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public partial record NumberEntity : NumericEntity<NumberEntity, NumericEntityState<NumberAttributes>, NumberAttributes>
	{
		public NumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumberEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumberAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }
	}

	public partial record PersonEntity : Entity<PersonEntity, EntityState<PersonAttributes>, PersonAttributes>
	{
		public PersonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record PersonAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("user_id")]
		public string? UserId { get; init; }
	}

	public partial record SceneEntity : Entity<SceneEntity, EntityState<SceneAttributes>, SceneAttributes>
	{
		public SceneEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SceneEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SceneAttributes
	{
		[JsonPropertyName("brightness")]
		public double? Brightness { get; init; }

		[JsonPropertyName("color")]
		public object? Color { get; init; }

		[JsonPropertyName("entity_id")]
		public IReadOnlyList<string>? EntityId { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("group_name")]
		public string? GroupName { get; init; }

		[JsonPropertyName("group_type")]
		public string? GroupType { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("is_dynamic")]
		public bool? IsDynamic { get; init; }

		[JsonPropertyName("location_id")]
		public string? LocationId { get; init; }

		[JsonPropertyName("name")]
		public string? Name { get; init; }

		[JsonPropertyName("speed")]
		public double? Speed { get; init; }
	}

	public partial record NumericSensorEntity : NumericEntity<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>, NumericSensorAttributes>
	{
		public NumericSensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumericSensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumericSensorAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("Available")]
		public string? Available { get; init; }

		[JsonPropertyName("Available (Important)")]
		public string? AvailableImportant { get; init; }

		[JsonPropertyName("Available (Opportunistic)")]
		public string? AvailableOpportunistic { get; init; }

		[JsonPropertyName("battery_state")]
		public string? BatteryState { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("last_update")]
		public string? LastUpdate { get; init; }

		[JsonPropertyName("marker_high_level")]
		public double? MarkerHighLevel { get; init; }

		[JsonPropertyName("marker_low_level")]
		public double? MarkerLowLevel { get; init; }

		[JsonPropertyName("marker_type")]
		public string? MarkerType { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("sensor_id")]
		public string? SensorId { get; init; }

		[JsonPropertyName("site_id")]
		public string? SiteId { get; init; }

		[JsonPropertyName("site_name")]
		public string? SiteName { get; init; }

		[JsonPropertyName("state_class")]
		public string? StateClass { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("Total")]
		public string? Total { get; init; }

		[JsonPropertyName("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }
	}

	public partial record SensorEntity : Entity<SensorEntity, EntityState<SensorAttributes>, SensorAttributes>
	{
		public SensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SensorAttributes
	{
		[JsonPropertyName("Administrative Area")]
		public string? AdministrativeArea { get; init; }

		[JsonPropertyName("Allows VoIP")]
		public bool? AllowsVoIP { get; init; }

		[JsonPropertyName("Areas Of Interest")]
		public string? AreasOfInterest { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("backups")]
		public IReadOnlyList<object>? Backups { get; init; }

		[JsonPropertyName("backups_in_google_drive")]
		public double? BackupsInGoogleDrive { get; init; }

		[JsonPropertyName("backups_in_home_assistant")]
		public double? BackupsInHomeAssistant { get; init; }

		[JsonPropertyName("Carrier ID")]
		public string? CarrierID { get; init; }

		[JsonPropertyName("Carrier Name")]
		public string? CarrierName { get; init; }

		[JsonPropertyName("Cellular Technology")]
		public string? CellularTechnology { get; init; }

		[JsonPropertyName("command_set")]
		public string? CommandSet { get; init; }

		[JsonPropertyName("Confidence")]
		public string? Confidence { get; init; }

		[JsonPropertyName("Country")]
		public string? Country { get; init; }

		[JsonPropertyName("Current Radio Technology")]
		public string? CurrentRadioTechnology { get; init; }

		[JsonPropertyName("Dates")]
		public IReadOnlyList<string>? Dates { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("dismissed")]
		public object? Dismissed { get; init; }

		[JsonPropertyName("distance")]
		public object? Distance { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("Heights")]
		public IReadOnlyList<double>? Heights { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("info")]
		public string? Info { get; init; }

		[JsonPropertyName("Inland Water")]
		public string? InlandWater { get; init; }

		[JsonPropertyName("ISO Country Code")]
		public string? ISOCountryCode { get; init; }

		[JsonPropertyName("last_backup")]
		public string? LastBackup { get; init; }

		[JsonPropertyName("last_update")]
		public string? LastUpdate { get; init; }

		[JsonPropertyName("last_uploaded")]
		public string? LastUploaded { get; init; }

		[JsonPropertyName("Locality")]
		public string? Locality { get; init; }

		[JsonPropertyName("location")]
		public string? Location_0 { get; init; }

		[JsonPropertyName("Location")]
		public IReadOnlyList<double>? Location_1 { get; init; }

		[JsonPropertyName("Low Power Mode")]
		public bool? LowPowerMode { get; init; }

		[JsonPropertyName("Mobile Country Code")]
		public string? MobileCountryCode { get; init; }

		[JsonPropertyName("Mobile Network Code")]
		public string? MobileNetworkCode { get; init; }

		[JsonPropertyName("Name")]
		public string? Name { get; init; }

		[JsonPropertyName("Ocean")]
		public string? Ocean { get; init; }

		[JsonPropertyName("Postal Code")]
		public string? PostalCode { get; init; }

		[JsonPropertyName("prior_value")]
		public string? PriorValue { get; init; }

		[JsonPropertyName("process_timestamp")]
		public string? ProcessTimestamp { get; init; }

		[JsonPropertyName("recurrence")]
		public object? Recurrence { get; init; }

		[JsonPropertyName("reminder")]
		public object? Reminder { get; init; }

		[JsonPropertyName("repositories")]
		public IReadOnlyList<object>? Repositories { get; init; }

		[JsonPropertyName("sensor_id")]
		public string? SensorId { get; init; }

		[JsonPropertyName("serial")]
		public string? Serial { get; init; }

		[JsonPropertyName("site_id")]
		public string? SiteId { get; init; }

		[JsonPropertyName("site_name")]
		public string? SiteName { get; init; }

		[JsonPropertyName("size_in_google_drive")]
		public string? SizeInGoogleDrive { get; init; }

		[JsonPropertyName("size_in_home_assistant")]
		public string? SizeInHomeAssistant { get; init; }

		[JsonPropertyName("sorted_active")]
		public string? SortedActive { get; init; }

		[JsonPropertyName("sorted_all")]
		public string? SortedAll { get; init; }

		[JsonPropertyName("state_message")]
		public string? StateMessage { get; init; }

		[JsonPropertyName("state_reason")]
		public object? StateReason { get; init; }

		[JsonPropertyName("status")]
		public string? Status { get; init; }

		[JsonPropertyName("Sub Administrative Area")]
		public string? SubAdministrativeArea { get; init; }

		[JsonPropertyName("Sub Locality")]
		public string? SubLocality { get; init; }

		[JsonPropertyName("Sub Thoroughfare")]
		public string? SubThoroughfare { get; init; }

		[JsonPropertyName("Thoroughfare")]
		public string? Thoroughfare { get; init; }

		[JsonPropertyName("Time Zone")]
		public string? TimeZone { get; init; }

		[JsonPropertyName("total_active")]
		public double? TotalActive { get; init; }

		[JsonPropertyName("total_all")]
		public double? TotalAll { get; init; }

		[JsonPropertyName("Types")]
		public IReadOnlyList<string>? Types { get; init; }

		[JsonPropertyName("Updated")]
		public string? Updated { get; init; }

		[JsonPropertyName("uri_supported")]
		public IReadOnlyList<string>? UriSupported { get; init; }

		[JsonPropertyName("Zones")]
		public IReadOnlyList<string>? Zones { get; init; }
	}

	public partial record SunEntity : Entity<SunEntity, EntityState<SunAttributes>, SunAttributes>
	{
		public SunEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SunEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SunAttributes
	{
		[JsonPropertyName("azimuth")]
		public double? Azimuth { get; init; }

		[JsonPropertyName("elevation")]
		public double? Elevation { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("next_dawn")]
		public string? NextDawn { get; init; }

		[JsonPropertyName("next_dusk")]
		public string? NextDusk { get; init; }

		[JsonPropertyName("next_midnight")]
		public string? NextMidnight { get; init; }

		[JsonPropertyName("next_noon")]
		public string? NextNoon { get; init; }

		[JsonPropertyName("next_rising")]
		public string? NextRising { get; init; }

		[JsonPropertyName("next_setting")]
		public string? NextSetting { get; init; }

		[JsonPropertyName("rising")]
		public bool? Rising { get; init; }
	}

	public partial record SwitchEntity : Entity<SwitchEntity, EntityState<SwitchAttributes>, SwitchAttributes>
	{
		public SwitchEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SwitchEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SwitchAttributes
	{
		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("mode")]
		public object? Mode { get; init; }
	}

	public partial record UpdateEntity : Entity<UpdateEntity, EntityState<UpdateAttributes>, UpdateAttributes>
	{
		public UpdateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public UpdateEntity(Entity entity) : base(entity)
		{
		}
	}

	public record UpdateAttributes
	{
		[JsonPropertyName("auto_update")]
		public bool? AutoUpdate { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("in_progress")]
		public bool? InProgress { get; init; }

		[JsonPropertyName("installed_version")]
		public string? InstalledVersion { get; init; }

		[JsonPropertyName("latest_version")]
		public string? LatestVersion { get; init; }

		[JsonPropertyName("release_summary")]
		public string? ReleaseSummary { get; init; }

		[JsonPropertyName("release_url")]
		public string? ReleaseUrl { get; init; }

		[JsonPropertyName("skipped_version")]
		public object? SkippedVersion { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public partial record WeatherEntity : Entity<WeatherEntity, EntityState<WeatherAttributes>, WeatherAttributes>
	{
		public WeatherEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public WeatherEntity(Entity entity) : base(entity)
		{
		}
	}

	public record WeatherAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("forecast")]
		public IReadOnlyList<object>? Forecast { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("humidity")]
		public double? Humidity { get; init; }

		[JsonPropertyName("precipitation_unit")]
		public string? PrecipitationUnit { get; init; }

		[JsonPropertyName("pressure_unit")]
		public string? PressureUnit { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("temperature_unit")]
		public string? TemperatureUnit { get; init; }

		[JsonPropertyName("visibility_unit")]
		public string? VisibilityUnit { get; init; }

		[JsonPropertyName("wind_bearing")]
		public string? WindBearing { get; init; }

		[JsonPropertyName("wind_speed")]
		public double? WindSpeed { get; init; }

		[JsonPropertyName("wind_speed_unit")]
		public string? WindSpeedUnit { get; init; }
	}

	public partial record ZoneEntity : Entity<ZoneEntity, EntityState<ZoneAttributes>, ZoneAttributes>
	{
		public ZoneEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ZoneEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ZoneAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("passive")]
		public bool? Passive { get; init; }

		[JsonPropertyName("persons")]
		public IReadOnlyList<string>? Persons { get; init; }

		[JsonPropertyName("radius")]
		public double? Radius { get; init; }
	}

	public interface IServices
	{
		AlarmControlPanelServices AlarmControlPanel { get; }

		AlexaMediaServices AlexaMedia { get; }

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

		InputButtonServices InputButton { get; }

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

		UpdateServices Update { get; }

		VacuumServices Vacuum { get; }

		WebostvServices Webostv { get; }

		ZoneServices Zone { get; }

		ZwaveJsServices ZwaveJs { get; }
	}

	public class Services : IServices
	{
		private readonly IHaContext _haContext;
		public Services(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AlarmControlPanelServices AlarmControlPanel => new(_haContext);
		public AlexaMediaServices AlexaMedia => new(_haContext);
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
		public InputButtonServices InputButton => new(_haContext);
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
		public UpdateServices Update => new(_haContext);
		public VacuumServices Vacuum => new(_haContext);
		public WebostvServices Webostv => new(_haContext);
		public ZoneServices Zone => new(_haContext);
		public ZwaveJsServices ZwaveJs => new(_haContext);
	}

	public class AlarmControlPanelServices
	{
		private readonly IHaContext _haContext;
		public AlarmControlPanelServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmAway(ServiceTarget target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public void AlarmArmAway(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmCustomBypass(ServiceTarget target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, data);
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public void AlarmArmCustomBypass(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmHome(ServiceTarget target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public void AlarmArmHome(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmNight(ServiceTarget target, AlarmControlPanelAlarmArmNightParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public void AlarmArmNight(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmVacation(ServiceTarget target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public void AlarmArmVacation(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmDisarm(ServiceTarget target, AlarmControlPanelAlarmDisarmParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public void AlarmDisarm(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmTrigger(ServiceTarget target, AlarmControlPanelAlarmTriggerParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public void AlarmTrigger(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}
	}

	public record AlarmControlPanelAlarmArmAwayParameters
	{
		///<summary>An optional code to arm away the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmCustomBypassParameters
	{
		///<summary>An optional code to arm custom bypass the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmHomeParameters
	{
		///<summary>An optional code to arm home the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmNightParameters
	{
		///<summary>An optional code to arm night the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmVacationParameters
	{
		///<summary>An optional code to arm vacation the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmDisarmParameters
	{
		///<summary>An optional code to disarm the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmTriggerParameters
	{
		///<summary>An optional code to trigger the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class AlexaMediaServices
	{
		private readonly IHaContext _haContext;
		public AlexaMediaServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear last entries from Alexa history for each Alexa account.</summary>
		public void ClearHistory(AlexaMediaClearHistoryParameters data)
		{
			_haContext.CallService("alexa_media", "clear_history", null, data);
		}

		///<summary>Clear last entries from Alexa history for each Alexa account.</summary>
		///<param name="email">List of Alexa accounts to update. If empty, will delete from all known accounts. eg: my_email@alexa.com</param>
		///<param name="entries">Number of entries to clear from 1 to 50. If empty, clear 50. eg: 50</param>
		public void ClearHistory(object? @email = null, object? @entries = null)
		{
			_haContext.CallService("alexa_media", "clear_history", null, new AlexaMediaClearHistoryParameters{Email = @email, Entries = @entries});
		}

		///<summary>Force logout of Alexa Login account and deletion of .pickle. Intended for debugging use.</summary>
		public void ForceLogout(AlexaMediaForceLogoutParameters data)
		{
			_haContext.CallService("alexa_media", "force_logout", null, data);
		}

		///<summary>Force logout of Alexa Login account and deletion of .pickle. Intended for debugging use.</summary>
		///<param name="email">List of Alexa accounts to log out. If empty, will log out from all known accounts. eg: my_email@alexa.com</param>
		public void ForceLogout(object? @email = null)
		{
			_haContext.CallService("alexa_media", "force_logout", null, new AlexaMediaForceLogoutParameters{Email = @email});
		}

		///<summary>Forces update of last_called echo device for each Alexa account.</summary>
		public void UpdateLastCalled(AlexaMediaUpdateLastCalledParameters data)
		{
			_haContext.CallService("alexa_media", "update_last_called", null, data);
		}

		///<summary>Forces update of last_called echo device for each Alexa account.</summary>
		///<param name="email">List of Alexa accounts to update. If empty, will update all known accounts. eg: my_email@alexa.com</param>
		public void UpdateLastCalled(object? @email = null)
		{
			_haContext.CallService("alexa_media", "update_last_called", null, new AlexaMediaUpdateLastCalledParameters{Email = @email});
		}
	}

	public record AlexaMediaClearHistoryParameters
	{
		///<summary>List of Alexa accounts to update. If empty, will delete from all known accounts. eg: my_email@alexa.com</summary>
		[JsonPropertyName("email")]
		public object? Email { get; init; }

		///<summary>Number of entries to clear from 1 to 50. If empty, clear 50. eg: 50</summary>
		[JsonPropertyName("entries")]
		public object? Entries { get; init; }
	}

	public record AlexaMediaForceLogoutParameters
	{
		///<summary>List of Alexa accounts to log out. If empty, will log out from all known accounts. eg: my_email@alexa.com</summary>
		[JsonPropertyName("email")]
		public object? Email { get; init; }
	}

	public record AlexaMediaUpdateLastCalledParameters
	{
		///<summary>List of Alexa accounts to update. If empty, will update all known accounts. eg: my_email@alexa.com</summary>
		[JsonPropertyName("email")]
		public object? Email { get; init; }
	}

	public class AutomationServices
	{
		private readonly IHaContext _haContext;
		public AutomationServices(IHaContext haContext)
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
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("automation", "toggle", target);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Trigger(ServiceTarget target, AutomationTriggerParameters data)
		{
			_haContext.CallService("automation", "trigger", target, data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public void Trigger(ServiceTarget target, bool? @skipCondition = null)
		{
			_haContext.CallService("automation", "trigger", target, new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, AutomationTurnOffParameters data)
		{
			_haContext.CallService("automation", "turn_off", target, data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public void TurnOff(ServiceTarget target, bool? @stopActions = null)
		{
			_haContext.CallService("automation", "turn_off", target, new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("automation", "turn_on", target);
		}
	}

	public record AutomationTriggerParameters
	{
		///<summary>Whether or not the conditions will be skipped.</summary>
		[JsonPropertyName("skip_condition")]
		public bool? SkipCondition { get; init; }
	}

	public record AutomationTurnOffParameters
	{
		///<summary>Stop currently running actions.</summary>
		[JsonPropertyName("stop_actions")]
		public bool? StopActions { get; init; }
	}

	public class ButtonServices
	{
		private readonly IHaContext _haContext;
		public ButtonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Press the button entity.</summary>
		///<param name="target">The target for this service call</param>
		public void Press(ServiceTarget target)
		{
			_haContext.CallService("button", "press", target);
		}
	}

	public class CameraServices
	{
		private readonly IHaContext _haContext;
		public CameraServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Disable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void DisableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "disable_motion_detection", target);
		}

		///<summary>Enable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void EnableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "enable_motion_detection", target);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayStream(ServiceTarget target, CameraPlayStreamParameters data)
		{
			_haContext.CallService("camera", "play_stream", target, data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public void PlayStream(ServiceTarget target, string @mediaPlayer, object? @format = null)
		{
			_haContext.CallService("camera", "play_stream", target, new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		public void Record(ServiceTarget target, CameraRecordParameters data)
		{
			_haContext.CallService("camera", "record", target, data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public void Record(ServiceTarget target, string @filename, long? @duration = null, long? @lookback = null)
		{
			_haContext.CallService("camera", "record", target, new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void Snapshot(ServiceTarget target, CameraSnapshotParameters data)
		{
			_haContext.CallService("camera", "snapshot", target, data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public void Snapshot(ServiceTarget target, string @filename)
		{
			_haContext.CallService("camera", "snapshot", target, new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_off", target);
		}

		///<summary>Turn on camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_on", target);
		}
	}

	public record CameraPlayStreamParameters
	{
		///<summary>Name(s) of media player to stream to.</summary>
		[JsonPropertyName("media_player")]
		public string? MediaPlayer { get; init; }

		///<summary>Stream format supported by media player.</summary>
		[JsonPropertyName("format")]
		public object? Format { get; init; }
	}

	public record CameraRecordParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }

		///<summary>Target recording length.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</summary>
		[JsonPropertyName("lookback")]
		public long? Lookback { get; init; }
	}

	public record CameraSnapshotParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }
	}

	public class ClimateServices
	{
		private readonly IHaContext _haContext;
		public ClimateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetAuxHeat(ServiceTarget target, ClimateSetAuxHeatParameters data)
		{
			_haContext.CallService("climate", "set_aux_heat", target, data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public void SetAuxHeat(ServiceTarget target, bool @auxHeat)
		{
			_haContext.CallService("climate", "set_aux_heat", target, new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanMode(ServiceTarget target, ClimateSetFanModeParameters data)
		{
			_haContext.CallService("climate", "set_fan_mode", target, data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public void SetFanMode(ServiceTarget target, string @fanMode)
		{
			_haContext.CallService("climate", "set_fan_mode", target, new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(ServiceTarget target, ClimateSetHumidityParameters data)
		{
			_haContext.CallService("climate", "set_humidity", target, data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public void SetHumidity(ServiceTarget target, long @humidity)
		{
			_haContext.CallService("climate", "set_humidity", target, new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHvacMode(ServiceTarget target, ClimateSetHvacModeParameters data)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public void SetHvacMode(ServiceTarget target, object? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, ClimateSetPresetModeParameters data)
		{
			_haContext.CallService("climate", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("climate", "set_preset_mode", target, new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSwingMode(ServiceTarget target, ClimateSetSwingModeParameters data)
		{
			_haContext.CallService("climate", "set_swing_mode", target, data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public void SetSwingMode(ServiceTarget target, string @swingMode)
		{
			_haContext.CallService("climate", "set_swing_mode", target, new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetTemperature(ServiceTarget target, ClimateSetTemperatureParameters data)
		{
			_haContext.CallService("climate", "set_temperature", target, data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public void SetTemperature(ServiceTarget target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_temperature", target, new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_off", target);
		}

		///<summary>Turn climate device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_on", target);
		}
	}

	public record ClimateSetAuxHeatParameters
	{
		///<summary>New value of auxiliary heater.</summary>
		[JsonPropertyName("aux_heat")]
		public bool? AuxHeat { get; init; }
	}

	public record ClimateSetFanModeParameters
	{
		///<summary>New value of fan mode. eg: low</summary>
		[JsonPropertyName("fan_mode")]
		public string? FanMode { get; init; }
	}

	public record ClimateSetHumidityParameters
	{
		///<summary>New target humidity for climate device.</summary>
		[JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record ClimateSetHvacModeParameters
	{
		///<summary>New value of operation mode.</summary>
		[JsonPropertyName("hvac_mode")]
		public object? HvacMode { get; init; }
	}

	public record ClimateSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: away</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record ClimateSetSwingModeParameters
	{
		///<summary>New value of swing mode. eg: horizontal</summary>
		[JsonPropertyName("swing_mode")]
		public string? SwingMode { get; init; }
	}

	public record ClimateSetTemperatureParameters
	{
		///<summary>New target temperature for HVAC.</summary>
		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		///<summary>New target high temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_high")]
		public double? TargetTempHigh { get; init; }

		///<summary>New target low temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_low")]
		public double? TargetTempLow { get; init; }

		///<summary>HVAC operation mode to set temperature to.</summary>
		[JsonPropertyName("hvac_mode")]
		public object? HvacMode { get; init; }
	}

	public class CloudServices
	{
		private readonly IHaContext _haContext;
		public CloudServices(IHaContext haContext)
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
		private readonly IHaContext _haContext;
		public CommandLineServices(IHaContext haContext)
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
		private readonly IHaContext _haContext;
		public CounterServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		public void Configure(ServiceTarget target, CounterConfigureParameters data)
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
		public void Configure(ServiceTarget target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			_haContext.CallService("counter", "configure", target, new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Decrement a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("counter", "decrement", target);
		}

		///<summary>Increment a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("counter", "increment", target);
		}

		///<summary>Reset a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Reset(ServiceTarget target)
		{
			_haContext.CallService("counter", "reset", target);
		}
	}

	public record CounterConfigureParameters
	{
		///<summary>New minimum value for the counter or None to remove minimum.</summary>
		[JsonPropertyName("minimum")]
		public long? Minimum { get; init; }

		///<summary>New maximum value for the counter or None to remove maximum.</summary>
		[JsonPropertyName("maximum")]
		public long? Maximum { get; init; }

		///<summary>New value for step.</summary>
		[JsonPropertyName("step")]
		public long? Step { get; init; }

		///<summary>New value for initial.</summary>
		[JsonPropertyName("initial")]
		public long? Initial { get; init; }

		///<summary>New state value.</summary>
		[JsonPropertyName("value")]
		public long? Value { get; init; }
	}

	public class CoverServices
	{
		private readonly IHaContext _haContext;
		public CoverServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Close all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover", target);
		}

		///<summary>Close all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover_tilt", target);
		}

		///<summary>Open all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover", target);
		}

		///<summary>Open all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover_tilt", target);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverPosition(ServiceTarget target, CoverSetCoverPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_position", target, data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="position">Position of the cover</param>
		public void SetCoverPosition(ServiceTarget target, long @position)
		{
			_haContext.CallService("cover", "set_cover_position", target, new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverTiltPosition(ServiceTarget target, CoverSetCoverTiltPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public void SetCoverTiltPosition(ServiceTarget target, long @tiltPosition)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover", target);
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover_tilt", target);
		}

		///<summary>Toggle a cover open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle", target);
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void ToggleCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle_cover_tilt", target);
		}
	}

	public record CoverSetCoverPositionParameters
	{
		///<summary>Position of the cover</summary>
		[JsonPropertyName("position")]
		public long? Position { get; init; }
	}

	public record CoverSetCoverTiltPositionParameters
	{
		///<summary>Tilt position of the cover.</summary>
		[JsonPropertyName("tilt_position")]
		public long? TiltPosition { get; init; }
	}

	public class DeviceTrackerServices
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerServices(IHaContext haContext)
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
		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		///<summary>Id of device (find id in known_devices.yaml). eg: phonedave</summary>
		[JsonPropertyName("dev_id")]
		public string? DevId { get; init; }

		///<summary>Hostname of device eg: Dave</summary>
		[JsonPropertyName("host_name")]
		public string? HostName { get; init; }

		///<summary>Name of location where device is located (not_home is away). eg: home</summary>
		[JsonPropertyName("location_name")]
		public string? LocationName { get; init; }

		///<summary>GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</summary>
		[JsonPropertyName("gps")]
		public object? Gps { get; init; }

		///<summary>Accuracy of GPS coordinates.</summary>
		[JsonPropertyName("gps_accuracy")]
		public long? GpsAccuracy { get; init; }

		///<summary>Battery level of device.</summary>
		[JsonPropertyName("battery")]
		public long? Battery { get; init; }
	}

	public class FanServices
	{
		private readonly IHaContext _haContext;
		public FanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void DecreaseSpeed(ServiceTarget target, FanDecreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "decrease_speed", target, data);
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Decrease speed by a percentage.</param>
		public void DecreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "decrease_speed", target, new FanDecreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void IncreaseSpeed(ServiceTarget target, FanIncreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "increase_speed", target, data);
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Increase speed by a percentage.</param>
		public void IncreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "increase_speed", target, new FanIncreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		public void Oscillate(ServiceTarget target, FanOscillateParameters data)
		{
			_haContext.CallService("fan", "oscillate", target, data);
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="oscillating">Flag to turn on/off oscillation.</param>
		public void Oscillate(ServiceTarget target, bool @oscillating)
		{
			_haContext.CallService("fan", "oscillate", target, new FanOscillateParameters{Oscillating = @oscillating});
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDirection(ServiceTarget target, FanSetDirectionParameters data)
		{
			_haContext.CallService("fan", "set_direction", target, data);
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="direction">The direction to rotate.</param>
		public void SetDirection(ServiceTarget target, object @direction)
		{
			_haContext.CallService("fan", "set_direction", target, new FanSetDirectionParameters{Direction = @direction});
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPercentage(ServiceTarget target, FanSetPercentageParameters data)
		{
			_haContext.CallService("fan", "set_percentage", target, data);
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentage">Percentage speed setting.</param>
		public void SetPercentage(ServiceTarget target, long @percentage)
		{
			_haContext.CallService("fan", "set_percentage", target, new FanSetPercentageParameters{Percentage = @percentage});
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, FanSetPresetModeParameters data)
		{
			_haContext.CallService("fan", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: auto</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("fan", "set_preset_mode", target, new FanSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Toggle the fan on/off.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("fan", "toggle", target);
		}

		///<summary>Turn fan off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("fan", "turn_off", target);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, FanTurnOnParameters data)
		{
			_haContext.CallService("fan", "turn_on", target, data);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="speed">Speed setting. eg: high</param>
		///<param name="percentage">Percentage speed setting.</param>
		///<param name="presetMode">Preset mode setting. eg: auto</param>
		public void TurnOn(ServiceTarget target, string? @speed = null, long? @percentage = null, string? @presetMode = null)
		{
			_haContext.CallService("fan", "turn_on", target, new FanTurnOnParameters{Speed = @speed, Percentage = @percentage, PresetMode = @presetMode});
		}
	}

	public record FanDecreaseSpeedParameters
	{
		///<summary>Decrease speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanIncreaseSpeedParameters
	{
		///<summary>Increase speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanOscillateParameters
	{
		///<summary>Flag to turn on/off oscillation.</summary>
		[JsonPropertyName("oscillating")]
		public bool? Oscillating { get; init; }
	}

	public record FanSetDirectionParameters
	{
		///<summary>The direction to rotate.</summary>
		[JsonPropertyName("direction")]
		public object? Direction { get; init; }
	}

	public record FanSetPercentageParameters
	{
		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }
	}

	public record FanSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record FanTurnOnParameters
	{
		///<summary>Speed setting. eg: high</summary>
		[JsonPropertyName("speed")]
		public string? Speed { get; init; }

		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }

		///<summary>Preset mode setting. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public class FfmpegServices
	{
		private readonly IHaContext _haContext;
		public FfmpegServices(IHaContext haContext)
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
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record FfmpegStartParameters
	{
		///<summary>Name of entity that will start. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record FfmpegStopParameters
	{
		///<summary>Name of entity that will stop. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public class FrontendServices
	{
		private readonly IHaContext _haContext;
		public FrontendServices(IHaContext haContext)
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
		///<param name="name">Name of a predefined theme eg: default</param>
		///<param name="mode">The mode the theme is for.</param>
		public void SetTheme(object @name, object? @mode = null)
		{
			_haContext.CallService("frontend", "set_theme", null, new FrontendSetThemeParameters{Name = @name, Mode = @mode});
		}
	}

	public record FrontendSetThemeParameters
	{
		///<summary>Name of a predefined theme eg: default</summary>
		[JsonPropertyName("name")]
		public object? Name { get; init; }

		///<summary>The mode the theme is for.</summary>
		[JsonPropertyName("mode")]
		public object? Mode { get; init; }
	}

	public class GroupServices
	{
		private readonly IHaContext _haContext;
		public GroupServices(IHaContext haContext)
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
		public void Set(string @objectId, string? @name = null, object? @icon = null, object? @entities = null, object? @addEntities = null, bool? @all = null)
		{
			_haContext.CallService("group", "set", null, new GroupSetParameters{ObjectId = @objectId, Name = @name, Icon = @icon, Entities = @entities, AddEntities = @addEntities, All = @all});
		}
	}

	public record GroupRemoveParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public object? ObjectId { get; init; }
	}

	public record GroupSetParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public string? ObjectId { get; init; }

		///<summary>Name of group eg: My test group</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Name of icon for the group. eg: mdi:camera</summary>
		[JsonPropertyName("icon")]
		public object? Icon { get; init; }

		///<summary>List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("add_entities")]
		public object? AddEntities { get; init; }

		///<summary>Enable this option if the group should only turn on when all entities are on.</summary>
		[JsonPropertyName("all")]
		public bool? All { get; init; }
	}

	public class HassioServices
	{
		private readonly IHaContext _haContext;
		public HassioServices(IHaContext haContext)
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
		///<param name="compressed">Use compressed archives</param>
		public void BackupFull(string? @name = null, string? @password = null, bool? @compressed = null)
		{
			_haContext.CallService("hassio", "backup_full", null, new HassioBackupFullParameters{Name = @name, Password = @password, Compressed = @compressed});
		}

		///<summary>Create a partial backup.</summary>
		public void BackupPartial(HassioBackupPartialParameters data)
		{
			_haContext.CallService("hassio", "backup_partial", null, data);
		}

		///<summary>Create a partial backup.</summary>
		///<param name="homeassistant">Backup Home Assistant settings</param>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant","share"]</param>
		///<param name="name">Optional (default = current date and time). eg: Partial backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		///<param name="compressed">Use compressed archives</param>
		public void BackupPartial(bool? @homeassistant = null, object? @addons = null, object? @folders = null, string? @name = null, string? @password = null, bool? @compressed = null)
		{
			_haContext.CallService("hassio", "backup_partial", null, new HassioBackupPartialParameters{Homeassistant = @homeassistant, Addons = @addons, Folders = @folders, Name = @name, Password = @password, Compressed = @compressed});
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
		///<param name="folders">Optional list of directories. eg: ["homeassistant","share"]</param>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestorePartial(string @slug, bool? @homeassistant = null, object? @folders = null, object? @addons = null, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_partial", null, new HassioRestorePartialParameters{Slug = @slug, Homeassistant = @homeassistant, Folders = @folders, Addons = @addons, Password = @password});
		}
	}

	public record HassioAddonRestartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStdinParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStopParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonUpdateParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioBackupFullParameters
	{
		///<summary>Optional (default = current date and time). eg: Backup 1</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }

		///<summary>Use compressed archives</summary>
		[JsonPropertyName("compressed")]
		public bool? Compressed { get; init; }
	}

	public record HassioBackupPartialParameters
	{
		///<summary>Backup Home Assistant settings</summary>
		[JsonPropertyName("homeassistant")]
		public bool? Homeassistant { get; init; }

		///<summary>Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</summary>
		[JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant","share"]</summary>
		[JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional (default = current date and time). eg: Partial backup 1</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }

		///<summary>Use compressed archives</summary>
		[JsonPropertyName("compressed")]
		public bool? Compressed { get; init; }
	}

	public record HassioRestoreFullParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public record HassioRestorePartialParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Restore Home Assistant</summary>
		[JsonPropertyName("homeassistant")]
		public bool? Homeassistant { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant","share"]</summary>
		[JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</summary>
		[JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public class HiveServices
	{
		private readonly IHaContext _haContext;
		public HiveServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>To be deprecated please use boost_heating_on.</summary>
		///<param name="target">The target for this service call</param>
		public void BoostHeating(ServiceTarget target, HiveBoostHeatingParameters data)
		{
			_haContext.CallService("hive", "boost_heating", target, data);
		}

		///<summary>To be deprecated please use boost_heating_on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="timePeriod">Set the time period for the boost. eg: 01:30:00</param>
		///<param name="temperature">Set the target temperature for the boost period.</param>
		public void BoostHeating(ServiceTarget target, DateTime @timePeriod, double? @temperature = null)
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
		public void BoostHeatingOn(ServiceTarget target, HiveBoostHeatingOnParameters data)
		{
			_haContext.CallService("hive", "boost_heating_on", target, data);
		}

		///<summary>Set the boost mode ON defining the period of time and the desired target temperature for the boost.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="timePeriod">Set the time period for the boost. eg: 01:30:00</param>
		///<param name="temperature">Set the target temperature for the boost period.</param>
		public void BoostHeatingOn(ServiceTarget target, DateTime @timePeriod, double? @temperature = null)
		{
			_haContext.CallService("hive", "boost_heating_on", target, new HiveBoostHeatingOnParameters{TimePeriod = @timePeriod, Temperature = @temperature});
		}
	}

	public record HiveBoostHeatingParameters
	{
		///<summary>Set the time period for the boost. eg: 01:30:00</summary>
		[JsonPropertyName("time_period")]
		public DateTime? TimePeriod { get; init; }

		///<summary>Set the target temperature for the boost period.</summary>
		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }
	}

	public record HiveBoostHeatingOffParameters
	{
		///<summary>Select entity_id to turn boost off.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record HiveBoostHeatingOnParameters
	{
		///<summary>Set the time period for the boost. eg: 01:30:00</summary>
		[JsonPropertyName("time_period")]
		public DateTime? TimePeriod { get; init; }

		///<summary>Set the target temperature for the boost period.</summary>
		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }
	}

	public class HomeassistantServices
	{
		private readonly IHaContext _haContext;
		public HomeassistantServices(IHaContext haContext)
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
		public void ReloadConfigEntry(ServiceTarget target, HomeassistantReloadConfigEntryParameters data)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, data);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entryId">A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</param>
		public void ReloadConfigEntry(ServiceTarget target, string? @entryId = null)
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
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "toggle", target);
		}

		///<summary>Generic service to turn devices off under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_off", target);
		}

		///<summary>Generic service to turn devices on under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_on", target);
		}

		///<summary>Force one or more entities to update its data</summary>
		///<param name="target">The target for this service call</param>
		public void UpdateEntity(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "update_entity", target);
		}
	}

	public record HomeassistantReloadConfigEntryParameters
	{
		///<summary>A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</summary>
		[JsonPropertyName("entry_id")]
		public string? EntryId { get; init; }
	}

	public record HomeassistantSetLocationParameters
	{
		///<summary>Latitude of your location. eg: 32.87336</summary>
		[JsonPropertyName("latitude")]
		public string? Latitude { get; init; }

		///<summary>Longitude of your location. eg: 117.22743</summary>
		[JsonPropertyName("longitude")]
		public string? Longitude { get; init; }
	}

	public class HueServices
	{
		private readonly IHaContext _haContext;
		public HueServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Activate a Hue scene with more control over the options.</summary>
		///<param name="target">The target for this service call</param>
		public void ActivateScene(ServiceTarget target, HueActivateSceneParameters data)
		{
			_haContext.CallService("hue", "activate_scene", target, data);
		}

		///<summary>Activate a Hue scene with more control over the options.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		///<param name="dynamic">Enable dynamic mode of the scene.</param>
		///<param name="speed">Speed of dynamic palette for this scene</param>
		///<param name="brightness">Set brightness for the scene.</param>
		public void ActivateScene(ServiceTarget target, long? @transition = null, bool? @dynamic = null, long? @speed = null, long? @brightness = null)
		{
			_haContext.CallService("hue", "activate_scene", target, new HueActivateSceneParameters{Transition = @transition, Dynamic = @dynamic, Speed = @speed, Brightness = @brightness});
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

	public record HueActivateSceneParameters
	{
		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>Enable dynamic mode of the scene.</summary>
		[JsonPropertyName("dynamic")]
		public bool? Dynamic { get; init; }

		///<summary>Speed of dynamic palette for this scene</summary>
		[JsonPropertyName("speed")]
		public long? Speed { get; init; }

		///<summary>Set brightness for the scene.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }
	}

	public record HueHueActivateSceneParameters
	{
		///<summary>Name of hue group/room from the hue app. eg: Living Room</summary>
		[JsonPropertyName("group_name")]
		public string? GroupName { get; init; }

		///<summary>Name of hue scene from the hue app. eg: Energize</summary>
		[JsonPropertyName("scene_name")]
		public string? SceneName { get; init; }

		///<summary>Enable dynamic mode of the scene (V2 bridges and supported scenes only).</summary>
		[JsonPropertyName("dynamic")]
		public bool? Dynamic { get; init; }
	}

	public class HumidifierServices
	{
		private readonly IHaContext _haContext;
		public HumidifierServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(ServiceTarget target, HumidifierSetHumidityParameters data)
		{
			_haContext.CallService("humidifier", "set_humidity", target, data);
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for humidifier device.</param>
		public void SetHumidity(ServiceTarget target, long @humidity)
		{
			_haContext.CallService("humidifier", "set_humidity", target, new HumidifierSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetMode(ServiceTarget target, HumidifierSetModeParameters data)
		{
			_haContext.CallService("humidifier", "set_mode", target, data);
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mode">New mode eg: away</param>
		public void SetMode(ServiceTarget target, string @mode)
		{
			_haContext.CallService("humidifier", "set_mode", target, new HumidifierSetModeParameters{Mode = @mode});
		}

		///<summary>Toggles a humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "toggle", target);
		}

		///<summary>Turn humidifier device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "turn_off", target);
		}

		///<summary>Turn humidifier device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "turn_on", target);
		}
	}

	public record HumidifierSetHumidityParameters
	{
		///<summary>New target humidity for humidifier device.</summary>
		[JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record HumidifierSetModeParameters
	{
		///<summary>New mode eg: away</summary>
		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public class InputBooleanServices
	{
		private readonly IHaContext _haContext;
		public InputBooleanServices(IHaContext haContext)
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
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "toggle", target);
		}

		///<summary>Turn off an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_off", target);
		}

		///<summary>Turn on an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_on", target);
		}
	}

	public class InputButtonServices
	{
		private readonly IHaContext _haContext;
		public InputButtonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Press the input button entity.</summary>
		///<param name="target">The target for this service call</param>
		public void Press(ServiceTarget target)
		{
			_haContext.CallService("input_button", "press", target);
		}

		public void Reload()
		{
			_haContext.CallService("input_button", "reload", null);
		}
	}

	public class InputDatetimeServices
	{
		private readonly IHaContext _haContext;
		public InputDatetimeServices(IHaContext haContext)
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
		public void SetDatetime(ServiceTarget target, InputDatetimeSetDatetimeParameters data)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public void SetDatetime(ServiceTarget target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public record InputDatetimeSetDatetimeParameters
	{
		///<summary>The target date the entity should be set to. eg: "2019-04-20"</summary>
		[JsonPropertyName("date")]
		public string? Date { get; init; }

		///<summary>The target time the entity should be set to. eg: "05:04:20"</summary>
		[JsonPropertyName("time")]
		public DateTime? Time { get; init; }

		///<summary>The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</summary>
		[JsonPropertyName("datetime")]
		public string? Datetime { get; init; }

		///<summary>The target date & time the entity should be set to as expressed by a UNIX timestamp.</summary>
		[JsonPropertyName("timestamp")]
		public long? Timestamp { get; init; }
	}

	public class InputNumberServices
	{
		private readonly IHaContext _haContext;
		public InputNumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("input_number", "decrement", target);
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
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
		public void SetValue(ServiceTarget target, InputNumberSetValueParameters data)
		{
			_haContext.CallService("input_number", "set_value", target, data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to.</param>
		public void SetValue(ServiceTarget target, double @value)
		{
			_haContext.CallService("input_number", "set_value", target, new InputNumberSetValueParameters{Value = @value});
		}
	}

	public record InputNumberSetValueParameters
	{
		///<summary>The target value the entity should be set to.</summary>
		[JsonPropertyName("value")]
		public double? Value { get; init; }
	}

	public class InputSelectServices
	{
		private readonly IHaContext _haContext;
		public InputSelectServices(IHaContext haContext)
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
		public void SelectFirst(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_first", target);
		}

		///<summary>Select the last option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectLast(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_last", target);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectNext(ServiceTarget target, InputSelectSelectNextParameters data)
		{
			_haContext.CallService("input_select", "select_next", target, data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public void SelectNext(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_next", target, new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, InputSelectSelectOptionParameters data)
		{
			_haContext.CallService("input_select", "select_option", target, data);
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("input_select", "select_option", target, new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectPrevious(ServiceTarget target, InputSelectSelectPreviousParameters data)
		{
			_haContext.CallService("input_select", "select_previous", target, data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public void SelectPrevious(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_previous", target, new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetOptions(ServiceTarget target, InputSelectSetOptionsParameters data)
		{
			_haContext.CallService("input_select", "set_options", target, data);
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public void SetOptions(ServiceTarget target, object @options)
		{
			_haContext.CallService("input_select", "set_options", target, new InputSelectSetOptionsParameters{Options = @options});
		}
	}

	public record InputSelectSelectNextParameters
	{
		///<summary>If the option should cycle from the last to the first.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public record InputSelectSelectPreviousParameters
	{
		///<summary>If the option should cycle from the first to the last.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSetOptionsParameters
	{
		///<summary>Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class InputTextServices
	{
		private readonly IHaContext _haContext;
		public InputTextServices(IHaContext haContext)
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
		public void SetValue(ServiceTarget target, InputTextSetValueParameters data)
		{
			_haContext.CallService("input_text", "set_value", target, data);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public void SetValue(ServiceTarget target, string @value)
		{
			_haContext.CallService("input_text", "set_value", target, new InputTextSetValueParameters{Value = @value});
		}
	}

	public record InputTextSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: This is an example text</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class LightServices
	{
		private readonly IHaContext _haContext;
		public LightServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target, LightToggleParameters data)
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
		public void Toggle(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "toggle", target, new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, LightTurnOffParameters data)
		{
			_haContext.CallService("light", "turn_off", target, data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public void TurnOff(ServiceTarget target, long? @transition = null, object? @flash = null)
		{
			_haContext.CallService("light", "turn_off", target, new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, LightTurnOnParameters data)
		{
			_haContext.CallService("light", "turn_on", target, data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
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
		public void TurnOn(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "turn_on", target, new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public record LightToggleParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>Color for the light in RGB-format. eg: [255, 100, 100]</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public object? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public object? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating level of white.</summary>
		[JsonPropertyName("white_value")]
		public long? WhiteValue { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public record LightTurnOffParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }
	}

	public record LightTurnOnParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>The color for the light (based on RGB - red, green, blue).</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</summary>
		[JsonPropertyName("rgbw_color")]
		public object? RgbwColor { get; init; }

		///<summary>A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</summary>
		[JsonPropertyName("rgbww_color")]
		public object? RgbwwColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public object? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public object? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Change brightness by an amount.</summary>
		[JsonPropertyName("brightness_step")]
		public long? BrightnessStep { get; init; }

		///<summary>Change brightness by a percentage.</summary>
		[JsonPropertyName("brightness_step_pct")]
		public long? BrightnessStepPct { get; init; }

		///<summary>Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("white")]
		public long? White { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public class LockServices
	{
		private readonly IHaContext _haContext;
		public LockServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Lock(ServiceTarget target, LockLockParameters data)
		{
			_haContext.CallService("lock", "lock", target, data);
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public void Lock(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "lock", target, new LockLockParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Open(ServiceTarget target, LockOpenParameters data)
		{
			_haContext.CallService("lock", "open", target, data);
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public void Open(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "open", target, new LockOpenParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Unlock(ServiceTarget target, LockUnlockParameters data)
		{
			_haContext.CallService("lock", "unlock", target, data);
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public void Unlock(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "unlock", target, new LockUnlockParameters{Code = @code});
		}
	}

	public record LockLockParameters
	{
		///<summary>An optional code to lock the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockOpenParameters
	{
		///<summary>An optional code to open the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockUnlockParameters
	{
		///<summary>An optional code to unlock the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class LogbookServices
	{
		private readonly IHaContext _haContext;
		public LogbookServices(IHaContext haContext)
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
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Message of the custom logbook entry. eg: is being used</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Entity to reference in custom logbook entry.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Icon of domain to display in custom logbook entry. eg: light</summary>
		[JsonPropertyName("domain")]
		public string? Domain { get; init; }
	}

	public class LoggerServices
	{
		private readonly IHaContext _haContext;
		public LoggerServices(IHaContext haContext)
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
		public void SetDefaultLevel(object? @level = null)
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
		[JsonPropertyName("level")]
		public object? Level { get; init; }
	}

	public class MediaPlayerServices
	{
		private readonly IHaContext _haContext;
		public MediaPlayerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearPlaylist(ServiceTarget target)
		{
			_haContext.CallService("media_player", "clear_playlist", target);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Join(ServiceTarget target, MediaPlayerJoinParameters data)
		{
			_haContext.CallService("media_player", "join", target, data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</param>
		public void Join(ServiceTarget target, object? @groupMembers = null)
		{
			_haContext.CallService("media_player", "join", target, new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaNextTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_next_track", target);
		}

		///<summary>Send the media player the command for pause.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_pause", target);
		}

		///<summary>Send the media player the command for play.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlay(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play", target);
		}

		///<summary>Toggle media player play/pause state.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlayPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play_pause", target);
		}

		///<summary>Send the media player the command for previous track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPreviousTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_previous_track", target);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaSeek(ServiceTarget target, MediaPlayerMediaSeekParameters data)
		{
			_haContext.CallService("media_player", "media_seek", target, data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public void MediaSeek(ServiceTarget target, double @seekPosition)
		{
			_haContext.CallService("media_player", "media_seek", target, new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaStop(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_stop", target);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayMedia(ServiceTarget target, MediaPlayerPlayMediaParameters data)
		{
			_haContext.CallService("media_player", "play_media", target, data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public void PlayMedia(ServiceTarget target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			_haContext.CallService("media_player", "play_media", target, new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		public void RepeatSet(ServiceTarget target, MediaPlayerRepeatSetParameters data)
		{
			_haContext.CallService("media_player", "repeat_set", target, data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		///<param name="repeat">Repeat mode to set.</param>
		public void RepeatSet(ServiceTarget target, object @repeat)
		{
			_haContext.CallService("media_player", "repeat_set", target, new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSoundMode(ServiceTarget target, MediaPlayerSelectSoundModeParameters data)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public void SelectSoundMode(ServiceTarget target, string? @soundMode = null)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSource(ServiceTarget target, MediaPlayerSelectSourceParameters data)
		{
			_haContext.CallService("media_player", "select_source", target, data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public void SelectSource(ServiceTarget target, string @source)
		{
			_haContext.CallService("media_player", "select_source", target, new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		public void ShuffleSet(ServiceTarget target, MediaPlayerShuffleSetParameters data)
		{
			_haContext.CallService("media_player", "shuffle_set", target, data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public void ShuffleSet(ServiceTarget target, bool @shuffle)
		{
			_haContext.CallService("media_player", "shuffle_set", target, new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("media_player", "toggle", target);
		}

		///<summary>Turn a media player power off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_off", target);
		}

		///<summary>Turn a media player power on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_on", target);
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Unjoin(ServiceTarget target)
		{
			_haContext.CallService("media_player", "unjoin", target);
		}

		///<summary>Turn a media player volume down.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeDown(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_down", target);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeMute(ServiceTarget target, MediaPlayerVolumeMuteParameters data)
		{
			_haContext.CallService("media_player", "volume_mute", target, data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public void VolumeMute(ServiceTarget target, bool @isVolumeMuted)
		{
			_haContext.CallService("media_player", "volume_mute", target, new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeSet(ServiceTarget target, MediaPlayerVolumeSetParameters data)
		{
			_haContext.CallService("media_player", "volume_set", target, data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public void VolumeSet(ServiceTarget target, double @volumeLevel)
		{
			_haContext.CallService("media_player", "volume_set", target, new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeUp(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_up", target);
		}
	}

	public record MediaPlayerJoinParameters
	{
		///<summary>The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</summary>
		[JsonPropertyName("group_members")]
		public object? GroupMembers { get; init; }
	}

	public record MediaPlayerMediaSeekParameters
	{
		///<summary>Position to seek to. The format is platform dependent.</summary>
		[JsonPropertyName("seek_position")]
		public double? SeekPosition { get; init; }
	}

	public record MediaPlayerPlayMediaParameters
	{
		///<summary>The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</summary>
		[JsonPropertyName("media_content_id")]
		public string? MediaContentId { get; init; }

		///<summary>The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</summary>
		[JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }

		///<summary>If the content should be played now or be added to the queue.</summary>
		[JsonPropertyName("enqueue")]
		public object? Enqueue { get; init; }

		///<summary>If the media should be played as an announcement. eg: true</summary>
		[JsonPropertyName("announce")]
		public bool? Announce { get; init; }
	}

	public record MediaPlayerRepeatSetParameters
	{
		///<summary>Repeat mode to set.</summary>
		[JsonPropertyName("repeat")]
		public object? Repeat { get; init; }
	}

	public record MediaPlayerSelectSoundModeParameters
	{
		///<summary>Name of the sound mode to switch to. eg: Music</summary>
		[JsonPropertyName("sound_mode")]
		public string? SoundMode { get; init; }
	}

	public record MediaPlayerSelectSourceParameters
	{
		///<summary>Name of the source to switch to. Platform dependent. eg: video1</summary>
		[JsonPropertyName("source")]
		public string? Source { get; init; }
	}

	public record MediaPlayerShuffleSetParameters
	{
		///<summary>True/false for enabling/disabling shuffle.</summary>
		[JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }
	}

	public record MediaPlayerVolumeMuteParameters
	{
		///<summary>True/false for mute/unmute.</summary>
		[JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }
	}

	public record MediaPlayerVolumeSetParameters
	{
		///<summary>Volume level to set as float.</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public class MqttServices
	{
		private readonly IHaContext _haContext;
		public MqttServices(IHaContext haContext)
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
		public void Publish(string @topic, string? @payload = null, object? @payloadTemplate = null, object? @qos = null, bool? @retain = null)
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
		[JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>how long we should listen for messages in seconds</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record MqttPublishParameters
	{
		///<summary>Topic to publish payload. eg: /homeassistant/hello</summary>
		[JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>Payload to publish. eg: This is great</summary>
		[JsonPropertyName("payload")]
		public string? Payload { get; init; }

		///<summary>Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</summary>
		[JsonPropertyName("payload_template")]
		public object? PayloadTemplate { get; init; }

		///<summary>Quality of Service to use.</summary>
		[JsonPropertyName("qos")]
		public object? Qos { get; init; }

		///<summary>If message should have the retain flag set.</summary>
		[JsonPropertyName("retain")]
		public bool? Retain { get; init; }
	}

	public class NetdaemonServices
	{
		private readonly IHaContext _haContext;
		public NetdaemonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void CheckForFrost()
		{
			_haContext.CallService("netdaemon", "check_for_frost", null);
		}

		public void DeleteDebugEntities()
		{
			_haContext.CallService("netdaemon", "delete_debug_entities", null);
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
		///<param name="options">List of options for a select entity</param>
		///<param name="attributes">The attributes of the entity</param>
		public void EntityCreate(object? @entityId = null, object? @state = null, object? @icon = null, object? @unit = null, object? @options = null, object? @attributes = null)
		{
			_haContext.CallService("netdaemon", "entity_create", null, new NetdaemonEntityCreateParameters{EntityId = @entityId, State = @state, Icon = @icon, Unit = @unit, Options = @options, Attributes = @attributes});
		}

		///<summary>Remove an entity</summary>
		public void EntityRemove(NetdaemonEntityRemoveParameters data)
		{
			_haContext.CallService("netdaemon", "entity_remove", null, data);
		}

		///<summary>Remove an entity</summary>
		///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
		public void EntityRemove(object? @entityId = null)
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
		///<param name="options">List of options for a select entity</param>
		///<param name="attributes">The attributes of the entity</param>
		public void EntityUpdate(object? @entityId = null, object? @state = null, object? @icon = null, object? @unit = null, object? @options = null, object? @attributes = null)
		{
			_haContext.CallService("netdaemon", "entity_update", null, new NetdaemonEntityUpdateParameters{EntityId = @entityId, State = @state, Icon = @icon, Unit = @unit, Options = @options, Attributes = @attributes});
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
		public void RegisterService(object? @service = null, object? @class = null, object? @method = null)
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
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The state of the entity eg: Lorem ipsum</summary>
		[JsonPropertyName("state")]
		public object? State { get; init; }

		///<summary>The icon for the entity eg: mdi:rocket-launch-outline</summary>
		[JsonPropertyName("icon")]
		public object? Icon { get; init; }

		///<summary>The unit of measurement for the entity</summary>
		[JsonPropertyName("unit")]
		public object? Unit { get; init; }

		///<summary>List of options for a select entity</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }

		///<summary>The attributes of the entity</summary>
		[JsonPropertyName("attributes")]
		public object? Attributes { get; init; }
	}

	public record NetdaemonEntityRemoveParameters
	{
		///<summary>The entity ID of the entity eg: sensor.awesome</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }
	}

	public record NetdaemonEntityUpdateParameters
	{
		///<summary>The entity ID of the entity eg: sensor.awesome</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The state of the entity eg: Lorem ipsum</summary>
		[JsonPropertyName("state")]
		public object? State { get; init; }

		///<summary>The icon for the entity eg: mdi:rocket-launch-outline</summary>
		[JsonPropertyName("icon")]
		public object? Icon { get; init; }

		///<summary>The unit of measurement for the entity</summary>
		[JsonPropertyName("unit")]
		public object? Unit { get; init; }

		///<summary>List of options for a select entity</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }

		///<summary>The attributes of the entity</summary>
		[JsonPropertyName("attributes")]
		public object? Attributes { get; init; }
	}

	public record NetdaemonRegisterServiceParameters
	{
		///<summary>The name of the service to register</summary>
		[JsonPropertyName("service")]
		public object? Service { get; init; }

		///<summary>The class that implements the service call</summary>
		[JsonPropertyName("class")]
		public object? Class { get; init; }

		///<summary>The method to call</summary>
		[JsonPropertyName("method")]
		public object? Method { get; init; }
	}

	public class NotifyServices
	{
		private readonly IHaContext _haContext;
		public NotifyServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sends a notification message using the alexa_media service.</summary>
		public void AlexaMedia(NotifyAlexaMediaParameters data)
		{
			_haContext.CallService("notify", "alexa_media", null, data);
		}

		///<summary>Sends a notification message using the alexa_media service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMedia(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media", null, new NotifyAlexaMediaParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_everywhere integration.</summary>
		public void AlexaMediaEverywhere(NotifyAlexaMediaEverywhereParameters data)
		{
			_haContext.CallService("notify", "alexa_media_everywhere", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_everywhere integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaEverywhere(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_everywhere", null, new NotifyAlexaMediaEverywhereParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_fire_tv integration.</summary>
		public void AlexaMediaFireTv(NotifyAlexaMediaFireTvParameters data)
		{
			_haContext.CallService("notify", "alexa_media_fire_tv", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_fire_tv integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaFireTv(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_fire_tv", null, new NotifyAlexaMediaFireTvParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_garage_echo_dot integration.</summary>
		public void AlexaMediaGarageEchoDot(NotifyAlexaMediaGarageEchoDotParameters data)
		{
			_haContext.CallService("notify", "alexa_media_garage_echo_dot", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_garage_echo_dot integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaGarageEchoDot(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_garage_echo_dot", null, new NotifyAlexaMediaGarageEchoDotParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_jo_s_echo integration.</summary>
		public void AlexaMediaJoSEcho(NotifyAlexaMediaJoSEchoParameters data)
		{
			_haContext.CallService("notify", "alexa_media_jo_s_echo", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_jo_s_echo integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaJoSEcho(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_jo_s_echo", null, new NotifyAlexaMediaJoSEchoParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_kitchen_echo integration.</summary>
		public void AlexaMediaKitchenEcho(NotifyAlexaMediaKitchenEchoParameters data)
		{
			_haContext.CallService("notify", "alexa_media_kitchen_echo", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_kitchen_echo integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaKitchenEcho(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_kitchen_echo", null, new NotifyAlexaMediaKitchenEchoParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_last_called integration.</summary>
		public void AlexaMediaLastCalled(NotifyAlexaMediaLastCalledParameters data)
		{
			_haContext.CallService("notify", "alexa_media_last_called", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_last_called integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaLastCalled(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_last_called", null, new NotifyAlexaMediaLastCalledParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_scott_s_2nd_echo_dot integration.</summary>
		public void AlexaMediaScottS2ndEchoDot(NotifyAlexaMediaScottS2ndEchoDotParameters data)
		{
			_haContext.CallService("notify", "alexa_media_scott_s_2nd_echo_dot", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_scott_s_2nd_echo_dot integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaScottS2ndEchoDot(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_scott_s_2nd_echo_dot", null, new NotifyAlexaMediaScottS2ndEchoDotParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_scott_s_3rd_fire integration.</summary>
		public void AlexaMediaScottS3rdFire(NotifyAlexaMediaScottS3rdFireParameters data)
		{
			_haContext.CallService("notify", "alexa_media_scott_s_3rd_fire", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_scott_s_3rd_fire integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaScottS3rdFire(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_scott_s_3rd_fire", null, new NotifyAlexaMediaScottS3rdFireParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_scott_s_echo_show integration.</summary>
		public void AlexaMediaScottSEchoShow(NotifyAlexaMediaScottSEchoShowParameters data)
		{
			_haContext.CallService("notify", "alexa_media_scott_s_echo_show", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_scott_s_echo_show integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaScottSEchoShow(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_scott_s_echo_show", null, new NotifyAlexaMediaScottSEchoShowParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_scott_s_firetvstick integration.</summary>
		public void AlexaMediaScottSFiretvstick(NotifyAlexaMediaScottSFiretvstickParameters data)
		{
			_haContext.CallService("notify", "alexa_media_scott_s_firetvstick", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_scott_s_firetvstick integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaScottSFiretvstick(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_scott_s_firetvstick", null, new NotifyAlexaMediaScottSFiretvstickParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_sunroom_echo_dot integration.</summary>
		public void AlexaMediaSunroomEchoDot(NotifyAlexaMediaSunroomEchoDotParameters data)
		{
			_haContext.CallService("notify", "alexa_media_sunroom_echo_dot", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_sunroom_echo_dot integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaSunroomEchoDot(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_sunroom_echo_dot", null, new NotifyAlexaMediaSunroomEchoDotParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_theo_s_echo integration.</summary>
		public void AlexaMediaTheoSEcho(NotifyAlexaMediaTheoSEchoParameters data)
		{
			_haContext.CallService("notify", "alexa_media_theo_s_echo", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_theo_s_echo integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaTheoSEcho(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_theo_s_echo", null, new NotifyAlexaMediaTheoSEchoParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_tv_home_connect integration.</summary>
		public void AlexaMediaTvHomeConnect(NotifyAlexaMediaTvHomeConnectParameters data)
		{
			_haContext.CallService("notify", "alexa_media_tv_home_connect", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_tv_home_connect integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaTvHomeConnect(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_tv_home_connect", null, new NotifyAlexaMediaTvHomeConnectParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the lg_webos_tv_oled55a16la service.</summary>
		public void LgWebosTvOled55a16la(NotifyLgWebosTvOled55a16laParameters data)
		{
			_haContext.CallService("notify", "lg_webos_tv_oled55a16la", null, data);
		}

		///<summary>Sends a notification message using the lg_webos_tv_oled55a16la service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void LgWebosTvOled55a16la(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "lg_webos_tv_oled55a16la", null, new NotifyLgWebosTvOled55a16laParameters{Message = @message, Title = @title, Target = @target, Data = @data});
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

		///<summary>Sends a notification that is visible in the front-end.</summary>
		public void PersistentNotification(NotifyPersistentNotificationParameters data)
		{
			_haContext.CallService("notify", "persistent_notification", null, data);
		}

		///<summary>Sends a notification that is visible in the front-end.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		public void PersistentNotification(string @message, string? @title = null)
		{
			_haContext.CallService("notify", "persistent_notification", null, new NotifyPersistentNotificationParameters{Message = @message, Title = @title});
		}
	}

	public record NotifyAlexaMediaParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaEverywhereParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaFireTvParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaGarageEchoDotParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaJoSEchoParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaKitchenEchoParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaLastCalledParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaScottS2ndEchoDotParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaScottS3rdFireParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaScottSEchoShowParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaScottSFiretvstickParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaSunroomEchoDotParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaTheoSEchoParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaTvHomeConnectParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyLgWebosTvOled55a16laParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppJoSIphoneParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppScottSXrParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppTheosIphone6sParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyNotifyParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyPersistentNotificationParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public class NumberServices
	{
		private readonly IHaContext _haContext;
		public NumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, NumberSetValueParameters data)
		{
			_haContext.CallService("number", "set_value", target, data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public void SetValue(ServiceTarget target, string? @value = null)
		{
			_haContext.CallService("number", "set_value", target, new NumberSetValueParameters{Value = @value});
		}
	}

	public record NumberSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: 42</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class PersistentNotificationServices
	{
		private readonly IHaContext _haContext;
		public PersistentNotificationServices(IHaContext haContext)
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
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Optional title for your notification. [Templates accepted] eg: Test notification</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>Target ID of the notification, will replace a notification with the same ID. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationDismissParameters
	{
		///<summary>Target ID of the notification, which should be removed. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationMarkReadParameters
	{
		///<summary>Target ID of the notification, which should be mark read. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public class PersonServices
	{
		private readonly IHaContext _haContext;
		public PersonServices(IHaContext haContext)
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
		private readonly IHaContext _haContext;
		public RecorderServices(IHaContext haContext)
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
		public void PurgeEntities(ServiceTarget target, RecorderPurgeEntitiesParameters data)
		{
			_haContext.CallService("recorder", "purge_entities", target, data);
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="domains">List the domains that need to be removed from the recorder database. eg: sun</param>
		///<param name="entityGlobs">List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</param>
		public void PurgeEntities(ServiceTarget target, object? @domains = null, object? @entityGlobs = null)
		{
			_haContext.CallService("recorder", "purge_entities", target, new RecorderPurgeEntitiesParameters{Domains = @domains, EntityGlobs = @entityGlobs});
		}
	}

	public record RecorderPurgeParameters
	{
		///<summary>Number of history days to keep in database after purge.</summary>
		[JsonPropertyName("keep_days")]
		public long? KeepDays { get; init; }

		///<summary>Attempt to save disk space by rewriting the entire database file.</summary>
		[JsonPropertyName("repack")]
		public bool? Repack { get; init; }

		///<summary>Apply entity_id and event_type filter in addition to time based purge.</summary>
		[JsonPropertyName("apply_filter")]
		public bool? ApplyFilter { get; init; }
	}

	public record RecorderPurgeEntitiesParameters
	{
		///<summary>List the domains that need to be removed from the recorder database. eg: sun</summary>
		[JsonPropertyName("domains")]
		public object? Domains { get; init; }

		///<summary>List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</summary>
		[JsonPropertyName("entity_globs")]
		public object? EntityGlobs { get; init; }
	}

	public class ReolinkDevServices
	{
		private readonly IHaContext _haContext;
		public ReolinkDevServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Execute a PTZ command.</summary>
		///<param name="target">The target for this service call</param>
		public void PtzControl(ServiceTarget target, ReolinkDevPtzControlParameters data)
		{
			_haContext.CallService("reolink_dev", "ptz_control", target, data);
		}

		///<summary>Execute a PTZ command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="command">Command to execute. Possible values are: AUTO DOWN FOCUSDEC FOCUSINC LEFT LEFTDOWN LEFTUP RIGHT RIGHTDOWN RIGHTUP STOP TOPOS UP ZOOMDEC ZOOMINC eg: LEFTUP</param>
		///<param name="preset">(Optional) In case of the command TOPOS. The available presets are listed as attribute on the camera. eg: HOME</param>
		///<param name="speed">(Optional) Speed at which the movement takes place. eg: 25</param>
		public void PtzControl(ServiceTarget target, object? @entityId = null, object? @command = null, object? @preset = null, object? @speed = null)
		{
			_haContext.CallService("reolink_dev", "ptz_control", target, new ReolinkDevPtzControlParameters{EntityId = @entityId, Command = @command, Preset = @preset, Speed = @speed});
		}

		///<summary>For cameras that have Video-On-Demand Playback capability, this will query the camera and emit an reolink_dev-vod-data event for each matching VoD that matches the search parameters, it will also provide the thumbail path for the expected thumbnail.</summary>
		///<param name="target">The target for this service call</param>
		public void QueryVods(ServiceTarget target, ReolinkDevQueryVodsParameters data)
		{
			_haContext.CallService("reolink_dev", "query_vods", target, data);
		}

		///<summary>For cameras that have Video-On-Demand Playback capability, this will query the camera and emit an reolink_dev-vod-data event for each matching VoD that matches the search parameters, it will also provide the thumbail path for the expected thumbnail.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="eventId">Event to emit as eg: VoD-query</param>
		///<param name="start">Start of date range, if not provided will use the month playback range eg: 1/1/2021</param>
		///<param name="end">End of date range, if not provided will use the current date and time eg: 1/31/2021</param>
		public void QueryVods(ServiceTarget target, object? @entityId = null, object? @eventId = null, object? @start = null, object? @end = null)
		{
			_haContext.CallService("reolink_dev", "query_vods", target, new ReolinkDevQueryVodsParameters{EntityId = @entityId, EventId = @eventId, Start = @start, End = @end});
		}

		///<summary>Optimizing brightness and contrast levels to compensate for differences between dark and bright objects using either BLC or WDR mode. This may improve image clarity in high contrast situations, but it should be tested at different times of the day and night to ensure there is no negative effect.</summary>
		///<param name="target">The target for this service call</param>
		public void SetBacklight(ServiceTarget target, ReolinkDevSetBacklightParameters data)
		{
			_haContext.CallService("reolink_dev", "set_backlight", target, data);
		}

		///<summary>Optimizing brightness and contrast levels to compensate for differences between dark and bright objects using either BLC or WDR mode. This may improve image clarity in high contrast situations, but it should be tested at different times of the day and night to ensure there is no negative effect.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="mode">The backlight parameter supports the following values:   BACKLIGHTCONTROL: use Backlight Control   DYNAMICRANGECONTROL: use Dynamic Range Control   OFF: no optimization eg: DYNAMICRANGECONTROL</param>
		public void SetBacklight(ServiceTarget target, object? @entityId = null, object? @mode = null)
		{
			_haContext.CallService("reolink_dev", "set_backlight", target, new ReolinkDevSetBacklightParameters{EntityId = @entityId, Mode = @mode});
		}

		///<summary>Set day and night parameter.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDaynight(ServiceTarget target, ReolinkDevSetDaynightParameters data)
		{
			_haContext.CallService("reolink_dev", "set_daynight", target, data);
		}

		///<summary>Set day and night parameter.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="mode">The day and night mode parameter supports the following values:   AUTO: Auto switch between black & white mode   COLOR: Always record videos in color mode   BLACKANDWHITE: Always record videos in black & white mode eg: AUTO</param>
		public void SetDaynight(ServiceTarget target, object? @entityId = null, object? @mode = null)
		{
			_haContext.CallService("reolink_dev", "set_daynight", target, new ReolinkDevSetDaynightParameters{EntityId = @entityId, Mode = @mode});
		}

		///<summary>Set the motion detection sensitivity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSensitivity(ServiceTarget target, ReolinkDevSetSensitivityParameters data)
		{
			_haContext.CallService("reolink_dev", "set_sensitivity", target, data);
		}

		///<summary>Set the motion detection sensitivity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="sensitivity">New sensitivity, value between 1 (low sensitivity) and 50 (high sensitivity) eg: 25</param>
		///<param name="preset">(Optional) Set the sensitivity of a specific preset (time schedule). When no value is supplied, all presets will be changed.</param>
		public void SetSensitivity(ServiceTarget target, object? @entityId = null, object? @sensitivity = null, object? @preset = null)
		{
			_haContext.CallService("reolink_dev", "set_sensitivity", target, new ReolinkDevSetSensitivityParameters{EntityId = @entityId, Sensitivity = @sensitivity, Preset = @preset});
		}
	}

	public record ReolinkDevPtzControlParameters
	{
		///<summary>Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>Command to execute. Possible values are: AUTO DOWN FOCUSDEC FOCUSINC LEFT LEFTDOWN LEFTUP RIGHT RIGHTDOWN RIGHTUP STOP TOPOS UP ZOOMDEC ZOOMINC eg: LEFTUP</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }

		///<summary>(Optional) In case of the command TOPOS. The available presets are listed as attribute on the camera. eg: HOME</summary>
		[JsonPropertyName("preset")]
		public object? Preset { get; init; }

		///<summary>(Optional) Speed at which the movement takes place. eg: 25</summary>
		[JsonPropertyName("speed")]
		public object? Speed { get; init; }
	}

	public record ReolinkDevQueryVodsParameters
	{
		///<summary>Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>Event to emit as eg: VoD-query</summary>
		[JsonPropertyName("event_id")]
		public object? EventId { get; init; }

		///<summary>Start of date range, if not provided will use the month playback range eg: 1/1/2021</summary>
		[JsonPropertyName("start")]
		public object? Start { get; init; }

		///<summary>End of date range, if not provided will use the current date and time eg: 1/31/2021</summary>
		[JsonPropertyName("end")]
		public object? End { get; init; }
	}

	public record ReolinkDevSetBacklightParameters
	{
		///<summary>Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The backlight parameter supports the following values:   BACKLIGHTCONTROL: use Backlight Control   DYNAMICRANGECONTROL: use Dynamic Range Control   OFF: no optimization eg: DYNAMICRANGECONTROL</summary>
		[JsonPropertyName("mode")]
		public object? Mode { get; init; }
	}

	public record ReolinkDevSetDaynightParameters
	{
		///<summary>Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The day and night mode parameter supports the following values:   AUTO: Auto switch between black & white mode   COLOR: Always record videos in color mode   BLACKANDWHITE: Always record videos in black & white mode eg: AUTO</summary>
		[JsonPropertyName("mode")]
		public object? Mode { get; init; }
	}

	public record ReolinkDevSetSensitivityParameters
	{
		///<summary>Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>New sensitivity, value between 1 (low sensitivity) and 50 (high sensitivity) eg: 25</summary>
		[JsonPropertyName("sensitivity")]
		public object? Sensitivity { get; init; }

		///<summary>(Optional) Set the sensitivity of a specific preset (time schedule). When no value is supplied, all presets will be changed.</summary>
		[JsonPropertyName("preset")]
		public object? Preset { get; init; }
	}

	public class SceneServices
	{
		private readonly IHaContext _haContext;
		public SceneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Activate a scene with configuration.</summary>
		public void Apply(SceneApplyParameters data)
		{
			_haContext.CallService("scene", "apply", null, data);
		}

		///<summary>Activate a scene with configuration.</summary>
		///<param name="entities">The entities and the state that they need to be. eg: {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}</param>
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
		///<param name="entities">The entities to control with the scene. eg: {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}</param>
		///<param name="snapshotEntities">The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</param>
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
		public void TurnOn(ServiceTarget target, SceneTurnOnParameters data)
		{
			_haContext.CallService("scene", "turn_on", target, data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null)
		{
			_haContext.CallService("scene", "turn_on", target, new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public record SceneApplyParameters
	{
		///<summary>The entities and the state that they need to be. eg: {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public record SceneCreateParameters
	{
		///<summary>The entity_id of the new scene. eg: all_lights</summary>
		[JsonPropertyName("scene_id")]
		public string? SceneId { get; init; }

		///<summary>The entities to control with the scene. eg: {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</summary>
		[JsonPropertyName("snapshot_entities")]
		public object? SnapshotEntities { get; init; }
	}

	public record SceneTurnOnParameters
	{
		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public class ScriptServices
	{
		private readonly IHaContext _haContext;
		public ScriptServices(IHaContext haContext)
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
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("script", "toggle", target);
		}

		///<summary>Turn off script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_off", target);
		}

		///<summary>Turn on script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_on", target);
		}
	}

	public class SelectServices
	{
		private readonly IHaContext _haContext;
		public SelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, SelectSelectOptionParameters data)
		{
			_haContext.CallService("select", "select_option", target, data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("select", "select_option", target, new SelectSelectOptionParameters{Option = @option});
		}
	}

	public record SelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public class SirenServices
	{
		private readonly IHaContext _haContext;
		public SirenServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a siren.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("siren", "toggle", target);
		}

		///<summary>Turn siren off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("siren", "turn_off", target);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SirenTurnOnParameters data)
		{
			_haContext.CallService("siren", "turn_on", target, data);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tone">The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</param>
		///<param name="volumeLevel">The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0.5</param>
		///<param name="duration">The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</param>
		public void TurnOn(ServiceTarget target, string? @tone = null, double? @volumeLevel = null, string? @duration = null)
		{
			_haContext.CallService("siren", "turn_on", target, new SirenTurnOnParameters{Tone = @tone, VolumeLevel = @volumeLevel, Duration = @duration});
		}
	}

	public record SirenTurnOnParameters
	{
		///<summary>The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</summary>
		[JsonPropertyName("tone")]
		public string? Tone { get; init; }

		///<summary>The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0.5</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }

		///<summary>The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class SwitchServices
	{
		private readonly IHaContext _haContext;
		public SwitchServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a switch state</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("switch", "toggle", target);
		}

		///<summary>Turn a switch off</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_off", target);
		}

		///<summary>Turn a switch on</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_on", target);
		}
	}

	public class SystemLogServices
	{
		private readonly IHaContext _haContext;
		public SystemLogServices(IHaContext haContext)
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
		public void Write(string @message, object? @level = null, string? @logger = null)
		{
			_haContext.CallService("system_log", "write", null, new SystemLogWriteParameters{Message = @message, Level = @level, Logger = @logger});
		}
	}

	public record SystemLogWriteParameters
	{
		///<summary>Message to log. eg: Something went wrong</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Log level.</summary>
		[JsonPropertyName("level")]
		public object? Level { get; init; }

		///<summary>Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</summary>
		[JsonPropertyName("logger")]
		public string? Logger { get; init; }
	}

	public class TimerServices
	{
		private readonly IHaContext _haContext;
		public TimerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Cancel a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Cancel(ServiceTarget target)
		{
			_haContext.CallService("timer", "cancel", target);
		}

		///<summary>Finish a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Finish(ServiceTarget target)
		{
			_haContext.CallService("timer", "finish", target);
		}

		///<summary>Pause a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("timer", "pause", target);
		}

		public void Reload()
		{
			_haContext.CallService("timer", "reload", null);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target, TimerStartParameters data)
		{
			_haContext.CallService("timer", "start", target, data);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public void Start(ServiceTarget target, string? @duration = null)
		{
			_haContext.CallService("timer", "start", target, new TimerStartParameters{Duration = @duration});
		}
	}

	public record TimerStartParameters
	{
		///<summary>Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class TtsServices
	{
		private readonly IHaContext _haContext;
		public TtsServices(IHaContext haContext)
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
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Text to speak on devices. eg: My name is hanna</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Control file cache of this message.</summary>
		[JsonPropertyName("cache")]
		public bool? Cache { get; init; }

		///<summary>Language to use for speech generation. eg: ru</summary>
		[JsonPropertyName("language")]
		public string? Language { get; init; }

		///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public record TtsGoogleTranslateSayParameters
	{
		///<summary>Name(s) of media player entities.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Text to speak on devices. eg: My name is hanna</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Control file cache of this message.</summary>
		[JsonPropertyName("cache")]
		public bool? Cache { get; init; }

		///<summary>Language to use for speech generation. eg: ru</summary>
		[JsonPropertyName("language")]
		public string? Language { get; init; }

		///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class UpdateServices
	{
		private readonly IHaContext _haContext;
		public UpdateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Removes the skipped version marker from an update.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearSkipped(ServiceTarget target)
		{
			_haContext.CallService("update", "clear_skipped", target);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The target for this service call</param>
		public void Install(ServiceTarget target, UpdateInstallParameters data)
		{
			_haContext.CallService("update", "install", target, data);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The target for this service call</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public void Install(ServiceTarget target, string? @version = null, bool? @backup = null)
		{
			_haContext.CallService("update", "install", target, new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Mark currently available update as skipped.</summary>
		///<param name="target">The target for this service call</param>
		public void Skip(ServiceTarget target)
		{
			_haContext.CallService("update", "skip", target);
		}
	}

	public record UpdateInstallParameters
	{
		///<summary>Version to install, if omitted, the latest version will be installed. eg: 1.0.0</summary>
		[JsonPropertyName("version")]
		public string? Version { get; init; }

		///<summary>Backup before installing the update, if supported by the integration.</summary>
		[JsonPropertyName("backup")]
		public bool? Backup { get; init; }
	}

	public class VacuumServices
	{
		private readonly IHaContext _haContext;
		public VacuumServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		///<param name="target">The target for this service call</param>
		public void CleanSpot(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "clean_spot", target);
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		///<param name="target">The target for this service call</param>
		public void Locate(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "locate", target);
		}

		///<summary>Pause the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "pause", target);
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		///<param name="target">The target for this service call</param>
		public void ReturnToBase(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "return_to_base", target);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(ServiceTarget target, VacuumSendCommandParameters data)
		{
			_haContext.CallService("vacuum", "send_command", target, data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public void SendCommand(ServiceTarget target, string @command, object? @params = null)
		{
			_haContext.CallService("vacuum", "send_command", target, new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanSpeed(ServiceTarget target, VacuumSetFanSpeedParameters data)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public void SetFanSpeed(ServiceTarget target, string @fanSpeed)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start", target);
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void StartPause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start_pause", target);
		}

		///<summary>Stop the current cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Stop(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "stop", target);
		}

		public void Toggle()
		{
			_haContext.CallService("vacuum", "toggle", null);
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_off", target);
		}

		///<summary>Start a new cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_on", target);
		}
	}

	public record VacuumSendCommandParameters
	{
		///<summary>Command to execute. eg: set_dnd_timer</summary>
		[JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>Parameters for the command. eg: { "key": "value" }</summary>
		[JsonPropertyName("params")]
		public object? Params { get; init; }
	}

	public record VacuumSetFanSpeedParameters
	{
		///<summary>Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</summary>
		[JsonPropertyName("fan_speed")]
		public string? FanSpeed { get; init; }
	}

	public class WebostvServices
	{
		private readonly IHaContext _haContext;
		public WebostvServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send a button press command.</summary>
		public void Button(WebostvButtonParameters data)
		{
			_haContext.CallService("webostv", "button", null, data);
		}

		///<summary>Send a button press command.</summary>
		///<param name="entityId">Name(s) of the webostv entities where to run the API method.</param>
		///<param name="button">Name of the button to press.  Known possible values are LEFT, RIGHT, DOWN, UP, HOME, MENU, BACK, ENTER, DASH, INFO, ASTERISK, CC, EXIT, MUTE, RED, GREEN, BLUE, VOLUMEUP, VOLUMEDOWN, CHANNELUP, CHANNELDOWN, PLAY, PAUSE, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 eg: LEFT</param>
		public void Button(string @entityId, string @button)
		{
			_haContext.CallService("webostv", "button", null, new WebostvButtonParameters{EntityId = @entityId, Button = @button});
		}

		///<summary>Send a command.</summary>
		public void Command(WebostvCommandParameters data)
		{
			_haContext.CallService("webostv", "command", null, data);
		}

		///<summary>Send a command.</summary>
		///<param name="entityId">Name(s) of the webostv entities where to run the API method.</param>
		///<param name="command">Endpoint of the command. eg: system.launcher/open</param>
		///<param name="payload">An optional payload to provide to the endpoint in the format of key value pair(s). eg: target: https://www.google.com</param>
		public void Command(string @entityId, string @command, object? @payload = null)
		{
			_haContext.CallService("webostv", "command", null, new WebostvCommandParameters{EntityId = @entityId, Command = @command, Payload = @payload});
		}

		///<summary>Send the TV the command to change sound output.</summary>
		public void SelectSoundOutput(WebostvSelectSoundOutputParameters data)
		{
			_haContext.CallService("webostv", "select_sound_output", null, data);
		}

		///<summary>Send the TV the command to change sound output.</summary>
		///<param name="entityId">Name(s) of the webostv entities to change sound output on.</param>
		///<param name="soundOutput">Name of the sound output to switch to. eg: external_speaker</param>
		public void SelectSoundOutput(string @entityId, string @soundOutput)
		{
			_haContext.CallService("webostv", "select_sound_output", null, new WebostvSelectSoundOutputParameters{EntityId = @entityId, SoundOutput = @soundOutput});
		}
	}

	public record WebostvButtonParameters
	{
		///<summary>Name(s) of the webostv entities where to run the API method.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Name of the button to press.  Known possible values are LEFT, RIGHT, DOWN, UP, HOME, MENU, BACK, ENTER, DASH, INFO, ASTERISK, CC, EXIT, MUTE, RED, GREEN, BLUE, VOLUMEUP, VOLUMEDOWN, CHANNELUP, CHANNELDOWN, PLAY, PAUSE, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 eg: LEFT</summary>
		[JsonPropertyName("button")]
		public string? Button { get; init; }
	}

	public record WebostvCommandParameters
	{
		///<summary>Name(s) of the webostv entities where to run the API method.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Endpoint of the command. eg: system.launcher/open</summary>
		[JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>An optional payload to provide to the endpoint in the format of key value pair(s). eg: target: https://www.google.com</summary>
		[JsonPropertyName("payload")]
		public object? Payload { get; init; }
	}

	public record WebostvSelectSoundOutputParameters
	{
		///<summary>Name(s) of the webostv entities to change sound output on.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Name of the sound output to switch to. eg: external_speaker</summary>
		[JsonPropertyName("sound_output")]
		public string? SoundOutput { get; init; }
	}

	public class ZoneServices
	{
		private readonly IHaContext _haContext;
		public ZoneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the YAML-based zone configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("zone", "reload", null);
		}
	}

	public class ZwaveJsServices
	{
		private readonly IHaContext _haContext;
		public ZwaveJsServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Allow for bulk setting partial parameters. Useful when multiple partial parameters have to be set at the same time.</summary>
		///<param name="target">The target for this service call</param>
		public void BulkSetPartialConfigParameters(ServiceTarget target, ZwaveJsBulkSetPartialConfigParametersParameters data)
		{
			_haContext.CallService("zwave_js", "bulk_set_partial_config_parameters", target, data);
		}

		///<summary>Allow for bulk setting partial parameters. Useful when multiple partial parameters have to be set at the same time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="parameter">The id of the configuration parameter you want to configure. eg: 9</param>
		///<param name="value">The new value(s) to set for this configuration parameter. Can either be a raw integer value to represent the bulk change or a mapping where the key is the bitmask (either in hex or integer form) and the value is the new value you want to set for that partial parameter. eg: {"0x1":1,"0x10":1,"0x20":1,"0x40":1}</param>
		public void BulkSetPartialConfigParameters(ServiceTarget target, string @parameter, object @value)
		{
			_haContext.CallService("zwave_js", "bulk_set_partial_config_parameters", target, new ZwaveJsBulkSetPartialConfigParametersParameters{Parameter = @parameter, Value = @value});
		}

		///<summary>Allows for calling a Command Class API on a node. Some Command Classes can't be fully controlled via the `set_value` service and require direct calls to the Command Class API.</summary>
		///<param name="target">The target for this service call</param>
		public void InvokeCcApi(ServiceTarget target, ZwaveJsInvokeCcApiParameters data)
		{
			_haContext.CallService("zwave_js", "invoke_cc_api", target, data);
		}

		///<summary>Allows for calling a Command Class API on a node. Some Command Classes can't be fully controlled via the `set_value` service and require direct calls to the Command Class API.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="commandClass">The ID of the command class that you want to issue a command to. eg: 132</param>
		///<param name="endpoint">The endpoint to call the API on. If an endpoint is specified, that endpoint will be targeted for all nodes associated with the target areas, devices, and/or entities. If an endpoint is not specified, the root endpoint (0) will be targeted for nodes associated with target areas and devices, and the endpoint for the primary value of each entity will be targeted. eg: 1</param>
		///<param name="methodName">The name of the API method to call. Refer to the Z-Wave JS Command Class API documentation (https://zwave-js.github.io/node-zwave-js/#/api/CCs/index) for available methods. eg: setInterval</param>
		///<param name="parameters">A list of parameters to pass to the API method. Refer to the Z-Wave JS Command Class API documentation (https://zwave-js.github.io/node-zwave-js/#/api/CCs/index) for parameters. eg: [1,1]</param>
		public void InvokeCcApi(ServiceTarget target, string @commandClass, string @methodName, object @parameters, string? @endpoint = null)
		{
			_haContext.CallService("zwave_js", "invoke_cc_api", target, new ZwaveJsInvokeCcApiParameters{CommandClass = @commandClass, Endpoint = @endpoint, MethodName = @methodName, Parameters = @parameters});
		}

		///<summary>Allow for changing any value that Z-Wave JS recognizes on multiple Z-Wave devices using multicast, so all devices receive the message simultaneously. This service has minimal validation so only use this service if you know what you are doing.</summary>
		///<param name="target">The target for this service call</param>
		public void MulticastSetValue(ServiceTarget target, ZwaveJsMulticastSetValueParameters data)
		{
			_haContext.CallService("zwave_js", "multicast_set_value", target, data);
		}

		///<summary>Allow for changing any value that Z-Wave JS recognizes on multiple Z-Wave devices using multicast, so all devices receive the message simultaneously. This service has minimal validation so only use this service if you know what you are doing.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="broadcast">Whether command should be broadcast to all devices on the network. eg: True</param>
		///<param name="commandClass">The ID of the command class for the value. eg: 117</param>
		///<param name="endpoint">The endpoint for the value. eg: 1</param>
		///<param name="property">The ID of the property for the value. eg: currentValue</param>
		///<param name="propertyKey">The ID of the property key for the value eg: 1</param>
		///<param name="options">Set value options map. Refer to the Z-Wave JS documentation for more information on what options can be set.</param>
		///<param name="value">The new value to set. eg: ffbb99</param>
		public void MulticastSetValue(ServiceTarget target, string @commandClass, string @property, object @value, bool? @broadcast = null, string? @endpoint = null, string? @propertyKey = null, object? @options = null)
		{
			_haContext.CallService("zwave_js", "multicast_set_value", target, new ZwaveJsMulticastSetValueParameters{Broadcast = @broadcast, CommandClass = @commandClass, Endpoint = @endpoint, Property = @property, PropertyKey = @propertyKey, Options = @options, Value = @value});
		}

		///<summary>Forces Z-Wave JS to try to reach a node. This can be used to update the status of the node in Z-Wave JS when you think it doesn't accurately reflect reality, e.g. reviving a failed/dead node or marking the node as asleep.</summary>
		///<param name="target">The target for this service call</param>
		public void Ping(ServiceTarget target)
		{
			_haContext.CallService("zwave_js", "ping", target);
		}

		///<summary>Force update value(s) for a Z-Wave entity</summary>
		public void RefreshValue(ZwaveJsRefreshValueParameters data)
		{
			_haContext.CallService("zwave_js", "refresh_value", null, data);
		}

		///<summary>Force update value(s) for a Z-Wave entity</summary>
		///<param name="entityId">Entity whose value(s) should be refreshed eg: sensor.family_room_motion</param>
		///<param name="refreshAllValues">Whether to refresh all values (true) or just the primary value (false)</param>
		public void RefreshValue(string @entityId, bool? @refreshAllValues = null)
		{
			_haContext.CallService("zwave_js", "refresh_value", null, new ZwaveJsRefreshValueParameters{EntityId = @entityId, RefreshAllValues = @refreshAllValues});
		}

		///<summary>Allow for changing configuration parameters of your Z-Wave devices.</summary>
		///<param name="target">The target for this service call</param>
		public void SetConfigParameter(ServiceTarget target, ZwaveJsSetConfigParameterParameters data)
		{
			_haContext.CallService("zwave_js", "set_config_parameter", target, data);
		}

		///<summary>Allow for changing configuration parameters of your Z-Wave devices.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="parameter">The (name or id of the) configuration parameter you want to configure. eg: Minimum brightness level</param>
		///<param name="value">The new value to set for this configuration parameter. eg: 5</param>
		///<param name="bitmask">Target a specific bitmask (see the documentation for more information).</param>
		public void SetConfigParameter(ServiceTarget target, string @parameter, string @value, string? @bitmask = null)
		{
			_haContext.CallService("zwave_js", "set_config_parameter", target, new ZwaveJsSetConfigParameterParameters{Parameter = @parameter, Value = @value, Bitmask = @bitmask});
		}

		///<summary>Allow for changing any value that Z-Wave JS recognizes on a Z-Wave device. This service has minimal validation so only use this service if you know what you are doing.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, ZwaveJsSetValueParameters data)
		{
			_haContext.CallService("zwave_js", "set_value", target, data);
		}

		///<summary>Allow for changing any value that Z-Wave JS recognizes on a Z-Wave device. This service has minimal validation so only use this service if you know what you are doing.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="commandClass">The ID of the command class for the value. eg: 117</param>
		///<param name="endpoint">The endpoint for the value. eg: 1</param>
		///<param name="property">The ID of the property for the value. eg: currentValue</param>
		///<param name="propertyKey">The ID of the property key for the value eg: 1</param>
		///<param name="value">The new value to set. eg: ffbb99</param>
		///<param name="options">Set value options map. Refer to the Z-Wave JS documentation for more information on what options can be set.</param>
		///<param name="waitForResult">Whether or not to wait for a response from the node. If not included in the payload, the integration will decide whether to wait or not. If set to `true`, note that the service call can take a while if setting a value on an asleep battery device.</param>
		public void SetValue(ServiceTarget target, string @commandClass, string @property, object @value, string? @endpoint = null, string? @propertyKey = null, object? @options = null, bool? @waitForResult = null)
		{
			_haContext.CallService("zwave_js", "set_value", target, new ZwaveJsSetValueParameters{CommandClass = @commandClass, Endpoint = @endpoint, Property = @property, PropertyKey = @propertyKey, Value = @value, Options = @options, WaitForResult = @waitForResult});
		}
	}

	public record ZwaveJsBulkSetPartialConfigParametersParameters
	{
		///<summary>The id of the configuration parameter you want to configure. eg: 9</summary>
		[JsonPropertyName("parameter")]
		public string? Parameter { get; init; }

		///<summary>The new value(s) to set for this configuration parameter. Can either be a raw integer value to represent the bulk change or a mapping where the key is the bitmask (either in hex or integer form) and the value is the new value you want to set for that partial parameter. eg: {"0x1":1,"0x10":1,"0x20":1,"0x40":1}</summary>
		[JsonPropertyName("value")]
		public object? Value { get; init; }
	}

	public record ZwaveJsInvokeCcApiParameters
	{
		///<summary>The ID of the command class that you want to issue a command to. eg: 132</summary>
		[JsonPropertyName("command_class")]
		public string? CommandClass { get; init; }

		///<summary>The endpoint to call the API on. If an endpoint is specified, that endpoint will be targeted for all nodes associated with the target areas, devices, and/or entities. If an endpoint is not specified, the root endpoint (0) will be targeted for nodes associated with target areas and devices, and the endpoint for the primary value of each entity will be targeted. eg: 1</summary>
		[JsonPropertyName("endpoint")]
		public string? Endpoint { get; init; }

		///<summary>The name of the API method to call. Refer to the Z-Wave JS Command Class API documentation (https://zwave-js.github.io/node-zwave-js/#/api/CCs/index) for available methods. eg: setInterval</summary>
		[JsonPropertyName("method_name")]
		public string? MethodName { get; init; }

		///<summary>A list of parameters to pass to the API method. Refer to the Z-Wave JS Command Class API documentation (https://zwave-js.github.io/node-zwave-js/#/api/CCs/index) for parameters. eg: [1,1]</summary>
		[JsonPropertyName("parameters")]
		public object? Parameters { get; init; }
	}

	public record ZwaveJsMulticastSetValueParameters
	{
		///<summary>Whether command should be broadcast to all devices on the network. eg: True</summary>
		[JsonPropertyName("broadcast")]
		public bool? Broadcast { get; init; }

		///<summary>The ID of the command class for the value. eg: 117</summary>
		[JsonPropertyName("command_class")]
		public string? CommandClass { get; init; }

		///<summary>The endpoint for the value. eg: 1</summary>
		[JsonPropertyName("endpoint")]
		public string? Endpoint { get; init; }

		///<summary>The ID of the property for the value. eg: currentValue</summary>
		[JsonPropertyName("property")]
		public string? Property { get; init; }

		///<summary>The ID of the property key for the value eg: 1</summary>
		[JsonPropertyName("property_key")]
		public string? PropertyKey { get; init; }

		///<summary>Set value options map. Refer to the Z-Wave JS documentation for more information on what options can be set.</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }

		///<summary>The new value to set. eg: ffbb99</summary>
		[JsonPropertyName("value")]
		public object? Value { get; init; }
	}

	public record ZwaveJsRefreshValueParameters
	{
		///<summary>Entity whose value(s) should be refreshed eg: sensor.family_room_motion</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Whether to refresh all values (true) or just the primary value (false)</summary>
		[JsonPropertyName("refresh_all_values")]
		public bool? RefreshAllValues { get; init; }
	}

	public record ZwaveJsSetConfigParameterParameters
	{
		///<summary>The (name or id of the) configuration parameter you want to configure. eg: Minimum brightness level</summary>
		[JsonPropertyName("parameter")]
		public string? Parameter { get; init; }

		///<summary>The new value to set for this configuration parameter. eg: 5</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }

		///<summary>Target a specific bitmask (see the documentation for more information).</summary>
		[JsonPropertyName("bitmask")]
		public string? Bitmask { get; init; }
	}

	public record ZwaveJsSetValueParameters
	{
		///<summary>The ID of the command class for the value. eg: 117</summary>
		[JsonPropertyName("command_class")]
		public string? CommandClass { get; init; }

		///<summary>The endpoint for the value. eg: 1</summary>
		[JsonPropertyName("endpoint")]
		public string? Endpoint { get; init; }

		///<summary>The ID of the property for the value. eg: currentValue</summary>
		[JsonPropertyName("property")]
		public string? Property { get; init; }

		///<summary>The ID of the property key for the value eg: 1</summary>
		[JsonPropertyName("property_key")]
		public string? PropertyKey { get; init; }

		///<summary>The new value to set. eg: ffbb99</summary>
		[JsonPropertyName("value")]
		public object? Value { get; init; }

		///<summary>Set value options map. Refer to the Z-Wave JS documentation for more information on what options can be set.</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }

		///<summary>Whether or not to wait for a response from the node. If not included in the payload, the integration will decide whether to wait or not. If set to `true`, note that the service call can take a while if setting a value on an asleep battery device.</summary>
		[JsonPropertyName("wait_for_result")]
		public bool? WaitForResult { get; init; }
	}

	public static class AutomationEntityExtensionMethods
	{
		///<summary>Toggle (enable / disable) an automation.</summary>
		public static void Toggle(this AutomationEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		public static void Toggle(this IEnumerable<AutomationEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Trigger the actions of an automation.</summary>
		public static void Trigger(this AutomationEntity target, AutomationTriggerParameters data)
		{
			target.CallService("trigger", data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		public static void Trigger(this IEnumerable<AutomationEntity> target, AutomationTriggerParameters data)
		{
			target.CallService("trigger", data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The AutomationEntity to call this service for</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public static void Trigger(this AutomationEntity target, bool? @skipCondition = null)
		{
			target.CallService("trigger", new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public static void Trigger(this IEnumerable<AutomationEntity> target, bool? @skipCondition = null)
		{
			target.CallService("trigger", new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		public static void TurnOff(this AutomationEntity target, AutomationTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Disable an automation.</summary>
		public static void TurnOff(this IEnumerable<AutomationEntity> target, AutomationTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The AutomationEntity to call this service for</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public static void TurnOff(this AutomationEntity target, bool? @stopActions = null)
		{
			target.CallService("turn_off", new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public static void TurnOff(this IEnumerable<AutomationEntity> target, bool? @stopActions = null)
		{
			target.CallService("turn_off", new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		public static void TurnOn(this AutomationEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Enable an automation.</summary>
		public static void TurnOn(this IEnumerable<AutomationEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class ButtonEntityExtensionMethods
	{
		///<summary>Press the button entity.</summary>
		public static void Press(this ButtonEntity target)
		{
			target.CallService("press");
		}

		///<summary>Press the button entity.</summary>
		public static void Press(this IEnumerable<ButtonEntity> target)
		{
			target.CallService("press");
		}
	}

	public static class CameraEntityExtensionMethods
	{
		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this CameraEntity target)
		{
			target.CallService("disable_motion_detection");
		}

		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this IEnumerable<CameraEntity> target)
		{
			target.CallService("disable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this CameraEntity target)
		{
			target.CallService("enable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this IEnumerable<CameraEntity> target)
		{
			target.CallService("enable_motion_detection");
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this CameraEntity target, CameraPlayStreamParameters data)
		{
			target.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this IEnumerable<CameraEntity> target, CameraPlayStreamParameters data)
		{
			target.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this CameraEntity target, string @mediaPlayer, object? @format = null)
		{
			target.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this IEnumerable<CameraEntity> target, string @mediaPlayer, object? @format = null)
		{
			target.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this CameraEntity target, CameraRecordParameters data)
		{
			target.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this IEnumerable<CameraEntity> target, CameraRecordParameters data)
		{
			target.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this CameraEntity target, string @filename, long? @duration = null, long? @lookback = null)
		{
			target.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this IEnumerable<CameraEntity> target, string @filename, long? @duration = null, long? @lookback = null)
		{
			target.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this CameraEntity target, CameraSnapshotParameters data)
		{
			target.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this IEnumerable<CameraEntity> target, CameraSnapshotParameters data)
		{
			target.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this CameraEntity target, string @filename)
		{
			target.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this IEnumerable<CameraEntity> target, string @filename)
		{
			target.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this CameraEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this IEnumerable<CameraEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this CameraEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this IEnumerable<CameraEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class ClimateEntityExtensionMethods
	{
		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this ClimateEntity target, ClimateSetAuxHeatParameters data)
		{
			target.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, ClimateSetAuxHeatParameters data)
		{
			target.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this ClimateEntity target, bool @auxHeat)
		{
			target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, bool @auxHeat)
		{
			target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this ClimateEntity target, ClimateSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this IEnumerable<ClimateEntity> target, ClimateSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this ClimateEntity target, string @fanMode)
		{
			target.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this IEnumerable<ClimateEntity> target, string @fanMode)
		{
			target.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this ClimateEntity target, ClimateSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this IEnumerable<ClimateEntity> target, ClimateSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this ClimateEntity target, long @humidity)
		{
			target.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this IEnumerable<ClimateEntity> target, long @humidity)
		{
			target.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this ClimateEntity target, ClimateSetHvacModeParameters data)
		{
			target.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this IEnumerable<ClimateEntity> target, ClimateSetHvacModeParameters data)
		{
			target.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this ClimateEntity target, object? @hvacMode = null)
		{
			target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this IEnumerable<ClimateEntity> target, object? @hvacMode = null)
		{
			target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this ClimateEntity target, ClimateSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this IEnumerable<ClimateEntity> target, ClimateSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this ClimateEntity target, string @presetMode)
		{
			target.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this IEnumerable<ClimateEntity> target, string @presetMode)
		{
			target.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this ClimateEntity target, ClimateSetSwingModeParameters data)
		{
			target.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this IEnumerable<ClimateEntity> target, ClimateSetSwingModeParameters data)
		{
			target.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this ClimateEntity target, string @swingMode)
		{
			target.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this IEnumerable<ClimateEntity> target, string @swingMode)
		{
			target.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this ClimateEntity target, ClimateSetTemperatureParameters data)
		{
			target.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this IEnumerable<ClimateEntity> target, ClimateSetTemperatureParameters data)
		{
			target.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this ClimateEntity target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			target.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this IEnumerable<ClimateEntity> target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			target.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this ClimateEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this IEnumerable<ClimateEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this ClimateEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this IEnumerable<ClimateEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class CoverEntityExtensionMethods
	{
		///<summary>Close all or specified cover.</summary>
		public static void CloseCover(this CoverEntity target)
		{
			target.CallService("close_cover");
		}

		///<summary>Close all or specified cover.</summary>
		public static void CloseCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("close_cover");
		}

		///<summary>Close all or specified cover tilt.</summary>
		public static void CloseCoverTilt(this CoverEntity target)
		{
			target.CallService("close_cover_tilt");
		}

		///<summary>Close all or specified cover tilt.</summary>
		public static void CloseCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("close_cover_tilt");
		}

		///<summary>Open all or specified cover.</summary>
		public static void OpenCover(this CoverEntity target)
		{
			target.CallService("open_cover");
		}

		///<summary>Open all or specified cover.</summary>
		public static void OpenCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("open_cover");
		}

		///<summary>Open all or specified cover tilt.</summary>
		public static void OpenCoverTilt(this CoverEntity target)
		{
			target.CallService("open_cover_tilt");
		}

		///<summary>Open all or specified cover tilt.</summary>
		public static void OpenCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("open_cover_tilt");
		}

		///<summary>Move to specific position all or specified cover.</summary>
		public static void SetCoverPosition(this CoverEntity target, CoverSetCoverPositionParameters data)
		{
			target.CallService("set_cover_position", data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		public static void SetCoverPosition(this IEnumerable<CoverEntity> target, CoverSetCoverPositionParameters data)
		{
			target.CallService("set_cover_position", data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The CoverEntity to call this service for</param>
		///<param name="position">Position of the cover</param>
		public static void SetCoverPosition(this CoverEntity target, long @position)
		{
			target.CallService("set_cover_position", new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The IEnumerable<CoverEntity> to call this service for</param>
		///<param name="position">Position of the cover</param>
		public static void SetCoverPosition(this IEnumerable<CoverEntity> target, long @position)
		{
			target.CallService("set_cover_position", new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		public static void SetCoverTiltPosition(this CoverEntity target, CoverSetCoverTiltPositionParameters data)
		{
			target.CallService("set_cover_tilt_position", data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		public static void SetCoverTiltPosition(this IEnumerable<CoverEntity> target, CoverSetCoverTiltPositionParameters data)
		{
			target.CallService("set_cover_tilt_position", data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The CoverEntity to call this service for</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public static void SetCoverTiltPosition(this CoverEntity target, long @tiltPosition)
		{
			target.CallService("set_cover_tilt_position", new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The IEnumerable<CoverEntity> to call this service for</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public static void SetCoverTiltPosition(this IEnumerable<CoverEntity> target, long @tiltPosition)
		{
			target.CallService("set_cover_tilt_position", new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCover(this CoverEntity target)
		{
			target.CallService("stop_cover");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("stop_cover");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCoverTilt(this CoverEntity target)
		{
			target.CallService("stop_cover_tilt");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("stop_cover_tilt");
		}

		///<summary>Toggle a cover open/closed.</summary>
		public static void Toggle(this CoverEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle a cover open/closed.</summary>
		public static void Toggle(this IEnumerable<CoverEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		public static void ToggleCoverTilt(this CoverEntity target)
		{
			target.CallService("toggle_cover_tilt");
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		public static void ToggleCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("toggle_cover_tilt");
		}
	}

	public static class HiveEntityExtensionMethods
	{
		///<summary>To be deprecated please use boost_heating_on.</summary>
		public static void BoostHeating(this ClimateEntity target, HiveBoostHeatingParameters data)
		{
			target.CallService("boost_heating", data);
		}

		///<summary>To be deprecated please use boost_heating_on.</summary>
		public static void BoostHeating(this IEnumerable<ClimateEntity> target, HiveBoostHeatingParameters data)
		{
			target.CallService("boost_heating", data);
		}

		///<summary>To be deprecated please use boost_heating_on.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="timePeriod">Set the time period for the boost. eg: 01:30:00</param>
		///<param name="temperature">Set the target temperature for the boost period.</param>
		public static void BoostHeating(this ClimateEntity target, DateTime @timePeriod, double? @temperature = null)
		{
			target.CallService("boost_heating", new HiveBoostHeatingParameters{TimePeriod = @timePeriod, Temperature = @temperature});
		}

		///<summary>To be deprecated please use boost_heating_on.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="timePeriod">Set the time period for the boost. eg: 01:30:00</param>
		///<param name="temperature">Set the target temperature for the boost period.</param>
		public static void BoostHeating(this IEnumerable<ClimateEntity> target, DateTime @timePeriod, double? @temperature = null)
		{
			target.CallService("boost_heating", new HiveBoostHeatingParameters{TimePeriod = @timePeriod, Temperature = @temperature});
		}

		///<summary>Set the boost mode ON defining the period of time and the desired target temperature for the boost.</summary>
		public static void BoostHeatingOn(this ClimateEntity target, HiveBoostHeatingOnParameters data)
		{
			target.CallService("boost_heating_on", data);
		}

		///<summary>Set the boost mode ON defining the period of time and the desired target temperature for the boost.</summary>
		public static void BoostHeatingOn(this IEnumerable<ClimateEntity> target, HiveBoostHeatingOnParameters data)
		{
			target.CallService("boost_heating_on", data);
		}

		///<summary>Set the boost mode ON defining the period of time and the desired target temperature for the boost.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="timePeriod">Set the time period for the boost. eg: 01:30:00</param>
		///<param name="temperature">Set the target temperature for the boost period.</param>
		public static void BoostHeatingOn(this ClimateEntity target, DateTime @timePeriod, double? @temperature = null)
		{
			target.CallService("boost_heating_on", new HiveBoostHeatingOnParameters{TimePeriod = @timePeriod, Temperature = @temperature});
		}

		///<summary>Set the boost mode ON defining the period of time and the desired target temperature for the boost.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="timePeriod">Set the time period for the boost. eg: 01:30:00</param>
		///<param name="temperature">Set the target temperature for the boost period.</param>
		public static void BoostHeatingOn(this IEnumerable<ClimateEntity> target, DateTime @timePeriod, double? @temperature = null)
		{
			target.CallService("boost_heating_on", new HiveBoostHeatingOnParameters{TimePeriod = @timePeriod, Temperature = @temperature});
		}
	}

	public static class HueEntityExtensionMethods
	{
		///<summary>Activate a Hue scene with more control over the options.</summary>
		public static void ActivateScene(this SceneEntity target, HueActivateSceneParameters data)
		{
			target.CallService("activate_scene", data);
		}

		///<summary>Activate a Hue scene with more control over the options.</summary>
		public static void ActivateScene(this IEnumerable<SceneEntity> target, HueActivateSceneParameters data)
		{
			target.CallService("activate_scene", data);
		}

		///<summary>Activate a Hue scene with more control over the options.</summary>
		///<param name="target">The SceneEntity to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		///<param name="dynamic">Enable dynamic mode of the scene.</param>
		///<param name="speed">Speed of dynamic palette for this scene</param>
		///<param name="brightness">Set brightness for the scene.</param>
		public static void ActivateScene(this SceneEntity target, long? @transition = null, bool? @dynamic = null, long? @speed = null, long? @brightness = null)
		{
			target.CallService("activate_scene", new HueActivateSceneParameters{Transition = @transition, Dynamic = @dynamic, Speed = @speed, Brightness = @brightness});
		}

		///<summary>Activate a Hue scene with more control over the options.</summary>
		///<param name="target">The IEnumerable<SceneEntity> to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		///<param name="dynamic">Enable dynamic mode of the scene.</param>
		///<param name="speed">Speed of dynamic palette for this scene</param>
		///<param name="brightness">Set brightness for the scene.</param>
		public static void ActivateScene(this IEnumerable<SceneEntity> target, long? @transition = null, bool? @dynamic = null, long? @speed = null, long? @brightness = null)
		{
			target.CallService("activate_scene", new HueActivateSceneParameters{Transition = @transition, Dynamic = @dynamic, Speed = @speed, Brightness = @brightness});
		}
	}

	public static class InputBooleanEntityExtensionMethods
	{
		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this InputBooleanEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this InputBooleanEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this InputBooleanEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class LightEntityExtensionMethods
	{
		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this LightEntity target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this IEnumerable<LightEntity> target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The LightEntity to call this service for</param>
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
		public static void Toggle(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
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
		public static void Toggle(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this LightEntity target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this IEnumerable<LightEntity> target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this LightEntity target, long? @transition = null, object? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this IEnumerable<LightEntity> target, long? @transition = null, object? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this LightEntity target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this IEnumerable<LightEntity> target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
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
		public static void TurnOn(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
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
		public static void TurnOn(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public static class LockEntityExtensionMethods
	{
		///<summary>Lock all or specified locks.</summary>
		public static void Lock(this LockEntity target, LockLockParameters data)
		{
			target.CallService("lock", data);
		}

		///<summary>Lock all or specified locks.</summary>
		public static void Lock(this IEnumerable<LockEntity> target, LockLockParameters data)
		{
			target.CallService("lock", data);
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public static void Lock(this LockEntity target, string? @code = null)
		{
			target.CallService("lock", new LockLockParameters{Code = @code});
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public static void Lock(this IEnumerable<LockEntity> target, string? @code = null)
		{
			target.CallService("lock", new LockLockParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		public static void Open(this LockEntity target, LockOpenParameters data)
		{
			target.CallService("open", data);
		}

		///<summary>Open all or specified locks.</summary>
		public static void Open(this IEnumerable<LockEntity> target, LockOpenParameters data)
		{
			target.CallService("open", data);
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public static void Open(this LockEntity target, string? @code = null)
		{
			target.CallService("open", new LockOpenParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public static void Open(this IEnumerable<LockEntity> target, string? @code = null)
		{
			target.CallService("open", new LockOpenParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		public static void Unlock(this LockEntity target, LockUnlockParameters data)
		{
			target.CallService("unlock", data);
		}

		///<summary>Unlock all or specified locks.</summary>
		public static void Unlock(this IEnumerable<LockEntity> target, LockUnlockParameters data)
		{
			target.CallService("unlock", data);
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public static void Unlock(this LockEntity target, string? @code = null)
		{
			target.CallService("unlock", new LockUnlockParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public static void Unlock(this IEnumerable<LockEntity> target, string? @code = null)
		{
			target.CallService("unlock", new LockUnlockParameters{Code = @code});
		}
	}

	public static class MediaPlayerEntityExtensionMethods
	{
		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this MediaPlayerEntity target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this MediaPlayerEntity target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</param>
		public static void Join(this MediaPlayerEntity target, object? @groupMembers = null)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</param>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, object? @groupMembers = null)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this MediaPlayerEntity target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this MediaPlayerEntity target)
		{
			target.CallService("media_play");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this MediaPlayerEntity target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this MediaPlayerEntity target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this MediaPlayerEntity target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this MediaPlayerEntity target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this MediaPlayerEntity target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public static void PlayMedia(this MediaPlayerEntity target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this MediaPlayerEntity target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this MediaPlayerEntity target, object @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, object @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this MediaPlayerEntity target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this MediaPlayerEntity target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this MediaPlayerEntity target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this MediaPlayerEntity target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this MediaPlayerEntity target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this MediaPlayerEntity target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this MediaPlayerEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this MediaPlayerEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this MediaPlayerEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_on");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this MediaPlayerEntity target)
		{
			target.CallService("unjoin");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("unjoin");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this MediaPlayerEntity target)
		{
			target.CallService("volume_down");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_down");
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this MediaPlayerEntity target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this MediaPlayerEntity target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this MediaPlayerEntity target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this MediaPlayerEntity target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this MediaPlayerEntity target)
		{
			target.CallService("volume_up");
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_up");
		}
	}

	public static class NumberEntityExtensionMethods
	{
		///<summary>Set the value of a Number entity.</summary>
		public static void SetValue(this NumberEntity target, NumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of a Number entity.</summary>
		public static void SetValue(this IEnumerable<NumberEntity> target, NumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The NumberEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public static void SetValue(this NumberEntity target, string? @value = null)
		{
			target.CallService("set_value", new NumberSetValueParameters{Value = @value});
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The IEnumerable<NumberEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public static void SetValue(this IEnumerable<NumberEntity> target, string? @value = null)
		{
			target.CallService("set_value", new NumberSetValueParameters{Value = @value});
		}
	}

	public static class ReolinkDevEntityExtensionMethods
	{
		///<summary>Execute a PTZ command.</summary>
		public static void PtzControl(this CameraEntity target, ReolinkDevPtzControlParameters data)
		{
			target.CallService("ptz_control", data);
		}

		///<summary>Execute a PTZ command.</summary>
		public static void PtzControl(this IEnumerable<CameraEntity> target, ReolinkDevPtzControlParameters data)
		{
			target.CallService("ptz_control", data);
		}

		///<summary>Execute a PTZ command.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="command">Command to execute. Possible values are: AUTO DOWN FOCUSDEC FOCUSINC LEFT LEFTDOWN LEFTUP RIGHT RIGHTDOWN RIGHTUP STOP TOPOS UP ZOOMDEC ZOOMINC eg: LEFTUP</param>
		///<param name="preset">(Optional) In case of the command TOPOS. The available presets are listed as attribute on the camera. eg: HOME</param>
		///<param name="speed">(Optional) Speed at which the movement takes place. eg: 25</param>
		public static void PtzControl(this CameraEntity target, object? @entityId = null, object? @command = null, object? @preset = null, object? @speed = null)
		{
			target.CallService("ptz_control", new ReolinkDevPtzControlParameters{EntityId = @entityId, Command = @command, Preset = @preset, Speed = @speed});
		}

		///<summary>Execute a PTZ command.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="command">Command to execute. Possible values are: AUTO DOWN FOCUSDEC FOCUSINC LEFT LEFTDOWN LEFTUP RIGHT RIGHTDOWN RIGHTUP STOP TOPOS UP ZOOMDEC ZOOMINC eg: LEFTUP</param>
		///<param name="preset">(Optional) In case of the command TOPOS. The available presets are listed as attribute on the camera. eg: HOME</param>
		///<param name="speed">(Optional) Speed at which the movement takes place. eg: 25</param>
		public static void PtzControl(this IEnumerable<CameraEntity> target, object? @entityId = null, object? @command = null, object? @preset = null, object? @speed = null)
		{
			target.CallService("ptz_control", new ReolinkDevPtzControlParameters{EntityId = @entityId, Command = @command, Preset = @preset, Speed = @speed});
		}

		///<summary>For cameras that have Video-On-Demand Playback capability, this will query the camera and emit an reolink_dev-vod-data event for each matching VoD that matches the search parameters, it will also provide the thumbail path for the expected thumbnail.</summary>
		public static void QueryVods(this CameraEntity target, ReolinkDevQueryVodsParameters data)
		{
			target.CallService("query_vods", data);
		}

		///<summary>For cameras that have Video-On-Demand Playback capability, this will query the camera and emit an reolink_dev-vod-data event for each matching VoD that matches the search parameters, it will also provide the thumbail path for the expected thumbnail.</summary>
		public static void QueryVods(this IEnumerable<CameraEntity> target, ReolinkDevQueryVodsParameters data)
		{
			target.CallService("query_vods", data);
		}

		///<summary>For cameras that have Video-On-Demand Playback capability, this will query the camera and emit an reolink_dev-vod-data event for each matching VoD that matches the search parameters, it will also provide the thumbail path for the expected thumbnail.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="eventId">Event to emit as eg: VoD-query</param>
		///<param name="start">Start of date range, if not provided will use the month playback range eg: 1/1/2021</param>
		///<param name="end">End of date range, if not provided will use the current date and time eg: 1/31/2021</param>
		public static void QueryVods(this CameraEntity target, object? @entityId = null, object? @eventId = null, object? @start = null, object? @end = null)
		{
			target.CallService("query_vods", new ReolinkDevQueryVodsParameters{EntityId = @entityId, EventId = @eventId, Start = @start, End = @end});
		}

		///<summary>For cameras that have Video-On-Demand Playback capability, this will query the camera and emit an reolink_dev-vod-data event for each matching VoD that matches the search parameters, it will also provide the thumbail path for the expected thumbnail.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="eventId">Event to emit as eg: VoD-query</param>
		///<param name="start">Start of date range, if not provided will use the month playback range eg: 1/1/2021</param>
		///<param name="end">End of date range, if not provided will use the current date and time eg: 1/31/2021</param>
		public static void QueryVods(this IEnumerable<CameraEntity> target, object? @entityId = null, object? @eventId = null, object? @start = null, object? @end = null)
		{
			target.CallService("query_vods", new ReolinkDevQueryVodsParameters{EntityId = @entityId, EventId = @eventId, Start = @start, End = @end});
		}

		///<summary>Optimizing brightness and contrast levels to compensate for differences between dark and bright objects using either BLC or WDR mode. This may improve image clarity in high contrast situations, but it should be tested at different times of the day and night to ensure there is no negative effect.</summary>
		public static void SetBacklight(this CameraEntity target, ReolinkDevSetBacklightParameters data)
		{
			target.CallService("set_backlight", data);
		}

		///<summary>Optimizing brightness and contrast levels to compensate for differences between dark and bright objects using either BLC or WDR mode. This may improve image clarity in high contrast situations, but it should be tested at different times of the day and night to ensure there is no negative effect.</summary>
		public static void SetBacklight(this IEnumerable<CameraEntity> target, ReolinkDevSetBacklightParameters data)
		{
			target.CallService("set_backlight", data);
		}

		///<summary>Optimizing brightness and contrast levels to compensate for differences between dark and bright objects using either BLC or WDR mode. This may improve image clarity in high contrast situations, but it should be tested at different times of the day and night to ensure there is no negative effect.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="mode">The backlight parameter supports the following values:   BACKLIGHTCONTROL: use Backlight Control   DYNAMICRANGECONTROL: use Dynamic Range Control   OFF: no optimization eg: DYNAMICRANGECONTROL</param>
		public static void SetBacklight(this CameraEntity target, object? @entityId = null, object? @mode = null)
		{
			target.CallService("set_backlight", new ReolinkDevSetBacklightParameters{EntityId = @entityId, Mode = @mode});
		}

		///<summary>Optimizing brightness and contrast levels to compensate for differences between dark and bright objects using either BLC or WDR mode. This may improve image clarity in high contrast situations, but it should be tested at different times of the day and night to ensure there is no negative effect.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="mode">The backlight parameter supports the following values:   BACKLIGHTCONTROL: use Backlight Control   DYNAMICRANGECONTROL: use Dynamic Range Control   OFF: no optimization eg: DYNAMICRANGECONTROL</param>
		public static void SetBacklight(this IEnumerable<CameraEntity> target, object? @entityId = null, object? @mode = null)
		{
			target.CallService("set_backlight", new ReolinkDevSetBacklightParameters{EntityId = @entityId, Mode = @mode});
		}

		///<summary>Set day and night parameter.</summary>
		public static void SetDaynight(this CameraEntity target, ReolinkDevSetDaynightParameters data)
		{
			target.CallService("set_daynight", data);
		}

		///<summary>Set day and night parameter.</summary>
		public static void SetDaynight(this IEnumerable<CameraEntity> target, ReolinkDevSetDaynightParameters data)
		{
			target.CallService("set_daynight", data);
		}

		///<summary>Set day and night parameter.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="mode">The day and night mode parameter supports the following values:   AUTO: Auto switch between black & white mode   COLOR: Always record videos in color mode   BLACKANDWHITE: Always record videos in black & white mode eg: AUTO</param>
		public static void SetDaynight(this CameraEntity target, object? @entityId = null, object? @mode = null)
		{
			target.CallService("set_daynight", new ReolinkDevSetDaynightParameters{EntityId = @entityId, Mode = @mode});
		}

		///<summary>Set day and night parameter.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="mode">The day and night mode parameter supports the following values:   AUTO: Auto switch between black & white mode   COLOR: Always record videos in color mode   BLACKANDWHITE: Always record videos in black & white mode eg: AUTO</param>
		public static void SetDaynight(this IEnumerable<CameraEntity> target, object? @entityId = null, object? @mode = null)
		{
			target.CallService("set_daynight", new ReolinkDevSetDaynightParameters{EntityId = @entityId, Mode = @mode});
		}

		///<summary>Set the motion detection sensitivity.</summary>
		public static void SetSensitivity(this CameraEntity target, ReolinkDevSetSensitivityParameters data)
		{
			target.CallService("set_sensitivity", data);
		}

		///<summary>Set the motion detection sensitivity.</summary>
		public static void SetSensitivity(this IEnumerable<CameraEntity> target, ReolinkDevSetSensitivityParameters data)
		{
			target.CallService("set_sensitivity", data);
		}

		///<summary>Set the motion detection sensitivity.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="sensitivity">New sensitivity, value between 1 (low sensitivity) and 50 (high sensitivity) eg: 25</param>
		///<param name="preset">(Optional) Set the sensitivity of a specific preset (time schedule). When no value is supplied, all presets will be changed.</param>
		public static void SetSensitivity(this CameraEntity target, object? @entityId = null, object? @sensitivity = null, object? @preset = null)
		{
			target.CallService("set_sensitivity", new ReolinkDevSetSensitivityParameters{EntityId = @entityId, Sensitivity = @sensitivity, Preset = @preset});
		}

		///<summary>Set the motion detection sensitivity.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="entityId">Name(s) of the Reolink camera entity to execute the command on. eg: camera.frontdoor</param>
		///<param name="sensitivity">New sensitivity, value between 1 (low sensitivity) and 50 (high sensitivity) eg: 25</param>
		///<param name="preset">(Optional) Set the sensitivity of a specific preset (time schedule). When no value is supplied, all presets will be changed.</param>
		public static void SetSensitivity(this IEnumerable<CameraEntity> target, object? @entityId = null, object? @sensitivity = null, object? @preset = null)
		{
			target.CallService("set_sensitivity", new ReolinkDevSetSensitivityParameters{EntityId = @entityId, Sensitivity = @sensitivity, Preset = @preset});
		}
	}

	public static class SceneEntityExtensionMethods
	{
		///<summary>Activate a scene.</summary>
		public static void TurnOn(this SceneEntity target, SceneTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Activate a scene.</summary>
		public static void TurnOn(this IEnumerable<SceneEntity> target, SceneTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The SceneEntity to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public static void TurnOn(this SceneEntity target, long? @transition = null)
		{
			target.CallService("turn_on", new SceneTurnOnParameters{Transition = @transition});
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The IEnumerable<SceneEntity> to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public static void TurnOn(this IEnumerable<SceneEntity> target, long? @transition = null)
		{
			target.CallService("turn_on", new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public static class SwitchEntityExtensionMethods
	{
		///<summary>Toggles a switch state</summary>
		public static void Toggle(this SwitchEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a switch state</summary>
		public static void Toggle(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this SwitchEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this SwitchEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class UpdateEntityExtensionMethods
	{
		///<summary>Removes the skipped version marker from an update.</summary>
		public static void ClearSkipped(this UpdateEntity target)
		{
			target.CallService("clear_skipped");
		}

		///<summary>Removes the skipped version marker from an update.</summary>
		public static void ClearSkipped(this IEnumerable<UpdateEntity> target)
		{
			target.CallService("clear_skipped");
		}

		///<summary>Install an update for this device or service</summary>
		public static void Install(this UpdateEntity target, UpdateInstallParameters data)
		{
			target.CallService("install", data);
		}

		///<summary>Install an update for this device or service</summary>
		public static void Install(this IEnumerable<UpdateEntity> target, UpdateInstallParameters data)
		{
			target.CallService("install", data);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The UpdateEntity to call this service for</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public static void Install(this UpdateEntity target, string? @version = null, bool? @backup = null)
		{
			target.CallService("install", new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The IEnumerable<UpdateEntity> to call this service for</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public static void Install(this IEnumerable<UpdateEntity> target, string? @version = null, bool? @backup = null)
		{
			target.CallService("install", new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Mark currently available update as skipped.</summary>
		public static void Skip(this UpdateEntity target)
		{
			target.CallService("skip");
		}

		///<summary>Mark currently available update as skipped.</summary>
		public static void Skip(this IEnumerable<UpdateEntity> target)
		{
			target.CallService("skip");
		}
	}
}