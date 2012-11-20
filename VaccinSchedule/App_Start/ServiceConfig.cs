using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using VaccinSchedule.Core;
using VaccinSchedule.Core.Services;

namespace VaccinSchedule
{
    public class ServiceConfig
    {
        public static void Register()
        {
            var container = new UnityContainer();
            var locator = new UnityServiceLocator(container);

            container.RegisterInstance<ISecurityContext>(DataFactory.Instance);

            ServiceLocator.SetLocatorProvider(() => locator);
        }
    }
}