using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = Singleton.ConnectionString;
            Console.WriteLine(obj.GetConnectionString());
            Console.WriteLine(obj.GetConnectionString());
            Console.WriteLine(obj.GetConnectionString());
        }


        // sealed bu class ın türetilemeyeceğini söylemek için kullanılır.
        public sealed class Singleton
        {
            private static string Conn = "XXX";

            private static Singleton obj;

            public static Singleton ConnectionString
            {
                get
                {
                    if (obj == null)
                    {
                        obj = new Singleton();
                    }
                    return obj;
                }
            }

            public string GetConnectionString()
            {
                return Conn;
            }
        }


    }
}
