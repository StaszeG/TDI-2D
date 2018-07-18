using System;
using TDI2D.Models;
using TDI2D.ServiceLayer.Models;
using TDI2D.ServiceLayer.Services;
using TDI2D.WindowOperators;

namespace TDI2D
{
    internal class EngineRoot : IEngineRoot
    {
        private readonly IGameWindow _gameWindow;
        private readonly IWindowSettingsService _windowSettingsService;

        public EngineRoot(IGameWindow windowManager, IWindowSettingsService windowSettingsService)
        {
            _gameWindow = windowManager;
            _windowSettingsService = windowSettingsService;
        }

        public void Start()
        {
            _gameWindow.Open();
        }

        public void Exit()
        {
            _gameWindow.Close();
        }

        public void SetWindowSettings(WindowSettings windowSettings)
        {
            var model = AutoMapper.Mapper.Map<WindowSettingsModel>(windowSettings);
            var result = _windowSettingsService.Set(model);
            if (!result.IsSuccess)
            {
                throw new Exception("Can't set window settings.");
            }
        }
    }
}
