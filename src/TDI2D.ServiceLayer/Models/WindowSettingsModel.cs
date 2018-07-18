﻿namespace TDI2D.ServiceLayer.Models
{
    public class WindowSettingsModel
    {
        public uint Height { get; set; }
        public uint Width { get; set; }
        public string WindowTitle { get; set; }

        public WindowSettingsModel(uint height, uint width, string windowTitle)
        {
            Height = height;
            Width = width;
            WindowTitle = windowTitle;
        }
    }
}
