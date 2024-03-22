using System;
using System.Windows.Forms;
using PaintProgram.Controllers;
using PaintProgram.Views;

namespace PaintingProgram
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var brushSetting = new BrushSettings();
            var colorPalette = new ColorPalette();
            var canvas = new Models.Canvas(800, 600);
            var drawingManager = new DrawingManager(canvas);
            var shapeTool = new Tools.ShapeTool(drawingManager, brushSetting, colorPalette);
            var toolSelector = new ToolSelector(shapeTool);

            var userInterface = new UserInterface(toolSelector, drawingManager);
            userInterface.Initialize();

            Application.Run();
        }
    }
}