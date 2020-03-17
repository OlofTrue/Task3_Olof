using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Animal
    {
        public Animal(string name)
        {
            this.NameOfSpecies = name;
        }
        public int Age { get; set; }
        public string NameOfSpecies { get; private set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public virtual string Stats(Object obj = null)
        {
            if (obj is null) obj = this;
            var result = new StringBuilder();
            foreach (var prop in this.GetType().GetProperties())
            {
                result.Append(prop.Name + "=");
                result.Append(prop.GetValue(obj,null) + ";");
            }
            return (result.ToString()+";").Replace(";;","");
        }
        //=> this.GetType().GetProperties().ToString();
    }



    class Horse: Animal
    {
        public Horse(string name="Horse") : base(name) {}
        public Boolean IsPony { get; set; }

        public override string Stats(Object obj = null) => base.Stats(this);
    }

    class Dog : Animal
    {
        public string ReturnString(String s) => s;
        public Dog(string name="Dog") : base(name) { }
        public Boolean IsHouseTrained { get; set; }
        public override string Stats(Object obj = null) => base.Stats(this);
    }
    class Hedgehog : Animal
    {
        public Hedgehog(string name="Hedgehog") : base(name) { }
        public int NrOfSpikes { get; set; }
        public override string Stats(Object obj = null) => base.Stats(this);
    }
    class Worm : Animal
    {
        public Worm(string name="Worm") : base(name) { }
        public Boolean IsPoisonous { get; set; }
        public override string Stats(Object obj = null) => base.Stats(this);
    }
    class Bird : Animal
    {
        public Bird(string name="Bird") : base(name) { }
        public double WingSpan { get; set; }
        public override string Stats(Object obj = null) => base.Stats(this);
    }

    class Pelican : Bird
    {
        public Pelican() : base("Pelican") { }
        public Boolean NestInTree { get; set; }
    }
    class Flamingo : Bird
    {
        public Flamingo() : base("Flamingo") { }
        public Boolean HasPinkColor { get; set; }
    }
    class Swahn : Bird
    {
        public Swahn() : base("Swahn") { }
        public Boolean IsBlack { get; set; }
    }

    // (8) Bird
    // (9) Animal
}
