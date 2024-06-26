using AccountManagementData;
using AccountManagementModels;


namespace AccountManagementServices
{
    public class StudTransactionServices
    {
        StudValidationServices validationServices = new StudValidationServices();
        StudentData userData = new StudentData();

        public bool CreateUser(Stud user)
        {
            bool result = false;

            if (validationServices.CheckIfUserNameExists(user.username))
            {
                result = userData.AddStud(user) > 0;
            }

            return result;
        }

        public bool CreateStud(string username, string password)
        {
            Stud user = new Stud { username = username, password = password };

            return CreateUser(user);
        }

        public bool UpdateStud(Stud user)
        {
            bool result = false;

            if (validationServices.CheckIfUserNameExists(user.username))
            {
                result = userData.UpdateStud(user) > 0;
            }

            return result;
        }

        public bool UpdateStud(string username, string password)
        {
            Stud user = new Stud { username = username, password = password };

            return UpdateStud(user);
        }

        public bool DeleteStud(Stud user)
        {
            bool result = false;

            if (validationServices.CheckIfUserNameExists(user.username))
            {
                result = userData.DeleteStud(user) > 0;
            }

            return result;
        }
    }
}
