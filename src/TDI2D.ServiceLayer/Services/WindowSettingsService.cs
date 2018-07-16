using TDI2D.ServiceLayer.Models;

namespace TDI2D.ServiceLayer.Services
{
    internal class WindowSettingsService : ServiceBase, IWindowSettingsService
    {
        private WindowSettingsModel _model;

        public ServiceResult Set(WindowSettingsModel model)
        {
            _model = model;
            return new ServiceResult(true);
        }

        public ServiceResult<WindowSettingsModel> Get()
        {
            return _model == null
                ? new ServiceResult<WindowSettingsModel>(false)
                : new ServiceResult<WindowSettingsModel>(_model);
        }
    }
}
