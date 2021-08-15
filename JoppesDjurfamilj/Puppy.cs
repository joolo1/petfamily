namespace JoppesDjurfamilj
{
    class Puppy : Dog
    {
        public Puppy(string name, int age) : base(name, age)
        {
            Name = name;
        }

        public override void Interact()
        {
            
        }

        public override string ToString()
        {
            return name;
        }
    }
}
