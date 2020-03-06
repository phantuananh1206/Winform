using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] arrayAnimal = new Animal[3];
            //Animal animal = new Animal();
            //animal.Xuat();
            Animal dog = new Dog();
            //dog.Xuat();

            Animal cat = new Cat();
            //cat.Xuat();
            //arrayAnimal[0] = animal;
            arrayAnimal[1] = dog;
            arrayAnimal[2] = cat;

            for (int i = 0; i < arrayAnimal.Length; i++)
            {
                //if (arrayAnimal[i] is Animal)
                //    arrayAnimal[i].Xuat();
                //else
                    if (arrayAnimal[i] is Dog)
                {
                    //((Dog)arrayAnimal[i]).Speak();
                    Dog d = (Dog)arrayAnimal[i];
                    d.Xuat();
                    d.Speak();
                    }
                else if (arrayAnimal[i] is Cat) { 
                    //((Cat)arrayAnimal[i]).Speak();
                    Cat c = (Cat)arrayAnimal[i];
                    c.Xuat();
                    c.Speak();
                }
            }

                Console.ReadKey();
        }
    }
}
