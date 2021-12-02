using System;
using System.Drawing;

namespace iFunnyCaption
{
    class Renderer
    {
        public static Image[] AddText(Image[] source, string[] lines, Font font)
        {
            Image[] output = new Image[source.Length];
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            for (int i = 0; i < output.Length; i++)
            {
                Bitmap image = (Bitmap)source[i];
                using (Graphics g = Graphics.FromImage(image))
                {
                    for (int j = 0; j < lines.Length; j++)
                    {
                        g.DrawString(lines[j], font, Brushes.Black, image.Width / 2, font.Height * (j + 1), format);
                    }
                }
                output[i] = image;
                Console.WriteLine("Adding text...");
            }
            return output;
        }

        public static Image[] WhiteBar(Image[] source, int extension)
        {
            Image[] output = new Image[source.Length];
            for (int i = 0; i < output.Length; i++)
            {
                Bitmap image = (Bitmap)source[i];
                Bitmap newimg = new Bitmap(image.Width, image.Height + extension);
                newimg = FillColor(newimg, Color.White);
                CopyRegionIntoImage(image, new Rectangle(0, 0, image.Width, image.Height), ref newimg, new Rectangle(0, extension, newimg.Width, newimg.Height - extension));
                output[i] = newimg;
                Console.WriteLine("Adding white bar...");
            }
            return output;
        }

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
