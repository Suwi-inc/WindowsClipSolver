using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace WindowsClipSolver.Core
{
    internal class ExtractText
    {
     
        public string getText(string path)
        {
            var text = "";
            try
            {
                using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
                {
                    using (var img = Pix.LoadFromFile(path))
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
