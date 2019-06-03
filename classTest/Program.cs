using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Rectangle rect1;
             rect1.leng = 100;
             rect1.wid = 30;

             Console.WriteLine("rect leng : {0}, wid :{1}", rect1.leng, rect1.wid);

             Rectangle rect2 = new Rectangle(200,50);
             Console.WriteLine("rect leng : {0}, wid :{1}, Area :{2} ", rect2.leng, rect2.wid, rect2.Area());
             */
            
            List<Animal> animals = new List<Animal>();

            animals.Add(new Animal("fox", "Raaww"));
            animals.Add(new Animal("Wolf", "Walllll"));
            animals.Add(new Animal("bar", "GomGom"));
            animals.Add(new Animal("pig", "ddd"));


            bool bFound = false;
            foreach (var animal in animals)
            {
                var animalN = animal.getName();
                if (animalN == "pig")
                {
                    bFound = true;
                }  
            }
            if (bFound == true) Console.WriteLine("pig found");
            if (bFound != true) Console.WriteLine("no pig!");



            Animal mypig = animals.Find(item => item.getName().Equals("pig"));
            if (mypig == null)Console.WriteLine("no pig");
            else mypig.MakeSound();




            /////////////////////////////////////////
            /*  Dictionary<enAnimalType, Animal> dicAnimals = new Dictionary<enAnimalType, Animal>();

              dicAnimals.Add(enAnimalType.fox, new Animal("a", "Raaww"));
              dicAnimals.Add(enAnimalType.dog, new Animal("b", "wallllll"));
              dicAnimals.Add(enAnimalType.cat, new Animal("c", "nya"));
              foreach (KeyValuePair<enAnimalType, Animal> item in dicAnimals)
              {
                  var key = item.Key;
                  var value = item.Value;

                  value.MakeSound();
              }

              foreach (var item in dicAnimals.Values)
              {
                  item.MakeSound();
              }

              Animal outanimal;
              if (dicAnimals.TryGetValue(enAnimalType.pig, out outanimal))
              {
                  outanimal.MakeSound();
              }
              else
              {
                  Console.WriteLine("not found");
              }

              */

            /* var fox = new Animal("fox","Raaww");
             fox.MakeSound();
             var a = new Animal("Wolf","Walllll");
             a.MakeSound();
             var b = new Animal("bar","GomGom");
             b.MakeSound();*/





            /////////////////////////////////////
            ///
            /*
            Console.WriteLine("{0}", ShapeMath.GetArea(enShape.Rec,4,6));
            Console.WriteLine("{0}", ShapeMath.GetArea(enShape.Tri, 4, 6));
            Console.WriteLine("{0}", ShapeMath.GetArea(enShape.Cir, 4));
            */

            Console.ReadLine();
            



        }

        struct Rectangle
        {
            public double leng;
            public double wid;

            public Rectangle(double l,double w)
            {
                leng = l;
                wid = w;
            }

            public double Area()
            {
                return leng * wid;
            }

        }
    }
}
