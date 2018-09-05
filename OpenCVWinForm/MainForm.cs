using System;
using System.IO;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
//using System.Xml;
using System.Xml.Serialization;
using System.Threading;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Blob;
using OpenCvSharp.CPlusPlus;
//using OpenCvSharp.Utilities;
using OpenCvSharp.Extensions;
using System.Runtime;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
//using PylonC.NET;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using DirectShowLib;
using Microsoft.Win32;
using System.Management;
using System.Security.Cryptography;
namespace OpenCVWinForm
{

    public partial class MainForm : Form
    {

        public string keyData = Registry.GetValue("HKEY_CURRENT_USER\\Console", "Dino", -1).ToString();
        public string getId = "";
        public string ID = "";
        public string indata = "";
        public bool comok = false;
        public int stepcheck = 0;
        public int stepagain = 0;
        public CvCapture cam = null;
        bool camok = false;
        private Thread _cameraThread;
        IplImage img = null;
        public int Timercam = 0;
        //private PYLON_DEVICE_HANDLE hPylonDeviceHandle;
        //private PYLON_FORMAT_CONVERTER_HANDLE hConverter;
        //private PYLON_STREAMGRABBER_HANDLE hGrabber;
        //private PYLON_WAITOBJECT_HANDLE hWait;
        //private PYLON_STREAMBUFFER_HANDLE hStream;
        // private MessageBoard MyMessageBoard;


        public const int AAC1KRKY2DCNT = 30;
        public const int AAC1KRKY2HCNT = 0x5a0;
        private const int AAC1KRKY2UDKM = 0x11e631e2;
        private const int AAC1KRKY2UDKS = 0xaec1783;
        //private ToolStripMenuItem aboutAToolStripMenuItem;
        private double angleMax;
        private double angleMin;
        private int angleNum;
        private double angleStep;
        private bool areaSelect;
        private bool autoCsvSave;
        private bool autoCut;
        private int autoDevH;
        private int autoDevW;
        private bool autoPrint;
        private bool autoSave;
        private bool autoTrim;
        private BackgroundWorker[] backgroundWorker;
        private BackgroundWorker backgroundWorker1;
        private BackgroundWorker backgroundWorker2;
        private BackgroundWorker backgroundWorker3;
        private bool barcodeHeadder;
        private bool barcodeInput;
        private TextBox barCodeInputBuffer;
        private string barCodeText;
        private int baslercamCnt;
        private ToolStripMenuItem[] baslerCamPropertyToolStripMenuItem;
        private BASLER_DEVICE[] baslerDevice;
        private int baudRate;
        private bool bcdEnabled;
        private bool bcdLock;
        private bool bcdReadFlg;
        private bool bcdTrigger;
        private bool bcdwind;
        private Bitmap bitmap;
        private bool[] bkgFlg;
        private IplImage bkgImg;
        private double blackLevel;
        private bool btnInterlock;
        private string btnName_A;
        private string btnName_B;
        private string btnName_C;
        private string btnName_D;
        private string btnName_E;
        private string btnName_F;
        private string btnName_G;
        private string btnName_H;
        private string btnName_I;
        private string btnName_J;
        private string btnName_K;
        private string btnName_L;
        private string btnName_M;
        private string btnName_N;
        private string btnName_O;
        //private PylonBuffer<byte> buffer;
        // private Dictionary<PYLON_STREAMBUFFER_HANDLE, PylonBuffer<byte>> buffers;
        private int busyActiveStatus;
        private bool busyEnable;
        private int busyPortNo;

        private bool button1_status;

        private bool button14_status;

        private bool buttonteaching_status;

        private bool button17_status;

        private bool button2_status;

        private bool button21_status;

        private bool button3_status;

        private bool button4_status;

        private bool button8_status;

        private const int CAM_COM_WAIT = 10;
        private bool cameraPropertyChange;
        private string cameraPropertyPath;
        private CameraSetting cameraSetting;
        private bool capBkFlg;
        private int capHeight;
        private IplImage capImg;
        private int capSize;
        private bool capture;
        private int captureErr;
        private int capWidth;
        private int capX;
        private int capY;

        private System.Drawing.Point clickPoint;
        private string cmd;
        private int cmdByteCnt;
        private byte[] cmdData;
        private string cmdExec;
        private bool cmdRenew;
        private Stopwatch cmdwait;
        private ShapeResult[] cmpResult;
        private int color;

        private bool comboBox1_status;

        private bool[] compFlg;
        private IContainer components;
        // private ComPortConfig comPortConfig;
        private string comPortPath;
        // private ComPortSetting comPortSetting;
        private string configName;
        private string configPath;
        public static string configPathG;
        private ToolStripMenuItem connectCheckToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private CvSeq<CvPoint> contour;
        private long counter;
        private int csvFileCnt;
        private string csvPath;
        private byte cur_dioPi;
        private byte cur_dioPo;
        private double cur_exp_Time;
        private int cur_pictureBoxHeight;
        private int cur_pictureBoxWidth;
        private int cur_userLevel;
        private string curCsvPath;
        private bool curEdit;
        private string curImagePath;
        private string curModelName;
        private int curNum;
        private bool damyCapture;
        private int dataBits;
        private int dataEdge;
        private bool dataEnable;
        private string dataPath;
        private int dataPortNo;
        private int dayCount;
        public static int daysLeft;
        private System.Drawing.Point defPos;

        private string deviceClass;

        private string deviceName;
        private string[] deviceNames;
        private string[] devicePaths;

        private bool[] difbkgFlg;
        private BackgroundWorker difDispBgWorker;
        private BackgroundWorker[] diffBgWorker;
        private int diffDispBkgFlg;
        private DiffDispData diffDispData;
        private bool diffImageFlg;
        private IplImage diffImgFull;
        private string diffNG_Threshold;
        private DiffResult[] diffResult;
        private int diffThreshold;
        private DIFFIMAGE_DATA difImgData;
        private int digitalFilter;
        private ToolStripMenuItem dimensionToolStripMenuItem;
        private const byte DIO_RESET_DATA = 0;
        private string dioDeviceName;
        private bool dioEnable;
        private short dioId;
        private TextBox dioInputBuffer;
        private int dioInterval;
        private string dioModelName;
        private TextBox dioOutputBuffer;
        private byte dioPi;
        private byte dioPo;
        // private DioPortAssign dioPortAssign;
        private string dioPortPath;
        // private DioPortSetting dioPortSetting;
        private CvRect drawRect;
        private byte dRESET;
        private IplImage dstBinDifimg;
        private IplImage dstdifimg;
        private IplImage dstImg;
        private DateTime dtNow;
        private string dtOld;
        private bool dumykey;
        // private Edit_SystemSetting editModelSelect;

        private string encoding;

        private int exposureMode;
        private int exposureTime;

        private bool fileOpFlg;
        private FileSystemWatcher fileSystemWatcher1;
        private bool fileWatch;
        private CvScalar fillval;
        private ContourChain findcnt_method;
        private ContourRetrieval findcnt_mode;
        private int findcnt_offsetx;
        private int findcnt_offsety;
        private bool formResize;
        private bool fstView;
        private const string FULL = "FULL";
        private bool fullSize;
        private double gain;
        private int gainMode;
        private double gammaLevel;
        private int getCurCount;
        private int getMaxCount;
        private string getPid;
        private bool gigeCam;
        private IplImage grayImg;
        private int handle;
        private string handShake;

        private int header_size;
        private int heightMax;
        private ToolStripMenuItem helpHToolStripMenuItem;

        private int hid;
        private int hourCount;

        private const byte I_DATA0 = 4;
        private const byte I_DATA1 = 8;
        private const byte I_DATA2 = 0x10;
        private const byte I_DATA3 = 0x20;
        private const byte I_DATA4 = 0x40;
        private int i_RESET;
        private const byte I_RESET = 1;
        private int i_TRIGGER;
        private const byte I_TRIGGER = 2;
        private int iDATA;
        private int image_offsetX;
        private int image_offsetY;
        private ImageAdjust imageAdjust;
        private bool imageBilateralEnabled;
        private int imageBilateralParam1;
        private int imageBilateralParam2;
        private int imageBilateralParam3;
        private float imageContrastCoef;
        private bool imageContrastEnabled;
        private ImageList imageList1;
        private int imageLocationOffsetX;
        private int imageLocationOffsetY;
        private int imageOffsetMode;
        private string imageSavePath;
        private double imageSearchAngle;
        private int imageSearchOffsetX;
        private int imageSearchOffsetY;
        private double imageSearchScale;
        private bool imageSmoothEnabled;
        private int imageSmoothParam1;
        private int imageSmoothParam2;
        private int imageSmoothParam3;
        private int imageSmoothParam4;
        private int imageSmoothType;
        private bool imageUnsharpEnabled;
        private float imageUnsharpMask;
        private string imgAdjPath;
        private double imgSizeHeight;
        private double imgSizeWidth;
        private static Rectangle init_rect;
        public static string inPutkii;
        private bool inside;
        //private string ioAssignPath;
        //private string ipAddress;
        //private bool iRESET;
        //private bool iTRIGGER;
        private int[] judgeResult;
        private Keys keyCode_A;
        private Keys keyCode_B;
        private Keys keyCode_C;
        private Keys keyCode_D;
        private Keys keyCode_E;
        private Keys keyCode_F;
        private Keys keyCode_G;
        private Keys keyCode_H;
        private Keys keyCode_I;
        private Keys keyCode_J;
        private Keys keyCode_K;
        private Keys keyCode_L;
        private Keys keyCode_M;
        private Keys keyCode_N;
        private Keys keyCode_O;

        private const long KEYINTERVAL = 200L;
        private bool keyStart;
        private string keystring;
        private int ledLight1ActiveStatus;
        private bool ledLight1Enable;
        private int ledLight1PortNo;
        private int ledLight2ActiveStatus;
        private bool ledLight2Enable;
        private int ledLight2PortNo;
        private ToolStripMenuItem listLToolStripMenuItem;
        // private ListView listView1;
        private bool listviewErrOnly;
        private string logFilePath;
        //public static readonly ILog logger;
        private string lotLogPath;
        private CvMat map_matrix;
        private string matcNG_Threshold;
        private int max_area;
        public const int MAX_INDUSTRIAL_CAM = 2;
        private const int max_thread = 0x18;
        private const int MAXCMDLENGTH = 6;
        private int maxCsvCnt;
        private int maxCsvFile;
        private int maxHeight;
        private int maxLatestImgSave;
        private int maxLogFile;
        private int maxNgImgSave;
        private const int MAXPOINT = 0x80;
        private int maxRefImgSave;
        private const int MAXWEBCAM = 8;
        private int maxWidth;
        private bool measureFlg;
        private int measurementCount;
        private int measurementNg;
        private int measurementOk;
        private double[] measurementsDiffArea;
        private double[] measurementsMatchRate;
        private int measureNum;
        private MenuStrip menuStrip1;
        private string message;
        private int min_area;
        private int minCount;
        private int minHeight;
        private int minWidth;
        private bool modelDell;
        private string modelName_A;
        private string modelName_B;
        private string modelName_C;
        private string modelName_D;
        private string modelName_E;
        private string modelName_F;
        private string modelName_G;
        private string modelName_H;
        private string modelName_I;
        private string modelName_J;
        private string modelName_K;
        private string modelName_L;
        private string modelName_M;
        private string modelName_N;
        private string modelName_O;
        private string modelSavePath;
        private string modelsMark;
        private string monFileExtension;
        private string monFolderPath;
        private bool mouseLBDownFlg;
        private double mouseWheelMax;
        private double mouseWheelMin;
        private System.Drawing.Point mousPosition;
        private static Rectangle[] mr_rectList;
        private static Rectangle[] ms_rectList;
        private int muid;
        //private About MyAbout;
        private BaslerCameraProperty MyBaslerCamera_Proterty;
        //private MessageBoard MyMessageBoard;
        // private PasswordForm MyPasswordForm;
        // private ProductKeyInput MyProductKeyInput;
        private bool newArea;
        private int ngActiveStatus;
        private bool ngEnable;
        private string ngImgPath;
        private int ngPortNo;
        private bool ngview;
        private bool numberDisp;
        private int o_BUSY;
        private const byte O_BUSY = 1;
        private int o_LIGHT1;
        private const byte O_LIGHT1 = 8;
        private int o_LIGHT2;
        private const byte O_LIGHT2 = 0x10;
        private int o_NG;
        private const byte O_NG = 4;
        private int o_PASS;
        private const byte O_PASS = 2;
        private int okActiveStatus;
        private bool okEnable;
        private int okPortNo;
        private int packetSize;
        private bool paintRectangleEnabled;
        private int panel2Height;
        private int panel2Resize;
        private int panel2Width;
        private string parity;
        public static bool pasForm;
        public static string passwd;

        public const string PIDKEY = "ABCD1234EFGH5678";
        private string pixcelFormat;
        //private SoundPlayer player;
        private int portCheckCount;
        private List<string> PortList;
        private string portName;
        private string portNo;
        private int portNo_A;
        private int portNo_B;
        private int portNo_C;
        private int portNo_D;
        private int portNo_E;
        private int portNo_F;
        private int portNo_G;
        private int portNo_H;
        private int portNo_I;
        private int portNo_J;
        private int portNo_K;
        private int portNo_L;
        private int portNo_M;
        private int portNo_N;
        private int portNo_O;
        private double ppmW;
        private Preset preset;
        private string presetPath;
        private bool printErrOnry;
        private Font printFont;
        private int printingPosition;
        private string printingText;
        private Rectangle r_rect;
        private static Rectangle[] r_rectList;
        private string rcvbuf;
        private string rcvPortNo;
        private IplImage refImg;
        private string refImgPath;
        private double refMeasWidthL;
        private RefModel refModelObj;
        private RefModel[] refModelObjNum;
        private REF_TEMP_DATA refTmpID;
        private int rereaseMode;
        private bool resetEnable;
        private int resetPortNo;
        private int reSize;
        private int restEdge;
        private int retcode;
        private int retRWcode;
        private int[] retry;
        private bool reverseX;
        private bool reverseY;
        private int rgb_B;
        private int rgb_G;
        private int rgb_R;
        private string richTextBoxBuffer;
        private bool rotation;
        private bool rotation270;
        private bool rotation90;
        private CvBox2D rotationBox;
        private IplImage rszImg;
        // private ry2 ry;
        private Rectangle s_rect;
        private static Rectangle[] s_rectList;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem saveSToolStripMenuItem;
        private const int SC_MOVE = 0xf010;
        private const int SC_SIZE = 0xf000;
        private double scaleMax;
        private double scaleMin;
        private int scaleNum;
        private double scaleStep;
        private int search_offsetX;
        private int search_offsetY;
        private int search_score;
        private int searchAreaOffsetX;
        private int searchAreaOffsetY;
        private int selectCam;
        private int selectCameraNo;
        private int selectIndustrialCamNum;
        private string selectModel;
        private int selectWebCamNumber;
        private int serialControl;
        private int serialID;
        private int serialMode;
        public const string serialNo = "60890005";
        private string serialNumber;
        //private SerialPort serialPort1;
        private bool serialPortEnabled;
        private ToolStripMenuItem serialToolStripMenuItem;
        private bool setFlg;
        private float shapeMatchThreshold;
        private bool shapeMeasureFlg;
        private const int ShapeResultMax = 0x200;
        private const int ShapeResultViewMax = 30;
        private double shapesThreshold;
        private MatchShapesMethod shapesType;
        private bool shiftk;
        private System.Drawing.Point sizeArea;
        private bool sizePicArea;
        private bool sizePicPosition;
        private System.Drawing.Point sizePicStartPosition;
        private System.Drawing.Point sizePosition;
        private bool soundNg;
        private bool soundPass;
        private int soundType;
        private string srcFn;
        private IplImage srcImg;
        private int srcImgHeight;
        private string srcImgPath;
        private int srcImgWidth;
        private double srcScale;
        private DateTime startDateTime;
        private string startMark;
        private int stat;
        private string stCurrentDir = Application.StartupPath;
        private float stopBits;
        private CvMemStorage storage;
        private int suid;
        private double svArea;
        private System.Drawing.Point[] svDstPnt;
        private Stopwatch sw;
        private Stopwatch sw_delay;
        private Stopwatch sw_thTime;
        private Stopwatch sw_timecode;
        private Stopwatch swt;
        private SystemSetting systemSetting;
        private bool teachFlg;
        private TEMPLATE_DATA_BKG tempDataBKG;
        private int tempNum;
        private int testInterval;

        private CvRect[] tgtRect;
        private IBaseFilter theDevice;
        private IBaseFilter[] theDevices;
        private int thlLvl;
        private const int thlMax = 0xff;
        private Thread thread1;
        private bool[] thrExecFlg;
        private bool timeout;
        //private Timer timer1;
        //private Timer timer2;
        //private Timer timer3;
        //private Timer timer4;
        private double tmpAngle;
        private double tmpAngleRange;
        private double tmpAngleStep;
        private double tmpArea;
        private int tmpBkgwFlg;
        private CvSeq<CvPoint> tmpcontour;
        private TEMPLATE_DATA_NUM[] tmpDataNum;
        private double tmpLength;
        private bool tmpMatch;
        private TempMatchResult[] tmpMatchResult;
        private BackgroundWorker tmpMatchStartBgWorker;
        private TempMatchResult tmpResult;
        private double tmpScaleMax;
        private double tmpScaleMin;
        private double tmpScaleStep;
        private CvMemStorage tmpStorage;
        private int triggerEdge;
        private bool triggerEnable;
        private int triggerPortNo;
        //private UdpClient udpClient;
        public const string upDate = "2016.08";
        private bool usbCam;
        private CvCapture[] usbCamCaptures = new CvCapture[8];

        private int usbcamCnt;
        private IplImage usbCapImg;
        public static int userLevel;
        private ToolStripMenuItem userToolStripMenuItem;
        public const string version = "for 32bit. ver 1.2.7.011";
        public const string versionNo = "1.2.7.011";
        private ToolStripMenuItem viewVToolStripMenuItem;
        private double viewWidth;
        public const string vno = "1.2.7.011";
        private ToolStripMenuItem[] webCamPropertyToolStripMenuItem;
        private double whiteLevel;
        private int whiteLevelMode;
        private int widthMax;
        private const int WM_SYSCOMMAND = 0x112;
        public const string x86x64 = "32bit";
        private CvPoint2D64f xyChm;


        //private IplImage diffImgFull;
        //public bool sizePicPosition;
        //private bool inside;
        //private int curNum;
        //private int tempNum;
        //private Point defPos;
        //private Rectangle s_rect;
        //private Rectangle r_rect;
        //private bool teachFlg;
        //private double srcScale;
        //private CvRect drawRect;
        //private bool diffImageFlg;
        //private int srcImgWidth;
        //private int srcImgHeight;
        //private IplImage srcImg;
        //private bool autoTrim;
        //private bool curEdit;
        //private static Rectangle[] s_rectList;
        //private static Rectangle[] r_rectList;
        //private bool sizePicArea;
        //private Point clickPoint;
        //private Point sizePicStartPosition;
        //private bool areaSelect;
        //private bool mouseLBDownFlg;
        //private bool newArea;
        //private int maxWidth;
        //private int maxHeight;
        //private int minWidth;
        //private int minHeight;
        //private CvBox2D rotationBox;
        //private Point mousPosition;
        //private CvPoint2D64f xyChm;
        //private int rgb_B;
        //private int rgb_G;
        //private int rgb_R;
        //private bool rotation;
        //private static Rectangle[] ms_rectList;
        //private double tmpAngleRange;
        //private double tmpAngleStep;
        //private double tmpScaleMin;
        //private double tmpScaleMax;
        //private double tmpScaleStep;


        IplImage Frame = new IplImage();
        IplImage Targetpic = new IplImage();

        // [StructLayout(LayoutKind.Sequential)]
        private struct ShapeResult
        {
            public CvSeq<CvPoint> Contour;
            public double Score;
            public CvBox2D Box;
            public double Area;
            public double Scale;
            public double Angle;
            public ShapeResult(CvSeq<CvPoint> Contour, double Score, CvBox2D Box, double Area, double Scale, double Angle)
            {
                this.Contour = Contour;
                this.Score = Score;
                this.Box = Box;
                this.Area = Area;
                this.Scale = Scale;
                this.Angle = Angle;
            }
        }

        private struct DiffResult
        {
            public Bitmap refimg;
            public Bitmap tgtimg;
            public Bitmap refFilImg;
            public Bitmap tgtFilImg;
            public Bitmap diffImg;
            public Bitmap mskImg;
            public Bitmap difBinImg;
            public int no;
            public CvRect rect;
            public double matchRate;
            public double diffArea;
            public long whitePix;
            public double angle;
        }

        private struct REF_TEMP_DATA
        {
            public int scaleID;
            public int angleID;
        }
        private struct BASLER_DEVICE
        {
            public string deviceClass;
            public string modelName;
            public string serialNumber;
        }
        private struct DiffDispData
        {
            public IplImage img;
            public bool flg;
        }
        private struct TEMPLATE_DATA_NUM
        {
            public MainForm.TEMPLATE_DATA[,] tmpData;
            public System.Drawing.Point pt;
            public int refScaleID;
            public int refAngleID;
        }

        private struct TEMPLATE_DATA
        {
            public double scale;
            public double angle;
            public IplImage image;
        }
        private struct TempMatchResult
        {
            public double Score;
            public CvPoint Location;
            public int ScaleID;
            public int AngleID;
            public double Scale;
            public double Angle;
            public TempMatchResult(double Score, CvPoint Location, int ScaleID, int AngleID, double Scale, double Angle)
            {
                this.Score = Score;
                this.Location = Location;
                this.ScaleID = ScaleID;
                this.AngleID = AngleID;
                this.Scale = Scale;
                this.Angle = Angle;
            }
        }
        private struct TEMPLATE_DATA_BKG
        {
            public MainForm.TEMPLATE_DATA[,] tmpData;
            public MainForm.REF_TEMP_DATA refTmpID;
            public MainForm.IMAGE_POSI_SIZE tgtArea;
            public int scaleNumber;
            public int anglenumber;
            public int mode;
            public int ptMatchBinThreshold;
        }

        private struct IMAGE_POSI_SIZE
        {
            public IplImage img;
            public CvRect rct;
        }
        private struct DIFFIMAGE_DATA
        {
            public int id;
            public IplImage rimg;
            public IplImage tmpimg;
        }



        public MainForm()
        {
            InitializeComponent();
        }
        public string SHA1(string number)
        {
            ASCIIEncoding ASCIIENC = new ASCIIEncoding();
            string strreturn = null;
            //strreturn = Constants.vbNullString;
            Byte[] bytesourcetxt = ASCIIENC.GetBytes(number);

            SHA1 SHA1Hash = new SHA1CryptoServiceProvider();
            Byte[] bytehash = SHA1Hash.ComputeHash(bytesourcetxt);
            foreach (byte b in bytehash)
            {
                strreturn += b.ToString("C8");
            }
            return strreturn;
        }
        public string GetHDDSerial()
        {
            //ManagementObjectSearcher hdd = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE InterfaceType='USB'");
            ManagementObjectSearcher hdd = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            string HDD_Serial = "";
            foreach (ManagementObject HD in hdd.Get())
            {

                HDD_Serial = HD["SerialNumber"].ToString();

            }
            return HDD_Serial;
        }
        private int OpenImageFile(string path)
        {
            int num = -1;
            if ((!this.teachFlg && !this.capture) && !this.measureFlg)
            {
                try
                {
                    if (!File.Exists(path))
                    {
                        return num;
                    }
                    this.srcImg = Cv.LoadImage(path, LoadMode.AnyColor);
                    if (this.srcImg == null)
                    {
                        return num;
                    }
                    this.CurrentDataClear();
                    this.curImagePath = Path.GetDirectoryName(this.srcFn);
                    this.srcImgHeight = this.srcImg.Height;
                    this.srcImgWidth = this.srcImg.Width;
                    this.drawRect = new CvRect(0, 0, this.srcImgWidth, this.srcImgHeight);
                    this.pictureBox1.Image = this.srcImg.ToBitmap();
                    this.dstImg = Cv.CloneImage(this.srcImg);
                    this.fileOpFlg = true;
                    this.button1.Text = "CAPTURE";
                    if (this.srcImg != null)
                    {
                        this.dstImg = Cv.CloneImage(this.srcImg);
                        if (this.dstImg == null)
                        {
                            return num;
                        }
                        this.buttonteaching.Enabled = true;
                        this.button3.Enabled = true;
                    }
                    if (this.tempNum > 0)
                    {
                        this.button2.Enabled = true;
                    }
                    //this.button4.Enabled = true;
                    this.capture = false;
                    //this.label1.Text = string.Concat(new object[] { "IMAGE FILE : ", this.srcImg.Width, " x ", this.srcImg.Height });
                    num = 1;
                }
                catch
                {
                }
            }
            return num;
        }


        private void ButtonLoadReference_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = this.curImagePath,
                FileName = "image.png",
                Filter = "Image Files(*.bmp, *.png)|*.bmp;*.png",
                Title = "Open the picture"
            };
            this.Refresh();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();
                if (Cursor.Current != Cursors.WaitCursor)
                {
                    Cursor.Current = Cursors.WaitCursor;
                }
                this.ButtonInterlock(true);
                this.CurrentDataClear();
                this.srcFn = dialog.FileName;
                this.srcImg = null;
                this.srcImg = Cv.LoadImage(this.srcFn, LoadMode.AnyColor);
                if (this.srcImg == null)
                {
                    MessageBox.Show(Resources.OPTCLICK_MSG_CAN_NOT_OPEN, "AAC-1000", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    this.curImagePath = Path.GetDirectoryName(this.srcFn);
                    this.srcImgHeight = this.srcImg.Height;
                    this.srcImgWidth = this.srcImg.Width;
                    this.drawRect = new CvRect(0, 0, this.srcImgWidth, this.srcImgHeight);
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    this.pictureBox1.Image = this.srcImg.ToBitmap();
                    this.dstImg = Cv.CloneImage(this.srcImg);
                    this.fileOpFlg = true;
                    this.button1.Text = "Camera";
                    this.capture = false;
                    //this.label1.Text = string.Concat(new object[] { "Image dimension: ", this.srcImg.Width, " x ", this.srcImg.Height });
                }
                this.ButtonInterlock(false);
                if (Cursor.Current != Cursors.Default)
                {
                    Cursor.Current = Cursors.Default;
                }
            }

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton7.Checked)
            {
                this.numericUpDown21.Enabled = true;
                this.trackBar9.Enabled = true;
                if (((this.dstdifimg != null) && !this.timer1.Enabled) && this.radioButton7.Focused)
                {
                    this.stat = 0x67;
                    this.timer1.Enabled = true;
                }
                else
                {
                    this.SelectAreaTeachRealTimeView();
                }
            }
            else
            {
                this.numericUpDown21.Enabled = false;
                this.trackBar9.Enabled = false;
            }

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton6.Checked)
            {
                if (((this.dstdifimg != null) && !this.timer1.Enabled) && this.radioButton6.Focused)
                {
                    this.stat = 0x67;
                    this.timer1.Enabled = true;
                }
                else
                {
                    this.SelectAreaTeachRealTimeView();
                }
            }

        }
        private void SelectAreaTeachRealTimeView()
        {
            if ((((this.teachFlg && (int.Parse(this.label48.Text) > 1)) && (int.Parse(this.label49.Text) > 1)) && ((this.curNum == this.tempNum) || this.curEdit)) && this.button3.Enabled)
            {
                this.r_rect.X = int.Parse(this.label46.Text);
                this.r_rect.Y = int.Parse(this.label47.Text);
                this.r_rect.Width = int.Parse(this.label48.Text);
                this.r_rect.Height = int.Parse(this.label49.Text);
                using (IplImage image = new IplImage(Cv.Size(this.r_rect.Width, this.r_rect.Height), this.srcImg.Depth, this.srcImg.NChannels))
                {
                    CvRect rect = new CvRect(this.r_rect.X, this.r_rect.Y, this.r_rect.Width, this.r_rect.Height);
                    Cv.SetImageROI(this.srcImg, rect);
                    Cv.Copy(this.srcImg, image);
                    Cv.ResetImageROI(this.srcImg);
                    Cv.Rectangle(image, 0, 0, image.Width - 1, image.Height - 1, Cv.RGB(0, 0, 0), 1);
                    if (!this.radioButton5.Checked)
                    {
                        using (IplImage image2 = new IplImage(image.Size, image.Depth, 1))
                        {
                            using (IplImage image3 = new IplImage(image.Size, image.Depth, 1))
                            {
                                Cv.CvtColor(image, image2, ColorConversion.BgrToGray);
                                if (this.radioButton7.Checked)
                                {
                                    Cv.Threshold(image2, image3, (double)((int)this.numericUpDown21.Value), 255.0, ThresholdType.Binary);
                                    Cv.CvtColor(image3, image, ColorConversion.GrayToBgr);
                                }
                                else
                                {
                                    Cv.CvtColor(image2, image, ColorConversion.GrayToBgr);
                                }
                            }
                        }
                    }
                    this.pictureBox2.Image = image.ToBitmap();
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton5.Checked)
            {
                if (((this.dstdifimg != null) && !this.timer1.Enabled) && this.radioButton5.Focused)
                {
                    this.stat = 0x67;
                    this.timer1.Enabled = true;
                }
                else
                {
                    this.SelectAreaTeachRealTimeView();
                }
            }

        }
        private void Teaching()
        {
            if (this.teachFlg)
            {
                this.teachFlg = false;
                this.buttonteaching.ForeColor = Color.Black;
                if (this.gigeCam || this.usbCam || this.camok)
                {
                    this.button1.Enabled = true;
                }
                this.button3.Enabled = false;
                this.button17.Enabled = false;// NUT DEL CAC BUOC TEACH
                this.button14.Enabled = false;// NUT refresh hinh anh
                if ((this.tempNum > 0) && ((this.usbCam || this.gigeCam || this.camok) || this.fileOpFlg))
                {
                    this.button2.Enabled = true;// cho phep kiem tra
                }
                //this.button4.Enabled = true;// cho phep an clear
                this.button21.Enabled = true;// cho phep an clear all
                if (this.diffImageFlg)
                {
                    this.button8.Enabled = true;
                }
                else
                {
                    this.button8.Enabled = false;
                }
                this.comboBox1.Enabled = true;
            }
            else
            {
                this.measureFlg = false;// xoa co kiem tra 
                this.teachFlg = true;// cho phep vao che do teaching
                this.buttonteaching.ForeColor = Color.Red;
                if (this.autoTrim)
                {
                    this.button3.Enabled = true;
                }
                else
                {
                    this.button3.Enabled = false;
                }
                this.button1.Enabled = false;
                if (this.tempNum > 0)
                {
                    this.button3.Enabled = true;
                    this.button14.Enabled = true;
                }
                if (this.tempNum > 0)
                {
                    this.button17.Enabled = true;
                }
                this.button20.Enabled = false;
                //this.button37.Enabled = false;// NUT AN ALL UPDATE
                this.button2.Enabled = false;
                //this.button4.Enabled = false;
                this.button21.Enabled = false;
                this.button8.Enabled = false;
                this.comboBox1.Enabled = false;
            }
            this.pictureBox1.Refresh();

        }

        private object SaveRefModelNum(string name, string pathsave)
        {
            RefModel[] modelArray = new RefModel[0x80];
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathsave, false))
            {
                string a = pathsave.Substring(0, pathsave.LastIndexOf(".csv"));
                if (!Directory.Exists(a))
                {
                    Directory.CreateDirectory(a);
                }


                string info = string.Concat("moodelName", ",", "diffThreshold", ",", "whitePixelThreshold", ", ", "matchRateThreshold", ",",
            "binaryAllThreshold", ",", "binaryRedThreshold", ",", "binaryGreenThreshold", ",", "binaryBlueThreshold", ",",
            "blobMinAreaThreshold", ",", "blobMaxAreaThreshold", ",", "erodNumThreshold", ",", "dilaNumThreshold", ",",
            "number", ",", "positionX", ",", "positionY", ",", "searchPositionRangeX", ",", "searchPositionRangeY", ",",
            "searchAngleRange", ",", "searchAngleStep", ",", "searchScaleMin", ",", "searchScaleMax", ",", "searchScaleStep", ",",
            "mode", ",", "maxPoint", ",", "r_rect.X", ",", "r_rect.Y", ",", "r_rect.Width", ",", "r_rect.Height", ",",
            "thresholdColorMode", ",", "thresholdManualMode", ",", "averageCount", ",", "smoothParam", ",", "smoothParam3", ",", "smoothParam4", ",",
            "unsharpMask", ",", "contrastCoef", ",", "inspectEnabled", ",", "checkPointName", ",", "reverseX", ",", "reverseY", ",",
            "imageWidth", ",", "imageHeight", ",", "svDstPnt[0].X", ",", "svDstPnt[0].Y", ",", "svDstPnt[1].X", ",", "svDstPnt[1].Y", ",",
            "svDstPnt[2].X", ",", "svDstPnt[2].Y", ",", "svDstPnt[3].X", ",", "svDstPnt[3].Y", ",", "svArea", ",",
            "ptMatchBinaryThreshold", ",", "rotation90", ",", "rotation270", ",", "matcNG_Threshold", ",", "diffNG_Threshold");

                file.WriteLine(info);
                for (int i = 0; i < this.tempNum; i++)
                {
                    this.refModelObjNum[i].maxPoint = this.tempNum;
                    this.refModelObjNum[i].reverseX = this.reverseX;
                    this.refModelObjNum[i].reverseY = this.reverseY;
                    this.refModelObjNum[i].rotation90 = this.rotation90;
                    this.refModelObjNum[i].rotation270 = this.rotation270;
                    refModelObjNum[i].moodelName = name;
                    refModelObjNum[i].modelImg.Save(a + "\\" + i.ToString() + ".bmp");// luu anh 
                    info = string.Concat(
                        refModelObjNum[i].moodelName, ",",
                        refModelObjNum[i].diffThreshold, ",",
                        refModelObjNum[i].whitePixelThreshold, ",",
                        refModelObjNum[i].matchRateThreshold, ",",
                        refModelObjNum[i].binaryAllThreshold, ",",
                        refModelObjNum[i].binaryRedThreshold, ",",
                        refModelObjNum[i].binaryGreenThreshold, ",",
                        refModelObjNum[i].binaryBlueThreshold, ",",
                        refModelObjNum[i].blobMinAreaThreshold, ",",
                        refModelObjNum[i].blobMaxAreaThreshold, ",",
                        refModelObjNum[i].erodNumThreshold, ",",
                        refModelObjNum[i].dilaNumThreshold, ",",
                        refModelObjNum[i].number, ",",
                        refModelObjNum[i].positionX, ",",
                        refModelObjNum[i].positionY, ",",
                        refModelObjNum[i].searchPositionRangeX, ",",
                        refModelObjNum[i].searchPositionRangeY, ",",
                        refModelObjNum[i].searchAngleRange, ",",
                        refModelObjNum[i].searchAngleStep, ",",
                        refModelObjNum[i].searchScaleMin, ",",
                        refModelObjNum[i].searchScaleMax, ",",
                        refModelObjNum[i].searchScaleStep, ",",
                        refModelObjNum[i].mode, ",",
                        refModelObjNum[i].maxPoint, ",",
                        // Recgtangle
                        refModelObjNum[i].r_rect.X, ",",
                        refModelObjNum[i].r_rect.Y, ",",
                        refModelObjNum[i].r_rect.Width, ",",
                        refModelObjNum[i].r_rect.Height, ",",
                        //
                        refModelObjNum[i].thresholdColorMode, ",",
                        refModelObjNum[i].thresholdManualMode, ",",
                        refModelObjNum[i].averageCount, ",",
                        refModelObjNum[i].smoothParam, ",",
                        refModelObjNum[i].smoothParam3, ",",
                        refModelObjNum[i].smoothParam4, ",",
                        refModelObjNum[i].unsharpMask, ",",
                        refModelObjNum[i].contrastCoef, ",",
                        refModelObjNum[i].inspectEnabled, ",",
                        refModelObjNum[i].checkPointName, ",",
                        refModelObjNum[i].reverseX, ",",
                        refModelObjNum[i].reverseY, ",",
                        refModelObjNum[i].imageWidth, ",",
                        refModelObjNum[i].imageHeight, ",",


                        // Point[] svDstPnt,
                        refModelObjNum[i].svDstPnt[0].X, ",",
                        refModelObjNum[i].svDstPnt[0].Y, ",",
                        refModelObjNum[i].svDstPnt[1].X, ",",
                        refModelObjNum[i].svDstPnt[1].Y, ",",
                        refModelObjNum[i].svDstPnt[2].X, ",",
                        refModelObjNum[i].svDstPnt[2].Y, ",",
                        refModelObjNum[i].svDstPnt[3].X, ",",
                        refModelObjNum[i].svDstPnt[3].Y, ",",

                        //-=======================================
                        refModelObjNum[i].svArea, ",",
                        refModelObjNum[i].ptMatchBinaryThreshold, ",",
                        refModelObjNum[i].rotation90, ",",
                        refModelObjNum[i].rotation270, ",",
                        refModelObjNum[i].matcNG_Threshold, ",",
                        refModelObjNum[i].diffNG_Threshold
                        );
                    file.WriteLine(info);

                }
            }
            return modelArray;

        }
        //public static void SaveToBinaryFile(object obj, string path)
        //{
        //    //FileStream serializationStream = new FileStream(path, FileMode.Create, FileAccess.Write);
        //    //new BinaryFormatter().Serialize(serializationStream, obj);
        //    //serializationStream.Close();
        //}

        private static void OldFileSearchDel(string dir, string file, int cnt)
        {
            FileInfo[] files = new DirectoryInfo(dir).GetFiles(file);
            if (files.Length > cnt)
            {
                Array.Sort<FileInfo>(files, (x, y) => x.LastWriteTime.CompareTo(y.LastWriteTime));
                for (int i = 0; i < (files.Length - cnt); i++)
                {
                    files[i].Delete();
                }
            }
        }

        private static void OldDirectorySearchDel(string dir, int cnt)
        {
            DirectoryInfo[] directories = new DirectoryInfo(dir).GetDirectories();
            if (directories.Length > cnt)
            {
                Array.Sort<DirectoryInfo>(directories, (x, y) => x.LastWriteTime.CompareTo(y.LastWriteTime));
                for (int i = 0; i < (directories.Length - cnt); i++)
                {
                    directories[i].Delete(true);
                }
            }
        }


        private void ModelDataSave(string path)
        {
            if (Cursor.Current != Cursors.WaitCursor)
            {
                Cursor.Current = Cursors.WaitCursor;
            }
            this.ButtonInterlock(true);
            if (this.tempNum > 0)
            {
                string str = path;
                if (!str.EndsWith(@"\"))
                {
                    str = str + @"\";
                }
                if (!Directory.Exists(str))
                {
                    Directory.CreateDirectory(str);
                }
                SaveFileDialog dialog = new SaveFileDialog
                {
                    InitialDirectory = str,
                    FileName = this.curModelName + ".csv",
                    Filter = "xml File(.csv)|*.csv|All files(*.*)|*.*",
                    Title = "Save Reference Model As..."
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(dialog.FileName);
                    string strB = Path.GetDirectoryName(dialog.FileName) + @"\";
                    if (string.Compare(str, strB, true) != 0)
                    {
                        MessageBox.Show("PLEASE_SAVE_TO", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    this.SaveRefModelNum(fileNameWithoutExtension, dialog.FileName);
                    //SaveToBinaryFile(this.SaveRefModelNum(fileNameWithoutExtension), dialog.FileName);

                    if (!this.comboBox1.Items.Contains(fileNameWithoutExtension))
                    {
                        this.comboBox1.Items.Add(fileNameWithoutExtension);
                    }
                    this.setFlg = true;
                    this.comboBox1.Text = fileNameWithoutExtension;
                    if (this.autoSave && this.teachFlg)
                    {
                        string str4 = DateTime.Now.ToString("yyyyMMddHHmmss");
                        string str5 = str4 + "_" + fileNameWithoutExtension + "_Ref.png";
                        if (((this.maxRefImgSave > 0) && (this.srcImg != null)) && ((this.srcImg.Width > 1) && (this.srcImg.Height > 1)))
                        {
                            Cv.SaveImage(this.refImgPath + str5, this.srcImg, new ImageEncodingParam[0]);
                            OldFileSearchDel(this.refImgPath, "*_Ref.png", this.maxRefImgSave);
                            str = this.refImgPath + @"\" + str4 + "_" + fileNameWithoutExtension + @"\";
                            Directory.CreateDirectory(str);
                            for (int i = 0; i < this.tempNum; i++)
                            {
                                Cv.SaveImage(str + string.Concat(new object[] { i + 1, "_", this.refModelObjNum[i].checkPointName, ".png" }), OpenCvSharp.Extensions.BitmapConverter.ToIplImage(this.refModelObjNum[i].modelImg), new ImageEncodingParam[0]);
                            }
                            OldDirectorySearchDel(this.refImgPath, this.maxRefImgSave);
                        }
                    }
                    this.setFlg = false;
                }
            }
            else
            {
                MessageBox.Show("Can not save model", "Vision Inspection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.ButtonInterlock(false);
            if (Cursor.Current != Cursors.Default)
            {
                Cursor.Current = Cursors.Default;
            }
            this.button7.ForeColor = Color.Black;
        }

        private void buttonteaching_Click(object sender, EventArgs e)
        {
            if ((this.button7.ForeColor != Color.Black) && this.teachFlg)
            {
                if (MessageBox.Show("Save model", "Vision Inspection", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    this.ModelDataSave(this.modelSavePath);
                }
                else
                {
                    this.button7.ForeColor = Color.Black;
                }
            }
            if ((this.measureNum > 0) && !this.teachFlg)
            {
                if (MessageBox.Show("Cancel Inspection", "Vision Inspection", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.Cancel)
                {
                    return;
                }
                if (this.pictureBox1.Image != null)
                {
                    this.srcScale = 1.0;
                    this.s_rect = new Rectangle(0, 0, 0, 0);
                    this.drawRect = new CvRect(0, 0, this.srcImgWidth, this.srcImgHeight);
                    this.diffImageFlg = !this.diffImageFlg;
                    this.button8_Click(null, null);
                    this.ReSiazeRectangle();
                }
                this.measureNum = 0;
                this.dstdifimg = null;
                this.dstBinDifimg = null;
                this.diffImgFull = null;
                this.pictureBox1.Image = this.srcImg.ToBitmap();
            }
            this.Teaching();


        }
        private Rectangle RectResizePictureBox(Rectangle rect)
        {
            double num = 0.0;
            Rectangle rectangle = new Rectangle(0, 0, 0, 0);
            rect.X = (int)Math.Round((double)(((double)(rect.X - this.minWidth)) / this.imgSizeWidth));
            rect.Y = (int)Math.Round((double)(((double)(rect.Y - this.minHeight)) / this.imgSizeWidth));
            rect.Width = (int)Math.Round((double)(((double)rect.Width) / this.imgSizeWidth));
            rect.Height = (int)Math.Round((double)(((double)rect.Height) / this.imgSizeWidth));
            new System.Drawing.Point(rect.X, rect.Y);
            if (this.pictureBox1.Image != null)
            {
                double num2 = ((double)this.pictureBox1.Height) / ((double)this.pictureBox1.Width);
                double num3 = ((double)this.pictureBox1.Image.Height) / ((double)this.pictureBox1.Image.Width);
                if (num2 > num3)
                {
                    num = ((double)this.pictureBox1.Width) / ((double)this.pictureBox1.Image.Width);
                }
                else
                {
                    num = ((double)this.pictureBox1.Height) / ((double)this.pictureBox1.Image.Height);
                }
                if (this.pictureBox1.Width > (this.pictureBox1.Image.Width * num))
                {
                    this.minWidth = (int)((this.pictureBox1.Width - (this.pictureBox1.Image.Width * num)) / 2.0);
                    this.maxWidth = this.pictureBox1.Width - ((int)((this.pictureBox1.Width - (this.pictureBox1.Image.Width * num)) / 2.0));
                }
                if (this.pictureBox1.Height > (this.pictureBox1.Image.Height * num))
                {
                    this.minHeight = (int)((this.pictureBox1.Height - (this.pictureBox1.Image.Height * num)) / 2.0);
                    this.maxHeight = this.pictureBox1.Height - ((int)((this.pictureBox1.Height - (this.pictureBox1.Image.Height * num)) / 2.0));
                }
                rectangle.X = (int)Math.Round((double)(((float)(rect.X * num)) + this.minWidth));
                rectangle.Y = (int)Math.Round((double)(((float)(rect.Y * num)) + this.minHeight));
                rectangle.Width = (int)Math.Round((double)(rect.Width * num));
                rectangle.Height = (int)Math.Round((double)(rect.Height * num));
                this.imgSizeWidth = num;
                this.imgSizeHeight = num;
            }
            return rectangle;
        }





        private System.Drawing.Point ResizeImgPos(CvSize imgSize, CvSize wdSize, System.Drawing.Point pos)
        {
            System.Drawing.Point point = new System.Drawing.Point(0, 0);
            point = pos;
            if (this.pictureBox1.Image != null)
            {
                double num3;
                double num = ((double)wdSize.Height) / ((double)wdSize.Width);
                double num2 = ((double)imgSize.Height) / ((double)imgSize.Width);
                if (num > num2)
                {
                    num3 = ((double)wdSize.Width) / ((double)imgSize.Width);
                }
                else
                {
                    num3 = ((double)wdSize.Height) / ((double)imgSize.Height);
                }
                if (wdSize.Width > ((int)Math.Round((double)(imgSize.Width * num3))))
                {
                    point.X -= (int)((wdSize.Width - (imgSize.Width * num3)) / 2.0);
                }
                if (wdSize.Height > ((int)Math.Round((double)(imgSize.Height * num3))))
                {
                    point.Y -= (int)((wdSize.Height - (imgSize.Height * num3)) / 2.0);
                }
                if (point.X < 0)
                {
                    point.X = 0;
                }
                if (point.X > (wdSize.Width - ((wdSize.Width - (imgSize.Width * num3)) / 2.0)))
                {
                    point.X = wdSize.Width - ((int)((wdSize.Width - (this.pictureBox1.Image.Width * num3)) / 2.0));
                }
                if (point.Y < 0)
                {
                    point.Y = 0;
                }
                if (point.Y > (wdSize.Height - ((wdSize.Height - (imgSize.Height * num3)) / 2.0)))
                {
                    point.Y = wdSize.Height - ((int)((wdSize.Height - (imgSize.Height * num3)) / 2.0));
                }
                pos = point;
                point.X = (int)Math.Round((double)(((double)pos.X) / num3));
                point.Y = (int)Math.Round((double)(((double)pos.Y) / num3));
            }
            return point;
        }
        private Rectangle CmvViewRectangle(CvSize wdSize, CvSize imgSize, Rectangle srect)
        {
            System.Drawing.Point point = new System.Drawing.Point(srect.X, srect.Y);
            Rectangle rectangle = new Rectangle(0, 0, 0, 0);
            if (this.pictureBox1.Image != null)
            {
                double num3;
                double num = ((double)wdSize.Height) / ((double)wdSize.Width);
                double num2 = ((double)imgSize.Height) / ((double)imgSize.Width);
                if (num > num2)
                {
                    num3 = ((double)wdSize.Width) / ((double)imgSize.Width);
                }
                else
                {
                    num3 = ((double)wdSize.Height) / ((double)imgSize.Height);
                }
                point.X = (int)(point.X * num3);
                point.Y = (int)(point.Y * num3);
                if (wdSize.Width > ((int)Math.Round((double)(imgSize.Width * num3))))
                {
                    point.X += (int)((wdSize.Width - (imgSize.Width * num3)) / 2.0);
                }
                if (wdSize.Height > ((int)Math.Round((double)(imgSize.Height * num3))))
                {
                    point.Y += (int)((wdSize.Height - (imgSize.Height * num3)) / 2.0);
                }
                if (point.X < 0)
                {
                    point.X = 0;
                }
                if (point.X > (wdSize.Width - ((wdSize.Width - (imgSize.Width * num3)) / 2.0)))
                {
                    point.X = wdSize.Width - ((int)((wdSize.Width - (this.pictureBox1.Image.Width * num3)) / 2.0));
                }
                if (point.Y < 0)
                {
                    point.Y = 0;
                }
                if (point.Y > (wdSize.Height - ((wdSize.Height - (imgSize.Height * num3)) / 2.0)))
                {
                    point.Y = wdSize.Height - ((int)((wdSize.Height - (imgSize.Height * num3)) / 2.0));
                }
                rectangle.X = (int)Math.Round((double)point.X);
                rectangle.Y = (int)Math.Round((double)point.Y);
                rectangle.Width = (int)Math.Round((double)(srect.Width * num3));
                rectangle.Height = (int)Math.Round((double)(srect.Height * num3));
            }
            return rectangle;
        }

        private void ReSiazeRectangle()
        {
            Rectangle srect = new Rectangle();
            for (int i = 0; i < this.tempNum; i++)
            {
                srect = r_rectList[i];
                srect.X -= this.drawRect.X;
                srect.Y -= this.drawRect.Y;
                s_rectList[i] = this.CmvViewRectangle(Cv.Size(this.pictureBox1.Width, this.pictureBox1.Height), Cv.Size(this.drawRect.Width, this.drawRect.Height), srect);
                if ((r_rectList[i].X + r_rectList[i].Width) <= this.drawRect.X)
                {
                    s_rectList[i].X = -1;
                }
                if ((r_rectList[i].Y + r_rectList[i].Height) <= this.drawRect.Y)
                {
                    s_rectList[i].Y = -1;
                }
                if (r_rectList[i].X >= (this.drawRect.Width + this.drawRect.X))
                {
                    s_rectList[i].X = -1;
                }
                if (r_rectList[i].Y >= (this.drawRect.Height + this.drawRect.Y))
                {
                    s_rectList[i].Y = -1;
                }
            }
            for (int j = 0; j < this.measureNum; j++)
            {
                srect = mr_rectList[j];
                srect.X -= this.drawRect.X;
                srect.Y -= this.drawRect.Y;
                ms_rectList[j] = this.CmvViewRectangle(Cv.Size(this.pictureBox1.Width, this.pictureBox1.Height), Cv.Size(this.drawRect.Width, this.drawRect.Height), srect);
                if ((mr_rectList[j].X + mr_rectList[j].Width) <= this.drawRect.X)
                {
                    ms_rectList[j].X = -1;
                }
                if ((mr_rectList[j].Y + mr_rectList[j].Height) <= this.drawRect.Y)
                {
                    ms_rectList[j].Y = -1;
                }
                if (mr_rectList[j].X >= (this.drawRect.Width + this.drawRect.X))
                {
                    ms_rectList[j].X = -1;
                }
                if (mr_rectList[j].Y >= (this.drawRect.Height + this.drawRect.Y))
                {
                    ms_rectList[j].Y = -1;
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBox1.Focus();
            System.Drawing.Point location = e.Location;
            if (e.Button != MouseButtons.Left)
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.sizePicPosition = true;
                    this.inside = false;
                    if ((((this.curNum == this.tempNum) && (this.tempNum < 0x80)) && (!this.curEdit && s_rectList[this.tempNum].Contains(location))) || (((this.curNum <= this.tempNum) && (this.curNum > 0)) && (this.curEdit && s_rectList[this.curNum - 1].Contains(location))))
                    {
                        this.inside = true;
                    }
                    if (this.inside && this.teachFlg)
                    {
                        this.defPos.X = this.s_rect.X - location.X;
                        this.defPos.Y = this.s_rect.Y - location.Y;
                    }
                    else
                    {
                        System.Drawing.Point point2 = this.ResizeImgPos(Cv.Size(this.drawRect.Width, this.drawRect.Height), Cv.Size(this.pictureBox1.Width, this.pictureBox1.Height), location);
                        this.defPos.X = point2.X;
                        this.defPos.Y = point2.Y;
                    }
                }
            }
            else
            {
                if (!this.curEdit)
                {
                    this.button3.Enabled = false;
                }
                this.sizePicArea = true;
                this.sizePicStartPosition = this.clickPoint = location;
                if (this.tempNum < 0x80)
                {
                    this.s_rect = new Rectangle(0, 0, 0, 0);
                    this.r_rect = new Rectangle(0, 0, 0, 0);
                    s_rectList[this.tempNum] = s_rect;
                    r_rectList[this.tempNum] = new Rectangle(0, 0, 0, 0);
                }
                if ((this.curNum > 0) && !this.curEdit)
                {
                    this.areaSelect = false;
                    for (int i = 0; i < this.tempNum; i++)
                    {
                        if (((this.teachFlg && s_rectList[i].Contains(this.clickPoint)) && ((s_rectList[i].X >= 0) && (s_rectList[i].Y >= 0))) || ((!this.teachFlg && ms_rectList[i].Contains(this.clickPoint)) && ((ms_rectList[i].X >= 0) && (ms_rectList[i].Y >= 0))))
                        {
                            this.areaSelect = true;
                            if (this.curNum != (i + 1))
                            {
                                this.curNum = i + 1;
                                this.mouseLBDownFlg = true;
                                //this.DispSelectItemProperty(this.curNum);
                                break;
                            }
                        }
                        if (((i == (this.tempNum - 1)) && this.teachFlg) && !this.curEdit)
                        {
                            this.newArea = true;
                        }
                    }
                }
                else
                {
                    this.newArea = true;
                }
                ((Control)sender).Refresh();
            }
            this.ReSiazeRectangle();


        }
        private unsafe CvPoint2D64f ChromaticityAvg(IplImage img, System.Drawing.Point xy, int area)
        {
            CvPoint2D64f pointdf;
            int num = 0;
            int num2 = 0;
            CvPoint3D64f pointdf2 = new CvPoint3D64f(0.0, 0.0, 0.0);
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            int num8 = 0;
            double num9 = 0.0;
            double num10 = 0.0;
            double num11 = 0.0;
            try
            {
                if (area == 0)
                {
                    area = 1;
                }
                num = area;
                num2 = area;
                xy.X -= area / 2;
                xy.Y -= area / 2;
                if (xy.X < 0)
                {
                    num = area + xy.X;
                    xy.X = 0;
                }
                if (xy.Y < 0)
                {
                    num2 = area + xy.Y;
                    xy.Y = 0;
                }
                for (int i = 0; i < num2; i++)
                {
                    xy.Y += i;
                    for (int j = 0; j < num; j++)
                    {
                        xy.X += j;
                        if (this.formResize)
                        {
                            break;
                        }
                        byte* imageData = (byte*)img.ImageData;
                        num6 = imageData[(xy.Y * img.WidthStep) + (xy.X * 3)];
                        num7 = imageData[((xy.Y * img.WidthStep) + (xy.X * 3)) + 1];
                        num8 = imageData[((xy.Y * img.WidthStep) + (xy.X * 3)) + 2];
                        double num14 = ((double)num6) / 255.0;
                        double num15 = ((double)num7) / 255.0;
                        double num16 = ((double)num8) / 255.0;
                        num9 = ((0.4124 * num16) + (0.3576 * num15)) + (0.1805 * num14);
                        num10 = ((0.2126 * num16) + (0.7152 * num15)) + (0.0722 * num14);
                        num11 = ((0.0193 * num16) + (0.1192 * num15)) + (0.9505 * num14);
                        num3 += num6;
                        num4 += num7;
                        num5 += num8;
                        pointdf2.X += num9;
                        pointdf2.Y += num10;
                        pointdf2.Z += num11;
                    }
                }
                this.rgb_B = num3 / (num * num2);
                this.rgb_G = num4 / (num * num2);
                this.rgb_R = num5 / (num * num2);
                pointdf2.X /= (double)(num * num2);
                pointdf2.Y /= (double)(num * num2);
                pointdf2.Z /= (double)(num * num2);
                pointdf.X = pointdf2.X / ((pointdf2.X + pointdf2.Y) + pointdf2.Z);
                pointdf.Y = pointdf2.Y / ((pointdf2.X + pointdf2.Y) + pointdf2.Z);
            }
            catch
            {
                pointdf.X = 0.0;
                pointdf.Y = 0.0;
            }
            return pointdf;
        }

        private Rectangle ResizeRectangle(Rectangle s, CvSize imgSize, CvSize wdSize)
        {
            Rectangle rectangle = s;
            System.Drawing.Point point = new System.Drawing.Point(s.X, s.Y);
            System.Drawing.Point point2 = new System.Drawing.Point(0, 0);
            point2 = point;
            if (this.pictureBox1.Image != null)
            {
                double num3;
                double num = ((double)wdSize.Height) / ((double)wdSize.Width);
                double num2 = ((double)imgSize.Height) / ((double)imgSize.Width);
                if (num > num2)
                {
                    num3 = ((double)wdSize.Width) / ((double)imgSize.Width);
                }
                else
                {
                    num3 = ((double)wdSize.Height) / ((double)imgSize.Height);
                }
                if (wdSize.Width > ((int)Math.Round((double)(imgSize.Width * num3))))
                {
                    point2.X -= (int)((wdSize.Width - (imgSize.Width * num3)) / 2.0);
                }
                if (wdSize.Height > ((int)Math.Round((double)(imgSize.Height * num3))))
                {
                    point2.Y -= (int)((wdSize.Height - (imgSize.Height * num3)) / 2.0);
                }
                if (point2.X < 0)
                {
                    point2.X = 0;
                }
                if (point2.X > (wdSize.Width - ((wdSize.Width - (imgSize.Width * num3)) / 2.0)))
                {
                    point2.X = wdSize.Width - ((int)((wdSize.Width - (this.pictureBox1.Image.Width * num3)) / 2.0));
                }
                if (point2.Y < 0)
                {
                    point2.Y = 0;
                }
                if (point2.Y > (wdSize.Height - ((wdSize.Height - (imgSize.Height * num3)) / 2.0)))
                {
                    point2.Y = wdSize.Height - ((int)((wdSize.Height - (imgSize.Height * num3)) / 2.0));
                }
                point = point2;
                rectangle.X = (int)Math.Round((double)(((double)point.X) / num3));
                rectangle.Y = (int)Math.Round((double)(((double)point.Y) / num3));
                rectangle.Width = (int)Math.Round((double)(((double)s.Width) / num3));
                rectangle.Height = (int)Math.Round((double)(((double)s.Height) / num3));
            }
            return rectangle;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            System.Drawing.Point point5;
            System.Drawing.Point location = e.Location;
            double num = 1.0;
            this.maxWidth = this.pictureBox1.Width;
            this.maxHeight = this.pictureBox1.Height;
            this.minWidth = 0;
            this.minHeight = 0;
            if (this.pictureBox1.Image != null)
            {
                double num2 = ((double)this.pictureBox1.Height) / ((double)this.pictureBox1.Width);
                double num3 = ((double)this.pictureBox1.Image.Height) / ((double)this.pictureBox1.Image.Width);
                if (num2 > num3)
                {
                    num = ((double)this.pictureBox1.Width) / ((double)this.pictureBox1.Image.Width);
                }
                else
                {
                    num = ((double)this.pictureBox1.Height) / ((double)this.pictureBox1.Image.Height);
                }
                if (this.pictureBox1.Width > (this.pictureBox1.Image.Width * num))
                {
                    this.minWidth = (int)((this.pictureBox1.Width - (this.pictureBox1.Image.Width * num)) / 2.0);
                    this.maxWidth = this.pictureBox1.Width - ((int)((this.pictureBox1.Width - (this.pictureBox1.Image.Width * num)) / 2.0));
                }
                if (this.pictureBox1.Height > (this.pictureBox1.Image.Height * num))
                {
                    this.minHeight = (int)((this.pictureBox1.Height - (this.pictureBox1.Image.Height * num)) / 2.0);
                    this.maxHeight = this.pictureBox1.Height - ((int)((this.pictureBox1.Height - (this.pictureBox1.Image.Height * num)) / 2.0));
                }
            }
            if ((this.drawRect.Width <= 0) && (this.drawRect.Height <= 0))
            {
                //this.srcImgWidth = this.pictureBox1.Width;
                //this.srcImgHeight = this.pictureBox1.Height;
                this.drawRect.Width = this.srcImgWidth;
                this.drawRect.Height = this.srcImgHeight;
            }
            if ((((e.Button == MouseButtons.Left) && this.teachFlg) && (this.sizePicArea && (this.sizePicStartPosition != location))) && ((this.tempNum < 0x80) || ((this.tempNum <= 0x80) && this.curEdit)))
            {
                System.Drawing.Point sizePicStartPosition = this.sizePicStartPosition;
                System.Drawing.Point point3 = location;
                if (point3.X < 0)
                {
                    point3.X = 0;
                }
                if (point3.Y < 0)
                {
                    point3.Y = 0;
                }
                if (point3.X <= (this.minWidth + 1))
                {
                    point3.X = this.minWidth + 1;
                }
                if (point3.Y <= (this.minHeight + 1))
                {
                    point3.Y = this.minHeight + 1;
                }
                if (point3.X >= (this.maxWidth - 3))
                {
                    point3.X = this.maxWidth - 3;
                }
                if (point3.Y >= (this.maxHeight - 3))
                {
                    point3.Y = this.maxHeight - 3;
                }
                int left = Math.Min(sizePicStartPosition.X, point3.X);
                int top = Math.Min(sizePicStartPosition.Y, point3.Y);
                int right = Math.Max(sizePicStartPosition.X, point3.X);
                Rectangle rectangle = Rectangle.FromLTRB(left, top, right, Math.Max(sizePicStartPosition.Y, point3.Y));
                if ((rectangle.Width > 1) && (rectangle.Height > 1))
                {
                    if ((this.teachFlg && !this.curEdit) && this.newArea)
                    {
                        this.curNum = this.tempNum;
                        this.newArea = false;
                        if ((this.tempNum < 0x80) || ((this.tempNum <= 0x80) && this.curEdit))
                        {
                            this.s_rect = new Rectangle(0, 0, 0, 0);
                            this.r_rect = new Rectangle(0, 0, 0, 0);
                            s_rectList[this.tempNum] = new Rectangle(0, 0, 0, 0);
                            r_rectList[this.tempNum] = new Rectangle(0, 0, 0, 0);
                        }
                    }
                    this.s_rect = rectangle;
                }
                if ((this.s_rect.Width > 1) && (this.s_rect.Height > 1))
                {
                    this.rotationBox.Size.Width = this.s_rect.Width;
                    this.rotationBox.Size.Height = this.s_rect.Height;
                    this.rotationBox.Center.X = this.s_rect.X + (this.s_rect.Width / 2);
                    this.rotationBox.Center.Y = this.s_rect.Y + (this.s_rect.Height / 2);
                    if ((this.curNum == this.tempNum) && !this.curEdit)
                    {
                        s_rectList[this.tempNum] = this.s_rect;
                    }
                    else if ((this.curNum <= this.tempNum) && this.curEdit)
                    {
                        s_rectList[this.curNum - 1] = this.s_rect;
                    }
                    this.button3.Enabled = true;
                    this.pictureBox1.Invalidate();
                }
                this.mousPosition = point3;
            }
            else
            {
                if ((e.Button == MouseButtons.Right) && this.sizePicPosition)
                {
                    if (this.inside && this.teachFlg)
                    {
                        if ((location.X + this.defPos.X) <= (this.minWidth + 1))
                        {
                            this.s_rect.X = this.minWidth + 1;
                        }
                        else if (((location.X + this.defPos.X) + this.s_rect.Width) >= (this.maxWidth - 3))
                        {
                            this.s_rect.X = (this.maxWidth - 3) - this.s_rect.Width;
                        }
                        else
                        {
                            this.s_rect.X = location.X + this.defPos.X;
                        }
                        if ((location.Y + this.defPos.Y) < (this.minHeight + 1))
                        {
                            this.s_rect.Y = this.minHeight + 1;
                        }
                        else if (((location.Y + this.defPos.Y) + this.s_rect.Height) >= (this.maxHeight - 3))
                        {
                            this.s_rect.Y = (this.maxHeight - 3) - this.s_rect.Height;
                        }
                        else
                        {
                            this.s_rect.Y = location.Y + this.defPos.Y;
                        }
                        if ((this.curNum == this.tempNum) && !this.curEdit)
                        {
                            s_rectList[this.tempNum] = this.s_rect;
                        }
                        else if ((this.curNum <= this.tempNum) && this.curEdit)
                        {
                            s_rectList[this.curNum - 1] = this.s_rect;
                        }
                        this.sizePicStartPosition.X = this.s_rect.X;
                        this.sizePicStartPosition.Y = this.s_rect.Y;
                        if (location.X >= (this.maxWidth - 3))
                        {
                            this.mousPosition.X = this.maxWidth - 3;
                        }
                        else if (location.X <= (this.minWidth + 1))
                        {
                            this.mousPosition.X = this.minWidth + 1;
                        }
                        else
                        {
                            this.mousPosition.X = location.X;
                        }
                        if (location.Y >= (this.maxHeight - 3))
                        {
                            this.mousPosition.Y = this.maxHeight - 3;
                        }
                        else if (location.Y <= (this.minHeight + 1))
                        {
                            this.mousPosition.Y = this.minHeight + 1;
                        }
                        else
                        {
                            this.mousPosition.Y = location.Y;
                        }
                        this.rotationBox.Size.Width = this.s_rect.Width;
                        this.rotationBox.Size.Height = this.s_rect.Height;
                        this.rotationBox.Center.X = this.s_rect.X + (this.s_rect.Width / 2);
                        this.rotationBox.Center.Y = this.s_rect.Y + (this.s_rect.Height / 2);
                        ((Control)sender).Invalidate();
                        goto Label_0C85;
                    }
                    if ((this.rotation && (this.s_rect.Width > 1)) && (this.s_rect.Height > 1))
                    {
                        float num4 = (this.sizePicStartPosition.Y - location.Y) % 360;
                        this.rotationBox.Angle = num4;
                        ((Control)sender).Invalidate();
                        goto Label_0C85;
                    }
                    if (this.srcImg == null)
                    {
                        goto Label_0C85;
                    }
                    System.Drawing.Point point4 = this.ResizeImgPos(Cv.Size(this.drawRect.Width, this.drawRect.Height), Cv.Size(this.pictureBox1.Width, this.pictureBox1.Height), location);
                    this.drawRect.X = (this.drawRect.X + this.defPos.X) - point4.X;
                    this.drawRect.Y = (this.drawRect.Y + this.defPos.Y) - point4.Y;
                    if (this.drawRect.X < 0)
                    {
                        this.drawRect.X = 0;
                    }
                    if (this.drawRect.Y < 0)
                    {
                        this.drawRect.Y = 0;
                    }
                    if ((this.drawRect.X + this.drawRect.Width) >= this.srcImgWidth)
                    {
                        this.drawRect.X = this.srcImgWidth - this.drawRect.Width;
                    }
                    if ((this.drawRect.Y + this.drawRect.Height) >= this.srcImgHeight)
                    {
                        this.drawRect.Y = this.srcImgHeight - this.drawRect.Height;
                    }
                    this.defPos = point4;
                    this.sizePicStartPosition.X = this.drawRect.X;
                    this.sizePicStartPosition.Y = this.drawRect.Y;
                    if (location.X > this.pictureBox1.Width)
                    {
                        this.mousPosition.X = this.pictureBox1.Width;
                    }
                    else if (location.X < 0)
                    {
                        this.mousPosition.X = 0;
                    }
                    else
                    {
                        this.mousPosition.X = location.X;
                    }
                    if (location.Y > this.pictureBox1.Height)
                    {
                        this.mousPosition.Y = this.pictureBox1.Height;
                    }
                    else if (location.Y < 0)
                    {
                        this.mousPosition.Y = 0;
                    }
                    else
                    {
                        this.mousPosition.Y = location.Y;
                    }
                    using (IplImage image = Cv.CreateImage(Cv.Size(this.drawRect.Width, this.drawRect.Height), this.srcImg.Depth, this.srcImg.NChannels))
                    {
                        try
                        {
                            if (this.diffImageFlg && (this.diffImgFull != null))
                            {
                                if ((this.diffImgFull.Width > 0) && (this.diffImgFull.Height > 0))
                                {
                                    Cv.SetImageROI(this.diffImgFull, this.drawRect);
                                    Cv.Copy(this.diffImgFull, image);
                                    Cv.ResetImageROI(this.diffImgFull);
                                }
                                else
                                {
                                    Cv.SetImageROI(this.srcImg, this.drawRect);
                                    Cv.Copy(this.srcImg, image);
                                    Cv.ResetImageROI(this.srcImg);
                                }
                            }
                            else
                            {
                                Cv.SetImageROI(this.srcImg, this.drawRect);
                                Cv.Copy(this.srcImg, image);
                                Cv.ResetImageROI(this.srcImg);
                            }
                            this.pictureBox1.Image = image.ToBitmap();
                        }
                        catch
                        {
                        }
                        goto Label_0C85;
                    }
                }
                this.mousPosition = location;
            }
            Label_0C85:
            point5 = this.ResizeImgPos(Cv.Size(this.drawRect.Width, this.drawRect.Height), Cv.Size(this.pictureBox1.Width, this.pictureBox1.Height), this.mousPosition);
            point5.X += this.drawRect.X;
            point5.Y += this.drawRect.Y;
            if (point5.X >= this.srcImgWidth)
            {
                point5.X = this.srcImgWidth - 1;
            }
            if (point5.Y >= this.srcImgHeight)
            {
                point5.Y = this.srcImgHeight - 1;
            }
            if (point5.X < 0)
            {
                point5.X = 0;
            }
            if (point5.Y < 0)
            {
                point5.Y = 0;
            }
            this.label10.Text = "Mouse: " + point5.X.ToString().PadLeft(4) + ", " + point5.Y.ToString().PadLeft(4);
            if ((((this.srcImg != null) && (this.srcImg.Width > 0)) && ((this.srcImg.Height > 0) && (this.pictureBox1.Image != null))) && ((this.pictureBox1.Image.Width > 0) && (this.pictureBox1.Image.Height > 0)))
            {
                this.xyChm = this.ChromaticityAvg(this.srcImg, point5, 1);
            }
            this.label13.Text = string.Concat(new object[] { "Image: X=", this.drawRect.X, ", Y=", this.drawRect.Y, ", W=", this.drawRect.Width, ", H=", this.drawRect.Height });
            if ((this.s_rect.Width > 1) && (this.s_rect.Height > 1))
            {
                this.r_rect = this.ResizeRectangle(this.s_rect, Cv.Size(this.drawRect.Width, this.drawRect.Height), Cv.Size(this.pictureBox1.Width, this.pictureBox1.Height));
                this.r_rect.X += this.drawRect.X;
                this.r_rect.Y += this.drawRect.Y;
            }
            this.label11.Text = "Select: X=" + this.r_rect.X.ToString().PadLeft(4) + ", Y=" + this.r_rect.Y.ToString().PadLeft(4) + ", WIDTH=" + this.r_rect.Width.ToString().PadLeft(4) + ", HEIGHT=" + this.r_rect.Height.ToString().PadLeft(4);
            if (((this.curNum == this.tempNum) || (this.curNum == 0)) && ((!this.curEdit && (this.r_rect.Width > 1)) && (this.r_rect.Height > 1)))
            {
                r_rectList[this.tempNum] = this.r_rect;
            }
            else if (((this.curNum <= this.tempNum) && this.curEdit) && ((this.r_rect.Width > 1) && (this.r_rect.Height > 1)))
            {
                r_rectList[this.curNum - 1] = this.r_rect;
            }
            if ((((this.teachFlg && (this.r_rect.Width > 1)) && (this.r_rect.Height > 1)) && ((this.curNum == this.tempNum) || this.curEdit)) && this.button3.Enabled)
            {
                using (IplImage image2 = new IplImage(Cv.Size(this.r_rect.Width, this.r_rect.Height), this.srcImg.Depth, this.srcImg.NChannels))
                {
                    CvRect rect = new CvRect(this.r_rect.X, this.r_rect.Y, this.r_rect.Width, this.r_rect.Height);
                    try
                    {
                        Cv.SetImageROI(this.srcImg, rect);
                        Cv.Copy(this.srcImg, image2);
                        Cv.ResetImageROI(this.srcImg);
                        Cv.Rectangle(image2, 0, 0, image2.Width - 1, image2.Height - 1, Cv.RGB(0, 0, 0), 1);
                        if (!this.radioButton5.Checked)
                        {
                            using (IplImage image3 = new IplImage(image2.Size, image2.Depth, 1))
                            {
                                using (IplImage image4 = new IplImage(image2.Size, image2.Depth, 1))
                                {
                                    Cv.CvtColor(image2, image3, ColorConversion.BgrToGray);
                                    if (this.radioButton7.Checked)
                                    {
                                        Cv.Threshold(image3, image4, (double)((int)this.numericUpDown21.Value), 255.0, ThresholdType.Binary);
                                        Cv.CvtColor(image4, image2, ColorConversion.GrayToBgr);
                                    }
                                    else
                                    {
                                        Cv.CvtColor(image3, image2, ColorConversion.GrayToBgr);
                                    }
                                }
                            }
                        }
                        this.pictureBox2.Image = image2.ToBitmap();
                    }
                    catch
                    {
                    }
                    this.label46.Text = this.r_rect.X.ToString();
                    this.label47.Text = this.r_rect.Y.ToString();
                    this.label48.Text = this.r_rect.Width.ToString();
                    this.label49.Text = this.r_rect.Height.ToString();
                }
            }
            // this.label12.Text = "xy: " + this.xyChm.X.ToString("0.0000") + ", " + this.xyChm.Y.ToString("0.0000");
            this.label14.Text = "RGB: " + this.rgb_R.ToString().PadLeft(3) + " " + this.rgb_G.ToString().PadLeft(3) + " " + this.rgb_B.ToString().PadLeft(3);
            // this.label35.Text = "Y = " + ((((0.299 * this.rgb_R) + (0.587 * this.rgb_G)) + (0.114 * this.rgb_B))).ToString("0.0000");
            if ((e.Button == MouseButtons.Left) || (e.Button == MouseButtons.Right))
            {
                this.ReSiazeRectangle();
            }
        }


        private void LoadInitModelData()
        {

            this.trackBar1.Value = 0x2d;
            this.numericUpDown3.Value = this.trackBar1.Value;
            this.trackBar2.Value = 0x2d;
            this.numericUpDown4.Value = this.trackBar2.Value;
            this.trackBar3.Value = 0x2d;
            this.numericUpDown5.Value = this.trackBar3.Value;
            this.trackBar4.Value = 0x2d;
            this.numericUpDown6.Value = this.trackBar4.Value;
            this.trackBar6.Value = 100;
            this.numericUpDown7.Value = this.trackBar6.Value;
            this.trackBar7.Value = 0x30d40;
            this.numericUpDown8.Value = this.trackBar7.Value;
            this.trackBar5.Value = 0x5f;
            this.numericUpDown9.Value = this.trackBar5.Value;
            this.trackBar8.Value = 200;

            this.numericUpDown10.Value = (decimal)Math.Round((double)(this.trackBar8.Value * 0.01), 2);
            this.comboBox3.Text = "1";
            this.comboBox4.Text = "1";
            this.radioButton1.Checked = true;
            this.radioButton3.Checked = true;
            this.numericUpDown11.Value = 20M;
            this.numericUpDown12.Value = 20M;
            this.numericUpDown13.Value = 1M;
            this.numericUpDown14.Value = 0.2M;
            this.numericUpDown15.Value = 1M;
            this.numericUpDown16.Value = 1M;
            this.numericUpDown17.Value = 1M;
            this.comboBox5.Text = "0";
            this.comboBox2.Text = "3";
            this.comboBox6.Text = "20";
            this.comboBox7.Text = "1";
            this.numericUpDown18.Value = 1.1M;
            this.numericUpDown19.Value = 5M;
            this.checkBox2.Checked = true;
            this.textBox1.Text = "";
            this.tmpAngleRange = 1.0;
            this.tmpAngleStep = 0.2;
            this.tmpScaleMin = 1.0;
            this.tmpScaleMax = 1.0;
            this.tmpScaleStep = 1.0;
            this.pictureBox2.Image = null;
            this.label2.Text = "No.";
            this.label46.Text = "0";
            this.label47.Text = "0";
            this.label48.Text = "0";
            this.label49.Text = "0";

        }

        private void Load_ImageAdjust(string path)
        {
            ImageAdjust.ReadXML<ImageAdjust>(out this.imageAdjust, path);
            this.imageOffsetMode = this.imageAdjust.imageOffsetMode;
            this.imageSearchOffsetX = this.imageAdjust.imageSeachOffsetX;
            this.imageSearchOffsetY = this.imageAdjust.imageSeachOffsetY;
            this.imageSearchAngle = this.imageAdjust.imageOffsetAngle;
            this.imageSearchScale = this.imageAdjust.imageOffsetScale;
            this.imageLocationOffsetX = this.imageAdjust.imageLocationOffsetX;
            this.imageLocationOffsetY = this.imageAdjust.imageLocationOffsetY;
            this.imageContrastEnabled = this.imageAdjust.imageContrastEnabled;
            this.imageContrastCoef = this.imageAdjust.imageContrastCoef;
            this.imageSmoothEnabled = this.imageAdjust.imageSmoothEnabled;
            this.imageSmoothType = this.imageAdjust.imageSmoothType;
            this.imageSmoothParam1 = this.imageAdjust.imageSmoothParam1;
            this.imageSmoothParam2 = this.imageAdjust.imageSmoothParam2;
            this.imageSmoothParam3 = this.imageAdjust.imageSmoothParam3;
            this.imageSmoothParam4 = this.imageAdjust.imageSmoothParam4;
            this.imageUnsharpEnabled = this.imageAdjust.imageUnsharpEnabled;
            this.imageUnsharpMask = this.imageAdjust.imageUnsharpMask;
            this.imageBilateralEnabled = this.imageAdjust.imageBilateralEnabled;
            this.imageBilateralParam1 = this.imageAdjust.imageBilateralParam1;
            this.imageBilateralParam2 = this.imageAdjust.imageBilateralParam2;
            this.imageBilateralParam3 = this.imageAdjust.imageBilateralParam3;
            this.autoSave = this.imageAdjust.autoSave;
            this.maxLatestImgSave = this.imageAdjust.maxLatestImgSave;
            this.maxNgImgSave = this.imageAdjust.maxNgImgSave;
            this.maxLogFile = this.imageAdjust.maxLogFile;
            this.maxRefImgSave = this.imageAdjust.maxRefImgSave;
            this.autoCsvSave = this.imageAdjust.autoCsvSave;
            this.maxCsvCnt = this.imageAdjust.maxCsvCnt;
            this.maxCsvFile = this.imageAdjust.maxCsvFile;
            this.autoPrint = this.imageAdjust.autoPrint;
            this.printErrOnry = this.imageAdjust.printErrOnry;
            this.soundType = this.imageAdjust.soundType;
            if (this.imageAdjust.version < 0x7f)
            {
                this.imageAdjust.soundPass = true;
                this.imageAdjust.soundNg = true;
            }
            this.soundPass = this.imageAdjust.soundPass;
            this.soundNg = this.imageAdjust.soundNg;
            if ((this.imageAdjust.imageSavePath != null) && (this.imageAdjust.imageSavePath != ""))
            {
                this.imageSavePath = this.imageAdjust.imageSavePath;
                this.srcImgPath = this.imageSavePath + @"\pass\";
                this.ngImgPath = this.imageSavePath + @"\ng\";
                this.refImgPath = this.imageSavePath + @"\reference\";
            }
            if ((this.imageAdjust.csvSavePath != null) && (this.imageAdjust.csvSavePath != ""))
            {
                this.csvPath = this.imageAdjust.csvSavePath + @"\";
            }
            string str = "";
            if ((this.imageAdjust.modelSavePath != null) && (this.imageAdjust.modelSavePath != ""))
            {
                if (!this.imageAdjust.modelSavePath.EndsWith(@"\"))
                {
                    str = @"\";
                }
                if (this.modelSavePath != (this.imageAdjust.modelSavePath + str))
                {
                    this.DataClear();
                    this.LoadModelData(this.imageAdjust.modelSavePath + str);
                }
                this.modelSavePath = this.imageAdjust.modelSavePath + str;
            }
            else
            {
                this.imageAdjust.modelSavePath = this.modelSavePath;
                this.DataClear();
                this.LoadModelData(this.modelSavePath);
            }
            if ((this.imageAdjust.monFolderPath != null) && (this.imageAdjust.monFolderPath != ""))
            {
                this.monFolderPath = this.imageAdjust.monFolderPath;
            }
            if (string.IsNullOrEmpty(this.imageAdjust.monFileExtension))
            {
                this.monFileExtension = "BITMAP";
            }
            else
            {
                this.monFileExtension = this.imageAdjust.monFileExtension;
            }
            this.bcdLock = this.imageAdjust.bcdLock;
            this.bcdTrigger = this.imageAdjust.bcdTrigger;
            if (this.imageAdjust.version < 0x7f)
            {
                if (string.IsNullOrEmpty(this.imageAdjust.monFolderPath))
                {
                    this.imageAdjust.monFolderPath = this.monFolderPath;
                }
                if (string.IsNullOrEmpty(this.imageAdjust.monFileExtension))
                {
                    this.monFileExtension = "BITMAP";
                }
                this.imageAdjust.monFileExtension = this.monFileExtension;
                this.imageAdjust.bcdEnabled = false;
                this.imageAdjust.bcdLock = false;
                this.imageAdjust.bcdTrigger = false;
                this.imageAdjust.soundPass = true;
                this.imageAdjust.soundNg = true;
                this.soundPass = this.imageAdjust.soundPass;
                this.soundNg = this.imageAdjust.soundNg;
                this.imageAdjust.version = 0x7f;
                ImageAdjust.WriteXML<ImageAdjust>(this.imageAdjust, path);
            }
        }

        private void DataClear()
        {
            //if (this.MyMessageBoard != null)
            //{
            //    this.MyMessageBoard.Dispose();
            //}
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            //this.button4.Enabled = false;
            this.button21.Enabled = false;
            this.buttonteaching.Enabled = false;
            this.button17.Enabled = false;
            this.pictureBox1.Image = null;
            this.pictureBox2.Image = null;
            //this.pictureBox3.Image = null;
            this.pictureBox4.Image = null;
            this.pictureBox6.Image = null;
            this.pictureBox7.Image = null;
            //this.pictureBox8.Image = null;
            //this.pictureBox9.Image = null;
            this.drawRect = new CvRect(0, 0, this.srcImgWidth, this.srcImgHeight);
            this.label13.Text = "Width = 0,Heght = 0";
            this.clickPoint = new System.Drawing.Point(0, 0);
            this.sizePicStartPosition = new System.Drawing.Point(0, 0);
            this.srcScale = 1.0;
            this.srcImg = null;
            this.dstImg = null;
            this.rszImg = null;
            this.s_rect = new Rectangle(0, 0, 0, 0);
            this.r_rect = new Rectangle(0, 0, 0, 0);
            s_rectList = new Rectangle[0x81];
            r_rectList = new Rectangle[0x81];
            ms_rectList = new Rectangle[0x81];
            mr_rectList = new Rectangle[0x81];
            this.retry = new int[0x80];
            this.tmpDataNum = new TEMPLATE_DATA_NUM[0x80];
            this.tempNum = 0;
            this.measureNum = 0;
            this.curNum = 0;
            this.comboBox1.Text = "";
            this.dstdifimg = null;
            this.dstBinDifimg = null;
            this.diffImgFull = null;
            this.diffImageFlg = false;
            this.xyChm = new CvPoint2D64f(0.0, 0.0);
            this.rgb_B = 0;
            this.rgb_G = 0;
            this.rgb_R = 0;
            this.listView1.Items.Clear();
            this.label25.ForeColor = Color.Black;
            this.label25.BackColor = Color.Transparent;
            this.label25.Text = "O/N";
            if (this.comok && this.ComControl.IsOpen == true)
            {
                this.ComControl.Write("R");
            }
            this.label27.Text = "0";
            this.label29.Text = "0";
            this.label70.Text = "0";
            this.label71.Text = "0";
            this.label2.Text = "N0.";
            this.label46.Text = "0";
            this.label47.Text = "0";
            this.label48.Text = "0";
            this.label49.Text = "0";
            this.label50.Text = "0";
            this.label52.Text = "0";
            this.label73.Text = "0";
            this.label58.Text = "0";
            this.label59.Text = "0";
            this.label64.Text = "0";
            this.label67.Text = "0";
            this.label74.ForeColor = Color.Black;
            this.label74.Text = "Info:";
            //this.label92.Text = "";
            //this.label94.Text = "";
            this.measurementCount = 0;
            this.measurementOk = 0;
            this.measurementNg = 0;
            this.label2.Text = "No.1";
            this.label50.Text = this.label52.Text = "1";
            if (this.gigeCam || this.usbCam || this.camok)
            {
                this.button1.Enabled = true;
            }
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            // this.button4.Enabled = true;
            this.button21.Enabled = true;
            this.button18.Enabled = false;
            this.button19.Enabled = false;
            this.textBox1.Text = "";
            this.curEdit = false;
            this.setFlg = false;
            this.fileOpFlg = false;
            this.button7.ForeColor = Color.WhiteSmoke;
            this.label100.Visible = false;
            //this.StopSound();

        }

        private void LoadCameraProperty(string path)
        {
            CameraSetting.ReadCameraProperty<CameraSetting>(out this.cameraSetting, path);
            this.exposureMode = this.cameraSetting.exposureMode;
            this.exposureTime = this.cameraSetting.exposureTime;
            this.gainMode = this.cameraSetting.gainMode;
            this.gain = this.cameraSetting.gain;
            this.whiteLevelMode = this.cameraSetting.whiteLevelMode;
            this.whiteLevel = this.cameraSetting.whiteLevel;
            this.blackLevel = this.cameraSetting.blackLevel;
            this.gammaLevel = this.cameraSetting.gamma;
            this.packetSize = this.cameraSetting.packetSize;
            this.deviceName = this.cameraSetting.deviceName;
            this.serialNumber = this.cameraSetting.serialNumber;
            this.fullSize = this.cameraSetting.fullsize;
            this.capSize = this.cameraSetting.capSize;
            this.capWidth = this.cameraSetting.capWidth;
            this.capHeight = this.cameraSetting.capHeight;
            this.capX = this.cameraSetting.capX;
            this.capY = this.cameraSetting.capY;
            this.widthMax = this.cameraSetting.widthMax;
            this.heightMax = this.cameraSetting.heightMax;
            this.color = this.cameraSetting.color;
            this.reSize = this.cameraSetting.reSize;
        }
        private void difDispBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int argument = (int)e.Argument;
            e.Result = new DiffDispData();
            BackgroundWorker worker = (BackgroundWorker)sender;
            IplImage src = new IplImage(this.srcImg.Size, this.srcImg.Depth, this.srcImg.NChannels);
            DiffDispData data = new DiffDispData();
            try
            {

                data.img = new IplImage(this.srcImg.Size, this.srcImg.Depth, this.srcImg.NChannels);
                data.flg = false;
                this.dstdifimg = new IplImage(this.srcImg.Size, this.srcImg.Depth, this.srcImg.NChannels);
                using (IplImage image2 = new IplImage(this.srcImg.Size, this.srcImg.Depth, this.srcImg.NChannels))
                {
                    using (IplImage image3 = new IplImage(this.srcImg.Size, this.srcImg.Depth, this.srcImg.NChannels))
                    {
                        using (IplImage image4 = new IplImage(this.srcImg.Size, BitDepth.U8, 1))
                        {
                            for (int i = 0; i < argument; i++)
                            {
                                if (worker.CancellationPending)
                                {
                                    e.Cancel = true;
                                    return;
                                }
                                if (this.diffResult[i].whitePix != 0L)
                                {

                                    src = OpenCvSharp.Extensions.BitmapConverter.ToIplImage(this.diffResult[i].difBinImg);
                                    this.FillImage(src, src, Color.DarkRed);
                                    Cv.Zero(image3);
                                    CvRect rect = new CvRect((image3.Width / 2) - (this.rszImg.Width / 2), (image3.Height / 2) - (this.rszImg.Height / 2), this.rszImg.Width, this.rszImg.Height);
                                    Cv.SetImageROI(image3, rect);
                                    Cv.Copy(this.rszImg, image3);
                                    Cv.ResetImageROI(image3);
                                    CvRect rect2 = this.diffResult[i].rect;
                                    Cv.Zero(image4);
                                    rect2.X += (int)Math.Round((double)((((double)image2.Width) / 2.0) - (((double)this.rszImg.Width) / 2.0)));
                                    rect2.Y += (int)Math.Round((double)((((double)image2.Height) / 2.0) - (((double)this.rszImg.Height) / 2.0)));
                                    Cv.SetImageROI(image2, rect2);
                                    Cv.Copy(src, image2);
                                    Cv.ResetImageROI(image2);
                                    Cv.CvtColor(image2, image4, ColorConversion.BgrToGray);
                                    Cv.Threshold(image4, image4, (double)this.refModelObjNum[i].binaryAllThreshold, 255.0, ThresholdType.BinaryInv);
                                    Cv.Copy(image3, image2, image4);
                                    data.flg = true;
                                }
                                worker.ReportProgress((int)((((float)(i + 1)) / ((float)argument)) * 100f));
                            }
                            if (data.flg)
                            {
                                Cv.Copy(image2, data.img);
                                this.dstdifimg = data.img;
                            }
                            else
                            {
                                data.img = null;
                            }
                            e.Result = data;
                        }
                    }
                }
            }
            catch
            {
                e.Result = null;
            }
            src.Dispose();
        }
        private void difDispBgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                this.diffDispBkgFlg = -1;
            }
            else if (e.Result != null)
            {
                this.diffDispData = (DiffDispData)e.Result;
                this.diffImgFull = this.diffDispData.img;
                this.diffImageFlg = this.diffDispData.flg;
                this.diffDispBkgFlg = 1;
            }
            else if (e.Result == null)
            {
                this.diffDispBkgFlg = -2;
            }
        }
        private void difDispBgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.label100.Text = "DIFFERENTIALS IMAGE  " + e.ProgressPercentage.ToString() + " %";
            this.label100.Location = new System.Drawing.Point((this.pictureBox1.Location.X + (this.pictureBox1.Width / 2)) - (this.label100.Width / 2), ((this.pictureBox1.Location.Y + (this.pictureBox1.Height / 2)) - (this.label100.Height / 2)) - 70);
            this.label100.Visible = true;
        }
        private TempMatchResult DoTemplateMatchingMSA_BKG(TEMPLATE_DATA_BKG data)
        {
            TempMatchResult result = new TempMatchResult();
            int num3 = 0;
            int num4 = 0;
            double num5 = 1.0;

            try
            {
                using (IplImage image = new IplImage(Cv.Size((data.tgtArea.img.Width - data.tmpData[data.refTmpID.scaleID, data.refTmpID.angleID].image.Width) + 1, (data.tgtArea.img.Height - data.tmpData[data.refTmpID.scaleID, data.refTmpID.angleID].image.Height) + 1), BitDepth.F32, 1))
                {
                    double num;
                    double num2;
                    CvPoint point;
                    CvPoint point2;
                    int num6 = 0;
                    int num7 = 0;
                    int num8 = 0;
                    int num9 = 0;
                    Cv.MatchTemplate(data.tgtArea.img, data.tmpData[data.refTmpID.scaleID, data.refTmpID.angleID].image, image, MatchTemplateMethod.SqDiffNormed);
                    //Cv.MatchTemplate(data.tgtArea.img, data.tmpData[data.refTmpID.scaleID, data.refTmpID.angleID].image, image, MatchTemplateMethod.SqDiffNormed);
                    Cv.MinMaxLoc(image, out num, out num2, out point, out point2);

                    using (IplImage image2 = new IplImage(Cv.Size(data.tmpData[data.refTmpID.scaleID, data.refTmpID.angleID].image.Width + num6, data.tmpData[data.refTmpID.scaleID, data.refTmpID.angleID].image.Height + num7), data.tgtArea.img.Depth, data.tgtArea.img.NChannels))
                    {
                        CvPoint point3;
                        CvRect rect;
                        rect.Width = data.tmpData[data.refTmpID.scaleID, data.refTmpID.angleID].image.Width + num6;
                        rect.Height = data.tmpData[data.refTmpID.scaleID, data.refTmpID.angleID].image.Height + num7;
                        if ((point.X - num8) < 0)
                        {
                            rect.X = 0;
                        }
                        else
                        {
                            rect.X = point.X - num8;

                            //rect.X = 291;
                            // rect.X = refModelObjNum[stepcheck].positionX - data.tgtArea.rct.X;;

                        }
                        if ((point.Y - num9) < 0)
                        {
                            rect.Y = 0;

                        }
                        else
                        {
                            rect.Y = point.Y - num9;
                            //rect.Y = 252;
                            // rect.Y = refModelObjNum[stepcheck].positionY- data.tgtArea.rct.Y; ;

                        }
                        Cv.SetImageROI(data.tgtArea.img, rect);
                        Cv.Copy(data.tgtArea.img, image2);
                        Cv.ResetImageROI(data.tgtArea.img);
                        point3.X = 0;
                        point3.Y = 0;
                        if (data.mode > 0)
                        {
                            using (IplImage image3 = new IplImage(image2.Size, BitDepth.U8, 1))
                            {
                                using (IplImage image4 = new IplImage(image2.Size, BitDepth.U8, 1))
                                {
                                    Cv.CvtColor(image2, image3, ColorConversion.BgrToGray);
                                    if (data.mode == 2)
                                    {
                                        Cv.Threshold(image3, image4, (double)data.ptMatchBinThreshold, 255.0, ThresholdType.Binary);
                                        Cv.CvtColor(image4, image2, ColorConversion.GrayToBgr);
                                    }
                                    else
                                    {
                                        Cv.CvtColor(image3, image2, ColorConversion.GrayToBgr);
                                    }
                                }
                            }
                        }
                        for (int i = 0; i < data.scaleNumber; i++)
                        {
                            using (IplImage image5 = new IplImage(Cv.Size((image2.Width - data.tmpData[i, 0].image.Width) + 1, (image2.Height - data.tmpData[i, 0].image.Height) + 1), BitDepth.F32, 1))
                            {
                                for (int j = 0; j < data.anglenumber; j++)
                                {
                                    using (IplImage image6 = new IplImage(Cv.Size(data.tmpData[i, j].image.Width, data.tmpData[i, j].image.Height), data.tmpData[i, j].image.Depth, data.tmpData[i, j].image.NChannels))
                                    {
                                        if (data.mode > 0)
                                        {
                                            Cv.Copy(data.tmpData[i, j].image, image6);
                                            using (IplImage image7 = new IplImage(image6.Size, BitDepth.U8, 1))
                                            {
                                                using (IplImage image8 = new IplImage(image6.Size, BitDepth.U8, 1))
                                                {
                                                    Cv.CvtColor(image6, image7, ColorConversion.BgrToGray);
                                                    if (data.mode == 2)
                                                    {
                                                        Cv.Threshold(image7, image8, (double)data.ptMatchBinThreshold, 255.0, ThresholdType.Binary);
                                                        Cv.CvtColor(image8, image6, ColorConversion.GrayToBgr);
                                                    }
                                                    else
                                                    {
                                                        Cv.CvtColor(image7, image6, ColorConversion.GrayToBgr);
                                                    }
                                                }
                                            }
                                            Cv.MatchTemplate(image2, image6, image5, MatchTemplateMethod.SqDiffNormed);
                                        }
                                        else
                                        {
                                            Cv.MatchTemplate(image2, data.tmpData[i, j].image, image5, MatchTemplateMethod.SqDiffNormed);
                                        }
                                        Cv.MinMaxLoc(image5, out num, out num2, out point, out point2);
                                        if (num5 > num)
                                        {
                                            num5 = num;
                                            point3 = point;
                                            num3 = i;
                                            num4 = j;
                                        }
                                    }
                                }
                            }
                        }
                        num5 = (1.0 - num5) * 100.0;
                        if (num5 < 10)
                        {
                            result.Score = 1;
                        }
                        else
                        {
                            result.Score = num5;
                        }
                        // result.Location.X = refModelObjNum[stepcheck].positionX;
                        // result.Location.Y = refModelObjNum[stepcheck].positionY;
                        //rect.X = 291;
                        //rect.Y = 252;


                        // result.Location.X = (rect.X );
                        // result.Location.Y = (rect.Y );
                        int xlo = (rect.X + point3.X) + data.tgtArea.rct.X;
                        int ylo = (rect.Y + point3.Y) + data.tgtArea.rct.Y;
                        if (Math.Abs(refModelObjNum[stepcheck].positionX - xlo) >= 30 || Math.Abs(refModelObjNum[stepcheck].positionY - ylo) >= 30)
                        {
                            result.Location.X = refModelObjNum[stepcheck].positionX;
                            result.Location.Y = refModelObjNum[stepcheck].positionY;
                        }
                        else
                        {
                            result.Location.X = xlo;
                            result.Location.Y = ylo;
                        }

                        result.ScaleID = num3;
                        result.AngleID = num4;
                        result.Scale = data.tmpData[num3, num4].scale;
                        result.Angle = data.tmpData[num3, num4].angle;
                    }
                    return result;
                }
            }
            catch
            {

            }
            return result;
        }


        private void tmpMatchStartBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int argument = (int)e.Argument;
            BackgroundWorker worker = (BackgroundWorker)sender;
            bool flag = false;
            for (int i = 0; i < argument; i++)
            {

                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                if (!this.backgroundWorker[i].IsBusy)
                {
                    if (this.refModelObjNum[i].inspectEnabled)
                    {

                        this.bkgFlg[i] = false;
                        this.compFlg[i] = false;
                        this.measurementsMatchRate[i] = 0.0;
                        this.measurementsDiffArea[i] = 0.0;
                        if (this.tmpDataNum[i].tmpData == null)
                        {
                            this.MakeTempImage(i);
                        }
                        if (!flag)
                        {
                            if (this.imageAdjust.imageOffsetMode == 1)
                            {
                                int num3 = 0;

                                while (true)
                                {
                                    this.stepcheck = i;
                                    this.tempDataBKG.mode = this.refModelObjNum[i].mode;
                                    this.tempDataBKG.ptMatchBinThreshold = this.refModelObjNum[i].ptMatchBinaryThreshold;
                                    this.image_offsetX = 0;
                                    this.image_offsetY = 0;
                                    this.search_offsetX = this.imageAdjust.imageSeachOffsetX;
                                    this.search_offsetY = this.imageAdjust.imageSeachOffsetY;
                                    this.search_score = this.imageAdjust.imageOffsetScore;
                                    this.tempDataBKG.tmpData = this.tmpDataNum[i].tmpData;
                                    this.tempDataBKG.refTmpID.scaleID = this.tmpDataNum[i].refScaleID;
                                    this.tempDataBKG.refTmpID.angleID = this.tmpDataNum[i].refAngleID;
                                    this.tempDataBKG.tgtArea = this.SetSearcArea(this.rszImg, i, this.tmpDataNum[i], this.image_offsetX, this.image_offsetY, this.refModelObjNum[i].searchPositionRangeX + this.search_offsetX, this.refModelObjNum[i].searchPositionRangeY + this.search_offsetY);
                                    this.tempDataBKG.scaleNumber = this.scaleNum;
                                    this.tempDataBKG.anglenumber = this.angleNum;
                                    this.tmpMatchResult[i] = this.DoTemplateMatchingMSA_BKG(this.tempDataBKG);
                                    if ((this.tmpMatchResult[i].Score != 0.0) || (num3 >= 2))
                                    {
                                        break;
                                    }
                                    num3++;
                                    this.bkgFlg[i] = false;
                                    this.compFlg[i] = false;
                                    this.measurementsMatchRate[i] = 0.0;
                                    this.measurementsDiffArea[i] = 0.0;
                                }
                                if (this.tmpMatchResult[i].Score >= this.search_score)
                                {
                                    this.image_offsetX = this.tmpMatchResult[i].Location.X - this.tmpDataNum[i].pt.X;
                                    this.image_offsetY = this.tmpMatchResult[i].Location.Y - this.tmpDataNum[i].pt.Y;
                                }
                                else
                                {
                                    this.image_offsetX = 0;
                                    this.image_offsetY = 0;
                                }
                                this.search_offsetX = 0;
                                this.search_offsetY = 0;
                                this.bkgFlg[i] = true;
                            }
                            else if (this.imageAdjust.imageOffsetMode == 2)
                            {
                                this.search_offsetX = this.imageAdjust.imageSeachOffsetX;
                                this.search_offsetY = this.imageAdjust.imageSeachOffsetY;
                                this.image_offsetX = this.imageAdjust.imageLocationOffsetX;
                                this.image_offsetY = this.imageAdjust.imageLocationOffsetY;
                                //flag = true;
                            }
                            else if (this.imageAdjust.imageOffsetMode == 0)
                            {
                                this.search_offsetX = 0;
                                this.search_offsetY = 0;
                                this.image_offsetX = 0;
                                this.image_offsetY = 0;
                                //flag = true;
                            }
                        }
                        if (flag)
                        {
                            this.tempDataBKG.mode = this.refModelObjNum[i].mode;
                            this.tempDataBKG.ptMatchBinThreshold = this.refModelObjNum[i].ptMatchBinaryThreshold;
                            this.tempDataBKG.tmpData = this.tmpDataNum[i].tmpData;
                            this.tempDataBKG.refTmpID.scaleID = this.tmpDataNum[i].refScaleID;
                            this.tempDataBKG.refTmpID.angleID = this.tmpDataNum[i].refAngleID;
                            this.tempDataBKG.tgtArea = this.SetSearcArea(this.rszImg, i, this.tmpDataNum[i], this.image_offsetX, this.image_offsetY, this.refModelObjNum[i].searchPositionRangeX + this.search_offsetX, this.refModelObjNum[i].searchPositionRangeY + this.search_offsetY);
                            this.tempDataBKG.scaleNumber = this.scaleNum;
                            this.tempDataBKG.anglenumber = this.angleNum;
                            this.backgroundWorker[i].RunWorkerAsync(this.tempDataBKG);

                        }
                        else
                        {
                            //flag = true;
                        }
                    }
                    else
                    {
                        this.bkgFlg[i] = true;
                        this.compFlg[i] = true;
                        this.measurementsMatchRate[i] = 0.0;
                        this.measurementsDiffArea[i] = 0.0;
                    }
                }

                worker.ReportProgress((int)((((float)(i + 1)) / ((float)argument)) * 100f));
            }
            e.Result = argument;
        }
        private void tmpMatchStartBgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                this.tmpBkgwFlg = -1;
            }
            else
            {
                this.tmpBkgwFlg = 1;
                this.measureNum = (int)e.Result;
                this.curNum = this.measureNum;
            }
        }
        private void tmpMatchStartBgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.label100.Text = "TEMPLATE MATCHING  " + e.ProgressPercentage.ToString() + " %";
            this.label100.Location = new System.Drawing.Point((this.pictureBox1.Location.X + (this.pictureBox1.Width / 2)) - (this.label100.Width / 2), ((this.pictureBox1.Location.Y + (this.pictureBox1.Height / 2)) - (this.label100.Height / 2)) - 70);
        }
        private DiffResult DiffImageBKG(DIFFIMAGE_DATA arg)
        {
            DiffResult result = new DiffResult();
            int id = arg.id;
            using (IplImage image = new IplImage(arg.rimg.Size, arg.rimg.Depth, arg.rimg.NChannels))// rimg anh goc
            {
                using (IplImage image2 = new IplImage(arg.tmpimg.Size, arg.tmpimg.Depth, arg.tmpimg.NChannels))// cac khung hinh teach can tim
                {
                    using (IplImage image3 = new IplImage(arg.tmpimg.Size, arg.tmpimg.Depth, arg.tmpimg.NChannels))
                    {
                        //string rimg = string.Concat(arg.rimg.Size.Width.ToString(), ",", arg.rimg.Size.Height.ToString(), ",_", arg.tmpimg.Size.Width.ToString(),",", arg.tmpimg.Size.Height.ToString()) ;
                        // MessageBox.Show(rimg);
                        Cv.Copy(arg.rimg, image);// copy data anh rimg sang image
                        Cv.Copy(arg.tmpimg, image2);
                        CvPoint point = new CvPoint
                        {
                            X = this.tmpMatchResult[id].Location.X,
                            Y = this.tmpMatchResult[id].Location.Y
                        };
                        CvPoint point2 = new CvPoint
                        {
                            X = this.tmpMatchResult[id].Location.X + image2.Width,
                            Y = this.tmpMatchResult[id].Location.Y + image2.Height
                        };
                        if (point.X < 0)
                        {
                            point.X = 0;
                        }
                        if (point.Y < 0)
                        {
                            point.Y = 0;
                        }
                        if (point2.X >= image.Width)
                        {
                            point2.X = image.Width - 1;
                        }
                        if (point2.Y >= image.Height)
                        {
                            point2.Y = image.Height - 1;
                        }
                        int left = Math.Min(point.X, point2.X);
                        int top = Math.Min(point.Y, point2.Y);
                        int right = Math.Max(point.X, point2.X);
                        mr_rectList[id] = Rectangle.FromLTRB(left, top, right, Math.Max(point.Y, point2.Y));
                        ms_rectList[id] = this.CmvViewRectangle(Cv.Size(this.pictureBox1.Width, this.pictureBox1.Height), Cv.Size(this.srcImgWidth, this.srcImgHeight), mr_rectList[id]);
                        CvRect rect = new CvRect(this.tmpMatchResult[id].Location, image2.Size);
                        Cv.SetImageROI(image, rect);
                        Cv.Copy(image, image3);
                        Cv.ResetImageROI(image);
                        if (this.refModelObjNum[id].mode > 0)
                        {
                            using (IplImage image4 = new IplImage(image2.Size, BitDepth.U8, 1))
                            {
                                using (IplImage image5 = new IplImage(image2.Size, BitDepth.U8, 1))
                                {
                                    Cv.CvtColor(image2, image4, ColorConversion.BgrToGray);
                                    if (this.refModelObjNum[id].mode == 2)
                                    {
                                        Cv.Threshold(image4, image5, (double)this.refModelObjNum[id].ptMatchBinaryThreshold, 255.0, ThresholdType.Binary);
                                        Cv.CvtColor(image5, image2, ColorConversion.GrayToBgr);
                                    }
                                    else
                                    {
                                        Cv.CvtColor(image4, image2, ColorConversion.GrayToBgr);
                                    }
                                    Cv.CvtColor(image3, image4, ColorConversion.BgrToGray);
                                    if (this.refModelObjNum[id].mode == 2)
                                    {
                                        Cv.Threshold(image4, image5, (double)this.refModelObjNum[id].ptMatchBinaryThreshold, 255.0, ThresholdType.Binary);
                                        Cv.CvtColor(image5, image3, ColorConversion.GrayToBgr);
                                    }
                                    else
                                    {
                                        Cv.CvtColor(image4, image3, ColorConversion.GrayToBgr);
                                    }
                                }
                            }
                        }
                        int thickness = 1;
                        int num3 = 0;
                        int num4 = 0;
                        Cv.Rectangle(image3, 0, 0, image3.Width - num3, image3.Height - num4, Cv.RGB(0, 0, 0), thickness);
                        Cv.Rectangle(image2, 0, 0, image2.Width - num3, image2.Height - num4, Cv.RGB(0, 0, 0), thickness);
                        using (IplImage image6 = new IplImage(image2.Size, image2.Depth, image2.NChannels))
                        {
                            using (IplImage image7 = new IplImage(image2.Size, image2.Depth, image2.NChannels))
                            {
                                using (IplImage image8 = new IplImage(image3.Size, image3.Depth, image3.NChannels))
                                {
                                    using (IplImage image9 = new IplImage(image3.Size, image3.Depth, image3.NChannels))
                                    {
                                        Cv.Copy(image2, image6);
                                        Cv.Copy(image3, image8);
                                        if (this.refModelObjNum[id].unsharpMask > 1.0)
                                        {
                                            CvUnsharpMasking(image2, image6, this.refModelObjNum[id].unsharpMask);
                                            CvUnsharpMasking(image3, image8, this.refModelObjNum[id].unsharpMask);
                                        }
                                        int smoothParam = this.refModelObjNum[id].smoothParam;
                                        int num6 = smoothParam;
                                        int num7 = this.refModelObjNum[id].smoothParam3;
                                        int num8 = this.refModelObjNum[id].smoothParam4;
                                        if (smoothParam > 0)
                                        {
                                            Cv.Smooth(image6, image7, SmoothType.Bilateral, smoothParam, num6, (double)num7, (double)num8);
                                            Cv.Smooth(image7, image6, SmoothType.Bilateral, smoothParam, num6, (double)num7, (double)num8);
                                            Cv.Smooth(image8, image9, SmoothType.Bilateral, smoothParam, num6, (double)num7, (double)num8);
                                            Cv.Smooth(image9, image8, SmoothType.Bilateral, smoothParam, num6, (double)num7, (double)num8);
                                        }
                                        if (this.refModelObjNum[id].contrastCoef > 0f)
                                        {
                                            CvContrast(image6, image6, this.refModelObjNum[id].contrastCoef);
                                            CvContrast(image8, image8, this.refModelObjNum[id].contrastCoef);
                                        }
                                        IplImage dst = new IplImage(image6.Size, image6.Depth, image6.NChannels);
                                        this.DifferentImage(image6, image8, out dst);

                                        if (this.refModelObjNum[id].erodNumThreshold > 0)
                                        {
                                            Cv.Erode(dst, dst, null, this.refModelObjNum[id].erodNumThreshold);
                                        }
                                        if (this.refModelObjNum[id].dilaNumThreshold > 0)
                                        {
                                            Cv.Dilate(dst, dst, null, this.refModelObjNum[id].dilaNumThreshold);
                                        }
                                        IplImage image11 = new IplImage(dst.Size, dst.Depth, dst.NChannels);
                                        IplImage image12 = new IplImage(dst.Size, BitDepth.U8, 1);
                                        if (!this.refModelObjNum[id].thresholdColorMode && this.refModelObjNum[id].thresholdManualMode)
                                        {
                                            Cv.Threshold(dst, image11, (double)this.refModelObjNum[id].binaryAllThreshold, 255.0, ThresholdType.Binary);
                                            Cv.CvtColor(image11, image12, ColorConversion.BgrToGray);
                                        }
                                        else
                                        {
                                            if (this.refModelObjNum[id].thresholdColorMode && this.refModelObjNum[id].thresholdManualMode)
                                            {
                                                if ((this.refModelObjNum[id].binaryGreenThreshold == this.refModelObjNum[id].binaryBlueThreshold) && (this.refModelObjNum[id].binaryGreenThreshold == this.refModelObjNum[id].binaryRedThreshold))
                                                {
                                                    Cv.Threshold(dst, image11, (double)this.refModelObjNum[id].binaryAllThreshold, 255.0, ThresholdType.Binary);
                                                    Cv.CvtColor(image11, image12, ColorConversion.BgrToGray);
                                                    goto Label_08D2;
                                                }
                                                using (IplImage image13 = new IplImage(dst.Size, BitDepth.U8, 1))
                                                {
                                                    using (IplImage image14 = new IplImage(dst.Size, BitDepth.U8, 1))
                                                    {
                                                        using (IplImage image15 = new IplImage(dst.Size, BitDepth.U8, 1))
                                                        {
                                                            Cv.Split(dst, image13, image14, image15, null);
                                                            Cv.Threshold(image13, image13, (double)this.refModelObjNum[id].binaryBlueThreshold, 255.0, ThresholdType.Binary);
                                                            Cv.Threshold(image14, image14, (double)this.refModelObjNum[id].binaryGreenThreshold, 255.0, ThresholdType.Binary);
                                                            Cv.Threshold(image15, image15, (double)this.refModelObjNum[id].binaryRedThreshold, 255.0, ThresholdType.Binary);
                                                            Cv.Merge(image13, image14, image15, null, image11);
                                                            Cv.CvtColor(image11, image12, ColorConversion.BgrToGray);
                                                        }
                                                    }
                                                    goto Label_08D2;
                                                }
                                            }
                                            if (this.refModelObjNum[id].thresholdColorMode && !this.refModelObjNum[id].thresholdManualMode)
                                            {
                                                using (IplImage image16 = new IplImage(dst.Size, BitDepth.U8, 1))
                                                {
                                                    using (IplImage image17 = new IplImage(dst.Size, BitDepth.U8, 1))
                                                    {
                                                        using (IplImage image18 = new IplImage(dst.Size, BitDepth.U8, 1))
                                                        {
                                                            Cv.Split(dst, image16, image17, image18, null);
                                                            Cv.Threshold(image16, image16, 0.0, 255.0, ThresholdType.Otsu);
                                                            Cv.Threshold(image17, image17, 0.0, 255.0, ThresholdType.Otsu);
                                                            Cv.Threshold(image18, image18, 0.0, 255.0, ThresholdType.Otsu);
                                                            Cv.Merge(image16, image17, image18, null, image11);
                                                            Cv.CvtColor(image11, image12, ColorConversion.BgrToGray);
                                                        }
                                                    }
                                                    goto Label_08D2;
                                                }
                                            }
                                            Cv.CvtColor(dst, image12, ColorConversion.BgrToGray);
                                            Cv.Threshold(image12, image12, 0.0, 255.0, ThresholdType.Otsu);
                                        }
                                        Label_08D2:
                                        using (IplImage image19 = new IplImage(dst.Size, BitDepth.U8, 1))
                                        {
                                            Cv.Copy(image12, image19);
                                            CvBlobs blobs = new CvBlobs(image19);
                                            int blobMinAreaThreshold = this.refModelObjNum[id].blobMinAreaThreshold;
                                            int blobMaxAreaThreshold = this.refModelObjNum[id].blobMaxAreaThreshold;
                                            if (blobMaxAreaThreshold == 0)
                                            {
                                                blobs.FilterByArea(blobMinAreaThreshold, 0x7fffffff);
                                            }
                                            else
                                            {
                                                blobs.FilterByArea(blobMinAreaThreshold, blobMaxAreaThreshold);
                                            }
                                            IplImage imgDest = new IplImage(image11.Size, BitDepth.U8, 3);
                                            imgDest.Zero();
                                            blobs.RenderBlobs(image11, imgDest, RenderBlobsMode.None | RenderBlobsMode.Color);
                                            Cv.Threshold(imgDest, image11, (double)this.refModelObjNum[id].binaryAllThreshold, 255.0, ThresholdType.Binary);
                                            long pWhitePixelCount = 0L;
                                            long pBlackPixelCount = 0L;
                                            double num13 = 0.0;
                                            using (IplImage image21 = new IplImage(dst.Size, BitDepth.U8, 1))
                                            {
                                                Cv.CvtColor(image11, image21, ColorConversion.BgrToGray);
                                                ThreshImagePixcelCountProc(image21, this.refModelObjNum[id].binaryAllThreshold, out pWhitePixelCount, out pBlackPixelCount);
                                                num13 = (((double)pWhitePixelCount) / ((double)(pWhitePixelCount + pBlackPixelCount))) * 100.0;
                                            }
                                            result.refimg = image2.ToBitmap();
                                            result.tgtimg = image3.ToBitmap();
                                            result.refFilImg = image6.ToBitmap();
                                            result.tgtFilImg = image8.ToBitmap();
                                            result.diffImg = dst.ToBitmap();
                                            result.mskImg = image19.ToBitmap();
                                            result.difBinImg = image11.ToBitmap();
                                            result.no = id + 1;
                                            result.rect = rect;
                                            result.matchRate = this.measurementsMatchRate[id];
                                            result.diffArea = num13;
                                            result.whitePix = pWhitePixelCount;
                                            result.angle = this.tmpMatchResult[id].Angle;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            this.diffResult[id] = result;
            return result;
        }

        private void diffBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            e.Result = new DiffResult();
            DIFFIMAGE_DATA argument = (DIFFIMAGE_DATA)e.Argument;
            try
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {
                    this.DiffImageBKG(argument);
                }
            }
            catch
            {
                e.Result = null;
            }
        }
        private void diffBgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            for (int i = 0; i < this.tempNum; i++)
            {
                if (sender.Equals(this.diffBgWorker[i]))
                {
                    this.difbkgFlg[i] = true;
                    return;
                }
            }
        }
        private void diffBgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            e.Result = null;
            e.Result = new TempMatchResult();
            TEMPLATE_DATA_BKG argument = (TEMPLATE_DATA_BKG)e.Argument;


            try
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {

                    this.stepcheck = this.stepagain;
                    this.stepagain++;
                    e.Result = this.DoTemplateMatchingMSA_BKG(argument);


                }
            }
            catch
            {
                e.Result = null;
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            for (int i = 0; i < this.backgroundWorker.Length; i++)
            {
                if (sender.Equals(this.backgroundWorker[i]))
                {
                    try
                    {
                        this.tmpMatchResult[i] = new TempMatchResult();
                        if (e.Result != null)
                        {
                            this.tmpMatchResult[i] = (TempMatchResult)e.Result;
                        }
                    }
                    catch
                    {
                    }
                    this.bkgFlg[i] = true;
                    return;
                }
            }
        }
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }


        private void InitBgWorker(int num)
        {
            this.difDispBgWorker = new BackgroundWorker();
            this.difDispBgWorker.DoWork += new DoWorkEventHandler(this.difDispBgWorker_DoWork);
            this.difDispBgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.difDispBgWorker_RunWorkerCompleted);
            this.difDispBgWorker.ProgressChanged += new ProgressChangedEventHandler(this.difDispBgWorker_ProgressChanged);
            this.difDispBgWorker.WorkerSupportsCancellation = true;
            this.tmpMatchStartBgWorker = new BackgroundWorker();
            this.tmpMatchStartBgWorker.DoWork += new DoWorkEventHandler(this.tmpMatchStartBgWorker_DoWork);
            this.tmpMatchStartBgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.tmpMatchStartBgWorker_RunWorkerCompleted);
            this.tmpMatchStartBgWorker.ProgressChanged += new ProgressChangedEventHandler(this.tmpMatchStartBgWorker_ProgressChanged);
            this.tmpMatchStartBgWorker.WorkerSupportsCancellation = true;
            this.diffBgWorker = new BackgroundWorker[num];
            this.backgroundWorker = new BackgroundWorker[num];
            for (int i = 0; i < num; i++)
            {

                this.diffBgWorker[i] = new BackgroundWorker();
                this.diffBgWorker[i].DoWork += new DoWorkEventHandler(this.diffBgWorker_DoWork);
                this.diffBgWorker[i].RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.diffBgWorker_RunWorkerCompleted);
                this.diffBgWorker[i].ProgressChanged += new ProgressChangedEventHandler(this.diffBgWorker_ProgressChanged);
                this.diffBgWorker[i].WorkerSupportsCancellation = true;
                this.backgroundWorker[i] = new BackgroundWorker();
                this.backgroundWorker[i].DoWork += new DoWorkEventHandler(this.backgroundWorker_DoWork);
                this.backgroundWorker[i].RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
                this.backgroundWorker[i].ProgressChanged += new ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
                this.backgroundWorker[i].WorkerSupportsCancellation = true;
            }
        }
        private void LoadSystemParam(string path)
        {
            SystemSetting.ReadXML<SystemSetting>(out this.systemSetting, path);
            this.configName = this.systemSetting.configName;
            this.selectCameraNo = this.systemSetting.selectCameraNo;
            this.selectModel = this.systemSetting.selectModel;
            this.listviewErrOnly = this.systemSetting.listviewErrOnly;
            this.reverseX = this.systemSetting.reverseX;
            this.reverseY = this.systemSetting.reverseY;
            this.autoTrim = this.systemSetting.autoTrim;
            this.autoCut = this.systemSetting.autoCut;
            this.curImagePath = this.systemSetting.curImagePath;
            this.curCsvPath = this.systemSetting.curCsvPath;
            this.keyStart = this.systemSetting.keyStart;
            this.autoDevW = this.systemSetting.autoDevW;
            this.autoDevH = this.systemSetting.autoDevH;
            this.rotation90 = this.systemSetting.rotation90;
            this.rotation270 = this.systemSetting.rotation270;
            this.bcdEnabled = this.systemSetting.bcdEnabled;
            this.fileWatch = this.systemSetting.fileWatch;
            this.testInterval = this.systemSetting.testInterval;
            this.numberDisp = this.systemSetting.numberDisp;
        }
        private void SetInitCameraProperty()
        {
            this.cameraSetting.exposureMode = 0;
            this.cameraSetting.exposureTime = 0x7530;
            this.cameraSetting.gainMode = 0;
            this.cameraSetting.gain = 0.0;
            this.cameraSetting.whiteLevelMode = 0;
            this.cameraSetting.whiteLevel = 1.45;
            this.cameraSetting.blackLevel = 0.0;
            this.cameraSetting.gamma = 1.0;
            this.cameraSetting.packetSize = 0x5dc;
            this.cameraSetting.deviceName = "";
            this.cameraSetting.serialNumber = "";
            this.cameraSetting.fullsize = true;
            this.cameraSetting.capSize = 0;
            this.cameraSetting.capWidth = 0;
            this.cameraSetting.capHeight = 0;
            this.cameraSetting.capX = 0;
            this.cameraSetting.capY = 0;
            this.cameraSetting.mode = 9;
            this.cameraSetting.widthMax = 0;
            this.cameraSetting.heightMax = 0;
            this.cameraSetting.color = 0;
            this.cameraSetting.reSize = -1;
            CameraSetting.WriteCameraProterty<CameraSetting>(this.cameraSetting, this.cameraPropertyPath);
        }
        private void Save_InitImageAdjust(string path)
        {

            // Start
            imageAdjust = new ImageAdjust(); // quyetpham add 29/3/2018
            // End
            this.imageAdjust.imageOffsetMode = 1;
            this.imageAdjust.imageSeachOffsetX = 100;
            this.imageAdjust.imageSeachOffsetY = 100;
            this.imageAdjust.imageOffsetAngle = 0.0;
            this.imageAdjust.imageOffsetScale = 1.0;
            this.imageAdjust.imageLocationOffsetX = 0;
            this.imageAdjust.imageLocationOffsetY = 0;
            this.imageAdjust.imageContrastEnabled = true;
            this.imageAdjust.imageContrastCoef = 5f;
            this.imageAdjust.imageSmoothEnabled = true;
            this.imageAdjust.imageSmoothType = 3;
            this.imageAdjust.imageSmoothParam1 = 3;
            this.imageAdjust.imageSmoothParam2 = 3;
            this.imageAdjust.imageSmoothParam3 = 3;
            this.imageAdjust.imageSmoothParam4 = 3;
            this.imageAdjust.imageUnsharpEnabled = true;
            this.imageAdjust.imageUnsharpMask = 1f;
            this.imageAdjust.imageBilateralEnabled = true;
            this.imageAdjust.imageBilateralParam1 = 3;
            this.imageAdjust.imageBilateralParam2 = 20;
            this.imageAdjust.imageBilateralParam3 = 1;
            this.imageAdjust.autoSave = false;
            this.imageAdjust.maxLatestImgSave = 100;
            this.imageAdjust.maxNgImgSave = 100;
            this.imageAdjust.maxLogFile = 0x16d;
            this.imageAdjust.maxRefImgSave = 100;
            this.imageAdjust.autoCsvSave = false;
            this.imageAdjust.maxCsvCnt = 10;
            this.imageAdjust.maxCsvFile = 10;
            this.imageAdjust.autoPrint = false;
            this.imageAdjust.printErrOnry = false;
            this.imageAdjust.imageSavePath = this.imageSavePath;
            this.imageAdjust.csvSavePath = this.csvPath;
            this.imageAdjust.modelSavePath = this.modelSavePath;
            this.imageAdjust.soundType = 0;
            this.imageAdjust.monFolderPath = this.monFolderPath;
            this.imageAdjust.monFileExtension = this.monFileExtension;
            this.imageAdjust.bcdEnabled = false;
            this.imageAdjust.bcdLock = false;
            this.imageAdjust.bcdTrigger = false;
            this.imageAdjust.soundPass = true;
            this.imageAdjust.soundNg = true;
            this.imageAdjust.version = 0x7f;
            ImageAdjust.WriteXML<ImageAdjust>(this.imageAdjust, path);
        }

        //private uint IndurstrialCameraCheck()
        //{
        //    this.PortClose();
        //    Thread.Sleep(200);
        //    this.LoadCameraProperty(this.cameraPropertyPath);
        //    this.cameraPropertyChange = true;
        //    uint num = 0;
        //    num = this.InitBaslerCameraNumDevice();
        //    if (num == 0)
        //    {
        //        this.gigeCam = false;
        //        return num;
        //    }
        //    this.gigeCam = true;
        //    return num;
        //}

        //private uint InitBaslerCameraNumDevice()
        //{
        //    uint index = 0;
        //    uint num2 = 0;
        //    uint num3 = 0;
        //    this.baslerDevice = new BASLER_DEVICE[2];
        //    while (true)
        //    {
        //        try
        //        {
        //            Environment.SetEnvironmentVariable("PYLON_GIGE_HEARTBEAT", "3000");
        //            Pylon.Initialize();
        //            num2 = Pylon.EnumerateDevices();
        //            if (num2 == 0)
        //            {
        //                this.hPylonDeviceHandle = null;
        //                this.message = "Camera Not Found";
        //                throw new Exception();
        //            }
        //            if (num2 > 2)
        //            {
        //                num2 = 2;
        //            }
        //            index = num3;
        //            while (index < num2)
        //            {
        //                this.hPylonDeviceHandle = Pylon.CreateDeviceByIndex(index);
        //                PYLON_DEVICE_INFO_HANDLE hDi = Pylon.DeviceGetDeviceInfoHandle(this.hPylonDeviceHandle);
        //                Pylon.DeviceInfoGetNumProperties(hDi);
        //                this.baslerDevice[index].deviceClass = Pylon.DeviceInfoGetPropertyValueByName(hDi, "DeviceClass");
        //                this.baslerDevice[index].modelName = Pylon.DeviceInfoGetPropertyValueByName(hDi, "ModelName");
        //                this.baslerDevice[index].serialNumber = Pylon.DeviceInfoGetPropertyValueByName(hDi, "SerialNumber");
        //                Pylon.DeviceOpen(this.hPylonDeviceHandle, 3);
        //                if (Pylon.DeviceIsOpen(this.hPylonDeviceHandle))
        //                {
        //                    Pylon.DeviceClose(this.hPylonDeviceHandle);
        //                }
        //                Pylon.DestroyDevice(this.hPylonDeviceHandle);
        //                this.hPylonDeviceHandle = null;
        //                index++;
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            this.hPylonDeviceHandle = null;
        //            Pylon.Terminate();
        //        }
        //        if (index >= num2)
        //        {
        //            return num2;
        //        }
        //        if (this.baslerDevice[index].modelName == null)
        //        {
        //            this.baslerDevice[index].deviceClass = "";
        //            this.baslerDevice[index].modelName = "Device";
        //            this.baslerDevice[index].serialNumber = "";
        //        }
        //        if (this.baslerDevice[index].modelName.IndexOf("busy") < 0)
        //        {
        //            this.baslerDevice[index].modelName = this.baslerDevice[index].modelName + " " + this.baslerDevice[index].serialNumber + " busy!";
        //        }
        //        num3 = index + 1;
        //    }
        //}

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            string fullPath = e.FullPath;
            string name = e.Name;
            if (!string.IsNullOrEmpty(fullPath) && !string.IsNullOrEmpty(name))
            {
                this.CurrentDataClear();
                Thread.Sleep(100);
                this.srcImg = null;
                this.srcImg = Cv.LoadImage(fullPath, LoadMode.AnyColor);
                if (this.srcImg != null)
                {
                    this.curImagePath = Path.GetDirectoryName(fullPath);
                    this.srcImgHeight = this.srcImg.Height;
                    this.srcImgWidth = this.srcImg.Width;
                    this.drawRect = new CvRect(0, 0, this.srcImgWidth, this.srcImgHeight);
                    this.pictureBox1.Image = this.srcImg.ToBitmap();
                    this.dstImg = Cv.CloneImage(this.srcImg);
                    this.fileOpFlg = true;
                    this.button1.Text = "Capture";
                    if (this.srcImg != null)
                    {
                        this.dstImg = Cv.CloneImage(this.srcImg);
                        if (this.dstImg != null)
                        {
                            this.buttonteaching.Enabled = true;
                            this.button3.Enabled = true;
                        }
                    }
                    if (this.tempNum > 0)
                    {
                        this.button2.Enabled = true;
                    }
                    //this.button4.Enabled = true;
                    this.capture = false;
                    //this.label1.Text = string.Concat(new object[] { "IMAGE FILE : ", this.srcImg.Width, " x ", this.srcImg.Height });
                    if ((!string.IsNullOrEmpty(this.comboBox1.Text) && !this.measureFlg) && !this.teachFlg)
                    {
                        this.MeasurementClick();
                    }
                }
            }
        }





        //private void FileWatcher(bool en)
        //{
        //    if (!en)
        //    {
        //       // this.button38.BackgroundImage = Resources.folder;
        //       // this.button38.ForeColor = Color.WhiteSmoke;
        //        this.fileSystemWatcher1.EnableRaisingEvents = false;
        //        return;
        //    }
        //  //  this.button38.BackgroundImage = Resources.folderC;
        //  //  this.button38.ForeColor = Color.Cyan;
        //    this.fileSystemWatcher1.Path = this.monFolderPath;
        //    string str = "";
        //    string monFileExtension = this.monFileExtension;
        //    if (monFileExtension != null)
        //    {
        //        if (!(monFileExtension == "JPEG"))
        //        {
        //            if (monFileExtension == "PNG")
        //            {
        //                str = "*.png";
        //                goto Label_008E;
        //            }
        //            if (monFileExtension == "TIFF")
        //            {
        //                str = "*.tif";
        //                goto Label_008E;
        //            }
        //        }
        //        else
        //        {
        //            str = "*.jpg";
        //            goto Label_008E;
        //        }
        //    }
        //    str = "*.bmp";
        //    Label_008E:
        //    this.fileSystemWatcher1.Filter = str;
        //    this.fileSystemWatcher1.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.FileName;
        //    this.fileSystemWatcher1.EnableRaisingEvents = true;
        //}

        private int WebCameraOpen(int num)
        {
            bool flag = false;
            if (Cursor.Current != Cursors.WaitCursor)
            {
                flag = true;
                if (Cursor.Current != Cursors.WaitCursor)
                {
                    Cursor.Current = Cursors.WaitCursor;
                }
                base.Enabled = false;
            }
            this.WebCameraInit();
            if (flag)
            {
                base.Enabled = true;
                if (Cursor.Current != Cursors.Default)
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            return 0;
        }

        private void WebCameraInit()
        {
            for (int i = 0; i < 8; i++)
            {
                Cv.ReleaseCapture(this.usbCamCaptures[i]);
            }
            this.usbCamCaptures = new CvCapture[8];
            this.deviceNames = new string[8];
            this.devicePaths = new string[8];
            this.theDevices = new IBaseFilter[8];
            this.usbcamCnt = 0;
            this.usbCam = false;
        }

        public bool CheckComcontrol()
        {
            try
            {
                this.ComControl.PortName = "COM7";
                this.ComControl.Open();
            }
            catch (Exception)
            {
                return false;
                throw;

            }
            return true;
        }
        public bool CheckCamera()
        {
            try
            {
                if (this.cam == null)
                {

                    this.cam = CvCapture.FromCamera(0);

                    //this.cam.FrameWidth = 1280;
                    // this.cam.FrameHeight = 1024;

                    this.cam.SetCaptureProperty(CaptureProperty.FrameWidth, 1280);
                    this.cam.SetCaptureProperty(CaptureProperty.FrameHeight, 1024);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Camera not exist.", "Vison Inspection [contact cuongadn90@gmail.com]", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
                throw;

            }

            return true;
        }
        static List<USBDeviceInfo> GetUSBDevices()
        {
            List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

            ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
                collection = searcher.Get();

            foreach (var device in collection)
            {
                device.GetPropertyValue("Base Container Id");
                //devices.Add(new USBDeviceInfo(
                //(string)device.GetPropertyValue("DeviceID"),
                //(string)device.GetPropertyValue("PNPDeviceID"),
                //(string)device.GetPropertyValue("Description"),
                //(string)device.GetPropertyValue("Name")
                //));
            }

            collection.Dispose();
            return devices;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            //if (this.keyData != (SHA1(GetHDDSerial().Trim() + "Copyrightcuongadn90")))
            //{
            //    MessageBox.Show("License not valid. Please contact service!", "Vision Inspect [cuongadn90@gmail.com]",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    Application.Exit();
            //}

            this.Text = "Vision Inspect Version: " + Application.ProductVersion;
            this.srcImgWidth = this.pictureBox1.Width;
            this.srcImgHeight = this.pictureBox1.Height;
            this.timer1.Enabled = false;
            //this.timer2.Enabled = false;
            //this.timer3.Enabled = false;

            this.sw = new Stopwatch();
            this.swt = new Stopwatch();
            this.sw_delay = new Stopwatch();
            this.sw_thTime = new Stopwatch();
            this.sw_timecode = new Stopwatch();
            this.swt = new Stopwatch();
            //base.SuspendLayout();
            base.Visible = false;
            //Application.DoEvents();
            if (CheckCamera() == true)
            {
                Process command = new Process();
                ProcessStartInfo commandInfo = new ProcessStartInfo("cmd.exe");
                commandInfo.WorkingDirectory = @"C:\Program Files\Dino-Lite DOS Control";
                commandInfo.UseShellExecute = false;
                commandInfo.RedirectStandardInput = true;
                commandInfo.RedirectStandardOutput = true;
                commandInfo.CreateNoWindow = true;
                command.StartInfo = commandInfo;
                command.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                command.Start();
                command.StandardInput.WriteLine("DN_DS_Ctrl.exe LED off -CAM0");
                button1.Enabled = true;
                this.camok = true;
                command.Close();
            }
            else
            {
                button1.Enabled = false;
                this.camok = false;
                Application.Exit();
            }
            this.comok = CheckComcontrol();
            if (!this.comok)
            {
                MessageBox.Show("Com 7 not connect", "Vision Inspect Error: cuongadn90@gmail.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                this.timer3.Enabled = true;
            }

            string str2 = this.stCurrentDir + @"\model\";
            this.configPath = this.stCurrentDir + @"\conf\config.xml";
            configPathG = this.configPath;
            this.cameraPropertyPath = this.stCurrentDir + @"\conf\camprt.xml";
            this.presetPath = this.stCurrentDir + @"\preset\";
            // this.ioAssignPath = this.stCurrentDir + @"\conf\ioassing.xml";
            this.imgAdjPath = this.stCurrentDir + @"\conf\imgadj.xml";
            this.logFilePath = this.stCurrentDir + @"\log\";
            this.lotLogPath = this.stCurrentDir + @"\add\";
            this.imageSavePath = this.stCurrentDir + @"\image";
            this.srcImgPath = this.imageSavePath + @"\pass\";
            this.ngImgPath = this.imageSavePath + @"\ng\";
            this.refImgPath = this.imageSavePath + @"\reference\";
            this.dataPath = this.stCurrentDir + @"\data\";
            this.csvPath = this.stCurrentDir + @"\data\csv\";
            this.modelSavePath = this.stCurrentDir + @"\model\";
            this.comPortPath = this.stCurrentDir + @"\conf\comport.xml";
            this.dioPortPath = this.stCurrentDir + @"\conf\dioport.xml";
            this.monFolderPath = this.stCurrentDir + @"\watch\";
            this.DataClear();

            InitBgWorker(1);
            this.tgtRect = new CvRect[0x80];
            this.tmpMatchResult = new TempMatchResult[0x80];
            this.bkgFlg = new bool[0x80];
            this.diffResult = new DiffResult[0x80];
            this.compFlg = new bool[0x80];
            this.difbkgFlg = new bool[0x80];
            this.diffDispData = new DiffDispData();
            this.diffDispBkgFlg = 0;
            this.measurementsMatchRate = new double[0x80];
            this.measurementsDiffArea = new double[0x80];
            this.svDstPnt = new System.Drawing.Point[4];

            this.drawRect = new CvRect(0, 0, 0, 0);
            this.numericUpDown3.Minimum = this.trackBar1.Minimum = 1;
            this.numericUpDown3.Maximum = this.trackBar1.Maximum = 0xff;
            this.numericUpDown4.Minimum = this.trackBar2.Minimum = 1;
            this.numericUpDown4.Maximum = this.trackBar2.Maximum = 0xff;
            this.numericUpDown5.Minimum = this.trackBar3.Minimum = 1;
            this.numericUpDown5.Maximum = this.trackBar3.Maximum = 0xff;
            this.numericUpDown6.Minimum = this.trackBar4.Minimum = 1;
            this.numericUpDown6.Maximum = this.trackBar4.Maximum = 0xff;
            this.numericUpDown7.Minimum = this.trackBar6.Minimum = 0;
            this.numericUpDown7.Maximum = this.trackBar6.Maximum = 0x2faf080;
            this.numericUpDown8.Minimum = this.trackBar7.Minimum = 0;
            this.numericUpDown8.Maximum = this.trackBar7.Maximum = 0x5f5e100;
            this.numericUpDown9.Minimum = this.trackBar5.Minimum = 1;
            this.numericUpDown9.Maximum = this.trackBar5.Maximum = 100;
            this.numericUpDown10.Minimum = this.trackBar8.Minimum = 0;
            this.trackBar8.Maximum = 0x2710;
            this.numericUpDown10.Maximum = 100M;
            //this.pictureBox1.Controls.Add(this.label1);
            //this.label1.Location = new System.Drawing.Point(0, 0);
            //this.pictureBox1.Controls.Add(this.label13);
            //this.label13.Location = new System.Drawing.Point(this.label1.Location.X, this.label1.Location.Y + this.label1.Height);
            //this.pictureBox1.Controls.Add(this.label5);
            //this.label5.Location = new System.Drawing.Point(this.label13.Location.X, this.label13.Location.Y + this.label13.Height);
            //this.pictureBox1.Controls.Add(this.label7);
            //this.label7.Location = new System.Drawing.Point(this.label5.Location.X, this.label5.Location.Y + this.label5.Height);
            //this.pictureBox1.Controls.Add(this.label9);
            //this.label9.Location = new System.Drawing.Point(this.label7.Location.X, this.label7.Location.Y + this.label7.Height);
            //this.pictureBox1.Controls.Add(this.label83);
            //this.label83.Location = new System.Drawing.Point(this.label13.Location.X + this.label13.Width, this.label13.Location.Y);
            //this.label1.Text = "IMAGE SOURCE...";
            this.label13.Text = "Image: Width x Height:";
            //this.label5.Text = "GAIN    :";
            //this.label7.Text = "WHITE LV:";
            //this.label9.Text = "BLACK LV:";
            //this.label83.Text = "LOCATION OFFSET:X=0, Y=0";
            this.pictureBox2.Controls.Add(this.label2);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Text = "No.1";
            this.pictureBox2.Controls.Add(this.label41);
            this.label41.Location = new System.Drawing.Point(0, this.label2.Location.Y + this.label2.Height);
            this.label41.Text = "X:";
            this.pictureBox2.Controls.Add(this.label42);
            this.label42.Location = new System.Drawing.Point(0, this.label41.Location.Y + this.label41.Height);
            this.label42.Text = "Y:";
            this.pictureBox2.Controls.Add(this.label44);
            this.label44.Location = new System.Drawing.Point(0, this.label42.Location.Y + this.label42.Height);
            this.label44.Text = "WIDTH :";
            this.pictureBox2.Controls.Add(this.label45);
            this.label45.Location = new System.Drawing.Point(0, this.label44.Location.Y + this.label44.Height);
            this.label45.Text = "HEIGHT:";
            this.pictureBox2.Controls.Add(this.label46);
            this.label46.Location = new System.Drawing.Point(this.label41.Location.X + this.label41.Width, this.label41.Location.Y);
            this.label46.Text = "0";
            this.pictureBox2.Controls.Add(this.label47);
            this.label47.Location = new System.Drawing.Point(this.label46.Location.X, this.label42.Location.Y);
            this.label47.Text = "0";
            this.pictureBox2.Controls.Add(this.label48);
            this.label48.Location = new System.Drawing.Point(this.label44.Location.X + this.label44.Width, this.label44.Location.Y);
            this.label48.Text = "0";
            this.pictureBox2.Controls.Add(this.label49);
            this.label49.Location = new System.Drawing.Point(this.label48.Location.X, this.label45.Location.Y);
            this.label49.Text = "0";
            Color lightGray = Color.LightGray;
            //this.pictureBox6.Controls.Add(this.label72);
            Color redcolor = Color.Red;
            //this.label72.Location = new System.Drawing.Point(0, 0);
            this.label72.ForeColor = redcolor;
            this.label72.Text = "No.";
            // this.pictureBox6.Controls.Add(this.label73);
            this.label73.Location = new System.Drawing.Point(this.label72.Location.X + this.label72.Width, this.label72.Location.Y);
            this.label73.ForeColor = redcolor;
            this.label73.Text = "0";
            //this.pictureBox6.Controls.Add(this.label56);
            this.label56.Location = new System.Drawing.Point(0, this.label72.Location.Y + this.label72.Height);
            this.label56.ForeColor = redcolor;
            this.label56.Text = "Match[%]:";
            //this.pictureBox6.Controls.Add(this.label57);
            this.label57.Location = new System.Drawing.Point(0, this.label56.Location.Y + this.label56.Height);
            this.label57.ForeColor = redcolor;
            this.label57.Text = "Diff [%]:";
            //this.pictureBox6.Controls.Add(this.label58);
            this.label58.Location = new System.Drawing.Point(this.label56.Location.X + this.label56.Width, this.label56.Location.Y);
            this.label58.ForeColor = redcolor;
            this.label58.Text = "0";
            //this.pictureBox6.Controls.Add(this.label59);
            this.label59.Location = new System.Drawing.Point(this.label58.Location.X, this.label57.Location.Y);
            this.label59.ForeColor = redcolor;
            this.label59.Text = "0.00";
            //this.pictureBox6.Controls.Add(this.label64);
            this.label64.Location = new System.Drawing.Point(this.label59.Location.X, this.label59.Location.Y + this.label59.Height);
            this.label64.ForeColor = redcolor;
            this.label64.Text = "0";
            //this.pictureBox6.Controls.Add(this.label65);
            this.label65.Location = new System.Drawing.Point(this.label57.Location.X, this.label57.Location.Y + this.label57.Height);
            this.label65.ForeColor = redcolor;
            this.label65.Text = "Diff[pix]:";
            //this.pictureBox6.Controls.Add(this.label66);
            this.label66.Location = new System.Drawing.Point(this.label65.Location.X, this.label65.Location.Y + this.label65.Height);
            this.label66.ForeColor = redcolor;
            this.label66.Text = "Angle[deg]:";
            //this.pictureBox6.Controls.Add(this.label67);
            this.label67.Location = new System.Drawing.Point(this.label66.Location.X + this.label66.Width, this.label66.Location.Y);
            this.label67.ForeColor = redcolor;
            this.label67.Text = "0.00";
            //this.pictureBox6.Controls.Add(this.label88);
            this.label88.Location = new System.Drawing.Point(this.label66.Location.X, this.label66.Location.Y + this.label66.Height);
            this.label88.ForeColor = redcolor;
            this.label88.Text = " ";
            //this.pictureBox6.Controls.Add(this.label89);
            this.label89.Location = new System.Drawing.Point(this.label88.Location.X, this.label88.Location.Y + this.label88.Height);
            this.label89.ForeColor = redcolor;
            this.label89.Text = " ";
            //this.pictureBox6.Controls.Add(this.label90);
            this.label90.Location = new System.Drawing.Point(this.label89.Location.X, this.label89.Location.Y + this.label89.Height);
            this.label90.ForeColor = redcolor;
            this.label90.Text = " ";
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            //this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            //this.pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            // this.groupBox20.Height = (((this.button7.Location.Y + this.button7.Height) + 5) + this.button5.Height) + 5; // button 5 cho phep hien thi groupbox 20 thong tin cai dat

            // this.panel1.Visible = false;
            //this.button1.Enabled = false;
            //this.button2.Enabled = false;
            //this.button3.Enabled = false;
            //this.button4.Enabled = true;
            //this.buttonteaching.Enabled = false;
            //this.button17.Enabled = false;
            //this.button14.Enabled = false;
            //this.button24.Enabled = false;
            //this.button25.Enabled = false;
            //this.button31.Enabled = false;
            //this.button31.BackgroundImage = Color.Green;
            //this.button32.Enabled = false;
            //this.button32.BackgroundImage = Resources.rotationGL;
            //this.button34.Text = "◀";
            // this.panel4.Width = this.button34.Width + this.button34.Location.X;
            //  this.panel4.Location = new System.Drawing.Point((this.pictureBox1.Location.X + this.pictureBox1.Width) - this.panel4.Width, this.pictureBox1.Location.Y);
            //  this.panel4.BackColor = Color.DarkGray;
            //  this.button35.Text = "◀";
            //  this.panel5.Width = this.button35.Width + this.button35.Location.X;
            //   this.panel5.Location = new System.Drawing.Point((this.pictureBox1.Location.X + this.pictureBox1.Width) - this.panel5.Width, this.pictureBox1.Location.Y + this.panel4.Height);
            //   this.panel5.BackColor = Color.DarkGray;
            //   this.panel2.Size = this.panel4.Size;
            //this.panel2.Location = new System.Drawing.Point((this.pictureBox1.Location.X + this.pictureBox1.Width) - this.panel2.Width, (this.pictureBox1.Location.Y + this.pictureBox1.Height) - this.panel2.Height);
            //    this.button22.Width = this.button34.Width;
            //    this.button22.Height = this.button34.Height;
            //  this.panel2Width = this.panel2.Width;
            //  this.panel2Height = this.panel2.Height;
            //   this.button23.Enabled = false;
            //  this.button23.Visible = false;
            this.LoadInitModelData();
            this.listView1.View = View.Details;
            this.listView1.Items.Clear();
            this.listView1.Columns.Clear();
            ColumnHeader header = new ColumnHeader
            {
                Text = "No",
                Width = 0x20
            };
            this.listView1.Columns.Add(header);
            ColumnHeader header2 = new ColumnHeader
            {
                Text = "Name",
                Width = 0x9e
            };
            this.listView1.Columns.Add(header2);
            ColumnHeader header3 = new ColumnHeader
            {
                Text = "Match%",
                Width = 0x3a
            };
            this.listView1.Columns.Add(header3);
            ColumnHeader header4 = new ColumnHeader
            {
                Text = "Diff",
                Width = 0x30
            };
            this.listView1.Columns.Add(header4);
            ColumnHeader header5 = new ColumnHeader
            {
                Text = "Result",
                Width = 0x30
            };
            this.listView1.Columns.Add(header5);
            base.MinimizeBox = true;
            base.MaximizeBox = true;
            base.ControlBox = true;
            //base.WindowState = FormWindowState.Maximized;
            this.groupBox20.Visible = true;
            // this.dioToolStripMenuItem.Visible = true;
            //this.serialToolStripMenuItem.Visible = true;
            //this.label91.Visible = true;
            //this.label92.Visible = true;
            //this.label94.Visible = true;
            this.label88.Visible = false;
            this.label89.Visible = false;
            this.label90.Visible = false;
            // this.checkBox5.Visible = false;// check box doc OCR
            //this.button9.Visible = true;
            //this.panel5.Visible = true;
            //this.panel5.Enabled = true;
            //this.panel4.Visible = true;
            //this.panel4.Enabled = true;
            //this.button38.Visible = true;
            //this.panel5.Visible = false;
            //this.panel5.Enabled = false;
            //this.panel4.Visible = false;
            //this.panel4.Enabled = false;
            //this.button38.Visible = false;

            if (!Directory.Exists(this.stCurrentDir + @"\conf\"))
            {
                Directory.CreateDirectory(this.stCurrentDir + @"\conf\");
            }
            if (!Directory.Exists(this.presetPath))
            {
                Directory.CreateDirectory(this.presetPath);
            }
            if (!Directory.Exists(this.srcImgPath))
            {
                Directory.CreateDirectory(this.srcImgPath);
            }
            if (!Directory.Exists(this.ngImgPath))
            {
                Directory.CreateDirectory(this.ngImgPath);
            }
            if (!Directory.Exists(this.refImgPath))
            {
                Directory.CreateDirectory(this.refImgPath);
            }
            //if (!Directory.Exists(this.dataPath))
            //{
            //    Directory.CreateDirectory(this.dataPath);
            //}
            //if (!Directory.Exists(this.csvPath))
            //{
            //    Directory.CreateDirectory(this.csvPath);
            //}
            if (!Directory.Exists(this.modelSavePath))
            {
                Directory.CreateDirectory(this.modelSavePath);
            }
            if (!Directory.Exists(this.monFolderPath))
            {
                Directory.CreateDirectory(this.monFolderPath);
            }
            string path = this.presetPath + "preset1.xml";
            if (!File.Exists(path))
            {
                this.SaveInitPresetROUGH(path);
            }
            this.button26.Text = this.LoadPreset(1);
            path = this.presetPath + "preset2.xml";
            if (!File.Exists(path))
            {
                this.SaveInitPresetNORMAL(path);
            }
            this.button27.Text = this.LoadPreset(2);
            path = this.presetPath + "preset3.xml";
            if (!File.Exists(path))
            {
                this.SaveInitPresetFINE(path);
            }
            this.button28.Text = this.LoadPreset(3);
            path = this.presetPath + "preset4.xml";
            if (!File.Exists(path))
            {
                this.SaveInitPresetCOLOR(path);
            }
            this.button29.Text = this.LoadPreset(4);
            if (!File.Exists(this.configPath))
            {
                this.SaveInitialSystemParam();
            }
            this.LoadSystemParam(this.configPath);
            //if (!File.Exists(this.cameraPropertyPath))
            //{
            //    this.SetInitCameraProperty();
            //}
            // this.LoadCameraProperty(this.cameraPropertyPath);
            //this.cameraPropertyChange = true;
            this.checkBox3.Checked = this.listviewErrOnly;
            //this.checkBox4.Checked = this.keyStart;
            //this.checkBox7.Checked = this.bcdEnabled;
            //if (this.checkBox7.Checked)
            //{
            //    this.textBox3.Visible = true;
            //}
            //else
            //{
            //    this.textBox3.Visible = false;
            //}
            this.checkBox10.Checked = this.numberDisp;
            //if (!File.Exists(this.comPortPath))
            //{
            //    this.Init_comPortConfig(this.comPortPath);
            //}
            //this.Load_ComPortConfig(this.comPortPath);
            //if (!File.Exists(this.dioPortPath))
            //{
            //    this.Init_dioPortAssign(this.dioPortPath);
            //}
            //this.Load_DioPortAssign(this.dioPortPath);
            //if (this.autoTrim)
            //{
            //    this.button6.ForeColor = Color.Cyan;
            //}
            //else
            //{
            //    this.button6.ForeColor = Color.WhiteSmoke;
            //}
            //if (this.autoCut)
            //{
            //    this.button9.ForeColor = Color.Cyan;
            //    this.button35.ForeColor = Color.Cyan;
            //}
            //else
            //{
            //    this.button9.ForeColor = Color.WhiteSmoke;
            //    this.button35.ForeColor = Color.WhiteSmoke;
            //}
            if ((this.autoDevW * this.autoDevH) > 0x80)
            {
                this.autoDevH = this.autoDevW = 1;
            }
            this.numericUpDown22.Value = this.autoDevW;
            this.numericUpDown23.Value = this.autoDevH;
            this.LoadModelData(this.modelSavePath);
            //if (!File.Exists(this.ioAssignPath))
            //{
            //    this.SaveInitIoAssign();
            //}
            //this.Load_IO_Assign(this.ioAssignPath);
            if (!File.Exists(this.imgAdjPath))
            {
                this.Save_InitImageAdjust(this.imgAdjPath);
            }
            this.Load_ImageAdjust(this.imgAdjPath);
            // ownedForm.ProcessMessage = "Check. camera connection... ";
            this.exposureTime = 0x2710;
            this.packetSize = 0x5dc;
            //richTextBox10.Text += "Connection check of industrial camera.                                                                                                                                                                                                                                                                                                 /";
            //this.baslercamCnt = (int)this.IndurstrialCameraCheck();
            //richTextBox10.Text += "Connection check of Web camera. ";
            // this.WebCameraOpen(this.selectWebCamNumber);
            //richTextBox10.Text += "Camera open... ";
            //this.MakeDeviceMenu();
            //if (this.gigeCam || this.usbCam)
            //{
            //    this.button1.Enabled = true;
            //    this.label1.Text = "Camera View";
            //}


            if ((this.selectModel == "") || ((this.selectModel != "") && (this.comboBox1.FindString(this.selectModel) < 0)))
            {
                this.comboBox1.SelectedIndex = 0;
            }
            else
            {
                this.comboBox1.Text = this.selectModel;
            }
            //this.FileWatcher(this.fileWatch);
            //this.richTextBox1.Text = "dummy";
            //this.richTextBox1.SaveFile("dummy", RichTextBoxStreamType.PlainText);
            // File.Delete("dummy");
            // this.richTextBox1.Text = "";
            /// this.richTextBoxBuffer = "";
            //if (this.comPortConfig.enabled)
            //{
            //    if (((this.comPortConfig.serialMode == -1) || (this.comPortConfig.serialMode == 0)) || (this.comPortConfig.serialMode == 1))
            //    {
            //        ownedForm.ProcessMessage = "Check. serial port... ";
            //        if (this.SerialPort_Open() > 0)
            //        {
            //            ownedForm.ProcessMessage = "COM port open. ";
            //            string str4 = "";
            //            int index = this.portName.IndexOf("(COM");
            //            int num3 = this.portName.IndexOf(")") - (index + 4);
            //            if (num3 > 0)
            //            {
            //                str4 = this.portName.Substring(index + 1, num3 + 3);
            //            }
            //            this.label91.Text = str4 + " port open.";
            //            this.label92.Text = "RX[]";
            //            this.label94.Text = "TX[]";
            //        }
            //        else
            //        {
            //            this.comPortConfig.enabled = false;
            //            this.label91.Text = "";
            //            this.label92.Text = "";
            //            this.label94.Text = "";
            //        }
            //    }
            //    else if (this.comPortConfig.serialMode == 2)
            //    {
            //        ownedForm.ProcessMessage = "Check. UDP port... ";
            //        if (this.udpClient == null)
            //        {
            //            try
            //            {
            //                IPEndPoint localEP = new IPEndPoint(IPAddress.Any, int.Parse(this.comPortConfig.rcvPortno));
            //                this.udpClient = new UdpClient(localEP);
            //                this.label91.Text = this.comPortConfig.rcvPortno + " port open.";
            //                this.label92.Text = "RX[]";
            //                this.label94.Text = "TX[]";
            //                this.udpClient.BeginReceive(new AsyncCallback(this.UDPReceiveCallback), this.udpClient);
            //            }
            //            catch
            //            {
            //                ownedForm.ProcessMessage = "Not connect. UDP port.";
            //                this.label91.Text = "Not connect.";
            //                this.label92.Text = "";
            //                this.label94.Text = "";
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    this.label91.Text = "";
            //    this.label92.Text = "";
            //    this.label94.Text = "";
            //}


            //richTextBox10.Text += "Check. Digital I/O teminal... ";

            //richTextBox10.Text += "Loading ... ";
            //if (((this.selectCam == 0) && this.gigeCam) && (this.hPylonDeviceHandle != null))
            //{
            //    this.DumyCapture();
            //}
            //Thread.Sleep(500);
            //base.ResumeLayout();
            base.Show();

        }
        private void LoadModelData(string path)
        {
            this.comboBox1.Items.Clear();
            this.comboBox1.BeginUpdate();
            this.comboBox1.Items.Add("");
            if (Directory.Exists(path))
            {
                string[] strArray = Directory.GetFiles(path, "*.csv", SearchOption.TopDirectoryOnly);
                for (int i = 0; i < strArray.Length; i++)
                {
                    this.comboBox1.Items.Add(Path.GetFileNameWithoutExtension(strArray[i]));
                }
            }
            else
            {
                Directory.CreateDirectory(path);
            }
            this.comboBox1.EndUpdate();
        }

        private void SaveInitPresetROUGH(string path)
        {
            this.preset.version = 0x7c;
            this.preset.name = "ROUGH";
            this.preset.inspectEnabled = true;
            this.preset.searchPositionRangeX = 0x19;
            this.preset.searchPositionRangeY = 0x19;
            this.preset.searchAngleRange = 1.0;
            this.preset.searchAngleStep = 0.2;
            this.preset.searchScaleMin = 1.0;
            this.preset.searchScaleMax = 1.0;
            this.preset.searchScaleStep = 1.0;
            this.preset.ptmSearchMode = 0;
            this.preset.ptmBinaryThreshold = 0x7f;
            this.preset.averageCount = 0;
            this.preset.smoothParam1 = 3;
            this.preset.smoothParam2 = 3;
            this.preset.smoothParam3 = 20;
            this.preset.smoothParam4 = 1;
            this.preset.unsharpMask = 1f;
            this.preset.contrastCoef = 4f;
            this.preset.erodNum = 1;
            this.preset.dilaNum = 0;
            this.preset.binaryAllThreshold = 0x37;
            this.preset.binaryRedThreshold = 0x37;
            this.preset.binaryGreenThreshold = 0x37;
            this.preset.binaryBlueThreshold = 0x37;
            this.preset.blobMinAreaThreshold = 150;
            this.preset.blobMaxAreaThreshold = 0x30d40;
            this.preset.matchRateThreshold = 92.0;
            this.preset.diffThreshold = 200;
            this.preset.matchRateNG_UnderOver = 0;
            this.preset.diffNG_UnderOver = 1;
            XmlSerializer serializer = new XmlSerializer(typeof(Preset));
            FileStream stream = new FileStream(path, FileMode.Create);
            serializer.Serialize((Stream)stream, this.preset);
            stream.Close();
        }
        private void SaveInitPresetNORMAL(string path)
        {
            this.preset.version = 0x7c;
            this.preset.name = "NORMAL";
            this.preset.inspectEnabled = true;
            this.preset.searchPositionRangeX = 20;
            this.preset.searchPositionRangeY = 20;
            this.preset.searchAngleRange = 1.0;
            this.preset.searchAngleStep = 0.2;
            this.preset.searchScaleMin = 1.0;
            this.preset.searchScaleMax = 1.0;
            this.preset.searchScaleStep = 1.0;
            this.preset.ptmSearchMode = 0;
            this.preset.ptmBinaryThreshold = 0x7f;
            this.preset.averageCount = 0;
            this.preset.smoothParam1 = 3;
            this.preset.smoothParam2 = 3;
            this.preset.smoothParam3 = 20;
            this.preset.smoothParam4 = 1;
            this.preset.unsharpMask = 1.1f;
            this.preset.contrastCoef = 5f;
            this.preset.erodNum = 1;
            this.preset.dilaNum = 1;
            this.preset.binaryAllThreshold = 0x2d;
            this.preset.binaryRedThreshold = 0x2d;
            this.preset.binaryGreenThreshold = 0x2d;
            this.preset.binaryBlueThreshold = 0x2d;
            this.preset.blobMinAreaThreshold = 100;
            this.preset.blobMaxAreaThreshold = 0x30d40;
            this.preset.matchRateThreshold = 95.0;
            this.preset.diffThreshold = 200;
            this.preset.matchRateNG_UnderOver = 0;
            this.preset.diffNG_UnderOver = 1;
            XmlSerializer serializer = new XmlSerializer(typeof(Preset));
            FileStream stream = new FileStream(path, FileMode.Create);
            serializer.Serialize((Stream)stream, this.preset);
            stream.Close();
        }
        private void SaveInitPresetFINE(string path)
        {
            this.preset.version = 0x7c;
            this.preset.name = "FINE";
            this.preset.inspectEnabled = true;
            this.preset.searchPositionRangeX = 15;
            this.preset.searchPositionRangeY = 15;
            this.preset.searchAngleRange = 1.0;
            this.preset.searchAngleStep = 0.2;
            this.preset.searchScaleMin = 1.0;
            this.preset.searchScaleMax = 1.0;
            this.preset.searchScaleStep = 1.0;
            this.preset.ptmSearchMode = 0;
            this.preset.ptmBinaryThreshold = 0x7f;
            this.preset.averageCount = 0;
            this.preset.smoothParam1 = 3;
            this.preset.smoothParam2 = 3;
            this.preset.smoothParam3 = 20;
            this.preset.smoothParam4 = 1;
            this.preset.unsharpMask = 1.1f;
            this.preset.contrastCoef = 5.5f;
            this.preset.erodNum = 1;
            this.preset.dilaNum = 1;
            this.preset.binaryAllThreshold = 0x23;
            this.preset.binaryRedThreshold = 0x23;
            this.preset.binaryGreenThreshold = 0x23;
            this.preset.binaryBlueThreshold = 0x23;
            this.preset.blobMinAreaThreshold = 30;
            this.preset.blobMaxAreaThreshold = 0x30d40;
            this.preset.matchRateThreshold = 95.0;
            this.preset.diffThreshold = 200;
            this.preset.matchRateNG_UnderOver = 0;
            this.preset.diffNG_UnderOver = 1;
            XmlSerializer serializer = new XmlSerializer(typeof(Preset));
            FileStream stream = new FileStream(path, FileMode.Create);
            serializer.Serialize((Stream)stream, this.preset);
            stream.Close();
        }
        private void SaveInitPresetCOLOR(string path)
        {
            this.preset.version = 0x7c;
            this.preset.name = "COLOR";
            this.preset.inspectEnabled = true;
            this.preset.searchPositionRangeX = 10;
            this.preset.searchPositionRangeY = 10;
            this.preset.searchAngleRange = 1.0;
            this.preset.searchAngleStep = 0.2;
            this.preset.searchScaleMin = 1.0;
            this.preset.searchScaleMax = 1.0;
            this.preset.searchScaleStep = 1.0;
            this.preset.ptmSearchMode = 0;
            this.preset.ptmBinaryThreshold = 0x7f;
            this.preset.averageCount = 0;
            this.preset.smoothParam1 = 3;
            this.preset.smoothParam2 = 3;
            this.preset.smoothParam3 = 20;
            this.preset.smoothParam4 = 1;
            this.preset.unsharpMask = 1f;
            this.preset.contrastCoef = 8f;
            this.preset.erodNum = 1;
            this.preset.dilaNum = 1;
            this.preset.binaryAllThreshold = 30;
            this.preset.binaryRedThreshold = 30;
            this.preset.binaryGreenThreshold = 30;
            this.preset.binaryBlueThreshold = 30;
            this.preset.blobMinAreaThreshold = 10;
            this.preset.blobMaxAreaThreshold = 0x30d40;
            this.preset.matchRateThreshold = 96.0;
            this.preset.diffThreshold = 200;
            this.preset.matchRateNG_UnderOver = 0;
            this.preset.diffNG_UnderOver = 1;
            XmlSerializer serializer = new XmlSerializer(typeof(Preset));
            FileStream stream = new FileStream(path, FileMode.Create);
            serializer.Serialize((Stream)stream, this.preset);
            stream.Close();
        }
        private void SaveInitialSystemParam()
        {
            this.systemSetting.configName = "config.xml";
            this.systemSetting.selectCameraNo = 0;
            this.systemSetting.selectModel = "";
            this.systemSetting.listviewErrOnly = false;
            this.systemSetting.reverseX = false;
            this.systemSetting.reverseY = false;
            this.systemSetting.password0 = "";
            this.systemSetting.password1 = "";
            this.systemSetting.autoTrim = false;
            this.systemSetting.autoCut = false;
            this.systemSetting.curImagePath = this.stCurrentDir + @"\data";
            this.systemSetting.curCsvPath = this.stCurrentDir + @"\data\csv";
            this.systemSetting.keyStart = false;
            this.systemSetting.autoDevW = 1;
            this.systemSetting.autoDevH = 1;
            this.systemSetting.rotation90 = false;
            this.systemSetting.rotation270 = false;
            this.systemSetting.bcdEnabled = false;
            this.systemSetting.fileWatch = false;
            this.systemSetting.testInterval = 0xbb8;
            this.systemSetting.numberDisp = false;
            SystemSetting.WriteXML<SystemSetting>(this.systemSetting, this.configPath);
        }


        private void CurrentDataClear()
        {

            //if (this.MyMessageBoard != null)
            //{
            //    this.MyMessageBoard.Dispose();
            //}
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            // this.button4.Enabled = false;
            this.button21.Enabled = false;
            this.buttonteaching.Enabled = false;
            this.button17.Enabled = false;
            this.pictureBox1.Image = null;
            //this.pictureBox3.Image = null;
            this.pictureBox4.Image = null;
            this.pictureBox6.Image = null;
            this.pictureBox7.Image = null;
            //this.pictureBox8.Image = null;
            //this.pictureBox9.Image = null;
            this.drawRect = new CvRect(0, 0, this.srcImgWidth, this.srcImgHeight);
            this.label13.Text = "Image:Width = 0,Height = 0";
            this.clickPoint = new System.Drawing.Point(0, 0);
            this.sizePicStartPosition = new System.Drawing.Point(0, 0);
            this.srcScale = 1.0;
            this.rszImg = null;
            this.s_rect = new Rectangle(0, 0, 0, 0);
            this.r_rect = new Rectangle(0, 0, 0, 0);
            ms_rectList = new Rectangle[0x81];
            mr_rectList = new Rectangle[0x81];
            this.retry = new int[0x80];
            this.measureNum = 0;
            this.dstdifimg = null;
            this.dstBinDifimg = null;
            this.diffImgFull = null;
            this.diffImageFlg = false;
            this.diffResult = null;
            this.xyChm = new CvPoint2D64f(0.0, 0.0);
            this.rgb_B = 0;
            this.rgb_G = 0;
            this.rgb_R = 0;
            this.listView1.Items.Clear();
            this.label25.ForeColor = Color.Black;
            this.label25.BackColor = Color.Transparent;
            this.label25.Text = "O/N";
            if (this.comok && this.ComControl.IsOpen == true)
            {
                this.ComControl.Write("R");
            }
            this.label74.ForeColor = Color.Black;
            this.label74.Text = "Info:";
            if (!this.measureFlg)
            {
                if ((this.gigeCam || this.usbCam) && !this.measureFlg)
                {
                    this.button1.Enabled = true;
                }
                if (((this.tempNum > 0) && (this.usbCam || this.gigeCam)) && !this.capture)
                {
                    this.button2.Enabled = true;
                }
                this.button3.Enabled = false;
                // this.button4.Enabled = true;
                this.button21.Enabled = true;
                this.buttonteaching.Enabled = false;
                this.button17.Enabled = false;
            }
            this.curEdit = false;
            if (!this.autoCsvSave)
            {
                this.csvFileCnt = 0;
                // this.richTextBox1.Text = "";
                // this.richTextBoxBuffer = "";
            }
            this.label100.Visible = false;
        }
        //private string BaslerPixelFormatChange(PYLON_DEVICE_HANDLE hdl, string device)
        //{
        //    string str = "";
        //    if (device.IndexOf("uc") > 0)
        //    {
        //        if (device.IndexOf("daA") >= 0)
        //        {
        //            str = "YCbCr422_8";
        //        }
        //        else
        //        {
        //            str = "BG8";
        //        }
        //    }
        //    else if (device.IndexOf("um") > 0)
        //    {
        //        str = "MONO8";
        //    }
        //    else if (device.IndexOf("gc") > 0)
        //    {
        //        str = "YUV422PACED";
        //    }
        //    else if (device.IndexOf("gm") > 0)
        //    {
        //        str = "MONO8";
        //    }
        //    if ((this.color == 1) && (device.IndexOf("daA") < 0))
        //    {
        //        str = "MONO8";
        //    }
        //    try
        //    {
        //        string str2 = str;
        //        if (str2 != null)
        //        {
        //            if (!(str2 == "YCbCr422_8"))
        //            {
        //                if (str2 == "YUV422PACED")
        //                {
        //                    goto Label_0108;
        //                }
        //                if (str2 == "BG8")
        //                {
        //                    goto Label_013D;
        //                }
        //                if (str2 != "MONO8")
        //                {
        //                    return str;
        //                }
        //                goto Label_0190;
        //            }
        //            if (!Pylon.DeviceFeatureIsAvailable(hdl, "EnumEntry_PixelFormat_YCbCr422_8"))
        //            {
        //                this.message = "YCbCr422_8 のピクセルフォーマットは使用できません。";
        //                throw new Exception();
        //            }
        //            Pylon.DeviceFeatureFromString(hdl, "PixelFormat", "YCbCr422_8");
        //        }
        //        return str;
        //    Label_0108:
        //        if (!Pylon.DeviceFeatureIsAvailable(hdl, "EnumEntry_PixelFormat_YUV422Packed"))
        //        {
        //            this.message = "YUV422 Packedのピクセルフォーマットは使用できません。";
        //            throw new Exception();
        //        }
        //        Pylon.DeviceFeatureFromString(hdl, "PixelFormat", "YUV422Packed");
        //        return str;
        //    Label_013D:
        //        if (!Pylon.DeviceFeatureIsAvailable(hdl, "EnumEntry_PixelFormat_BayerBG8"))
        //        {
        //            if (!Pylon.DeviceFeatureIsAvailable(hdl, "EnumEntry_PixelFormat_BayerGB8"))
        //            {
        //                this.message = "Bayer BG8/GB8 のピクセルフォーマットは使用できません。";
        //                throw new Exception();
        //            }
        //            Pylon.DeviceFeatureFromString(hdl, "PixelFormat", "BayerGB8");
        //            return str;
        //        }
        //        Pylon.DeviceFeatureFromString(hdl, "PixelFormat", "BayerBG8");
        //        return str;
        //    Label_0190:
        //        if (!Pylon.DeviceFeatureIsAvailable(hdl, "EnumEntry_PixelFormat_Mono8"))
        //        {
        //            this.message = "8ビットモノラルのピクセルフォーマットは使用できません。";
        //            throw new Exception();
        //        }
        //        Pylon.DeviceFeatureFromString(hdl, "PixelFormat", "Mono8");
        //    }
        //    catch (Exception)
        //    {
        //        str = "";
        //    }
        //    return str;
        //}
        //private void SetCameraGain(PYLON_DEVICE_HANDLE hndl, int mode, double value)
        //{
        //    if (hndl != null)
        //    {
        //        try
        //        {
        //            switch (mode)
        //            {
        //                case 0:
        //                    if (!Pylon.DeviceFeatureIsAvailable(hndl, "EnumEntry_GainAuto_Off"))
        //                    {
        //                        this.message = "GainAuto Off. Not fined";
        //                        throw new Exception();
        //                    }
        //                    break;

        //                case 1:
        //                    if (!Pylon.DeviceFeatureIsAvailable(hndl, "EnumEntry_GainAuto_Once"))
        //                    {
        //                        this.message = "GainAuto Once. Not fined";
        //                        throw new Exception();
        //                    }
        //                    goto Label_0134;

        //                case 2:
        //                    if (!Pylon.DeviceFeatureIsAvailable(hndl, "EnumEntry_GainAuto_Continuous"))
        //                    {
        //                        this.message = "GainAuto Continuous. Not fined";
        //                        throw new Exception();
        //                    }
        //                    goto Label_0170;

        //                default:
        //                    goto Label_018C;
        //            }
        //            Pylon.DeviceFeatureFromString(hndl, "GainAuto", "Off");
        //            Thread.Sleep(10);
        //            if (!Pylon.DeviceFeatureIsAvailable(hndl, "EnumEntry_GainSelector_All"))
        //            {
        //                this.message = "GainSelector All. Not fined";
        //                throw new Exception();
        //            }
        //            Pylon.DeviceFeatureFromString(hndl, "GainSelector", "All");
        //            Thread.Sleep(10);
        //            if (this.deviceClass == "BaslerUsb")
        //            {
        //                Pylon.DeviceSetFloatFeature(hndl, "Gain", value);
        //                Thread.Sleep(10);
        //            }
        //            else if (this.deviceClass == "BaslerGigE")
        //            {
        //                if ((this.deviceName == "acA1300-30gc") && (value < 300.0))
        //                {
        //                    value = 300.0;
        //                }
        //                Pylon.DeviceSetIntegerFeature(hndl, "GainRaw", (long)value);
        //                Thread.Sleep(10);
        //            }
        //            return;
        //            Label_0134:
        //            Pylon.DeviceFeatureFromString(hndl, "GainAuto", "Once");
        //            Thread.Sleep(10);
        //            return;
        //            Label_0170:
        //            Pylon.DeviceFeatureFromString(hndl, "GainAuto", "Continuous");
        //            Thread.Sleep(10);
        //            return;
        //            Label_018C:
        //            if (!Pylon.DeviceFeatureIsAvailable(hndl, "EnumEntry_GainAuto_Off"))
        //            {
        //                this.message = "GainAuto Off. Not fined";
        //                throw new Exception();
        //            }
        //            Pylon.DeviceFeatureFromString(hndl, "GainAuto", "Off");
        //            Thread.Sleep(10);
        //            if (!Pylon.DeviceFeatureIsAvailable(hndl, "EnumEntry_GainSelector_All"))
        //            {
        //                this.message = "GainSelector All. Not fined";
        //                throw new Exception();
        //            }
        //            Pylon.DeviceFeatureFromString(hndl, "GainSelector", "All");
        //            Thread.Sleep(10);
        //            Pylon.DeviceSetIntegerFeature(hndl, "GainRaw", 450L);
        //            Thread.Sleep(10);
        //        }
        //        catch
        //        {
        //            if (this.message.Length == 0)
        //            {
        //                this.message = "Camera Open : Failed";
        //            }
        //            try
        //            {
        //                if (hndl.IsValid)
        //                {
        //                    if (Pylon.DeviceIsOpen(hndl))
        //                    {
        //                        Pylon.DeviceClose(hndl);
        //                    }
        //                    Pylon.DestroyDevice(hndl);
        //                    this.hPylonDeviceHandle = null;
        //                }
        //            }
        //            catch (Exception)
        //            {
        //            }
        //            Pylon.Terminate();
        //        }
        //    }
        //}
        //private void SetCameraWhite(PYLON_DEVICE_HANDLE hndl, int mode, double value)
        //{
        //    if ((((mode != 0) || (value >= 0.0)) || (value <= 255.0)) && (hndl != null))
        //    {
        //        try
        //        {
        //            switch (mode)
        //            {
        //                case 1:
        //                    break;

        //                default:
        //                    Pylon.DeviceFeatureFromString(hndl, "BalanceWhiteAuto", "Off");
        //                    Thread.Sleep(10);
        //                    Pylon.DeviceFeatureFromString(hndl, "BalanceRatioSelector", "Red");
        //                    Thread.Sleep(10);
        //                    if (this.deviceClass == "BaslerUsb")
        //                    {
        //                        Pylon.DeviceSetFloatFeature(hndl, "BalanceRatio", value);
        //                        Thread.Sleep(10);
        //                    }
        //                    else if (this.deviceClass == "BaslerGigE")
        //                    {
        //                        Pylon.DeviceSetIntegerFeature(hndl, "BalanceRatioRaw", (long)value);
        //                        Thread.Sleep(10);
        //                    }
        //                    return;
        //            }
        //            Pylon.DeviceFeatureFromString(hndl, "BalanceWhiteAuto", "Once");
        //            Thread.Sleep(10);
        //        }
        //        catch
        //        {
        //        }
        //    }
        //}
        //private void SetCameraBlack(PYLON_DEVICE_HANDLE hndl, int mode, double value)
        //{
        //    if (((mode == 0) && (value > 0.0)) && ((value < 1024.0) && (hndl != null)))
        //    {
        //        try
        //        {
        //            int num = mode;
        //            Pylon.DeviceFeatureFromString(hndl, "BlackLevelSelector", "All");
        //            Thread.Sleep(10);
        //            if (this.deviceClass == "BaslerUsb")
        //            {
        //                Pylon.DeviceSetFloatFeature(hndl, "BlackLevel", value);
        //                Thread.Sleep(10);
        //            }
        //            else if (this.deviceClass == "BaslerGigE")
        //            {
        //                Pylon.DeviceSetIntegerFeature(hndl, "BlackLevelRaw", (long)value);
        //                Thread.Sleep(10);
        //            }
        //        }
        //        catch
        //        {
        //        }
        //    }
        //}
        //private void SetCameraGamma(PYLON_DEVICE_HANDLE hndl, bool enabled, int mode, double value)
        //{
        //    if (hndl != null)
        //    {
        //        try
        //        {
        //            if (enabled)
        //            {
        //                Pylon.DeviceSetBooleanFeature(hndl, "GammaEnable", true);
        //                Thread.Sleep(10);
        //                if (mode == 0)
        //                {
        //                    if (!Pylon.DeviceFeatureIsAvailable(hndl, "EnumEntry_GammaSelector_sRGB"))
        //                    {
        //                        this.message = "GammaSelector sRGB Not fined";
        //                        try
        //                        {
        //                            Pylon.DeviceSetFloatFeature(hndl, "Gamma", 1.0);
        //                            Thread.Sleep(10);
        //                        }
        //                        catch
        //                        {
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Pylon.DeviceFeatureFromString(hndl, "GammaSelector", "sRGB");
        //                        Thread.Sleep(10);
        //                    }
        //                }
        //                else if (mode == 1)
        //                {
        //                    bool flag = Pylon.DeviceFeatureIsAvailable(hndl, "EnumEntry_GammaSelector_User");
        //                    Thread.Sleep(10);
        //                    if (!flag)
        //                    {
        //                        this.message = "GammaSelector User Not fined";
        //                    }
        //                    else
        //                    {
        //                        Pylon.DeviceFeatureFromString(hndl, "GammaSelector", "User");
        //                        Thread.Sleep(10);
        //                    }
        //                    Pylon.DeviceSetFloatFeature(hndl, "Gamma", value);
        //                    Thread.Sleep(10);
        //                }
        //            }
        //            else
        //            {
        //                Pylon.DeviceSetBooleanFeature(hndl, "GammaEnable", false);
        //                Thread.Sleep(10);
        //            }
        //        }
        //        catch
        //        {
        //        }
        //    }
        //}

        private void DumyCapture()
        {
            this.capture = true;
            this.damyCapture = true;
            this.CurrentDataClear();
            if (this.diffImgFull != null)
            {
                this.diffImgFull.Dispose();
            }
            this.fileOpFlg = false;
            this.srcScale = 1.0;
            //if (((this.selectCam == 0) && this.gigeCam) && ((this.hPylonDeviceHandle != null) && this.cameraPropertyChange))
            //{
            //    this.SetCameraGain(this.hPylonDeviceHandle, this.gainMode, this.gain);
            //    this.SetCameraWhite(this.hPylonDeviceHandle, this.whiteLevelMode, this.whiteLevel);
            //    this.SetCameraBlack(this.hPylonDeviceHandle, 0, this.blackLevel);
            //    this.SetCameraGamma(this.hPylonDeviceHandle, true, 0, this.gammaLevel);
            //}
            ms_rectList = new Rectangle[0x81];
            mr_rectList = new Rectangle[0x81];
            this.s_rect = new Rectangle(0, 0, 0, 0);
            this.r_rect = new Rectangle(0, 0, 0, 0);
            this.drawRect = new CvRect(0, 0, this.srcImgWidth, this.srcImgHeight);
            this.captureErr = 0;
            this.timeout = false;
            this.stat = 0;
            this.timer1.Interval = 5;
            this.timer1.Enabled = true;
            if (!this.measureFlg)
            {
                this.button1.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (((this.drawRect.Width > 0) && (this.drawRect.Height > 0)) && (this.srcImg != null))
            {
                using (IplImage image = Cv.CreateImage(Cv.Size(this.drawRect.Width, this.drawRect.Height), this.srcImg.Depth, this.srcImg.NChannels))
                {
                    try
                    {
                        if (!this.diffImageFlg && (this.diffImgFull != null))
                        {
                            if ((this.diffImgFull.Width >= image.Width) && (this.diffImgFull.Height >= image.Height))
                            {
                                Cv.SetImageROI(this.diffImgFull, this.drawRect);
                                Cv.Copy(this.diffImgFull, image);
                                Cv.ResetImageROI(this.diffImgFull);
                                this.diffImageFlg = true;
                            }
                            else
                            {
                                Cv.SetImageROI(this.srcImg, this.drawRect);
                                Cv.Copy(this.srcImg, image);
                                Cv.ResetImageROI(this.srcImg);
                                this.diffImageFlg = false;
                            }
                        }
                        else
                        {
                            Cv.SetImageROI(this.srcImg, this.drawRect);
                            Cv.Copy(this.srcImg, image);
                            Cv.ResetImageROI(this.srcImg);
                            this.diffImageFlg = false;
                        }
                        this.pictureBox1.Image = image.ToBitmap();
                    }
                    catch
                    {
                    }
                    return;
                }
            }
            if (this.diffImageFlg)
            {
                if (this.rszImg != null)
                {
                    this.pictureBox1.Image = this.rszImg.ToBitmap();
                }
                else if (this.srcImg != null)
                {
                    this.pictureBox1.Image = this.srcImg.ToBitmap();
                }
                this.diffImageFlg = false;
            }
            else if (this.diffImgFull != null)
            {
                this.pictureBox1.Image = this.diffImgFull.ToBitmap();
                this.diffImageFlg = true;
            }

        }
        //private void PortClose()
        //{
        //    try
        //    {
        //        if (Pylon.DeviceIsOpen(this.hPylonDeviceHandle))
        //        {
        //            Pylon.DeviceClose(this.hPylonDeviceHandle);
        //        }
        //    }
        //    catch
        //    {
        //    }
        //    try
        //    {
        //        Pylon.DestroyDevice(this.hPylonDeviceHandle);
        //        this.hPylonDeviceHandle = null;
        //        if (this.hConverter.IsValid)
        //        {
        //            Pylon.PixelFormatConverterDestroy(this.hConverter);
        //            this.hConverter.SetInvalid();
        //        }
        //    }
        //    catch
        //    {
        //    }
        //    this.hPylonDeviceHandle = null;
        //    Pylon.Terminate();
        //}


        private void ScreenScaleChange(double scale, System.Drawing.Point pt)
        {
            float num = ((float)this.pictureBox1.Width) / ((float)this.pictureBox1.Height);
            System.Drawing.Point point = this.ResizeImgPos(Cv.Size(this.drawRect.Width, this.drawRect.Height), Cv.Size(this.pictureBox1.Width, this.pictureBox1.Height), pt);
            point.X += this.drawRect.X;
            point.Y += this.drawRect.Y;
            if (point.X >= this.srcImgWidth)
            {
                point.X = this.srcImgWidth - 1;
            }
            if (point.Y >= this.srcImgHeight)
            {
                point.Y = this.srcImgHeight - 1;
            }
            if (point.X < 0)
            {
                point.X = 0;
            }
            if (point.Y < 0)
            {
                point.Y = 0;
            }
            System.Drawing.Point point2 = this.ResizeImgPos(Cv.Size(this.srcImgWidth, this.srcImgHeight), Cv.Size(this.pictureBox1.Width, this.pictureBox1.Height), pt);
            this.drawRect.Width = (int)Math.Round((double)(this.srcImgWidth * scale));
            this.drawRect.Height = (int)Math.Round((double)(this.srcImgHeight * scale));
            this.drawRect.X = (int)Math.Round((double)(point.X - (point2.X * scale)));
            this.drawRect.Y = (int)Math.Round((double)(point.Y - (point2.Y * scale)));
            if ((((float)this.drawRect.Width) / ((float)this.drawRect.Height)) > num)
            {
                if ((((float)this.drawRect.Width) / ((float)this.srcImgHeight)) > num)
                {
                    this.drawRect.Height = this.srcImgHeight;
                    this.drawRect.Y = 0;
                }
                else
                {
                    int num2 = (int)(((float)this.drawRect.Width) / num);
                    this.drawRect.Y -= (num2 - this.drawRect.Height) / 2;
                    this.drawRect.Height = num2;
                }
            }
            else if ((((float)this.drawRect.Width) / ((float)this.drawRect.Height)) < num)
            {
                if ((((float)this.srcImgWidth) / ((float)this.drawRect.Height)) < num)
                {
                    this.drawRect.Width = this.srcImgWidth;
                    this.drawRect.X = 0;
                }
                else
                {
                    int num3 = (int)(this.drawRect.Height * num);
                    this.drawRect.X -= (num3 - this.drawRect.Width) / 2;
                    this.drawRect.Width = num3;
                }
            }
            if (this.drawRect.Width > this.srcImgWidth)
            {
                this.drawRect.Width = this.srcImgWidth;
            }
            if (this.drawRect.Height > this.srcImgHeight)
            {
                this.drawRect.Height = this.srcImgHeight;
            }
            if (this.drawRect.X < 0)
            {
                this.drawRect.X = 0;
            }
            if (this.drawRect.Y < 0)
            {
                this.drawRect.Y = 0;
            }
            if ((this.drawRect.Width + this.drawRect.X) > this.srcImgWidth)
            {
                this.drawRect.X = this.srcImgWidth - this.drawRect.Width;
            }
            if ((this.drawRect.Height + this.drawRect.Y) > this.srcImgHeight)
            {
                this.drawRect.Y = this.srcImgHeight - this.drawRect.Height;
            }
            IplImage dst = Cv.CreateImage(Cv.Size(this.drawRect.Width, this.drawRect.Height), this.srcImg.Depth, this.srcImg.NChannels);
            try
            {
                if (this.diffImageFlg && (this.diffImgFull != null))
                {
                    if ((this.diffImgFull.Width > 0) && (this.diffImgFull.Height > 0))
                    {
                        Cv.SetImageROI(this.diffImgFull, this.drawRect);
                        Cv.Copy(this.diffImgFull, dst);
                        Cv.ResetImageROI(this.diffImgFull);
                    }
                    else
                    {
                        Cv.SetImageROI(this.srcImg, this.drawRect);
                        Cv.Copy(this.srcImg, dst);
                        Cv.ResetImageROI(this.srcImg);
                    }
                }
                else
                {
                    Cv.SetImageROI(this.srcImg, this.drawRect);
                    Cv.Copy(this.srcImg, dst);
                    Cv.ResetImageROI(this.srcImg);
                }
                this.pictureBox1.Image = dst.ToBitmap();
                this.ReSiazeRectangle();
                this.label13.Text = string.Concat(new object[] { "Image: X=", this.drawRect.X, ", Y=", this.drawRect.Y, ", W=", this.drawRect.Width, ", H=", this.drawRect.Height });
            }
            catch
            {
            }
            finally
            {
                if (dst != null)
                {
                    dst.Dispose();
                }
            }
        }
        //private int BaslerCaptureSizeChange(PYLON_DEVICE_HANDLE hdl)
        //{
        //    int num = 1;
        //    long capX = 0L;
        //    long capY = 0L;
        //    long num4 = Pylon.DeviceGetIntegerFeature(hdl, "WidthMax");
        //    long num5 = Pylon.DeviceGetIntegerFeature(hdl, "HeightMax");
        //    this.widthMax = (int)num4;
        //    this.heightMax = (int)num5;
        //    long capWidth = this.capWidth;
        //    long capHeight = this.capHeight;
        //    if (this.capX > this.widthMax)
        //    {
        //        capX = 0L;
        //    }
        //    else
        //    {
        //        capX = this.capX;
        //    }
        //    if (this.capY > this.heightMax)
        //    {
        //        capY = 0L;
        //    }
        //    else
        //    {
        //        capY = this.capY;
        //    }
        //    if (this.capWidth > (this.widthMax - capX))
        //    {
        //        this.capWidth = this.widthMax - ((int)capX);
        //    }
        //    else if (this.capWidth <= 0)
        //    {
        //        this.capWidth = this.widthMax;
        //    }
        //    if (this.capHeight > (this.heightMax - capY))
        //    {
        //        this.capHeight = this.heightMax - ((int)capY);
        //    }
        //    else if (this.capHeight <= 0)
        //    {
        //        this.capHeight = this.heightMax;
        //    }
        //    capWidth = this.capWidth;
        //    capHeight = this.capHeight;
        //    try
        //    {
        //        if ((capX == 0L) && (capY == 0L))
        //        {
        //            Pylon.DeviceSetIntegerFeature(this.hPylonDeviceHandle, "OffsetX", capX);
        //            Pylon.DeviceSetIntegerFeature(this.hPylonDeviceHandle, "OffsetY", capY);
        //            Pylon.DeviceSetIntegerFeature(this.hPylonDeviceHandle, "Width", capWidth);
        //            Pylon.DeviceSetIntegerFeature(this.hPylonDeviceHandle, "Height", capHeight);
        //        }
        //        else
        //        {
        //            Pylon.DeviceSetIntegerFeature(this.hPylonDeviceHandle, "Width", capWidth);
        //            Pylon.DeviceSetIntegerFeature(this.hPylonDeviceHandle, "Height", capHeight);
        //            Pylon.DeviceSetIntegerFeature(this.hPylonDeviceHandle, "OffsetX", capX);
        //            Pylon.DeviceSetIntegerFeature(this.hPylonDeviceHandle, "OffsetY", capY);
        //        }
        //    }
        //    catch
        //    {
        //        num = -1;
        //    }
        //    this.capX = (int)capX;
        //    this.capY = (int)capY;
        //    this.capWidth = (int)capWidth;
        //    this.capHeight = (int)capHeight;
        //    return num;
        //}
        //private int PortOpenNum(uint num)
        //{
        //    int num2 = 1;
        //    this.hPylonDeviceHandle = new PYLON_DEVICE_HANDLE();
        //    string str = "";
        //    try
        //    {
        //        this.hPylonDeviceHandle = Pylon.CreateDeviceByIndex(num);
        //        Pylon.DeviceOpen(this.hPylonDeviceHandle, 3);
        //        if (Pylon.DeviceGetNumStreamGrabberChannels(this.hPylonDeviceHandle) < 1)
        //        {
        //            str = "このトランスポートレイヤーはストリーム取込に対応しておりません。";
        //            throw new Exception();
        //        }
        //        this.hGrabber = Pylon.DeviceGetStreamGrabber(this.hPylonDeviceHandle, 0);
        //        Pylon.StreamGrabberOpen(this.hGrabber);
        //        this.hWait = Pylon.StreamGrabberGetWaitObject(this.hGrabber);
        //        PYLON_DEVICE_INFO_HANDLE hDi = Pylon.DeviceGetDeviceInfoHandle(this.hPylonDeviceHandle);
        //        uint num5 = Pylon.DeviceInfoGetNumProperties(hDi);
        //        this.deviceName = Pylon.DeviceInfoGetPropertyValueByName(hDi, "ModelName");
        //        this.deviceClass = Pylon.DeviceInfoGetPropertyValueByName(hDi, "DeviceClass");
        //        this.serialNumber = Pylon.DeviceInfoGetPropertyValueByName(hDi, "SerialNumber");


        //          this.pixcelFormat = this.BaslerPixelFormatChange(this.hPylonDeviceHandle, this.deviceName);
        //        if (Pylon.DeviceFeatureIsAvailable(this.hPylonDeviceHandle, "EnumEntry_TriggerSelector_AcquisitionStart"))
        //        {
        //            Pylon.DeviceFeatureFromString(this.hPylonDeviceHandle, "TriggerSelector", "AcquisitionStart");
        //            Pylon.DeviceFeatureFromString(this.hPylonDeviceHandle, "TriggerMode", "Off");
        //        }
        //        if (Pylon.DeviceFeatureIsAvailable(this.hPylonDeviceHandle, "EnumEntry_TriggerSelector_FrameStart"))
        //        {
        //            Pylon.DeviceFeatureFromString(this.hPylonDeviceHandle, "TriggerSelector", "FrameStart");
        //            Pylon.DeviceFeatureFromString(this.hPylonDeviceHandle, "TriggerMode", "Off");
        //        }
        //        Pylon.DeviceFeatureFromString(this.hPylonDeviceHandle, "TriggerMode", "On");
        //        Pylon.DeviceFeatureFromString(this.hPylonDeviceHandle, "TriggerSource", "Software");
        //        if (Pylon.DeviceFeatureIsAvailable(this.hPylonDeviceHandle, "EnumEntry_ExposureMode_Timed"))
        //        {
        //            Pylon.DeviceFeatureFromString(this.hPylonDeviceHandle, "ExposureMode", "Timed");
        //            if (this.deviceClass == "BaslerUsb")
        //            {
        //                Pylon.DeviceSetFloatFeature(this.hPylonDeviceHandle, "ExposureTime", (double)this.exposureTime);
        //            }
        //            else if (this.deviceClass == "BaslerGigE")
        //            {
        //                Pylon.DeviceSetFloatFeature(this.hPylonDeviceHandle, "ExposureTimeAbs", (double)this.exposureTime);
        //            }
        //        }
        //        this.BaslerCaptureSizeChange(this.hPylonDeviceHandle);
        //        if (Pylon.DeviceFeatureIsWritable(this.hPylonDeviceHandle, "GevSCPSPacketSize"))
        //        {
        //            Pylon.DeviceSetIntegerFeature(this.hPylonDeviceHandle, "GevSCPSPacketSize", (long)this.packetSize);
        //        }
        //        this.hConverter = new PYLON_FORMAT_CONVERTER_HANDLE();
        //        Pylon.StreamGrabberSetMaxNumBuffer(this.hGrabber, 1);
        //        uint maxSize = (uint)Pylon.DeviceGetIntegerFeature(this.hPylonDeviceHandle, "PayloadSize");
        //        Pylon.StreamGrabberSetMaxBufferSize(this.hGrabber, maxSize);
        //        Pylon.StreamGrabberPrepareGrab(this.hGrabber);
        //        this.buffer = new PylonBuffer<byte>(maxSize, true);
        //        this.buffers = new Dictionary<PYLON_STREAMBUFFER_HANDLE, PylonBuffer<byte>>();
        //        this.hStream = Pylon.StreamGrabberRegisterBuffer<byte>(this.hGrabber, ref this.buffer);
        //        this.buffers.Add(this.hStream, this.buffer);
        //        Pylon.StreamGrabberQueueBuffer(this.hGrabber, this.hStream, 0);
        //        str = "Camera Open : Success";
        //        // this.SaveCameraProperty();
        //        this.counter = 0L;
        //    }
        //    catch
        //    {
        //        num2 = 0;
        //        if (str.Length == 0)
        //        {
        //            str = "Camera Open : Failed";
        //        }
        //        try
        //        {
        //            if (this.hPylonDeviceHandle.IsValid)
        //            {
        //                if (Pylon.DeviceIsOpen(this.hPylonDeviceHandle))
        //                {
        //                    Pylon.DeviceClose(this.hPylonDeviceHandle);
        //                }
        //                Pylon.DestroyDevice(this.hPylonDeviceHandle);
        //                this.hPylonDeviceHandle = null;
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            this.hPylonDeviceHandle = null;
        //        }
        //        Pylon.Terminate();
        //    }
        //    return num2;
        //}

        private void CaptureImage()
        {
            if (!this.capture)
            {
                //if (this.hPylonDeviceHandle == null)
                //{
                //    this.LoadCameraProperty(this.cameraPropertyPath);
                //    this.cameraPropertyChange = true;
                //    this.PortClose();
                //    this.PortOpenNum((uint)this.selectIndustrialCamNum);
                //}

                this.capture = true;
                this.button1.ForeColor = Color.Red;
                this.button1.Text = "Pause";
                this.CurrentDataClear();
                if (this.diffImgFull != null)
                {
                    this.diffImgFull.Dispose();
                }
                this.fileOpFlg = false;
                this.srcScale = 1.0;
                if (this.srcImg != null)
                {
                    System.Drawing.Point pt = new System.Drawing.Point(0, 0);
                    this.ScreenScaleChange(this.srcScale, pt);
                }
                //if (((this.selectCam == 0) && this.gigeCam) && ((this.hPylonDeviceHandle != null) && this.cameraPropertyChange))
                //{
                //    this.SetCameraGain(this.hPylonDeviceHandle, this.gainMode, this.gain);
                //    this.SetCameraWhite(this.hPylonDeviceHandle, this.whiteLevelMode, this.whiteLevel);
                //    this.SetCameraBlack(this.hPylonDeviceHandle, 0, this.blackLevel);
                //    this.SetCameraGamma(this.hPylonDeviceHandle, true, 0, this.gammaLevel);
                //}
                ms_rectList = new Rectangle[0x81];
                mr_rectList = new Rectangle[0x81];
                this.s_rect = new Rectangle(0, 0, 0, 0);
                this.r_rect = new Rectangle(0, 0, 0, 0);
                this.drawRect = new CvRect(0, 0, this.srcImgWidth, this.srcImgHeight);
                this.captureErr = 0;
                this.timeout = false;
                //this.stat = 0;
                //this.timer1.Interval = 15;
                //this.timer1.Enabled = true;
                _cameraThread = new Thread(new ThreadStart(CaptureCameraCallback));
                _cameraThread.Start();
                if (!this.measureFlg)
                {
                    this.button1.Enabled = true;
                }
                else
                {
                    this.timer2.Enabled = true;
                }
            }
            else
            {

                this.capture = false;
                this.timer1.Enabled = false;
                this.button1.ForeColor = Color.Black;
                this.button1.Text = "Camera";

                this.CurrentDataClear();
                this.srcImg = img;

                this.curImagePath = Path.GetDirectoryName(this.srcFn);
                this.srcImgHeight = this.srcImg.Height;
                this.srcImgWidth = this.srcImg.Width;
                this.drawRect = new CvRect(0, 0, this.srcImgWidth, this.srcImgHeight);
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                this.pictureBox1.Image = this.srcImg.ToBitmap();
                this.dstImg = Cv.CloneImage(this.srcImg);


                //this.label1.Text = string.Concat(new object[] { "IMAGE FILE : ", this.srcImg.Width, " x ", this.srcImg.Height });
                //this.ButtonInterlock(false);
                if (Cursor.Current != Cursors.Default)
                {
                    Cursor.Current = Cursors.Default;
                }

                _cameraThread.Abort();
                if (this.srcImg != null)
                {
                    this.dstImg = Cv.CloneImage(this.srcImg);
                    if ((this.dstImg != null) && (this.pictureBox1.Image != null))
                    {
                        this.buttonteaching.Enabled = true;
                    }
                }
                if ((this.srcImg == null) || (this.dstImg == null))
                {
                    this.dstImg = null;
                }
                else if ((this.tempNum > 0) && (this.usbCam || this.gigeCam || this.camok))
                {
                    this.button1.Enabled = true;
                    this.button2.Enabled = true;
                }
                else
                {
                    this.button1.Enabled = false;
                    this.button2.Enabled = false;
                }
                this.capture = false;
                if (!this.measureFlg)
                {

                    this.button1.Enabled = true;
                }
            }
        }
        private void CaptureCameraCallback()
        {
            while (true)
            {
                //this.cam.FrameWidth = 1280;
                //this.cam.FrameHeight = 1024;
                img = cam.QueryFrame();
                pictureBox1.Image = img.ToBitmap();

            }
        }
        private CvSeq<CvPoint> EdgeCheck(IplImage src, CvMemStorage strg)
        {
            CvSeq<CvPoint> firstContour = null;
            if (src != null)
            {
                using (IplImage image = new IplImage(src.Size, BitDepth.U8, 1))
                {
                    using (IplImage image2 = new IplImage(src.Size, BitDepth.U8, 1))
                    {
                        new IplImage(src.Size, BitDepth.U8, 3);
                        Cv.RGB(0xff, 0, 0);
                        Cv.RGB(0xff, 0, 0);
                        if (src.NChannels > 1)
                        {
                            Cv.CvtColor(src, image, ColorConversion.BgrToGray);
                        }
                        else
                        {
                            Cv.Copy(src, image);
                        }
                        this.thlLvl = 80;
                        Cv.Threshold(image, image2, (double)this.thlLvl, 255.0, ThresholdType.Otsu);
                        Cv.FindContours(image2, strg, out firstContour, this.header_size, this.findcnt_mode, this.findcnt_method, Cv.Point(this.findcnt_offsetx, this.findcnt_offsety));
                        this.pictureBox6.Image = image2.ToBitmap();
                    }
                }
            }
            return firstContour;
        }


        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (this.pictureBox1.Focused)
            {
                base.ActiveControl = null;
            }
            this.sizePicArea = false;
            this.sizePicPosition = false;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.sizePicArea = false;
            this.mouseLBDownFlg = false;

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (((this.teachFlg && !this.capture) && !this.measureFlg) || ((this.paintRectangleEnabled && !this.teachFlg) && (this.measureNum > 0)))
            {
                using (Font font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point))
                {
                    using (Font font2 = new Font("Arial", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point))
                    {
                        using (Pen pen = new Pen(Color.White, 1f))
                        {
                            using (new Pen(Color.Black, 2f))
                            {
                                using (Pen pen3 = new Pen(Color.Gainsboro, 1f))
                                {
                                    using (Pen pen4 = new Pen(Color.Red, 2f))
                                    {
                                        using (Pen pen5 = new Pen(Color.Cyan, 2f))
                                        {
                                            using (Pen pen6 = new Pen(Color.Magenta, 2f))
                                            {
                                                using (Pen pen7 = new Pen(Color.Yellow, 2f))
                                                {
                                                    using (new Pen(Color.Lime, 2f))
                                                    {
                                                        using (Pen pen9 = new Pen(Color.Red, 4f))
                                                        {
                                                            using (SolidBrush brush = new SolidBrush(Color.FromArgb(0xff, 0, 0xff, 0)))
                                                            {
                                                                using (Pen pen10 = new Pen(brush, 4f))
                                                                {
                                                                    StringFormat format = new StringFormat
                                                                    {
                                                                        Alignment = StringAlignment.Near,
                                                                        LineAlignment = StringAlignment.Center
                                                                    };
                                                                    int num = 0;
                                                                    Rectangle layoutRectangle = new Rectangle(0, 0, 60, 20);
                                                                    Brush cyan = Brushes.DarkRed;
                                                                    Pen pen11 = new Pen(Color.Black);
                                                                    if (this.rotation)
                                                                    {
                                                                        CvPoint2D32f[] pt = new CvPoint2D32f[4];
                                                                        System.Drawing.Point[] points = new System.Drawing.Point[4];
                                                                        Cv.BoxPoints(this.rotationBox, out pt);
                                                                        for (int i = 0; i < 4; i++)
                                                                        {
                                                                            points[i].X = (int)Math.Round((double)pt[i].X);
                                                                            points[i].Y = (int)Math.Round((double)pt[i].Y);
                                                                        }
                                                                        e.Graphics.DrawPolygon(pen, points);
                                                                    }
                                                                    else if (this.measureNum == 0)
                                                                    {
                                                                        for (int j = this.tempNum; j >= 0; j--)
                                                                        {
                                                                            if (j <= 0x80)
                                                                            {
                                                                                Rectangle rect = new Rectangle(s_rectList[j].X, s_rectList[j].Y, s_rectList[j].Width - 1, s_rectList[j].Height - 1);
                                                                                Rectangle rectangle3 = new Rectangle(this.drawRect.X, this.drawRect.Y, this.drawRect.Width, this.drawRect.Height);
                                                                                System.Drawing.Point[] pointArray2 = new System.Drawing.Point[] { new System.Drawing.Point(r_rectList[j].X, r_rectList[j].Y), new System.Drawing.Point(r_rectList[j].X + r_rectList[j].Width, r_rectList[j].Y), new System.Drawing.Point(r_rectList[j].X + r_rectList[j].Width, r_rectList[j].Y + r_rectList[j].Height), new System.Drawing.Point(r_rectList[j].X, r_rectList[j].Y + r_rectList[j].Height) };
                                                                                if (((rectangle3.Contains(pointArray2[0]) && rectangle3.Contains(pointArray2[1])) && (rectangle3.Contains(pointArray2[2]) && rectangle3.Contains(pointArray2[3]))) && ((s_rectList[j].X >= 0) && (s_rectList[j].Y >= 0)))
                                                                                {
                                                                                    if (!this.curEdit && (j == this.tempNum))
                                                                                    {
                                                                                        if ((s_rectList[j].Width > 0) && (s_rectList[j].Height > 0))
                                                                                        {
                                                                                            num = j + 1;
                                                                                            cyan = Brushes.Magenta;
                                                                                            e.Graphics.DrawRectangle(pen6, rect);
                                                                                            layoutRectangle = new Rectangle(s_rectList[j].X - 10, s_rectList[j].Y - 20, 60, 20);
                                                                                            if (layoutRectangle.X < 0)
                                                                                            {
                                                                                                layoutRectangle.X = 0;
                                                                                            }
                                                                                            if (layoutRectangle.Y < 0)
                                                                                            {
                                                                                                layoutRectangle.Y = 0;
                                                                                            }
                                                                                            e.Graphics.DrawString(num.ToString(), font2, cyan, layoutRectangle, format);
                                                                                        }
                                                                                    }
                                                                                    else if (this.curEdit && ((this.curNum - 1) == j))
                                                                                    {
                                                                                        num = j + 1;
                                                                                        cyan = Brushes.Yellow;
                                                                                        e.Graphics.DrawRectangle(pen7, rect);
                                                                                        layoutRectangle = new Rectangle(s_rectList[j].X - 10, s_rectList[j].Y - 20, 60, 20);
                                                                                        if (layoutRectangle.X < 0)
                                                                                        {
                                                                                            layoutRectangle.X = 0;
                                                                                        }
                                                                                        if (layoutRectangle.Y < 0)
                                                                                        {
                                                                                            layoutRectangle.Y = 0;
                                                                                        }
                                                                                        e.Graphics.DrawString(num.ToString(), font2, cyan, layoutRectangle, format);
                                                                                    }
                                                                                    else if ((!this.curEdit && ((this.curNum - 1) == j)) && s_rectList[j].Contains(this.clickPoint))
                                                                                    {
                                                                                        num = j + 1;
                                                                                        cyan = Brushes.DarkRed;
                                                                                        e.Graphics.DrawRectangle(pen5, rect);
                                                                                        layoutRectangle = new Rectangle(s_rectList[j].X - 10, s_rectList[j].Y - 20, 60, 20);
                                                                                        if (layoutRectangle.X < 0)
                                                                                        {
                                                                                            layoutRectangle.X = 0;
                                                                                        }
                                                                                        if (layoutRectangle.Y < 0)
                                                                                        {
                                                                                            layoutRectangle.Y = 0;
                                                                                        }
                                                                                        e.Graphics.DrawString(num.ToString(), font2, cyan, layoutRectangle, format);
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        e.Graphics.DrawRectangle(pen3, rect);
                                                                                        if (this.checkBox10.Checked)
                                                                                        {
                                                                                            num = j + 1;
                                                                                            cyan = Brushes.Gainsboro;
                                                                                            layoutRectangle = new Rectangle(s_rectList[j].X - 10, s_rectList[j].Y - 20, 60, 20);
                                                                                            if (layoutRectangle.X < 0)
                                                                                            {
                                                                                                layoutRectangle.X = 0;
                                                                                            }
                                                                                            if (layoutRectangle.Y < 0)
                                                                                            {
                                                                                                layoutRectangle.Y = 0;
                                                                                            }
                                                                                            e.Graphics.DrawString(num.ToString(), font, cyan, layoutRectangle, format);
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (!this.measureFlg)
                                                                    {
                                                                        for (int k = 0; k < this.measureNum; k++)
                                                                        {
                                                                            if (k < 0x80)
                                                                            {
                                                                                //Rectangle rectangle4 = new Rectangle(10, 10, 100, 100);

                                                                                Rectangle rectangle4 = new Rectangle(ms_rectList[k].X, ms_rectList[k].Y, ms_rectList[k].Width - 1, ms_rectList[k].Height - 1);
                                                                                Rectangle rectangle5 = new Rectangle(this.drawRect.X, this.drawRect.Y, this.drawRect.Width, this.drawRect.Height);
                                                                                System.Drawing.Point[] pointArray3 = new System.Drawing.Point[] { new System.Drawing.Point(mr_rectList[k].X, mr_rectList[k].Y), new System.Drawing.Point(mr_rectList[k].X + mr_rectList[k].Width, mr_rectList[k].Y), new System.Drawing.Point(mr_rectList[k].X + mr_rectList[k].Width, mr_rectList[k].Y + mr_rectList[k].Height), new System.Drawing.Point(mr_rectList[k].X, mr_rectList[k].Y + mr_rectList[k].Height) };
                                                                                if (((rectangle5.Contains(pointArray3[0]) && rectangle5.Contains(pointArray3[1])) && (rectangle5.Contains(pointArray3[2]) && rectangle5.Contains(pointArray3[3]))) && ((ms_rectList[k].X >= 0) && (ms_rectList[k].Y >= 0)))
                                                                                {
                                                                                    if (k == (this.curNum - 1))
                                                                                    {
                                                                                        num = k + 1;
                                                                                        //layoutRectangle = rectangle4;
                                                                                        layoutRectangle = new Rectangle(ms_rectList[k].X - 12, ms_rectList[k].Y - 30, 0x60, 0x1c);
                                                                                        if (this.judgeResult[k] < 0)
                                                                                        {
                                                                                            cyan = Brushes.Red;
                                                                                            e.Graphics.DrawRectangle(pen9, rectangle4);
                                                                                            pen11 = new Pen(Color.LightGoldenrodYellow);
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            cyan = brush;
                                                                                            e.Graphics.DrawRectangle(pen10, rectangle4);
                                                                                            pen11 = new Pen(Color.Blue);
                                                                                        }
                                                                                        if (layoutRectangle.X < 2)
                                                                                        {
                                                                                            layoutRectangle.X = 2;
                                                                                        }
                                                                                        if (layoutRectangle.Y < 2)
                                                                                        {
                                                                                            layoutRectangle.Y = 2;
                                                                                        }
                                                                                        if ((layoutRectangle.X > 0) && (layoutRectangle.Y > 0))
                                                                                        {
                                                                                            GraphicsPath path = new GraphicsPath();
                                                                                            FontFamily family = new FontFamily("Arial");
                                                                                            int style = 1;
                                                                                            path.AddString(num.ToString(), family, style, 32f, layoutRectangle, StringFormat.GenericDefault);
                                                                                            e.Graphics.FillPath(cyan, path);
                                                                                            e.Graphics.DrawPath(pen11, path);
                                                                                        }
                                                                                    }
                                                                                    else if (this.judgeResult[k] < 0)
                                                                                    {
                                                                                        e.Graphics.DrawRectangle(pen4, rectangle4);
                                                                                        layoutRectangle = new Rectangle(ms_rectList[k].X - 2, ms_rectList[k].Y - 0x18, 0x48, 0x1c);
                                                                                        if (layoutRectangle.X < 0)
                                                                                        {
                                                                                            layoutRectangle.X = 0;
                                                                                        }
                                                                                        if (layoutRectangle.Y < 0)
                                                                                        {
                                                                                            layoutRectangle.Y = 0;
                                                                                        }
                                                                                        if ((layoutRectangle.X > 0) && (layoutRectangle.Y > 0))
                                                                                        {
                                                                                            num = k + 1;
                                                                                            e.Graphics.DrawString(num.ToString(), font, Brushes.Red, layoutRectangle, format);
                                                                                        }
                                                                                    }
                                                                                    else if (!this.checkBox3.Checked)
                                                                                    {
                                                                                        e.Graphics.DrawRectangle(pen5, rectangle4);
                                                                                        if (this.checkBox10.Checked)
                                                                                        {
                                                                                            layoutRectangle = new Rectangle(ms_rectList[k].X - 2, ms_rectList[k].Y - 0x18, 0x48, 0x1c);
                                                                                            if (layoutRectangle.X < 0)
                                                                                            {
                                                                                                layoutRectangle.X = 0;
                                                                                            }
                                                                                            if (layoutRectangle.Y < 0)
                                                                                            {
                                                                                                layoutRectangle.Y = 0;
                                                                                            }
                                                                                            num = k + 1;
                                                                                            e.Graphics.DrawString(num.ToString(), font, Brushes.DarkRed, layoutRectangle, format);
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private bool VerifyPresetData(int n)
        {
            bool flag2;
            bool flag = false;
            string text1 = "preset" + n;
            string path = string.Concat(new object[] { this.presetPath, "preset", n, ".xml" });
            XmlSerializer serializer = new XmlSerializer(typeof(Preset));
            try
            {
                FileStream stream = new FileStream(path, FileMode.Open);
                this.preset = (Preset)serializer.Deserialize(stream);
                stream.Close();
                if (this.checkBox2.Checked != this.preset.inspectEnabled)
                {
                    return flag;
                }
                if (this.numericUpDown11.Value != this.preset.searchPositionRangeX)
                {
                    return flag;
                }
                if (this.numericUpDown12.Value != this.preset.searchPositionRangeY)
                {
                    return flag;
                }
                if (this.numericUpDown13.Value != ((decimal)this.preset.searchAngleRange))
                {
                    return flag;
                }
                if (this.numericUpDown14.Value != ((decimal)this.preset.searchAngleStep))
                {
                    return flag;
                }
                if (this.numericUpDown15.Value != ((decimal)this.preset.searchScaleMin))
                {
                    return flag;
                }
                if (this.numericUpDown16.Value != ((decimal)this.preset.searchScaleMax))
                {
                    return flag;
                }
                if (this.numericUpDown17.Value != ((decimal)this.preset.searchScaleStep))
                {
                    return flag;
                }
                if ((this.preset.ptmSearchMode == 1) && !this.radioButton6.Checked)
                {
                    return flag;
                }
                if ((this.preset.ptmSearchMode == 2) && !this.radioButton7.Checked)
                {
                    return flag;
                }
                if ((this.preset.ptmSearchMode == 0) && !this.radioButton5.Checked)
                {
                    return flag;
                }
                if (this.radioButton7.Checked && (this.numericUpDown21.Value != this.preset.ptmBinaryThreshold))
                {
                    return flag;
                }
                if (this.comboBox5.Text != this.preset.averageCount.ToString())
                {
                    return flag;
                }
                if (this.comboBox2.Text != this.preset.smoothParam1.ToString())
                {
                    return flag;
                }
                if (this.comboBox6.Text != this.preset.smoothParam3.ToString())
                {
                    return flag;
                }
                if (this.comboBox7.Text != this.preset.smoothParam4.ToString())
                {
                    return flag;
                }
                if (this.numericUpDown18.Value != ((decimal)this.preset.unsharpMask))
                {
                    return flag;
                }
                if (this.numericUpDown19.Value != ((decimal)this.preset.contrastCoef))
                {
                    return flag;
                }
                if (this.comboBox3.Text != this.preset.erodNum.ToString())
                {
                    return flag;
                }
                if (this.comboBox4.Text != this.preset.dilaNum.ToString())
                {
                    return flag;
                }
                if (this.trackBar1.Value != this.preset.binaryAllThreshold)
                {
                    return flag;
                }
                if (this.trackBar2.Value != this.preset.binaryRedThreshold)
                {
                    return flag;
                }
                if (this.trackBar3.Value != this.preset.binaryGreenThreshold)
                {
                    return flag;
                }
                if (this.trackBar4.Value != this.preset.binaryBlueThreshold)
                {
                    return flag;
                }
                if (this.trackBar6.Value != this.preset.blobMinAreaThreshold)
                {
                    return flag;
                }
                if (this.trackBar7.Value != this.preset.blobMaxAreaThreshold)
                {
                    return flag;
                }
                if (this.trackBar5.Value != ((int)this.preset.matchRateThreshold))
                {
                    return flag;
                }
                if (this.trackBar8.Value != this.preset.diffThreshold)
                {
                    return flag;
                }
                if (this.radioButton8.Checked != (this.preset.matchRateNG_UnderOver == 1))
                {
                    return flag;
                }
                if (this.radioButton10.Checked != (this.preset.diffNG_UnderOver == 1))
                {
                    return flag;
                }
                return true;
            }
            catch
            {
                return false;
            }
            return flag2;
        }

        private string LoadPreset(int n)
        {
            string name = "preset" + n;
            string path = string.Concat(new object[] { this.presetPath, "preset", n, ".xml" });
            XmlSerializer serializer = new XmlSerializer(typeof(Preset));
            try
            {
                FileStream stream = new FileStream(path, FileMode.Open);
                this.preset = (Preset)serializer.Deserialize(stream);
                stream.Close();
                name = this.preset.name;
                this.checkBox2.Checked = this.preset.inspectEnabled;
                this.numericUpDown11.Value = this.preset.searchPositionRangeX;
                this.numericUpDown12.Value = this.preset.searchPositionRangeY;
                this.numericUpDown13.Value = (decimal)this.preset.searchAngleRange;
                this.numericUpDown14.Value = (decimal)this.preset.searchAngleStep;
                this.numericUpDown15.Value = (decimal)this.preset.searchScaleMin;
                this.numericUpDown16.Value = (decimal)this.preset.searchScaleMax;
                this.numericUpDown17.Value = (decimal)this.preset.searchScaleStep;
                switch (this.preset.ptmSearchMode)
                {
                    case 0:
                        this.radioButton5.Checked = true;
                        break;

                    case 1:
                        this.radioButton6.Checked = true;
                        break;

                    case 2:
                        this.radioButton7.Checked = true;
                        break;

                    default:
                        this.radioButton5.Checked = true;
                        break;
                }
                this.numericUpDown21.Value = this.preset.ptmBinaryThreshold;
                this.comboBox5.Text = this.preset.averageCount.ToString();
                this.comboBox2.Text = this.preset.smoothParam1.ToString();
                this.comboBox6.Text = this.preset.smoothParam3.ToString();
                this.comboBox7.Text = this.preset.smoothParam4.ToString();
                this.numericUpDown18.Value = (decimal)this.preset.unsharpMask;
                this.numericUpDown19.Value = (decimal)this.preset.contrastCoef;
                this.comboBox3.Text = this.preset.erodNum.ToString();
                this.comboBox4.Text = this.preset.dilaNum.ToString();
                this.trackBar1.Value = this.preset.binaryAllThreshold;
                this.numericUpDown3.Value = this.trackBar1.Value;
                this.trackBar2.Value = this.preset.binaryRedThreshold;
                this.numericUpDown4.Value = this.trackBar2.Value;
                this.trackBar3.Value = this.preset.binaryGreenThreshold;
                this.numericUpDown5.Value = this.trackBar3.Value;
                this.trackBar4.Value = this.preset.binaryBlueThreshold;
                this.numericUpDown6.Value = this.trackBar4.Value;
                this.trackBar6.Value = this.preset.blobMinAreaThreshold;
                this.numericUpDown7.Value = this.trackBar6.Value;
                this.trackBar7.Value = this.preset.blobMaxAreaThreshold;
                this.numericUpDown8.Value = this.trackBar7.Value;
                this.trackBar5.Value = (int)this.preset.matchRateThreshold;
                this.numericUpDown9.Value = this.trackBar5.Value;
                this.trackBar8.Value = this.preset.diffThreshold;
                if (this.preset.version < 0x7c)
                {
                    this.numericUpDown10.Value = (decimal)Math.Round((double)(this.trackBar8.Value * 0.05), 2);
                }
                else
                {
                    this.numericUpDown10.Value = (decimal)Math.Round((double)(this.trackBar8.Value * 0.01), 2);
                }
                if (this.preset.version >= 0x7c)
                {
                    if (this.preset.matchRateNG_UnderOver == 0)
                    {
                        this.radioButton9.Checked = true;
                    }
                    else
                    {
                        this.radioButton8.Checked = true;
                    }
                    if (this.preset.diffNG_UnderOver == 1)
                    {
                        this.radioButton10.Checked = true;
                        return name;
                    }
                    this.radioButton11.Checked = true;
                    return name;
                }
                this.radioButton9.Checked = true;
                this.radioButton10.Checked = true;
            }
            catch
            {
            }
            return name;

        }
        //private double GetCameraGain(PYLON_DEVICE_HANDLE hndl)
        //{
        //    double num = 0.0;
        //    if (hndl != null)
        //    {
        //        try
        //        {
        //            if (this.deviceClass == "BaslerUsb")
        //            {
        //                num = Pylon.DeviceGetFloatFeature(hndl, "Gain");
        //                Thread.Sleep(10);
        //                return num;
        //            }
        //            if (this.deviceClass == "BaslerGigE")
        //            {
        //                num = Pylon.DeviceGetIntegerFeature(hndl, "GainRaw");
        //                Thread.Sleep(10);
        //            }
        //        }
        //        catch
        //        {
        //        }
        //    }
        //    return num;
        //}
        //private double GetCameraWhite(PYLON_DEVICE_HANDLE hndl)
        //{
        //    double num = 0.0;
        //    if (hndl == null)
        //    {
        //        return num;
        //    }
        //    try
        //    {
        //        if (this.deviceClass == "BaslerUsb")
        //        {
        //            num = Pylon.DeviceGetFloatFeature(hndl, "BalanceRatio");
        //            Thread.Sleep(10);
        //        }
        //        else if (this.deviceClass == "BaslerGigE")
        //        {
        //            num = Pylon.DeviceGetIntegerFeature(hndl, "BalanceRatioRaw");
        //            Thread.Sleep(10);
        //        }
        //        return num;
        //    }
        //    catch
        //    {
        //        return num;
        //    }
        //}
        //private double GetCameraBlack(PYLON_DEVICE_HANDLE hndl)
        //{
        //    double num = 0.0;
        //    if (hndl != null)
        //    {
        //        try
        //        {
        //            if (this.deviceClass == "BaslerUsb")
        //            {
        //                num = Pylon.DeviceGetFloatFeature(hndl, "BlackLevel");
        //                Thread.Sleep(10);
        //                return num;
        //            }
        //            if (this.deviceClass == "BaslerGigE")
        //            {
        //                num = Pylon.DeviceGetIntegerFeature(hndl, "BlackLevelRaw");
        //                Thread.Sleep(10);
        //            }
        //        }
        //        catch
        //        {
        //        }
        //    }
        //    return num;
        //}

        private void button27_Click(object sender, EventArgs e)
        {
            if (!this.VerifyPresetData(2))
            {
                this.button27.Text = this.LoadPreset(2);
                this.button26.ForeColor = Color.Black;
                this.button27.ForeColor = Color.Red;
                this.button28.ForeColor = Color.Black;
                this.button29.ForeColor = Color.Black;
                if ((this.dstdifimg != null) && !this.timer1.Enabled)
                {
                    this.stat = 0x67;
                    this.timer1.Enabled = true;
                }

            }

        }
        private IMAGE_POSI_SIZE SetSearcArea(IplImage img, int n, TEMPLATE_DATA_NUM tmp, int locationOffsetX, int locationOffsetY, int offsetX, int offsetY)
        {
            IMAGE_POSI_SIZE image_posi_size = new IMAGE_POSI_SIZE();
            try
            {
                image_posi_size.rct = new CvRect((tmp.pt.X - offsetX) + locationOffsetX, (tmp.pt.Y - offsetY) + locationOffsetY, tmp.tmpData[tmp.refScaleID, tmp.refAngleID].image.Width + (offsetX * 2), tmp.tmpData[tmp.refScaleID, tmp.refAngleID].image.Height + (offsetY * 2));
                if (image_posi_size.rct.X < 0)
                {
                    image_posi_size.rct.X = 0;
                }
                if (image_posi_size.rct.Y < 0)
                {
                    image_posi_size.rct.Y = 0;
                }
                if ((image_posi_size.rct.X + image_posi_size.rct.Width) > img.Width)
                {
                    image_posi_size.rct.X = 0;
                    image_posi_size.rct.Width = img.Width;
                }
                if ((image_posi_size.rct.Y + image_posi_size.rct.Height) > img.Height)
                {
                    image_posi_size.rct.Y = 0;
                    image_posi_size.rct.Height = img.Height;
                }
                image_posi_size.img = new IplImage(image_posi_size.rct.Width, image_posi_size.rct.Height, img.Depth, img.NChannels);
                Cv.SetImageROI(img, image_posi_size.rct);
                Cv.Copy(img, image_posi_size.img);
                Cv.ResetImageROI(img);
            }
            catch
            {
            }
            return image_posi_size;
        }
        public static void CvUnsharpMasking(IplImage src, IplImage dst, float k)
        {
            float[] data = new float[] { -k / 9f, -k / 9f, -k / 9f, -k / 9f, 1f + ((8f * k) / 9f), -k / 9f, -k / 9f, -k / 9f, -k / 9f };
            CvMat kernel = Cv.Mat<float>(3, 3, MatrixType.F32C1, data);
            Cv.Filter2D(src, dst, kernel);
        }
        public static void CvContrast(IplImage src, IplImage dst, float a)
        {
            byte[] data = new byte[0x100];
            IplImage[] imageArray = new IplImage[4];
            for (int i = 0; i < 0x100; i++)
            {
                data[i] = (byte)(255.0 / (1.0 + Math.Exp((double)((-a * (i - 0x80)) / 255f))));
            }
            CvMat lut = Cv.Mat<byte>(1, 0x100, MatrixType.U8C1, data);
            if (src.NChannels == 1)
            {
                Cv.LUT(src, dst, lut);
            }
            else if (src.NChannels == 3)
            {
                imageArray[0] = new IplImage(src.Size, BitDepth.U8, 1);
                imageArray[1] = new IplImage(src.Size, BitDepth.U8, 1);
                imageArray[2] = new IplImage(src.Size, BitDepth.U8, 1);
                imageArray[3] = new IplImage(src.Size, BitDepth.U8, 1);
                Cv.Split(src, imageArray[0], imageArray[1], imageArray[2], null);
                Cv.LUT(imageArray[0], imageArray[0], lut);
                Cv.LUT(imageArray[1], imageArray[1], lut);
                Cv.LUT(imageArray[2], imageArray[2], lut);
                Cv.Merge(imageArray[0], imageArray[1], imageArray[2], null, dst);
            }
        }
        private void DifferentImage(IplImage tmp, IplImage tgt, out IplImage dst)
        {
            using (IplImage image = new IplImage(tgt.Size, tgt.Depth, tgt.NChannels))
            {
                using (IplImage image2 = new IplImage(tgt.Size, tgt.Depth, tgt.NChannels))
                {
                    Cv.Sub(tmp, tgt, image);
                    Cv.Sub(tgt, tmp, image2);
                    Cv.Add(image, image2, image);
                    dst = Cv.CloneImage(image);
                }
            }
        }

        public static unsafe void ThreshImagePixcelCountProc(IplImage pThreshImage, int threshold, out long pWhitePixelCount, out long pBlackPixelCount)
        {
            pWhitePixelCount = 0L;
            pBlackPixelCount = 0L;
            byte* imageData = (byte*)pThreshImage.ImageData;
            for (int i = 0; i < pThreshImage.Height; i++)
            {
                for (int j = 0; j < pThreshImage.Width; j++)
                {
                    int num3 = imageData[(i * pThreshImage.WidthStep) + j];
                    if (num3 >= threshold)
                    {
                        pWhitePixelCount += 1L;
                    }
                    else
                    {
                        pBlackPixelCount += 1L;
                    }
                }
            }
        }
        private unsafe void FillImage(IplImage src, IplImage dst, Color cl)
        {
            byte* imageData = (byte*)dst.ImageData;
            int width = src.Width;
            int height = src.Height;
            void* voidPtr1 = (void*)src.ImageData;
            for (int i = 0; i < src.Height; i++)
            {
                for (int j = 0; j < src.Width; j++)
                {
                    int num3 = imageData[(i * src.WidthStep) + (j * 3)];
                    int num4 = imageData[((i * src.WidthStep) + (j * 3)) + 1];
                    int num5 = imageData[((i * src.WidthStep) + (j * 3)) + 2];
                    if (((num3 != 0) || (num4 != 0)) || (num5 != 0))
                    {
                        imageData[(i * src.WidthStep) + (j * 3)] = cl.B;
                        imageData[((i * src.WidthStep) + (j * 3)) + 1] = cl.G;
                        imageData[((i * src.WidthStep) + (j * 3)) + 2] = cl.R;
                    }
                }
            }
        }
        private void CheckTempSelectButton()
        {
            if (this.curNum == this.tempNum)
            {
                if (this.curNum == 0)
                {
                    this.button18.Enabled = false;
                    this.button19.Enabled = false;
                }
                else
                {
                    this.button18.Enabled = true;
                    this.button19.Enabled = true;
                }
            }
            else
            {
                this.button18.Enabled = true;
                this.button19.Enabled = true;
            }
            this.label50.Text = this.curNum.ToString();
        }
        private void ButtonInterlock(bool on)
        {
            if (on && !this.btnInterlock)
            {
                //this.openOToolStripMenuItem.Enabled = false;
                //this.saveSToolStripMenuItem.Enabled = false;
                //this.excsvEToolStripMenuItem.Enabled = false;
                //this.exitXToolStripMenuItem.Enabled = false;
                this.comboBox1_status = this.comboBox1.Enabled;
                this.button26.Enabled = false;
                this.button27.Enabled = false;
                this.button28.Enabled = false;
                this.button29.Enabled = false;
                this.button7.Enabled = false;
                this.button20.Enabled = false;
                //this.panel1.Enabled = false;
                this.button1_status = this.button1.Enabled;
                this.button2_status = this.button1.Enabled;
                this.button3_status = this.button3.Enabled;
                //this.button4_status = this.button4.Enabled;
                this.button21_status = this.button21.Enabled;
                this.buttonteaching_status = this.buttonteaching.Enabled;
                this.button17_status = this.button17.Enabled;
                this.button14_status = this.button14.Enabled;
                this.button8_status = this.button8.Enabled;
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                // this.button4.Enabled = false;
                this.button21.Enabled = false;
                this.buttonteaching.Enabled = false;
                this.button17.Enabled = false;
                this.button14.Enabled = false;
                this.button8.Enabled = false;
                //if (this.measureFlg)
                //{
                //    this.button10.Enabled = false;
                //    this.button11.Enabled = false;
                //    this.button12.Enabled = false;
                //    this.button23.Enabled = false;
                //    this.button38.Enabled = false;
                //}
                this.btnInterlock = true;
            }
            else if (!on && this.btnInterlock)
            {
                //this.openOToolStripMenuItem.Enabled = true;
                //this.saveSToolStripMenuItem.Enabled = true;
                //this.excsvEToolStripMenuItem.Enabled = true;
                //this.exitXToolStripMenuItem.Enabled = true;
                this.comboBox1.Enabled = this.comboBox1_status;
                this.button26.Enabled = true;
                this.button27.Enabled = true;
                this.button28.Enabled = true;
                this.button29.Enabled = true;
                this.button7.Enabled = true;
                if (!this.teachFlg)
                {
                    this.button20.Enabled = true;
                    //this.button37.Enabled = true;
                }
                //this.panel1.Enabled = true;
                this.button1.Enabled = this.button1_status;
                if (this.teachFlg || this.measureFlg)
                {
                    this.button2.Enabled = false;
                }
                else if (this.tempNum == 0)
                {
                    this.button2.Enabled = false;
                }
                else if ((this.tempNum > 0) && ((this.usbCam || this.gigeCam) || this.fileOpFlg))
                {
                    this.button2.Enabled = true;
                }
                else
                {
                    this.button2.Enabled = this.button2_status;
                }
                this.button3.Enabled = this.button3_status;
                //this.button4.Enabled = this.button4_status;
                this.button21.Enabled = this.button21_status;
                if ((this.pictureBox1.Image != null) && (this.srcImg != null))
                {
                    this.buttonteaching.Enabled = true;
                }
                else
                {
                    this.buttonteaching.Enabled = false;
                }
                this.button14.Enabled = false;
                this.button17.Enabled = false;
                if (this.teachFlg && (this.tempNum > 0))
                {
                    this.button14.Enabled = true;
                    if (this.tempNum > 0)
                    {
                        this.button17.Enabled = true;
                    }
                }
                if (this.teachFlg || this.measureFlg)
                {
                    this.button8.Enabled = false;
                }
                else if (this.diffImageFlg)
                {
                    this.button8.Enabled = true;
                }
                else
                {
                    this.button8.Enabled = false;
                }
                //this.button10.Enabled = true;
                //this.button11.Enabled = true;
                //this.button12.Enabled = true;
                //this.button23.Enabled = true;
                //this.button38.Enabled = true;
                this.btnInterlock = false;
            }
        }
        private void ImageDataSave(IplImage img, int num, string name, int judg)
        {
            if (judg == 0)
            {
                if (this.maxLatestImgSave > 0)
                {
                    Cv.SaveImage(this.srcImgPath + name, img, new ImageEncodingParam[0]);
                    OldFileSearchDel(this.srcImgPath, "*_PASS.png", this.maxLatestImgSave);
                }
            }
            else if (this.maxNgImgSave > 0)
            {
                Cv.SaveImage(this.ngImgPath + name, img, new ImageEncodingParam[0]);
                OldFileSearchDel(this.ngImgPath, "*_NG.png", this.maxNgImgSave);
            }
        }
        private void SetupScaleAngle(double angle, double step, double scmin, double scmax, double scstep)
        {
            double scaleMin;
            this.scaleMin = scmin;
            this.scaleMax = scmax;
            this.scaleStep = scstep;
            if (this.scaleStep == 0.0)
            {
                this.scaleStep = 1.0;
            }
            if (this.scaleMin > this.scaleMax)
            {
                scaleMin = this.scaleMin;
                this.scaleMin = this.scaleMax;
                this.scaleMax = scaleMin;
            }
            this.angleMin = angle * -1.0;
            this.angleMax = angle;
            this.angleStep = step;
            if (this.angleStep == 0.0)
            {
                this.angleStep = 1.0;
            }
            if (this.angleMin > this.angleMax)
            {
                scaleMin = this.angleMin;
                this.angleMin = this.angleMax;
                this.angleMax = scaleMin;
            }
            this.scaleNum = (int)Math.Round((double)(((this.scaleMax - this.scaleMin) / this.scaleStep) + 1.0), 0);
            this.angleNum = (int)Math.Round((double)(((this.angleMax - this.angleMin) / this.angleStep) + 1.0), 0);
        }
        private void SetupTemplateNumImages(int num, IplImage tmpimg, System.Drawing.Point pt)
        {
            double num2 = 0.0;
            if (this.scaleNum == 0)
            {
                this.scaleNum = 1;
            }
            if (this.angleNum == 0)
            {
                this.angleNum = 1;
            }
            this.tmpDataNum[num].tmpData = new TEMPLATE_DATA[1, 0x12d];
            this.tmpDataNum[num].pt = pt;
            this.tmpDataNum[num].refScaleID = 0;
            this.tmpDataNum[num].refAngleID = 0;
            this.refTmpID = new REF_TEMP_DATA();
            for (int i = 0; i < this.scaleNum; i++)
            {
                IplImage image;
                num2 = this.scaleMin + (i * this.scaleStep);
                double num3 = Math.Round(num2, 2, MidpointRounding.AwayFromZero);
                if (num3 != 1.0)
                {
                    image = Cv.CreateImage(Cv.Size((int)(tmpimg.Width * num3), (int)(tmpimg.Height * num3)), tmpimg.Depth, tmpimg.NChannels);
                    Cv.Resize(tmpimg, image, Interpolation.Lanczos4);
                }
                else
                {
                    image = Cv.CloneImage(tmpimg);
                }
                for (int j = 0; j < this.angleNum; j++)
                {
                    num2 = this.angleMin + (j * this.angleStep);
                    double angle = Math.Round(num2, 1, MidpointRounding.AwayFromZero);
                    this.tmpDataNum[num].tmpData[i, j].scale = num3;
                    this.tmpDataNum[num].tmpData[i, j].angle = angle;
                    this.tmpDataNum[num].tmpData[i, j].image = Cv.CreateImage(Cv.GetSize(image), image.Depth, image.NChannels);
                    if (angle != 0.0)
                    {
                        CvPoint2D32f center = Cv.Point2D32f(((float)image.Width) / 2f, ((float)image.Height) / 2f);
                        CvMat mapMatrix = Cv.CreateMat(3, 2, MatrixType.F32C1);
                        Cv._2DRotationMatrix(center, angle, 1.0, out mapMatrix);
                        Cv.WarpAffine(image, this.tmpDataNum[num].tmpData[i, j].image, mapMatrix, Interpolation.Area);
                    }
                    else
                    {
                        this.tmpDataNum[num].tmpData[i, j].image = image;
                    }
                    if ((num3 == 1.0) && (angle <= 0.0))
                    {
                        this.refTmpID.scaleID = i;
                        this.refTmpID.angleID = j;
                        this.tmpDataNum[num].refScaleID = i;
                        this.tmpDataNum[num].refAngleID = j;
                    }
                }
            }
        }
        private void DispMakeThumbnail(int num)
        {
            if (num >= 0)
            {
                using (IplImage image = new IplImage(Cv.Size(this.tmpDataNum[num].tmpData[this.tmpDataNum[num].refScaleID, this.tmpDataNum[num].refAngleID].image.Width, this.tmpDataNum[num].tmpData[this.tmpDataNum[num].refScaleID, this.tmpDataNum[num].refAngleID].image.Height), this.tmpDataNum[num].tmpData[this.tmpDataNum[num].refScaleID, this.tmpDataNum[num].refAngleID].image.Depth, this.tmpDataNum[num].tmpData[this.tmpDataNum[num].refScaleID, this.tmpDataNum[num].refAngleID].image.NChannels))
                {
                    Cv.Copy(this.tmpDataNum[num].tmpData[this.tmpDataNum[num].refScaleID, this.tmpDataNum[num].refAngleID].image, image);
                    Cv.Rectangle(image, 0, 0, image.Width - 1, image.Height - 1, Cv.RGB(0, 0, 0), 1);
                    if (this.refModelObjNum[num].mode > 0)
                    {
                        using (IplImage image2 = new IplImage(image.Size, image.Depth, 1))
                        {
                            using (IplImage image3 = new IplImage(image.Size, image.Depth, 1))
                            {
                                Cv.CvtColor(image, image2, ColorConversion.BgrToGray);
                                if (this.refModelObjNum[num].mode == 2)
                                {
                                    Cv.Threshold(image2, image3, (double)((int)this.numericUpDown21.Value), 255.0, ThresholdType.Binary);
                                    Cv.CvtColor(image3, image, ColorConversion.GrayToBgr);
                                }
                                else
                                {
                                    Cv.CvtColor(image2, image, ColorConversion.GrayToBgr);
                                }
                            }
                        }
                    }
                    this.pictureBox2.Image = image.ToBitmap();
                }
            }
        }
        private void DispSelectItem(int m)
        {
            if ((this.diffResult != null) && (m >= 0))
            {
                this.pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
                this.pictureBox7.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                this.pictureBox7.Image = this.diffResult[m].refimg;
                this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
                this.pictureBox4.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                this.pictureBox4.Image = this.diffResult[m].tgtimg;
                //this.pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
                //this.pictureBox8.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                //this.pictureBox8.Image = this.diffResult[m].refFilImg;
                // this.pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
                // this.pictureBox9.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                // this.pictureBox9.Image = this.diffResult[m].tgtFilImg;
                //this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                // this.pictureBox3.Image = this.diffResult[m].mskImg;
                this.pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
                this.pictureBox6.Image = this.diffResult[m].difBinImg;
                this.label73.Text = (m + 1).ToString();
                this.label58.Text = this.diffResult[m].matchRate.ToString("0.00");
                this.label59.Text = this.diffResult[m].diffArea.ToString("0.00");
                this.label64.Text = this.diffResult[m].whitePix.ToString();
                this.label67.Text = this.diffResult[m].angle.ToString("0.00");
            }
        }
        private void DispRefModelData(int num)
        {
            if ((num >= 0) && (this.refModelObjNum[num] != null))
            {
                this.radioButton1.Checked = this.refModelObjNum[num].thresholdColorMode;
                this.radioButton3.Checked = this.refModelObjNum[num].thresholdManualMode;
                this.trackBar1.Value = this.refModelObjNum[num].binaryAllThreshold;
                this.numericUpDown3.Value = this.trackBar1.Value;
                this.trackBar2.Value = this.refModelObjNum[num].binaryRedThreshold;
                this.numericUpDown4.Value = this.trackBar2.Value;
                this.trackBar3.Value = this.refModelObjNum[num].binaryGreenThreshold;
                this.numericUpDown5.Value = this.trackBar3.Value;
                this.trackBar4.Value = this.refModelObjNum[num].binaryBlueThreshold;
                this.numericUpDown6.Value = this.trackBar4.Value;
                this.trackBar6.Value = this.refModelObjNum[num].blobMinAreaThreshold;
                this.numericUpDown7.Value = this.trackBar6.Value;
                this.trackBar7.Value = this.refModelObjNum[num].blobMaxAreaThreshold;
                this.numericUpDown8.Value = this.trackBar7.Value;
                this.trackBar5.Value = (int)this.refModelObjNum[num].matchRateThreshold;
                this.numericUpDown9.Value = this.trackBar5.Value;
                this.trackBar8.Value = this.refModelObjNum[num].diffThreshold;
                this.numericUpDown10.Value = (decimal)Math.Round((double)(this.trackBar8.Value * 0.01), 2);
                this.comboBox3.Text = this.refModelObjNum[num].erodNumThreshold.ToString();
                this.comboBox4.Text = this.refModelObjNum[num].dilaNumThreshold.ToString();
                this.numericUpDown11.Value = this.refModelObjNum[num].searchPositionRangeX;
                this.numericUpDown12.Value = this.refModelObjNum[num].searchPositionRangeY;
                this.numericUpDown13.Value = (decimal)Math.Round(this.refModelObjNum[num].searchAngleRange, 2);
                this.numericUpDown14.Value = (decimal)Math.Round(this.refModelObjNum[num].searchAngleStep, 2);
                this.numericUpDown15.Value = (decimal)Math.Round(this.refModelObjNum[num].searchScaleMin, 2);
                this.numericUpDown16.Value = (decimal)Math.Round(this.refModelObjNum[num].searchScaleMax, 2);
                this.numericUpDown17.Value = (decimal)Math.Round(this.refModelObjNum[num].searchScaleStep, 2);
                this.comboBox5.Text = this.refModelObjNum[num].averageCount.ToString();
                this.comboBox2.Text = this.refModelObjNum[num].smoothParam.ToString();
                this.comboBox6.Text = this.refModelObjNum[num].smoothParam3.ToString();
                this.comboBox7.Text = this.refModelObjNum[num].smoothParam4.ToString();
                this.numericUpDown18.Value = (decimal)Math.Round((double)this.refModelObjNum[num].unsharpMask, 2);
                this.numericUpDown19.Value = (decimal)Math.Round((double)this.refModelObjNum[num].contrastCoef, 2);
                this.checkBox2.Checked = this.refModelObjNum[num].inspectEnabled;
                this.textBox1.Text = this.refModelObjNum[num].checkPointName;
                this.reverseX = this.refModelObjNum[num].reverseX;
                this.reverseY = this.refModelObjNum[num].reverseY;
                //if (this.reverseX)
                //{
                //    this.button24.ForeColor = Color.Cyan;
                //}
                //else
                //{
                //    this.button24.ForeColor = Color.WhiteSmoke;
                //}
                //if (this.reverseY)
                //{
                //    this.button25.ForeColor = Color.Cyan;
                //}
                //else
                //{
                //    this.button25.ForeColor = Color.WhiteSmoke;
                //}
                this.rotation90 = this.refModelObjNum[num].rotation90;
                this.rotation270 = this.refModelObjNum[num].rotation270;
                //if (this.rotation90)
                //{
                //    this.button31.ForeColor = Color.Cyan;
                //}
                //else
                //{
                //    this.button31.ForeColor = Color.WhiteSmoke;
                //}
                //if (this.rotation270)
                //{
                //    this.button32.ForeColor = Color.Cyan;
                //}
                //else
                //{
                //    this.button32.ForeColor = Color.WhiteSmoke;
                //}
                this.matcNG_Threshold = this.refModelObjNum[num].matcNG_Threshold;
                if (this.matcNG_Threshold == "OVER")
                {
                    this.radioButton8.Checked = true;
                }
                else
                {
                    this.matcNG_Threshold = "UNDER";
                    this.radioButton9.Checked = true;
                }
                this.diffNG_Threshold = this.refModelObjNum[num].diffNG_Threshold;
                if (this.diffNG_Threshold == "UNDER")
                {
                    this.radioButton11.Checked = true;
                }
                else
                {
                    this.diffNG_Threshold = "OVER";
                    this.radioButton10.Checked = true;
                }
                this.label2.Text = "No." + this.refModelObjNum[num].number.ToString();
                this.label46.Text = this.refModelObjNum[num].positionX.ToString();
                this.label47.Text = this.refModelObjNum[num].positionY.ToString();
                this.label48.Text = this.refModelObjNum[num].modelImg.Width.ToString();
                this.label49.Text = this.refModelObjNum[num].modelImg.Height.ToString();
                this.label50.Text = (num + 1).ToString();
                this.label52.Text = this.tempNum.ToString();
                r_rectList[num] = this.refModelObjNum[num].r_rect;
                this.trackBar9.Value = this.refModelObjNum[num].ptMatchBinaryThreshold;
                this.numericUpDown21.Value = this.trackBar9.Value;
                switch (this.refModelObjNum[num].mode)
                {
                    case 1:
                        this.radioButton6.Checked = true;
                        break;

                    case 2:
                        this.radioButton7.Checked = true;
                        break;

                    default:
                        this.radioButton5.Checked = true;
                        break;
                }
                this.MakeTempImage(num);
            }

        }
        private void CheckPresetData()
        {
            for (int i = 1; i <= 4; i++)
            {
                if (this.VerifyPresetData(i))
                {
                    switch (i)
                    {
                        case 1:
                            this.button26.ForeColor = Color.Red;
                            this.button27.ForeColor = Color.Black;
                            this.button28.ForeColor = Color.Black;
                            this.button29.ForeColor = Color.Black;
                            return;

                        case 2:
                            this.button26.ForeColor = Color.Black;
                            this.button27.ForeColor = Color.Red;
                            this.button28.ForeColor = Color.Black;
                            this.button29.ForeColor = Color.Black;
                            return;

                        case 3:
                            this.button26.ForeColor = Color.Black;
                            this.button27.ForeColor = Color.Black;
                            this.button28.ForeColor = Color.Red;
                            this.button29.ForeColor = Color.Black;
                            return;

                        case 4:
                            this.button26.ForeColor = Color.Black;
                            this.button27.ForeColor = Color.Black;
                            this.button28.ForeColor = Color.Black;
                            this.button29.ForeColor = Color.Red;
                            return;
                    }
                    return;
                }
                this.button26.ForeColor = Color.Black;
                this.button27.ForeColor = Color.Black;
                this.button28.ForeColor = Color.Black;
                this.button29.ForeColor = Color.Black;
            }
        }

        private void MakeTempImage(int num)
        {
            using (IplImage image = new IplImage(Cv.Size(this.refModelObjNum[num].modelImg.Width, this.refModelObjNum[num].modelImg.Height), BitDepth.U8, 3))
            {
                Cv.Copy(OpenCvSharp.Extensions.BitmapConverter.ToIplImage(this.refModelObjNum[num].modelImg), image);
                this.SetupScaleAngle(this.tmpAngleRange, this.tmpAngleStep, this.tmpScaleMin, this.tmpScaleMax, this.tmpScaleStep);
                System.Drawing.Point pt = new System.Drawing.Point(this.refModelObjNum[num].positionX, this.refModelObjNum[num].positionY);
                this.SetupTemplateNumImages(num, image, pt);
                if (!this.measureFlg)
                {
                    this.DispMakeThumbnail(num);
                }
            }
        }
        private RefModel SaveRefModel(int num, string name, Bitmap bitmapImg)
        {
            int mode = 0;
            if (this.radioButton7.Checked)
            {
                mode = 2;
            }
            else if (this.radioButton6.Checked)
            {
                mode = 1;
            }
            string str = name;
            Regex regex = new Regex("[^0-9]");
            return new RefModel(str, bitmapImg, this.trackBar8.Value, 0L, (double)this.trackBar5.Value, this.trackBar1.Value, this.trackBar2.Value, this.trackBar3.Value, this.trackBar4.Value, this.trackBar6.Value, this.trackBar7.Value, int.Parse(this.comboBox3.Text), int.Parse(this.comboBox4.Text), int.Parse(regex.Replace(this.label2.Text, "")), int.Parse(this.label46.Text), int.Parse(this.label47.Text), (int)this.numericUpDown11.Value, (int)this.numericUpDown12.Value, (double)this.numericUpDown13.Value, (double)this.numericUpDown14.Value, (double)this.numericUpDown15.Value, (double)this.numericUpDown16.Value, (double)this.numericUpDown17.Value, mode, this.tempNum, r_rectList[num], this.radioButton1.Checked, this.radioButton3.Checked, int.Parse(this.comboBox5.Text), int.Parse(this.comboBox2.Text), int.Parse(this.comboBox6.Text), int.Parse(this.comboBox7.Text), (float)this.numericUpDown18.Value, (float)this.numericUpDown19.Value, this.checkBox2.Checked, this.textBox1.Text, this.reverseX, this.reverseY, this.srcImgWidth, this.srcImgHeight, this.svDstPnt, this.svArea, (int)this.numericUpDown21.Value, this.rotation90, this.rotation270, this.matcNG_Threshold, this.diffNG_Threshold);
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (Cursor.Current != Cursors.Default)
            {
                Cursor.Current = Cursors.Default;
            }

            this.Refresh();
            Application.DoEvents();

        }
        private CvScalar GetColorCode(int num)
        {
            int num2 = num % 10;
            CvScalar scalar = Cv.RGB(0, 0, 0);
            switch (num2)
            {
                case 0:
                    return Cv.RGB(0, 0, 0);

                case 1:
                    return Cv.RGB(0x99, 0x4c, 0);

                case 2:
                    return Cv.RGB(0xff, 0, 0);

                case 3:
                    return Cv.RGB(0xff, 0x66, 0);

                case 4:
                    return Cv.RGB(0xff, 210, 0);

                case 5:
                    return Cv.RGB(0, 0x80, 0);

                case 6:
                    return Cv.RGB(0, 0, 0xff);

                case 7:
                    return Cv.RGB(0x80, 0, 0x80);

                case 8:
                    return Cv.RGB(0x80, 0x80, 0x80);

                case 9:
                    return Cv.RGB(0xff, 0xff, 0xff);
            }
            return scalar;
        }
        private string GetStatus()
        {
            if (this.measureFlg)
            {
                return "1";
            }
            if (this.teachFlg)
            {
                return "2";
            }
            if (this.capture)
            {
                return "3";
            }
            return "0";
        }



        private void ShapeMeasure()
        {
            if (this.dstImg != null)
            {
                using (IplImage image = new IplImage(this.dstImg.Size, this.dstImg.Depth, this.dstImg.NChannels))
                {
                    Cv.Copy(this.dstImg, image);
                    CvRect rect = new CvRect((image.Width / 0x18) / 2, (image.Height / 0x18) / 2, image.Width - (image.Width / 0x18), image.Height - (image.Height / 0x18));
                    Rectangle rectangle = new Rectangle();
                    new CvPoint(0, 0);
                    new CvPoint(0, 0);
                    new CvPoint(0, 0);
                    new CvPoint(0, 0);
                    CvPoint[] pointArray = new CvPoint[4];
                    RotatedRect rect2 = new RotatedRect();
                    if (this.curNum <= this.tempNum)
                    {
                        if (((this.r_rect.Width < 1) || (this.r_rect.Height < 1)) && (this.curEdit && (this.curNum > 0)))
                        {
                            rectangle = r_rectList[this.curNum - 1];
                        }
                        else
                        {
                            rectangle = this.r_rect;
                        }
                    }
                    this.svArea = 0.0;
                    for (int i = 0; i < 4; i++)
                    {
                        this.svDstPnt[i] = new System.Drawing.Point();
                    }
                    if ((rectangle.Width > 1) && (rectangle.Height > 1))
                    {
                        rect.Width = rectangle.Width;
                        rect.Height = rectangle.Height;
                        rect.X = rectangle.X;
                        rect.Y = rectangle.Y;
                    }
                    else
                    {
                        rect = new CvRect(0, 0, image.Width, image.Height);
                    }
                    using (IplImage image2 = new IplImage(rect.Width, rect.Height, image.Depth, image.NChannels))
                    {
                        Cv.SetImageROI(image, rect);
                        Cv.Copy(image, image2);
                        Cv.ResetImageROI(image);
                        using (IplImage image3 = new IplImage(rect.Width, rect.Height, BitDepth.U8, 1))
                        {
                            Cv.CvtColor(image2, image3, ColorConversion.BgrToGray);
                            if (this.checkBox9.Checked)
                            {
                                // Cv.Threshold(image3, image3, (double)this.numericUpDown28.Value, 255.0, ThresholdType.BinaryInv); // goc

                                Cv.Threshold(image3, image3, (double)this.numericUpDown21.Value, 255.0, ThresholdType.BinaryInv); // threshold voi numericUpDown21 thay the
                            }
                            else
                            {
                                //Cv.Threshold(image3, image3, (double)this.numericUpDown28.Value, 255.0, ThresholdType.BinaryInv);
                                Cv.Threshold(image3, image3, (double)this.numericUpDown21.Value, 255.0, ThresholdType.BinaryInv);
                            }
                            this.tmpcontour = this.EdgeCheck(image3, this.tmpStorage);
                        }
                        double parameter = (double)this.numericUpDown29.Value;
                        if (this.tmpcontour != null)
                        {
                            this.tmpcontour = Cv.ApproxPoly(this.tmpcontour, this.header_size, this.tmpStorage, ApproxPolyMethod.DP, parameter, true);
                        }
                        this.min_area = (image.Width / 100) * (image.Height / 100);
                        this.max_area = (image.Width - (image.Width / 10)) * (image.Height - (image.Height / 10));
                        // this.min_area = (int)this.numericUpDown24.Value;
                        // this.max_area = (int)this.numericUpDown25.Value;
                        this.tmpArea = Math.Abs(Cv.ContourArea(this.tmpcontour, CvSlice.WholeSeq));
                        this.tmpLength = Cv.ArcLength(this.tmpcontour, CvSlice.WholeSeq, 1);
                        CvBox2D boxd = new CvBox2D();
                        this.tmpAngle = 0.0;
                        double tmpArea = 0.0;
                        int num = 0;
                        while (this.tmpcontour != null)
                        {
                            if (this.tmpcontour.Total >= 5)
                            {
                                this.tmpArea = Math.Abs(Cv.ContourArea(this.tmpcontour, CvSlice.WholeSeq));
                                this.tmpLength = Cv.ArcLength(this.tmpcontour, CvSlice.WholeSeq, 1);
                                boxd = Cv.FitEllipse2(this.tmpcontour);
                                this.tmpAngle = boxd.Angle;
                                if ((this.tmpArea > this.min_area) && (this.tmpArea < this.max_area))
                                {
                                    CvFont font;
                                    int num7;
                                    tmpArea = this.tmpArea;
                                    this.svArea = tmpArea;
                                    rect2 = Cv.MinAreaRect2(this.tmpcontour);
                                    Point2f[] pointfArray = new Point2f[4];
                                    pointfArray = rect2.Points();
                                    pointArray[0].X = ((int)Math.Round((double)pointfArray[3].X)) + rect.X;
                                    pointArray[0].Y = ((int)Math.Round((double)pointfArray[3].Y)) + rect.Y;
                                    pointArray[1].X = ((int)Math.Round((double)pointfArray[0].X)) + rect.X;
                                    pointArray[1].Y = ((int)Math.Round((double)pointfArray[0].Y)) + rect.Y;
                                    pointArray[2].X = ((int)Math.Round((double)pointfArray[1].X)) + rect.X;
                                    pointArray[2].Y = ((int)Math.Round((double)pointfArray[1].Y)) + rect.Y;
                                    pointArray[3].X = ((int)Math.Round((double)pointfArray[2].X)) + rect.X;
                                    pointArray[3].Y = ((int)Math.Round((double)pointfArray[2].Y)) + rect.Y;
                                    num++;
                                    CvScalar colorCode = this.GetColorCode(num);
                                    Cv.DrawContours(image, this.tmpcontour, colorCode, colorCode, 0, 1, LineType.AntiAlias, Cv.Point(rect.X, rect.Y));
                                    for (int j = 0; j < 4; j++)
                                    {
                                        Cv.Line(image, pointArray[j], pointArray[(j + 1) % 4], colorCode, 1);
                                    }
                                    CvPoint center = new CvPoint(((int)rect2.Center.X) + rect.X, ((int)rect2.Center.Y) + rect.Y);
                                    Cv.Circle(image, center, 2, colorCode, 1);
                                    double hscale = ((double)this.srcImgWidth) / 1800.0;
                                    Cv.InitFont(out font, FontFace.Vector0, hscale, hscale, 0.0, 1, LineType.AntiAlias);
                                    CvSize textSize = new CvSize();
                                    Cv.GetTextSize("1", font, out textSize, out num7);
                                    pointArray[0].X += textSize.Height / 2;
                                    pointArray[0].Y -= textSize.Height / 2;
                                    Cv.PutText(image, num.ToString(), pointArray[0], font, colorCode);
                                    this.refMeasWidthL = rect2.Size.Width;
                                    //this.label75.Text = this.ppmW.ToString("0.000000");
                                    if (rect2.Size.Width > rect2.Size.Height)
                                    {
                                        center.Y += (int)(rect2.Size.Height / 10f);
                                    }
                                    else
                                    {
                                        center.Y += (int)(rect2.Size.Width / 10f);
                                    }
                                    center.Y += 100;
                                    center.X = 4;
                                    //center.Y = ((this.label9.Location.Y + this.label9.Height) + 20) + (num * (textSize.Height + 5));
                                    string str = (rect2.Size.Width * this.ppmW).ToString("0.000");
                                    string[] strArray = new string[] { num.ToString(), " W:", str, " D:", (rect2.Size.Height * this.ppmW).ToString("0.000"), " A:", tmpArea.ToString() };
                                    Cv.PutText(image, string.Concat(strArray), center, font, colorCode);
                                }
                            }
                            this.tmpcontour = this.tmpcontour.HNext;
                        }
                        this.pictureBox1.Image = image.ToBitmap();
                    }
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            double num43;
            switch (this.stat)
            {
                case 0x67:
                    if (((this.curNum - 1) < this.tempNum) && (this.curNum > 0))
                    {
                        if (this.backgroundWorker.Length >= this.curNum)
                        {
                            if (!this.backgroundWorker[this.curNum - 1].IsBusy)
                            {
                                int num20 = 0;
                                if (this.radioButton6.Checked)
                                {
                                    num20 = 1;
                                }
                                else if (this.radioButton7.Checked)
                                {
                                    num20 = 2;
                                }
                                this.tempDataBKG.mode = num20;
                                this.tempDataBKG.ptMatchBinThreshold = (int)this.numericUpDown21.Value;
                                this.tempDataBKG.tmpData = this.tmpDataNum[this.curNum - 1].tmpData;
                                this.tempDataBKG.refTmpID.scaleID = this.tmpDataNum[this.curNum - 1].refScaleID;
                                this.tempDataBKG.refTmpID.angleID = this.tmpDataNum[this.curNum - 1].refAngleID;
                                this.tempDataBKG.tgtArea = this.SetSearcArea(this.rszImg, this.curNum - 1, this.tmpDataNum[this.curNum - 1], this.image_offsetX, this.image_offsetY, this.searchAreaOffsetX + this.search_offsetX, this.searchAreaOffsetY + this.search_offsetY);
                                this.tempDataBKG.scaleNumber = this.scaleNum;
                                this.tempDataBKG.anglenumber = this.angleNum;
                                //this.bkgFlg[this.curNum - 1] = false;
                                //this.backgroundWorker[this.curNum - 1].RunWorkerAsync(this.tempDataBKG);
                                this.stat = 0x68;
                                this.sw.Restart();
                                return;
                            }
                            this.stat = 0;
                            this.timer1.Enabled = false;
                            return;
                        }
                        this.stat = 0;
                        this.timer1.Enabled = false;
                    }
                    return;

                case 0x68:
                    if ((((this.curNum - 1) < this.tempNum) && (this.curNum > 0)) && (this.bkgFlg[this.curNum - 1] || (this.sw.ElapsedMilliseconds > 0x927c0L)))
                    {
                        this.sw.Stop();
                        int index = this.curNum - 1;
                        this.tmpResult = this.tmpMatchResult[index];
                        double score = this.tmpResult.Score;
                        using (IplImage image6 = new IplImage(this.tmpDataNum[index].tmpData[this.tmpDataNum[index].refScaleID, this.tmpDataNum[index].refAngleID].image.Size, this.tmpDataNum[index].tmpData[this.tmpDataNum[index].refScaleID, this.tmpDataNum[index].refAngleID].image.Depth, this.tmpDataNum[index].tmpData[this.tmpDataNum[index].refScaleID, this.tmpDataNum[index].refAngleID].image.NChannels))
                        {
                            if (this.tmpDataNum[index].tmpData[this.tmpMatchResult[index].ScaleID, this.tmpMatchResult[index].AngleID].image != null)
                            {
                                Cv.Copy(this.tmpDataNum[index].tmpData[this.tmpMatchResult[index].ScaleID, this.tmpMatchResult[index].AngleID].image, image6);
                            }
                            else
                            {
                                Cv.Copy(this.tmpDataNum[index].tmpData[this.tmpDataNum[index].refScaleID, this.tmpDataNum[index].refAngleID].image, image6);
                            }
                            CvPoint point = new CvPoint
                            {
                                X = this.tmpResult.Location.X,
                                Y = this.tmpResult.Location.Y
                            };
                            CvPoint point2 = new CvPoint
                            {
                                X = this.tmpResult.Location.X + image6.Width,
                                Y = this.tmpResult.Location.Y + image6.Height
                            };
                            if (point.X < 0)
                            {
                                point.X = 0;
                            }
                            if (point.Y < 0)
                            {
                                point.Y = 0;
                            }
                            if (point2.X >= this.rszImg.Width)
                            {
                                point2.X = this.rszImg.Width - 1;
                            }
                            if (point2.Y >= this.rszImg.Height)
                            {
                                point2.Y = this.rszImg.Height - 1;
                            }
                            CvRect rect2 = new CvRect
                            {
                                Size = image6.Size,
                                X = this.tmpResult.Location.X,
                                Y = this.tmpResult.Location.Y
                            };
                            using (IplImage image7 = new IplImage(rect2.Width, rect2.Height, image6.Depth, image6.NChannels))
                            {
                                Cv.SetImageROI(this.rszImg, rect2);
                                Cv.Copy(this.rszImg, image7);
                                Cv.ResetImageROI(this.rszImg);
                                using (IplImage image8 = new IplImage(image6.Size, BitDepth.U8, 1))
                                {
                                    using (IplImage image9 = new IplImage(image6.Size, BitDepth.U8, 1))
                                    {
                                        int num23 = 0;
                                        if (this.radioButton7.Checked)
                                        {
                                            num23 = 2;
                                        }
                                        else if (this.radioButton6.Checked)
                                        {
                                            num23 = 1;
                                        }
                                        if (num23 > 0)
                                        {
                                            Cv.CvtColor(image6, image8, ColorConversion.BgrToGray);
                                            if (num23 == 2)
                                            {
                                                Cv.Threshold(image8, image9, (double)((int)this.numericUpDown21.Value), 255.0, ThresholdType.Binary);
                                                Cv.CvtColor(image9, image6, ColorConversion.GrayToBgr);
                                            }
                                            else
                                            {
                                                Cv.CvtColor(image8, image6, ColorConversion.GrayToBgr);
                                            }
                                            Cv.CvtColor(image7, image8, ColorConversion.BgrToGray);
                                            if (num23 == 2)
                                            {
                                                Cv.Threshold(image8, image9, (double)((int)this.numericUpDown21.Value), 255.0, ThresholdType.Binary);
                                                Cv.CvtColor(image9, image7, ColorConversion.GrayToBgr);
                                            }
                                            else
                                            {
                                                Cv.CvtColor(image8, image7, ColorConversion.GrayToBgr);
                                            }
                                        }
                                    }
                                }
                                int thickness = 1;
                                int num25 = 0;
                                int num26 = 0;
                                Cv.Rectangle(image7, 0, 0, image7.Width - num25, image7.Height - num26, Cv.RGB(0, 0, 0), thickness);
                                Cv.Rectangle(image6, 0, 0, image6.Width - num25, image6.Height - num26, Cv.RGB(0, 0, 0), thickness);
                                // this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                                //this.pictureBox3.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                                this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
                                this.pictureBox4.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                                this.pictureBox4.Image = image7.ToBitmap();
                                this.pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
                                this.pictureBox7.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                                this.pictureBox7.Image = image6.ToBitmap();
                                using (IplImage image10 = new IplImage(image6.Size, image6.Depth, image6.NChannels))
                                {
                                    using (IplImage image11 = new IplImage(image6.Size, image6.Depth, image6.NChannels))
                                    {
                                        using (IplImage image12 = new IplImage(image7.Size, image7.Depth, image7.NChannels))
                                        {
                                            using (IplImage image13 = new IplImage(image7.Size, image7.Depth, image7.NChannels))
                                            {
                                                Cv.Copy(image6, image10);
                                                Cv.Copy(image7, image12);
                                                float k = (float)this.numericUpDown18.Value;
                                                if (k > 1.0)
                                                {
                                                    CvUnsharpMasking(image6, image10, k);
                                                    CvUnsharpMasking(image7, image12, k);
                                                }
                                                int num28 = int.Parse(this.comboBox2.Text);
                                                int num29 = num28;
                                                int num30 = int.Parse(this.comboBox6.Text);
                                                int num31 = int.Parse(this.comboBox7.Text);
                                                if (num28 > 0)
                                                {
                                                    Cv.Smooth(image10, image11, SmoothType.Bilateral, num28, num29, (double)num30, (double)num31);
                                                    Cv.Smooth(image11, image10, SmoothType.Bilateral, num28, num29, (double)num30, (double)num31);
                                                    Cv.Smooth(image12, image13, SmoothType.Bilateral, num28, num29, (double)num30, (double)num31);
                                                    Cv.Smooth(image13, image12, SmoothType.Bilateral, num28, num29, (double)num30, (double)num31);
                                                }
                                                float a = (float)this.numericUpDown19.Value;
                                                if (a > 0f)
                                                {
                                                    CvContrast(image10, image10, a);
                                                    CvContrast(image12, image12, a);
                                                }
                                                //this.pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
                                                //this.pictureBox8.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                                                //this.pictureBox8.Image = image10.ToBitmap();
                                                //this.pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
                                                //this.pictureBox9.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                                                //this.pictureBox9.Image = image12.ToBitmap();
                                                this.dstdifimg = new IplImage();
                                                this.DifferentImage(image10, image12, out this.dstdifimg);
                                            }
                                        }
                                    }
                                }
                            }
                            int iterations = int.Parse(this.comboBox3.Text);
                            Cv.Erode(this.dstdifimg, this.dstdifimg, null, iterations);
                            int num34 = int.Parse(this.comboBox4.Text);
                            Cv.Dilate(this.dstdifimg, this.dstdifimg, null, num34);
                            this.dstBinDifimg = new IplImage(this.dstdifimg.Size, this.dstdifimg.Depth, this.dstdifimg.NChannels);
                            this.grayImg = new IplImage(this.dstdifimg.Size, BitDepth.U8, 1);
                            if (!this.radioButton1.Checked && this.radioButton3.Checked)
                            {
                                this.diffThreshold = this.trackBar1.Value;
                                Cv.Threshold(this.dstdifimg, this.dstBinDifimg, (double)this.diffThreshold, 255.0, ThresholdType.Binary);
                                Cv.CvtColor(this.dstBinDifimg, this.grayImg, ColorConversion.BgrToGray);
                            }
                            else if (this.radioButton1.Checked && this.radioButton3.Checked)
                            {
                                if ((this.trackBar4.Value == this.trackBar3.Value) && (this.trackBar4.Value == this.trackBar2.Value))
                                {
                                    this.diffThreshold = this.trackBar1.Value;
                                    Cv.Threshold(this.dstdifimg, this.dstBinDifimg, (double)this.diffThreshold, 255.0, ThresholdType.Binary);
                                    Cv.CvtColor(this.dstBinDifimg, this.grayImg, ColorConversion.BgrToGray);
                                }
                                else
                                {
                                    IplImage[] imageArray = new IplImage[4];
                                    for (int i = 0; i < 4; i++)
                                    {
                                        imageArray[i] = new IplImage(this.dstdifimg.Size, BitDepth.U8, 1);
                                    }
                                    Cv.Split(this.dstdifimg, imageArray[0], imageArray[1], imageArray[2], null);
                                    this.diffThreshold = this.trackBar4.Value;
                                    Cv.Threshold(imageArray[0], imageArray[0], (double)this.diffThreshold, 255.0, ThresholdType.Binary);
                                    this.diffThreshold = this.trackBar3.Value;
                                    Cv.Threshold(imageArray[1], imageArray[1], (double)this.diffThreshold, 255.0, ThresholdType.Binary);
                                    this.diffThreshold = this.trackBar2.Value;
                                    Cv.Threshold(imageArray[2], imageArray[2], (double)this.diffThreshold, 255.0, ThresholdType.Binary);
                                    Cv.Merge(imageArray[0], imageArray[1], imageArray[2], null, this.dstBinDifimg);
                                    Cv.CvtColor(this.dstBinDifimg, this.grayImg, ColorConversion.BgrToGray);
                                }
                            }
                            else if (this.radioButton1.Checked && !this.radioButton3.Checked)
                            {
                                IplImage[] imageArray2 = new IplImage[4];
                                for (int j = 0; j < 4; j++)
                                {
                                    imageArray2[j] = new IplImage(this.dstdifimg.Size, BitDepth.U8, 1);
                                }
                                Cv.Split(this.dstdifimg, imageArray2[0], imageArray2[1], imageArray2[2], null);
                                Cv.Threshold(imageArray2[0], imageArray2[0], 0.0, 255.0, ThresholdType.Otsu);
                                Cv.Threshold(imageArray2[1], imageArray2[1], 0.0, 255.0, ThresholdType.Otsu);
                                Cv.Threshold(imageArray2[2], imageArray2[2], 0.0, 255.0, ThresholdType.Otsu);
                                Cv.Merge(imageArray2[0], imageArray2[1], imageArray2[2], null, this.dstBinDifimg);
                                Cv.CvtColor(this.dstBinDifimg, this.grayImg, ColorConversion.BgrToGray);
                            }
                            else
                            {
                                Cv.CvtColor(this.dstdifimg, this.grayImg, ColorConversion.BgrToGray);
                                Cv.Threshold(this.grayImg, this.grayImg, 0.0, 255.0, ThresholdType.Otsu);
                            }
                            using (IplImage image14 = new IplImage(this.dstdifimg.Size, BitDepth.U8, 1))
                            {
                                using (IplImage image15 = new IplImage(this.srcImg.Size, this.srcImg.Depth, this.srcImg.NChannels))
                                {
                                    using (new IplImage(this.srcImg.Size, BitDepth.U8, 1))
                                    {
                                        if (this.radioButton1.Checked)
                                        {
                                            Cv.CvtColor(this.dstBinDifimg, image14, ColorConversion.BgrToGray);
                                        }
                                        else
                                        {
                                            Cv.Copy(this.grayImg, image14);
                                        }
                                        CvBlobs blobs = new CvBlobs(image14);
                                        int minArea = this.trackBar6.Value;
                                        int maxArea = this.trackBar7.Value;
                                        if (maxArea == 0)
                                        {
                                            blobs.FilterByArea(minArea, 0x7fffffff);
                                        }
                                        else
                                        {
                                            blobs.FilterByArea(minArea, maxArea);
                                        }
                                        IplImage imgDest = new IplImage(this.dstBinDifimg.Size, BitDepth.U8, 3);
                                        imgDest.Zero();
                                        blobs.RenderBlobs(this.dstBinDifimg, imgDest, RenderBlobsMode.None | RenderBlobsMode.Color);
                                        this.diffThreshold = this.trackBar1.Value;
                                        Cv.Threshold(imgDest, this.dstBinDifimg, (double)this.diffThreshold, 255.0, ThresholdType.Binary);
                                        imgDest.Dispose();
                                        long pWhitePixelCount = 0L;
                                        long pBlackPixelCount = 0L;
                                        double num41 = 0.0;
                                        //this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                                        // this.pictureBox3.Image = image14.ToBitmap();
                                        this.pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
                                        this.pictureBox6.Image = this.dstBinDifimg.ToBitmap();
                                        using (IplImage image18 = new IplImage(this.dstdifimg.Size, BitDepth.U8, 1))
                                        {
                                            Cv.CvtColor(this.dstBinDifimg, image18, ColorConversion.BgrToGray);
                                            ThreshImagePixcelCountProc(image18, this.diffThreshold, out pWhitePixelCount, out pBlackPixelCount);
                                            num41 = (((double)pWhitePixelCount) / ((double)(pWhitePixelCount + pBlackPixelCount))) * 100.0;
                                        }
                                        this.label73.Text = this.curNum.ToString();
                                        this.label58.Text = score.ToString("0.00");
                                        this.label59.Text = num41.ToString("0.00");
                                        this.label64.Text = pWhitePixelCount.ToString();
                                        this.label67.Text = this.tmpResult.Angle.ToString("0.00");
                                        this.FillImage(this.dstBinDifimg, this.dstBinDifimg, Color.DarkRed);
                                        Cv.Zero(image15);
                                        CvRect rect3 = new CvRect((image15.Width / 2) - (this.rszImg.Width / 2), (image15.Height / 2) - (this.rszImg.Height / 2), this.rszImg.Width, this.rszImg.Height);
                                        Cv.SetImageROI(image15, rect3);
                                        Cv.Copy(this.rszImg, image15);
                                        Cv.ResetImageROI(image15);
                                    }
                                }
                            }
                        }
                        this.CheckTempSelectButton();
                        this.timer1.Enabled = false;
                        this.stat = 0;
                        this.ButtonInterlock(false);
                        if (Cursor.Current != Cursors.Default)
                        {
                            Cursor.Current = Cursors.Default;
                        }
                    }
                    return;

                case 0x385:
                    if (this.tmpBkgwFlg == 1)
                    {
                        this.sw_thTime.Stop();
                        this.tmpMatchStartBgWorker.Dispose();
                        this.fstView = false;
                        this.ngview = false;
                        this.tmpMatch = false;
                        this.retry = new int[this.tempNum];
                        this.stat = 0x5b;
                        this.sw.Restart();
                        return;
                    }
                    if ((this.tmpBkgwFlg == -1) || (this.sw_thTime.ElapsedMilliseconds > (((this.tempNum * this.scaleNum) * this.angleNum) * 500)))
                    {
                        this.sw_thTime.Stop();
                        this.label100.Visible = false;
                        this.measureFlg = false;
                        this.stat = 0;
                        this.timer1.Enabled = false;
                        this.ButtonInterlock(false);
                        this.swt.Stop();
                        num43 = ((double)this.swt.ElapsedMilliseconds) / 1000.0;
                        // this.label61.Text = "time : " + num43.ToString("#0.00") + " [sec]";
                        //if (((this.cmdExec != "") && this.comPortConfig.enabled) && (this.comPortConfig.serialMode > 0))
                        //{
                        //    // this.TransmitDataWrite(this.startMark + this.modelsMark + this.comPortConfig.serialID.ToString("X1") + this.cmdExec + "ER");
                        //    this.cmdExec = "";
                        //}
                        this.label100.Visible = false;
                        this.pictureBox6.Image = null;
                        this.pictureBox1.Image = null;
                        if (this.tmpBkgwFlg == -1)
                        {
                            this.label74.Text = "Info: CANCEL  TEMPLATE MATCHING ";
                            //  logger.Info("=== ERROR : CANCEL TEMPLATE MATCHING ===");
                            return;
                        }
                        this.label74.Text = "Info: TIMEOUT  TEMPLATE MATCHING ";
                        //  logger.Info("=== ERROR : TIMEOUT TEMPLATE MATCHING ===");
                    }
                    return;

                case 910:
                    this.difImgData = new DIFFIMAGE_DATA();
                    for (int m = 0; m < this.tempNum; m++)
                    {
                        if (this.refModelObjNum[m].inspectEnabled)
                        {
                            if (!this.difbkgFlg[m] && !this.diffBgWorker[m].IsBusy)
                            {
                                this.difImgData.id = m;
                                this.difImgData.rimg = this.rszImg;
                                this.difImgData.tmpimg = this.tmpDataNum[m].tmpData[this.tmpMatchResult[m].ScaleID, this.tmpMatchResult[m].AngleID].image;
                                this.diffBgWorker[m].RunWorkerAsync(this.difImgData);
                            }
                        }
                        else
                        {
                            this.difbkgFlg[m] = true;
                            this.diffResult[m].angle = 0.0;
                            this.diffResult[m].difBinImg = null;
                            this.diffResult[m].diffArea = 0.0;
                            this.diffResult[m].diffImg = null;
                            this.diffResult[m].matchRate = 0.0;
                            this.diffResult[m].mskImg = null;
                            this.diffResult[m].no = m;
                            this.diffResult[m].rect = new CvRect();
                            this.diffResult[m].refFilImg = null;
                            this.diffResult[m].refimg = null;
                            this.diffResult[m].tgtFilImg = null;
                            this.diffResult[m].tgtimg = null;
                            this.diffResult[m].whitePix = 0L;
                        }
                    }
                    for (int n = 0; n < this.tempNum; n++)
                    {
                        if (!this.difbkgFlg[n])
                        {
                            this.label100.Text = "DIFFERENTIALS " + ((int)((((float)(n + 1)) / ((float)this.tempNum)) * 100f)) + " %";
                            this.label100.Location = new System.Drawing.Point((this.pictureBox1.Location.X + (this.pictureBox1.Width / 2)) - (this.label100.Width / 2), ((this.pictureBox1.Location.Y + (this.pictureBox1.Height / 2)) - (this.label100.Height / 2)) - 70);
                            return;
                        }
                        this.diffBgWorker[n].Dispose();
                    }
                    this.diffBgWorker = null;
                    this.stat = 0x38f;
                    return;

                case 0x38f:
                    if (!this.difDispBgWorker.IsBusy)
                    {
                        for (int num12 = 0; num12 < this.tempNum; num12++)
                        {
                            this.diffResult[num12].matchRate = this.measurementsMatchRate[num12];
                        }
                        this.diffDispBkgFlg = 0;
                        this.diffImgFull = null;
                        this.sw_thTime.Restart();
                        this.difDispBgWorker.WorkerReportsProgress = true;
                        this.difDispBgWorker.RunWorkerAsync(this.tempNum);
                        this.label100.Text = "";
                        this.stat = 0x390;
                        return;
                    }
                    return;

                case 0x390:
                    if (this.diffDispBkgFlg != 1)
                    {
                        if ((this.diffDispBkgFlg < 0) || (this.sw_thTime.ElapsedMilliseconds > (this.tempNum * 500)))
                        {
                            this.sw_thTime.Stop();
                            this.label100.Visible = false;
                            this.measureFlg = false;
                            this.stat = 0;
                            this.timer1.Enabled = false;
                            this.ButtonInterlock(false);
                            this.swt.Stop();
                            num43 = ((double)this.swt.ElapsedMilliseconds) / 1000.0;
                            //this.label61.Text = "time : " + num43.ToString("#0.00") + " [sec]";
                            //if (((this.cmdExec != "") && this.comPortConfig.enabled) && (this.comPortConfig.serialMode > 0))
                            //{
                            //    this.TransmitDataWrite(this.startMark + this.modelsMark + this.comPortConfig.serialID.ToString("X1") + this.cmdExec + "ER");
                            //    this.cmdExec = "";
                            //}
                            this.pictureBox6.Image = null;
                            this.pictureBox1.Image = null;
                            //if (this.diffDispBkgFlg == -1)
                            //{
                            //    logger.Info("=== ERROR : CANCEL DIFFERENTIALS ===");
                            //    return;
                            //}
                            //if (this.diffDispBkgFlg == -2)
                            //{
                            //    logger.Info("=== ERROR : NULL DIFFERENTIALS ===");
                            //    return;
                            //}
                            //logger.Info("=== ERROR : TIMEOUT DIFFERENTIALS ===");
                        }
                        return;
                    }
                    this.sw_thTime.Stop();
                    this.label100.Visible = false;
                    this.paintRectangleEnabled = true;
                    this.difDispBgWorker.Dispose();
                    this.stat = 0x5c;
                    return;

                case 0:
                    if (this.capture)
                    {//!this.backgroundWorker1.IsBusy &&

                        this.sw.Restart();
                        if (this.measureFlg)
                        {//&& (this.selectCam == 1)
                            this.cam.QueryFrame();
                        }
                        this.capBkFlg = false;
                        //this.backgroundWorker1.RunWorkerAsync();
                        this.stat = 1;
                    }
                    return;

                case 1:
                    {
                        if (!this.capBkFlg || this.timeout)
                        {//|| (this.sw.ElapsedMilliseconds <= 10L)) 
                            if ((this.sw.ElapsedMilliseconds > 0x1388L) || this.timeout)
                            {
                                this.CaptureClick();
                                this.label74.ForeColor = Color.Red;
                                this.label74.Text = "CAPTURE ERROR : STOPPED. TIME-OUT";
                                this.pictureBox1.Image = null;
                                this.timeout = false;
                                this.measureFlg = false;
                                //logger.Info("=== ERROR : STOPPED.  CAPTURE TIME-OUT ===");
                                this.stat = 0;
                            }
                            return;
                        }
                        this.sw.Stop();
                        if (this.bkgImg == null)
                        {
                            if (this.captureErr == 0)
                            {
                                this.label74.ForeColor = Color.Red;
                                this.label74.Text = "CAPTURE ERROR : RETRY...";
                            }
                            else
                            {
                                if (this.captureErr > 10)
                                {
                                    this.timeout = true;
                                    return;
                                }
                                this.label74.Text = this.label74.Text + ".";
                            }
                            Thread.Sleep(250);
                            this.captureErr++;
                            this.stat = 0;
                            return;
                        }
                        long elapsedMilliseconds = this.sw.ElapsedMilliseconds;
                        try
                        {
                            if (this.reSize == 3)
                            {
                                this.srcImg = new IplImage(0x50e, 0x3c4, this.cam.QueryFrame().Depth, this.cam.QueryFrame().NChannels);
                                Cv.Resize(this.bkgImg, this.srcImg, Interpolation.Linear);
                            }
                            else if (this.reSize == 2)
                            {
                                this.srcImg = new IplImage(0xa1e, 0x796, this.cam.QueryFrame().Depth, this.cam.QueryFrame().NChannels);
                                Cv.Resize(this.bkgImg, this.srcImg, Interpolation.Linear);
                            }
                            else if (this.reSize == 1)
                            {
                                this.srcImg = new IplImage(0xf10, 0xacc, this.cam.QueryFrame().Depth, this.cam.QueryFrame().NChannels);
                                Cv.Resize(this.bkgImg, this.srcImg, Interpolation.Linear);
                            }
                            else if (this.reSize == 0)
                            {
                                this.srcImg = new IplImage(0x1200, 0xcd8, this.cam.QueryFrame().Depth, this.cam.QueryFrame().NChannels);
                                Cv.Resize(this.bkgImg, this.srcImg, Interpolation.Linear);
                            }
                            else
                            {
                                this.srcImg = Cv.CloneImage(this.cam.QueryFrame());
                            }
                            if (this.pixcelFormat == "MONO8")
                            {
                                using (IplImage image = new IplImage(this.srcImg.Size, BitDepth.U8, 3))
                                {
                                    Cv.CvtColor(this.srcImg, image, ColorConversion.GrayToBgr);
                                    this.srcImg = new IplImage(image.Size, image.Depth, image.NChannels);
                                    Cv.Copy(image, this.srcImg);
                                }
                            }
                        }
                        catch
                        {
                            this.bkgImg = null;
                            this.srcImg = null;
                            return;
                        }
                        long num1 = this.swt.ElapsedMilliseconds;
                        try
                        {
                            if (this.reverseX && this.reverseY)
                            {
                                Cv.Flip(this.srcImg, this.srcImg, FlipMode.XY);
                            }
                            else if (!this.reverseX && this.reverseY)
                            {
                                Cv.Flip(this.srcImg, this.srcImg, FlipMode.Y);
                            }
                            else if (this.reverseX && !this.reverseY)
                            {
                                Cv.Flip(this.srcImg, this.srcImg, FlipMode.X);
                            }
                            if (this.rotation90 ^ this.rotation270)
                            {
                                using (IplImage image2 = new IplImage(this.srcImg.Height, this.srcImg.Width, BitDepth.U8, 3))
                                {
                                    CvPoint2D32f[] pointdfArray;
                                    CvPoint2D32f[] pointdfArray2;
                                    CvPoint2D32f[] pointdfArray5;
                                    if (this.rotation90)
                                    {
                                        pointdfArray5 = new CvPoint2D32f[] { new CvPoint2D32f(0f, 0f), new CvPoint2D32f((float)this.srcImg.Width, 0f), new CvPoint2D32f((float)this.srcImg.Width, (float)this.srcImg.Height) };
                                        pointdfArray = pointdfArray5;
                                        pointdfArray5 = new CvPoint2D32f[] { new CvPoint2D32f((float)this.srcImg.Height, 0f), new CvPoint2D32f((float)this.srcImg.Height, (float)this.srcImg.Width), new CvPoint2D32f(0f, (float)this.srcImg.Width) };
                                        pointdfArray2 = pointdfArray5;
                                    }
                                    else
                                    {
                                        pointdfArray5 = new CvPoint2D32f[] { new CvPoint2D32f(0f, 0f), new CvPoint2D32f((float)this.srcImg.Width, 0f), new CvPoint2D32f((float)this.srcImg.Width, (float)this.srcImg.Height) };
                                        pointdfArray = pointdfArray5;
                                        pointdfArray5 = new CvPoint2D32f[] { new CvPoint2D32f(0f, (float)this.srcImg.Width), new CvPoint2D32f(0f, 0f), new CvPoint2D32f((float)this.srcImg.Height, 0f) };
                                        pointdfArray2 = pointdfArray5;
                                    }
                                    CvMat affineTransform = Cv.GetAffineTransform(pointdfArray, pointdfArray2);
                                    Cv.WarpAffine(this.srcImg, image2, affineTransform);
                                    this.srcImg = new IplImage(image2.Size, image2.Depth, image2.NChannels);
                                    Cv.Copy(image2, this.srcImg);
                                }
                            }
                        }
                        catch
                        {
                        }
                        // this.label1.Text = string.Concat(new object[] { "CAMERA : ", this.srcImg.Width, " x ", this.srcImg.Height });
                        this.bkgImg = null;
                        try
                        {
                            using (IplImage image3 = new IplImage(this.srcImg.Size, this.srcImg.Depth, this.srcImg.NChannels))
                            {
                                try
                                {
                                    Cv.Copy(this.srcImg, image3);
                                    if (this.imageContrastEnabled)
                                    {
                                        CvContrast(this.srcImg, image3, this.imageContrastCoef);
                                    }
                                    if (this.imageSmoothEnabled)
                                    {
                                        SmoothType gaussian = SmoothType.Gaussian;
                                        switch (this.imageSmoothType)
                                        {
                                            case 0:
                                                gaussian = SmoothType.Bilateral;
                                                break;

                                            case 1:
                                                gaussian = SmoothType.Blur;
                                                break;

                                            case 2:
                                                gaussian = SmoothType.BlurNoScale;
                                                break;

                                            case 3:
                                                gaussian = SmoothType.Gaussian;
                                                break;

                                            case 4:
                                                gaussian = SmoothType.Median;
                                                break;

                                            default:
                                                gaussian = SmoothType.Gaussian;
                                                break;
                                        }
                                        Cv.Smooth(image3, this.srcImg, gaussian, this.imageSmoothParam1, this.imageSmoothParam2, (double)this.imageSmoothParam3, (double)this.imageSmoothParam4);
                                    }
                                    if (this.imageUnsharpEnabled)
                                    {
                                        if (this.imageContrastEnabled && !this.imageSmoothEnabled)
                                        {
                                            Cv.Copy(image3, this.srcImg);
                                        }
                                        CvUnsharpMasking(this.srcImg, image3, this.imageUnsharpMask);
                                    }
                                    if (this.imageBilateralEnabled)
                                    {
                                        Cv.Smooth(image3, this.srcImg, SmoothType.Bilateral, this.imageBilateralParam1, this.imageBilateralParam2, (double)this.imageBilateralParam3);
                                    }
                                }
                                catch
                                {
                                    this.srcImg = null;
                                    return;
                                }
                            }
                        }
                        catch
                        {
                            this.srcImg = null;
                            GC.Collect();
                            this.stat = 0;
                        }
                        if (!this.damyCapture)
                        {
                            try
                            {
                                if ((this.srcScale != 1.0) && !this.measureFlg)
                                {
                                    this.ScreenScaleChange(this.srcScale, this.clickPoint);
                                }
                                else
                                {
                                    this.pictureBox1.Image = this.srcImg.ToBitmap();
                                }
                            }
                            catch
                            {
                            }
                        }
                        try
                        {
                            if (((this.srcImgWidth != this.srcImg.Width) || (this.srcImgHeight != this.srcImg.Height)) || ((this.cameraPropertyChange || (this.pictureBox1.Width != this.cur_pictureBoxWidth)) || (this.pictureBox1.Height != this.cur_pictureBoxHeight)))
                            {
                                this.cur_pictureBoxWidth = this.pictureBox1.Width;
                                this.cur_pictureBoxHeight = this.pictureBox1.Height;
                                this.srcImgWidth = this.srcImg.Width;
                                this.srcImgHeight = this.srcImg.Height;
                                if ((this.whiteLevelMode == 0) && (this.gainMode == 0))
                                {
                                    this.cameraPropertyChange = false;
                                }
                                this.drawRect = new CvRect(0, 0, this.srcImgWidth, this.srcImgHeight);
                                double num2 = ((double)this.cur_pictureBoxHeight) / ((double)this.cur_pictureBoxWidth);
                                double num3 = ((double)this.srcImgHeight) / ((double)this.srcImgWidth);
                                if (num2 > num3)
                                {
                                    this.imgSizeWidth = ((double)this.cur_pictureBoxWidth) / ((double)this.srcImgWidth);
                                    this.imgSizeHeight = this.imgSizeWidth;
                                }
                                else
                                {
                                    this.imgSizeHeight = ((double)this.cur_pictureBoxHeight) / ((double)this.srcImgHeight);
                                    this.imgSizeWidth = this.imgSizeHeight;
                                }
                                //if (this.selectCam == 0)
                                //{
                                //    this.label5.Text = "GAIN    : " + this.GetCameraGain(this.hPylonDeviceHandle).ToString();
                                //    this.label7.Text = "WHITE LV: " + this.GetCameraWhite(this.hPylonDeviceHandle).ToString();
                                //    this.label9.Text = "BLACK LV: " + this.GetCameraBlack(this.hPylonDeviceHandle).ToString();
                                //}
                                //else
                                //{
                                //    this.label5.Text = "GAIN    : ";
                                //    this.label7.Text = "WHITE LV: ";
                                //    this.label9.Text = "BLACK LV: ";
                                //}
                            }
                        }
                        catch
                        {
                            this.srcImg = null;
                            return;
                        }
                        //if (((this.measureFlg && (this.srcImg != null)) && ((this.serialControl > 0) && (this.serialControl <= 6))) && this.comPortConfig.enabled)
                        //{
                        //    this.SendBynary55AA81(this.serialControl);
                        //    this.serialControl = 0;
                        //}
                        this.label74.ForeColor = Color.Black;
                        this.label74.Text = "Capture OK: ";
                        //elapsedMilliseconds.ToString() +
                        if (this.shapeMeasureFlg)
                        {
                            try
                            {
                                this.dstImg = Cv.CloneImage(this.srcImg);
                            }
                            catch
                            {
                                this.dstImg = null;
                            }
                            if (this.dstImg != null)
                            {
                                this.ShapeMeasure();
                            }
                        }
                        if (this.measureFlg)
                        {
                            this.button1.ForeColor = Color.Black;
                            this.button1.Text = "Camera";
                            if (this.srcImg != null)
                            {
                                try
                                {
                                    this.dstImg = Cv.CloneImage(this.srcImg);
                                }
                                catch
                                {
                                    this.dstImg = null;
                                }
                                if (this.dstImg != null)
                                {
                                    this.capture = false;
                                    this.Measurement();
                                    this.stat = 80;
                                    GC.Collect();
                                    return;
                                }
                                this.label74.ForeColor = Color.Red;
                                this.label74.Text = "CAPTURE ERROR!";
                                Thread.Sleep(250);
                                this.captureErr++;
                                this.stat = 0;
                                return;
                            }
                            this.label74.ForeColor = Color.Red;
                            this.label74.Text = "CAPTURE ERROR!";
                            Thread.Sleep(250);
                            this.captureErr++;
                            this.stat = 0;
                            return;
                        }
                        if (this.damyCapture)
                        {
                            this.damyCapture = false;
                            this.pictureBox1.Image = null;
                            this.CaptureImage();
                            this.srcImg = null;
                            return;
                        }
                        this.swt.Restart();
                        this.stat = 0;
                        return;
                    }
                case 2:
                    if (this.srcImg == null)
                    {
                        return;
                    }
                    return;

                case 80:
                    if (this.tempNum > 0)
                    {
                        this.InitBgWorker(this.tempNum);
                        this.bkgFlg = new bool[this.tempNum];
                        this.compFlg = new bool[this.tempNum];
                        this.difbkgFlg = new bool[this.tempNum];
                        this.pictureBox6.BackColor = Color.DimGray;
                        this.pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
                        //this.pictureBox6.Image = Resources.load32;
                        this.pictureBox1.BackColor = Color.DimGray;
                        this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                        // this.pictureBox1.Image = Resources.load32;
                        this.stat = 90;
                    }
                    else
                    {
                        this.measureFlg = false;
                        this.stat = 0;
                        this.timer1.Enabled = false;
                        this.ButtonInterlock(false);
                        this.swt.Stop();
                        num43 = ((double)this.swt.ElapsedMilliseconds) / 1000.0;
                        //this.label61.Text = "time : " + num43.ToString("#0.00") + " [sec]";
                        //if (((this.cmdExec != "") && this.comPortConfig.enabled) && (this.comPortConfig.serialMode > 0))
                        //{
                        //    this.TransmitDataWrite(this.startMark + this.modelsMark + this.comPortConfig.serialID.ToString("X1") + this.cmdExec + "ER");
                        //    this.cmdExec = "";
                        //}
                        //logger.Info("=== ERROR : TEACHING POINT NULL ===");
                    }
                    //if (((!string.IsNullOrEmpty(this.dioPortAssign.dioDeviceName) && !string.IsNullOrEmpty(this.dioPortAssign.dioModelName)) && this.dioPortAssign.dioEnable) && (this.dioPortAssign.ledLight1Enable || this.dioPortAssign.ledLight2Enable))
                    //{
                    //    this.dio.EchoBackByte(this.dioId, 0, out this.dioPo);
                    //    if (this.dioPortAssign.ledLight1Enable && (this.dioPortAssign.ledLight1ActiveStatus == 0))
                    //    {
                    //        this.dioPo = (byte)(this.dioPo & ((byte)~this.o_LIGHT1));
                    //    }
                    //    else if (this.dioPortAssign.ledLight1Enable && (this.dioPortAssign.ledLight1ActiveStatus == 1))
                    //    {
                    //        this.dioPo = (byte)(this.dioPo | ((byte)this.o_LIGHT1));
                    //    }
                    //    if (this.dioPortAssign.ledLight2Enable && (this.dioPortAssign.ledLight2ActiveStatus == 0))
                    //    {
                    //        this.dioPo = (byte)(this.dioPo & ((byte)~this.o_LIGHT2));
                    //    }
                    //    else if (this.dioPortAssign.ledLight2Enable && (this.dioPortAssign.ledLight2ActiveStatus == 1))
                    //    {
                    //        this.dioPo = (byte)(this.dioPo | ((byte)this.o_LIGHT2));
                    //    }
                    //    this.dioOutputBuffer.Text = Convert.ToString(this.dioPo, 2);
                    //}
                    return;

                case 90:
                    if (this.dstImg == null)
                    {
                        this.measureFlg = false;
                        this.stat = 0;
                        this.timer1.Enabled = false;
                        this.ButtonInterlock(false);
                        this.swt.Stop();
                        //this.label61.Text = "time : " + ((((double)this.swt.ElapsedMilliseconds) / 1000.0)).ToString("#0.00") + " [sec]";
                        //if (((this.cmdExec != "") && this.comPortConfig.enabled) && (this.comPortConfig.serialMode > 0))
                        //{
                        //    this.TransmitDataWrite(this.startMark + this.modelsMark + this.comPortConfig.serialID.ToString("X1") + this.cmdExec + "ER");
                        //    this.cmdExec = "";
                        //}
                        this.pictureBox6.Image = null;
                        this.pictureBox1.Image = null;
                        //logger.Info("=== ERROR : IMAGE NULL ===");
                        return;
                    }
                    for (int num4 = 0; num4 < this.tempNum; num4++)
                    {
                        if (this.backgroundWorker[num4].IsBusy)
                        {
                            return;
                        }
                    }
                    this.tmpMatchResult = new TempMatchResult[0x80];
                    this.paintRectangleEnabled = false;
                    this.rszImg = null;
                    this.rszImg = new IplImage(this.dstImg.Size, this.dstImg.Depth, this.dstImg.NChannels);
                    this.rszImg = Cv.CloneImage(this.dstImg);
                    this.s_rect = new Rectangle(0, 0, 0, 0);
                    if ((this.refModelObjNum[0].svArea > 0.0) && (this.refModelObjNum[0].svDstPnt[1].X > 0))
                    {
                        using (IplImage image4 = new IplImage(this.rszImg.Size, this.rszImg.Depth, this.rszImg.NChannels))
                        {
                            Cv.Copy(this.rszImg, image4);
                            this.contour = this.EdgeCheck(image4, this.storage);
                            double parameter = 1.5;
                            if (this.contour != null)
                            {
                                this.contour = Cv.ApproxPoly(this.contour, this.header_size, this.tmpStorage, ApproxPolyMethod.DP, parameter, true);
                            }
                            CvBox2D boxd = new CvBox2D();
                            double num6 = 0.0;
                            new CvPoint(0, 0);
                            new CvPoint(0, 0);
                            new CvPoint(0, 0);
                            new CvPoint(0, 0);
                            CvPoint[] pointArray = new CvPoint[4];
                            while (this.contour != null)
                            {
                                if (this.contour.Total >= 5)
                                {
                                    num6 = Math.Abs(Cv.ContourArea(this.contour, CvSlice.WholeSeq));
                                    Cv.ArcLength(this.contour, CvSlice.WholeSeq, 1);
                                    boxd = Cv.FitEllipse2(this.contour);
                                    if ((num6 > (this.refModelObjNum[0].svArea * 0.9)) && (num6 < (this.refModelObjNum[0].svArea * 1.1)))
                                    {
                                        using (IplImage image5 = new IplImage(this.refModelObjNum[0].svDstPnt[2].X, this.refModelObjNum[0].svDstPnt[2].Y, image4.Depth, image4.NChannels))
                                        {
                                            RotatedRect rect = Cv.MinAreaRect2(this.contour);
                                            rect = Cv.MinAreaRect2(this.contour);
                                            Point2f[] pointfArray = new Point2f[4];
                                            pointfArray = rect.Points();
                                            pointArray[0].X = (int)Math.Round((double)pointfArray[3].X);
                                            pointArray[0].Y = (int)Math.Round((double)pointfArray[3].Y);
                                            pointArray[1].X = (int)Math.Round((double)pointfArray[0].X);
                                            pointArray[1].Y = (int)Math.Round((double)pointfArray[0].Y);
                                            pointArray[2].X = (int)Math.Round((double)pointfArray[1].X);
                                            pointArray[2].Y = (int)Math.Round((double)pointfArray[1].Y);
                                            pointArray[3].X = (int)Math.Round((double)pointfArray[2].X);
                                            pointArray[3].Y = (int)Math.Round((double)pointfArray[2].Y);
                                            CvScalar fillval = Cv.ScalarAll(0.0);
                                            CvMat mapMatrix = new CvMat(3, 3, MatrixType.F32C1);
                                            CvPoint2D32f[] src = new CvPoint2D32f[4];
                                            CvPoint2D32f[] dst = new CvPoint2D32f[4];
                                            double num7 = Math.Sqrt(Math.Pow((double)(pointArray[1].X - pointArray[0].X), 2.0) + Math.Pow((double)(pointArray[1].Y - pointArray[0].Y), 2.0));
                                            double num8 = Math.Sqrt(Math.Pow((double)(pointArray[2].X - pointArray[1].X), 2.0) + Math.Pow((double)(pointArray[2].Y - pointArray[1].Y), 2.0));
                                            if (num7 > num8)
                                            {
                                                src[0] = pointArray[2];
                                                src[1] = pointArray[3];
                                                src[2] = pointArray[0];
                                                src[3] = pointArray[1];
                                            }
                                            else
                                            {
                                                src[0] = pointArray[3];
                                                src[1] = pointArray[0];
                                                src[2] = pointArray[1];
                                                src[3] = pointArray[2];
                                            }
                                            dst[0] = new CvPoint2D32f(0.0, 0.0);
                                            dst[1] = new CvPoint2D32f((double)this.refModelObjNum[0].svDstPnt[1].X, 0.0);
                                            dst[2] = new CvPoint2D32f((float)this.refModelObjNum[0].svDstPnt[2].X, (float)this.refModelObjNum[0].svDstPnt[2].Y);
                                            dst[3] = new CvPoint2D32f(0f, (float)this.refModelObjNum[0].svDstPnt[3].Y);
                                            Cv.GetPerspectiveTransform(src, dst, out mapMatrix);
                                            this.rszImg = new IplImage(image5.Size, image4.Depth, image4.NChannels);
                                            Cv.WarpPerspective(image4, this.rszImg, mapMatrix, Interpolation.NearestNeighbor, fillval);
                                            break;
                                        }
                                    }
                                }
                                this.contour = this.contour.HNext;
                            }
                        }
                    }
                    break;

                case 0x5b:
                    if (!this.tmpMatch)
                    {
                        for (int num9 = 0; num9 < this.tempNum; num9++)
                        {
                            if (!this.bkgFlg[num9])
                            {
                                return;
                            }
                            if (!this.compFlg[num9])
                            {
                                this.measurementsMatchRate[num9] = this.tmpMatchResult[num9].Score;
                                if ((this.tmpMatchResult[num9].Score == 0.0) && (this.retry[num9] < 2))
                                {
                                    this.MakeTempImage(num9);
                                    this.retry[num9]++;
                                    this.bkgFlg[num9] = false;
                                    this.measurementsMatchRate[num9] = 0.0;
                                    this.measurementsDiffArea[num9] = 0.0;
                                    this.tempDataBKG.mode = this.refModelObjNum[num9].mode;
                                    this.tempDataBKG.ptMatchBinThreshold = this.refModelObjNum[num9].ptMatchBinaryThreshold;
                                    this.tempDataBKG.tmpData = this.tmpDataNum[num9].tmpData;
                                    this.tempDataBKG.refTmpID.scaleID = this.tmpDataNum[num9].refScaleID;
                                    this.tempDataBKG.refTmpID.angleID = this.tmpDataNum[num9].refAngleID;
                                    this.tempDataBKG.tgtArea = this.SetSearcArea(this.rszImg, num9, this.tmpDataNum[num9], this.image_offsetX, this.image_offsetY, this.refModelObjNum[num9].searchPositionRangeX + this.search_offsetX, this.refModelObjNum[num9].searchPositionRangeY + this.search_offsetY);
                                    this.tempDataBKG.scaleNumber = this.scaleNum;
                                    this.tempDataBKG.anglenumber = this.angleNum;
                                    this.backgroundWorker[num9].RunWorkerAsync(this.tempDataBKG);
                                    return;
                                }
                                this.compFlg[num9] = true;
                            }
                            if (num9 == (this.tempNum - 1))
                            {
                                this.tmpMatch = true;
                                this.diffResult = null;
                                this.diffResult = new DiffResult[0x80];
                                this.label100.Text = "";
                                this.stat = 910;
                                return;
                            }
                        }
                    }
                    return;

                case 0x5c:
                    {
                        string text = "";
                        double matchRateThreshold = 0.0;
                        double num14 = 0.0;
                        this.judgeResult = new int[0x80];
                        this.measurementCount++;
                        this.label27.Text = this.measurementCount.ToString();
                        int num15 = 0;
                        int num16 = 0;
                        string str2 = "";
                        string message = "";
                        string str4 = "";
                        string str5 = "";
                        for (int num17 = 0; num17 < this.tempNum; num17++)
                        {
                            matchRateThreshold = this.refModelObjNum[num17].matchRateThreshold;
                            num14 = this.refModelObjNum[num17].diffThreshold * 0.01;
                            if (this.refModelObjNum[num17].inspectEnabled)
                            {
                                if ((((this.refModelObjNum[num17].matcNG_Threshold != "OVER") && (this.diffResult[num17].matchRate < matchRateThreshold)) || ((this.refModelObjNum[num17].diffNG_Threshold != "UNDER") && (this.diffResult[num17].diffArea > num14))) || (((this.refModelObjNum[num17].matcNG_Threshold == "OVER") && (this.diffResult[num17].matchRate > matchRateThreshold)) || ((this.refModelObjNum[num17].diffNG_Threshold == "UNDER") && (this.diffResult[num17].diffArea < num14))))
                                {
                                    num16++;
                                    this.label29.Text = this.measurementNg.ToString();
                                    this.label25.ForeColor = Color.Red;
                                    this.label25.BackColor = Color.Yellow;
                                    str5 = "NG";
                                    this.label25.Text = "NG";
                                    this.judgeResult[num17] = -1;
                                    str4 = str4 + (num17 + 1) + ", ";
                                    if (this.comok && ComControl.IsOpen == true)
                                    {
                                        this.ComControl.Write("N");
                                    }
                                    this.timer3.Enabled = true;
                                }
                                else
                                {
                                    num15++;
                                    this.label25.ForeColor = Color.Green;
                                    this.label25.BackColor = Color.Yellow;
                                    str5 = "OK";
                                    this.label25.Text = "OK";
                                    this.judgeResult[num17] = 1;
                                    if (this.comok && ComControl.IsOpen == true)
                                    {
                                        this.ComControl.Write("O");
                                    }
                                    this.timer3.Enabled = true;
                                }
                            }
                            else
                            {
                                this.diffResult[num17].matchRate = 0.0;
                                this.diffResult[num17].diffArea = 0.0;
                                str5 = "Not check";
                                this.label25.BackColor = Color.Yellow;
                                this.label25.Text = "Not Check";
                                this.judgeResult[num17] = 0;
                            }
                            string[] strArray = new string[6];
                            this.dtNow = DateTime.Now;
                            strArray[0] = (num17 + 1).ToString();
                            strArray[1] = this.refModelObjNum[num17].checkPointName;
                            strArray[2] = this.diffResult[num17].matchRate.ToString("0.00");
                            strArray[3] = this.diffResult[num17].diffArea.ToString("0.00");
                            strArray[4] = str5;
                            string[] strArray2 = strArray;
                            ListViewItem item = new ListViewItem
                            {
                                UseItemStyleForSubItems = false,
                                Text = strArray2[0]
                            };
                            System.Drawing.FontStyle style = item.Font.Style;
                            Font font = new Font(item.Font.Name, item.Font.Size, style);
                            str2 = str2 + strArray2[0] + ",";
                            for (int num18 = 1; num18 < 5; num18++)
                            {
                                if (strArray2[num18] == "PASS")
                                {
                                    item.SubItems.Add(strArray2[num18], Color.RoyalBlue, Color.White, font);
                                }
                                else if (strArray2[num18] == "NG")
                                {
                                    item.ForeColor = Color.Red;
                                    item.SubItems.Add(strArray2[num18], Color.Red, Color.White, font);
                                }
                                else
                                {
                                    item.SubItems.Add(strArray2[num18], Color.Black, Color.White, font);
                                }
                                str2 = str2 + strArray2[num18] + ",";
                            }
                            message = string.Concat(new object[] {
                       "MEASURE,", this.curModelName, ",", strArray2[0], ",", this.refModelObjNum[num17].checkPointName, ",", this.diffResult[num17].matchRate.ToString("0.00"), ",", this.diffResult[num17].diffArea.ToString("0.00"), ",", str5, ",", this.refModelObjNum[num17].positionX.ToString(), ",", this.refModelObjNum[num17].positionY.ToString(),
                       ",", this.refModelObjNum[num17].modelImg.Width.ToString(), ",", this.refModelObjNum[num17].modelImg.Height.ToString(), ",", this.refModelObjNum[num17].searchPositionRangeX, ",", this.refModelObjNum[num17].searchPositionRangeY, ",", this.refModelObjNum[num17].searchAngleRange, ",", this.refModelObjNum[num17].searchAngleStep, ",", this.refModelObjNum[num17].searchScaleMax, ",", this.refModelObjNum[num17].searchScaleMin,
                       ",", this.refModelObjNum[num17].searchScaleStep, ",", this.refModelObjNum[num17].unsharpMask, ",", this.refModelObjNum[num17].smoothParam, ",", this.refModelObjNum[num17].smoothParam3, ",", this.refModelObjNum[num17].smoothParam4, ",", this.refModelObjNum[num17].contrastCoef, ",", this.refModelObjNum[num17].erodNumThreshold, ",", this.refModelObjNum[num17].dilaNumThreshold,
                       ",", this.refModelObjNum[num17].binaryAllThreshold, ",", this.refModelObjNum[num17].binaryRedThreshold, ",", this.refModelObjNum[num17].binaryGreenThreshold, ",", this.refModelObjNum[num17].binaryBlueThreshold, ",", this.refModelObjNum[num17].blobMinAreaThreshold, ",", this.refModelObjNum[num17].blobMaxAreaThreshold, ",", this.refModelObjNum[num17].matchRateThreshold, ",", this.refModelObjNum[num17].diffThreshold,
                       ",", this.image_offsetX, ",", this.image_offsetY, ",", this.search_offsetX, ",", this.search_offsetY, ",", this.refModelObjNum[num17].reverseX, ",", this.refModelObjNum[num17].reverseY, ",", this.refModelObjNum[num17].rotation90, ",", this.refModelObjNum[num17].rotation270,
                       ",", this.refModelObjNum[num17].matcNG_Threshold, ",", this.refModelObjNum[num17].diffNG_Threshold, ","
                    });
                            // logger.Info(message);
                            if (!this.checkBox3.Checked || (this.checkBox3.Checked && (this.judgeResult[num17] < 0)))
                            {
                                this.listView1.Items.Add(item);
                            }
                            str2 = str2 + "\n";
                        }
                        //if (this.checkBox7.Checked)
                        //{
                        //    text = this.textBox3.Text;
                        //}
                        this.csvFileCnt++;
                        this.dtNow = DateTime.Now;
                        this.richTextBoxBuffer = this.richTextBoxBuffer + "------------------------------------------------------------\n";
                        object richTextBoxBuffer = this.richTextBoxBuffer;
                        this.richTextBoxBuffer = string.Concat(new object[] { richTextBoxBuffer, text, ",", this.dtNow.ToString("yyyy/MM/dd HH:mm:ss"), ",", this.curModelName, ",", this.measurementCount, ",", num15 + num16, ",", num16, "\n" });
                        this.richTextBoxBuffer = this.richTextBoxBuffer + str2;
                        if (this.autoCsvSave)
                        {
                            if (this.csvFileCnt >= this.maxCsvCnt)
                            {
                                this.csvFileCnt = 0;
                                string path = this.csvPath + this.dtNow.ToString("yyyyMMddHHmmss") + ".csv";
                                //this.richTextBox1.Text = this.richTextBoxBuffer;
                                //this.richTextBox1.SaveFile(path, RichTextBoxStreamType.PlainText);
                                //this.richTextBox1.Text = "";
                                //this.richTextBoxBuffer = "";
                            }
                            //OldFileSearchDel(this.csvPath, "*.csv", this.maxCsvFile);
                        }
                        bool argument = false;
                        if (num16 == 0)
                        {
                            this.measurementOk++;
                            this.label25.BackColor = Color.Yellow;
                            this.label25.ForeColor = Color.Green;
                            str5 = "OK";
                            this.label25.Text = "OK";
                            argument = true;
                            if (this.comok && ComControl.IsOpen == true)
                            {
                                this.ComControl.Write("O");
                            }
                            this.timer3.Enabled = true;
                            NGShow frm = new NGShow();
                            frm.Hide();
                            //string path = this.csvPath + this.dtNow.ToString("yyyyMMddHHmmss") + ".csv";
                            string path = Path.Combine(Application.StartupPath, "data", "csv", this.dtNow.ToString("yyyyMMddHHmmss") + ".csv");

                            // QuyetPham add 7.8.2018
                            using (StreamWriter writer = new StreamWriter(path))
                            {
                                writer.WriteLine("Result");
                                writer.WriteLine("OK");
                            }
                            // End
                        }
                        else
                        {
                            this.measurementNg++;
                            this.label25.BackColor = Color.Yellow;
                            this.label25.ForeColor = Color.Red;
                            str5 = "NG";
                            this.label25.Text = "NG";
                            if (this.comok && ComControl.IsOpen == true)
                            {
                                this.ComControl.Write("N");
                            }
                            this.timer3.Enabled = true;
                            NGShow frm = new NGShow();
                            // QuyetPham add 7.8.2018
                            frm.Left = 0;
                            frm.Top = 480;
                            frm.Show();
                            //string path = this.csvPath + this.dtNow.ToString("yyyyMMddHHmmss") + ".csv";
                            string path = Path.Combine(Application.StartupPath, "data", "csv", this.dtNow.ToString("yyyyMMddHHmmss") + ".csv");
                            using (StreamWriter writer = new StreamWriter(path))
                            {
                                writer.WriteLine("Result");
                                writer.WriteLine("NG");
                            }
                            // End

                        }
                        this.label70.Text = (num15 + num16).ToString();
                        this.label71.Text = num16.ToString();
                        this.label29.Text = this.measurementNg.ToString();
                        this.label43.Text = (Math.Round(((double)this.measurementOk / (double)this.measurementCount) * 100, 2)).ToString();
                        string name = "";
                        if (this.autoSave)
                        {
                            string str8 = "";
                            //if (this.checkBox7.Checked && !string.IsNullOrEmpty(text))
                            //{
                            //    str8 = text + "_";
                            //}
                            DateTime now = DateTime.Now;
                            name = str8 + now.ToString("yyyyMMddHHmmss") + "_" + this.measurementCount.ToString("D8") + "_" + this.curModelName + "_" + str5 + ".png";
                            this.ImageDataSave(this.srcImg, this.measurementCount, name, (str5 == "NG") ? 1 : 0);
                        }
                        this.curNum = 0;
                        bool flag2 = false;
                        for (int num19 = 0; num19 < this.tempNum; num19++)
                        {
                            if ((this.judgeResult[num19] != 0) && (!flag2 || (this.judgeResult[num19] == -1)))
                            {
                                flag2 = true;
                                this.curNum = num19 + 1;
                                if (this.judgeResult[num19] == -1)
                                {
                                    break;
                                }
                            }
                        }
                        this.DispSelectItem(this.curNum - 1);
                        this.DispRefModelData(this.curNum - 1);
                        this.DispMakeThumbnail(this.curNum - 1);
                        this.CheckTempSelectButton();
                        this.CheckPresetData();
                        if (str4 != "")
                        {
                            this.label74.ForeColor = Color.Red;
                            this.label74.Text = "NG No.=" + str4;
                        }
                        this.timer1.Enabled = false;
                        this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        if (this.diffImageFlg && (this.diffImgFull != null))
                        {
                            this.pictureBox1.Image = this.diffImgFull.ToBitmap();
                        }
                        else if (this.srcImg != null)
                        {
                            this.pictureBox1.Image = this.srcImg.ToBitmap();
                        }
                        //this.DeleteOldLogFile();
                        //this.backgroundWorker2.RunWorkerAsync(argument);
                        this.diffBgWorker = null;
                        this.difDispBgWorker = null;
                        //if ((!string.IsNullOrEmpty(this.dioPortAssign.dioDeviceName) && !string.IsNullOrEmpty(this.dioPortAssign.dioModelName)) && this.dioPortAssign.dioEnable)
                        //{
                        //    this.dio.EchoBackByte(this.dioId, 0, out this.dioPo);
                        //    if ((this.dioPortAssign.okEnable && (this.dioPortAssign.okActiveStatus == 0)) && (num16 == 0))
                        //    {
                        //        this.dioPo = (byte)(this.dioPo | ((byte)this.o_PASS));
                        //    }
                        //    else if ((this.dioPortAssign.okEnable && (this.dioPortAssign.okActiveStatus == 1)) && (num16 == 0))
                        //    {
                        //        this.dioPo = (byte)(this.dioPo & ((byte)~this.o_PASS));
                        //    }
                        //    else if ((this.dioPortAssign.okEnable && (this.dioPortAssign.okActiveStatus == 0)) && (num16 != 0))
                        //    {
                        //        this.dioPo = (byte)(this.dioPo & ((byte)~this.o_PASS));
                        //    }
                        //    else if ((this.dioPortAssign.okEnable && (this.dioPortAssign.okActiveStatus == 0)) && (num16 != 0))
                        //    {
                        //        this.dioPo = (byte)(this.dioPo | ((byte)this.o_PASS));
                        //    }
                        //    if ((this.dioPortAssign.okEnable && (this.dioPortAssign.ngActiveStatus == 0)) && (num16 != 0))
                        //    {
                        //        this.dioPo = (byte)(this.dioPo | ((byte)this.o_NG));
                        //    }
                        //    else if ((this.dioPortAssign.okEnable && (this.dioPortAssign.ngActiveStatus == 1)) && (num16 != 0))
                        //    {
                        //        this.dioPo = (byte)(this.dioPo & ((byte)~this.o_NG));
                        //    }
                        //    else if ((this.dioPortAssign.okEnable && (this.dioPortAssign.ngActiveStatus == 0)) && (num16 == 0))
                        //    {
                        //        this.dioPo = (byte)(this.dioPo & ((byte)~this.o_NG));
                        //    }
                        //    else if ((this.dioPortAssign.okEnable && (this.dioPortAssign.ngActiveStatus == 0)) && (num16 == 0))
                        //    {
                        //        this.dioPo = (byte)(this.dioPo | ((byte)this.o_NG));
                        //    }
                        //    this.dioOutputBuffer.Text = Convert.ToString(this.dioPo, 2);
                        Thread.Sleep(10);
                        //    if (this.dioPortAssign.busyEnable && (this.dioPortAssign.busyActiveStatus == 0))
                        //    {
                        //        this.dioPo = (byte)(this.dioPo & ((byte)~this.o_BUSY));
                        //    }
                        //    else if (this.dioPortAssign.busyEnable && (this.dioPortAssign.busyActiveStatus == 1))
                        //    {
                        //        this.dioPo = (byte)(this.dioPo | ((byte)this.o_BUSY));
                        //    }
                        //    this.dioOutputBuffer.Text = Convert.ToString(this.dioPo, 2);
                        //}
                        //if (((this.cmdExec != "") && this.comPortConfig.enabled) && (this.comPortConfig.serialMode > 0))
                        //{
                        //    string str9 = (num16 == 0) ? "OK" : "NG";
                        //    this.TransmitDataWrite(this.startMark + this.modelsMark + this.comPortConfig.serialID.ToString("X1") + this.cmdExec + str9);
                        //    this.cmdExec = "";
                        //}
                        this.measureFlg = false;
                        this.stat = 0;
                        this.ButtonInterlock(false);
                        //if (this.checkBox7.Checked)
                        //{
                        //    text = text + ",";
                        //}
                        object[] objArray = new object[] {
                   label25.Text,",", this.curModelName, ",", this.measurementCount, ",", str5, ",", this.measurementOk, ",", this.measurementNg, ",", num15, ",", num16, ",", (((double) this.swt.ElapsedMilliseconds) / 1000.0).ToString("#0.00"),
                   ",", name, ",", text
                };
                        message = string.Concat(objArray);
                        // logger.Info(message);
                        this.swt.Stop();
                        //this.label61.Text = "time : " + ((((double)this.swt.ElapsedMilliseconds) / 1000.0)).ToString("#0.00") + " [sec]";
                        return;
                    }
                default:
                    return;
            }
            this.measureNum = 0;
            this.sw_thTime.Restart();
            this.tmpBkgwFlg = 0;
            this.label100.Text = "TEMPLATE MATCHING  0%";
            this.label100.Visible = true;
            this.tmpMatchStartBgWorker.WorkerReportsProgress = true;
            this.tmpMatchStartBgWorker.RunWorkerAsync(this.tempNum);
            this.stat = 0x385;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureClick();
        }
        private void CaptureClick()
        {
            if (!this.capture)
            {
                this.swt.Restart();
                this.ButtonInterlock(true);
                //this.button24.Enabled = true;
                // this.button25.Enabled = true;
                //this.button31.Enabled = true;
                // this.button32.Enabled = true;
            }
            else
            {
                this.swt.Stop();
                this.ButtonInterlock(false);
                //this.button24.Enabled = false;
                //this.button25.Enabled = false;
                //this.button31.Enabled = false;
                //this.button32.Enabled = false;
            }
            this.CaptureImage();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.Enabled = false;
            if (((this.tempNum != 0) || ((this.r_rect.Width >= 1) && (this.r_rect.Height >= 1))) || (MessageBox.Show(Resources.BT3_SET_MSG_PLEASE_SPECIFY, "AAC-1000", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel))
            {
                if (Cursor.Current != Cursors.WaitCursor)
                {
                    Cursor.Current = Cursors.WaitCursor;
                }
                this.ButtonInterlock(true);
                if (this.dstImg != null)
                {
                    this.refImg = Cv.CloneImage(this.dstImg);
                    using (IplImage image = new IplImage(this.refImg.Size, this.refImg.Depth, this.refImg.NChannels))
                    {
                        Cv.Copy(this.refImg, image);
                        CvRect rect = new CvRect(5, 5, image.Width - 10, image.Height - 10);
                        Rectangle rectangle = new Rectangle();
                        new CvPoint(0, 0);
                        new CvPoint(0, 0);
                        new CvPoint(0, 0);
                        new CvPoint(0, 0);
                        CvPoint[] pointArray = new CvPoint[4];
                        RotatedRect rect2 = new RotatedRect();
                        if (this.curNum <= this.tempNum)
                        {
                            if (((this.r_rect.Width < 1) || (this.r_rect.Height < 1)) && (this.curEdit && (this.curNum > 0)))
                            {
                                rectangle = r_rectList[this.curNum - 1];
                            }
                            else
                            {
                                rectangle = this.r_rect;
                            }
                        }
                        this.svArea = 0.0;
                        for (int i = 0; i < 4; i++)
                        {
                            this.svDstPnt[i] = new System.Drawing.Point();
                        }
                        if ((rectangle.Width > 1) && (rectangle.Height > 1))
                        {
                            rect.Width = rectangle.Width;
                            rect.Height = rectangle.Height;
                            rect.X = rectangle.X;
                            rect.Y = rectangle.Y;
                        }
                        else if (this.autoTrim)
                        {
                            this.tmpcontour = this.EdgeCheck(image, this.tmpStorage);
                            double parameter = 1.5;
                            if (this.tmpcontour != null)
                            {
                                this.tmpcontour = Cv.ApproxPoly(this.tmpcontour, this.header_size, this.tmpStorage, ApproxPolyMethod.DP, parameter, true);
                            }
                            this.min_area = (image.Width / 100) * (image.Height / 100);
                            this.max_area = (image.Width - (image.Width / 20)) * (image.Height - (image.Height / 20));
                            this.tmpArea = Math.Abs(Cv.ContourArea(this.tmpcontour, CvSlice.WholeSeq));
                            this.tmpLength = Cv.ArcLength(this.tmpcontour, CvSlice.WholeSeq, 1);
                            CvBox2D boxd = new CvBox2D();
                            this.tmpAngle = 0.0;
                            double tmpArea = 0.0;
                            IplImage dst = new IplImage(image.Size, image.Depth, image.NChannels);
                            Cv.Copy(image, dst);
                            while (this.tmpcontour != null)
                            {
                                if (this.tmpcontour.Total >= 5)
                                {
                                    this.tmpArea = Math.Abs(Cv.ContourArea(this.tmpcontour, CvSlice.WholeSeq));
                                    this.tmpLength = Cv.ArcLength(this.tmpcontour, CvSlice.WholeSeq, 1);
                                    boxd = Cv.FitEllipse2(this.tmpcontour);
                                    this.tmpAngle = boxd.Angle;
                                    Cv.DrawContours(dst, this.tmpcontour, Cv.RGB(0xff, 0, 0xff), Cv.RGB(0xff, 0, 0xff), 0, 3, LineType.AntiAlias, Cv.Point(0, 0));
                                    if (((this.tmpArea > this.min_area) && (this.tmpArea < this.max_area)) && (this.tmpArea > tmpArea))
                                    {
                                        tmpArea = this.tmpArea;
                                        this.svArea = tmpArea;
                                        using (IplImage image3 = new IplImage(image.Size, image.Depth, image.NChannels))
                                        {
                                            Cv.Copy(image, image3);
                                            Cv.DrawContours(image3, this.tmpcontour, Cv.RGB(0xff, 0, 0xff), Cv.RGB(0xff, 0, 0xff), 0, 3, LineType.AntiAlias, Cv.Point(0, 0));
                                            this.pictureBox1.Image = image3.ToBitmap();
                                            rect2 = Cv.MinAreaRect2(this.tmpcontour);
                                            Point2f[] pointfArray = new Point2f[4];
                                            pointfArray = rect2.Points();
                                            pointArray[0].X = (int)Math.Round((double)pointfArray[3].X);
                                            pointArray[0].Y = (int)Math.Round((double)pointfArray[3].Y);
                                            pointArray[1].X = (int)Math.Round((double)pointfArray[0].X);
                                            pointArray[1].Y = (int)Math.Round((double)pointfArray[0].Y);
                                            pointArray[2].X = (int)Math.Round((double)pointfArray[1].X);
                                            pointArray[2].Y = (int)Math.Round((double)pointfArray[1].Y);
                                            pointArray[3].X = (int)Math.Round((double)pointfArray[2].X);
                                            pointArray[3].Y = (int)Math.Round((double)pointfArray[2].Y);
                                            if (rect2.Size.Width >= ((int)rect2.Size.Height))
                                            {
                                                rect.Width = (int)rect2.Size.Width;
                                                rect.Height = (int)rect2.Size.Height;
                                            }
                                            else
                                            {
                                                rect.Width = (int)rect2.Size.Height;
                                                rect.Height = (int)rect2.Size.Width;
                                            }
                                            rect.X = (int)Math.Round((double)(rect2.Center.X - (((float)rect.Width) / 2f)));
                                            rect.Y = (int)Math.Round((double)(rect2.Center.Y - (((float)rect.Height) / 2f)));
                                            if (rect.Width > image.Width)
                                            {
                                                rect.Width = image.Width;
                                            }
                                            if (rect.Height > image.Height)
                                            {
                                                rect.Height = image.Height;
                                            }
                                            if (rect.X < 0)
                                            {
                                                rect.X = 0;
                                            }
                                            if (rect.Y < 0)
                                            {
                                                rect.Y = 0;
                                            }
                                            this.r_rect.Width = rect.Width;
                                            this.r_rect.Height = rect.Height;
                                            this.r_rect.X = rect.X;
                                            this.r_rect.Y = rect.Y;
                                            if (((this.curNum == this.tempNum) || (this.curNum == 0)) && ((!this.curEdit && (this.r_rect.Width > 1)) && (this.r_rect.Height > 1)))
                                            {
                                                r_rectList[this.tempNum] = this.r_rect;
                                            }
                                            double num4 = 0.0;
                                            if (this.pictureBox1.Image != null)
                                            {
                                                double num5 = ((double)this.pictureBox1.Height) / ((double)this.pictureBox1.Width);
                                                double num6 = ((double)this.pictureBox1.Image.Height) / ((double)this.pictureBox1.Image.Width);
                                                if (num5 > num6)
                                                {
                                                    num4 = ((double)this.pictureBox1.Width) / ((double)this.pictureBox1.Image.Width);
                                                }
                                                else
                                                {
                                                    num4 = ((double)this.pictureBox1.Height) / ((double)this.pictureBox1.Image.Height);
                                                }
                                                if (this.pictureBox1.Width > (this.pictureBox1.Image.Width * num4))
                                                {
                                                    this.minWidth = (int)((this.pictureBox1.Width - (this.pictureBox1.Image.Width * num4)) / 2.0);
                                                    this.maxWidth = this.pictureBox1.Width - ((int)((this.pictureBox1.Width - (this.pictureBox1.Image.Width * num4)) / 2.0));
                                                }
                                                if (this.pictureBox1.Height > (this.pictureBox1.Image.Height * num4))
                                                {
                                                    this.minHeight = (int)((this.pictureBox1.Height - (this.pictureBox1.Image.Height * num4)) / 2.0);
                                                    this.maxHeight = this.pictureBox1.Height - ((int)((this.pictureBox1.Height - (this.pictureBox1.Image.Height * num4)) / 2.0));
                                                }
                                            }
                                            this.s_rect.Width = (int)Math.Round((double)(rect.Width * num4));
                                            this.s_rect.Height = (int)Math.Round((double)(rect.Height * num4));
                                            this.s_rect.X = ((int)Math.Round((double)(rect.X * num4))) + this.minWidth;
                                            this.s_rect.Y = ((int)Math.Round((double)(rect.Y * num4))) + this.minHeight;
                                            if ((this.curNum == this.tempNum) && !this.curEdit)
                                            {
                                                s_rectList[this.tempNum] = this.s_rect;
                                            }
                                        }
                                    }
                                }
                                this.tmpcontour = this.tmpcontour.HNext;
                            }
                        }
                        using (IplImage image4 = new IplImage(rect.Width, rect.Height, image.Depth, image.NChannels))
                        {
                            if (this.autoTrim)
                            {
                                CvScalar fillval = Cv.ScalarAll(0.0);
                                CvMat mapMatrix = new CvMat(3, 3, MatrixType.F32C1);
                                CvPoint2D32f[] src = new CvPoint2D32f[4];
                                CvPoint2D32f[] pointdfArray2 = new CvPoint2D32f[4];
                                double num7 = Math.Sqrt(Math.Pow((double)(pointArray[1].X - pointArray[0].X), 2.0) + Math.Pow((double)(pointArray[1].Y - pointArray[0].Y), 2.0));
                                double num8 = Math.Sqrt(Math.Pow((double)(pointArray[2].X - pointArray[1].X), 2.0) + Math.Pow((double)(pointArray[2].Y - pointArray[1].Y), 2.0));
                                if (num7 > num8)
                                {
                                    src[0] = pointArray[2];
                                    src[1] = pointArray[3];
                                    src[2] = pointArray[0];
                                    src[3] = pointArray[1];
                                }
                                else
                                {
                                    src[0] = pointArray[3];
                                    src[1] = pointArray[0];
                                    src[2] = pointArray[1];
                                    src[3] = pointArray[2];
                                }
                                pointdfArray2[0] = new CvPoint2D32f(0.0, 0.0);
                                pointdfArray2[1] = new CvPoint2D32f((double)rect.Width, 0.0);
                                pointdfArray2[2] = new CvPoint2D32f((float)rect.Width, (float)rect.Height);
                                pointdfArray2[3] = new CvPoint2D32f(0f, (float)rect.Height);
                                Cv.GetPerspectiveTransform(src, pointdfArray2, out mapMatrix);
                                Cv.WarpPerspective(image, image4, mapMatrix, Interpolation.NearestNeighbor, fillval);
                                for (int j = 0; j < 4; j++)
                                {
                                    this.svDstPnt[j].X = (int)pointdfArray2[j].X;
                                    this.svDstPnt[j].Y = (int)pointdfArray2[j].Y;
                                }
                            }
                            else
                            {
                                Cv.SetImageROI(image, rect);
                                Cv.Copy(image, image4);
                                Cv.ResetImageROI(image);
                            }
                            if (((this.autoCut && (this.tempNum < 0x80)) && ((this.curNum == this.tempNum) || (this.curNum == 0))) && !this.curEdit)
                            {
                                int autoDevW = 1;
                                int autoDevH = 1;
                                if ((this.autoDevW * this.autoDevH) < 0x80)
                                {
                                    if ((this.autoDevW > 0) && (this.autoDevW < 0x80))
                                    {
                                        autoDevW = this.autoDevW;
                                    }
                                    if ((this.autoDevH > 0) && (this.autoDevH < 0x80))
                                    {
                                        autoDevH = this.autoDevH;
                                    }
                                }
                                double num12 = Math.Round((double)(((double)rect.Width) / ((double)autoDevW)), MidpointRounding.AwayFromZero);
                                double num13 = Math.Round((double)(((double)rect.Height) / ((double)autoDevH)), MidpointRounding.AwayFromZero);
                                if ((rect.Width / autoDevW) < 3)
                                {
                                    num12 = 3.0;
                                }
                                if ((rect.Height / autoDevH) < 3)
                                {
                                    num13 = 3.0;
                                }
                                int num14 = 4;
                                int num15 = 4;
                                if (num12 < 10.0)
                                {
                                    num14 = 4;
                                }
                                else
                                {
                                    num14 = 4;
                                }
                                if (num13 < 10.0)
                                {
                                    num15 = 8;
                                }
                                else
                                {
                                    num15 = 8;
                                }
                                using (IplImage image5 = new IplImage(((int)num12) + num14, ((int)num13) + num15, image.Depth, image.NChannels))
                                {
                                    int width = (int)num12;
                                    int height = (int)num13;
                                    int x = 0;
                                    int y = 0;
                                    int num20 = 0;
                                    int num21 = 0;
                                    if (!this.autoTrim)
                                    {
                                        x = rect.X;
                                        y = rect.Y;
                                    }
                                    CvRect rect3 = new CvRect(x, y, width, height);
                                    CvRect rect4 = new CvRect(0, 0, 0, 0);
                                    for (int k = 0; k < autoDevH; k++)
                                    {
                                        if (this.tempNum >= 0x80)
                                        {
                                            break;
                                        }
                                        rect3.Y = y + (height * k);
                                        if ((((rect3.Height + num15) + rect3.Y) - (num15 / 2)) >= image.Height)
                                        {
                                            num21 = (image.Height - (((rect3.Height + num15) + rect3.Y) - (num15 / 2))) - 1;
                                        }
                                        else
                                        {
                                            num21 = 0;
                                        }
                                        for (int m = 0; m < autoDevW; m++)
                                        {
                                            if (this.tempNum >= 0x80)
                                            {
                                                break;
                                            }
                                            rect3.X = x + (width * m);
                                            if ((((rect3.Width + num14) + rect3.X) - (num14 / 2)) >= image.Width)
                                            {
                                                num20 = (image.Width - (((rect3.Width + num14) + rect3.X) - (num14 / 2))) - 1;
                                            }
                                            else
                                            {
                                                num20 = 0;
                                            }
                                            r_rectList[this.tempNum].Width = rect3.Width + num14;
                                            r_rectList[this.tempNum].Height = rect3.Height + num15;
                                            r_rectList[this.tempNum].X = (rect3.X - (num14 / 2)) + num20;
                                            r_rectList[this.tempNum].Y = (rect3.Y - (num15 / 2)) + num21;
                                            if (r_rectList[this.tempNum].X < 0)
                                            {
                                                r_rectList[this.tempNum].X = 0;
                                            }
                                            if (r_rectList[this.tempNum].Y < 0)
                                            {
                                                r_rectList[this.tempNum].Y = 0;
                                            }
                                            rect4 = new CvRect(r_rectList[this.tempNum].X, r_rectList[this.tempNum].Y, r_rectList[this.tempNum].Width, r_rectList[this.tempNum].Height);
                                            Cv.SetImageROI(image, rect4);
                                            Cv.Copy(image, image5);
                                            Cv.ResetImageROI(image);
                                            this.SetupScaleAngle(this.tmpAngleRange, this.tmpAngleStep, this.tmpScaleMin, this.tmpScaleMax, this.tmpScaleStep);
                                            if (((this.tempNum < 0x80) && ((this.curNum == this.tempNum) || (this.curNum == 0))) && !this.curEdit)
                                            {
                                                this.tmpDataNum[this.tempNum] = new TEMPLATE_DATA_NUM();
                                                System.Drawing.Point pt = new System.Drawing.Point(rect4.X, rect4.Y);
                                                this.SetupTemplateNumImages(this.tempNum, image5, pt);
                                                using (IplImage image6 = new IplImage(Cv.Size(this.tmpDataNum[this.tempNum].tmpData[this.tmpDataNum[this.tempNum].refScaleID, this.tmpDataNum[this.tempNum].refAngleID].image.Width, this.tmpDataNum[this.tempNum].tmpData[this.tmpDataNum[this.tempNum].refScaleID, this.tmpDataNum[this.tempNum].refAngleID].image.Height), this.tmpDataNum[this.tempNum].tmpData[this.tmpDataNum[this.tempNum].refScaleID, this.tmpDataNum[this.tempNum].refAngleID].image.Depth, this.tmpDataNum[this.tempNum].tmpData[this.tmpDataNum[this.tempNum].refScaleID, this.tmpDataNum[this.tempNum].refAngleID].image.NChannels))
                                                {
                                                    Cv.Copy(this.tmpDataNum[this.tempNum].tmpData[this.tmpDataNum[this.tempNum].refScaleID, this.tmpDataNum[this.tempNum].refAngleID].image, image6);
                                                    Cv.Rectangle(image6, 0, 0, image6.Width - 1, image6.Height - 1, Cv.RGB(0, 0, 0), 1);
                                                    if (!this.radioButton5.Checked)
                                                    {
                                                        using (IplImage image7 = new IplImage(image6.Size, image6.Depth, 1))
                                                        {
                                                            using (IplImage image8 = new IplImage(image6.Size, image6.Depth, 1))
                                                            {
                                                                Cv.CvtColor(image6, image7, ColorConversion.BgrToGray);
                                                                if (this.radioButton7.Checked)
                                                                {
                                                                    Cv.Threshold(image7, image8, (double)((int)this.numericUpDown21.Value), 255.0, ThresholdType.Binary);
                                                                    Cv.CvtColor(image8, image6, ColorConversion.GrayToBgr);
                                                                }
                                                                else
                                                                {
                                                                    Cv.CvtColor(image7, image6, ColorConversion.GrayToBgr);
                                                                }
                                                            }
                                                        }
                                                    }
                                                    this.pictureBox2.Image = image6.ToBitmap();
                                                }
                                                this.label2.Text = "No." + ((this.tempNum + 1)).ToString();
                                                this.label46.Text = rect4.X.ToString();
                                                this.label47.Text = rect4.Y.ToString();
                                                this.label48.Text = rect4.Width.ToString();
                                                this.label49.Text = rect4.Height.ToString();
                                                this.refModelObjNum[this.tempNum] = this.SaveRefModel(this.tempNum, "", image5.ToBitmap());
                                                if (this.tempNum < 0x80)
                                                {
                                                    this.tempNum++;
                                                    this.curNum = this.tempNum;
                                                }
                                                this.clickPoint.X = (s_rectList[this.curNum - 1].X + (s_rectList[this.curNum - 1].Width / 2)) - 1;
                                                this.clickPoint.Y = (s_rectList[this.curNum - 1].Y + (s_rectList[this.curNum - 1].Height / 2)) - 1;
                                            }
                                        }
                                    }
                                    goto Label_1DE2;
                                }
                            }
                            this.SetupScaleAngle(this.tmpAngleRange, this.tmpAngleStep, this.tmpScaleMin, this.tmpScaleMax, this.tmpScaleStep);
                            if (((this.tempNum < 0x80) && ((this.curNum == this.tempNum) || (this.curNum == 0))) && (!this.curEdit && (this.tempNum < this.refModelObjNum.Length)))
                            {
                                this.tmpDataNum[this.tempNum] = new TEMPLATE_DATA_NUM();
                                System.Drawing.Point point2 = new System.Drawing.Point(rect.X, rect.Y);
                                this.SetupTemplateNumImages(this.tempNum, image4, point2);
                                using (IplImage image9 = new IplImage(Cv.Size(this.tmpDataNum[this.tempNum].tmpData[this.tmpDataNum[this.tempNum].refScaleID, this.tmpDataNum[this.tempNum].refAngleID].image.Width, this.tmpDataNum[this.tempNum].tmpData[this.tmpDataNum[this.tempNum].refScaleID, this.tmpDataNum[this.tempNum].refAngleID].image.Height), this.tmpDataNum[this.tempNum].tmpData[this.tmpDataNum[this.tempNum].refScaleID, this.tmpDataNum[this.tempNum].refAngleID].image.Depth, this.tmpDataNum[this.tempNum].tmpData[this.tmpDataNum[this.tempNum].refScaleID, this.tmpDataNum[this.tempNum].refAngleID].image.NChannels))
                                {
                                    Cv.Copy(this.tmpDataNum[this.tempNum].tmpData[this.tmpDataNum[this.tempNum].refScaleID, this.tmpDataNum[this.tempNum].refAngleID].image, image9);
                                    Cv.Rectangle(image9, 0, 0, image9.Width - 1, image9.Height - 1, Cv.RGB(0, 0, 0), 1);
                                    if (!this.radioButton5.Checked)
                                    {
                                        using (IplImage image10 = new IplImage(image9.Size, image9.Depth, 1))
                                        {
                                            using (IplImage image11 = new IplImage(image9.Size, image9.Depth, 1))
                                            {
                                                Cv.CvtColor(image9, image10, ColorConversion.BgrToGray);
                                                if (this.radioButton7.Checked)
                                                {
                                                    Cv.Threshold(image10, image11, (double)((int)this.numericUpDown21.Value), 255.0, ThresholdType.Binary);
                                                    Cv.CvtColor(image11, image9, ColorConversion.GrayToBgr);
                                                }
                                                else
                                                {
                                                    Cv.CvtColor(image10, image9, ColorConversion.GrayToBgr);
                                                }
                                            }
                                        }
                                    }
                                    this.pictureBox2.Image = image9.ToBitmap();
                                }
                                this.label2.Text = "No." + ((this.tempNum + 1)).ToString();
                                this.label46.Text = rect.X.ToString();
                                this.label47.Text = rect.Y.ToString();
                                this.label48.Text = rect.Width.ToString();
                                this.label49.Text = rect.Height.ToString();
                                this.refModelObjNum[this.tempNum] = this.SaveRefModel(this.tempNum, "", image4.ToBitmap());
                                if (this.tempNum < 0x80)
                                {
                                    this.tempNum++;
                                    this.curNum = this.tempNum;
                                }
                                this.clickPoint.X = (s_rectList[this.curNum - 1].X + (s_rectList[this.curNum - 1].Width / 2)) - 1;
                                this.clickPoint.Y = (s_rectList[this.curNum - 1].Y + (s_rectList[this.curNum - 1].Height / 2)) - 1;
                            }
                            else if (((this.curNum <= this.tempNum) && (this.curNum > 0)) && this.curEdit)
                            {
                                this.tmpDataNum[this.curNum - 1] = new TEMPLATE_DATA_NUM();
                                System.Drawing.Point point3 = new System.Drawing.Point(rect.X, rect.Y);
                                this.SetupTemplateNumImages(this.curNum - 1, image4, point3);
                                this.label2.Text = "No." + this.curNum.ToString();
                                this.label46.Text = rect.X.ToString();
                                this.label47.Text = rect.Y.ToString();
                                this.label48.Text = rect.Width.ToString();
                                this.label49.Text = rect.Height.ToString();
                                this.refModelObjNum[this.curNum - 1] = this.SaveRefModel(this.curNum - 1, this.comboBox1.Text, image4.ToBitmap());
                                if (this.tmpDataNum[this.curNum - 1].tmpData != null)
                                {
                                    using (IplImage image12 = new IplImage(Cv.Size(this.tmpDataNum[this.curNum - 1].tmpData[this.tmpDataNum[this.curNum - 1].refScaleID, this.tmpDataNum[this.curNum - 1].refAngleID].image.Width, this.tmpDataNum[this.curNum - 1].tmpData[this.tmpDataNum[this.curNum - 1].refScaleID, this.tmpDataNum[this.curNum - 1].refAngleID].image.Height), this.tmpDataNum[this.curNum - 1].tmpData[this.tmpDataNum[this.curNum - 1].refScaleID, this.tmpDataNum[this.curNum - 1].refAngleID].image.Depth, this.tmpDataNum[this.curNum - 1].tmpData[this.tmpDataNum[this.curNum - 1].refScaleID, this.tmpDataNum[this.curNum - 1].refAngleID].image.NChannels))
                                    {
                                        Cv.Copy(this.tmpDataNum[this.curNum - 1].tmpData[this.tmpDataNum[this.curNum - 1].refScaleID, this.tmpDataNum[this.curNum - 1].refAngleID].image, image12);
                                        Cv.Rectangle(image12, 0, 0, image12.Width - 1, image12.Height - 1, Cv.RGB(0, 0, 0), 1);
                                        if (!this.radioButton5.Checked)
                                        {
                                            using (IplImage image13 = new IplImage(image12.Size, image12.Depth, 1))
                                            {
                                                using (IplImage image14 = new IplImage(image12.Size, image12.Depth, 1))
                                                {
                                                    Cv.CvtColor(image12, image13, ColorConversion.BgrToGray);
                                                    if (this.radioButton7.Checked)
                                                    {
                                                        Cv.Threshold(image13, image14, (double)((int)this.numericUpDown21.Value), 255.0, ThresholdType.Binary);
                                                        Cv.CvtColor(image14, image12, ColorConversion.GrayToBgr);
                                                    }
                                                    else
                                                    {
                                                        Cv.CvtColor(image13, image12, ColorConversion.GrayToBgr);
                                                    }
                                                }
                                            }
                                        }
                                        this.pictureBox2.Image = image12.ToBitmap();
                                    }
                                    this.clickPoint.X = this.tmpDataNum[this.curNum - 1].pt.X - 2;
                                    this.clickPoint.X = this.tmpDataNum[this.curNum - 1].pt.Y - 2;
                                }
                            }
                            Label_1DE2:
                            this.s_rect = new Rectangle(0, 0, 0, 0);
                            this.r_rect = new Rectangle(0, 0, 0, 0);
                            this.label52.Text = this.tempNum.ToString();
                            this.label50.Text = this.curNum.ToString();
                            if (!this.button18.Enabled && (this.tempNum > 1))
                            {
                                this.button18.Enabled = true;
                            }
                        }
                    }
                    //if (((this.tempNum > 0) && !this.button14.Enabled) && this.teachFlg)
                    //{
                    //    this.button14.Enabled = true;
                    //}
                    this.curEdit = false;
                    if (this.teachFlg)
                    {
                        this.buttonteaching.Enabled = true;
                    }
                    this.label74.Text = "";
                    this.label74.ForeColor = Color.WhiteSmoke;
                    this.setFlg = true;
                    this.button7.ForeColor = Color.Red;
                    this.button7.Enabled = true;
                    this.pictureBox1.Image = this.pictureBox1.Image;
                    this.pictureBox1.Invalidate();
                }
                this.CheckPresetData();
                this.ButtonInterlock(false);
                if (Cursor.Current != Cursors.Default)
                {
                    Cursor.Current = Cursors.Default;
                }
            }

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {

            this.formResize = true;
            for (int i = 0; i < this.tempNum; i++)
            {
                s_rectList[i] = this.CmvViewRectangle(Cv.Size(this.pictureBox1.Width, this.pictureBox1.Height), Cv.Size(this.srcImgWidth, this.srcImgHeight), r_rectList[i]);
            }
            for (int j = 0; j < this.measureNum; j++)
            {
                ms_rectList[j] = this.CmvViewRectangle(Cv.Size(this.pictureBox1.Width, this.pictureBox1.Height), Cv.Size(this.srcImgWidth, this.srcImgHeight), mr_rectList[j]);
            }
            if (base.Width < 0x3fc)
            {
                //this.groupBox4.Width = 0x24a - (0x3fc - base.Width);
                this.button8.Text = "Diff Area on/off";
                this.button8.Width = 0x62 - (0x3fc - base.Width);
            }
            else
            {
                this.button8.Text = "DIFF_AREA";
                this.button8.Width = 0x62;
                //this.groupBox4.Width = (this.button8.Location.X + this.button8.Width) - this.button1.Location.X;
            }
            //if (this.panel2.Width == (this.button22.Width + this.button22.Location.X))
            //{
            //    this.DbPictureBoxView(false);
            //}
            //else
            //{
            //this.DbPictureBoxView(true);
            //}
            this.pictureBox1.Refresh();
            this.formResize = false;
        }

        //private void DbPictureBoxView(bool st)
        //{
        //    if (!st)
        //    {
        //        this.button22.Text = "◀";
        //        this.panel2.Width = this.button22.Width + this.button22.Location.X;
        //        this.panel2.Location = new System.Drawing.Point((this.pictureBox1.Location.X + this.pictureBox1.Width) - this.panel2.Width, (this.pictureBox1.Location.Y + this.pictureBox1.Height) - this.panel2.Height);
        //        this.pictureBox7.Visible = false;
        //        this.pictureBox4.Visible = false;
        //        this.pictureBox9.Visible = false;
        //        this.pictureBox8.Visible = false;
        //        this.pictureBox3.Visible = false;
        //        this.label75.Visible = false;
        //        this.label76.Visible = false;
        //        this.label77.Visible = false;
        //        this.label78.Visible = false;
        //        this.label79.Visible = false;
        //        this.pictureBox7.Enabled = false;
        //        this.pictureBox4.Enabled = false;
        //        this.pictureBox9.Enabled = false;
        //        this.pictureBox8.Enabled = false;
        //        this.pictureBox3.Enabled = false;
        //        this.label75.Enabled = false;
        //        this.label76.Enabled = false;
        //        this.label77.Enabled = false;
        //        this.label78.Enabled = false;
        //        this.label79.Enabled = false;
        //    }
        //    else
        //    {
        //        this.button22.Text = "▶";
        //        if (this.panel2Width > 0)
        //        {
        //            this.panel2.Width = this.panel2Width;
        //        }
        //        else
        //        {
        //            this.panel2.Width = 0x1dc;
        //        }
        //        if (this.panel2.Width > (this.pictureBox1.Width - 0x2a))
        //        {
        //            this.panel2.Width = this.pictureBox1.Width - 0x2a;
        //        }
        //        else if (this.panel2.Width < 0x1dc)
        //        {
        //            this.panel2.Width = 0x1dc;
        //        }
        //        if (this.panel2Height > 0)
        //        {
        //            this.panel2.Height = this.panel2Height;
        //        }
        //        else
        //        {
        //            this.panel2.Height = 80;
        //        }
        //        if (this.panel2.Height > (this.pictureBox1.Height - 0x20))
        //        {
        //            this.panel2.Height = this.pictureBox1.Height - 0x20;
        //        }
        //        else if (this.panel2.Height < 80)
        //        {
        //            this.panel2.Height = 80;
        //        }
        //        this.pictureBox7.Width = ((this.panel2.Width - this.button22.Width) - this.button22.Location.X) / 5;
        //        this.pictureBox4.Width = this.pictureBox8.Width = this.pictureBox9.Width = this.pictureBox3.Width = this.pictureBox7.Width;
        //        this.pictureBox4.Location = new System.Drawing.Point(this.pictureBox7.Location.X + this.pictureBox7.Width, this.pictureBox7.Location.Y);
        //        this.pictureBox8.Location = new System.Drawing.Point(this.pictureBox4.Location.X + this.pictureBox4.Width, this.pictureBox7.Location.Y);
        //        this.pictureBox9.Location = new System.Drawing.Point(this.pictureBox8.Location.X + this.pictureBox8.Width, this.pictureBox7.Location.Y);
        //        this.pictureBox3.Location = new System.Drawing.Point(this.pictureBox9.Location.X + this.pictureBox9.Width, this.pictureBox7.Location.Y);
        //        this.label79.Text = "DIFFERENCE_IMAGE";
        //        if (this.label79.Width > this.pictureBox3.Width)
        //        {
        //            this.label79.Text = "DIFFERENCE";
        //        }
        //        this.label75.Location = new System.Drawing.Point((this.pictureBox7.Location.X + (this.pictureBox7.Width / 2)) - (this.label75.Width / 2), this.pictureBox7.Location.Y - this.label75.Height);
        //        this.label76.Location = new System.Drawing.Point((this.pictureBox4.Location.X + (this.pictureBox4.Width / 2)) - (this.label76.Width / 2), this.pictureBox4.Location.Y - this.label76.Height);
        //        this.label77.Location = new System.Drawing.Point((this.pictureBox8.Location.X + (this.pictureBox8.Width / 2)) - (this.label77.Width / 2), this.pictureBox8.Location.Y - this.label77.Height);
        //        this.label78.Location = new System.Drawing.Point((this.pictureBox9.Location.X + (this.pictureBox9.Width / 2)) - (this.label78.Width / 2), this.pictureBox9.Location.Y - this.label78.Height);
        //        this.label79.Location = new System.Drawing.Point((this.pictureBox3.Location.X + (this.pictureBox3.Width / 2)) - (this.label79.Width / 2), this.pictureBox3.Location.Y - this.label79.Height);
        //        this.panel2.Location = new System.Drawing.Point((this.pictureBox1.Location.X + this.pictureBox1.Width) - this.panel2.Width, (this.pictureBox1.Location.Y + this.pictureBox1.Height) - this.panel2.Height);
        //        this.pictureBox7.Visible = true;
        //        this.pictureBox4.Visible = true;
        //        this.pictureBox9.Visible = true;
        //        this.pictureBox8.Visible = true;
        //        this.pictureBox3.Visible = true;
        //        this.label75.Visible = true;
        //        this.label76.Visible = true;
        //        this.label77.Visible = true;
        //        this.label78.Visible = true;
        //        this.label79.Visible = true;
        //        this.pictureBox7.Enabled = true;
        //        this.pictureBox4.Enabled = true;
        //        this.pictureBox9.Enabled = true;
        //        this.pictureBox8.Enabled = true;
        //        this.pictureBox3.Enabled = true;
        //        this.label75.Enabled = true;
        //        this.label76.Enabled = true;
        //        this.label77.Enabled = true;
        //        this.label78.Enabled = true;
        //        this.label79.Enabled = true;
        //    }
        //}

        private void LoadRefModelDataNum(string path)
        {
            if (this.comboBox1.Text != null)// kiem tra lai xem combobox co trang hay khong
            {
                this.tmpDataNum = new TEMPLATE_DATA_NUM[0x80]; // khoi tao lai tmpDataNum
                this.refModelObjNum = new RefModel[0x80];// khoi tao lai mang luu thong tin cai dat ref
                if (this.comboBox1.Text != "")
                {
                    string str = path;
                    if (!str.EndsWith(@"\"))
                    {
                        str = str + @"\";
                    }
                    string str2 = str + this.comboBox1.Text + ".csv";
                    if (File.Exists(str2))// neu file path not exist
                    {
                        if (!this.teachFlg)
                        {
                            this.CurrentDataClear();// xoa du lieu hien tai da chon luc truoc
                        }
                        //========load du lieu
                        //int numline = int.Parse(ReadCsvFile.ReadTextFile(str2, 6));
                        this.refModelObjNum = new RefModel[(ReadCsvFile.CounterlineTextFile(str2)) - 1];
                        for (int i = 0; i < refModelObjNum.Length; i++)
                        {
                            string Linereal = ReadCsvFile.ReadTextFile(str2, i + 2);
                            string[] row = new string[128];
                            row = Linereal.Split(',');
                            System.Drawing.Point[] pointload = new System.Drawing.Point[4];
                            pointload[0] = new System.Drawing.Point((int.Parse(row[42])), (int.Parse(row[43])));

                            pointload[1] = new System.Drawing.Point((int.Parse(row[44])), (int.Parse(row[45])));
                            pointload[2] = new System.Drawing.Point((int.Parse(row[46])), (int.Parse(row[47])));
                            pointload[3] = new System.Drawing.Point((int.Parse(row[48])), (int.Parse(row[49])));
                            Bitmap bmp = Cv.LoadImage(str + comboBox1.Text + @"\" + i.ToString() + ".bmp", LoadMode.AnyColor).ToBitmap();
                            Rectangle _rect = new Rectangle((int.Parse(row[24])), (int.Parse(row[25])), (int.Parse(row[26])), (int.Parse(row[27])));
                            this.refModelObjNum[i] = new RefModel(
                                 row[0],
                                 bmp,
                                 int.Parse(row[1]),
                                 long.Parse(row[2]),
                                 double.Parse(row[3]),
                        int.Parse(row[4]),
                        int.Parse(row[5]),
                        int.Parse(row[6]),
                        int.Parse(row[7]),
                         int.Parse(row[8]),
                         int.Parse(row[9]),
                         int.Parse(row[10]),
                         int.Parse(row[11]),
                        int.Parse(row[12]),
                        int.Parse(row[13]),
                        int.Parse(row[14]),
                        int.Parse(row[15]),
                        int.Parse(row[16]),
                        double.Parse(row[17]),
                        double.Parse(row[18]),
                        double.Parse(row[19]),
                        double.Parse(row[20]),
                        double.Parse(row[21]),
                        int.Parse(row[22]),
                        int.Parse(row[23]),
                        _rect,
                        bool.Parse(row[28]),
                        bool.Parse(row[29]),
                        int.Parse(row[30]),
                        int.Parse(row[31]),
                        int.Parse(row[32]),
                        int.Parse(row[33]),
                        float.Parse(row[34]),
                        float.Parse(row[35]),
                        bool.Parse(row[36]),
                        row[37],
                        bool.Parse(row[38]),
                        bool.Parse(row[39]),
                        int.Parse(row[40]),
                        int.Parse(row[41]),

                        // Point[] svDstPnt,
                        pointload,

                        double.Parse(row[50]),
                        int.Parse(row[51]),
                        bool.Parse(row[52]),
                        bool.Parse(row[53]),
                        row[54],
                        row[55]
                         );
                            // RefModel("", null, 0, 0L, 0.0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.0, 0.0, 0.0, 0.0, 0.0, 0, 0, init_rect, true, true, 0, 0, 0, 0, 0f, 0f, true, "", false, false, 0, 0, null, 0.0, 0, false, false, "", "")

                        }
                        //-------------------------------------------------------------------------------------

                        //this.refModelObjNum = (RefModel[])LoadFromBinaryFile(str2);// lay du lieu trong file str2 luu vao class refmodeobjnum
                        if (this.refModelObjNum.Length < 0x80)
                        {
                            RefModel[] destinationArray = new RefModel[0x80];
                            Array.Copy(this.refModelObjNum, destinationArray, this.refModelObjNum.Length);
                            this.refModelObjNum = destinationArray;
                        }
                        this.tempNum = this.refModelObjNum[0].maxPoint;
                        if (this.tempNum > 0x80)
                        {
                            this.tempNum = 0x80;
                        }
                        this.curNum = this.tempNum;
                        this.measureNum = 0;
                        for (int i = this.tempNum - 1; i >= 0; i--)
                        {
                            r_rectList[i] = this.refModelObjNum[i].r_rect;
                        }
                        for (int j = 0; j < this.tempNum; j++)
                        {
                            if (this.refModelObjNum[j] != null)
                            {
                                this.MakeTempImage(j);
                            }
                        }
                        this.DispRefModelData(0);
                        this.curNum = 1;
                        this.CheckPresetData();
                        if (this.tempNum > 1)
                        {
                            this.button18.Enabled = true;
                            this.button19.Enabled = true;
                        }
                        else
                        {
                            this.button18.Enabled = false;
                            this.button19.Enabled = false;
                        }
                    }
                }
                else
                {
                    this.DataClear();
                    this.LoadInitModelData();
                    this.CheckPresetData();
                    this.button18.Enabled = false;
                    this.button19.Enabled = false;
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((this.comboBox1.Text != null) && (this.comboBox1.Text != this.curModelName))
            {
                if (Cursor.Current != Cursors.WaitCursor)
                {
                    Cursor.Current = Cursors.WaitCursor;
                }
                this.ButtonInterlock(true);
                this.button7.ForeColor = Color.Black;
                s_rectList = new Rectangle[0x81];
                r_rectList = new Rectangle[0x81];
                this.tmpDataNum = new TEMPLATE_DATA_NUM[0x80];
                this.tempNum = 0;
                this.measureNum = 0;
                this.curNum = 0;
                this.label27.Text = "0";
                this.label29.Text = "0";
                this.label70.Text = "0";
                this.label71.Text = "0";
                this.label2.Text = "N0.";
                this.label46.Text = "0";
                this.label47.Text = "0";
                this.label48.Text = "0";
                this.label49.Text = "0";
                this.label50.Text = "0";
                this.label52.Text = "0";
                this.label73.Text = "0";
                this.label58.Text = "0";
                this.label59.Text = "0";
                this.label64.Text = "0";
                this.label67.Text = "0";
                // this.label92.Text = "";
                // this.label94.Text = "";
                this.measurementCount = 0;
                this.measurementOk = 0;
                this.measurementNg = 0;
                //this.StopSound();
                if (this.teachFlg && !this.setFlg) // neu bien teach =true va co set = false
                {
                    this.Teaching();// chuyen sang che do teaching
                }
                this.LoadRefModelDataNum(this.modelSavePath);// load du lieu model chon
                if (((this.tempNum > 0) && (this.usbCam || this.gigeCam || this.camok)) && !this.teachFlg)
                {
                    this.button2.Enabled = true;
                }
                this.ButtonInterlock(false);
                if (Cursor.Current != Cursors.Default)
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            this.curModelName = this.comboBox1.Text;

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            if (this.button7.ForeColor != Color.WhiteSmoke)
            {
                if (MessageBox.Show("CHANGED_SAVE", "Robot", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    this.ModelDataSave(this.modelSavePath);
                }
                else
                {
                    this.button7.ForeColor = Color.Black;
                }
            }

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.modelDell = true;
        }

        private void comboBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if ((((this.cur_userLevel > 0) && (e.KeyCode == Keys.Delete)) && ((this.curModelName == this.comboBox1.Text) && (this.comboBox1.SelectedIndex > 0))) && this.modelDell)
            {
                this.modelDell = false;
                DialogResult result = MessageBox.Show(Resources.CB1_KEYDOWN_MSG_REMOVE_DATA, "AAC-1000", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    string modelSavePath = this.modelSavePath;
                    if (!modelSavePath.EndsWith(@"\"))
                    {
                        modelSavePath = modelSavePath + @"\";
                    }
                    string path = modelSavePath + this.comboBox1.Text + ".csv";
                    if (File.Exists(path))
                    {
                        this.comboBox1.Items.RemoveAt(this.comboBox1.SelectedIndex);
                        File.Delete(path);
                        this.DataClear();
                    }
                }
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((this.dstdifimg != null) && !this.timer1.Enabled) && this.comboBox2.Focused)
            {
                this.stat = 0x67;
                this.timer1.Enabled = true;
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((this.dstdifimg != null) && !this.timer1.Enabled) && this.comboBox2.Focused)
            {
                this.stat = 0x67;
                this.timer1.Enabled = true;
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((this.dstdifimg != null) && !this.timer1.Enabled) && this.comboBox2.Focused)
            {
                this.stat = 0x67;
                this.timer1.Enabled = true;
            }

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((this.dstdifimg != null) && !this.timer1.Enabled) && this.comboBox2.Focused)
            {
                this.stat = 0x67;
                this.timer1.Enabled = true;
            }

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((this.dstdifimg != null) && !this.timer1.Enabled) && this.comboBox2.Focused)
            {
                this.stat = 0x67;
                this.timer1.Enabled = true;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.ModelDataSave(this.modelSavePath);

        }
        private void Measurement()
        {
            this.CurrentDataClear();
            //this.label61.Text = "time : 0.000 [sec]";
            if (Cursor.Current != Cursors.WaitCursor)
            {
                Cursor.Current = Cursors.WaitCursor;
            }
            this.measureNum = 0;
            this.curNum = 0;
            this.measureFlg = true;
        }


        private void MeasurementClick()
        {
            //if (this.bcdEnabled)
            //{
            //    if ((this.bcdLock && !this.bcdReadFlg) && !this.bcdwind)
            //    {
            //        this.bcdwind = true;
            //        MessageBox.Show(Resources.MCLICK_MSG_BARCODE_READ, "", MessageBoxButtons.OK);
            //        this.bcdwind = false;
            //        return;
            //    }
            //    if ((this.bcdLock && !this.bcdReadFlg) && this.bcdwind)
            //    {
            //        return;
            //    }
            //}
            //this.bcdReadFlg = false;
            this.swt.Restart();
            //this.StopSound();
            if (!this.fileOpFlg && (this.gigeCam || this.usbCam || this.camok))
            {
                this.measureFlg = true;
                this.ButtonInterlock(true);
                this.CaptureImage();
            }
            else
            {
                this.measureFlg = true;
                this.ButtonInterlock(true);
                this.Measurement();
                this.timer1.Interval = 15;
                this.stat = 80;
                this.timer1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.stepcheck = 0;
            this.MeasurementClick();

        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            this.trackBar8.Value = (int)Math.Round((double)(((double)this.numericUpDown10.Value) / 0.01));

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            this.trackBar5.Value = (int)this.numericUpDown9.Value;

        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            this.searchAreaOffsetX = (int)this.numericUpDown11.Value;

        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            this.searchAreaOffsetY = (int)this.numericUpDown12.Value;

        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            this.tmpAngleRange = (double)this.numericUpDown13.Value;

        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            this.tmpAngleStep = (double)this.numericUpDown14.Value;

        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            this.tmpScaleMin = (double)this.numericUpDown15.Value;

        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            this.tmpScaleMax = (double)this.numericUpDown16.Value;

        }

        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {
            this.tmpScaleStep = (double)this.numericUpDown17.Value;

        }

        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {
            if (((this.dstdifimg != null) && !this.timer1.Enabled) && this.numericUpDown18.Focused)
            {
                this.stat = 0x67;
                this.timer1.Enabled = true;
            }

        }

        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {
            if (((this.dstdifimg != null) && !this.timer1.Enabled) && this.numericUpDown19.Focused)
            {
                this.stat = 0x67;
                this.timer1.Enabled = true;
            }

        }

        private void numericUpDown21_ValueChanged(object sender, EventArgs e)
        {
            if (this.trackBar9.Value != ((int)this.numericUpDown21.Value))
            {
                this.trackBar9.Value = (int)this.numericUpDown21.Value;
            }

        }

        private void numericUpDown22_ValueChanged(object sender, EventArgs e)
        {
            if ((this.autoDevH * ((int)this.numericUpDown22.Value)) > 0x80)
            {
                this.numericUpDown22.Value = this.autoDevW;
            }
            else
            {
                this.autoDevW = (int)this.numericUpDown22.Value;
            }
            this.label103.Text = "= " + (((int)this.numericUpDown22.Value) * ((int)this.numericUpDown23.Value));

        }

        private void numericUpDown23_ValueChanged(object sender, EventArgs e)
        {
            if ((this.autoDevW * ((int)this.numericUpDown23.Value)) > 0x80)
            {
                this.numericUpDown23.Value = this.autoDevH;
            }
            else
            {
                this.autoDevH = (int)this.numericUpDown23.Value;
            }
            this.label103.Text = "= " + (((int)this.numericUpDown22.Value) * ((int)this.numericUpDown23.Value));

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.trackBar1.Value = (int)this.numericUpDown3.Value;

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            this.trackBar2.Value = (int)this.numericUpDown4.Value;

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            this.trackBar3.Value = (int)this.numericUpDown5.Value;

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            this.trackBar4.Value = (int)this.numericUpDown6.Value;

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            this.trackBar6.Value = (int)this.numericUpDown7.Value;

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            this.trackBar7.Value = (int)this.numericUpDown8.Value;

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown3.Value = this.trackBar1.Value;
            this.trackBar2.Value = this.trackBar3.Value = this.trackBar4.Value = this.trackBar1.Value;
            if (((this.dstdifimg != null) && !this.timer1.Enabled) && (this.trackBar1.Focused || this.numericUpDown3.Focused))
            {
                this.stat = 0x67;
                this.timer1.Enabled = true;
            }

        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown4.Value = this.trackBar2.Value;
            if (((this.dstdifimg != null) && !this.timer1.Enabled) && (this.trackBar2.Focused || this.numericUpDown4.Focused))
            {
                this.stat = 0x67;
                this.timer1.Enabled = true;
            }

        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown5.Value = this.trackBar3.Value;
            if (((this.dstdifimg != null) && !this.timer1.Enabled) && (this.trackBar3.Focused || this.numericUpDown5.Focused))
            {
                this.stat = 0x67;
                this.timer1.Enabled = true;
            }

        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown6.Value = this.trackBar4.Value;
            if (((this.dstdifimg != null) && !this.timer1.Enabled) && (this.trackBar4.Focused || this.numericUpDown6.Focused))
            {
                this.stat = 0x67;
                this.timer1.Enabled = true;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked)
            {
                if (this.radioButton1.Checked)
                {
                    this.numericUpDown3.Enabled = true;
                    this.trackBar1.Enabled = true;
                    this.numericUpDown4.Enabled = true;
                    this.trackBar2.Enabled = true;
                    this.numericUpDown5.Enabled = true;
                    this.trackBar3.Enabled = true;
                    this.numericUpDown6.Enabled = true;
                    this.trackBar4.Enabled = true;
                }
                else
                {
                    this.numericUpDown3.Enabled = true;
                    this.trackBar1.Enabled = true;
                    this.numericUpDown4.Enabled = false;
                    this.trackBar2.Enabled = false;
                    this.numericUpDown5.Enabled = false;
                    this.trackBar3.Enabled = false;
                    this.numericUpDown6.Enabled = false;
                    this.trackBar4.Enabled = false;
                }
            }
            else
            {
                this.numericUpDown3.Enabled = false;
                this.trackBar1.Enabled = false;
                this.numericUpDown4.Enabled = false;
                this.trackBar2.Enabled = false;
                this.numericUpDown5.Enabled = false;
                this.trackBar3.Enabled = false;
                this.numericUpDown6.Enabled = false;
                this.trackBar4.Enabled = false;
            }

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (this.numberDisp != this.checkBox10.Checked)
            {
                this.numberDisp = this.checkBox10.Checked;
                this.pictureBox1.Refresh();
            }


        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton10.Checked)
            {
                this.diffNG_Threshold = "OVER";
            }
            else
            {
                this.diffNG_Threshold = "UNDER";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked && this.radioButton1.Checked)
            {
                this.numericUpDown3.Enabled = true;
                this.trackBar1.Enabled = true;
                this.numericUpDown4.Enabled = true;
                this.trackBar2.Enabled = true;
                this.numericUpDown5.Enabled = true;
                this.trackBar3.Enabled = true;
                this.numericUpDown6.Enabled = true;
                this.trackBar4.Enabled = true;
            }
            else if (this.radioButton3.Checked && !this.radioButton1.Checked)
            {
                this.numericUpDown3.Enabled = true;
                this.trackBar1.Enabled = true;
                this.numericUpDown4.Enabled = false;
                this.trackBar2.Enabled = false;
                this.numericUpDown5.Enabled = false;
                this.trackBar3.Enabled = false;
                this.numericUpDown6.Enabled = false;
                this.trackBar4.Enabled = false;
            }
            else
            {
                this.numericUpDown3.Enabled = false;
                this.trackBar1.Enabled = false;
                this.numericUpDown4.Enabled = false;
                this.trackBar2.Enabled = false;
                this.numericUpDown5.Enabled = false;
                this.trackBar3.Enabled = false;
                this.numericUpDown6.Enabled = false;
                this.trackBar4.Enabled = false;
            }

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton8.Checked)
            {
                this.matcNG_Threshold = "OVER";
            }
            else
            {
                this.matcNG_Threshold = "UNDER";
            }

        }
        private void ClearClick()
        {
            this.bcdReadFlg = false;
            //this.textBox3.Text = "";
            this.srcImg = null;
            this.dstImg = null;
            this.CurrentDataClear();
            //if ((!string.IsNullOrEmpty(this.dioPortAssign.dioDeviceName) && !string.IsNullOrEmpty(this.dioPortAssign.dioModelName)) && this.dioPortAssign.dioEnable)
            //{
            //    this.dRESET = this.DioResetData();
            //    this.dio.OutByte(this.dioId, 0, this.dRESET);
            //    this.cur_dioPo = this.dioPo = this.dRESET;
            //    this.dio.InpByte(this.dioId, 0, out this.dioPi);
            //    this.cur_dioPi = this.dioPi;
            //}
            //this.StopSound();
        }






        private void DispListView()
        {
            string str = "";
            string str2 = "";
            if (this.diffResult != null)
            {
                this.listView1.Items.Clear();
                for (int i = 0; i < this.tempNum; i++)
                {
                    switch (this.judgeResult[i])
                    {
                        case -1:
                            str2 = "NG";
                            break;

                        case 0:
                            str2 = "Not inspection";
                            break;

                        case 1:
                            str2 = "PASS";
                            break;
                    }
                    string[] strArray = new string[6];
                    strArray[0] = (i + 1).ToString();
                    strArray[1] = this.refModelObjNum[i].checkPointName;
                    strArray[2] = this.diffResult[i].matchRate.ToString("0.00");
                    strArray[3] = this.diffResult[i].diffArea.ToString("0.00");
                    strArray[4] = str2;
                    string[] strArray2 = strArray;
                    ListViewItem item = new ListViewItem
                    {
                        UseItemStyleForSubItems = false,
                        Text = strArray2[0]
                    };
                    System.Drawing.FontStyle style = item.Font.Style;
                    Font font = new Font(item.Font.Name, item.Font.Size, style);
                    str = str + strArray2[0] + ",";
                    for (int j = 1; j < 5; j++)
                    {
                        if (strArray2[j] == "PASS")
                        {
                            item.SubItems.Add(strArray2[j], Color.RoyalBlue, Color.White, font);
                        }
                        else if (strArray2[j] == "NG")
                        {
                            item.ForeColor = Color.Red;
                            item.SubItems.Add(strArray2[j], Color.Red, Color.White, font);
                        }
                        else
                        {
                            item.SubItems.Add(strArray2[j], Color.Black, Color.White, font);
                        }
                        str = str + strArray2[j] + ",";
                    }
                    if (!this.checkBox3.Checked || (this.checkBox3.Checked && (str2 == "NG")))
                    {
                        this.listView1.Items.Add(item);
                    }
                    str = str + "\n";
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.listviewErrOnly != this.checkBox3.Checked)
            {
                this.DispListView();
                this.listviewErrOnly = this.checkBox3.Checked;
                this.pictureBox1.Refresh();
            }

        }

        //private void button31_Click(object sender, EventArgs e)
        //{
        //    this.rotation90 = !this.rotation90;
        //    if (this.rotation90)
        //    {
        //        this.button31.BackgroundImage = Resources.rotationCR;
        //        this.button31.ForeColor = Color.Cyan;
        //    }
        //    else
        //    {
        //        this.button31.BackgroundImage = Resources.rotationWR;
        //        this.button31.ForeColor = Color.WhiteSmoke;
        //    }

        //}

        //private void button31_EnabledChanged(object sender, EventArgs e)
        //{
        //    if (this.button31.Enabled)
        //    {
        //        if (this.rotation90)
        //        {
        //            this.button31.BackgroundImage = Resources.rotationCR;
        //        }
        //        else
        //        {
        //            this.button31.BackgroundImage = Resources.rotationWR;
        //        }
        //    }
        //    else
        //    {
        //        //this.button31.BackgroundImage = Resources.rotationGR;
        //    }

        //}

        //private void button32_Click(object sender, EventArgs e)
        //{
        //    this.rotation270 = !this.rotation270;
        //    if (this.rotation270)
        //    {
        //        this.button32.BackgroundImage = Resources.rotationCL;
        //        this.button32.ForeColor = Color.Cyan;
        //    }
        //    else
        //    {
        //        this.button32.BackgroundImage = Resources.rotationWL;
        //        this.button32.ForeColor = Color.WhiteSmoke;
        //    }

        //}

        //private void button32_EnabledChanged(object sender, EventArgs e)
        //{
        //    if (this.button32.Enabled)
        //    {
        //        if (this.rotation270)
        //        {
        //            this.button32.BackgroundImage = Resources.rotationCL;
        //        }
        //        else
        //        {
        //            this.button32.BackgroundImage = Resources.rotationWL;
        //        }
        //    }
        //    else
        //    {
        //        //this.button32.BackgroundImage = Resources.rotationGL;
        //    }

        //}
        private void RefModelReNewImage()
        {
            if ((this.dstImg != null) && (this.tempNum > 0))
            {
                CvRect rect = new CvRect();
                Rectangle rectangle = new Rectangle();
                this.refImg = Cv.CloneImage(this.dstImg);
                using (IplImage image = new IplImage(this.refImg.Size, this.refImg.Depth, this.refImg.NChannels))
                {
                    Cv.Copy(this.refImg, image);
                    for (int i = 0; i < this.tempNum; i++)
                    {
                        r_rectList[i].X += this.imageAdjust.imageTeachOffsetX;
                        r_rectList[i].Y += this.imageAdjust.imageTeachOffsetY;
                        this.refModelObjNum[i].positionX = r_rectList[i].X;
                        this.refModelObjNum[i].positionY = r_rectList[i].Y;
                        this.refModelObjNum[i].r_rect = r_rectList[i];
                        s_rectList[i] = this.CmvViewRectangle(Cv.Size(this.pictureBox1.Width, this.pictureBox1.Height), Cv.Size(this.srcImgWidth, this.srcImgHeight), r_rectList[i]);
                        rectangle = r_rectList[i];
                        if ((rectangle.Width > 1) && (rectangle.Height > 1))
                        {
                            rect.Width = rectangle.Width;
                            rect.Height = rectangle.Height;
                            rect.X = rectangle.X;
                            rect.Y = rectangle.Y;
                            using (IplImage image2 = new IplImage(rect.Width, rect.Height, image.Depth, image.NChannels))
                            {
                                Cv.SetImageROI(image, rect);
                                Cv.Copy(image, image2);
                                Cv.ResetImageROI(image);
                                this.tmpDataNum[i] = new TEMPLATE_DATA_NUM();
                                System.Drawing.Point pt = new System.Drawing.Point(rect.X, rect.Y);
                                this.SetupTemplateNumImages(i, image2, pt);
                                this.DispRefModelData(i);
                                this.refModelObjNum[i] = this.SaveRefModel(i, this.comboBox1.Text, image2.ToBitmap());
                            }
                        }
                    }
                }
                this.DispRefModelData(this.curNum - 1);
                this.CheckTempSelectButton();
                this.CheckPresetData();
                this.button7.ForeColor = Color.Red;
            }
        }


        private void button14_Click(object sender, EventArgs e)
        {
            this.RefModelReNewImage();

        }
        private void DispScrollView(CvRect dRect)
        {
            if (this.srcImg != null)
            {
                IplImage dst = Cv.CreateImage(Cv.Size(dRect.Width, dRect.Height), this.srcImg.Depth, this.srcImg.NChannels);
                try
                {
                    if (this.diffImageFlg && (this.diffImgFull != null))
                    {
                        if ((this.diffImgFull.Width > 0) && (this.diffImgFull.Height > 0))
                        {
                            Cv.SetImageROI(this.diffImgFull, dRect);
                            Cv.Copy(this.diffImgFull, dst);
                            Cv.ResetImageROI(this.diffImgFull);
                        }
                        else
                        {
                            Cv.SetImageROI(this.srcImg, dRect);
                            Cv.Copy(this.srcImg, dst);
                            Cv.ResetImageROI(this.srcImg);
                        }
                    }
                    else
                    {
                        Cv.SetImageROI(this.srcImg, dRect);
                        Cv.Copy(this.srcImg, dst);
                        Cv.ResetImageROI(this.srcImg);
                    }
                    this.pictureBox1.Image = dst.ToBitmap();
                }
                catch
                {
                }
                finally
                {
                    if (dst != null)
                    {
                        dst.Dispose();
                    }
                }
            }
        }


        private void DispSelectRectAngle(int num)
        {
            int num2 = 0;
            int num3 = 0;
            if (this.pictureBox1.Image != null)
            {
                num2 = this.drawRect.Width / 20;
                num3 = this.drawRect.Height / 20;
                Rectangle rectangle = new Rectangle(this.drawRect.X + num2, this.drawRect.Y + num3, this.drawRect.Width - (num2 * 2), this.drawRect.Height - (num3 * 2));
                System.Drawing.Point[] pointArray = new System.Drawing.Point[] { new System.Drawing.Point(r_rectList[num].X, r_rectList[num].Y), new System.Drawing.Point(r_rectList[num].X + r_rectList[num].Width, r_rectList[num].Y), new System.Drawing.Point(r_rectList[num].X + r_rectList[num].Width, r_rectList[num].Y + r_rectList[num].Height), new System.Drawing.Point(r_rectList[num].X, r_rectList[num].Y + r_rectList[num].Height) };
                if ((!rectangle.Contains(pointArray[0]) || !rectangle.Contains(pointArray[1])) || (!rectangle.Contains(pointArray[2]) || !rectangle.Contains(pointArray[3])))
                {
                    this.drawRect.X = (r_rectList[num].X + (r_rectList[num].Width / 2)) - (this.drawRect.Width / 2);
                    this.drawRect.Y = (r_rectList[num].Y + (r_rectList[num].Height / 2)) - (this.drawRect.Height / 2);
                    if ((this.drawRect.X + this.drawRect.Width) > this.srcImgWidth)
                    {
                        this.drawRect.X = (this.srcImgWidth - this.drawRect.Width) - 2;
                    }
                    if (this.drawRect.X < 0)
                    {
                        this.drawRect.X = 0;
                    }
                    if ((this.drawRect.Y + this.drawRect.Height) > this.srcImgHeight)
                    {
                        this.drawRect.Y = (this.srcImgHeight - this.drawRect.Height) - 2;
                    }
                    if (this.drawRect.Y < 0)
                    {
                        this.drawRect.Y = 0;
                    }
                    this.DispScrollView(this.drawRect);
                    this.ReSiazeRectangle();
                }
                else
                {
                    this.pictureBox1.Image = this.pictureBox1.Image;
                }
            }
            if (this.teachFlg)
            {
                this.clickPoint.X = (s_rectList[num].X + (s_rectList[num].Width / 2)) - 1;
                this.clickPoint.Y = (s_rectList[num].Y + (s_rectList[num].Height / 2)) - 1;
                if (this.tempNum > 0)
                {
                    this.button17.Enabled = true;
                }
                else
                {
                    this.button17.Enabled = false;
                }
            }
            else
            {
                this.clickPoint.X = (ms_rectList[num].X + (ms_rectList[num].Width / 2)) - 1;
                this.clickPoint.Y = (ms_rectList[num].Y + (ms_rectList[num].Height / 2)) - 1;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (this.curNum > 0)
            {
                this.tempNum--;
                this.curNum--;
                List<Rectangle> list = new List<Rectangle>(s_rectList);
                list.RemoveAt(this.curNum);
                list.Add(new Rectangle(0, 0, 0, 0));
                s_rectList = list.ToArray();
                List<Rectangle> list2 = new List<Rectangle>(r_rectList);
                list2.RemoveAt(this.curNum);
                list2.Add(new Rectangle(0, 0, 0, 0));
                r_rectList = list2.ToArray();
                List<TEMPLATE_DATA_NUM> list3 = new List<TEMPLATE_DATA_NUM>(this.tmpDataNum);
                list3.RemoveAt(this.curNum);
                list3.Add(new TEMPLATE_DATA_NUM());
                this.tmpDataNum = list3.ToArray();
                List<Rectangle> list4 = new List<Rectangle>(ms_rectList);
                list4.RemoveAt(this.curNum);
                list4.Add(new Rectangle(0, 0, 0, 0));
                ms_rectList = list4.ToArray();
                List<Rectangle> list5 = new List<Rectangle>(mr_rectList);
                list5.RemoveAt(this.curNum);
                list5.Add(new Rectangle(0, 0, 0, 0));
                mr_rectList = list5.ToArray();
                List<RefModel> list6 = new List<RefModel>(this.refModelObjNum);
                list6.RemoveAt(this.curNum);
                list6.Add(new RefModel("", null, 0, 0L, 0.0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.0, 0.0, 0.0, 0.0, 0.0, 0, 0, init_rect, true, true, 0, 0, 0, 0, 0f, 0f, true, "", false, false, 0, 0, null, 0.0, 0, false, false, "", ""));
                this.refModelObjNum = list6.ToArray();
                if (this.tempNum == 0)
                {
                    this.pictureBox2.Image = null;
                    this.button17.Enabled = false;
                }
                else
                {
                    if (this.curNum < 1)
                    {
                        this.curNum = 1;
                    }
                    using (IplImage image = new IplImage(Cv.Size(this.tmpDataNum[this.curNum - 1].tmpData[this.tmpDataNum[this.curNum - 1].refScaleID, this.tmpDataNum[this.curNum - 1].refAngleID].image.Width, this.tmpDataNum[this.curNum - 1].tmpData[this.tmpDataNum[this.curNum - 1].refScaleID, this.tmpDataNum[this.curNum - 1].refAngleID].image.Height), this.tmpDataNum[this.curNum - 1].tmpData[this.tmpDataNum[this.curNum - 1].refScaleID, this.tmpDataNum[this.curNum - 1].refAngleID].image.Depth, this.tmpDataNum[this.curNum - 1].tmpData[this.tmpDataNum[this.curNum - 1].refScaleID, this.tmpDataNum[this.curNum - 1].refAngleID].image.NChannels))
                    {
                        Cv.Copy(this.tmpDataNum[this.curNum - 1].tmpData[this.tmpDataNum[this.curNum - 1].refScaleID, this.tmpDataNum[this.curNum - 1].refAngleID].image, image);
                        Cv.Rectangle(image, 0, 0, image.Width - 1, image.Height - 1, Cv.RGB(0, 0, 0), 1);
                        this.pictureBox2.Image = image.ToBitmap();
                        this.clickPoint.X = (s_rectList[this.curNum - 1].X + (s_rectList[this.curNum - 1].Width / 2)) - 1;
                        this.clickPoint.Y = (s_rectList[this.curNum - 1].Y + (s_rectList[this.curNum - 1].Height / 2)) - 1;
                    }
                }
                this.pictureBox1.Image = this.pictureBox1.Image;
                this.pictureBox1.Refresh();
                this.label2.Text = "No." + this.curNum.ToString();
                this.label50.Text = this.curNum.ToString();
                this.label52.Text = this.tempNum.ToString();
                if (this.tempNum > 1)
                {
                    this.button18.Enabled = true;
                    this.button19.Enabled = true;
                }
                else
                {
                    this.button18.Enabled = false;
                    this.button19.Enabled = false;
                }
                this.button7.ForeColor = Color.Red;
            }

        }
        private void DispSelectItemProperty(int num)
        {
            int num2 = -1;
            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                if (num == int.Parse(this.listView1.Items[i].Text))
                {
                    if (!this.listView1.Items[i].Selected)
                    {
                        this.listView1.Items[i].Selected = true;
                    }
                    return;
                }
                if (this.listView1.Items[i].Selected)
                {
                    num2 = i;
                }
            }
            if (num2 >= 0)
            {
                this.listView1.Items[num2].Selected = false;
            }
            num--;
            this.DispRefModelData(num);
            this.CheckTempSelectButton();
            this.CheckPresetData();
            if (!this.mouseLBDownFlg)
            {
                this.DispSelectRectAngle(num);
            }
            if (this.teachFlg && (this.tempNum > 0))
            {
                this.button17.Enabled = true;
            }
            else
            {
                this.button17.Enabled = false;
            }
            this.DispSelectItem(num);
            this.pictureBox1.Refresh();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (this.curNum > 1)
            {
                this.curNum--;
                this.DispSelectItemProperty(this.curNum);
            }
            else if (this.curNum == 1)
            {
                this.curNum = this.tempNum;
                this.DispSelectItemProperty(this.curNum);
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (this.curNum < this.tempNum)
            {
                this.curNum++;
                this.DispSelectItemProperty(this.curNum);
            }
            else if (this.curNum == this.tempNum)
            {
                this.curNum = 1;
                this.DispSelectItemProperty(this.curNum);
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if ((((this.comboBox1.Text != "") && (this.curNum > 0)) && ((this.pictureBox2.Image != null) && (this.pictureBox2.Image.Width > 0))) && (this.pictureBox2.Image.Height > 0))
            {
                if (Cursor.Current != Cursors.WaitCursor)
                {
                    Cursor.Current = Cursors.WaitCursor;
                }
                this.ButtonInterlock(true);
                Bitmap bitmapImg = this.tmpDataNum[this.curNum - 1].tmpData[this.tmpDataNum[this.curNum - 1].refScaleID, this.tmpDataNum[this.curNum - 1].refAngleID].image.ToBitmap();
                this.refModelObjNum[this.curNum - 1] = new RefModel("", null, 0, 0L, 0.0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.0, 0.0, 0.0, 0.0, 0.0, 0, 0, init_rect, true, true, 0, 0, 0, 0, 0f, 0f, true, "", false, false, 0, 0, null, 0.0, 0, false, false, "", "");
                this.refModelObjNum[this.curNum - 1] = this.SaveRefModel(this.curNum - 1, this.comboBox1.Text, bitmapImg);
                this.tmpDataNum[this.curNum - 1] = new TEMPLATE_DATA_NUM();
                this.DispRefModelData(this.curNum - 1);
                this.CheckPresetData();
                this.button7.ForeColor = Color.Red;
                if ((this.dstdifimg != null) && !this.timer1.Enabled)
                {
                    this.stat = 0x67;
                    this.timer1.Enabled = true;
                }
                else
                {
                    this.ButtonInterlock(false);
                    if (Cursor.Current != Cursors.Default)
                    {
                        Cursor.Current = Cursors.Default;
                    }
                }
            }

        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (!this.VerifyPresetData(1))
            {
                this.button26.Text = this.LoadPreset(1);
                this.button26.ForeColor = Color.Red;
                this.button27.ForeColor = Color.Black;
                this.button28.ForeColor = Color.Black;
                this.button29.ForeColor = Color.Black;
                if ((this.dstdifimg != null) && !this.timer1.Enabled)
                {
                    this.stat = 0x67;
                    this.timer1.Enabled = true;
                }
            }

        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (!this.VerifyPresetData(3))
            {
                this.button28.Text = this.LoadPreset(3);
                this.button26.ForeColor = Color.Black;
                this.button27.ForeColor = Color.Black;
                this.button28.ForeColor = Color.Red;
                this.button29.ForeColor = Color.Black;
                if ((this.dstdifimg != null) && !this.timer1.Enabled)
                {
                    this.stat = 0x67;
                    this.timer1.Enabled = true;
                }
            }

        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (!this.VerifyPresetData(4))
            {
                this.button29.Text = this.LoadPreset(4);
                this.button26.ForeColor = Color.Black;
                this.button27.ForeColor = Color.Black;
                this.button28.ForeColor = Color.Black;
                this.button29.ForeColor = Color.Red;
                if ((this.dstdifimg != null) && !this.timer1.Enabled)
                {
                    this.stat = 0x67;
                    this.timer1.Enabled = true;
                }
            }

        }

        private void trackBar9_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown21.Value = this.trackBar9.Value;
            if (((this.dstdifimg != null) && !this.timer1.Enabled) && (this.trackBar9.Focused || this.numericUpDown21.Focused))
            {
                this.stat = 0x67;
                this.timer1.Enabled = true;
            }
            else if (this.radioButton7.Checked)
            {
                this.SelectAreaTeachRealTimeView();
            }


        }

        private void trackBar6_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown7.Value = this.trackBar6.Value;
            if (((this.dstdifimg != null) && !this.timer1.Enabled) && (this.trackBar6.Focused || this.numericUpDown7.Focused))
            {
                this.stat = 0x67;
                this.timer1.Enabled = true;
            }

        }

        private void trackBar7_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown8.Value = this.trackBar7.Value;
            if (((this.dstdifimg != null) && !this.timer1.Enabled) && (this.trackBar7.Focused || this.numericUpDown8.Focused))
            {
                this.stat = 0x67;
                this.timer1.Enabled = true;
            }


        }

        private void trackBar5_ValueChanged(object sender, EventArgs e)
        {
            int num1 = this.trackBar5.Value;
            this.numericUpDown9.Value = this.trackBar5.Value;

        }

        private void trackBar8_ValueChanged(object sender, EventArgs e)
        {
            double num = this.trackBar8.Value * 0.01;
            this.numericUpDown10.Value = (decimal)Math.Round(num, 2);

        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.ClearClick();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear all data", "AAC-1000", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel)
            {
                this.DataClear();
                //this.label92.Text = "";
                //this.label94.Text = "";
                //if (this.autoCsvSave)
                //{
                //    if (this.richTextBoxBuffer.Length > 3)
                //    {
                //        string path = this.csvPath + this.dtNow.ToString("yyyyMMddHHmmss") + ".csv";
                //        this.richTextBox1.Text = this.richTextBoxBuffer;
                //        this.richTextBox1.SaveFile(path, RichTextBoxStreamType.PlainText);
                //    }
                //    OldFileSearchDel(this.csvPath, "*.csv", this.maxCsvFile);
                //}
                //this.csvFileCnt = 0;
                //this.richTextBox1.Text = "";
                //this.richTextBoxBuffer = "";
            }

        }

        private void numericUpDown28_ValueChanged(object sender, EventArgs e)
        {
            if (this.trackBar10.Value != ((int)this.numericUpDown28.Value))
            {
                this.trackBar10.Value = (int)this.numericUpDown28.Value;
            }

        }

        //private void button22_Click(object sender, EventArgs e)
        //{
        //    if (this.panel2.Width == (this.button22.Width + this.button22.Location.X))
        //    {
        //        this.DbPictureBoxView(true);
        //    }
        //    else
        //    {
        //        this.DbPictureBoxView(false);
        //    }

        //}

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                int num = int.Parse(this.listView1.SelectedItems[0].Text) - 1;
                if (!this.listView1.Focused || (this.listView1.Focused && (this.curNum != (num + 1))))
                {
                    this.listView1.EnsureVisible(this.listView1.SelectedItems[0].Index);
                    this.curNum = num + 1;
                    this.DispRefModelData(num);
                    this.CheckTempSelectButton();
                    this.CheckPresetData();
                    if (!this.mouseLBDownFlg)
                    {
                        this.DispSelectRectAngle(num);
                    }
                    this.DispSelectItem(num);
                    this.pictureBox1.Refresh();
                }
            }

        }

        private void trackBar10_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown28.Value = this.trackBar10.Value;

        }

        private void EditModeCancell()
        {
            this.DispRefModelData(this.curNum - 1);
            this.CheckTempSelectButton();
            this.CheckPresetData();
            this.button3.Enabled = false;
            this.s_rect = new Rectangle(0, 0, 0, 0);
            this.r_rect = new Rectangle(0, 0, 0, 0);
            s_rectList[this.tempNum] = new Rectangle(0, 0, 0, 0);
            r_rectList[this.tempNum] = new Rectangle(0, 0, 0, 0);
            if (((this.tempNum > 0) && !this.button14.Enabled) && this.teachFlg)
            {
                this.button14.Enabled = true;
            }
            this.curEdit = false;
            if (this.teachFlg)
            {
                this.buttonteaching.Enabled = true;
            }
            this.label74.Text = "";
            this.label74.ForeColor = Color.WhiteSmoke;
            this.setFlg = true;
            this.button7.ForeColor = Color.Red;
            this.button7.Enabled = true;
            if (this.tempNum > 0)
            {
                this.button17.Enabled = true;
            }
            this.pictureBox1.Image = this.pictureBox1.Image;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (this.teachFlg && (this.curNum > 0))
            {
                if (this.areaSelect)
                {
                    if (this.curEdit)
                    {
                        this.EditModeCancell();
                    }
                    else
                    {
                        this.s_rect = s_rectList[this.curNum - 1];
                        this.DispRefModelData(this.curNum - 1);
                        this.CheckTempSelectButton();
                        this.CheckPresetData();
                        this.curEdit = true;
                        this.button3.Enabled = true;
                        this.buttonteaching.Enabled = false;
                        this.button7.Enabled = false;
                        this.button17.Enabled = false;
                        this.label74.Text = "PLEASE CLICK THE“SET”TO EXIT THE EDIT MODE.";
                        this.label74.ForeColor = Color.Yellow;
                    }
                }
                ((Control)sender).Invalidate();
            }

        }
        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            double delta = e.Delta;
            if ((this.srcImg != null) && (this.pictureBox1.Image != null))
            {
                this.srcScale -= (delta / 120.0) * (this.srcScale / 10.0);
                if (this.srcScale > this.mouseWheelMax)
                {
                    this.srcScale = this.mouseWheelMax;
                }
                else if (this.srcScale <= this.mouseWheelMin)
                {
                    this.srcScale = this.mouseWheelMin;
                }
                this.ScreenScaleChange(this.srcScale, this.mousPosition);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.button1.ForeColor == Color.Red)
            {
                button1_Click(null, null);
            }
            if (this.comok)
            {
                this.ComControl.Write("R");
            }
            //       if (MessageBox.Show("Exit application?", "", MessageBoxButtons.YesNo) ==
            //DialogResult.Yes)
            //       {
            //           Application.Exit();
            //       }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (this.srcImg != null)
            {
                double srcScale = this.srcScale;
                this.srcScale *= 0.7;
                if (this.srcScale > this.mouseWheelMax)
                {
                    this.srcScale = this.mouseWheelMax;
                }
                else if (this.srcScale < this.mouseWheelMin)
                {
                    this.srcScale = this.mouseWheelMin;
                }
                if (srcScale != this.srcScale)
                {
                    this.ScreenScaleChange(this.srcScale, this.clickPoint);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.srcImg != null)
            {
                double srcScale = this.srcScale;
                this.srcScale *= 1.4;
                if (this.srcScale > this.mouseWheelMax)
                {
                    this.srcScale = this.mouseWheelMax;
                }
                else if (this.srcScale < this.mouseWheelMin)
                {
                    this.srcScale = this.mouseWheelMin;
                }
                if (srcScale != this.srcScale)
                {
                    this.ScreenScaleChange(this.srcScale, this.clickPoint);
                }
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.ForeColor != Color.Red)
            {
                groupBox1.Visible = true;
                button6.ForeColor = Color.Red;
            }
            else
            {
                groupBox1.Visible = false;
                button6.ForeColor = Color.Black;
            }
        }

        //private void ComControl_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        //{
        //    indata = ComControl.ReadExisting();
        //    indata.TrimEnd().TrimStart();
        //    if (indata.Length >= 1)
        //    {
        //        //MessageBox.Show(indata);       // show232(indata);
        //        if (indata.Contains("C") == true)
        //        { button4_Click(null, null); }
        //        indata = null;
        //     }
        //}
        //public void show232(string data232)
        //{

        //    data232.TrimEnd().TrimStart();

        //    if(this.camok)
        //    {
        //        if (data232.Length >= 5)
        //        {
        //            if (data232.Contains("C") == true)
        //            {
        //                if (this.button2.Enabled)
        //                {
        //                    //this.stepcheck = 0;

        //                  //  this.MeasurementClick();
        //                }
        //                this.indata = "";
        //                //ComControl.DiscardInBuffer();
        //               // ComControl.DiscardOutBuffer();
        //            }
        //            else
        //            {
        //                this.indata = "";
        //                ComControl.DiscardInBuffer();
        //                ComControl.DiscardOutBuffer();
        //            }
        //            //else if (data232=="reset")
        //            //{

        //            //}
        //        }
        //    }
        //}



        private void timer3_Tick(object sender, EventArgs e)
        {

            string indata = "";


            indata = ComControl.ReadExisting();
            if (indata.Contains("C") == true)

            {
                this.timer3.Enabled = false;
                //MessageBox.Show(indata);
                this.MeasurementClick();
            }
            //indata.TrimEnd().TrimStart();
            //    if (indata.Length >= 1)
            //{
            //    if (indata.Contains("C") == true)
            //        { 
            //    }
            //        indata = null;


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.measureFlg)
            {
                this.Timercam++;
                if (this.Timercam > 6)
                {
                    this.Timercam = 0;
                    this.timer2.Enabled = false;
                    this.capture = false;
                    this.timer1.Enabled = false;
                    this.button1.ForeColor = Color.Black;
                    this.button1.Text = "Camera";

                    this.CurrentDataClear();
                    this.srcImg = img;

                    this.curImagePath = Path.GetDirectoryName(this.srcFn);
                    this.srcImgHeight = this.srcImg.Height;
                    this.srcImgWidth = this.srcImg.Width;
                    this.drawRect = new CvRect(0, 0, this.srcImgWidth, this.srcImgHeight);
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    this.pictureBox1.Image = this.srcImg.ToBitmap();
                    this.dstImg = Cv.CloneImage(this.srcImg);
                    this.stat = 80;
                    this.timer1.Interval = 15;
                    this.timer1.Enabled = true;

                    //this.label1.Text = string.Concat(new object[] { "IMAGE FILE : ", this.srcImg.Width, " x ", this.srcImg.Height });
                    //this.ButtonInterlock(false);
                    if (Cursor.Current != Cursors.Default)
                    {
                        Cursor.Current = Cursors.Default;
                    }

                    _cameraThread.Abort();
                    if (this.srcImg != null)
                    {
                        this.dstImg = Cv.CloneImage(this.srcImg);
                        if ((this.dstImg != null) && (this.pictureBox1.Image != null))
                        {
                            this.buttonteaching.Enabled = true;
                        }
                    }
                    if ((this.srcImg == null) || (this.dstImg == null))
                    {
                        this.dstImg = null;
                    }
                    else if ((this.tempNum > 0) && (this.usbCam || this.gigeCam || this.camok))
                    {
                        this.button1.Enabled = true;
                    }
                    else
                    {
                        this.button1.Enabled = false;
                    }
                    this.capture = false;
                    if (!this.measureFlg)
                    {

                        this.button1.Enabled = true;
                    }

                }
            }
        }
    }
    class USBDeviceInfo
    {
        public USBDeviceInfo(string deviceID, string pnpDeviceID, string description, string nameusb)
        {
            this.DeviceID = deviceID;
            this.PnpDeviceID = pnpDeviceID;
            this.Description = description;
            this.Name = nameusb;
        }
        public string DeviceID { get; private set; }
        public string PnpDeviceID { get; private set; }
        public string Description { get; private set; }
        public string Name { get; private set; }
    }
}

