using System;
using System.Diagnostics;

namespace Episode41
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager logManager = new LogManager();

            logManager.LogYaz("Hello World!");
        }
    }

    public class LogManager
    {
        private Logger[] _loggers = new Logger[] { 
            new ConsoleLogger(),
            new DebugLogger(),
        };

        public void LogYaz(string mesaj)
        {
            foreach (Logger logger in _loggers)
            {
                logger.LogYaz(mesaj);
            }
        }
    }

    public abstract class Logger
    {
        public abstract string Isim { get; }
        public abstract void LogYaz(string mesaj);
    }
    public class ConsoleLogger : Logger
    {
        public override string Isim { get { return nameof(ConsoleLogger); } }
        public override void LogYaz(string mesaj)
        {
            Console.WriteLine(mesaj);
        }
    }
    public class DebugLogger : Logger
    {
        public override string Isim { get { return nameof(DebugLogger); } }
        public override void LogYaz(string mesaj)
        {
            Debug.WriteLine(mesaj);
        }
    }
}
