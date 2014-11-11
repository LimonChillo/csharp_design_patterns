using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace _04b_Proxy
{
    public partial class Form1 : Form
    {
        public readonly BackgroundWorker bgw;
        MyPictureBox pb = new MyPictureBox();
        
        public Form1()
        {
            InitializeComponent();
          
            pb.Size = new Size(800, 600);
            Controls.Add(pb);
            RealImage ri = new RealImage("http://student.cosy.sbg.ac.at/~anaderli/fh/Koala.jpg");
            ProxyImage pi = new ProxyImage(pb, "WAITING.jpg",ri);
            pb.Image = pi.getImage();

        }


    }
}
