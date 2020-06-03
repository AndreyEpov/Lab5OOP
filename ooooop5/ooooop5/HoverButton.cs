using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooooop5
{
    class HoverButton: Button
    {

        protected Color color = Color.SkyBlue;
        protected StringFormat strType;
        public HoverButton() : base()
        {
            ForeColor = Color.White;
            Font = new Font("Arial",
             20.25F,
             FontStyle.Bold,
             GraphicsUnit.Point,
             0);
        }
       

    }
}
