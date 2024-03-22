namespace PaintingProgram.Controllers
{
    public class ColorPalette
    {
        public System.Drawing.Color SelectedColor { get; set; }

        public ColorPalette() => SelectedColor = System.Drawing.Color.Black ;
    }
}