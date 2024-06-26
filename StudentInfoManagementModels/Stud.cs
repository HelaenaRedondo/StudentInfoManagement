using System.Globalization;

namespace AccountManagementModels
{
    public class Stud
    {
        public string username;
        public string password;
        public DateTime birthdate;
        private DateTime dateCreated = DateTime.Now;
        public DateTime dateUpdated;
        public StudentProfile profile;
        public int status;
        public bool studentid;
        public string studentname;
        public String contact;
        public String age;
        public string? s_username;
        public string? s_email;
        public string? s_address;
        public string? s_name;
    }
}