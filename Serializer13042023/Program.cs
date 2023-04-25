using MySerializer;
using System;

namespace Serializer13042023
{
    class Program
    {
        static void Main()
        {
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            //Person
            string path = desktopPath + "\\" + "test.json";

            Person<int> test1 = new Person<int>();
            test1.ID = 1;
            test1.Name = "TestSubject1";

            //To file
            test1.DoSerialization(path);

            //To string
            string serializedString = test1.DoSerializationToString();
            Console.WriteLine($"Serialization result to string: {serializedString}\n");

            //From string
            var personFromString = test1.DoDeserializationFromString(serializedString);
            Console.WriteLine($"Deserialized result from string:\n{personFromString.ID}\n{personFromString.Name}\n");

            //From file
            var personFromFile = test1.DoDeserialization(path);
            Console.WriteLine($"Deserialized result from file {path}:\n{personFromFile.ID}\n{personFromFile.Name}\n");

          

            //Animal
            string path2 = desktopPath + "\\" + "test2.json";

            Animal<int> test2 = new Animal<int>();
            test2.ID = 2;
            test2.Name = "TestSubject2";
            test2.Type = "Cat";

            //To file
            test2.DoSerialization(path2);

            //To string
            string serializedString2 = test2.DoSerializationToString();
            Console.WriteLine($"Serialization result to string: {serializedString2}\n");

            //From string
            var animalFromString = test2.DoDeserializationFromString(serializedString2);
            Console.WriteLine($"Deserialized result from string:\n{animalFromString.ID}\n{animalFromString.Name}\n{animalFromString.Type}\n");

            //From file
            var animalFromFile = test2.DoDeserialization(path2);
            Console.WriteLine($"Deserialized result from file {path2}:\n{animalFromFile.ID}\n{animalFromFile.Name}\n{animalFromFile.Type}\n");
        }
    }
}
