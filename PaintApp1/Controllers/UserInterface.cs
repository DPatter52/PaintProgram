using PaintingProgram.Controllers;


namespace UserInterface
{
    public class UserInterface
    {
        private ToolSelector toolSelector;
        private DrawingManager drawingManager;

        private Form mainForm;
        private Button selectColorButton;
        private Label colorLabel;

        public UserInterface(ToolSelector toolSelector, DrawingManager drawingManager)
        {
            this.toolSelector = toolSelector;
            this.drawingManager = drawingManager;
            mainForm = new Form();
            selectColorButton = new Button();
            colorLabel = new Label();
        }

        public void Initialize()
        {
            mainForm = new Form
            {
                Text = "Painting Program",
                Size = new System.Drawing.Size(400, 200)
            };

            selectColorButton = new Button
            {
                Text = "Select Color",
                Location = new System.Drawing.Point(50, 100)
            };
            selectColorButton.Click += selectColorButton_Click;

            colorLabel = new Label
            {
                Text = "Selected Color: ",
                Location = new System.Drawing.Point(50, 100)
            };

            mainForm.Controls.Add(selectColorButton);
            mainForm.Controls.Add(colorLabel);
        }

        private void selectColorButton_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
