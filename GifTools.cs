using System.Drawing;
using System.Drawing.Imaging;
namespace iFunnyCaption
{
    class GifTools
    {
        public static Image[] getFrames(Image originalImg)
        {
            int numberOfFrames = originalImg.GetFrameCount(FrameDimension.Time);
            Image[] frames = new Image[numberOfFrames];

            for (int i = 0; i < numberOfFrames; i++)
            {
                originalImg.SelectActiveFrame(FrameDimension.Time, i);
                frames[i] = ((Image)originalImg.Clone());
            }

            return frames;
        }

        public static int GetFrameDelay(Image gif)
        {
            PropertyItem item = gif.GetPropertyItem(0x5100);
            int msdelay = (item.Value[0] + item.Value[1] * 256) * 10;
            return msdelay;
        }
    }
}
