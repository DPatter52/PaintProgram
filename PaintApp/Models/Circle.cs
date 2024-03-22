using System.Drawing;

namespace PaintingProgram.Models
{
    public class Circle : Shape
    {

        // Getting/Setting the point center values
        public Point Center { get; set; }

        // Getting/Setting the Radius values
        public int Radius { get; set; }

        // Drawing the circle and setting the different parameters for it to be drawn on the canvas using the namespace DrawEllipse from System.Drawing
        public override void Draw(Graphics graphics)
        {

            int diameter = Radius * 2;
            using (var pen = new Pen(Color))
            {
                graphics.DrawEllipse(pen, Center.X - Radius, Center.Y - Radius, diameter, diameter);
            }
        }
    }
}