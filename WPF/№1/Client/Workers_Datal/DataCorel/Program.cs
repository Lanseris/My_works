using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCorel
{
    class Program
    {
        static void Main(string[] args)
        {
            EmploeersStore a = new EmploeersStore();
            DepartmentStore b = new DepartmentStore(a);
            Console.ReadLine();
        }
    }
}
