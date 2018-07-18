using TDI2D.Models;

namespace TDI2D
{
    public interface IEngine
    {
        void Start();
        void Exit();
        void SetWindowSettings(WindowSettings windowSettings);
    }
}