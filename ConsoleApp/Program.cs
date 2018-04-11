using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new worker_class_with_bad_name().GetData();
            Console.Out.WriteLine("d = {0}", d);
        }
    }

    public class worker_class_with_bad_name
    {
        public string GetData()
        {
            return DateTime.Now.ToString();
        }
    }
}
