using System.Collections.Generic;
using System.Drawing;

namespace ooooop5
{
    internal class MyImage
    {
        public Bitmap bitmap
        {
            get; 
        }
        private string v;
        public string showText { get; private set; }

        public string text = "";

        public List<MyImage> gallery = new List<MyImage>();
        

        public MyImage(Bitmap bitmap, string v)
        {
            this.bitmap = bitmap;
            this.showText = v;
        }
    }
}