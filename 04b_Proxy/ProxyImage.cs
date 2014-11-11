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
        PictureBox pb;
        string url;

        public ProxyImage(PictureBox pb, string url, RealImage ri)
        {
            this.pb = pb;
            this.url = url;
            this.ri = ri;
        }

        public Image getImage()
        {
            bgw = new BackgroundWorker();
            bgw.WorkerReportsProgress = true;
            bgw.DoWork += new DoWorkEventHandler(doSomething);
            bgw.RunWorkerAsync();

            return loadLocalImage(url); 
        }


        private Image loadLocalImage(String fileName)
        {
            return Image.FromFile(fileName);
        }


        private void doSomething(object sender, DoWorkEventArgs e)
        {
            pb.Image = ri.getImage();
            bgw.ReportProgress(100);
        }

     
      
        
    }
}
