using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClipSolver.Core
{
    internal class HandleFile
    {
        static void OpenFile(Object obj) 
        { 
        }
       public static void SaveImageFile(PictureBox obj) {
            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.Title = "Save Image";
            saveImage.Filter = "Image Files(*.jpg; *.jpeg; *.bmp;.*png)|*.jpg; *.jpeg; *.bmp; *.png";
            saveImage.FilterIndex = 2;
            saveImage.RestoreDirectory = true;
            if (saveImage.ShowDialog() == DialogResult.OK)
            {
                obj.Image.Save(saveImage.FileName);
            }
        }

       public static void SaveTextFile(RichTextBox obj) {
            SaveFileDialog saveText = new SaveFileDialog();
            saveText.Title = "Save Text";
            saveText.Filter = "Text Files(*.txt)|*.txt";
            saveText.FilterIndex = 2;
            saveText.RestoreDirectory = true;
            if (saveText.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveText.FileName, obj.Text);
            }
        }
    }
}
