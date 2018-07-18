using TDI2D.Models;

namespace TDI2D
{
    internal interface IEngineRoot
    {
        void Start();
        void Exit();
        void SetWindowSettings(WindowSettings windowSettings);
    }
}
