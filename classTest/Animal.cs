using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTest
{
    class Animal
    {

        static int numOfAnimal =0;

        private string name;
        private string sound;

        public Animal()
        {
            numOfAnimal++;
        }

        public Animal(string n,string s)
        {
            name = n;
            sound = s;
            numOfAnimal++;
        }
        public void MakeSound()
        {
            Console.WriteLine("Animal name : {0}, sound : {1} ",name,sound);
        }


        static int GetNumOfAnimal()
        {
            return numOfAnimal;
        }
    }
}
