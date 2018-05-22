using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;

namespace ConsoleApp
{
    public class Sut
    {
        public string Add10(int i)
        {
            return (i + 10).ToString();
        }

        public string GetAnswer(string s)
        {
            if (s == "test")
            {
                var t = s + 50;
                for (int i = 0; i < s.Length; i++)
                {
                    t += "1";
                }
                for (int i = 0; i < s.Length; i++)
                {
                    t += "2";
                }
                return t;
            }
            if (s == "foo")
            {
                var t = s + 30;
                for (int i = 0; i < s.Length; i++)
                {
                    t += "2";
                }
                for (int i = 0; i < s.Length; i++)
                {
                    t += "2";
                }
                return t;
            }
            if (s == "boo")
            {
                var t = s + 10;
                for (int i = 0; i < s.Length; i++)
                {
                    t += "3";
                }
                for (int i = 0; i < s.Length; i++)
                {
                    t += "2";
                }
                return t;
            }
            return "";
        }

        public static string foo = "foo";

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public IEnumerable<Person> GetSomeLinq()
        {
            return Enumerable.Range(1, 1000)
                    .Select(i => new Person {Age = new Random().Next(30), Name = $"Person{i}"})
                    .OrderBy(_ => _.Age)
                    .OrderBy(_ => _.Name);
        }

        public void LockCode()
        {
            lock (foo)
            {
                try
                {
                    // do something
                    try
                    {

                    }
                    catch (NullReferenceException e)
                    {
                        Console.WriteLine(e);
                    }
                }
                finally
                {
                    throw new Exception("this is bad");
                }
            }
        }

    }
}