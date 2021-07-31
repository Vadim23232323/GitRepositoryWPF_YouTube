using System;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace lessons_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal(2, "Tom");
            Animal dog = new Animal(4, "Charley");
            Animal[] animals = { cat, dog };

            XmlSerializer formatter = new XmlSerializer(typeof(Animal[]));

            using (FileStream fs = new FileStream("animals.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, animals);
                Console.WriteLine("Объект был сериализирован");
            }

            using (FileStream fs = new FileStream("animals.xml", FileMode.OpenOrCreate))
            {

                Animal[] newAnimals = (Animal[])formatter.Deserialize(fs);

                Console.WriteLine("Объект был десериализирован");

                foreach (Animal obj in newAnimals)
                    Console.WriteLine($"Имя: {obj.name}, возраст: {obj.age}");
            }

            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
