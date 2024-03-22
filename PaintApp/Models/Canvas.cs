using System.Collections.Generic;
using System.Drawing;

namespace PaintingProgram.Models
{

    public class Canvas
    {
        private Bitmap drawingSurface;
        private Graphics graphics;

        // Contstructs the canvas based on the width and height given.
        public Canvas(int width, int height)
        {
            drawingSurface = new Bitmap(width, height);
            graphics = graphics.FromImage(drawingSurface);
        }

        // Alows us to draw shapes on the canvas.
        public void DrawShape(Shape shape) => shape.Draw(graphics);

        // Replaces everything on the canvas with white, technically clearing it to a new canvas.
        public void ClearCanvas() => graphics.Clear(Color.White);

        // Retrieves the state of the canvas.
        public void Bitmap GetCanvasImage() => return drawingSurface;
internal class DrawShape
        {
        }
    }
}