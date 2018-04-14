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

    }
}