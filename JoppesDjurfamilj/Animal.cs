using System;
using System.Collections.Generic;
using System.Text;

namespace JoppesDjurfamilj
{
    abstract class Animal
    {
        protected int age;
        protected string name;
        protected string favoriteFood;
        protected string breed;
        protected bool isHungry;

        public string Name { get; set; }

        protected Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public abstract void Interact();
        public abstract void Eat(string food);
        public abstract void HungryAnimal();

        public abstract override string ToString();
    }
}
