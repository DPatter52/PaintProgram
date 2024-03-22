using System;

namespace PaintingProgram.Controllers
{
    public class BrushSettings
    {
        private int brushSize;

        public int BrushSize
        {
            get { return brushSize; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("Brush size must be greater than or equal to 1");
                brushSize = value;
            }
        }

        public BrushSettings()
        {
            BrushSize = 1;
        }
    }
}