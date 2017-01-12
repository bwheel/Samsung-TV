using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samsung_TV.Commands
{
    public class CommandFactory
    {
        public static ICommand GetCommand(Keycode command)
        {
            ICommand result = null;
            switch (command)
            {
                case Keycode.KEY_0:
                    result = new Key0Command();
                    break;
                case Keycode.KEY_1:
                    result = new Key1Command();
                    break;
                case Keycode.KEY_2:
                    result = new Key2Command();
                    break;
                case Keycode.KEY_3:
                    result = new Key3Command();
                    break;
                case Keycode.KEY_4:
                    result = new Key4Command();
                    break;
                case Keycode.KEY_5:
                    result = new Key5Command();
                    break;
                case Keycode.KEY_6:
                    result = new Key6Command();
                    break;
                case Keycode.KEY_7:
                    result = new Key7Command();
                    break;
                case Keycode.KEY_8:
                    result = new Key8Command();
                    break;
                case Keycode.KEY_9:
                    result = new Key9Command();
                    break;
                case Keycode.KEY_11:
                    result = new Key11Command();
                    break;
                case Keycode.KEY_12:
                    result = new Key12Command();
                    break;
                case Keycode.KEY_3SPEED:
                    result = new Key3SpeedCommand();
                    break;
                case Keycode.KEY_4_3:
                    result = new Key4_3Command();
                    break;
                case Keycode.KEY_16_9:
                    result = new Key16_9Command();
                    break;
                case Keycode.KEY_AD:
                    result = new KeyAdCommand();
                    break;
                case Keycode.KEY_ADDDEL:
                    result = new KeyAdddelCommand();
                    break;
                case Keycode.KEY_ALT_MHP:
                    result = new KeyAltMhpCommand();
                    break;
                case Keycode.KEY_ANGLE:
                    result = new KeyAngleCommand();
                    break;
                case Keycode.KEY_ANTENA:
                    result = new KeyAntenaCommand();
                    break;
                case Keycode.KEY_ANYNET:
                    result = new KeyAnyNetCommand();
                    break;
                case Keycode.KEY_ANYVIEW:
                    result = new KeyAnyViewCommand();
                    break;
                case Keycode.KEY_APP_LIST:
                    result = new KeyAppListCommand();
                    break;
                case Keycode.KEY_ASPECT:
                    result = new KeyAspectCommand();
                    break;
                case Keycode.KEY_AUTO_ARC_ANTENNA_AIR:
                    result = new KeyAutoArcAntennaAir();
                    break;
                case Keycode.KEY_AUTO_ARC_ANTENNA_CABLE:
                    result = new KeyAutoArcAntennaCable();
                    break;
                case Keycode.KEY_AUTO_ARC_ANTENNA_SATELLITE:
                    result = new KeyAutoArcAntennaSatellite();
                    break;
                case Keycode.KEY_AUTO_ARC_ANYNET_AUTO_START:
                    result = new KeyAutoArcAnynetAutoStart();
                    break;
                case Keycode.KEY_AUTO_ARC_ANYNET_MODE_OK:
                    result = new KeyAutoArcAnynetModeOk();
                    break;
                case Keycode.KEY_AUTO_ARC_AUTOCOLOR_FAIL:
                    result = new KeyAutoArcAutocolorFail();
                    break;
                case Keycode.KEY_AUTO_ARC_AUTOCOLOR_SUCCESS:
                    result = new KeyAutoArcAutocolorSuccess();
                    break;
                case Keycode.KEY_AUTO_ARC_CAPTION_ENG:
                    result = new KeyAutoArcCaptionEng();
                    break;
                case Keycode.KEY_AUTO_ARC_CAPTION_KOR:
                    result = new KeyAutoArcCaptionKor();
                    break;
                case Keycode.KEY_AUTO_ARC_CAPTION_OFF:
                    result = new KeyAutoArcCaptionOff();
                    break;
                case Keycode.KEY_AUTO_ARC_CAPTION_ON:
                    result = new KeyAutoArcCaptionOn();
                    break;
                case Keycode.KEY_AUTO_ARC_C_FORCE_AGING:
                    result = new KeyAutoArcCForceAging();
                    break;
                case Keycode.KEY_AUTO_ARC_JACK_IDENT:
                    result = new KeyAutoArcJackIdent();
                    break;
                case Keycode.KEY_AUTO_ARC_LNA_OFF:
                    result = new KeyAutoArcLnaOff();
                    break;
                case Keycode.KEY_AUTO_ARC_LNA_ON:
                    result = new KeyAutoArcLnaOn();
                    break;
                case Keycode.KEY_AUTO_ARC_PIP_CH_CHANGE:
                    result = new KeyAutoArcPipChChange();
                    break;
                case Keycode.KEY_AUTO_ARC_PIP_DOUBLE:
                    result = new KeyAutoArcPipDouble();
                    break;
                case Keycode.KEY_AUTO_ARC_PIP_LARGE:
                    result = new KeyAutoArcPipLarge();
                    break;
                case Keycode.KEY_AUTO_ARC_PIP_LEFT_BOTTOM:
                    result = new KeyAutoArcPipLeftBottom();
                    break;
                case Keycode.KEY_AUTO_ARC_PIP_LEFT_TOP:
                    result = new KeyAutoArcPipLeftTop();
                    break;
                case Keycode.KEY_AUTO_ARC_PIP_RIGHT_BOTTOM:
                    result = new KeyAutoArcPipRightBottom();
                    break;
                case Keycode.KEY_AUTO_ARC_PIP_RIGHT_TOP:
                    result = new KeyAutoArcPipRightTop();
                    break;
                case Keycode.KEY_AUTO_ARC_PIP_SMALL:
                    result = new KeyAutoArcPipSmall();
                    break;
                case Keycode.KEY_AUTO_ARC_PIP_SOURCE_CHANGE:
                    result = new KeyAutoArcPipSourceChange();
                    break;
                case Keycode.KEY_AUTO_ARC_PIP_WIDE:
                    result = new KeyAutoArcPipWide();
                    break;
                case Keycode.KEY_AUTO_ARC_RESET:
                    result = new KeyAutoArcReset();
                    break;
                case Keycode.KEY_AUTO_ARC_USBJACK_INSPECT:
                    result = new KeyAutoArcUSBJackInspect();
                    break;
                case Keycode.KEY_AUTO_FORMAT:
                    result = new KeyAutoFormat();
                    break;
                case Keycode.KEY_AUTO_PROGRAM:
                    result = new KeyAutoProgram();
                    break;
                case Keycode.KEY_AV1:
                    result = new KeyAv1();
                    break;
                case Keycode.KEY_AV2:
                    result = new KeyAv2();
                    break;
                case Keycode.KEY_AV3:
                    result = new KeyAv3();
                    break;
                case Keycode.KEY_BACK_MHP:
                    result = new KeyBackMhp();
                    break;
                case Keycode.KEY_BOOKMARK:
                    result = new KeyBookmark();
                    break;
                case Keycode.KEY_CALLER_ID:
                    result = new KeyCallerId();
                    break;
                case Keycode.KEY_CAPTION:
                    result = new KeyCaption();
                    break;
                case Keycode.KEY_CATV_MODE:
                    result = new KeyCatvMode();
                    break;
                case Keycode.KEY_CHDOWN:
                    result = new KeyChDown();
                    break;
                case Keycode.KEY_CHUP:
                    result = new KeyChUp();
                    break;
                case Keycode.KEY_CH_LIST:
                    result = new KeyChList();
                    break;
                case Keycode.KEY_CLEAR:
                    result = new KeyClear();
                    break;
                case Keycode.KEY_CLOCK_DISPLAY:
                    result = new KeyClockDisplay();
                    break;
                case Keycode.KEY_COMPONENT1:
                    result = new KeyComponent1();
                    break;
                case Keycode.KEY_COMPONENT2:
                    result = new KeyComponent2();
                    break;
                case Keycode.KEY_CONTENTS:
                    result = new KeyContents();
                    break;
                case Keycode.KEY_CONVERGENCE:
                    result = new KeyConvergence();
                    break;
                case Keycode.KEY_CONVERT_AUDIO_MAINSUB:
                    result = new KeyConvertAudioMainsub();
                    break;
                case Keycode.KEY_CUSTOM:
                    result = new KeyCustom();
                    break;
                case Keycode.KEY_CYAN:
                    result = new KeyCyan();
                    break;
                case Keycode.KEY_DEVICE_CONNECT:
                    result = new KeyDeviceConnect();
                    break;
                case Keycode.KEY_DISC_MENU:
                    result = new KeyDiscMenu();
                    break;
                case Keycode.KEY_DMA:
                    result = new KeyDma();
                    break;
                case Keycode.KEY_DNET:
                    result = new KeyDNet();
                    break;
                case Keycode.KEY_DNIe:
                    result = new KeyDnie();
                    break;
                case Keycode.KEY_DNSe:
                    result = new KeyDnse();
                    break;
                case Keycode.KEY_DOOR:
                    result = new KeyDoor();
                    break;
                case Keycode.KEY_DOWN:
                    result = new KeyDown();
                    break;
                case Keycode.KEY_DSS_MODE:
                    result = new KeyDssMode();
                    break;
                case Keycode.KEY_DTV:
                    result = new KeyDtv();
                    break;
                case Keycode.KEY_DTV_LINK:
                    result = new KeyDtvLink();
                    break;
                case Keycode.KEY_DTV_SIGNAL:
                    result = new KeyDtvSignal();
                    break;
                case Keycode.KEY_DVD_MODE:
                    result = new KeyDvdMode();
                    break;
                case Keycode.KEY_DVI:
                    result = new KeyDvi();
                    break;
                case Keycode.KEY_DVR:
                    result = new KeyDvr();
                    break;
                case Keycode.KEY_DVR_MENU:
                    result = new KeyDvrMenu();
                    break;
                case Keycode.KEY_DYNAMIC:
                    result = new KeyDynamic();
                    break;
                case Keycode.KEY_ENTER:
                    result = new KeyEnter();
                    break;
                case Keycode.KEY_ENTERTAINMENT:
                    result = new KeyEntertainment();
                    break;
                case Keycode.KEY_ESAVING:
                    result = new KeyESaving();
                    break;
                case Keycode.KEY_EXIT:
                    result = new KeyExit();
                    break;
                case Keycode.KEY_EXT1:
                    result = new KeyExt1();
                    break;
                case Keycode.KEY_EXT2:
                    result = new KeyExt2();
                    break;
                case Keycode.KEY_EXT3:
                    result = new KeyExt3();
                    break;
                case Keycode.KEY_EXT4:
                    result = new KeyExt4();
                    break;
                case Keycode.KEY_EXT5:
                    result = new KeyExt5();
                    break;
                case Keycode.KEY_EXT6:
                    result = new KeyExt6();
                    break;
                case Keycode.KEY_EXT7:
                    result = new KeyExt7();
                    break;
                case Keycode.KEY_EXT8:
                    result = new KeyExt8();
                    break;
                case Keycode.KEY_EXT9:
                    result = new KeyExt9();
                    break;
                case Keycode.KEY_EXT10:
                    result = new KeyExt10();
                    break;
                case Keycode.KEY_EXT11:
                    result = new KeyExt11();
                    break;
                case Keycode.KEY_EXT12:
                    result = new KeyExt12();
                    break;
                case Keycode.KEY_EXT13:
                    result = new KeyExt13();
                    break;
                case Keycode.KEY_EXT14:
                    result = new KeyExt14();
                    break;
                case Keycode.KEY_EXT15:
                    result = new KeyExt15();
                    break;
                case Keycode.KEY_EXT16:
                    result = new KeyExt16();
                    break;
                case Keycode.KEY_EXT17:
                    result = new KeyExt17();
                    break;
                case Keycode.KEY_EXT18:
                    result = new KeyExt18();
                    break;
                case Keycode.KEY_EXT19:
                    result = new KeyExt19();
                    break;
                case Keycode.KEY_EXT20:
                    result = new KeyExt20();
                    break;
                case Keycode.KEY_EXT21:
                    result = new KeyExt21();
                    break;
                case Keycode.KEY_EXT22:
                    result = new KeyExt22();
                    break;
                case Keycode.KEY_EXT23:
                    result = new KeyExt23();
                    break;
                case Keycode.KEY_EXT24:
                    result = new KeyExt24();
                    break;
                case Keycode.KEY_EXT25:
                    result = new KeyExt25();
                    break;
                case Keycode.KEY_EXT26:
                    result = new KeyExt26();
                    break;
                case Keycode.KEY_EXT27:
                    result = new KeyExt27();
                    break;
                case Keycode.KEY_EXT28:
                    result = new KeyExt28();
                    break;
                case Keycode.KEY_EXT29:
                    result = new KeyExt29();
                    break;
                case Keycode.KEY_EXT30:
                    result = new KeyExt30();
                    break;
                case Keycode.KEY_EXT31:
                    result = new KeyExt31();
                    break;
                case Keycode.KEY_EXT32:
                    result = new KeyExt32();
                    break;
                case Keycode.KEY_EXT33:
                    result = new KeyExt33();
                    break;
                case Keycode.KEY_EXT34:
                    result = new KeyExt34();
                    break;
                case Keycode.KEY_EXT35:
                    result = new KeyExt35();
                    break;
                case Keycode.KEY_EXT36:
                    result = new KeyExt36();
                    break;
                case Keycode.KEY_EXT37:
                    result = new KeyExt37();
                    break;
                case Keycode.KEY_EXT38:
                    result = new KeyExt38();
                    break;
                case Keycode.KEY_EXT39:
                    result = new KeyExt39();
                    break;
                case Keycode.KEY_EXT40:
                    result = new KeyExt40();
                    break;
                case Keycode.KEY_EXT41:
                    result = new KeyExt41();
                    break;
                case Keycode.KEY_FACTORY:
                    result = new KeyFactory();
                    break;
                case Keycode.KEY_FAVCH:
                    result = new KeyFavch();
                    break;
                case Keycode.KEY_FF:
                    result = new KeyFF();
                    break;
                case Keycode.KEY_FF_:
                    result = new KeyFF_();
                    break;
                case Keycode.KEY_FM_RADIO:
                    result = new KeyFmRadio();
                    break;
                case Keycode.KEY_GAME:
                    result = new KeyGame();
                    break;
                case Keycode.KEY_GREEN:
                    result = new KeyGreen();
                    break;
                case Keycode.KEY_GUIDE:
                    result = new KeyGuide();
                    break;
                case Keycode.KEY_HDMI:
                    result = new KeyHdmi();
                    break;
                case Keycode.KEY_HDMI1:
                    result = new KeyHdmi1();
                    break;
                case Keycode.KEY_HDMI2:
                    result = new KeyHdmi2();
                    break;
                case Keycode.KEY_HDMI3:
                    result = new KeyHdmi3();
                    break;
                case Keycode.KEY_HDMI4:
                    result = new KeyHdmi4();
                    break;
                case Keycode.KEY_HELP:
                    result = new KeyHelp();
                    break;
                case Keycode.KEY_HOME:
                    result = new KeyHome();
                    break;
                case Keycode.KEY_ID_INPUT:
                    result = new KeyIdInput();
                    break;
                case Keycode.KEY_ID_SETUP:
                    result = new KeyIdSetup();
                    break;
                case Keycode.KEY_INFO:
                    result = new KeyInfo();
                    break;
                case Keycode.KEY_INSTANT_REPLAY:
                    result = new KeyInstantReplay();
                    break;
                case Keycode.KEY_LEFT:
                    result = new KeyLeft();
                    break;
                case Keycode.KEY_LINK:
                    result = new KeyLink();
                    break;
                case Keycode.KEY_LIVE:
                    result = new KeyLive();
                    break;
                case Keycode.KEY_MAGIC_BRIGHT:
                    result = new KeyMagicBright();
                    break;
                case Keycode.KEY_MAGIC_CHANNEL:
                    result = new KeyMagicChannel();
                    break;
                case Keycode.KEY_MDC:
                    result = new KeyMdc();
                    break;
                case Keycode.KEY_MENU:
                    result = new KeyMenu();
                    break;
                case Keycode.KEY_MIC:
                    result = new KeyMic();
                    break;
                case Keycode.KEY_MORE:
                    result = new KeyMore();
                    break;
                case Keycode.KEY_MOVIE1:
                    result = new KeyMovie1();
                    break;
                case Keycode.KEY_MS:
                    result = new KeyMs();
                    break;
                case Keycode.KEY_MTS:
                    result = new KeyMts();
                    break;
                case Keycode.KEY_MUTE:
                    result = new KeyMute();
                    break;
                case Keycode.KEY_NINE_SEPERATE:
                    result = new KeyNineSeperate();
                    break;
                case Keycode.KEY_OPEN:
                    result = new KeyOpen();
                    break;
                case Keycode.KEY_PANNEL_CHDOWN:
                    result = new KeyPannelChDown();
                    break;
                case Keycode.KEY_PANNEL_CHUP:
                    result = new KeyPannelChUp();
                    break;
                case Keycode.KEY_PANNEL_ENTER:
                    result = new KeyPannelEnter();
                    break;
                case Keycode.KEY_PANNEL_MENU:
                    result = new KeyPannelMenu();
                    break;
                case Keycode.KEY_PANNEL_POWER:
                    result = new KeyPannelPower();
                    break;
                case Keycode.KEY_PANNEL_SOURCE:
                    result = new KeyPannelSource();
                    break;
                case Keycode.KEY_PANNEL_VOLDOW:
                    result = new KeyPannelVolDown();
                    break;
                case Keycode.KEY_PANNEL_VOLUP:
                    result = new KeyPannelVolUp();
                    break;
                case Keycode.KEY_PANORAMA:
                    result = new KeyPanorama();
                    break;
                case Keycode.KEY_PAUSE:
                    result = new KeyPause();
                    break;
                case Keycode.KEY_PCMODE:
                    result = new KeyPcMode();
                    break;
                case Keycode.KEY_PERPECT_FOCUS:
                    result = new KeyPerpectFocus();
                    break;
                case Keycode.KEY_PICTURE_SIZE:
                    result = new KeyPictureSize();
                    break;
                case Keycode.KEY_PIP_CHDOWN:
                    result = new KeyPipChDown();
                    break;
                case Keycode.KEY_PIP_CHUP:
                    result = new KeyPipChUp();
                    break;
                case Keycode.KEY_PIP_ONOFF:
                    result = new KeyPipOnOff();
                    break;
                case Keycode.KEY_PIP_SCAN:
                    result = new KeyPipScan();
                    break;
                case Keycode.KEY_PIP_SIZE:
                    result = new KeyPipSize();
                    break;
                case Keycode.KEY_PIP_SWAP:
                    result = new KeyPipSwap();
                    break;
                case Keycode.KEY_PLAY:
                    result = new KeyPlay();
                    break;
                case Keycode.KEY_PLUS100:
                    result = new KeyPlus100();
                    break;
                case Keycode.KEY_PMODE:
                    result = new KeyPMode();
                    break;
                case Keycode.KEY_POWER:
                    result = new KeyPower();
                    break;
                case Keycode.KEY_POWEROFF:
                    result = new KeyPowerOff();
                    break;
                case Keycode.KEY_POWERON:
                    result = new KeyPowerOn();
                    break;
                case Keycode.KEY_PRECH:
                    result = new KeyPrech();
                    break;
                case Keycode.KEY_PRINT:
                    result = new KeyPrint();
                    break;
                case Keycode.KEY_PROGRAM:
                    result = new KeyProgram();
                    break;
                case Keycode.KEY_QUICK_REPLAY:
                    result = new KeyQuickReplay();
                    break;
                case Keycode.KEY_REC:
                    result = new KeyRec();
                    break;
                case Keycode.KEY_RED:
                    result = new KeyRed();
                    break;
                case Keycode.KEY_REPEAT:
                    result = new KeyRepeat();
                    break;
                case Keycode.KEY_RESERVED1:
                    result = new KeyReserved1();
                    break;
                case Keycode.KEY_RETURN:
                    result = new KeyReturn();
                    break;
                case Keycode.KEY_REWIND:
                    result = new KeyRewind();
                    break;
                case Keycode.KEY_REWIND_:
                    result = new KeyRewind_();
                    break;
                case Keycode.KEY_RIGHT:
                    result = new KeyRight();
                    break;
                case Keycode.KEY_RSS:
                    result = new KeyRss();
                    break;
                case Keycode.KEY_RSURF:
                    result = new KeyRsurf();
                    break;
                case Keycode.KEY_SCALE:
                    result = new KeyScale();
                    break;
                case Keycode.KEY_SEFFECT:
                    result = new KeySEffect();
                    break;
                case Keycode.KEY_SETUP_CLOCK_TIMER:
                    result = new KeySetupClockTimer();
                    break;
                case Keycode.KEY_SLEEP:
                    result = new KeySleep();
                    break;
                case Keycode.KEY_SOUND_MODE:
                    result = new KeySoundMode();
                    break;
                case Keycode.KEY_SOURCE:
                    result = new KeySource();
                    break;
                case Keycode.KEY_SRS:
                    result = new KeySrs();
                    break;
                case Keycode.KEY_STANDARD:
                    result = new KeyStandard();
                    break;
                case Keycode.KEY_STB_MODE:
                    result = new KeyStbMode();
                    break;
                case Keycode.KEY_STILL_PICTURE:
                    result = new KeyStillPicture();
                    break;
                case Keycode.KEY_STOP:
                    result = new KeyStop();
                    break;
                case Keycode.KEY_SUB_TITLE:
                    result = new KeySubTitle();
                    break;
                case Keycode.KEY_SVIDEO1:
                    result = new KeySVideo1();
                    break;
                case Keycode.KEY_SVIDEO2:
                    result = new KeySVideo2();
                    break;
                case Keycode.KEY_SVIDEO3:
                    result = new KeySVideo3();
                    break;
                case Keycode.KEY_TOOLS:
                    result = new KeyTools();
                    break;
                case Keycode.KEY_TOPMENU:
                    result = new KeyTopMenu();
                    break;
                case Keycode.KEY_TTX_MIX:
                    result = new KeyTtxMix();
                    break;
                case Keycode.KEY_TTX_SUBFACE:
                    result = new KeyTtxSubface();
                    break;
                case Keycode.KEY_TURBO:
                    result = new KeyTurbo();
                    break;
                case Keycode.KEY_TV:
                    result = new KeyTv();
                    break;
                case Keycode.KEY_TV_MODE:
                    result = new KeyTvMode();
                    break;
                case Keycode.KEY_UP:
                    result = new KeyUp();
                    break;
                case Keycode.KEY_VCHIP:
                    result = new KeyVChip();
                    break;
                case Keycode.KEY_VCR_MODE:
                    result = new KeyVcrMode();
                    break;
                case Keycode.KEY_VOLDOWN:
                    result = new KeyVolDown();
                    break;
                case Keycode.KEY_VOLUP:
                    result = new KeyVolUp();
                    break;
                case Keycode.KEY_WHEEL_LEFT:
                    result = new KeyWheelLeft();
                    break;
                case Keycode.KEY_WHEEL_RIGHT:
                    result = new KeyWheelRight();
                    break;
                case Keycode.KEY_W_LINK:
                    result = new KeyWLink();
                    break;
                case Keycode.KEY_YELLOW:
                    result = new KeyYellow();
                    break;
                case Keycode.KEY_ZOOM1:
                    result = new KeyZoom1();
                    break;
                case Keycode.KEY_ZOOM2:
                    result = new KeyZoom2();
                    break;
                case Keycode.KEY_ZOOM_IN:
                    result = new KeyZoomIn();
                    break;
                case Keycode.KEY_ZOOM_MOVE:
                    result = new KeyZoomMove();
                    break;
                case Keycode.KEY_ZOOM_OUT:
                    result = new KeyZoomOut();
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
