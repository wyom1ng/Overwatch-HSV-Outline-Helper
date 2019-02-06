using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace HSV_stuff
{
    internal class HSV
    {

        //initial min and max HSV filter values.
        private const int H_MIN = 132;
        private const int H_MAX = 162;
        private const int S_MIN = 85;
        private const int S_MAX = 229;
        private const int V_MIN = 122;
        private const int V_MAX = 255;

        
        

        private Mat morphOps(Mat thresh, int x)
        {

            //create structuring element that will be used to "dilate"
            Mat erodeElement = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(1, 1));
            Mat dilateElement = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(x, x));
            Cv2.Erode(thresh, thresh, erodeElement);
            Cv2.Dilate(thresh, thresh, dilateElement);
            Cv2.Dilate(thresh, thresh, dilateElement);
            Cv2.Erode(thresh, thresh, dilateElement);
            Cv2.Erode(thresh, thresh, dilateElement);

            return thresh;
        }

       
        public Bitmap modify(Bitmap frame, int hMin, int hMax, int sMin, int sMax, int vMin, int vMax, bool range, bool morph, int x)
        {
            Scalar lowerb = new Scalar(hMin, sMin, vMin);
            Scalar upperb = new Scalar(hMax, sMax, vMax);

            Mat mat = OpenCvSharp.Extensions.BitmapConverter.ToMat(frame);

            Cv2.CvtColor(mat, mat, ColorConversionCodes.BGR2HSV);
            if(range)
            Cv2.InRange(mat, lowerb, upperb, mat);

            if (morph)
            mat = morphOps(mat, x);
            frame = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat);
            mat.Dispose();
            return frame;
        }
    }
}
