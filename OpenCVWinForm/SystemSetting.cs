using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace OpenCVWinForm
{
    public class SystemSetting
    {
        // Fields
        private bool _autoCut = false;
        private int _autoDevH = 1;
        private int _autoDevW = 1;
        private bool _autoTrim = false;
        private bool _bcdEnabled = false;
        private string _configName = "";
        private string _curCsvPath = "";
        private string _curImagePath = "";
        private bool _fileWatch = false;
        private bool _keyStart = true;
        private bool _listviewErrOnly = false;
        private bool _numberDisp = false;
        private string _password0 = "";
        private string _password1 = "";
        private bool _reverseX = false;
        private bool _reverseY = false;
        private bool _rotation270 = false;
        private bool _rotation90 = false;
        private int _selectCameraNo = 0;
        private string _selectModel = "";
        private int _testInterval = 0xbb8;

        // Methods
        public static int ReadXML<Type>(out Type pClass, string pPath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Type));
            using (FileStream stream = new FileStream(pPath, FileMode.Open))
            {
                pClass = (Type)serializer.Deserialize(stream);
            }
            return 0;
        }

        public static int WriteXML<Type>(Type pClass, string pPath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Type));
            using (FileStream stream = new FileStream(pPath, FileMode.Create))
            {
                serializer.Serialize((Stream)stream, pClass);
            }
            return 0;
        }

        // Properties
        public bool autoCut
        {
            get
            {
                return this._autoCut;
            }
            set
            {
                this._autoCut = value;
            }
        }

        public int autoDevH
        {
            get
            {
                return this._autoDevH;
            }
            set
            {
                this._autoDevH = value;
            }
        }

        public int autoDevW
        {
            get
            {
                return this._autoDevW;
            }
            set
            {
                this._autoDevW = value;
            }
        }

        public bool autoTrim
        {
            get
            {
                return this._autoTrim;
            }
            set
            {
                this._autoTrim = value;
            }
        }

        public bool bcdEnabled
        {
            get
            {
                return this._bcdEnabled;
            }
            set
            {
                this._bcdEnabled = value;
            }
        }

        public string configName
        {
            get
            {
                return this._configName;
            }
            set
            {
                this._configName = value;
            }
        }

        public string curCsvPath
        {
            get
            {
                return this._curCsvPath;
            }
            set
            {
                this._curCsvPath = value;
            }
        }

        public string curImagePath
        {
            get
            {
                return this._curImagePath;
            }
            set
            {
                this._curImagePath = value;
            }
        }

        public bool fileWatch
        {
            get
            {
                return this._fileWatch;
            }
            set
            {
                this._fileWatch = value;
            }
        }

        public bool keyStart
        {
            get
            {
                return this._keyStart;
            }
            set
            {
                this._keyStart = value;
            }
        }

        public bool listviewErrOnly
        {
            get
            {
                return this._listviewErrOnly;
            }
            set
            {
                this._listviewErrOnly = value;
            }
        }

        public bool numberDisp
        {
            get
            {
                return this._numberDisp;
            }
            set
            {
                this._numberDisp = value;
            }
        }

        public string password0
        {
            get
            {
                return this._password0;
            }
            set
            {
                this._password0 = value;
            }
        }

        public string password1
        {
            get
            {
                return this._password1;
            }
            set
            {
                this._password1 = value;
            }
        }

        public bool reverseX
        {
            get
            {
                return this._reverseX;
            }
            set
            {
                this._reverseX = value;
            }
        }

        public bool reverseY
        {
            get
            {
                return this._reverseY;
            }
            set
            {
                this._reverseY = value;
            }
        }

        public bool rotation270
        {
            get
            {
                return this._rotation270;
            }
            set
            {
                this._rotation270 = value;
            }
        }

        public bool rotation90
        {
            get
            {
                return this._rotation90;
            }
            set
            {
                this._rotation90 = value;
            }
        }

        public int selectCameraNo
        {
            get
            {
                return this._selectCameraNo;
            }
            set
            {
                this._selectCameraNo = value;
            }
        }

        public string selectModel
        {
            get
            {
                return this._selectModel;
            }
            set
            {
                this._selectModel = value;
            }
        }

        public int testInterval
        {
            get
            {
                return this._testInterval;
            }
            set
            {
                this._testInterval = value;
            }
        }
    }

 

}
