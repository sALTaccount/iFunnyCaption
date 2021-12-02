using AnimatedGif;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;

namespace iFunnyCaption
{
    class Program
    {
        private static PrivateFontCollection _privateFontCollection = new PrivateFontCollection();
        static void oldmain(string[] args)
        {
            byte[] fontbytes = File.ReadAllBytes("Futura Bold.ttf");
            FontTools.AddFontFromBytes(ref _privateFontCollection, fontbytes);
            Image origGif = Image.FromFile(args[0]);
            int imagewidth = origGif.Width;
            int fontheight = (int)(0.075 * imagewidth);
            Font FuturaBold = new Font(_privateFontCollection.Families[0], fontheight);
            string text = args[1];
            var lines = FontTools.SplitToLines(text, FuturaBold, origGif.Width);
            Image[] Frames = GifTools.getFrames(origGif);
            Image[] wWhiteBar = Renderer.WhiteBar(Frames, FuturaBold.Height * (lines.Count() + 1));
            Image[] wText = Renderer.AddText(wWhiteBar, lines.ToArray(), FuturaBold);
            using (var gif = AnimatedGif.AnimatedGif.Create("output.gif", GifTools.GetFrameDelay(origGif)))
            {
                foreach (Image img in wText)
                {
                    gif.AddFrame(img, delay: -1, quality: GifQuality.Bit8);
                    Console.WriteLine("Writing frame...");
                }
            }
        }

    }
}
