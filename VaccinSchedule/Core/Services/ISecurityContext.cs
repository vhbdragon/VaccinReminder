
namespace VaccinSchedule.Core.Services
{
    public interface ISecurityContext
    {
        bool Login(string userName, string password, bool rememberMe);
    }
}
