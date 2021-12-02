using AnimatedGif;
using iFunnyCaption;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace iFunnyCaptionGUI
{
    public partial class MainWindow : Form
    {
        private static PrivateFontCollection _privateFontCollection = new PrivateFontCollection();

        public MainWindow()
        {
            InitializeComponent();
            byte[] fontbytes = Properties.Resources.Futura_Bold;
            FontTools.AddFontFromBytes(ref _privateFontCollection, fontbytes);
        }

        private void InGifPicker_Click(object sender, EventArgs e)
        {
            if (InputGifDir.Text != "" &&
                Uri.IsWellFormedUriString(InputGifDir.Text, UriKind.Absolute))
                openInputGif.InitialDirectory = InputGifDir.Text;

            openInputGif.FileName = "";
            openInputGif.Filter = "GIF files (*.gif))|*.gif";
            openInputGif.RestoreDirectory = true;
            if (openInputGif.ShowDialog() == DialogResult.OK)
            {
                InputGifDir.Text = openInputGif.FileName;
            }
        }

        private void OutDirPicker_Click(object sender, EventArgs e)
        {
            if (OutputGifDir.Text != "" &&
                Uri.IsWellFormedUriString(OutputGifDir.Text, UriKind.Absolute))
                openOutputGif.InitialDirectory = OutputGifDir.Text;

            openOutputGif.Filter = "GIF files (*.gif)|*.gif";
            openOutputGif.RestoreDirectory = true;
            if (openOutputGif.ShowDialog() == DialogResult.OK)
            {
                OutputGifDir.Text = openOutputGif.FileName;
            }
        }

        private void RenderButton_Click(object sender, EventArgs e)
        {
            RenderProgressBar.Minimum = 1;
            string noPercent = SpeedDropdown.Text.Replace("%", "");
            float speed = float.Parse(noPercent);
            Thread renderThread = new Thread(() => Render(this, InputGifDir.Text, OutputGifDir.Text,
                CaptionText.Text, _privateFontCollection.Families[0], speed/100f));
            renderThread.Start();
        }

        public static void Render(MainWindow sender, string inputGif, string outputGif, string caption, FontFamily fontIn, float speedMultiplier)
        {
            Image origGif = Image.FromFile(inputGif);
            int imagewidth = origGif.Width;
            int fontheight = (int)(0.075 * imagewidth);
            string text = caption;
            Font FuturaBold = new Font(fontIn, fontheight);
            var lines = FontTools.SplitToLines(text, FuturaBold, origGif.Width);
            Image[] Frames = GifTools.getFrames(origGif);
            sender.RenderProgressBar.Invoke((MethodInvoker)delegate { sender.RenderProgressBar.Maximum = Frames.Length; });
            Image[] wWhiteBar = Renderer.WhiteBar(Frames, FuturaBold.Height * (lines.Count() + 1));
            Image[] wText = Renderer.AddText(wWhiteBar, lines.ToArray(), FuturaBold);
            using (var gif = AnimatedGif.AnimatedGif.Create(outputGif, (int)(GifTools.GetFrameDelay(origGif)/speedMultiplier)))
            {
                foreach (Image img in wText)
                {
                    sender.RenderProgressBar.Invoke((MethodInvoker)delegate { sender.RenderProgressBar.Increment(1);});
                    gif.AddFrame(img, delay: -1, quality: GifQuality.Bit8);
                    Console.WriteLine("Writing frame...");
                }
            }
            MessageBox.Show("Render complete", "iFunny Caption", MessageBoxButtons.OK);
            sender.RenderProgressBar.Invoke((MethodInvoker)delegate { sender.RenderProgressBar.Value = 1; });
        }

    }
}
