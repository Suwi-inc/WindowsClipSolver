using System.Drawing;
using WindowsClipSolver.Core;

namespace WindowsClipSolver
{
    public partial class Clipper : Form
    {
        //main
        ScreenCapture? screenCapture;
        ExtractText extractText;
        string? imagePath;
        ToolTip toolTip;
        public Clipper()
        {
            InitializeComponent();
            initImages(true);

            extractText = new ExtractText();
            toolTip = new ToolTip();
            setButtonsState(false);
        }
        private new void Capture(object sender, EventArgs e)
        {
            this.Visible = false;
            screenCapture = new ScreenCapture();
            screenCapture.CaptureImage();
            if (screenCapture.IsImageCaptured())
            {
                // Retrieve the captured image
                Bitmap capturedImage = screenCapture.GetImage();
                // Save or process the captured image as needed
                //string imageName = string.Format("screenshot_{0}.png", DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                //capturedImage.Save(imageName, System.Drawing.Imaging.ImageFormat.Png);
                setImage(capturedImage);
                setTextFromImage(capturedImage);
                setButtonsState(true);
                this.Visible = true;
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
            open.Filter = "Image Files(*.jpg; *.jpeg; *.bmp;.*png)|*.jpg; *.jpeg; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(open.FileName);
                setImage(image);
                //imagePath = open.FileName;
                setTextFromImage(image);
                setButtonsState(true);
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (menuTab.SelectedIndex == 0)
                HandleFile.SaveImageFile(imageBox);
            else
                HandleFile.SaveTextFile(mainText);
        }
        private void copyButton_Click(object sender, EventArgs e)
        {
            if (menuTab.SelectedIndex == 0)
                Clipboard.SetImage(imageBox.Image);
            else
                Clipboard.SetText(mainText.Text);

        }
        // display image in picture box  
        private void setImage(Bitmap image)
        {
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox.Image = image;

        }
        // display extracted text from the image in the text field 
        private void setTextFromImage(Bitmap image)
        {
            mainText.Text = extractText.getText(image);
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            mainText.Clear();
            imageBox.Image = null;
            setButtonsState(false);
        }
        private void initImages(bool image)
        {
            clearButton.Image = new Bitmap(Properties.Resources.broom, clearButton.Height - 4, clearButton.Height - 4);
            takeScreenShot.Image = new Bitmap(Properties.Resources.camera, clearButton.Height - 4, clearButton.Height - 4);
            openFolder.Image = new Bitmap(Properties.Resources.open, clearButton.Height - 4, clearButton.Height - 4);
            saveButton.Image = new Bitmap(image ? Properties.Resources.saveImage : Properties.Resources.saveSmall, saveButton.Height - 6, saveButton.Height - 6);
            copyButton.Image = new Bitmap(image ? Properties.Resources.copyImage : Properties.Resources.copyrText1, copyButton.Height - 8, copyButton.Height - 8);

        }
        private void buttonGroup_DpiChangedAfterParent(object sender, EventArgs e)
        {
            initImages(menuTab.SelectedIndex == 0 ? true : false);
        }
        private void saveButton_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show(menuTab.SelectedIndex == 0 ? "Save Image" : "Save Text", saveButton);
        }
        private void copyButton_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show(menuTab.SelectedIndex == 0 ? "Copy Image" : "Copy Text", copyButton);
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

        private void setButtonsState(bool val)
        {
            clearButton.Enabled = val;
            copyButton.Enabled = val;
            saveButton.Enabled = val;
        }

        private void menuTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            //default icons are for image copy and image save, only change for text if index is 1
            initImages(menuTab.SelectedIndex != 1);

        }
    }
}
