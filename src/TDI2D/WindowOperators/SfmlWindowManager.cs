using System;
using TDI2D.ServiceLayer.Services;

namespace TDI2D.WindowOperators
{
    internal class SfmlWindowOperator : IWindowOperator
    {
        private readonly IWindowSettingsService _windowsSettings;

        public SfmlWindowOperator(IWindowSettingsService windowsSettings)
        {
            _windowsSettings = windowsSettings;
        }

        public void OpenWindow()
        {
            Console.WriteLine("Window opened.");
        }
    }
}
