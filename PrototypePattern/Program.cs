using System;

namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Реализуем паттерн \"Прототип\"\r\n\r\n";

            Dog originalDog = new Dog("Шарик", 5, "Овчарка");
            Dog clonedDog = (Dog)originalDog.Clone();
            Dog iCloneableDog = (Dog)(originalDog as ICloneable).Clone();

            PrintDogInfo("Оригинальная собака", originalDog);
            PrintDogInfo("Клон собаки (IMyCloneable)", clonedDog);
            PrintDogInfo("Клон собаки (ICloneable)", iCloneableDog);

            originalDog.Name = "Бобик";
            Console.WriteLine($"После изменений - Оригинальная собака: {originalDog.Name}");
            Console.WriteLine($"После изменений - Клон собаки (IMyCloneable): {clonedDog.Name}");
            Console.WriteLine($"После изменений - Клон собаки (ICloneable): {iCloneableDog.Name}");

            PrintAdvantagesAndDisadvantages();

            Console.ReadKey();
        }

        static void PrintDogInfo(string title, Dog dog)
        {
            Console.WriteLine($"{title}:");
            Console.WriteLine($"  Имя: {dog.Name}");
            Console.WriteLine($"  Возраст: {dog.Age} лет");
            Console.WriteLine($"  Порода: {dog.Breed}\n");
        }

        static void PrintAdvantagesAndDisadvantages()
        {
            Console.WriteLine();
            Console.WriteLine("Преимущества и недостатки интерфейсов:");
            Console.WriteLine("IMyCloneable:");
            Console.WriteLine("  + Четкое определение клонирования с явным типом возврата.");
            Console.WriteLine("  - Не является стандартным интерфейсом .NET, может быть менее понятен для других разработчиков.\n");

            Console.WriteLine("ICloneable:");
            Console.WriteLine("  + Является стандартным интерфейсом .NET, легко используется с коллекциями.");
            Console.WriteLine("  - Возвращает object, что требует приведения типа и может вызывать проблемы с безопасностью типов.");
        }
    }
}
