using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseApp
{
    public class Menu
    {

        PetStore petStore;
        public Menu()
        {
            this.petStore = new PetStore();
        }

        public void MenuPets(string go)
        {
            switch (go)
            {
                case "Buy":
                    Console.WriteLine("Введите кого вы хоите купить: rabbit/cavy");
                    string type = Console.ReadLine();
                    this.petStore.CreatePet(type);
                    break;
                case "Sel":
                    Console.WriteLine("Введите кого вы хоите разводить: rabbit/cavy");
                    string type = Console.ReadLine();
                    this.petStore.CreatePet(type);

                    break;
                case "Art":
                    Art();
                    break;
                case "Inf":
                    {
                        {
                            Console.Write("Введите имя животного о котором хотите унать: ");
                            Name = Console.ReadLine();
                            NewPet rrr = Spisok[Name];
                            PetInfo(rrr, Name);
                        }
                    }

                    break;
                case "help":
                    Help();
                    break;
                case "Info":
                    int kol = 1;
                    foreach (KeyValuePair<string, NewPet> i in Spisok)
                    {
                        Console.WriteLine(kol++ + ") " + i.Value.Vid + " " + i.Key);
                    }

                    break;
                default:
                    if (go != "Stop")
                    {
                        Console.WriteLine("Такой команды не существует. help - узнать список команд.");
                    }

                    break;
            }

            Console.WriteLine("----------");
        }

        private static void Help()
        {
            Console.WriteLine(@"
           Команды:
            Stop - закончить программу;
            Art - вывести рисунок кроликов;
            Buy - купить нового кролика;
            Sel - выростить нового кролика;
            Info - узнать имена всех кроликов
            Inf - узнать о конкретном кролике
            ");
        }

        private static void Art()
        {
            Console.WriteLine(@" 
            ------/)/)------/),/)----(\__/)---(\.(\-----(\(\
            -----(':'=)----(':'=)---(=';'=)---(=':')----(=':')
            --(')('),,)-(')('),,)---(')_(')---(..(')(')-(..(')(')  ");
        }
    }
}