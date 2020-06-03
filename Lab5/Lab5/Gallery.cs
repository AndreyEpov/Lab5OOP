using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    class Gallery : HoverButton
    {
        private int i = 0;

        private bool flag = false;
        public List <PicImage> pic = new List<PicImage>();
        GraphicsPath graphicsPath = new GraphicsPath();

        public Gallery() : base()
        {
           pic.Add(new PicImage(new Bitmap(Properties.Resources.bambyk), "Some"));
           pic.Add(new PicImage(new Bitmap(Properties.Resources.pic1), "Body"));
           pic.Add(new PicImage(new Bitmap(Properties.Resources.shrek), "Somebody")); 
        }





        protected override void OnPaint(PaintEventArgs pevent)
        {

            pevent.Graphics.DrawImage(pic[i].bitmap, 0, 0);
            strType = new StringFormat();
            strType.Alignment = StringAlignment.Center;
            strType.LineAlignment = StringAlignment.Far;
            pevent.Graphics.DrawString(pic[i].text, Font, new SolidBrush(ForeColor), ClientRectangle, strType);
          
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            pic[i].text = pic[i].showText;
            
            
            if(flag==true)
            {
                graphicsPath.AddRectangle(new Rectangle(12, 12, Width, Height));
                Region = new Region(graphicsPath);
                flag = false;
            }
          

        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            pic[i].text = "";

        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            i++;

            if (i > pic.Count - 1)
                i = 0;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
