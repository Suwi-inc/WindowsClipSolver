using System.Diagnostics;
using Tesseract;
namespace WindowsClipSolver.Core
{
    internal class ExtractText
    {
        public string getText(Bitmap image)
        {
            var text = "";
            try
            {
                using (var engine = new TesseractEngine(@"./tessdata", "eng+rus+lat", EngineMode.Default))
                {
                    using (var img = Pix.LoadFromMemory(new ImageConverter().ConvertTo(image, typeof(byte[])) as byte[]))
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
                Console.WriteLine("Unexpected Error: \n Details: \n"+e.ToString());
            }
            return text;
        }
    }
}
