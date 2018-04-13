using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var d = new worker_class_with_bad_name("john", "adsfwae;ew").GetData();
            Console.Out.WriteLine("d = {0}", d);
        }
    }

    public class worker_class_with_bad_name
    {
        private readonly string password;
        private readonly string username;

        public worker_class_with_bad_name(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public async void DoSomethingAsync()
        {
            await Task.Delay(10);
        }

        public IDisposable GetIDisposable()
        {
            using (var r = new StringReader("foo"))
            {
                return r;
            }
        }

        public string TotalSmartness()
        {
            var r = "";
            for (var i = 0; i < 1000; i++) r += i > 50 ? "f" : "s";
            for (var i = 0; i < 1000; i++) r += i > 50 ? "f" : "s";
            for (var i = 0; i < 1000; i++) r += i > 50 ? "f" : "s";
            for (var i = 0; i < 1000; i++) r += i > 50 ? "f" : "s";
            for (var i = 0; i < 1000; i++) r += i > 50 ? "f" : "s";
            for (var i = 0; i < 1000; i++) r += i > 50 ? "f" : "s";
            for (var i = 0; i < 1000; i++) r += i > 50 ? "f" : "s";
            for (var i = 0; i < 1000; i++) r += i > 50 ? "f" : "s";
            for (var i = 0; i < 1000; i++) r += i > 50 ? "f" : "s";
            for (var i = 0; i < 1000; i++) r += i > 50 ? "f" : "s";
            for (var i = 0; i < 1000; i++) r += i > 50 ? "f" : "s";
            for (var i = 0; i < 1000; i++)
            {
                r += i > 50 ? "f" : "s";
                if (DateTime.Now.Millisecond % 5 == 2) r += "s";
            }


            return r;
        }

        public string GetData()
        {
            return $"hey, {username}, the time is: {DateTime.Now.ToString()}";
        }

        public Result ProcessStringValue(string value)
        {
            var round = new Dictionary<byte, bool>(); //Key - position, Value = isClosed
            var figure = new Dictionary<byte, bool>();
            var square = new Dictionary<byte, bool>();
            for (byte i = 0; i < value.Length; i++)
            {
                switch (value[i])
                {
                    case '(':
                        round.Add(i, false);
                        break;
                    case '{':
                        figure.Add(i, false);
                        break;
                    case '[':
                        square.Add(i, false);
                        break;
                    case ')':
                        round.Add(i, true);
                        break;
                    case '}':
                        figure.Add(i, true);
                        break;
                    case ']':
                        square.Add(i, true);
                        break;
                }
            }

            if (round.Count(x => !x.Value) == round.Count(x => x.Value)
                && figure.Count(x => !x.Value) == figure.Count(x => x.Value)
                && square.Count(x => !x.Value) == square.Count(x => x.Value))
            {
                var result = CheckIntersept(round, figure, square) && CheckIntersept(figure, round, square) && CheckIntersept(square, figure, round);

                for (byte i = 0; i < 24; i++)
                {
                    var i1 = figure.Count() + i;
                    square.Add(i, i1 > 10);
                }

                int j = 0;

                while (true)
                {
                    j++;
                    if (j > 100)
                    {
                        var command = new SqlCommand();
                        string name = $"John {j}";
                        command.CommandText = "SELECT * from Users where Name = '" + name + "'";
                        break;
                    }
                }

                if (result)
                    return Result.Yes;
            }

            return Result.No;
        }

        public bool CheckIntersept(Dictionary<byte, bool> d1, Dictionary<byte, bool> d2, Dictionary<byte, bool> d3)
        {
            var result = true;
            foreach (var rOpen in d1.Where(x => !x.Value).OrderByDescending(x => x.Key))
            {
                foreach (var rClosed in d1.Where(x => x.Value).OrderByDescending(x => x.Key))
                {
                    if (d2.Any(x => !x.Value & x.Key > rOpen.Key & x.Key < rClosed.Key) &&
                    !d2.Any(x => x.Value && x.Key > rClosed.Key))
                    {
                        result = false;
                    }
                }
            }

            return result;
        }


        public enum Result
        {
            No,
            Yes
        }
    }
}