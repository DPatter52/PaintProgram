using System.Drawing;
using System.IO;

namespace PaintingProgram.Controllers
{
    public class FileIO 
    {
        public void SaveImage(Bitmap image, string filePath)
        {
            image.Save(filePath);
        }

        public Bitmap LoadImage(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found", filePath);
            return new Bitmap(filePath);
        }
    }
}