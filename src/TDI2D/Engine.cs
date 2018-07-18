using Castle.Windsor;
using TDI2D.Containers;
using TDI2D.Maps;
using TDI2D.Models;
using TDI2D.ServiceLayer.Containers;

namespace TDI2D
{
    public class Engine : IEngine
    {
        private readonly IEngineRoot _engineRoot;

        public Engine()
        {
            var container = new WindsorContainer();

            container.Install(new Installer());
            container.Install(new ServicesInstaller());

            _engineRoot = container.Resolve<IEngineRoot>();

            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<SfmlProfile>();
            });
        }

        public void Start()
        {
            _engineRoot.Start();
        }

        public void SetWindowSettings(WindowSettings windowSettings)
        {
            _engineRoot.SetWindowSettings(windowSettings);
        }

        public void Exit()
        {
            _engineRoot.Exit();
        }
    }
}
