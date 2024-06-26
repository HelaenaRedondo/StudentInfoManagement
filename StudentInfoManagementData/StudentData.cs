using AccountManagementData;
using AccountManagementModels;

namespace AccountManagementData
{
    public class StudentData
    {
        List<Stud> studentdata;
        SqlDbData sqlData;
        public StudentData()
        {
            studentdata = new List<Stud>();
            sqlData = new SqlDbData();

            //UserFactory _userFactory = new UserFactory();
            //users = _userFactory.GetDummyUsers();
        }

        public List<Stud> GetUsers()
        {
            studentdata = sqlData.Get();
            return studentdata;
        }

        public int AddStud(Stud user)
        {

            return sqlData.AddUsers(user.username, user.password, user.birthdate, user.studentid, user.contact);
        }

        public int UpdateUser(Stud user)
        {
            return NewMethod(user);
        }

        private int NewMethod(Stud user)
        {
            return (int)NewMethod1(user);
        }

        private object NewMethod1(Stud user)
        {
            return sqlData.UpdateUsers(user.username, user.password, user.birthdate, user.studentid, user.contact);
        }

        public int DeleteStud(Stud user) => sqlData.DeleteUsers(user.username);

        public int UpdateStud(Stud user)
        {
            throw new NotImplementedException();
        }
    }
}
