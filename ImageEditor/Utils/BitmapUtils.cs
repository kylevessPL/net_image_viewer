using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ImageEditor.Forms.Utils
{
    public static class BitmapUtils
    {
        public static bool Compare(Bitmap bmp1, Bitmap bmp2)
        {
            var iHash1 = GetHash(bmp1);
            var iHash2 = GetHash(bmp2);
            return iHash1.SequenceEqual(iHash2);
        }

        private static IEnumerable<bool> GetHash(Image bmpSource)
        {
            var lResult = new List<bool>();
            var bmpMin = new Bitmap(bmpSource, new Size(16, 16));
            for (var j = 0; j < bmpMin.Height; j++)
            for (var i = 0; i < bmpMin.Width; i++)
                lResult.Add(bmpMin.GetPixel(i, j).GetBrightness() < 0.5f);
            return lResult;
        }
    }
}