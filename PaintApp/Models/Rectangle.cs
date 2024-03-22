using System.Drawing;

namespace PaintingProgram.Models
{
    public class Rectangle : Shape
    {
        public Point TopLeft { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(pen, TopLeft.X, TopLeft.Y, Width, Height);
        }

    }
}