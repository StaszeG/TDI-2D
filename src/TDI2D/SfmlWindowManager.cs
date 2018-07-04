using System;
using TDI2D.Interfaces;

namespace TDI2D
{
    internal class SfmlWindowManager : IWindowManager
    {
        public void OpenWindow()
        {
            Console.WriteLine("Window opened.");
        }
    }
}
