using System;
using System.Threading.Tasks;
using TDI2D;

namespace SampleTestProject
{
    internal class Program
    {
        private static readonly Engine _engine = new Engine();

        private static void Main()
        {
            Task.Run(() =>
            {
                _engine.Start();
            });
            Console.ReadKey();
            _engine.Exit();
        }
    }
}
