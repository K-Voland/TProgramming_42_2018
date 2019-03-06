using System;

namespace CourseApp
{
    public class Program
    {
      public static void Main()
      {
         Console.WriteLine("Волошин Константин");
         double a = 1.2;
         double b = 0.48;
         double xn = 0.7;
         double xk = 2.2;
         double dx = 0.3;
         double[] xx = {0.25, 0.36, 0.56, 0.94, 1.28 };

         Console.WriteLine("Задание А");
         for(double x = xn; x < xk; x += dx)
            {
               Console.WriteLine(Fan(x, a, b));
            }

         Console.WriteLine("Задание B");
         foreach(double x in xx)
            {
                Console.WriteLine(Fan(x, a, b));
            }

         Console.WriteLine("Задание на даты:");
         DateTime dr = new DateTime(1999, 9, 17);
         Console.WriteLine(Date.DateB(dr));

         Console.WriteLine("Кроличья ферма!");

         string go;
         Menu start = new Menu();
         do
         {
          go = Console.ReadLine();
          start.MenuPets(go);
         }
         while(go != "Stop");
      }

      private static double Fan(double x, double a, double b)
      {
         double y = ((b * b * b) + (Math.Sin(a * x) * Math.Sin(a * x))) / (Math.Acos(x * b * x) + Math.Exp(-x / 2));
         return y;
      }
   }
}