using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() =>
             {
                 Console.WriteLine("Merhaba Dünya!");
                 Thread.Sleep(2000);
                 Console.WriteLine("Merhaba Galaksi'ler");
             });
            Console.WriteLine(t.IsCompleted);
            Console.WriteLine("Merhaba Mars!");
            Thread.Sleep(3000);
            Console.WriteLine(t.IsCompleted);
        }
    }
}
