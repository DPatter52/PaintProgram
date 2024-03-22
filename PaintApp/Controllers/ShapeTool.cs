using System.Drawing;
using PaintingProgram.Controllers;
using PaintingProgram.Models;

namespace PaintingProgram.Tools
{
    public class ShapeTool
    {
        private DrawingManager drawingManager;
        private BrushSettings brushSetting;
        private ColorPalette colorPalette;

        public ShapeTool(DrawingManager drawingManager, BrushSettings brushSetting, ColorPalette colorPalette)
        {
            this.drawingManager = drawingManager;
            this.brushSetting = brushSetting;
            this.colorPalette = colorPalette;
        }

        public void DrawLine(Point startPoint, Point endPoint)
        {
            var line = new Line
            {
                StartPoint = startPoint,
                EndPoint = endPoint,
                Color = colorPalette.SelectedColor
            };
            drawingManager.AddShape(line);
        }

        public void DrawCircle(Point center, int radius)
        {
            var circle = new Circle
            {
                Center = center,
                Radius = radius,
                Color = colorPalette.SelectedColor
            };
            drawingManager.AddShape(circle);
        }

        public void DrawRectangle(Point topLeft, int width, int height)
        {
            var rectangle = new Rectangle
            {
                TopLeft = topLeft,
                Width = width,
                Height = height,
                Color = colorPalette.SelectedColor
            };
            drawingManager.AddShape(rectangle);
        }
    }
}