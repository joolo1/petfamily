using System;
using System.Collections.Generic;
using System.Text;

namespace JoppesDjurfamilj
{
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {

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
            return name;
        }
    }
}
