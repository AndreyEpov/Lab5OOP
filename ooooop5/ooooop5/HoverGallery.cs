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
    class HoverGallery:HoverButton
    {
        private int i = 0;
      
        public List<MyImage> Im = new List<MyImage>();
        public HoverGallery() : base()
        {
            Im.Add(new MyImage(new Bitmap(Properties.Resources.kust), "Не нажимай"));
            Im.Add(new MyImage(new Bitmap(Properties.Resources.kot), "Ну просил же"));

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.DrawImage(Im[i].bitmap, 0, 0);
            strType = new StringFormat();
            strType.Alignment = StringAlignment.Center;
            strType.LineAlignment = StringAlignment.Center;
            pe.Graphics.DrawString(Im[i].text, Font, new SolidBrush(ForeColor), ClientRectangle, strType);

        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Im[i].text = Im[i].showText;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Im[i].text = "";
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddRectangle(new Rectangle(0, 0, Width, Height));
            Region = new Region(graphicsPath);
            
        }

       

        protected override void OnMouseClick(MouseEventArgs e)
        {
            i++;

            if (i > Im.Count - 1)
                i = 0;
        }
    }
}
