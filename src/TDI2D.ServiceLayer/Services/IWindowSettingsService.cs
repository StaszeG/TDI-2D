using TDI2D.ServiceLayer.Models;

namespace TDI2D.ServiceLayer.Services
{
    public interface IWindowSettingsService
    {
        ServiceResult Set(WindowSettingsModel model);
        ServiceResult<WindowSettingsModel> Get();
    }
}
