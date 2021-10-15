using System;

namespace FactoryMethod
{
    class Program
    {
        /* Factory Method *************
           Amaç: Oluşturulmak istenen sınıfın kendisinden bir örnek istemek yerine Factory Metod patterni sayesinde tek bir instance üzerinden gerekli nesnenin üretilmesini sağlamaktır.

           Algoritmada belirli adımlarda farklı tiplerde nesnelere ihtiyaç olabilir. Bu nesneleri if-else veyahut switch yapıları aracılığıyla duruma göre oluşturabilirsiniz. Tabi bunu her seferinde yapmanın zaman ve kod açısından çok tasarruflu olduğu düşünülemez. İşte böyle durumlarda Factory Metod patterni kullanılabilir.

           Bu işlemi gerçekleştirmek için abstract class ya da interface yapıları kullanılır. Bu yapılardan faydalanmamızın sebebi bu yapılardan kalıtım alan sınıfın abstract ya da interface içerisinde elemanı mecbur uygulamak zorunda olmasıdır. Ama daha mühümi farklı tipteki nesneleri oluşturmakla ilgilenmek zorunda kalmayacak olan Base Class'ımızın(ki bu sınıftan oluşturulmasını istediğimiz nesneleri türeteceğiz) oluşturduğumuz nesneyi Polymorpism(çok biçimlilik) aracılığı ile üst bir referans türü ile işaretleyebilmektir.
           */

        static void Main(string[] args)
        {
            Creater creater = new Creater();
            Game xboxGame = creater.FactoryMethod(PlatformType.XBOX);
            Game pcGame = creater.FactoryMethod(PlatformType.PC);
            Game psGame = creater.FactoryMethod(PlatformType.PS);

            xboxGame.Platform();
            pcGame.Platform();
            psGame.Platform();

            Console.Read();
        }

        abstract class Game
        {
            public abstract void Platform();
        }

        class XBox : Game
        {
            public override void Platform()
            {
                Console.WriteLine("Bu oyun XBOX platformunda çalışmaktadır.");
            }
        }

        class PC : Game
        {
            public override void Platform()
            {
                Console.WriteLine("Bu oyun PC platformunda çalışmaktadır.");
            }
        }

        class PS : Game
        {
            public override void Platform()
            {
                Console.WriteLine("Bu oyun PS platformunda çalışmaktadır.");
            }
        }

        //Bu sınıflardan nesne üretecek olan Creater sınıfını oluşturalım ve içerisine Factory işlemini yapacak metodumuzu tanımlayalım.  
        // Burada her bir oyun türü Game abstract sınıfından kalıtım alınmasından dolayı çok biçimlilik kullanılarak Game referansında tutulabilmekte ve geriye döndürülmektedir. 
        class Creater
        {
            public Game FactoryMethod(PlatformType platformType)
            {
                Game game = null;

                switch (platformType)
                {
                    case PlatformType.XBOX:
                        game = new XBox();
                        break;
                    case PlatformType.PC:
                        game = new PC();
                        break;
                    case PlatformType.PS:
                        game = new PS();
                        break;
                }
                return game;
            }
        }

        enum PlatformType
        {
            XBOX,
            PC, // bilgisayar
            PS // play station
        }

    }
}