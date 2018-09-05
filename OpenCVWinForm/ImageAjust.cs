using System.Xml.Serialization;
using System.IO;
using System.Xml.Resolvers;
using System.Linq;
using System.Xml.Xsl;
using System.Text;
public class ImageAdjust
{
    // Fields
    private bool _autoCsvSave = false;
    private bool _autoPrint = false;
    private bool _autoSave = false;
    private bool _bcdEnabled = false;
    private bool _bcdLock = false;
    private bool _bcdTrigger = false;
    private string _csvSavePath = "";
    private bool _imageBilateralEnabled = false;
    private int _imageBilateralParam1 = 0;
    private int _imageBilateralParam2 = 0;
    private int _imageBilateralParam3 = 0;
    private float _imageContrastCoef = 0f;
    private bool _imageContrastEnabled = false;
    private int _imageLocationOffsetX = 0;
    private int _imageLocationOffsetY = 0;
    private double _imageOffsetAngle = 0.0;
    private int _imageOffsetMode = 0;
    private double _imageOffsetScale = 1.0;
    private int _imageOffsetScore = 0;
    private string _imageSavePath = "";
    private int _imageSeachOffsetX = 0;
    private int _imageSeachOffsetY = 0;
    private bool _imageSmoothEnabled = false;
    private int _imageSmoothParam1 = 0;
    private int _imageSmoothParam2 = 0;
    private int _imageSmoothParam3 = 0;
    private int _imageSmoothParam4 = 0;
    private int _imageSmoothType = 0;
    private int _imageTeachOffsetX = 0;
    private int _imageTeachOffsetY = 0;
    private bool _imageUnsharpEnabled = false;
    private float _imageUnsharpMask = 0f;
    private string _language = "English";
    private string _logSavePath = "";
    private int _maxCsvCnt = 0;
    private int _maxCsvFile = 0;
    private int _maxLatestImgSave = 0;
    private int _maxLogFile = 7;
    private int _maxNgImgSave = 0;
    private int _maxRefImgSave = 0;
    private string _modelSavePath = "";
    private string _monFileExtension = "";
    private string _monFolderPath = "";
    private bool _printErrOnry = false;
    private bool _soundNg = true;
    private bool _soundPass = true;
    private int _soundType = 0;
    private int _version = 0;

    // Methods
    public static int ReadXML<Type>(out Type pClass, string pPath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Type));
        using (FileStream stream = new FileStream(pPath, FileMode.Open))
        {
            pClass = (Type) serializer.Deserialize(stream);

        }
        return 0;
    }

    public static int WriteXML<Type>(Type pClass, string pPath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Type));
        using (FileStream stream = new FileStream(pPath, FileMode.Create))
        {
            serializer.Serialize((Stream) stream, pClass);
        }
        return 0;
    }

    // Properties
    public bool autoCsvSave
    {
        get
        {
            return this._autoCsvSave;
        }
        set
        {
            this._autoCsvSave = value;
        }
    }

    public bool autoPrint
    {
        get
        {
            return this._autoPrint;
        }
        set
        {
            this._autoPrint = value;
        }
    }

    public bool autoSave
    {
        get
        {
            return this._autoSave;
        }
        set
        {
            this._autoSave = value;
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

    public bool bcdLock
    {
        get
        {
            return this._bcdLock;
        }
        set
        {
            this._bcdLock = value;
        }
    }

    public bool bcdTrigger
    {
        get
        {
            return this._bcdTrigger;
        }
        set
        {
            this._bcdTrigger = value;
        }
    }

    public string csvSavePath
    {
        get
        {
            return this._csvSavePath;
        }
        set
        {
            this._csvSavePath = value;
        }
    }

    public bool imageBilateralEnabled
    {
        get
        {
            return this._imageBilateralEnabled;
        }
        set
        {
            this._imageBilateralEnabled = value;
        }
    }

    public int imageBilateralParam1
    {
        get
        {
            return this._imageBilateralParam1;
        }
        set
        {
            this._imageBilateralParam1 = value;
        }
    }

    public int imageBilateralParam2
    {
        get
        {
            return this._imageBilateralParam2;
        }
        set
        {
            this._imageBilateralParam2 = value;
        }
    }

    public int imageBilateralParam3
    {
        get
        {
            return this._imageBilateralParam3;
        }
        set
        {
            this._imageBilateralParam3 = value;
        }
    }

    public float imageContrastCoef
    {
        get
        {
            return this._imageContrastCoef;
        }
        set
        {
            this._imageContrastCoef = value;
        }
    }

    public bool imageContrastEnabled
    {
        get
        {
            return this._imageContrastEnabled;
        }
        set
        {
            this._imageContrastEnabled = value;
        }
    }

    public int imageLocationOffsetX
    {
        get
        {
            return this._imageLocationOffsetX;
        }
        set
        {
            this._imageLocationOffsetX = value;
        }
    }

    public int imageLocationOffsetY
    {
        get
        {
            return this._imageLocationOffsetY;
        }
        set
        {
            this._imageLocationOffsetY = value;
        }
    }

    public double imageOffsetAngle
    {
        get
        {
            return this._imageOffsetAngle;
        }
        set
        {
            this._imageOffsetAngle = value;
        }
    }

    public int imageOffsetMode
    {
        get
        {
            return this._imageOffsetMode;
        }
        set
        {
            this._imageOffsetMode = value;
        }
    }

    public double imageOffsetScale
    {
        get
        {
            return this._imageOffsetScale;
        }
        set
        {
            this._imageOffsetScale = value;
        }
    }

    public int imageOffsetScore
    {
        get
        {
            return this._imageOffsetScore;
        }
        set
        {
            this._imageOffsetScore = value;
        }
    }

    public string imageSavePath
    {
        get
        {
            return this._imageSavePath;
        }
        set
        {
            this._imageSavePath = value;
        }
    }

    public int imageSeachOffsetX
    {
        get
        {
            return this._imageSeachOffsetX;
        }
        set
        {
            this._imageSeachOffsetX = value;
        }
    }

    public int imageSeachOffsetY
    {
        get
        {
            return this._imageSeachOffsetY;
        }
        set
        {
            this._imageSeachOffsetY = value;
        }
    }

    public bool imageSmoothEnabled
    {
        get
        {
            return this._imageSmoothEnabled;
        }
        set
        {
            this._imageSmoothEnabled = value;
        }
    }

    public int imageSmoothParam1
    {
        get
        {
            return this._imageSmoothParam1;
        }
        set
        {
            this._imageSmoothParam1 = value;
        }
    }

    public int imageSmoothParam2
    {
        get
        {
            return this._imageSmoothParam2;
        }
        set
        {
            this._imageSmoothParam2 = value;
        }
    }

    public int imageSmoothParam3
    {
        get
        {
            return this._imageSmoothParam3;
        }
        set
        {
            this._imageSmoothParam3 = value;
        }
    }

    public int imageSmoothParam4
    {
        get
        {
            return this._imageSmoothParam4;
        }
        set
        {
            this._imageSmoothParam4 = value;
        }
    }

    public int imageSmoothType
    {
        get
        {
            return this._imageSmoothType;
        }
        set
        {
            this._imageSmoothType = value;
        }
    }

    public int imageTeachOffsetX
    {
        get
        {
            return this._imageTeachOffsetX;
        }
        set
        {
            this._imageTeachOffsetX = value;
        }
    }

    public int imageTeachOffsetY
    {
        get
        {
            return this._imageTeachOffsetY;
        }
        set
        {
            this._imageTeachOffsetY = value;
        }
    }

    public bool imageUnsharpEnabled
    {
        get
        {
            return this._imageUnsharpEnabled;
        }
        set
        {
            this._imageUnsharpEnabled = value;
        }
    }

    public float imageUnsharpMask
    {
        get
        {
            return this._imageUnsharpMask;
        }
        set
        {
            this._imageUnsharpMask = value;
        }
    }

    public string language
    {
        get
        {
            return this._language;
        }
        set
        {
            this._language = value;
        }
    }

    public string logSavePath
    {
        get
        {
            return this._logSavePath;
        }
        set
        {
            this._logSavePath = value;
        }
    }

    public int maxCsvCnt
    {
        get
        {
            return this._maxCsvCnt;
        }
        set
        {
            this._maxCsvCnt = value;
        }
    }

    public int maxCsvFile
    {
        get
        {
            return this._maxCsvFile;
        }
        set
        {
            this._maxCsvFile = value;
        }
    }

    public int maxLatestImgSave
    {
        get
        {
            return this._maxLatestImgSave;
        }
        set
        {
            this._maxLatestImgSave = value;
        }
    }

    public int maxLogFile
    {
        get
        {
            return this._maxLogFile;
        }
        set
        {
            this._maxLogFile = value;
        }
    }

    public int maxNgImgSave
    {
        get
        {
            return this._maxNgImgSave;
        }
        set
        {
            this._maxNgImgSave = value;
        }
    }

    public int maxRefImgSave
    {
        get
        {
            return this._maxRefImgSave;
        }
        set
        {
            this._maxRefImgSave = value;
        }
    }

    public string modelSavePath
    {
        get
        {
            return this._modelSavePath;
        }
        set
        {
            this._modelSavePath = value;
        }
    }

    public string monFileExtension
    {
        get
        {
            return this._monFileExtension;
        }
        set
        {
            this._monFileExtension = value;
        }
    }

    public string monFolderPath
    {
        get
        {
            return this._monFolderPath;
        }
        set
        {
            this._monFolderPath = value;
        }
    }

    public bool printErrOnry
    {
        get
        {
            return this._printErrOnry;
        }
        set
        {
            this._printErrOnry = value;
        }
    }

    public bool soundNg
    {
        get
        {
            return this._soundNg;
        }
        set
        {
            this._soundNg = value;
        }
    }

    public bool soundPass
    {
        get
        {
            return this._soundPass;
        }
        set
        {
            this._soundPass = value;
        }
    }

    public int soundType
    {
        get
        {
            return this._soundType;
        }
        set
        {
            this._soundType = value;
        }
    }

    public int version
    {
        get
        {
            return this._version;
        }
        set
        {
            this._version = value;
        }
    }
}

 
