using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    class HoverButton : Button
    {
        protected Color color = Color.SkyBlue;

        protected StringFormat strType;

        public HoverButton() : base()
        {
            ForeColor = Color.White;
            Font = new Font("Arial",
                60.25f,
                FontStyle.Bold,
                GraphicsUnit.Point,
                0);
        }

    }
}
