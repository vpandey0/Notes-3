using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using DependencyInversion.Models;
using DependencyInversion.Repository;
namespace DependencyInversion
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
             container.RegisterType<IStudentRepository, StudentRepository>(); // IOC by unity container
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}