using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCSharp
{
    public class Person
    {
        public string FirstName;
        public string LastName;


        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);

        }


    }
}
