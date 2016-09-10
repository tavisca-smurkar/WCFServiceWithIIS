using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceIISClient
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeServiceClient client = new EmployeeServiceClient();
            Console.WriteLine(client.GetEmployee("1").Name);
            client.Close();
        }
    }
}
