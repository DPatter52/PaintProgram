using PaintingProgram.Controllers;
using PaintingProgram.Models;
using PaintingProgram.Tools;

namespace PaintApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var brushSetting = new BrushSettings();
            var colorPalette = new ColorPalette();
            var canvas = new Canvas(800, 600);
            var drawingManager = new DrawingManager(canvas);
            var shapeTool = new ShapeTool(drawingManager, brushSetting, colorPalette);
            var toolSelector = new ToolSelector(shapeTool);

            var userInterface = new UserInterface.UserInterface(toolSelector, drawingManager);
            userInterface.Initialize();

            Application.Run();
        }
    }
}
