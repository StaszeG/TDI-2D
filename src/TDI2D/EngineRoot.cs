using System;
using TDI2D.Interfaces;

namespace TDI2D
{
    internal class EngineRoot : IEngineRoot
    {
        private readonly IWindowManager _windowManager;

        public EngineRoot(IWindowManager windowManager)
        {
            _windowManager = windowManager;
        }

        public void Start()
        {
            _windowManager.OpenWindow();
            Console.ReadLine();
        }
    }
}
