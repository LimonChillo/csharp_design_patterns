/*
    David Kranewitter
    Simon Hintersonnleitner
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net;

namespace _04b_Proxy
{
    class RealImage : AbstractImage
    {
        public string url;

        public RealImage(string url)
        {
            this.url = url;
        }

        public override Image getImage()
        {
            WebRequest requestPic = WebRequest.Create(url);
            WebResponse responsePic = requestPic.GetResponse();
            return Image.FromStream(responsePic.GetResponseStream());
        }
    }
}
