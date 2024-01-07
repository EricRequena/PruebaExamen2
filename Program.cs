using System;
namespace PracticaExamen
{
    public class Ejercicio1
    {
        public static void Main()
        {
            const string MsgIntMinuts = "Introduce una cantidad en minutos";
            double minuts, c = 60;

            Console.WriteLine(MsgIntMinuts);
            minuts = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"La conversion es {conversion(minuts * c)} segons");
        }
        public static double conversion(double seconds)
        {
            return seconds;
        }
    }
}