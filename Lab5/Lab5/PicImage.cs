using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class PicImage 
    {
        public Bitmap bitmap { get; }

        public string showText {  get; private set; }

        public string text = "";

        public List<PicImage> gallery = new List<PicImage>();
        public PicImage() : base()
        {

        }

        public PicImage(Bitmap bitmap, string showText)
        {
            this.bitmap = bitmap;
            this.showText = showText;
        }
    }
}
