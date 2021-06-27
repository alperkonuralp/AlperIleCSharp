using System;

namespace Episode39
{
    class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();
            //a.Write("A Sınıfının Write Metodu");

            //B b = new B();
            //b.Write("B sınıfının Write Metodu");

            //A c = new B();
            //c.Write("A referansı ile B sınıfına erişiyoruz");

            //// ilk versiyon
            //ConsoleLog a = new ConsoleLog();
            // ikinci version
            FileLog a = new FileLog();

            // Sabit Kod
            WriteMessage(a);

        }

        public static void WriteMessage(ConsoleLog a)
        {
            a.Write("Sabit Mesaj");
        }
    }

    public class ConsoleLog
    {
        public virtual void Write(string msg)
        {
            Console.WriteLine(msg);
        }

        public int Get()
        {
            return new Random().Next(1, 2000);
        }
    }

    public class FileLog : ConsoleLog
    {
        public override void Write(string msg)
        {
            Console.WriteLine("B : " + msg);
        }

        new public int Get()
        {
            return new Random().Next(2001, 4000);
        }
    }
}
