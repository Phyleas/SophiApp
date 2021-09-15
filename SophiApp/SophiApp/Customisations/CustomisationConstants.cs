﻿using Microsoft.Win32.TaskScheduler;
using System.ServiceProcess;

namespace SophiApp.Customisations
{
    internal struct CustomisationConstants
    {
        internal const string _100_DIAG_TRACK = "DiagTrack";
        internal const string _104_CORE = "Core";
        internal const string _104_DISABLED = "Disabled";
        internal const byte _104_DISABLED_DEFAULT_VALUE = 1;
        internal const string _104_QUEUE_TASK = "QueueReporting";
        internal const string _104_WER_PATH = @"SOFTWARE\Microsoft\Windows\Windows Error Reporting";
        internal const string _104_WER_SERVICE = "WerSvc";
        internal const ServiceStartMode _104_WER_SERVICE_MANUAL = ServiceStartMode.Manual;
        internal const string _109_PRO_DATA_UPD = "ProgramDataUpdater";
        internal const string _110_PROXY = "Proxy";
        internal const string _111_CONS = "Consolidator";
        internal const string _112_USB_CEIP = "UsbCeip";
        internal const string _113_DISK_DATA_COLLECTOR = "Microsoft-Windows-DiskDiagnosticDataCollector";
        internal const string _114_MAPS_TOAST = "MapsToastTask";
        internal const string _115_MAPS_UPDATE = "MapsUpdateTask";
        internal const string _116_FAMILY_MONITOR = "FamilySafetyMonitor";
        internal const string _117_XBOX_SAVE = "XblGameSaveTask";
        internal const string _118_OPT_OUT = "OptOut";
        internal const byte _118_OPT_OUT_DEFAULT_VALUE = 1;
        internal const string _118_USER_ARSO_PATH = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\UserARSO";
        internal const string _119_HTTP_ACCEPT = "HttpAcceptLanguageOptOut";
        internal const byte _119_HTTP_ACCEPT_DEFAULT_VALUE = 1;
        internal const string _119_USER_PROFILE_PATH = @"Control Panel\International\User Profile";
        internal const string _120_ADVERT_ENABLED = "Enabled";
        internal const string _120_ADVERT_INFO_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\AdvertisingInfo";
        internal const string _121_SUB_CONTENT = "SubscribedContent-310093Enabled";
        internal const string _122_SUB_CONTENT = "SubscribedContent-338389Enabled";
        internal const string _123_SUB_CONTENT_93 = "SubscribedContent-338393Enabled";
        internal const string _123_SUB_CONTENT_94 = "SubscribedContent-353694Enabled";
        internal const string _123_SUB_CONTENT_96 = "SubscribedContent-353696Enabled";
        internal const string _124_SILENT_APP_INSTALL = "SilentInstalledAppsEnabled";
        internal const string _125_PROFILE_ENGAGE_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\UserProfileEngagement";
        internal const string _125_SETTING_ENABLED = "ScoobeSystemSettingEnabled";
        internal const string _126_PRIVACY_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Privacy";
        internal const string _126_TAILORED_DATA = "TailoredExperiencesWithDiagnosticDataEnabled";
        internal const string _127_DISABLE_SEARCH_SUGGESTIONS = "DisableSearchBoxSuggestions";
        internal const string _800_MSI_EXTRACT_COM_PATH = @"Msi.Package\shell\Extract\Command";
        internal const string _800_MSI_EXTRACT_PATH = @"Msi.Package\shell\Extract";
        internal const string _800_MSI_EXTRACT_VALUE = "msiexec.exe /a \"%1\" /qb TARGETDIR=\"%1 extracted\"";
        internal const string _800_MSI_ICON = "Icon";
        internal const string _800_MSI_ICON_VALUE = "shell32.dll,-16817";
        internal const string _800_MSI_MUIVERB_VALUE = "@shell32.dll,-37514";
        internal const string _801_CAB_COM_PATH = @"CABFolder\Shell\RunAs\Command";
        internal const string _801_CAB_LUA_SHIELD = "HasLUAShield";
        internal const string _801_CAB_RUNAS_PATH = @"CABFolder\Shell\RunAs";
        internal const string _801_CAB_VALUE = "cmd /c DISM.exe /Online /Add-Package /PackagePath:\"%1\" /NoRestart & pause\"";
        internal const string _801_MUIVERB_VALUE = "@shell32.dll,-10210";
        internal const string _802_EXTENDED = @"Extended";
        internal const string _802_RUNAS_USER_PATH = @"exefile\shell\runasuser";
        internal const string _803_CAST_TO_DEV_GUID = @"{7AD84985-87B4-4a16-BE58-8B72A5B390F7}";
        internal const string _803_CAST_TO_DEV_VALUE = "Play to menu";
        internal const string _804_SHARE_GUID = @"{E2BF9676-5F8F-435C-97EB-11607A5BEDF7}";
        internal const string _805_MS_PAINT_3D = "Microsoft.MSPaint";
        internal const string _806_BMP_EXT = @"SystemFileAssociations\.bmp\Shell\3D Edit";
        internal const string _807_GIF_EXT = @"SystemFileAssociations\.gif\Shell\3D Edit";
        internal const string _808_JPE_EXT = @"SystemFileAssociations\.jpe\Shell\3D Edit";
        internal const string _809_JPEG_EXT = @"SystemFileAssociations\.jpeg\Shell\3D Edit";
        internal const string _810_JPG_EXT = @"SystemFileAssociations\.jpg\Shell\3D Edit";
        internal const string _811_PNG_EXT = @"SystemFileAssociations\.png\Shell\3D Edit";
        internal const string _812_TIF_EXT = @"SystemFileAssociations\.tif\Shell\3D Edit";
        internal const string _813_TIFF_EXT = @"SystemFileAssociations\.tiff\Shell\3D Edit";
        internal const string _814_PHOTOS_SHELL_EDIT_PATH = @"AppX43hnxtbyyps62jhe9sqpdzxn1790zetc\Shell\ShellEdit";
        internal const string _815_PHOTOS_SHELL_VIDEO_PATH = @"AppX43hnxtbyyps62jhe9sqpdzxn1790zetc\Shell\ShellCreateVideo";
        internal const string _816_IMG_SHELL_EDIT_PATH = @"SystemFileAssociations\image\shell\edit";
        internal const string _817_BAT_SHELL_EDIT_PATH = @"batfile\shell\print";
        internal const string _817_CMD_SHELL_EDIT_PATH = @"cmdfile\shell\print";
        internal const string _818_HIDE_VALUE = "-{3dad6c5d-2167-4cae-9914-f99e41c12cfa}";
        internal const string _818_LIB_LOCATION_PATH = @"Folder\ShellEx\ContextMenuHandlers\Library Location";
        internal const string _818_SHOW_VALUE = "{3dad6c5d-2167-4cae-9914-f99e41c12cfa}";
        internal const string _819_HIDE_VALUE = "-{7BA4C740-9E81-11CF-99D3-00AA004AE837}";
        internal const string _819_SEND_TO_PATH = @"AllFilesystemObjects\shellex\ContextMenuHandlers\SendTo";
        internal const string _819_SHOW_VALUE = "{7BA4C740-9E81-11CF-99D3-00AA004AE837}";
        internal const string _820_BITLOCKER_BDELEV_PATH = @"Drive\shell\encrypt-bde-elev";
        internal const string _821_BMP_ITEM_NAME = "ItemName";
        internal const string _821_BMP_ITEM_VALUE = @"@%systemroot%\system32\mspaint.exe,-59414";
        internal const string _821_BMP_NULL_FILE = "NullFile";
        internal const string _821_BMP_SHELL_NEW = @".bmp\ShellNew";
        internal const string _822_DATA_VALUE = "{\rtf1}";
        internal const string _822_ITEM_VALUE = @"@%ProgramFiles%\Windows NT\Accessories\WORDPAD.EXE,-213";
        internal const string _822_MS_WORD_PAD = "Microsoft.Windows.WordPad";
        internal const string _822_RTF_SHELL_NEW = @".rtf\ShellNew";
        internal const string _823_ITEM_DATA = @"@%SystemRoot%\system32\zipfldr.dll,-10194";
        internal const string _823_ZIP_SHELLNEW_PATH = @".zip\CompressedFolder\ShellNew";
        internal const string _824_CURRENT_EXPLORER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer";
        internal const string _824_PROMPT_NAME = "MultipleInvokePromptMinimum";
        internal const int _824_PROMPT_VALUE = 300;
        internal const string _825_NO_USE_NAME = "NoUseStoreOpenWith";
        internal const byte _825_NO_USE_VALUE = 1;
        internal const string ALLOW_TELEMETRY = "AllowTelemetry";
        internal const string CAPABILITY_MS_PAINT = "Microsoft.Windows.MSPaint";
        internal const string CONTENT_DELIVERY_MANAGER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
        internal const string DATA = "Data";
        internal const string DATA_COLLECTION_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\DataCollection";
        internal const byte DEFAULT_TELEMETRY_VALUE = 3;
        internal const string DIAG_TRACK_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Diagnostics\DiagTrack";
        internal const byte DISABLED_VALUE = 0;
        internal const byte ENABLED_VALUE = 1;
        internal const string ITEM_NAME = "ItemName";
        internal const string MAX_TELEMETRY_ALLOWED = "MaxTelemetryAllowed";
        internal const byte MIN_ENT_TELEMETRY_VALUE = 0;
        internal const byte MIN_TELEMETRY_VALUE = 1;
        internal const string MUIVERB = "MUIVerb";
        internal const string POLICIES_EXPLORER_PATH = @"SOFTWARE\Policies\Microsoft\Windows\Explorer";
        internal const string PROGRAM_ACCESS_ONLY = "ProgrammaticAccessOnly";
        internal const string SHELL_EXT_BLOCKED_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Shell Extensions\Blocked";
        internal const string SHOWED_TOAST_LEVEL = "ShowedToastAtLevel";
        internal const string SIUF_PATH = @"SOFTWARE\Microsoft\Siuf\Rules";
        internal const string SIUF_PERIOD = "NumberOfSIUFInPeriod";
        internal const TaskState TASK_STATE_READY = TaskState.Ready;
        internal const string UWP_MS_WIN_PHOTOS = "Microsoft.Windows.Photos";
        internal const string WIN_VER_EDU = "Education";
        internal const string WIN_VER_ENT = "Enterprise";
        internal const string WIN_VER_PRO = "Professional";
        internal static byte[] _823_ZIP_DATA = new byte[] { 80, 75, 5, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    }
}