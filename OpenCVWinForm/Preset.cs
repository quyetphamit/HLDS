using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCVWinForm
{
    public class Preset
    {
        // Fields
        private int _averageCount;
        private int _binaryAllThreshold;
        private int _binaryBlueThreshold;
        private int _binaryGreenThreshold;
        private int _binaryRedThreshold;
        private int _blobMaxAreaThreshold;
        private int _blobMinAreaThreshold;
        private float _contrastCoef;
        private int _diffNG_UnderOver;
        private int _diffThreshold;
        private int _dilaNum;
        private int _erodNum;
        private bool _inspectEnabled;
        private int _matchRateNG_UnderOver;
        private double _matchRateThreshold;
        private string _name;
        private int _ptmBinaryThreshold;
        private int _ptmSearchMode;
        private double _searchAngleRange;
        private double _searchAngleStep;
        private int _searchPositionRangeX;
        private int _searchPositionRangeY;
        private double _searchScaleMax;
        private double _searchScaleMin;
        private double _searchScaleStep;
        private int _smoothParam1;
        private int _smoothParam2;
        private int _smoothParam3;
        private int _smoothParam4;
        private float _unsharpMask;
        private int _version;

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

        public int diffNG_UnderOver
        {
            get
            {
                return this._diffNG_UnderOver;
            }
            set
            {
                this._diffNG_UnderOver = value;
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

        public int dilaNum
        {
            get
            {
                return this._dilaNum;
            }
            set
            {
                this._dilaNum = value;
            }
        }

        public int erodNum
        {
            get
            {
                return this._erodNum;
            }
            set
            {
                this._erodNum = value;
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

        public int matchRateNG_UnderOver
        {
            get
            {
                return this._matchRateNG_UnderOver;
            }
            set
            {
                this._matchRateNG_UnderOver = value;
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

        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public int ptmBinaryThreshold
        {
            get
            {
                return this._ptmBinaryThreshold;
            }
            set
            {
                this._ptmBinaryThreshold = value;
            }
        }

        public int ptmSearchMode
        {
            get
            {
                return this._ptmSearchMode;
            }
            set
            {
                this._ptmSearchMode = value;
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

        public int smoothParam1
        {
            get
            {
                return this._smoothParam1;
            }
            set
            {
                this._smoothParam1 = value;
            }
        }

        public int smoothParam2
        {
            get
            {
                return this._smoothParam2;
            }
            set
            {
                this._smoothParam2 = value;
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

 


 

}
