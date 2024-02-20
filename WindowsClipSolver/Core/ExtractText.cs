using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using static System.Resources.ResXFileRef;

namespace WindowsClipSolver.Core
{
    internal class ExtractText
    {
     
        public string getText(string image)
        {
            var text = "";
            try
            {
                using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
                {
                    //Pix.LoadFromMemory(new ImageConverter().ConvertTo(image, typeof(byte[])) as byte[])
                    using (var img = Pix.LoadFromFile(image))
                    {
                        using (var page = engine.Process(img))
                        {
                          text = page.GetText();
                            
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Trace.TraceError(e.ToString());
                Console.WriteLine("Unexpected Error: ");
                Console.WriteLine("Details: ");
                Console.WriteLine(e.ToString());
            }
            return text;
        }
    }
}
