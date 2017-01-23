﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samsung_TV
{
    public class CommandTypes
    {
        public enum KeyCode
        {
            KEY_0,
            KEY_1,
            KEY_2,
            KEY_3,
            KEY_4,
            KEY_5,
            KEY_6,
            KEY_7,
            KEY_8,
            KEY_9,
            KEY_11,
            KEY_12,
            KEY_3SPEED,
            KEY_4_3,
            KEY_16_9,
            KEY_AD,
            KEY_ADDDEL,
            KEY_ALT_MHP,
            KEY_ANGLE,
            KEY_ANTENA,
            KEY_ANYNET,
            KEY_ANYVIEW,
            KEY_APP_LIST,
            KEY_ASPECT,
            KEY_AUTO_ARC_ANTENNA_AIR,
            KEY_AUTO_ARC_ANTENNA_CABLE,
            KEY_AUTO_ARC_ANTENNA_SATELLITE,
            KEY_AUTO_ARC_ANYNET_AUTO_START,
            KEY_AUTO_ARC_ANYNET_MODE_OK,
            KEY_AUTO_ARC_AUTOCOLOR_FAIL,
            KEY_AUTO_ARC_AUTOCOLOR_SUCCESS,
            KEY_AUTO_ARC_CAPTION_ENG,
            KEY_AUTO_ARC_CAPTION_KOR,
            KEY_AUTO_ARC_CAPTION_OFF,
            KEY_AUTO_ARC_CAPTION_ON,
            KEY_AUTO_ARC_C_FORCE_AGING,
            KEY_AUTO_ARC_JACK_IDENT,
            KEY_AUTO_ARC_LNA_OFF,
            KEY_AUTO_ARC_LNA_ON,
            KEY_AUTO_ARC_PIP_CH_CHANGE,
            KEY_AUTO_ARC_PIP_DOUBLE,
            KEY_AUTO_ARC_PIP_LARGE,
            KEY_AUTO_ARC_PIP_LEFT_BOTTOM,
            KEY_AUTO_ARC_PIP_LEFT_TOP,
            KEY_AUTO_ARC_PIP_RIGHT_BOTTOM,
            KEY_AUTO_ARC_PIP_RIGHT_TOP,
            KEY_AUTO_ARC_PIP_SMALL,
            KEY_AUTO_ARC_PIP_SOURCE_CHANGE,
            KEY_AUTO_ARC_PIP_WIDE,
            KEY_AUTO_ARC_RESET,
            KEY_AUTO_ARC_USBJACK_INSPECT,
            KEY_AUTO_FORMAT,
            KEY_AUTO_PROGRAM,
            KEY_AV1,
            KEY_AV2,
            KEY_AV3,
            KEY_BACK_MHP,
            KEY_BOOKMARK,
            KEY_CALLER_ID,
            KEY_CAPTION,
            KEY_CATV_MODE,
            KEY_CHDOWN,
            KEY_CHUP,
            KEY_CH_LIST,
            KEY_CLEAR,
            KEY_CLOCK_DISPLAY,
            KEY_COMPONENT1,
            KEY_COMPONENT2,
            KEY_CONTENTS,
            KEY_CONVERGENCE,
            KEY_CONVERT_AUDIO_MAINSUB,
            KEY_CUSTOM,
            KEY_CYAN,
            KEY_DEVICE_CONNECT,
            KEY_DISC_MENU,
            KEY_DMA,
            KEY_DNET,
            KEY_DNIe,
            KEY_DNSe,
            KEY_DOOR,
            KEY_DOWN,
            KEY_DSS_MODE,
            KEY_DTV,
            KEY_DTV_LINK,
            KEY_DTV_SIGNAL,
            KEY_DVD_MODE,
            KEY_DVI,
            KEY_DVR,
            KEY_DVR_MENU,
            KEY_DYNAMIC,
            KEY_ENTER,
            KEY_ENTERTAINMENT,
            KEY_ESAVING,
            KEY_EXIT,
            KEY_EXT1,
            KEY_EXT2,
            KEY_EXT3,
            KEY_EXT4,
            KEY_EXT5,
            KEY_EXT6,
            KEY_EXT7,
            KEY_EXT8,
            KEY_EXT9,
            KEY_EXT10,
            KEY_EXT11,
            KEY_EXT12,
            KEY_EXT13,
            KEY_EXT14,
            KEY_EXT15,
            KEY_EXT16,
            KEY_EXT17,
            KEY_EXT18,
            KEY_EXT19,
            KEY_EXT20,
            KEY_EXT21,
            KEY_EXT22,
            KEY_EXT23,
            KEY_EXT24,
            KEY_EXT25,
            KEY_EXT26,
            KEY_EXT27,
            KEY_EXT28,
            KEY_EXT29,
            KEY_EXT30,
            KEY_EXT31,
            KEY_EXT32,
            KEY_EXT33,
            KEY_EXT34,
            KEY_EXT35,
            KEY_EXT36,
            KEY_EXT37,
            KEY_EXT38,
            KEY_EXT39,
            KEY_EXT40,
            KEY_EXT41,
            KEY_FACTORY,
            KEY_FAVCH,
            KEY_FF,
            KEY_FF_,
            KEY_FM_RADIO,
            KEY_GAME,
            KEY_GREEN,
            KEY_GUIDE,
            KEY_HDMI,
            KEY_HDMI1,
            KEY_HDMI2,
            KEY_HDMI3,
            KEY_HDMI4,
            KEY_HELP,
            KEY_HOME,
            KEY_ID_INPUT,
            KEY_ID_SETUP,
            KEY_INFO,
            KEY_INSTANT_REPLAY,
            KEY_LEFT,
            KEY_LINK,
            KEY_LIVE,
            KEY_MAGIC_BRIGHT,
            KEY_MAGIC_CHANNEL,
            KEY_MDC,
            KEY_MENU,
            KEY_MIC,
            KEY_MORE,
            KEY_MOVIE1,
            KEY_MS,
            KEY_MTS,
            KEY_MUTE,
            KEY_NINE_SEPERATE,
            KEY_OPEN,
            KEY_PANNEL_CHDOWN,
            KEY_PANNEL_CHUP,
            KEY_PANNEL_ENTER,
            KEY_PANNEL_MENU,
            KEY_PANNEL_POWER,
            KEY_PANNEL_SOURCE,
            KEY_PANNEL_VOLDOW,
            KEY_PANNEL_VOLUP,
            KEY_PANORAMA,
            KEY_PAUSE,
            KEY_PCMODE,
            KEY_PERPECT_FOCUS,
            KEY_PICTURE_SIZE,
            KEY_PIP_CHDOWN,
            KEY_PIP_CHUP,
            KEY_PIP_ONOFF,
            KEY_PIP_SCAN,
            KEY_PIP_SIZE,
            KEY_PIP_SWAP,
            KEY_PLAY,
            KEY_PLUS100,
            KEY_PMODE,
            KEY_POWER,
            KEY_POWEROFF,
            KEY_POWERON,
            KEY_PRECH,
            KEY_PRINT,
            KEY_PROGRAM,
            KEY_QUICK_REPLAY,
            KEY_REC,
            KEY_RED,
            KEY_REPEAT,
            KEY_RESERVED1,
            KEY_RETURN,
            KEY_REWIND,
            KEY_REWIND_,
            KEY_RIGHT,
            KEY_RSS,
            KEY_RSURF,
            KEY_SCALE,
            KEY_SEFFECT,
            KEY_SETUP_CLOCK_TIMER,
            KEY_SLEEP,
            KEY_SOUND_MODE,
            KEY_SOURCE,
            KEY_SRS,
            KEY_STANDARD,
            KEY_STB_MODE,
            KEY_STILL_PICTURE,
            KEY_STOP,
            KEY_SUB_TITLE,
            KEY_SVIDEO1,
            KEY_SVIDEO2,
            KEY_SVIDEO3,
            KEY_TOOLS,
            KEY_TOPMENU,
            KEY_TTX_MIX,
            KEY_TTX_SUBFACE,
            KEY_TURBO,
            KEY_TV,
            KEY_TV_MODE,
            KEY_UP,
            KEY_VCHIP,
            KEY_VCR_MODE,
            KEY_VOLDOWN,
            KEY_VOLUP,
            KEY_WHEEL_LEFT,
            KEY_WHEEL_RIGHT,
            KEY_W_LINK,
            KEY_YELLOW,
            KEY_ZOOM1,
            KEY_ZOOM2,
            KEY_ZOOM_IN,
            KEY_ZOOM_MOVE,
            KEY_ZOOM_OUT,
        }


        public static Dictionary<KeyCode, string> CommandLookUp = new Dictionary<KeyCode, string>()
        {
            { KeyCode.KEY_0,"KEY_0" },
            { KeyCode.KEY_1,"KEY_1" },
            { KeyCode.KEY_2,"KEY_2" },
            { KeyCode.KEY_3,"KEY_3" },
            { KeyCode.KEY_4,"KEY_4" },
            { KeyCode.KEY_5,"KEY_5" },
            { KeyCode.KEY_6,"KEY_6" },
            { KeyCode.KEY_7,"KEY_7" },
            { KeyCode.KEY_8,"KEY_8" },
            { KeyCode.KEY_9,"KEY_9" },
            { KeyCode.KEY_11,"KEY_11" },
            { KeyCode.KEY_12,"KEY_12" },
            { KeyCode.KEY_3SPEED,"KEY_3SPEED" },
            { KeyCode.KEY_4_3,"KEY_4_3" },
            { KeyCode.KEY_16_9,"KEY_16_9" },
            { KeyCode.KEY_AD,"KEY_AD" },
            { KeyCode.KEY_ADDDEL,"KEY_ADDDEL" },
            { KeyCode.KEY_ALT_MHP,"KEY_ALT_MHP" },
            { KeyCode.KEY_ANGLE,"KEY_ANGLE" },
            { KeyCode.KEY_ANTENA,"KEY_ANTENA" },
            { KeyCode.KEY_ANYNET,"KEY_ANYNET" },
            { KeyCode.KEY_ANYVIEW,"KEY_ANYVIEW" },
            { KeyCode.KEY_APP_LIST,"KEY_APP_LIST" },
            { KeyCode.KEY_ASPECT,"KEY_ASPECT" },
            { KeyCode.KEY_AUTO_ARC_ANTENNA_AIR,"KEY_AUTO_ARC_ANTENNA_AIR" },
            { KeyCode.KEY_AUTO_ARC_ANTENNA_CABLE,"KEY_AUTO_ARC_ANTENNA_CABLE" },
            { KeyCode.KEY_AUTO_ARC_ANTENNA_SATELLITE,"KEY_AUTO_ARC_ANTENNA_SATELLITE" },
            { KeyCode.KEY_AUTO_ARC_ANYNET_AUTO_START,"KEY_AUTO_ARC_ANYNET_AUTO_START" },
            { KeyCode.KEY_AUTO_ARC_ANYNET_MODE_OK,"KEY_AUTO_ARC_ANYNET_MODE_OK" },
            { KeyCode.KEY_AUTO_ARC_AUTOCOLOR_FAIL,"KEY_AUTO_ARC_AUTOCOLOR_FAIL" },
            { KeyCode.KEY_AUTO_ARC_AUTOCOLOR_SUCCESS,"KEY_AUTO_ARC_AUTOCOLOR_SUCCESS" },
            { KeyCode.KEY_AUTO_ARC_CAPTION_ENG,"KEY_AUTO_ARC_CAPTION_ENG" },
            { KeyCode.KEY_AUTO_ARC_CAPTION_KOR,"KEY_AUTO_ARC_CAPTION_KOR" },
            { KeyCode.KEY_AUTO_ARC_CAPTION_OFF,"KEY_AUTO_ARC_CAPTION_OFF" },
            { KeyCode.KEY_AUTO_ARC_CAPTION_ON,"KEY_AUTO_ARC_CAPTION_ON" },
            { KeyCode.KEY_AUTO_ARC_C_FORCE_AGING,"KEY_AUTO_ARC_C_FORCE_AGING" },
            { KeyCode.KEY_AUTO_ARC_JACK_IDENT,"KEY_AUTO_ARC_JACK_IDENT" },
            { KeyCode.KEY_AUTO_ARC_LNA_OFF,"KEY_AUTO_ARC_LNA_OFF" },
            { KeyCode.KEY_AUTO_ARC_LNA_ON,"KEY_AUTO_ARC_LNA_ON" },
            { KeyCode.KEY_AUTO_ARC_PIP_CH_CHANGE,"KEY_AUTO_ARC_PIP_CH_CHANGE" },
            { KeyCode.KEY_AUTO_ARC_PIP_DOUBLE,"KEY_AUTO_ARC_PIP_DOUBLE" },
            { KeyCode.KEY_AUTO_ARC_PIP_LARGE,"KEY_AUTO_ARC_PIP_LARGE" },
            { KeyCode.KEY_AUTO_ARC_PIP_LEFT_BOTTOM,"KEY_AUTO_ARC_PIP_LEFT_BOTTOM" },
            { KeyCode.KEY_AUTO_ARC_PIP_LEFT_TOP,"KEY_AUTO_ARC_PIP_LEFT_TOP" },
            { KeyCode.KEY_AUTO_ARC_PIP_RIGHT_BOTTOM,"KEY_AUTO_ARC_PIP_RIGHT_BOTTOM" },
            { KeyCode.KEY_AUTO_ARC_PIP_RIGHT_TOP,"KEY_AUTO_ARC_PIP_RIGHT_TOP" },
            { KeyCode.KEY_AUTO_ARC_PIP_SMALL,"KEY_AUTO_ARC_PIP_SMALL" },
            { KeyCode.KEY_AUTO_ARC_PIP_SOURCE_CHANGE,"KEY_AUTO_ARC_PIP_SOURCE_CHANGE" },
            { KeyCode.KEY_AUTO_ARC_PIP_WIDE,"KEY_AUTO_ARC_PIP_WIDE" },
            { KeyCode.KEY_AUTO_ARC_RESET,"KEY_AUTO_ARC_RESET" },
            { KeyCode.KEY_AUTO_ARC_USBJACK_INSPECT,"KEY_AUTO_ARC_USBJACK_INSPECT" },
            { KeyCode.KEY_AUTO_FORMAT,"KEY_AUTO_FORMAT" },
            { KeyCode.KEY_AUTO_PROGRAM,"KEY_AUTO_PROGRAM" },
            { KeyCode.KEY_AV1,"KEY_AV1" },
            { KeyCode.KEY_AV2,"KEY_AV2" },
            { KeyCode.KEY_AV3,"KEY_AV3" },
            { KeyCode.KEY_BACK_MHP,"KEY_BACK_MHP" },
            { KeyCode.KEY_BOOKMARK,"KEY_BOOKMARK" },
            { KeyCode.KEY_CALLER_ID,"KEY_CALLER_ID" },
            { KeyCode.KEY_CAPTION,"KEY_CAPTION" },
            { KeyCode.KEY_CATV_MODE,"KEY_CATV_MODE" },
            { KeyCode.KEY_CHDOWN,"KEY_CHDOWN" },
            { KeyCode.KEY_CHUP,"KEY_CHUP" },
            { KeyCode.KEY_CH_LIST,"KEY_CH_LIST" },
            { KeyCode.KEY_CLEAR,"KEY_CLEAR" },
            { KeyCode.KEY_CLOCK_DISPLAY,"KEY_CLOCK_DISPLAY" },
            { KeyCode.KEY_COMPONENT1,"KEY_COMPONENT1" },
            { KeyCode.KEY_COMPONENT2,"KEY_COMPONENT2" },
            { KeyCode.KEY_CONTENTS,"KEY_CONTENTS" },
            { KeyCode.KEY_CONVERGENCE,"KEY_CONVERGENCE" },
            { KeyCode.KEY_CONVERT_AUDIO_MAINSUB,"KEY_CONVERT_AUDIO_MAINSUB" },
            { KeyCode.KEY_CUSTOM,"KEY_CUSTOM" },
            { KeyCode.KEY_CYAN,"KEY_CYAN" },
            { KeyCode.KEY_DEVICE_CONNECT,"KEY_DEVICE_CONNECT" },
            { KeyCode.KEY_DISC_MENU,"KEY_DISC_MENU" },
            { KeyCode.KEY_DMA,"KEY_DMA" },
            { KeyCode.KEY_DNET,"KEY_DNET" },
            { KeyCode.KEY_DNIe,"KEY_DNIe" },
            { KeyCode.KEY_DNSe,"KEY_DNSe" },
            { KeyCode.KEY_DOOR,"KEY_DOOR" },
            { KeyCode.KEY_DOWN,"KEY_DOWN" },
            { KeyCode.KEY_DSS_MODE,"KEY_DSS_MODE" },
            { KeyCode.KEY_DTV,"KEY_DTV" },
            { KeyCode.KEY_DTV_LINK,"KEY_DTV_LINK" },
            { KeyCode.KEY_DTV_SIGNAL,"KEY_DTV_SIGNAL" },
            { KeyCode.KEY_DVD_MODE,"KEY_DVD_MODE" },
            { KeyCode.KEY_DVI,"KEY_DVI" },
            { KeyCode.KEY_DVR,"KEY_DVR" },
            { KeyCode.KEY_DVR_MENU,"KEY_DVR_MENU" },
            { KeyCode.KEY_DYNAMIC,"KEY_DYNAMIC" },
            { KeyCode.KEY_ENTER,"KEY_ENTER" },
            { KeyCode.KEY_ENTERTAINMENT,"KEY_ENTERTAINMENT" },
            { KeyCode.KEY_ESAVING,"KEY_ESAVING" },
            { KeyCode.KEY_EXIT,"KEY_EXIT" },
            { KeyCode.KEY_EXT1,"KEY_EXT1" },
            { KeyCode.KEY_EXT2,"KEY_EXT2" },
            { KeyCode.KEY_EXT3,"KEY_EXT3" },
            { KeyCode.KEY_EXT4,"KEY_EXT4" },
            { KeyCode.KEY_EXT5,"KEY_EXT5" },
            { KeyCode.KEY_EXT6,"KEY_EXT6" },
            { KeyCode.KEY_EXT7,"KEY_EXT7" },
            { KeyCode.KEY_EXT8,"KEY_EXT8" },
            { KeyCode.KEY_EXT9,"KEY_EXT9" },
            { KeyCode.KEY_EXT10,"KEY_EXT10" },
            { KeyCode.KEY_EXT11,"KEY_EXT11" },
            { KeyCode.KEY_EXT12,"KEY_EXT12" },
            { KeyCode.KEY_EXT13,"KEY_EXT13" },
            { KeyCode.KEY_EXT14,"KEY_EXT14" },
            { KeyCode.KEY_EXT15,"KEY_EXT15" },
            { KeyCode.KEY_EXT16,"KEY_EXT16" },
            { KeyCode.KEY_EXT17,"KEY_EXT17" },
            { KeyCode.KEY_EXT18,"KEY_EXT18" },
            { KeyCode.KEY_EXT19,"KEY_EXT19" },
            { KeyCode.KEY_EXT20,"KEY_EXT20" },
            { KeyCode.KEY_EXT21,"KEY_EXT21" },
            { KeyCode.KEY_EXT22,"KEY_EXT22" },
            { KeyCode.KEY_EXT23,"KEY_EXT23" },
            { KeyCode.KEY_EXT24,"KEY_EXT24" },
            { KeyCode.KEY_EXT25,"KEY_EXT25" },
            { KeyCode.KEY_EXT26,"KEY_EXT26" },
            { KeyCode.KEY_EXT27,"KEY_EXT27" },
            { KeyCode.KEY_EXT28,"KEY_EXT28" },
            { KeyCode.KEY_EXT29,"KEY_EXT29" },
            { KeyCode.KEY_EXT30,"KEY_EXT30" },
            { KeyCode.KEY_EXT31,"KEY_EXT31" },
            { KeyCode.KEY_EXT32,"KEY_EXT32" },
            { KeyCode.KEY_EXT33,"KEY_EXT33" },
            { KeyCode.KEY_EXT34,"KEY_EXT34" },
            { KeyCode.KEY_EXT35,"KEY_EXT35" },
            { KeyCode.KEY_EXT36,"KEY_EXT36" },
            { KeyCode.KEY_EXT37,"KEY_EXT37" },
            { KeyCode.KEY_EXT38,"KEY_EXT38" },
            { KeyCode.KEY_EXT39,"KEY_EXT39" },
            { KeyCode.KEY_EXT40,"KEY_EXT40" },
            { KeyCode.KEY_EXT41,"KEY_EXT41" },
            { KeyCode.KEY_FACTORY,"KEY_FACTORY" },
            { KeyCode.KEY_FAVCH,"KEY_FAVCH" },
            { KeyCode.KEY_FF,"KEY_FF" },
            { KeyCode.KEY_FF_,"KEY_FF_" },
            { KeyCode.KEY_FM_RADIO,"KEY_FM_RADIO" },
            { KeyCode.KEY_GAME,"KEY_GAME" },
            { KeyCode.KEY_GREEN,"KEY_GREEN" },
            { KeyCode.KEY_GUIDE,"KEY_GUIDE" },
            { KeyCode.KEY_HDMI,"KEY_HDMI" },
            { KeyCode.KEY_HDMI1,"KEY_HDMI1" },
            { KeyCode.KEY_HDMI2,"KEY_HDMI2" },
            { KeyCode.KEY_HDMI3,"KEY_HDMI3" },
            { KeyCode.KEY_HDMI4,"KEY_HDMI4" },
            { KeyCode.KEY_HELP,"KEY_HELP" },
            { KeyCode.KEY_HOME,"KEY_HOME" },
            { KeyCode.KEY_ID_INPUT,"KEY_ID_INPUT" },
            { KeyCode.KEY_ID_SETUP,"KEY_ID_SETUP" },
            { KeyCode.KEY_INFO,"KEY_INFO" },
            { KeyCode.KEY_INSTANT_REPLAY,"KEY_INSTANT_REPLAY" },
            { KeyCode.KEY_LEFT,"KEY_LEFT" },
            { KeyCode.KEY_LINK,"KEY_LINK" },
            { KeyCode.KEY_LIVE,"KEY_LIVE" },
            { KeyCode.KEY_MAGIC_BRIGHT,"KEY_MAGIC_BRIGHT" },
            { KeyCode.KEY_MAGIC_CHANNEL,"KEY_MAGIC_CHANNEL" },
            { KeyCode.KEY_MDC,"KEY_MDC" },
            { KeyCode.KEY_MENU,"KEY_MENU" },
            { KeyCode.KEY_MIC,"KEY_MIC" },
            { KeyCode.KEY_MORE,"KEY_MORE" },
            { KeyCode.KEY_MOVIE1,"KEY_MOVIE1" },
            { KeyCode.KEY_MS,"KEY_MS" },
            { KeyCode.KEY_MTS,"KEY_MTS" },
            { KeyCode.KEY_MUTE,"KEY_MUTE" },
            { KeyCode.KEY_NINE_SEPERATE,"KEY_NINE_SEPERATE" },
            { KeyCode.KEY_OPEN,"KEY_OPEN" },
            { KeyCode.KEY_PANNEL_CHDOWN,"KEY_PANNEL_CHDOWN" },
            { KeyCode.KEY_PANNEL_CHUP,"KEY_PANNEL_CHUP" },
            { KeyCode.KEY_PANNEL_ENTER,"KEY_PANNEL_ENTER" },
            { KeyCode.KEY_PANNEL_MENU,"KEY_PANNEL_MENU" },
            { KeyCode.KEY_PANNEL_POWER,"KEY_PANNEL_POWER" },
            { KeyCode.KEY_PANNEL_SOURCE,"KEY_PANNEL_SOURCE" },
            { KeyCode.KEY_PANNEL_VOLDOW,"KEY_PANNEL_VOLDOW" },
            { KeyCode.KEY_PANNEL_VOLUP,"KEY_PANNEL_VOLUP" },
            { KeyCode.KEY_PANORAMA,"KEY_PANORAMA" },
            { KeyCode.KEY_PAUSE,"KEY_PAUSE" },
            { KeyCode.KEY_PCMODE,"KEY_PCMODE" },
            { KeyCode.KEY_PERPECT_FOCUS,"KEY_PERPECT_FOCUS" },
            { KeyCode.KEY_PICTURE_SIZE,"KEY_PICTURE_SIZE" },
            { KeyCode.KEY_PIP_CHDOWN,"KEY_PIP_CHDOWN" },
            { KeyCode.KEY_PIP_CHUP,"KEY_PIP_CHUP" },
            { KeyCode.KEY_PIP_ONOFF,"KEY_PIP_ONOFF" },
            { KeyCode.KEY_PIP_SCAN,"KEY_PIP_SCAN" },
            { KeyCode.KEY_PIP_SIZE,"KEY_PIP_SIZE" },
            { KeyCode.KEY_PIP_SWAP,"KEY_PIP_SWAP" },
            { KeyCode.KEY_PLAY,"KEY_PLAY" },
            { KeyCode.KEY_PLUS100,"KEY_PLUS100" },
            { KeyCode.KEY_PMODE,"KEY_PMODE" },
            { KeyCode.KEY_POWER,"KEY_POWER" },
            { KeyCode.KEY_POWEROFF,"KEY_POWEROFF" },
            { KeyCode.KEY_POWERON,"KEY_POWERON" },
            { KeyCode.KEY_PRECH,"KEY_PRECH" },
            { KeyCode.KEY_PRINT,"KEY_PRINT" },
            { KeyCode.KEY_PROGRAM,"KEY_PROGRAM" },
            { KeyCode.KEY_QUICK_REPLAY,"KEY_QUICK_REPLAY" },
            { KeyCode.KEY_REC,"KEY_REC" },
            { KeyCode.KEY_RED,"KEY_RED" },
            { KeyCode.KEY_REPEAT,"KEY_REPEAT" },
            { KeyCode.KEY_RESERVED1,"KEY_RESERVED1" },
            { KeyCode.KEY_RETURN,"KEY_RETURN" },
            { KeyCode.KEY_REWIND,"KEY_REWIND" },
            { KeyCode.KEY_REWIND_,"KEY_REWIND_" },
            { KeyCode.KEY_RIGHT,"KEY_RIGHT" },
            { KeyCode.KEY_RSS,"KEY_RSS" },
            { KeyCode.KEY_RSURF,"KEY_RSURF" },
            { KeyCode.KEY_SCALE,"KEY_SCALE" },
            { KeyCode.KEY_SEFFECT,"KEY_SEFFECT" },
            { KeyCode.KEY_SETUP_CLOCK_TIMER,"KEY_SETUP_CLOCK_TIMER" },
            { KeyCode.KEY_SLEEP,"KEY_SLEEP" },
            { KeyCode.KEY_SOUND_MODE,"KEY_SOUND_MODE" },
            { KeyCode.KEY_SOURCE,"KEY_SOURCE" },
            { KeyCode.KEY_SRS,"KEY_SRS" },
            { KeyCode.KEY_STANDARD,"KEY_STANDARD" },
            { KeyCode.KEY_STB_MODE,"KEY_STB_MODE" },
            { KeyCode.KEY_STILL_PICTURE,"KEY_STILL_PICTURE" },
            { KeyCode.KEY_STOP,"KEY_STOP" },
            { KeyCode.KEY_SUB_TITLE,"KEY_SUB_TITLE" },
            { KeyCode.KEY_SVIDEO1,"KEY_SVIDEO1" },
            { KeyCode.KEY_SVIDEO2,"KEY_SVIDEO2" },
            { KeyCode.KEY_SVIDEO3,"KEY_SVIDEO3" },
            { KeyCode.KEY_TOOLS,"KEY_TOOLS" },
            { KeyCode.KEY_TOPMENU,"KEY_TOPMENU" },
            { KeyCode.KEY_TTX_MIX,"KEY_TTX_MIX" },
            { KeyCode.KEY_TTX_SUBFACE,"KEY_TTX_SUBFACE" },
            { KeyCode.KEY_TURBO,"KEY_TURBO" },
            { KeyCode.KEY_TV,"KEY_TV" },
            { KeyCode.KEY_TV_MODE,"KEY_TV_MODE" },
            { KeyCode.KEY_UP,"KEY_UP" },
            { KeyCode.KEY_VCHIP,"KEY_VCHIP" },
            { KeyCode.KEY_VCR_MODE,"KEY_VCR_MODE" },
            { KeyCode.KEY_VOLDOWN,"KEY_VOLDOWN" },
            { KeyCode.KEY_VOLUP,"KEY_VOLUP" },
            { KeyCode.KEY_WHEEL_LEFT,"KEY_WHEEL_LEFT" },
            { KeyCode.KEY_WHEEL_RIGHT,"KEY_WHEEL_RIGHT" },
            { KeyCode.KEY_W_LINK,"KEY_W_LINK" },
            { KeyCode.KEY_YELLOW,"KEY_YELLOW" },
            { KeyCode.KEY_ZOOM1,"KEY_ZOOM1" },
            { KeyCode.KEY_ZOOM2,"KEY_ZOOM2" },
            { KeyCode.KEY_ZOOM_IN,"KEY_ZOOM_IN" },
            { KeyCode.KEY_ZOOM_MOVE,"KEY_ZOOM_MOVE" },
            { KeyCode.KEY_ZOOM_OUT,"KEY_ZOOM_OUT" }
        };
    }
}