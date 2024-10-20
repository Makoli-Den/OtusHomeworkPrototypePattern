namespace PrototypePattern
{
    /// <summary>
    /// Класс, представляющий собаку. Наследуется от Mammal.
    /// </summary>
    public class Dog : Mammal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }

        public override IMyCloneable Clone()
        {
            return new Dog(Name, Age, Breed);
        }
    }
}
