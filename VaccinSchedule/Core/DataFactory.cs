using VaccinSchedule.Core.DataLayer;
using VaccinSchedule.Core.Services;
using WebMatrix.WebData;

namespace VaccinSchedule.Core
{
    public class DataFactory : ISecurityContext
    {
        private VaccinReminderDataContext dataContext;
        protected VaccinReminderDataContext DataContext
        {
            get
            {
                if (dataContext == null)
                {
                    dataContext = new VaccinReminderDataContext();
                }
                return dataContext;
            }
            set { dataContext = value; }
        }

        private static DataFactory instance;
        public static DataFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataFactory();
                }
                return instance;
            }
            set { instance = value; }
        }

        public bool Login(string userName, string password, bool rememberMe)
        {
            return WebSecurity.Login(userName, password, rememberMe);
        }
    }
}