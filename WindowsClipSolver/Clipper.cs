using System.Drawing;
using WindowsClipSolver.Core;

namespace WindowsClipSolver
{
    public partial class Clipper : Form
    {
        ScreenCapture? screenCapture;
        ExtractText extractText;
        string? imagePath;
        ToolTip toolTip;
        public Clipper()
        {
            InitializeComponent();
            initImages();

            extractText = new ExtractText();
            toolTip = new ToolTip();
            setButtonsState(false);
        }
        private new void Capture(object sender, EventArgs e)
        {
            screenCapture = new ScreenCapture();
            screenCapture.CaptureImage();
            if (screenCapture.IsImageCaptured())
            {
                //FIX ME no need to save image before setting it to image box
                // Retrieve the captured image
                Bitmap capturedImage = screenCapture.GetImage();
                // Save or process the captured image as needed
                string imageName = string.Format("screenshot_{0}.png", DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                capturedImage.Save(imageName, System.Drawing.Imaging.ImageFormat.Png);

                setImage(imageName);
                setTextFromImage(imageName);
                setButtonsState(true);
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
                setButtonsState(true);
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.Title = "Save Image";
            saveImage.Filter = "Image Files(*.jpg; *.jpeg; *.bmp;.*png)|*.jpg; *.jpeg; *.bmp; *.png";
            saveImage.FilterIndex = 2;
            saveImage.RestoreDirectory = true;
            if (saveImage.ShowDialog() == DialogResult.OK)
            {
                imageBox.Image.Save(saveImage.FileName);
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
            setButtonsState(false);
        }

        private void initImages()
        {
            clearButton.Image = new Bitmap(Properties.Resources.broom, clearButton.Height - 4, clearButton.Height - 4);
            takeScreenShot.Image = new Bitmap(Properties.Resources.camera, clearButton.Height - 4, clearButton.Height - 4);
            openFolder.Image = new Bitmap(Properties.Resources.open, clearButton.Height - 4, clearButton.Height - 4);
            saveButton.Image = new Bitmap(Properties.Resources.saveImage, saveButton.Height - 4, saveButton.Height - 4);
            copyButton.Image = new Bitmap(Properties.Resources.copyImage, copyButton.Height - 8, copyButton.Height - 8);

        }

        private void buttonGroup_DpiChangedAfterParent(object sender, EventArgs e)
        {
            initImages();
        }

        private void saveButton_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Save Image", saveButton);
        }

        private void copyButton_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Copy Image", copyButton);
        }

        private void clearButton_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Clear", clearButton);
        }

        private void takeScreenShot_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Capture Screen", takeScreenShot);
        }

        private void openFolder_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Open Folder", openFolder);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(imageBox.Image);

        }
        private void setButtonsState(bool val)
        {
            clearButton.Enabled = val;
            copyButton.Enabled = val;
            saveButton.Enabled = val;
        }

        
    }
}
