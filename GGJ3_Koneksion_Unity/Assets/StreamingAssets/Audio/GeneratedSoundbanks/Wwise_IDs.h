/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID PLAY_AMBIANCE_SWITCH = 1312697745U;
        static const AkUniqueID PLAY_BUZZES = 2459940809U;
        static const AkUniqueID PLAY_FLOOR = 1473554808U;
        static const AkUniqueID PLAY_GAMESTART = 1497459184U;
        static const AkUniqueID PLAY_GRAVEYARD = 315336149U;
        static const AkUniqueID PLAY_OUTLET = 2187493489U;
        static const AkUniqueID PLAY_ROOTS = 2135754993U;
        static const AkUniqueID PLAY_TEST = 3187507146U;
        static const AkUniqueID STOP_AMBIANCE_SWITCH = 2478053135U;
        static const AkUniqueID STOP_BUZZES = 3753166191U;
        static const AkUniqueID STOP_FLOOR = 3605768394U;
        static const AkUniqueID STOP_GRAVEYARD = 505928471U;
        static const AkUniqueID STOP_ROOTS = 4220051187U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace GAMESTATE
        {
            static const AkUniqueID GROUP = 4091656514U;

            namespace STATE
            {
                static const AkUniqueID MENU = 2607556080U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID PLAY = 1256202815U;
            } // namespace STATE
        } // namespace GAMESTATE

        namespace MUSIC_STATE
        {
            static const AkUniqueID GROUP = 3826569560U;

            namespace STATE
            {
                static const AkUniqueID DEFAULT = 782826392U;
                static const AkUniqueID EIGHT_OUTLET = 3430678834U;
                static const AkUniqueID FIFTH_OUTLET = 2221782172U;
                static const AkUniqueID FIRST_OUTLET = 296419799U;
                static const AkUniqueID FOURTH_OUTLET = 1573921923U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID SECOND_OUTLET = 1645992811U;
                static const AkUniqueID SEVENTH_OUTLET = 3791539724U;
                static const AkUniqueID SIXTH_OUTLET = 3663346869U;
                static const AkUniqueID THIRD_OUTLET = 1460986192U;
            } // namespace STATE
        } // namespace MUSIC_STATE

    } // namespace STATES

    namespace SWITCHES
    {
        namespace AMB_SWITCH
        {
            static const AkUniqueID GROUP = 439968226U;

            namespace SWITCH
            {
                static const AkUniqueID FIFTH_RECTANGLE = 117868958U;
                static const AkUniqueID FIRST_RECTANGLE = 418045379U;
                static const AkUniqueID FOURTH_RECTANGLE = 1985572375U;
                static const AkUniqueID SECOND_RECTANGLE = 1529178447U;
                static const AkUniqueID START = 1281810935U;
                static const AkUniqueID THIRD_RECTANGLE = 1737148314U;
            } // namespace SWITCH
        } // namespace AMB_SWITCH

    } // namespace SWITCHES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID AMBIANCE_VOLUME_RTPC = 939099552U;
        static const AkUniqueID MASTER_VOLUME_RTPC = 2585960002U;
        static const AkUniqueID MUSIC_VOLUME_RTPC = 3131952431U;
        static const AkUniqueID SFX_VOLUME_RTPC = 2654583815U;
        static const AkUniqueID ZOOM_RTPC = 2323009266U;
    } // namespace GAME_PARAMETERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID SBK_MAIN = 2354509155U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID AMBIANCE = 2981377429U;
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID MUSIC = 3991942870U;
        static const AkUniqueID SFX = 393239870U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
