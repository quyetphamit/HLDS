using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
namespace OpenCVWinForm
{
    internal class Resources
    {
        // Fields
        private static CultureInfo resourceCulture;
        private static ResourceManager resourceMan;

        // Methods
        internal Resources()
        {
        }

        // Properties
        internal static UnmanagedMemoryStream _1kHz05sec
        {
            get
            {
                return ResourceManager.GetStream("_1kHz05sec", resourceCulture);
            }
        }

        internal static UnmanagedMemoryStream _1kHz100msec
        {
            get
            {
                return ResourceManager.GetStream("_1kHz100msec", resourceCulture);
            }
        }

        internal static Bitmap _30MMCOL
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("_30MMCOL", resourceCulture);
            }
        }

        internal static Bitmap _37MM_inv
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("_37MM_inv", resourceCulture);
            }
        }

        internal static Bitmap _37mm_whtsmk
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("_37mm_whtsmk", resourceCulture);
            }
        }

        internal static Bitmap _37mm_whtsmk1
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("_37mm_whtsmk1", resourceCulture);
            }
        }

        internal static Bitmap ABEX_logo
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("ABEX_logo", resourceCulture);
            }
        }

        //internal static string BT1_CAPTURE
        //{
        //    get
        //    {
        //        return ResourceManager.GetString("BT1_CAPTURE", resourceCulture);
        //    }
        //}

        internal static string BT1_STOP
        {
            get
            {
                return ResourceManager.GetString("BT1_STOP", resourceCulture);
            }
        }

        //internal static string BT16_TEACHING_MSG_CHANGED_SAVE
        //{
        //    get
        //    {
        //        return ResourceManager.GetString("BT16_TEACHING_MSG_CHANGED_SAVE", resourceCulture);
        //    }
        //}

        //internal static string BT16_TEACHING_MSG_INSPECTION_CLEARED
        //{
        //    get
        //    {
        //        return ResourceManager.GetString("BT16_TEACHING_MSG_INSPECTION_CLEARED", resourceCulture);
        //    }
        //}

        //internal static string BT21_CLALL_MSG_REMOVE_DATA
        //{
        //    get
        //    {
        //        return ResourceManager.GetString("BT21_CLALL_MSG_REMOVE_DATA", resourceCulture);
        //    }
        //}

        internal static string BT3_SET_MSG_PLEASE_SPECIFY
        {
            get
            {
                return ResourceManager.GetString("BT3_SET_MSG_PLEASE_SPECIFY", resourceCulture);
            }
        }

        internal static string BT37_ALLUPDATE_MSG_YESNO
        {
            get
            {
                return ResourceManager.GetString("BT37_ALLUPDATE_MSG_YESNO", resourceCulture);
            }
        }

        internal static string BT8_DIFF
        {
            get
            {
                return ResourceManager.GetString("BT8_DIFF", resourceCulture);
            }
        }

        //internal static string BT8_DIFF_AREA
        //{
        //    get
        //    {
        //        return ResourceManager.GetString("BT8_DIFF_AREA", resourceCulture);
        //    }
        //}

        //internal static string CAUTION
        //{
        //    get
        //    {
        //        return ResourceManager.GetString("CAUTION", resourceCulture);
        //    }
        //}

        //internal static string CB1_CLICK_MSG_CHANGED_SAVE
        //{
        //    get
        //    {
        //        return ResourceManager.GetString("CB1_CLICK_MSG_CHANGED_SAVE", resourceCulture);
        //    }
        //}

        internal static string CB1_KEYDOWN_MSG_REMOVE_DATA
        {
            get
            {
                return ResourceManager.GetString("CB1_KEYDOWN_MSG_REMOVE_DATA", resourceCulture);
            }
        }

        internal static string CCTCLICK_MSG_IND_CAMERA_OPEN
        {
            get
            {
                return ResourceManager.GetString("CCTCLICK_MSG_IND_CAMERA_OPEN", resourceCulture);
            }
        }

        internal static string CCTCLICK_MSG_INDWEB_CAMERA_OPEN
        {
            get
            {
                return ResourceManager.GetString("CCTCLICK_MSG_INDWEB_CAMERA_OPEN", resourceCulture);
            }
        }

        internal static string CCTCLICK_MSG_NOT_FIND_CAMERA
        {
            get
            {
                return ResourceManager.GetString("CCTCLICK_MSG_NOT_FIND_CAMERA", resourceCulture);
            }
        }

        internal static string CCTCLICK_MSG_WEB_CAMERA_OPEN
        {
            get
            {
                return ResourceManager.GetString("CCTCLICK_MSG_WEB_CAMERA_OPEN", resourceCulture);
            }
        }

       
        internal static CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        internal static string DEVICE_CONNECTION
        {
            get
            {
                return ResourceManager.GetString("DEVICE_CONNECTION", resourceCulture);
            }
        }

        internal static string DEVICE_DISCONNECT
        {
            get
            {
                return ResourceManager.GetString("DEVICE_DISCONNECT", resourceCulture);
            }
        }

        internal static string DEVICE_PROPERTY
        {
            get
            {
                return ResourceManager.GetString("DEVICE_PROPERTY", resourceCulture);
            }
        }

        internal static string ERROR
        {
            get
            {
                return ResourceManager.GetString("ERROR", resourceCulture);
            }
        }

        internal static Bitmap expand_screen_gray
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("expand_screen_gray", resourceCulture);
            }
        }

        internal static Bitmap expand_screen_whtsmk
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("expand_screen_whtsmk", resourceCulture);
            }
        }

        internal static Bitmap folder
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("folder", resourceCulture);
            }
        }

        internal static Bitmap folderC
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("folderC", resourceCulture);
            }
        }

        internal static Bitmap folderD
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("folderD", resourceCulture);
            }
        }

        internal static string FORMCLOSE_MSG_EXIT
        {
            get
            {
                return ResourceManager.GetString("FORMCLOSE_MSG_EXIT", resourceCulture);
            }
        }

        internal static string FORMCLOSE_MSG_NOT_FIND_USBKEY
        {
            get
            {
                return ResourceManager.GetString("FORMCLOSE_MSG_NOT_FIND_USBKEY", resourceCulture);
            }
        }

        internal static string FORMCLOSE_MSG_PARAMETER_CHANGE
        {
            get
            {
                return ResourceManager.GetString("FORMCLOSE_MSG_PARAMETER_CHANGE", resourceCulture);
            }
        }

        internal static string FORMCLOSE_MSG_PID_INVALID
        {
            get
            {
                return ResourceManager.GetString("FORMCLOSE_MSG_PID_INVALID", resourceCulture);
            }
        }

        internal static string FORMCLOSE_MSG_SAVE_CONFIG_FILE
        {
            get
            {
                return ResourceManager.GetString("FORMCLOSE_MSG_SAVE_CONFIG_FILE", resourceCulture);
            }
        }

        internal static string FORMCLOSE_MSG_USBKEY_INVALID
        {
            get
            {
                return ResourceManager.GetString("FORMCLOSE_MSG_USBKEY_INVALID", resourceCulture);
            }
        }

        internal static Bitmap full_screen_gray
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("full_screen_gray", resourceCulture);
            }
        }

        internal static Bitmap full_screen_whtsmk
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("full_screen_whtsmk", resourceCulture);
            }
        }

        internal static string IF_OPEN_MSG_CAN_NOT_OPEN
        {
            get
            {
                return ResourceManager.GetString("IF_OPEN_MSG_CAN_NOT_OPEN", resourceCulture);
            }
        }

        //internal static string L_DIFFERENCE
        //{
        //    get
        //    {
        //        return ResourceManager.GetString("L_DIFFERENCE", resourceCulture);
        //    }
        //}

        internal static string L_DIFFERENCE_IMAGE
        {
            get
            {
                return ResourceManager.GetString("L_DIFFERENCE_IMAGE", resourceCulture);
            }
        }

        //internal static string L_JUDGE
        //{
        //    get
        //    {
        //        return ResourceManager.GetString("L_JUDGE");
        //    }
        //}

        internal static string L_NG
        {
            get
            {
                return ResourceManager.GetString("L_NG", resourceCulture);
            }
        }

        internal static string L_NOTINSPECTION
        {
            get
            {
                return ResourceManager.GetString("L_NOTINSPECTION", resourceCulture);
            }
        }

        internal static string L_PASS
        {
            get
            {
                return ResourceManager.GetString("L_PASS", resourceCulture);
            }
        }

        internal static string L_USER_OPERATOR
        {
            get
            {
                return ResourceManager.GetString("L_USER_OPERATOR", resourceCulture);
            }
        }

        internal static string L_USER_SERVICE
        {
            get
            {
                return ResourceManager.GetString("L_USER_SERVICE", resourceCulture);
            }
        }

        internal static string LISTVIEW_DIFF
        {
            get
            {
                return ResourceManager.GetString("LISTVIEW_DIFF", resourceCulture);
            }
        }

        internal static string LISTVIEW_GAP
        {
            get
            {
                return ResourceManager.GetString("LISTVIEW_GAP", resourceCulture);
            }
        }

        internal static string LISTVIEW_JUDGE
        {
            get
            {
                return ResourceManager.GetString("LISTVIEW_JUDGE", resourceCulture);
            }
        }

        internal static string LISTVIEW_MATCH
        {
            get
            {
                return ResourceManager.GetString("LISTVIEW_MATCH", resourceCulture);
            }
        }

        internal static string LISTVIEW_NAME
        {
            get
            {
                return ResourceManager.GetString("LISTVIEW_NAME", resourceCulture);
            }
        }

        //internal static string LISTVIEW_NO
        //{
        //    get
        //    {
        //        return ResourceManager.GetString("LISTVIEW_NO", resourceCulture);
        //    }
        //}

        //internal static Bitmap load32
        //{
        //    get
        //    {
        //        return (Bitmap)ResourceManager.GetObject("load32", resourceCulture);
        //    }
        //}

        internal static Bitmap load64
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("load64", resourceCulture);
            }
        }

        internal static Bitmap loadinfo16
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("loadinfo16", resourceCulture);
            }
        }

        internal static Bitmap loadinfo24
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("loadinfo24", resourceCulture);
            }
        }

        internal static Bitmap loadinfo48
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("loadinfo48", resourceCulture);
            }
        }

        internal static string MCLICK_MSG_BARCODE_READ
        {
            get
            {
                return ResourceManager.GetString("MCLICK_MSG_BARCODE_READ", resourceCulture);
            }
        }

        //internal static string MDSAVE_MSG_CAN_NOT_BE_SAVED
        //{
        //    get
        //    {
        //        return ResourceManager.GetString("MDSAVE_MSG_CAN_NOT_BE_SAVED", resourceCulture);
        //    }
        //}

        //internal static string MDSAVE_MSG_PLEASE_SAVE_TO
        //{
        //    get
        //    {
        //        return ResourceManager.GetString("MDSAVE_MSG_PLEASE_SAVE_TO", resourceCulture);
        //    }
        //}

        internal static UnmanagedMemoryStream ng
        {
            get
            {
                return ResourceManager.GetStream("ng", resourceCulture);
            }
        }

        internal static string OPTCLICK_MSG_CAN_NOT_OPEN
        {
            get
            {
                return ResourceManager.GetString("OPTCLICK_MSG_CAN_NOT_OPEN", resourceCulture);
            }
        }

        internal static UnmanagedMemoryStream pass
        {
            get
            {
                return ResourceManager.GetStream("pass", resourceCulture);
            }
        }

     
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    ResourceManager manager = new ResourceManager("AAC-1000.resources", typeof(Resources).Assembly);
                    resourceMan = manager;
                }
                return resourceMan;
            }
        }

        internal static Bitmap rotation_whtsmk
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("rotation_whtsmk", resourceCulture);
            }
        }

        internal static Bitmap rotationCL
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("rotationCL", resourceCulture);
            }
        }

        internal static Bitmap rotationCR
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("rotationCR", resourceCulture);
            }
        }

        //internal static Bitmap rotationGL
        //{
        //    get
        //    {
        //        return (Bitmap)ResourceManager.GetObject("rotationGL", resourceCulture);
        //    }
        //}

        internal static Bitmap rotationGR
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("rotationGR", resourceCulture);
            }
        }

        internal static Bitmap rotationWL
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("rotationWL", resourceCulture);
            }
        }

        internal static Bitmap rotationWR
        {
            get
            {
                return (Bitmap)ResourceManager.GetObject("rotationWR", resourceCulture);
            }
        }

        internal static string SUCCESS
        {
            get
            {
                return ResourceManager.GetString("SUCCESS", resourceCulture);
            }
        }

        internal static string SYSSET_BT10_MSG_LOGFILE_CHANGED
        {
            get
            {
                return ResourceManager.GetString("SYSSET_BT10_MSG_LOGFILE_CHANGED", resourceCulture);
            }
        }

        internal static string SYSSET_BT10_MSG_LOGFILE_REBOOT
        {
            get
            {
                return ResourceManager.GetString("SYSSET_BT10_MSG_LOGFILE_REBOOT", resourceCulture);
            }
        }

        internal static string SYSSET_BT12_MSG_MODELDATA_CHANGED
        {
            get
            {
                return ResourceManager.GetString("SYSSET_BT12_MSG_MODELDATA_CHANGED", resourceCulture);
            }
        }

        internal static string SYSSET_BT12_MSG_MODELDATA_RECONFIGURE
        {
            get
            {
                return ResourceManager.GetString("SYSSET_BT12_MSG_MODELDATA_RECONFIGURE", resourceCulture);
            }
        }

        internal static string SYSSET_BT22_MSG_FOLDER_CHANGED
        {
            get
            {
                return ResourceManager.GetString("SYSSET_BT22_MSG_FOLDER_CHANGED", resourceCulture);
            }
        }

        internal static string USER_B3_CHANGE_THE_PASSWORD
        {
            get
            {
                return ResourceManager.GetString("USER_B3_CHANGE_THE_PASSWORD", resourceCulture);
            }
        }

        internal static string USER_L1_NEWPASSWORD
        {
            get
            {
                return ResourceManager.GetString("USER_L1_NEWPASSWORD", resourceCulture);
            }
        }

        internal static string USER_L1_PASSWORD
        {
            get
            {
                return ResourceManager.GetString("USER_L1_PASSWORD", resourceCulture);
            }
        }

        internal static string USER_L2_INCORRECT_PASSWORD
        {
            get
            {
                return ResourceManager.GetString("USER_L2_INCORRECT_PASSWORD", resourceCulture);
            }
        }

        internal static string USER_L2_RETURN_TO_OPERATOR
        {
            get
            {
                return ResourceManager.GetString("USER_L2_RETURN_TO_OPERATOR", resourceCulture);
            }
        }

        internal static string USER_MSG_CHANGE_PASSWORD
        {
            get
            {
                return ResourceManager.GetString("USER_MSG_CHANGE_PASSWORD", resourceCulture);
            }
        }

        internal static string USER_MSG_DO_NOT_MATCH_PASSWORD
        {
            get
            {
                return ResourceManager.GetString("USER_MSG_DO_NOT_MATCH_PASSWORD", resourceCulture);
            }
        }

        internal static string USER_MSG_NEW_PASSWORD_SAVED
        {
            get
            {
                return ResourceManager.GetString("USER_MSG_NEW_PASSWORD_SAVED", resourceCulture);
            }
        }
    }

}
