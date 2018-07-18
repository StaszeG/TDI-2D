namespace TDI2D.Models
{
    public class WindowSettings
    {
        public uint Height { get; set; }
        public uint Width { get; set; }
        public string WindowTitle { get; set; }

        public WindowSettings(uint height, uint width, string windowTitle)
        {
            Height = height;
            Width = width;
            WindowTitle = windowTitle;
        }
    }
}
