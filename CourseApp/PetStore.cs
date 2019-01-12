using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseApp
{
    public class PetStore
    {
        public Pet CreatePet(string type)
        {
            if (type == "Rabbit") //use switch case instead
            {
                return new Krolik();
            }
            else if (type == "Cavy")
            {
                return new Cavy();
            }

        }

        // public Pet NewPet() // пока это не потребуется - и логика в buy Pet будет существовать
        // {

        // }
    }
}