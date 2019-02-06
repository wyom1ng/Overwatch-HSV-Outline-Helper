using System.Drawing;

namespace HSV_stuff
{
    class ScreenCap
    {
        public Bitmap CaptureImage(int width1, int height1, int w, int h)
        {
            width1 = (width1 / 2) - (w / 2);
            height1 = (height1 / 2) - (h / 2);
            Bitmap bm = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(bm);
            g.CopyFromScreen(width1, height1, 0, 0, bm.Size);
            return bm;
        }
    }
}
