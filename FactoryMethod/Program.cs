using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Factory Method *************
            Amaç: Oluşturulmak istenen sınıfın kendisinden bir örnek istemek yerine Factory Metod patterni sayesinde tek bir instance üzerinden gerekli nesnenin üretilmesini sağlamaktır.
              
            Algoritmada belirli adımlarda farklı tiplerde nesnelere ihtiyaç olabilir. Bu nesneleri if-else veyahut switch yapıları aracılığıyla duruma göre oluşturabilirsiniz. Tabi bunu her seferinde yapmanın zaman ve kod açısından çok tasarruflu olduğu düşünülemez. İşte böyle durumlarda Factory Metod patterni kullanılabilir.

            Bu işlemi gerçekleştirmek için abstract class ya da interface yapıları kullanılır. Bu yapılardan faydalanmamızın sebebi bu yapılardan kalıtım alan sınıfın abstract ya da interface içerisinde elemanı mecbur uygulamak zorunda olmasıdır. Ama daha mühümi farklı tipteki nesneleri oluşturmakla ilgilenmek zorunda kalmayacak olan Base Class'ımızın(ki bu sınıftan oluşturulmasını istediğimiz nesneleri türeteceğiz) oluşturduğumuz nesneyi Polymorpism(çok biçimlilik) aracılığı ile üst bir referans türü ile işaretleyebilmektir.

            */
            Console.WriteLine("Hello World!");
        }
    }
}
