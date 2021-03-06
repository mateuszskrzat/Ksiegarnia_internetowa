using Logic.DataLogic;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MyBook
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IAdminLogic, AdminLogic>();
            container.RegisterType<IProductLogic, ProductLogic>();
            container.RegisterType<IEmployeeLogic, EmployeeLogic>();
            container.RegisterType<IOrderLogic, IOrderLogic>();
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}