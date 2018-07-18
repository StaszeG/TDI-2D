using System;
using SFML.Graphics;
using SFML.Window;
using TDI2D.ServiceLayer.Services;

namespace TDI2D.WindowOperators
{
    internal class SfmlWindow : IGameWindow
    {
        private readonly IWindowSettingsService _windowsSettings;

        private RenderWindow _window;

        public SfmlWindow(IWindowSettingsService windowsSettings)
        {
            _windowsSettings = windowsSettings;
        }

        public void Open()
        {
            _window = new RenderWindow(new VideoMode(800, 600), "SFML Works!");
            _window.Closed += OnClose;

            ManageWindowLoop();
        }

        public void Close()
        {
            _window.Close();
        }

        private void ManageWindowLoop()
        {
            while (_window.IsOpen)
            {
                _window.DispatchEvents();

                _window.Clear(Color.Black);

                _window.Display();
            }
        }

        private static void OnClose(object sender, EventArgs e)
        {
            var window = (RenderWindow)sender;
            window.Close();
        }
    }
}
