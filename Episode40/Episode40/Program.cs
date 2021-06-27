using System;

namespace Episode40
{
    class Program
    {
        static void Main(string[] args)
        {
            OtvCalculation calculation = new OtvCalculation20210627();

            ShowApp(calculation);
        }

        private static void ShowApp(OtvCalculation calculation)
        {
            Console.WriteLine("Ötv Hesaplaması");
            Console.WriteLine();

            Console.Write("Araç Ham Fiyatı = ");
            double baseValue = double.Parse(Console.ReadLine());

            //double otvValue;
            //if (baseValue >= 250000.0)
            //    otvValue = baseValue * 0.55;
            //else
            //    otvValue = baseValue * 0.45;
            double otvValue = calculation.Calculate(baseValue);

            Console.WriteLine("Ötv Tutarı = " + otvValue);
        }
    }

    public class OtvCalculation
    {
        public virtual double Calculate(double baseValue)
        {
            return baseValue * 0.45;
        }
    }

    public class OtvCalculation20210101 : OtvCalculation
    {
        public override double Calculate(double baseValue)
        {
            if (baseValue >= 250000.0)
                return baseValue * 0.55;
            else
                return baseValue * 0.45;
        }
    }
    public class OtvCalculation20210627 : OtvCalculation
    {
        public override double Calculate(double baseValue)
        {
            if (baseValue >= 500000.0)
                return baseValue * 0.75;
            else if (baseValue >= 250000.0)
                return baseValue * 0.55;
            else if (baseValue >= 100000.0)
                return baseValue * 0.50;
            else
                return baseValue * 0.45;
        }
    }
}
