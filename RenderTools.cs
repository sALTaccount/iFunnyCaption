using System.Drawing;

namespace iFunnyCaption
{
    class RenderTools
    {
        public static Bitmap FillColor(Bitmap bitmp, Color color)
        {
            using (Graphics grD = Graphics.FromImage(bitmp))
            {
                grD.Clear(color);
            }
            return bitmp;
        }

        public static void CopyRegionIntoImage(Bitmap srcBitmap, Rectangle srcRegion, ref Bitmap destBitmap, Rectangle destRegion)
        {
            using (Graphics grD = Graphics.FromImage(destBitmap))
            {
                grD.DrawImage(srcBitmap, destRegion, srcRegion, GraphicsUnit.Pixel);
            }
        }
    }
}
