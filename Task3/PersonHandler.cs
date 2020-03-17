using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class PersonHandler
    {
        public Person CreatPerson(int age, string fName,
            string lName,double height, double weight)
        {
            return new Person()
            {
                Age=age,
                FName = fName,
                LName = lName,
                Height = height,
                Weight = weight
            };
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public void SetHeight(Person pers,double height)
        {
            pers.Height = height;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
    }
}
