using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTest
{
    class Animal
    {
        private string name;
        private string sound;

        public Animal(){}

        public Animal(string n,string a)
        {
            name = n;
            sound = a;
        }
        public void MakeSound()
        {
            Console.WriteLine("Animal name : {0}, sound : {1}",name,sound);
        }
    }
}
