using System;
using TDI2D.WindowOperators;

namespace TDI2D
{
    internal class EngineRoot : IEngineRoot
    {
        private readonly IGameWindow _windowManager;

        public EngineRoot(IGameWindow windowManager)
        {
            _windowManager = windowManager;
        }

        public void Start()
        {
            _windowManager.Open();
        }

        public void Exit()
        {
            _windowManager.Close();
        }
    }
}
