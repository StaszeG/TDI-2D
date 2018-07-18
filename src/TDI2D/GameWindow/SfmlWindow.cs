using System;
using SFML.Graphics;
using TDI2D.Models;
using TDI2D.ServiceLayer.Services;

namespace TDI2D.WindowOperators
{
    internal class SfmlWindow : IGameWindow
    {
        private readonly IWindowSettingsService _windowSettings;

        private RenderWindow _window;

        public SfmlWindow(IWindowSettingsService windowSettings)
        {
            _windowSettings = windowSettings;
        }

        public void Open()
        {
            var windowSettingsResult = _windowSettings.Get();
            if (!windowSettingsResult.IsSuccess)
            {
                throw new Exception("Can't get window settings");
            }

            var windowSettings = AutoMapper.Mapper.Map<WindowSettings>(windowSettingsResult.Response);
            _window = AutoMapper.Mapper.Map<RenderWindow>(windowSettings);
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
