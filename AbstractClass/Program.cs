using System;

namespace AbstractClass
{
    class Program
    {
        /* 
        => Abstraction(Soyutlama) :  iç detayları gizleyerek sadece işlevleri göstermeye denir.   
        - Sınıf hiyerarşisinde genellikle base class tanımlamak için kullanılan ve soyutlama yeteneği kazandıran sınıflardır. İçerisinde en az bir abstract metod kullanmak best practice dır.
        - abstract sınıfları genellikle kalıtım uygularken kullanırız.
        - new anahtar sözcüğü ile nesneleri oluşturulamaz. 
        - içerisinde metod ve değişken bulundurabilir.
        - abstract sınıflardan türetilen sınıfların abstract metodları implemente etmesi zorunludur. Diğer metodları override etmeden de kullanabilir.
        - constructors ve deconstructors bulundurabilirler.
        - static tanımlanamazlar. 
        - bir sınıf yalnızca bir abstract sınıfı implemente edebilir. çoklu kalıtım desteklenmez.
        - abstract olmayan metodları da bulundurabilir.
        
         */

        static void Main(string[] args)
        {
            G obj1;
            obj1 = new G1();
            obj1.gfg1();
            obj1 = new G2();
            obj1.gfg1();

            MyClass obj2 = new MyClass();
            obj2.Show();

        }


        // abstract sınıf
        public abstract class G
        {
            // abstract metod
            public abstract void gfg1();
        }


        public class G1 : G
        {
            public override void gfg1()
            {
                Console.WriteLine("Class name is G1");
            }
        }

        public class G2 : G
        {
            public override void gfg1()
            {
                Console.WriteLine("Class name is G2");
            }
        }

        interface Interface1
        {
            void Show();
        }

        class MyClass : Interface1
        {
            public void Show()
            {
                Console.WriteLine("Hello! My name is Mehmet");
            }
        }
    }
}
