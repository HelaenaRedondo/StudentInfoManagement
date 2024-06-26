using AccountManagementModels;
using System.Data.SqlClient;

namespace AccountManagementData
{
    public class SqlDbData
    {
        static string connectionString
        = "Data Source =LILXX\\SQLEXPRESS; Initial Catalog = StudentInfoManagement; Integrated Security = True;";

        SqlConnection SqlConnection;

        SqlConnection sqlConnection;
        private string connection;

        public SqlDbData()
        {
            this.sqlConnection = new SqlConnection(connection);
        }
        public List<Stud> GetStudent()
        {
            string SELECT = "Select * FROM Student";

            SqlCommand selcom = new SqlCommand(SELECT, sqlConnection);

            sqlConnection.Open();
            List<Stud> stud = new List<Stud>();

            SqlDataReader read = selcom.ExecuteReader();

            while (read.Read())
            {
                string studentID = read["username"].ToString();
                string name = read["password"].ToString();
                string email = read["birthdate"].ToString();
                string phonenum = read["email"].ToString();
                string address = read["contact"].ToString();

                Stud readStudent = new Stud();
                readStudent.s_username = studentID;
                readStudent.s_name = name;
                readStudent.s_email = email;
                readStudent.s_address = address;

                stud.Add(readStudent);

            }
            sqlConnection.Close();

            return stud;
        }
        public int AddStudent(string studentID, string name, string email, string phonenum, string address)
        {
            int success;

            string INSERT = "INSERT INTO Student VALUES (@StudentID, @Name, @Email, @Phone Number, @Address)";

            SqlCommand incom = new SqlCommand(INSERT, sqlConnection);

            incom.Parameters.AddWithValue("@StudentID", studentID);
            incom.Parameters.AddWithValue("@Name", name);
            incom.Parameters.AddWithValue("@Email", email);
            incom.Parameters.AddWithValue("@Phone Number", phonenum);
            incom.Parameters.AddWithValue("@Address", address);
            sqlConnection.Close();

            success = incom.ExecuteNonQuery();

            sqlConnection.Close();

            return success;

        }

        public int UpdateStudent(string studentID, string name, string email, string phonenum, string address)
        {
            int success;

            string UPDATE = $"UPDATE Student SET Name = @Name, Email = @Email, Phone Number = @Phone Number, Address = @Address WHERE StduentID = @StudentID";


            SqlCommand upcom = new SqlCommand(UPDATE, sqlConnection);

            upcom.Parameters.AddWithValue("@Student ID", studentID);
            upcom.Parameters.AddWithValue("@Name", name);
            upcom.Parameters.AddWithValue("@Email", email);
            upcom.Parameters.AddWithValue("@Phone Number", phonenum);
            upcom.Parameters.AddWithValue("@Address", address);
            sqlConnection.Close();

            success = upcom.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

        public int DeleteStudent(string studentID)
        {
            int success;

            string DELETE = $"DELETE FROM Student WHERE StudentID = @StudentID";
            SqlCommand delcom = new SqlCommand(DELETE, sqlConnection);
            sqlConnection.Open();

            delcom.Parameters.AddWithValue("@StudentID", studentID);

            success = delcom.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

        internal int DeleteUsers(string username)
        {
            throw new NotImplementedException();
        }

        internal object UpdateUsers(string username, string password, DateTime birthdate, bool studentid, string contact)
        {
            throw new NotImplementedException();
        }

        internal int AddUsers(string username, string password, DateTime birthdate, bool studentid, string contact)
        {
            throw new NotImplementedException();
        }

        internal List<Stud> Get()
        {
            throw new NotImplementedException();
        }

        public static List<Stud> GetStud()
        {
            throw new NotImplementedException();
        }
    }
}