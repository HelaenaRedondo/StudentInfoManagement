using AccountManagementData;
using AccountManagementModels;

namespace AccountManagementServices
{
    public class StudGetServices
    {
        private List<Stud> GetAllUsers()
        {
            StudentData userData = new StudentData();

            return userData.GetUsers();

        }

        public List<Stud> GetUsersByStatus(int userStatus)
        {
            List<Stud> usersByStatus = new List<Stud>();

            foreach (var user in GetAllUsers())
            {
                if (user.status == userStatus)
                {
                    usersByStatus.Add(user);
                }
            }

            return usersByStatus;
        }

        public Stud GetUser(string username, string password)
        {
            Stud foundUser = new Stud();

            foreach (var user in GetAllUsers())
            {
                if (user.username == username && user.password == password)
                {
                    foundUser = user;
                }
            }

            return foundUser;
        }

        public Stud GetUser(string username)
        {
            Stud foundUser = new Stud();

            foreach (var user in GetAllUsers())
            {
                if (user.username == username)
                {
                    foundUser = user;
                }
            }

            return foundUser;
        }
    }
}