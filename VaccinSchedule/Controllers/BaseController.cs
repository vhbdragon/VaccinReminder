using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;
using VaccinSchedule.Core.Services;

namespace VaccinSchedule.Controllers
{
    public class BaseController : Controller
    {
        protected ISecurityContext securityContext
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ISecurityContext>();
            }
        }
    }
}
