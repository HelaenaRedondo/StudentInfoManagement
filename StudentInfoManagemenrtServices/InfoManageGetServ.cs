using InfoManagementDb;

namespace StudentInfoManagement
{
    public class Info
    {
        public List<Information> GetAllInfo()
        {
            Infos infos = new Infos();
            return infos.GetInfo();
        }

        public Information Getusersemail(string email)
        {
            Information acc = new Information();

            foreach (var manage in GetAllInfo())
            {
                if (manage.email == email)
                {
                    acc = manage;
                }
            }
            return acc;
        }

        public Information GetUsernameandPassword(string firstname, string password)
        {
            Information acc = new Information();

            foreach (var manage in GetAllInfo())
            {
                if (manage.firstname == firstname && manage.password == password)
                {
                    acc = manage;
                }
            }
            return acc;
        }

        public Information GetUser(string address)
        {
            Information acc = new Information();

            foreach (var manage in GetAllInfo())
            {
                if (manage.address == address)
                {
                    acc = manage;
                }
            }

            return acc;
        }

        public IEnumerable<object> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        internal Information GetUserByFirstnameAndPassword(string firstname, string password)
        {
            throw new NotImplementedException();
        }

        internal Information GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
