using Castle.Windsor;
using TDI2D.Containers;
using TDI2D.Interfaces;

namespace TDI2D
{
    public class Engine : IEngine
    {
        private IWindsorContainer _container;
        private IEngineRoot _engineRoot;

        public Engine()
        {
            _container = new WindsorContainer();
            _container.Install(new Installer());

            _engineRoot = _container.Resolve<IEngineRoot>();
        }


        public void Start()
        {
            _engineRoot.Start();
        }
    }

    public interface IEngine
    {
        void Start();
    }
}
