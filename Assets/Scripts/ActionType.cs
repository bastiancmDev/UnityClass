﻿using System.Collections;
using System.Collections.Generic;


public enum GuiActionType
{
    SETWINDSPEED,
    SETSHOWDATACARDS,
    CLOSEHUDPANELS,
    SETSHOTCARD,
    SETCLUBCARD,
    SETBALLCARD,
    NEXTCARD,
    PREVCARD,
    SETCLUBLINE,
    GETSTARTLINEX,
    GETSTARTLINEY,
    SETNEEDLEROTATION,
    SETLASTLINECURVE,
    SETCLOSECARDS,
    SETCLUBPAGEDATA,
    SETCLUBPAGEAVGDATA,
    SETCLUBCANVASDATABALL,
    SETCLUBCANVASDATATOP,
    SETCLUBCANVASDATABFRONT,
    SETCLUBCANVASDATAFACE,
    SETBALLPAGEDATA,
    SETBALLPAGEDATAAVG,
    BALLPAGETOPCURVE,
    SETBALLPAGESIDECURVE,
    SETTABLEBALLDATA,
    SETTABLECLUBDATA,
    SETBALLCURVETOPALL,
    SETBALLCURVESIDEALL,
    SETSHOWMAPPANEL,
    SETSHOWCONFIGPANEL,
    GETMAPPANELSTATE,
    GETCONFIGPANELSTATE,
    UPDATELOADINGPROGRESS,
    SETSCENEDATA,
    SETBALLPOSITIONINMAP,
    SETMINIMAPLINES,
    SETMINIMAPDASHLINE,
    SETMARGINCALCULATOR,
    SHOWCLOSEWINDOW,
    GETCLOSEWINDOWSTATE,
    SETCARDSTIMER,
    SETINFOTABSTATE,
    GETINFOTABSTATE,
    SCAPEKEYACTION,
    SHOWLOADINGLEAGUESOVERLAY,
    BACKSPACEKEYACTION,
    SCAPEKEYACTIONSEARCH,
    INTROACTION,
    TABACTION,
    STARTMENUVIDEO,
    SETRELOCATEPANELSTATE,
    GETRELOCATEPANELSTATE,

    #region after shot panel

    SETAFTERSHOTPANELVALUES,
    SETAFTERSHOTPANELSTATE,
    SETAFTERSHOTPANELTIMMER,

    #endregion

    #region Replay system

    SHOWREPLAYPANEL,
    SETSHOTLIST,

    #endregion

    CLOSESHOTLIST,
    GETSHOTLISTSTATE,
    SETBALLDISTANCETOPINTEXT,
    SETBALLDISTANCETOCURSOR,
    SETPINDISTANCETOCURSOR,
    SETHUBBUTTONSPANELSTATE,
    GETHUDBUTTONSPANELSTATE,
    SETDEVICELIST,
    SETDEVICECONNECTED,
    SETDEVICEDISCONNECTED,
    PUTBALLINZONEANIM,
    MULTIBALLINZONEANIM,
    BALLREADY,
    ENDSHOTREPLAY,
    HIDEDEVICEUIONSHOT,
    BALLNOTFOUND,
    SETLOADINGMESSAGE,
    SETHAMBURGUERMENUSTATE,

    SETDEVICEPANELRIGHTHANDONSTART,
    SETDEVICEPANELRIGHTHAND,
    GETSETTINGSPANELSTATE,
    SETSETTINGSPANELSTATE,
    GETCLUBANDBALLPANELSTATE,
    SETCLUBANDBALLPANELSTATE,
    GETNEWCLUBPANELSTATE,
    SETNEWCLUBPANELSTATE,
    GETNEWBALLPANELSTATE,
    SETNEWBALLPANELSTATE ,

    SETCARDSSHOWVM,
    BALLINHITZONE,

    SETPLAYERNAMEANDSHOTNUMBER,
    GETADDNEWPLAYERPANELSTATE,
    SETADDNEWPLAYERPANELSTATE,

    GETREMOVEPLAYERPANELSTATE,
    SETREMOVEPLAYERPANELSTATE,

    HIDESTATUSMODETEXT,
    SETSTATUSMODETEXT,
    SELECTDEVICEONSTARTUP,
    SHOWDEVICEDISCONNECTED,
    SETONSCREENAIM,
    SETOPENKEYBOARD,
    SETPRACTICERIBBONSHOW,
    SETPRACTICERIBBONDATA,
    SETMINIMAPRENDER,
    UPDATEMINIMAPUNITS,
    STARTLOADINGSCREENVIDEO,
    HIDELOADINGSCREEN,
    UPDATESELECTEDTEESFOREACHPLAYER,
    DGETPLAYERSTEE,
    GETRIBBONCATPANELSTATUS,
    SETRIBBONCATPANELSTATUS,
    ENDRELOCATE,
    SETRELOCATESLIDER,
    SETREALTIMEWEATHERTEXT,
    SETREALTIMEWEATHERVALUES,
    SETINITIALTEE,
    SETTEEINFOINRELOCATE,
    SETMINIMAPTAGPOSITION,
    CLARMINIMAPTAGPOSITION,
    SETPRACTICEBUTTON,
    CLOSESETTINGS,
    HAMBURGEROPEN,
    HAMBUGUERCLOSE,
    SETSCORECARDSTATUS,
    GETSCORECARDSTATUS,
    SETPLAYERDATAINSCORECARD,
    SETPLAYERIDCARD,
    BLOCKADDPPLAYERSTOURNAMENT,
    SETMINIMAPBOTTOMTEXT,

    SETWEATHERPRESETS,
    SETWEATHERPRESETSWITHVALUES,
    SETPRESETTOADVANCEVALUES,

    SETMINIMAPFLAGTAGPOSITION,

    SETFORSHOTTEXT,
    SETFORSHOTSTATUS,
    GETFORSHOTSTATUS,

    ANIMATEPINPLACEMENTBASIC,
    ANIMATESCORINGADVANCED,
    ANIMATESCORINGBASIC,
    ANIMATEPINPLACEMENTADVANCED,
    ANIMATEMULLIGANS,
    ANIMATEPUTTINGMODE,
    ANIMATEGIMMES,
    ANIMATEPRACTICE,
    ANIMATESROKELIMIT,
    ANIMATEROUGH,

    OPENPENALTYSCREEN,
    CLOSEALLPENALTYWINDOWS,
    SHOWPLUSONENUMBER,
    SETUIMULLIGANSNUMBER,
    OPENPLACEHOLDERWINDOW,
    CLOSEALLPLACEHOLDERWINDOWS,
    CLOSELICENSEVERSIONWINDOW,
    OPENCLOSETRAYECTORYVIEW,
    GETSAVEGAMEPANELSTATUS,
    SETSAVEGAMEPANELSTATUS,
    GETTRAYECTORYVIEWSTATUS,
    OPENCLOSEENVIRONMENTSETTINGS,
    GETENVIRONMENTSETTINGSSTATUS,
    GETENVIRONMENTSETTINGSADVANCEDSTATUS,
    OPENCLOSEENVIRONMENTSETTINGSADVANCED,

    SETBLOCKPLAYERLIST,
    WAITFORSECONDSNCLOSEALLPENALTY,
    WAITFORSECONDSNCLOSEALLPLACEHOLDERS,
    SETOUTOFBOUNDSREMAININGTIME,
    SETHOLEFINISHEDREMAININGTIME,
    ACTIVESESSIONYESBUTTON,
    ACTIVESESSIONNOBUTTON,
    ACTIVESESSIONCLOSEBUTTON,
    APPLYTRAYECTORYCHANGE,

    PENALTYREHITPRESSED,
    PENALTYDROPPRESSED,
    PENALTYMULLIGANSPRESSED,
    PENALTYDROPOPTIONSMOVEUPMOUSEDOWN,
    PENALTYDROPOPTIONSMOVEDOWNMOUSEDOWN,
    PENALTYDROPOPTIONSMOVEUPMOUSEUP,
    PENALTYDROPOPTIONSMOVEDOWNMOUSEUP,

    PENALTYSTOPCOROUTINEACTION,
    DESTROYMAINMENU,
    DESTROYMINIMAP,
    SETMULLIGANBUTTON,
    SETPRESETENVIRONMENTVALUES,
    APPLYENVIROMENTSETTINGS,
    PANELEXITBEHAVIOUR,

    SHOWHIDELICENCEAUTHENTICATORWINDOW,
    UPDATECLUBIMAGEINDEXNNAME,
    SELECTNEXTPREVIOUSCLUB,
    SETDISTANCEANDGIMMIESTEXT,

    SETPRACTICEHUDCARDCOLOR,
    GETCURRENTPLAYERPHOTOSOURCE,
    OPENCLOSECONFIRMMULLIGANWINDOW,
    SETMULLIGANSNUMBERTOLOCALPLAYERMULLIGAN,
    SETCANUSEMULLIGANS,
    OPENACTIVATIONPANEL,

    CLOSECOURSESETTINGSANDMORE,
    CLOSEPRACTICESETTINGSANDMORE,


    OPENDEACTIVATECOURSECONFIRMATION,
    SETISCOURSEACTIVE,
    UPDATEISACTIVEONEACHOFTHECOURSES,
    UPDATEISACTIVEFORALLCOURSES,
    SHOWGOLFCOURSEDEACTIVATION,
    HIDEGOLFCOURSEDEACTIVATION,
    DEACTIVATECOURSEBUTTON,
    SHOWNOTPURCHASEDWINDOW,
    HIDENOTPURCHASEDWINDOW,
    UPDATEISPURCHASEDONEACHOFTHECOURSES,
    CLOSEALLLOGINDIALOGS,
    SETUSERNAMETITLETEXT,
    SHOWACTIVATINGLICENSEWINDOW,
    HIDEACTIVATINGLICENSEWINDOW,
    ACTIVATECOURSE,
    SHOW_ERROR_ACTIVATION_OR_DEACTIVATION_WINDOW,
    HIDEERRORACTIVATIONWINDOW,
    LOADCOURSECATALOGUE,
    SETMENUPROFILEIMAGE,
    OPENCLOSESIGNUPWINDOW,
    CALLBACKSIGNUPNEWUSER,
    SIGNUPNEWUSER,
    GETPLAYERINDEXINACTUALPLAYERLIST,
    SHOWHIDECRASHRESTOREPLACEHOLDER,
    ONCLICKYESRESTOREPANEL,
    PLAYSHOTINREPLAY,
    NEXTSHOTINREPLAY,
    PREVIOUSSHOTINREPLAY,
    SAVESETTING,
    REPLAYCAMERASELECTED,
    PAUSEINREPLAY,
    SETSCORECARDEXITLABEL,
    SHOWHIDEPICTURESETTINGS,
    GETCURRENTPICTURESETTINGSCALL,
    GETVISUALSETTINGSSTATUS,
    SETPLAYBUTTONINREPLAY,

    GETSTROKELIMITPANELSTATUS,
    SETSTROKELIMITPANELSTATUS,

    LOGINAFTERSIGNUP,
    SHOWHIDENOACCESPOPUP,
    TRYCONNECT,
    SHOWHIDEMANUALPUTTING,
    GETACTUALPLAYERLISTLENGTH,
    INTROACTIONDIALOG,
    SHOWHIDECLUBSELECTION,
    SHOWHIDENOTINSTALLEDWINDOW,
    SHOWHIDENOINTERNETPOPUP,
    GETFIRSTSELECTEDTEE,
    SETDATATILESVISIVILITY,
    SHOWHIDECLUBSELECTORBAR,
    CLOSECOURSESETTINGSANDMOREPRACTICE,
    SETERRORTEXTACTIVATE,
    SHOWHIDELOADINGWHEEL,
    GETSRIGHTBORDER,
    ADDNEWCLUBTOLIST,
    SORTALLCLUBSBYDISTANCE,
    SELECTCLUBBYINDEX,
    SETPAGEINMENU,
    OPENINGAMESETTINGSPANELINTAB,
    ASSIGNNEWINFOTOCLUBSELECT,
    GETCLUBSELECTIONSTATUS,
    SHOWHIDECLOSESTNLONGEST,
    UPDATEPLAYERSCLOSESTORLONGESTLIST,
    SETSHOTNUMBERTEXT,
    SETSHOTNUMBERTEXTCARDPLAYER,
    SHOWHIDECENTERPANELPOPUP,
    PLAYAGAINBUTTON,
    BACKMAINMENUBUTTON,
    SHOWHIDECLUBSELECTORUI,
    SHOWHOLEOUTPLAYERTRANSITION,
    SHOWFADERTRANSITION,
    SHOWINITIALFADERTRANSITION,
    CLOSEHOLETRANSITION,
    SETDISTANCEANDPUTTSTEXT,
    SETMANUALPUTTSTEXT,
    SETHUDVISIBLESTATE,

    SETHOLEENDINGPLAYERDATA,
    CLOSEHOLEENDINGPLAYERDATA,

    OPENCLOSEPLAYERISALREADYACTIVEWINDOW,

    SHOWORHIDEREDEEMINGCODEWINDOW,

    SHOWFEEDBACKREDEEMINGCODEWINDOW,

    RELOADCATALOGS,
    TOGGLESHORTCUTSPANEL,
    GETSHORTCUTSPANELSTATE,

    SETDEVICENOTUNLOCKEDWINDOW,

    INITCATALOGUES,

    SETMINIMAPTOTALDISTANCE,

    SETCLUBREQUESTWARNING,

    SETLIEPENALTYPANEL,
    SETLIEPENALTYVISIBILITY,

    ENABLELEFTSIDEDATATILESSETTING,
    
    UPDATEINSTALLINGCOUSESTATE,

    SHOWHIDETILESCATEGORIESPANEL,

    UPDATEFAVORITECATALOGSTATE,

    SETSAVESLOTTOLOAD,
    SHOWMAXENTRIESREACHEDALERT,
    SHOWLOGINREQUIREDALERT,
    SHOWRESTRICTEDPERMISIONALERT,
    ACTIVATECOURSELIST,
    DEACTIVATECOURSELIST,

    OPENEXITGAMEPANEL,

    LOAD_CONTEST_BANNER,

    SHOW_CONTEST_PAGE,
    SHOW_CONTEST_FINISHCREATION_PAGE,

    SHOW_INSTALLATION_ERROR,

    SHOW_ERROR_START_DOWNLAOD_WINDOW,
    HIDE_ERROR_START_DOWNLAOD_WINDOW,

    LOGIN_USERNAME_ERROR,
    LOGIN_PASSWORD_ERROR,
    LOGINWITHPASSWORD_SUCCESS,

    LOGIN_WITH_DEVICE_NOT_SUPPORT_SUBSCRIPTION,
    LOGIN_WITH_DEVICE_REQUIRE_UPGRADE,
    LOGIN_WITH_DEVICE_SUBSCRIPTION_SUCCESS,
    LOGIN_WITH_DEVICE_ERROR_ON_CONNECTION,
    LOGIN_WITH_DEVICE_REQUIRE_LICENSE_KEY,

    SHOW_HIDE_RESTRICTION_BY_SUBSCRIPTION,
    GET_RESTRICTION_POPUP_STATUS,    
    
    SHOW_ERROR_ON_TRANSFER_LICENCE,    

    SHOW_LICENSING_DEVICE_AT_START,
    SHOW_DONGLE_COURSES_ERROR,
    SHOW_HIDE_EULA_SCREEN,
    OPENYIELDHOLECONFIRMATION,
    OPEN_COURSE_SELECTOR,
}
public enum ActionType
{
    LOADGAME,
    LOADMYPRACTICE,
    LOADMYCOURSES,
    LOADMYFAVORITECOURSES,
    LOADLASTPLAYEDCOURSES,
    LOADONSALECOURSES,
    ADDFAVORITECOURSE,
    REMOVEFAVORITE,
    LOADMYFAVORITEPRACTICE,
    LOADLASTPLAYEDPRACTICE,
    LOADONSALEPRACTICE,
    ADDFAVORITEPRACTICE,
    REMOVEFAVORITEPRACTICE,
    LOADPREMIUMPRACTICE,
    LOADSTANDARDPRACTICE,
    LOADPREMIUMCOURSE,
    LOADSTANDARDCOURSE,
    LOADVIDEO,
    GETVIDEORENDER,
    GETVIDEORENDERFLYBY,
    PLAYVIDEO,
    STOPVIDEO,
    LOADIMAGE,
    LOADCARTITEMS,
    ADDITEMTOCART,
    REMOVEITEMFROMCART,
    COMFIRMPURCHASE,
    CLEARCART,
    LOADGAMEYOSEMITE,
    LOADMINIMAP,
    SET2DTO3DCOORDSLEFT,
    CANCELAUTOCARDS,
    GETCLUBCANVASSIZE,
    QWERTY,
    LBURRANGARRA,
    SETMINIMAPMOUSEDOWN,
    SETMINIMAPMOUSEPOS,
    SETMINIMAPMOUSEOVER,
    CLOSEEXITWINDOW,
    BACKTOMENU,
    LOADMENUVIDEO,
    STOPFLYBYVIDEO,
    CHANGEINFOTABSTATE,
    CLOSEAFTERSHOTPANEL,
    STARTFLYBY,
    STARTREPLAY,
    SHOWCARDSBUTTON,
    CHANGEMINIMAPSTATE,
    RENDERVIDEOFLYBY,
    LOADPHOTOS,
    ADDTEXTURETOCOURSESPHOTOS,
    ACTIVATEFADERFLYBY,

    #region Replay system

    CLOSEREPLAYSYSTEM,
    PLAYREPLAYSHOT,
    NEXTREPLAYSHOT,
    PREVREPLAYSHOT,
    CHANGEREPLAYINDEX,
    GETSHOTINDEX,
    PAUSEREPLAYSHOT,
    #endregion

    STARTGREENCONTOUR,
    STARTGREENGRID,
    STARTBIRDVIEW,
    HAMBURGUERSET,
    SHOWENVIRONMENT,
    GETDEVICELIST,
    CONNECTSELECTEDDEVICE,
    DISSCONECTSELECTEDDEVICE,
    STARTFLAGPEEK,
    STARTRELOCATE,
    SYNCRODEVICEUI,

    SETCURRENTCLUB,
    SETCURRENTBALL,
    GETCLUBLIST,
    GETBALLLIST,
    GETCURRENTCLUB,
    GETCURRENTBALL,
    ADDNEWCLUB,
    ADDNEWBALL,
    MODIFYCLUB,
    MODIFYBALL,
    REMOVEBALL,
    REMOVECLUB,
    GETPLAYERHANDEDNESS,
    SETPLAYERHANDEDNESS,
    GUIOPENPANEL,
    GUICLOSEPANEL,

    GETLOCALPLAYERLIST,
    ADDNEWLOCALPLAYER,
    REMOVELOCALPLAYER,
    MODIFYLOCALPLAYER,
    LOADPLAYERLIST,
    SELECTLOCALPLAYER,

    SETBALLASSIST,
    CONNECTDEVICESTARTUP,
    OPENCAMERACONTROL,
    SETQUALITY,
    GETQUALITY,

    PAUSEGAME,

    SET2DTO3DCOORDSRIGHT,

    SHOWGREENSETTINGS,

    LOADLOADINGSCREENVIDEO,
    GETLOADINGVIDEORENDER,

    SHOWTEESELECTION,

    SETRELOCATEDISTANCE,
    RESETRELOCATEDISTANCE,
    SETRELOCATEPOSITION,
    STARTPRACTICEMODE,
    SETSKIPHOLE,
    GETSKIPHOLESTATUS,

    OPENSCORECARD,
    GETREALTIMEWEATHERVALUES,
    SETDOTTEDBALLSTATUS,
    SETTEEPOSITION,
    DSETISCLICKINGUI,
    RESETAIMPOINT,
    CLOSESCORECARD,

    GETWINDBASICBUTTONVALUE,
    GETWEATHERPRESETVALUES,
    LOADHOLESBYCOURSE,

    UPDATEPLAYERHANDEDNESS,
    LOADOWNERPLAYER,
    GETHOLENUMBER,
    SETTESTCOLOR,
    CHECKFOROPENPANEL,
    SETSHOWANALYSISWINDOW,

    REORDERPLAYERLIST,

    GETISDEVICECONNECTED,
    GETDEVICEALTITUDE,
    SETMULLIGAN,

    ACTIVATELICENCE,

    VALIDATEUSERNAMELOGIN,
    VALIDATEUSERNAMERESPONSE,
    VALIDATELOGINRESPONSE,
    LOGINWITHPASSWORD,
    SETDEVICEAUTOSEARCHSTATUS,
    GETIMAGEWITHCALLBACK,
    FORGOTPASSWORDRESPONSE,
    FORGOTPASSWORDEMAILORUSERNAMEVALIDATE,
    GETSHOTLIST,
    GETCURRENTSHOT,
    LOADVISUALSETTINGS,
    GETCURRENTPICTURESETTINGS,
    OPENVISUALSETTINGS,
    OPENCLOSEVISUALSETTINGS,
    CLICK_YES_INTERNET_UI,
    CLICK_NO_INTERNET_UI,
    SAVEPICTURESETTINGS,
    UPDATEPRACTICEPLAYERSELECTED,
    LOADMANUALPUTTINGVALUES,
    ASSIGNVALUESMANUALPUTTING,
    PLAYVIDEOFROMURL,
    PLAYPAUSEFLYBY,
    CHECKFORACTIVATEDCOURSES,

    LOADONSALEGAMES,
    LOADMYGAMES,
    LOADMYFAVORITEGAMES,
    LOADLASTPLAYEDGAMES,
    LOADPREMIUMGAMES,
    LOADSTANDARDGAMES,
    SHOW_CTP_POPUP,
    SETPRECONFIGURATION,

    SET_MINIMAP_EXPAND,
    LOADPRACTICEANDCOURSES,

    REDEEMCOURSEACTIVATIONCODE,
    CHECKALLOWTONEXTPLAYER,
    GETCLUBMODEBYSLOT,
    SETCLUBTYPEBYSLOT,

    EXITGAMEMENU,

    INSTALLCOURSEFROMCATALOG,
    COURSE_DOWNLOADED,
    SETFLIGHTBEHAVIOR,
    ONENTERCOURSEPREVIEWTABS,
    SEND_PURCHASED_ANALYTICS,

    START_GAME_WITH_DEVICE_CONNECTED,

    TRANSFER_LICENCE,

    SEND_EULA_ACCEPTED,
    SETYIELDHOLE
}
public enum LanguageAction
{
    SETHUDTEXT = 0,
    SETWEATHERTEXT = 1,
    SETBUYINFOTEXT = 2,
    SETCOUSEINFOTEXT = 3,
    SETDRINFOTEXT = 4,
    SETPRACTICECATALOGTEXT = 5,
    SETCOURSESCATALOGTEXT = 6,
    SETMAINMENUTEXT = 7,
    SETCOURSEITEMTEXT = 8,
    SETSETTINGSLANGUAGE = 9,
    SETGAMESCATALOGTEXT = 10,
    SETEXITGAMETEXT = 11,
    SETLOADINGLANGUAGE = 12,
    SETCRASHRESTORELANGUAGE = 13,
    SETPRACTICERIBBONTEXT = 14,
    SETPURCHASETEXT = 15,
    SETAUTHENTICATORTEXTS = 16,
    SETLANGUAGESBUTTONS = 17,
    SETGAMESTEXT = 18,
    SETINFOCOURSETEXT = 19,
    SETRELOCATETEXT = 20
}