using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSV_stuff
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
            ScreenWidth.Value = 1920;
            ScreenHeight.Value = 1080;
            CapWidth.Value = 800;
            CapHeight.Value = 450;
            H_MAX.Value = 255;
            S_MAX.Value = 255;
            V_MAX.Value = 255;
            morphAmount.Value = 3;
        }

        private bool running = false;
        private int width;
        private int height;
        private int w;
        private int h;
        private Thread pic_get;
        private Bitmap bmp;
        private ScreenCap getBMP = new ScreenCap();
        private HSV scan = new HSV();

        private object lockObject = new object();

        private void func()
        {
            width = Convert.ToInt32(ScreenWidth.Value);
            height = Convert.ToInt32(ScreenHeight.Value);
            w = Convert.ToInt32(CapWidth.Value);
            h = Convert.ToInt32(CapHeight.Value);
            while (true)
            {
                bmp = getBMP.CaptureImage(width, height, w, h);
                Bitmap hsv = (Bitmap)bmp.Clone();
                pictureBox1.Image = scan.modify(hsv, (int)H_MIN.Value, (int)H_MAX.Value, (int)S_MIN.Value, (int)S_MAX.Value, (int)V_MIN.Value, (int)V_MAX.Value, range.Checked, morph.Checked, (int)morphAmount.Value);
                Thread.Sleep(16);
            }
        }

        private void modify_Click(object sender, EventArgs e)
        {
            if (running)
            {
                pic_get.Abort();
            }
            running = !running;
        }

        private void getImage_Click_1(object sender, EventArgs e)
        {
            if (!running)
            {
                pic_get = new Thread(func);
                pic_get.Start();
            }
            running = !running;
        }

        private void GUI_FormClosing(object sender, EventArgs e)
        {
            if (running)
            {
                pic_get.Abort();
            }
        }
    }
}
