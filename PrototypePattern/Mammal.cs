namespace PrototypePattern
{
    /// <summary>
    /// Класс, представляющий млекопитающих. Наследуется от Animal.
    /// </summary>
    public class Mammal : Animal
    {
        public int Age { get; set; }

        public Mammal(string name, int age) : base(name)
        {
            Age = age;
        }

        public override IMyCloneable Clone()
        {
            return new Mammal(Name, Age);
        }
    }
}
