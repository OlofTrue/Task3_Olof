using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main() //string[] args
        {
            Console.WriteLine("---- Task3 ----");

            // (1)
            //var persTest = new Person();
            //persTest.Age = 25;
            //Console.WriteLine($"age={persTest.Age}");

            // (2)
            var persHndl = new PersonHandler();
            var persTest1 = persHndl.CreatPerson(25, "Anders", "Blomquist", 175, 75.5);
            var persTest2 = persHndl.CreatPerson(35, "Christian", "Davidsson", 185, 95.5);

            persHndl.SetAge(persTest1, 26);
            persHndl.SetAge(persTest2, 36);
            Console.WriteLine($"age1={persTest1.Age} , age2={persTest2.Age}");

            // (3.2)
            //  (F8) Bird
            //  (F9) Animal

            // (3.3)
            var animalTest = new Animal("generic");
            Console.WriteLine($"animal prop = [{animalTest.Stats()}]");
            var dogTest = new Dog();
            Console.WriteLine($"dog prop = [{dogTest.Stats()}]");

            var animals = new List<Animal>()
            {
                new Animal("Human") { Age = 55, Length = 177.5, Weight = 70 },
                new Dog() { Age = 2, Length = 47.5, Weight = 12, IsHouseTrained = true }
            };
            Console.WriteLine();
            Console.WriteLine($"-----list of animals---------");
            foreach (var animal in animals)
            {
                Console.WriteLine($" [{animal.Stats()}]");
            }
            Console.WriteLine();
            var dogs = new List<Dog>()
            {
                new Dog() { Age = 1, Length = 27.5, Weight = 4, IsHouseTrained = false }
            };
            Console.WriteLine($"-----list of dogs---------");
            foreach (var dog in dogs)
            {
                Console.WriteLine($" [{dog.Stats()}]");
            }
            //dogs.Add(new Dog());
            //dogs.Add(new Horse());


            // (F7) inkompatibla klasser - Error CS1503  Argument 1: cannot convert from 'Task3.Horse' to 'Task3.Dog'
            // (F8) List<Animal>

            // (F11) skriver ut samtliga tillängliga properties (+ aktuellt värde) för alla poster i listan

            //Console.WriteLine($" [{dogTest.ReturnString("har metod ReturnString")}]");

            // (F15) Animal-klass saknar metod / arv sker åt motsatt håll
            Console.WriteLine();
            Console.WriteLine($"---------animal as Dog----------");
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.NameOfSpecies} : {(animal as Dog)?.ReturnString("har metod ReturnString")}");
            }

        }
    }
}
