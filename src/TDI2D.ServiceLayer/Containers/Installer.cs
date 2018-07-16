using System.Reflection;
using Castle.Components.DictionaryAdapter.Xml;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using TDI2D.ServiceLayer.Services;

namespace TDI2D.ServiceLayer.Containers
{
    public class ServicesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                .IncludeNonPublicTypes()
                .BasedOn<ServiceBase>()
                .WithService.DefaultInterfaces()
                .LifestyleSingleton());
        }
    }
}
