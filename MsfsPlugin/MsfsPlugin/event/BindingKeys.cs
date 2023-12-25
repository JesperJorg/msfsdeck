﻿namespace Loupedeck.MsfsPlugin
{
    public enum BindingKeys
    {
        ENGINE_AUTO,
        KOHLSMAN,
        AILERON_TRIM,
        ELEVATOR_TRIM,
        RUDDER_TRIM,
        AP_ALT,
        ALT,
        AP_ALT_INPUT,
        ALT_INPUT,
        MAX_FLAP,
        FLAP,
        AP_HEADING,
        HEADING,
        AP_HEADING_INPUT,
        HEADING_INPUT,
        MIXTURE,
        PROPELLER,
        AP_SPEED,
        SPEED,
        AP_SPEED_INPUT,
        SPEED_INPUT,
        SPOILER,
        MIN_THROTTLE,
        THROTTLE,
        AP_VSPEED,
        VSPEED,
        AP_VSPEED_INPUT,
        VSPEED_INPUT,
        PARKING_BRAKES,
        PAUSE,
        PITOT,
        CONNECTION,
        GEAR_FRONT,
        GEAR_LEFT,
        GEAR_RIGHT,
        GEAR_RETRACTABLE,
        FUEL_FLOW,
        FUEL_PERCENT,
        FUEL_TIME_LEFT,
        AP_NEXT_WP_ID,
        AP_NEXT_WP_DIST,
        AP_NEXT_WP_ETE,
        AP_NEXT_WP_HEADING,
        ENGINE_TYPE,
        ENGINE_NUMBER,
        E1RPM,
        E2RPM,
        E1N1,
        E2N1,
        E3N1,
        E4N1,
        PUSHBACK_STATE,
        PUSHBACK_ANGLE,
        PUSHBACK_ATTACHED,
        PUSHBACK_CONTROLLER,
        LIGHT_NAV,
        LIGHT_BEACON,
        LIGHT_LANDING,
        LIGHT_TAXI,
        LIGHT_STROBE,
        LIGHT_INSTRUMENT,
        LIGHT_RECOG,
        LIGHT_WING,
        LIGHT_LOGO,
        LIGHT_CABIN,
        LIGHT_PEDESTAL,
        LIGHT_GLARESHIELD,
        LIGHT_ALL_SWITCH,
        AP_ALT_AP_FOLDER,
        ALT_AP_FOLDER,
        AP_HEADING_AP_FOLDER,
        HEADING_AP_FOLDER,
        AP_SPEED_AP_FOLDER,
        SPEED_AP_FOLDER,
        AP_VSPEED_AP_FOLDER,
        VSPEED_AP_FOLDER,
        AP_ALT_SWITCH_AP_FOLDER,
        AP_HEAD_SWITCH_AP_FOLDER,
        AP_NAV_SWITCH_AP_FOLDER,
        AP_SPEED_SWITCH_AP_FOLDER,
        AP_MASTER_SWITCH_AP_FOLDER,
        AP_THROTTLE_SWITCH_AP_FOLDER,
        AP_VSPEED_SWITCH_AP_FOLDER,
        AP_YAW_DAMPER_AP_FOLDER,
        AP_BC_AP_FOLDER,
        AP_ALT_SWITCH,
        AP_HEAD_SWITCH,
        AP_NAV_SWITCH,
        AP_SPEED_SWITCH,
        AP_MASTER_SWITCH,
        AP_THROTTLE_SWITCH,
        AP_VSPEED_SWITCH,
        AP_YAW_DAMPER_SWITCH,
        AP_BC_SWITCH,
        ATC_ATC_FOLDER,
        ATC_0_ATC_FOLDER,
        ATC_1_ATC_FOLDER,
        ATC_2_ATC_FOLDER,
        ATC_3_ATC_FOLDER,
        ATC_4_ATC_FOLDER,
        ATC_5_ATC_FOLDER,
        ATC_6_ATC_FOLDER,
        ATC_7_ATC_FOLDER,
        ATC_8_ATC_FOLDER,
        ATC_9_ATC_FOLDER,
        AP_ALT_AL_FOLDER,
        ALT_AL_FOLDER,
        AP_HEADING_AL_FOLDER,
        HEADING_AL_FOLDER,
        AP_SPEED_AL_FOLDER,
        SPEED_AL_FOLDER,
        AP_VSPEED_AL_FOLDER,
        VSPEED_AL_FOLDER,
        AP_FD_SWITCH_AL_FOLDER,
        AP_ALT_SWITCH_AL_FOLDER,
        AP_SWITCH_AL_FOLDER,
        AP_GPS_SWITCH_AL_FOLDER,
        AP_FLC_SWITCH_AL_FOLDER,
        AP_APP_SWITCH_AL_FOLDER,
        AP_LOC_SWITCH_AL_FOLDER,
        AP_SPEED_SWITCH_AL_FOLDER,
        AP_HEAD_SWITCH_AL_FOLDER,
        AP_THROTTLE_SWITCH_AL_FOLDER,
        AP_VSPEED_SWITCH_AL_FOLDER,
        AP_YAW_DAMPER_AL_FOLDER,
        AP_BC_AL_FOLDER,
        AUTO_TAXI,
        COM1_ACTIVE_FREQUENCY,
        COM2_ACTIVE_FREQUENCY,
        COM3_ACTIVE_FREQUENCY,
        COM1_ACTIVE_FREQUENCY_TYPE,
        COM2_ACTIVE_FREQUENCY_TYPE,
        COM3_ACTIVE_FREQUENCY_TYPE,
        COM1_STATUS,
        COM2_STATUS,
        COM3_STATUS,
        COM1_AVAILABLE,
        COM2_AVAILABLE,
        COM3_AVAILABLE,
        COM1_STBY,
        COM2_STBY,
        COM3_STBY,
        COM1_RADIO_SWAP,
        COM2_RADIO_SWAP,
        COM3_RADIO_SWAP,
        FLASHLIGHT,
        ICON_SIZE,
        SIM_RATE,
        SPOILERS_ARM,
        NAV1_ACTIVE_FREQUENCY,
        NAV2_ACTIVE_FREQUENCY,
        NAV1_STBY_FREQUENCY,
        NAV2_STBY_FREQUENCY,
        NAV1_AVAILABLE,
        NAV2_AVAILABLE,
        NAV1_RADIO_SWAP,
        NAV2_RADIO_SWAP,

        VOR1_OBS,
        VOR2_OBS,
        VOR1_SET,
        VOR2_SET,

        AIR_TEMP,
        WIND_DIRECTION,
        WIND_SPEED,
        VISIBILITY,
        SEA_LEVEL_PRESSURE,

        ADF_ACTIVE_FREQUENCY,
        ADF_STBY_FREQUENCY,
        ADF1_AVAILABLE,
        ADF1_STBY_AVAILABLE,
        ADF_RADIO_SWAP,

        //++ When adding new data to the communication with simConnect, add new binding key here and then create new Input/Encoder class creating a binding with this key.
        //++ Next add to SimConnectDAO (see similarly formed comments (there are more than one) there).
    }
}

