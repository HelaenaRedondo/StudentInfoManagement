
using System;


namespace StudentInfoManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INFORMATION MANAGEMENT SYSTEM");

            InfoManageGetServ getServices = new InfoManageGetServ();
            var users = getServices.GetAllInfo();

            foreach (var item in users)
            {

                Console.WriteLine("Here's the Information:");
                Console.WriteLine("FIRSTNAME" + item.firstname);
                Console.WriteLine("MIDDLENAME:" + item.middlename);
                Console.WriteLine("LASTNAME:" + item.lastname);
                Console.WriteLine("Contact Number:" + item.contactnumber);
                Console.WriteLine("ADDRESS:" + item.address);
                Console.WriteLine("PASSWORD:" + item.password);

            }

        }
    }
}








