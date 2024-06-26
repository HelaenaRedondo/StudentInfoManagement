namespace AccountManagementServices
{
    public class StudValidationServices
    {

        StudGetServices getservices = new StudGetServices();

        public bool CheckIfUserNameExists(string username)
        {
            bool result = getservices.GetUser(username) != null;
            return result;
        }

        public bool CheckIfUserExists(string username, string password)
        {
            bool result = getservices.GetUser(username, password) != null;
            return result;
        }

    }
}
