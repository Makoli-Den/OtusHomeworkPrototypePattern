namespace PrototypePattern
{
    /// <summary>
    /// Базовый класс, представляющий животное.
    /// </summary>
    public class Animal : IMyCloneable, ICloneable
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual IMyCloneable Clone()
        {
            return new Animal(Name);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
