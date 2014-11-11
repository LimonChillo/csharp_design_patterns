/*
    David Kranewitter
    Simon Hintersonnleitner
*/

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
    class ProxyImage : AbstractImage
    {
        RealImage ri;
        BackgroundWorker bgw;
       
        public ProxyImage( RealImage ri)
        {
            this.ri = ri;
        }

        public override Image getImage()
        {
            bgw = new BackgroundWorker();
            bgw.WorkerReportsProgress = true;
            bgw.DoWork += new DoWorkEventHandler(replaceImage);
            bgw.RunWorkerAsync();

            return loadLocalImage(); 
        }

        private Image loadLocalImage()
        {
            return Image.FromFile("WAITING.jpg");
        }

        private void replaceImage(object sender, DoWorkEventArgs e)
        {
            Form1.pb.Image = ri.getImage();
            bgw.ReportProgress(100);
        }
  
    }
}
