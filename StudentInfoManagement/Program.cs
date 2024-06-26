using AccountManagementData;
using AccountManagementModels;
using AccountManagementServices;
using System.Security.Cryptography.X509Certificates;
using AccountManagementData;



namespace Client
{
    internal class Prog
    {
        private static object sqlDbData;

        static void Main(string[] args)
        {
            {

                List<Stud> usersFromDB = GetUsersFromDB();
                foreach (var item in usersFromDB)
                {
                    Console.WriteLine(item.username);
                    Console.WriteLine(item.password);
                    Console.WriteLine(item.studentid);
                    Console.WriteLine(item.age);
                    Console.WriteLine(item.birthdate);
                    Console.WriteLine(item.contact);

                }
            }

            //UserGetServices getServices = new UserGetServices();

            //var users = getServices.GetUersByStatus(1);

            //foreach (var item in users)
            //{
            // Console.Writeline(item.studentname);
            //Console.WriteLine(item.password);
            //}
        }

        private static List<Stud> GetUsersFromDB() => SqlDbData.GetStud();

    }
}
