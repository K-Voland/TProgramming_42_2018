using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseApp
{
   public class Cavy : Pet
   {
      public override void NewPet()
      {
         Console.Write("Введите имя новорожденной морской свинки: ");
         Name = Console.ReadLine();
         Console.WriteLine("Введите имена родителй морской свинки: ");
         Pearent1 = Console.ReadLine();
         Pearent2 = Console.ReadLine();
         Spisok.Add(Name, new NewPet(Pearent1, Pearent2, "cavy"));
         foreach(string i in Spisok.Keys)
         {
            if(Pearent1 == i )
            {
            Spisok.Add(Pearent1, new NewPet(Name, "cavy"));
            }

            if(Pearent2 == i)
            {
            Spisok.Add(Pearent2, new NewPet(Name, "cavy"));
            }
         }
      }

      public override string GetInfo()
      {
        return $"Морская свинка: {Name} ";
      }
   }
}