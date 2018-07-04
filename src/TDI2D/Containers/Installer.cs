﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using TDI2D.Interfaces;

namespace TDI2D.Containers
{
    internal class Installer : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IEngineRoot>()
                .ImplementedBy<EngineRoot>()
                .LifestyleTransient());

            container.Register(Component.For<IWindowManager>()
                .ImplementedBy<SfmlWindowManager>()
                .LifestyleTransient());
        }
    }
}
