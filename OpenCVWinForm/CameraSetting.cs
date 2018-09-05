using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;
using System.ComponentModel;


using System.Data;
using System.Drawing;

using System.Xml;
using System.Xml.Serialization;
using System.Threading;
using System.IO;

namespace OpenCVWinForm
{
    public class CameraSetting
    {
        // Fields
        private double _blackLevel = 0.0;
        private int _capHeight = 0;
        private int _capSize = 0;
        private int _capWidth = 0;
        private int _capX = 0;
        private int _capY = 0;
        private int _color = 0;
        private string _deviceName = "";
        private int _exposureMode = 1;
        private int _exposureTime = 0x3e8;
        private bool _fullsize = true;
        private double _gain = 0.0;
        private int _gainMode = 0;
        private double _gamma = 1.0;
        private int _heightMax = 0;
        private int _mode = 0;
        private int _packetSize = 0x5dc;
        private int _reSize = -1;
        private string _serialNumber = "";
        private double _whiteLevel = 127.0;
        private int _whiteLevelMode = 0;
        private int _widthMax = 0;

        // Methods
        public static int ReadCameraProperty<Type>(out Type pClass, string pPath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Type));
            using (FileStream stream = new FileStream(pPath, FileMode.Open))
            {
                pClass = (Type)serializer.Deserialize(stream);
                return 0;
            }
        }

        public static int WriteCameraProterty<Type>(Type pClass, string pPath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Type));
            using (FileStream stream = new FileStream(pPath, FileMode.Create))
            {
                serializer.Serialize((Stream)stream, pClass);
            }
            return 0;
        }

        // Properties
        public double blackLevel
        {
            get
            {
                return this._blackLevel;
            }
            set
            {
                this._blackLevel = value;
            }
        }

        public int capHeight
        {
            get
            {
                return this._capHeight;
            }
            set
            {
                this._capHeight = value;
            }
        }

        public int capSize
        {
            get
            {
                return this._capSize;
            }
            set
            {
                this._capSize = value;
            }
        }

        public int capWidth
        {
            get
            {
                return this._capWidth;
            }
            set
            {
                this._capWidth = value;
            }
        }

        public int capX
        {
            get
            {
                return this._capX;
            }
            set
            {
                this._capX = value;
            }
        }

        public int capY
        {
            get
            {
                return this._capY;
            }
            set
            {
                this._capY = value;
            }
        }

        public int color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }

        public string deviceName
        {
            get
            {
                return this._deviceName;
            }
            set
            {
                this._deviceName = value;
            }
        }

        public int exposureMode
        {
            get
            {
                return this._exposureMode;
            }
            set
            {
                this._exposureMode = value;
            }
        }

        public int exposureTime
        {
            get
            {
                return this._exposureTime;
            }
            set
            {
                this._exposureTime = value;
            }
        }

        public bool fullsize
        {
            get
            {
                return this._fullsize;
            }
            set
            {
                this._fullsize = value;
            }
        }

        public double gain
        {
            get
            {
                return this._gain;
            }
            set
            {
                this._gain = value;
            }
        }

        public int gainMode
        {
            get
            {
                return this._gainMode;
            }
            set
            {
                this._gainMode = value;
            }
        }

        public double gamma
        {
            get
            {
                return this._gamma;
            }
            set
            {
                this._gamma = value;
            }
        }

        public int heightMax
        {
            get
            {
                return this._heightMax;
            }
            set
            {
                this._heightMax = value;
            }
        }

        public int mode
        {
            get
            {
                return this._mode;
            }
            set
            {
                this._mode = value;
            }
        }

        public int packetSize
        {
            get
            {
                return this._packetSize;
            }
            set
            {
                this._packetSize = value;
            }
        }

        public int reSize
        {
            get
            {
                return this._reSize;
            }
            set
            {
                this._reSize = value;
            }
        }

        public string serialNumber
        {
            get
            {
                return this._serialNumber;
            }
            set
            {
                this._serialNumber = value;
            }
        }

        public double whiteLevel
        {
            get
            {
                return this._whiteLevel;
            }
            set
            {
                this._whiteLevel = value;
            }
        }

        public int whiteLevelMode
        {
            get
            {
                return this._whiteLevelMode;
            }
            set
            {
                this._whiteLevelMode = value;
            }
        }

        public int widthMax
        {
            get
            {
                return this._widthMax;
            }
            set
            {
                this._widthMax = value;
            }
        }
    }

 

}
