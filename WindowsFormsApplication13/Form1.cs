using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.ML;
using Emgu.CV.Util;
using System.Diagnostics;


namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> image = new Image<Bgr, byte>(320, 240, new Bgr(0, 0, 255));//创建一张320*240尺寸颜色为红色的图像。
            imageBox1.Image = image;//在ImageBox1控件中显示所创建好的图像。

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(Environment.CurrentDirectory.ToString());
             Mat imgscr = CvInvoke.Imread(Environment.CurrentDirectory+"\\1.jpg");//读取图像
            // CvInvoke.Imshow("img", imgscr);//显示图像
              imageBox2.Image = imgscr;//在ImageBox2控件中显示所创建好的图像。
             CvInvoke.WaitKey(0);//按键等待
            
        }

        

       
    }
}
