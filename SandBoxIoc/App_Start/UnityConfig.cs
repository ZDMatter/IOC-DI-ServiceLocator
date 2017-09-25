using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using SandBoxIocDomain.Domain;

namespace SandBoxIoc
{
    public static class UnityConfig
    {

        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            // e.g. container.RegisterType<ITestService, TestService>();

            RegisterTypes(container);

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            //Automatic resolver based on IPerson => Person
            container.RegisterTypes(
               AllClasses.FromLoadedAssemblies(),
               WithMappings.FromMatchingInterface,
               WithName.Default);

#if DEBUG
            container.RegisterType<IShippingType, MocConcrete1>("Concrete1");
#else
            container.RegisterType<IShippingType, Concrete1>("Concrete1");
#endif

            container.RegisterType<IShippingType, Concrete2>("Concrete2");

            container.RegisterType<IShippingType, Concrete3>("Concrete3");
        }
    }
}