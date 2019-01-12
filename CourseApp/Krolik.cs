using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseApp
{
   public class Krolik : Pet
   {

      public override void NewPet()
      {
         Console.Write("Введите имя новорожденного кролика: ");
         Name = Console.ReadLine();
         Console.WriteLine("Введите имена родителй кролика: ");
         Pearent1 = Console.ReadLine();
         Pearent2 = Console.ReadLine();
         Spisok.Add(Name, new NewPet(Pearent1, Pearent2, "rabbit"));
         foreach(string i in Spisok.Keys)
         {
            if(Pearent1 == i )
            {
            Spisok.Add(Pearent1, new NewPet(Name, "rabbit"));
            }

            if(Pearent2 == i)
            {
            Spisok.Add(Pearent2, new NewPet(Name, "rabbit"));
            }
         }
      }

      public override string GetInfo()
      {
        return $"Кролик: {Name} ";
      }
   }
}