using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Life
{
    class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel()
            : base()
        {
            DoubleBuffered = true;
        }
    }
}
