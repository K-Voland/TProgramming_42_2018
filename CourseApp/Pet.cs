using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseApp
{
    public abstract class Pet
    {
        public Pet() // Default constructor
        :this("Noname")
        {
        }

        public Pet(string name) // Default constructor
        :this(name, null, null)
        {
        }

        public Pet(string name, Pet parent1, Pet parent2) // Default constructor
        {
            this.Name = name;
            this.Pearent1 = parent1;
            this.Pearent2 = parent2;
        }
        public List<Pet> Childs { get; set; }

        public string Name {get; set; }

        public Pet Pearent1 {get; set; }

        public Pet Pearent2 {get; set; }

        public override string ToString()
        {
            string tostr = $"{GetInfo()} \r\n";
            if (Pearent1 != null || Pearent2 != null)
            {
                tostr += $", Родители: {Pearent1} и {Pearent2}";
            }

            if (Childs != null)
            {
                tostr += $", Дети: ";
                foreach (var j in Childs)
                {
                    tostr += $"{j} ";
                }
            }

            return tostr;
        }

        public abstract string GetInfo();
    }
}