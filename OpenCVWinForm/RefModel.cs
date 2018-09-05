using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
//using static System.Object;
namespace OpenCVWinForm
{
    public class RefModel
    {
        // Fields
        private int _averageCount;
        private int _binaryAllThreshold;
        private int _binaryBlueThreshold;
        private int _binaryGreenThreshold;
        private int _binaryRedThreshold;
        private int _blobMaxAreaThreshold;
        private int _blobMinAreaThreshold;
        private string _checkPointName;
        private float _contrastCoef;
        private string _diffNG_Threshold;
        private int _diffThreshold;
        private int _dilaNumThreshold;
        private int _erodNumThreshold;
        private int _imageHeight;
        private int _imageWidth;
        private bool _inspectEnabled;
        private double _matchRateThreshold;
        private string _matcNG_Threshold;
        private int _maxPoint;
        private int _mode;
        private Bitmap _modelImg;
        private string _moodelName;
        private int _number;
        private int _positionX;
        private int _positionY;
        private int _ptMatchBinaryThreshold;
        private Rectangle _r_rect;
        private bool _reverseX;
        private bool _reverseY;
        private bool _rotation270;
        private bool _rotation90;
        private double _searchAngleRange;
        private double _searchAngleStep;
        private int _searchPositionRangeX;
        private int _searchPositionRangeY;
        private double _searchScaleMax;
        private double _searchScaleMin;
        private double _searchScaleStep;
        private int _smoothParam;
        private int _smoothParam3;
        private int _smoothParam4;
        private double _svArea;
        private Point[] _svDstPnt = new Point[4];
        private bool _thresholdColorMode;
        private bool _thresholdManualMode;
        private float _unsharpMask;
        private long _whitePixelThreshold;

        // Methods
        public RefModel(string str, Bitmap image, int diffthr, long whtpix, double mcr, int ball, int bred, int bgreen, int bblue, int blobmin, int blobmax, int erod, int dila, int number, int positionX, int positionY, int searchPositionRangeX, int searchPositionRangeY, double searchAngleRange, double searchAngleStep, double searchScaleMin, double searchScaleMax, double searchScaleStep, int mode, int maxPoint, Rectangle r_rect, bool thresholdColorMode, bool thresholdManualMode, int averageCount, int smoothParam, int smoothParam3, int smoothParam4, float unsharpMask, float contrastCoef, bool inspectEnabled, string checkPointName, bool reverseX, bool reverseY, int imageWidth, int imageHeight, Point[] svDstPnt, double svArea, int ptMatchBinaryThreshold, bool rotation90, bool rotation270, string matcNG_Threshold, string diffNG_Threshold)
        {
            this._moodelName = str;
            this._modelImg = image;
            this._diffThreshold = diffthr;
            this._whitePixelThreshold = whtpix;
            this._matchRateThreshold = mcr;
            this._binaryAllThreshold = ball;
            this._binaryRedThreshold = bred;
            this._binaryGreenThreshold = bgreen;
            this._binaryBlueThreshold = bblue;
            this._blobMinAreaThreshold = blobmin;
            this._blobMaxAreaThreshold = blobmax;
            this._erodNumThreshold = erod;
            this._dilaNumThreshold = dila;
            this._number = number;
            this._positionX = positionX;
            this._positionY = positionY;
            this._searchPositionRangeX = searchPositionRangeX;
            this._searchPositionRangeY = searchPositionRangeY;
            this._searchAngleRange = searchAngleRange;
            this._searchAngleStep = searchAngleStep;
            this._searchScaleMin = searchScaleMin;
            this._searchScaleMax = searchScaleMax;
            this._searchScaleStep = searchScaleStep;
            this._mode = mode;
            this._maxPoint = maxPoint;
            this._r_rect = r_rect;
            this._thresholdColorMode = thresholdColorMode;
            this._thresholdManualMode = thresholdManualMode;
            this._averageCount = averageCount;
            this._smoothParam = smoothParam;
            this._smoothParam3 = smoothParam3;
            this._smoothParam4 = smoothParam4;
            this._unsharpMask = unsharpMask;
            this._contrastCoef = contrastCoef;
            this._inspectEnabled = inspectEnabled;
            this._checkPointName = checkPointName;
            this._reverseX = reverseX;
            this._reverseY = reverseY;
            this._imageWidth = imageWidth;
            this._imageHeight = imageHeight;
            this._svDstPnt = svDstPnt;
            this._svArea = svArea;
            this._ptMatchBinaryThreshold = ptMatchBinaryThreshold;
            this._rotation90 = rotation90;
            this._rotation270 = rotation270;
            this._matcNG_Threshold = matcNG_Threshold;
            this._diffNG_Threshold = diffNG_Threshold;
        }

        // Properties
        public int averageCount
        {
            get
            {
                return this._averageCount;
            }
            set
            {
                this._averageCount = value;
            }
        }

        public int binaryAllThreshold
        {
            get
            {
                return this._binaryAllThreshold;
            }
            set
            {
                this._binaryAllThreshold = value;
            }
        }

        public int binaryBlueThreshold
        {
            get
            {
                return this._binaryBlueThreshold;
            }
            set
            {
                this._binaryBlueThreshold = value;
            }
        }

        public int binaryGreenThreshold
        {
            get
            {
                return this._binaryGreenThreshold;
            }
            set
            {
                this._binaryGreenThreshold = value;
            }
        }

        public int binaryRedThreshold
        {
            get
            {
                return this._binaryRedThreshold;
            }
            set
            {
                this._binaryRedThreshold = value;
            }
        }

        public int blobMaxAreaThreshold
        {
            get
            {
                return this._blobMaxAreaThreshold;
            }
            set
            {
                this._blobMaxAreaThreshold = value;
            }
        }

        public int blobMinAreaThreshold
        {
            get
            {
                return this._blobMinAreaThreshold;
            }
            set
            {
                this._blobMinAreaThreshold = value;
            }
        }

        public string checkPointName
        {
            get
            {
                return this._checkPointName;
            }
            set
            {
                this._checkPointName = value;
            }
        }

        public float contrastCoef
        {
            get
            {
                return this._contrastCoef;
            }
            set
            {
                this._contrastCoef = value;
            }
        }

        public string diffNG_Threshold
        {
            get
            {
                return this._diffNG_Threshold;
            }
            set
            {
                this._diffNG_Threshold = value;
            }
        }

        public int diffThreshold
        {
            get
            {
                return this._diffThreshold;
            }
            set
            {
                this._diffThreshold = value;
            }
        }

        public int dilaNumThreshold
        {
            get
            {
                return this._dilaNumThreshold;
            }
            set
            {
                this._dilaNumThreshold = value;
            }
        }

        public int erodNumThreshold
        {
            get
            {
                return this._erodNumThreshold;
            }
            set
            {
                this._erodNumThreshold = value;
            }
        }

        public int imageHeight
        {
            get
            {
                return this._imageHeight;
            }
            set
            {
                this._imageHeight = value;
            }
        }

        public int imageWidth
        {
            get
            {
                return this._imageWidth;
            }
            set
            {
                this._imageWidth = value;
            }
        }

        public bool inspectEnabled
        {
            get
            {
                return this._inspectEnabled;
            }
            set
            {
                this._inspectEnabled = value;
            }
        }

        public double matchRateThreshold
        {
            get
            {
                return this._matchRateThreshold;
            }
            set
            {
                this._matchRateThreshold = value;
            }
        }

        public string matcNG_Threshold
        {
            get
            {
                return this._matcNG_Threshold;
            }
            set
            {
                this._matcNG_Threshold = value;
            }
        }

        public int maxPoint
        {
            get
            {
                return this._maxPoint;
            }
            set
            {
                this._maxPoint = value;
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

        public Bitmap modelImg
        {
            get
            {
                return this._modelImg;
            }
            set
            {
                this._modelImg = value;
            }
        }

        public string moodelName
        {
            get
            {
                return this._moodelName;
            }
            set
            {
                this._moodelName = value;
            }
        }

        public int number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }

        public int positionX
        {
            get
            {
                return this._positionX;
            }
            set
            {
                this._positionX = value;
            }
        }

        public int positionY
        {
            get
            {
                return this._positionY;
            }
            set
            {
                this._positionY = value;
            }
        }

        public int ptMatchBinaryThreshold
        {
            get
            {
                return this._ptMatchBinaryThreshold;
            }
            set
            {
                this._ptMatchBinaryThreshold = value;
            }
        }

        public Rectangle r_rect
        {
            get
            {
                return this._r_rect;
            }
            set
            {
                this._r_rect = value;
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

        public double searchAngleRange
        {
            get
            {
                return this._searchAngleRange;
            }
            set
            {
                this._searchAngleRange = value;
            }
        }

        public double searchAngleStep
        {
            get
            {
                return this._searchAngleStep;
            }
            set
            {
                this._searchAngleStep = value;
            }
        }

        public int searchPositionRangeX
        {
            get
            {
                return this._searchPositionRangeX;
            }
            set
            {
                this._searchPositionRangeX = value;
            }
        }

        public int searchPositionRangeY
        {
            get
            {
                return this._searchPositionRangeY;
            }
            set
            {
                this._searchPositionRangeY = value;
            }
        }

        public double searchScaleMax
        {
            get
            {
                return this._searchScaleMax;
            }
            set
            {
                this._searchScaleMax = value;
            }
        }

        public double searchScaleMin
        {
            get
            {
                return this._searchScaleMin;
            }
            set
            {
                this._searchScaleMin = value;
            }
        }

        public double searchScaleStep
        {
            get
            {
                return this._searchScaleStep;
            }
            set
            {
                this._searchScaleStep = value;
            }
        }

        public int smoothParam
        {
            get
            {
                return this._smoothParam;
            }
            set
            {
                this._smoothParam = value;
            }
        }

        public int smoothParam3
        {
            get
            {
                return this._smoothParam3;
            }
            set
            {
                this._smoothParam3 = value;
            }
        }

        public int smoothParam4
        {
            get
            {
                return this._smoothParam4;
            }
            set
            {
                this._smoothParam4 = value;
            }
        }

        public double svArea
        {
            get
            {
                return this._svArea;
            }
            set
            {
                this._svArea = value;
            }
        }

        public Point[] svDstPnt
        {
            get
            {
                return this._svDstPnt;
            }
            set
            {
                this._svDstPnt = value;
            }
        }

        public bool thresholdColorMode
        {
            get
            {
                return this._thresholdColorMode;
            }
            set
            {
                this._thresholdColorMode = value;
            }
        }

        public bool thresholdManualMode
        {
            get
            {
                return this._thresholdManualMode;
            }
            set
            {
                this._thresholdManualMode = value;
            }
        }

        public float unsharpMask
        {
            get
            {
                return this._unsharpMask;
            }
            set
            {
                this._unsharpMask = value;
            }
        }

        public long whitePixelThreshold
        {
            get
            {
                return this._whitePixelThreshold;
            }
            set
            {
                this._whitePixelThreshold = value;
            }
        }


    }


}
