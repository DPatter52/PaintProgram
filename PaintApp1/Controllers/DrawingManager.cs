using PaintingProgram.Models;

namespace PaintingProgram.Controllers
{
    public class DrawingManager
    {
        private Canvas canvas;
        private List<Shape> shapes;

        public DrawingManager(Canvas canvas)
        {
            this.canvas = canvas;
            shapes = new List<Shape>();
        }

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
            canvas.DrawShape(shape);
        }

        public void ClearCanvas()
        {
            shapes.Clear();
            canvas.ClearCanvas();
        }
    }
}
