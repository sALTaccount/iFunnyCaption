using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace iFunnyCaption
{
    class FontTools
    {
        public static List<string> SplitToLines(string text, Font font, int width)
        {
            var lines = new List<string>();
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Replace(" ", "");
            }
            string curLine = "";
            string newLine = "";
            foreach (var word in words)
            {
                if (curLine == "")
                {
                    newLine = word;
                }
                else
                {
                    newLine = curLine + ' ' + word;
                }

                if (StringFits(newLine, font, width))
                {
                    curLine = newLine;
                }
                else
                {
                    lines.Add(curLine);
                    curLine = word;
                    newLine = word;
                }
            }
            if (newLine != "") lines.Add(newLine);
            return lines;
        }

        private static bool StringFits(string text, Font font, int width)
        {
            Image fakeImage = new Bitmap(1, 1);
            Graphics graphics = Graphics.FromImage(fakeImage);
            SizeF size = graphics.MeasureString(text, font);
            return size.Width < width;
        }

        public static void AddFontFromBytes(ref PrivateFontCollection _privateFontCollection, byte[] fontBytes)
        {
            var handle = GCHandle.Alloc(fontBytes, GCHandleType.Pinned);
            IntPtr pointer = handle.AddrOfPinnedObject();
            try
            {
                _privateFontCollection.AddMemoryFont(pointer, fontBytes.Length);
            }
            finally
            {
                handle.Free();
            }
        }
    }
}
