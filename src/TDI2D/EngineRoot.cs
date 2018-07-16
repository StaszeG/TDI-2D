using System;
using TDI2D.WindowOperators;

namespace TDI2D
{
    internal class EngineRoot : IEngineRoot
    {
        private readonly IWindowOperator _windowManager;

        public EngineRoot(IWindowOperator windowManager)
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
