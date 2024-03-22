using System.Drawing;

namespace PaintingProgram.Models
{
    // Serves as an abstract class so the other shapes can build off of it.
    public abstract class Shape
    {

        // Getting/Setting shape color
        public Color Color { get; set; }

        // Drawing the shape
        public abstract void Draw(Graphics graphics);
    }
}