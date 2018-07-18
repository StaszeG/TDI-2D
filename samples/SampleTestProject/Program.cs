using System;
using System.Threading.Tasks;
using TDI2D;
using TDI2D.Models;

namespace SampleTestProject
{
    internal class Program
    {
        private static readonly IEngine _engine = new Engine();

        private static void Main()
        {
            var windowSettings = new WindowSettings(600, 800, "My game window!");
            _engine.SetWindowSettings(windowSettings);

            Task.Run(() =>
            {
                _engine.Start();
            });
            Console.ReadKey();
            _engine.Exit();
        }
    }
}
