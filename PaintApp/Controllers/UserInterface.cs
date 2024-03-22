using System.Windows.Forms;
using PaintingProgram.Controllers;

namespace UserInterface
{
    public class UserInterface
    {
        private ToolSelector toolSelector;
        private DrawingManager drawingManager;

        public UserInterface(ToolSelector toolSelector, DrawingManager drawingManager)
        {
            this.toolSelector = toolSelector;
            this.drawingManager = drawingManager;
        }

        public void Initialize()
        {
            
        }
    }
}