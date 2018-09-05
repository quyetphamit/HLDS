using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
namespace OpenCVWinForm
{
   public class ReadCsvFile
    {
        
        public static int CounterlineTextFile(string File_Path)
        {
            // nhap duong dan file va dong can doc
            int counterLine = 0;
            // xac nhan duong dan ton tai hay khong
            if (System.IO.File.Exists(File_Path) == true)
            {
                System.IO.StreamReader objReader = new System.IO.StreamReader(File_Path);
                // mo file theo duong dan
                while ((objReader.ReadLine()) != null)
                {
                    counterLine = counterLine + 1;
                    // doc theo tung dong file text
                }
                objReader.Close();
                // dong file text da mo
            }
            else
            {
                MessageBox.Show("File: " + File_Path + " not found", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return counterLine;
        }
        public static string ReadTextFile(string filePath, int lineNumber)
        {
            // nhap duong dan file va dong can doc
            using (StreamReader file = new StreamReader(filePath))
            {
                string line = null;
                // doc nhung Line trong text file khong can truy nhap'
                for (int i = 1; i <= lineNumber - 1; i++)
                {
                    if (file.ReadLine() == null)
                    {
                        line = " ";
                    }
                }
                //doc Line trong text file can truy nhap
                line = file.ReadLine();
                // Succeded!
                file.Close();
                return line;
            }
        }
        struct Refmodelcsv
        {
            public int _averageCountcsv;
            public int _binaryAllThresholdcsv;
            public int _binaryBlueThresholdcsv;
            public int _binaryGreenThresholdcsv;
            public int _binaryRedThresholdcsv;
            public int _blobMaxAreaThresholdcsv;
            public int _blobMinAreaThresholdcsv;
            public string _checkPointNamecsv;
            public float _contrastCoefcsv;
            public string _diffNG_Thresholdcsv;
            public int _diffThresholdcsv;
            public int _dilaNumThresholdcsv;
            public int _erodNumThresholdcsv;
            public int _imageHeightcsv;
            public int _imageWidthcsv;
            public bool _inspectEnabledcsv;
            public double _matchRateThresholdcsv;
            public string _matcNG_Thresholdcsv;
            public int _maxPointcsv;
            public int _modecsv;
            public Bitmap _modelImgcsv;
            public string _moodelNamecsv;
            public int _numbercsv;
            public int _positionXcsv;
            public int _positionYcsv;
            public int _ptMatchBinaryThresholdcsv;
          //  public Rectangle _r_rectcsv;
            public bool _reverseXcsv;
            public bool _reverseYcsv;
            public bool _rotation270csv;
            public bool _rotation90csv;
            public double _searchAngleRangecsv;
            public double _searchAngleStepcsv;
            public int _searchPositionRangeXcsv;
            public int _searchPositionRangeYcsv;
            public double _searchScaleMaxcsv;
            public double _searchScaleMincsv;
            public double _searchScaleStepcsv;
            public int _smoothParamcsv;
            public int _smoothParamcsv3;
            public int _smoothParamcsv4;
            public double _svAreacsv;
            //public Point _svDstPnt = new Point[4];
            public bool _thresholdColorModecsv;
            public bool _thresholdManualModecsv;
            public float _unsharpMaskcsv;
            public long _whitePixelThresholdcsv;

        };
    }
}
