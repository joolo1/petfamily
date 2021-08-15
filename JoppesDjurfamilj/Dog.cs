using System;
using System.Collections.Generic;
using System.Text;

namespace JoppesDjurfamilj
{
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
            Name = name;
        }

        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }

        public override void HungryAnimal()
        {
            throw new NotImplementedException();
        }

        public override void Interact()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
