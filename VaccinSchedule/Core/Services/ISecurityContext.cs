
using VaccinSchedule.Core.DomainModel;
namespace VaccinSchedule.Core.Services
{
    public interface ISecurityContext
    {
        bool Login(string userName, string password);
        bool Login(string userName, string password, bool rememberMe);
        void Logout();
        string CreateUserAndAccount(string userName, string password);
        User CurrentUser { get; }
    }
}
