﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _04b_Proxy
{
    abstract class AbstractImage
    {
       protected Image img;  

        public virtual Image getImage()
        {
            return img;
        }
    }
}
