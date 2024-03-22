using System;
using System.Drawing;

namespace PaintingProgram.Controllers
{
    public class ColorPalette
    {
        public Color SelectedColor { get; set; }

        public ColorPalette()
        {
            SelectedColor = Color: Black;
        }
    }
}