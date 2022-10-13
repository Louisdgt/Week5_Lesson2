using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Week5_Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 12, 15, 10, 9, 90, 34, 28, 89, 23, 21, 56, 34, 92, 11, 2, 4, 66, 78, 88, 99, 24 };
            int[] agestrié=new int[ages.Length];
            int test = ages[0];
            int position = 0;
            int j = 0;
            for(int i=0;i<ages.Length; i++)
            {
                if (test < ages[i])
                {
                    test = ages[i];
                    position = i;
                    agestrié[j] = test;
                    
                }
                if (i == ages.Length - 1 && j<agestrié.Length)
                {
                    test = -1;
                    ages[position] = -1;
                    j++;
                    if(j<agestrié.Length)
                    {
                        i = 0;
                    }
                }
                
            }
            for(int w=0;w<ages.Length-1;w++)
            {
                Console.WriteLine(agestrié[w]);
            }
            Console.WriteLine("Suite");
            Console.WriteLine("");
            position = 0;
            test= ages[0];
            ages[0] = 100;
            j = 0;
            for (int i = 0; i < ages.Length; i++)
            {
                if (test < ages[i])
                {
                    test = ages[i];
                    position = i;
                    agestrié[j] = test;

                }
                if (i == ages.Length - 1 && j < agestrié.Length)
                {
                    test = -1;
                    ages[position] = -1;
                    j++;
                    if (j < agestrié.Length)
                    {
                        i = 0;
                    }
                }
            }
            for (int w = 0; w < ages.Length-1; w++)
            {
                Console.WriteLine(agestrié[w]);
            }

            //Prof
            var ageGrThn35 = ages.Where(age => age > 35).OrderByDescending(age => age).Select(age => age);
            foreach(var age in ageGrThn35)
            {
                Console.Write(age + " ; ");
            }
            Console.WriteLine();
            //FinPro
            ArrayList famAnimals = new ArrayList()
            {
                new Animal{Name="Heidi",Height=.8,Weight=18},
                new Animal
                {
                    Name ="Shrek",
                    Height=4,
                    Weight=130,

                },
                new Animal
                {
                    Name="Congo",
                    Height=3.8,
                    Weight=90,
                }
            };
            var famAnimalEnum = famAnimals.OfType<Animal>();
            var smallAnimals = from animal in famAnimalEnum
                               where animal.Weight<=90
                               orderby animal.Name
                               select animal;
            foreach(var animal in smallAnimals)
            {
                Console.WriteLine(animal.ToString());
            }
            var animalList =new List<Animal>()
            {
                new Animal { Name="German Shepherd",Height=25,Weight=77},
                new Animal { Name="Chihuahua",Height=30,Weight=200},
                new Animal{Name="Saint Bernard",Height=30,Weight=200}
            };
            var bigDogs = from dog in animalList
                          where (dog.Weight > 70) && (dog.Height > 25)
                          orderby dog.Name
                          select dog;
            foreach (var dog in bigDogs)
            {
                Console.WriteLine("A {0} weighs {1}lbs", dog.Name, dog.Weight);
            }
            string[] dogs = { "K 9", "Brian Griffin", "Scooby Doo", "Old Yeller", "Rin Tin Tin", "Benji", "Charlie B. Barkin", "Lassie", "Snoopy" };
            var dogWithSpaceInName = from dog in dogs
                                     where dog.Contains(" ")
                                     select dog;
            var dogWithSpaceInName_lambda = dogs.Where(dog => dog.Contains(" ")).Select(dog => dog);
            foreach (var dog in dogWithSpaceInName)
            {
                Console.Write(dog + " ; ");
            }
            Console.WriteLine();
            foreach(var dog in dogWithSpaceInName_lambda)
            {
                Console.WriteLine(dog + " ; ");
            }
            Console.ReadLine();
        }
    }
}
