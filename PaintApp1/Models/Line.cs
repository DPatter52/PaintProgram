namespace PaintingProgram.Models
{
    public class Line : Shape
    {
        // Getting/Setting start/end point values
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public override void Draw(Graphics graphics)
        {
            using (var pen = new Pen(Color))
            {
                graphics.DrawLine(pen, StartPoint, EndPoint);
            }
        }
    }
}
