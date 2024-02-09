using System.Drawing;
using WindowsClipSolver.Core;

namespace WindowsClipSolver
{
    public partial class Clipper : Form
    {
        ScreenCapture screenCapture;
        ExtractText extractText;
        string imagePath;
        public Clipper()
        {
            InitializeComponent();
            screenCapture = new ScreenCapture();
            extractText = new ExtractText();
        }
        private void Capture(object sender, EventArgs e)
        {
            screenCapture.CaptureImage();
            if (screenCapture.IsImageCaptured())
            {
                // Retrieve the captured image
                Bitmap capturedImage = screenCapture.GetImage();
                // Save or process the captured image as needed
                string imageName = string.Format("screenshot_{0}.png", DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                capturedImage.Save(imageName, System.Drawing.Imaging.ImageFormat.Png);

                setImage(imageName);
                setTextFromImage(imageName);

            }
            else
            {
                MessageBox.Show("Failed to capture screenshot.");

            }
            screenCapture.Close();
        }

        private void openFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.bmp;.*png)|*.jpg; *.jpeg; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                setImage(open.FileName);
                imagePath = open.FileName;
                setTextFromImage(imagePath);
            }
        }
        // display image in picture box  
        private void setImage(string path)
        {
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox.Image = new Bitmap(path);

        }
        // display extracted text from the image in the text field 
        private void setTextFromImage(string path)
        {
            mainText.Text = extractText.getText(path);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            mainText.Clear();
            imageBox.Image = null;
        }
    }
}
