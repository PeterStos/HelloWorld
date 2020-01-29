using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void MultipleLegs(PetStruct petStruct, PetClass petClass)
        {
            petStruct.Legs = petStruct.Legs * 2;
            petClass.Legs = petClass.Legs * 2;

            Console.WriteLine("Internal Method - A " + petStruct.Type + " has " + petStruct.Legs + " Legs.");
            Console.WriteLine("Internal Method - A " + petClass.Type + " has " + petClass.Legs + " Legs.");
        }
        static void Main(string[] args)
        {
            // Start of the block Arrays and collections
            int[] intArray = new int[5];
            string[] stringArray = new string[5];

            int[] populatedArray = new int[] {0, 1, 2, 3, 4, 5};
            string[] populatedStringArray = new string[] { "One", "Two", "Three" };

            intArray[0] = 5;
            intArray[2] = 15;

            int firstValue = intArray[0];

            int[,] multiInt = new int[2,3]; //  2 in the first column, 3 in the second
            int[,] multiPopulatedInt = { {1, 2, 3}, {5, 6, 7} };

            int firstMultiValue = multiPopulatedInt[0, 0]; // value would be 1
            int secondMultiValue = multiPopulatedInt[1, 2]; // value 7

            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("fist String"); // add to the end of List
            listOfStrings.Insert(0, "Inserted String"); // insert based on index
            listOfStrings.Remove("first String"); // removing based on content
            listOfStrings.Remove("0"); // removing based in index

            listOfStrings.Sort();
            var theFirstString = listOfStrings[0];

            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("James", "Bond");
            names.Add("Money", "Penny");
            names.Remove("James");
            // End of the block Arrays and collections
            
            PetStruct dog = new PetStruct();
            dog.Type = PetType.Dog;
            dog.HasFur = true;
            dog.Legs = 4;

            PetClass duck = new PetClass();
            duck.Type = PetType.Duck;
            duck.HasFur = false;
            duck.Legs = 2;

            Console.WriteLine("A " + dog.Type + " has " + dog.Legs + " legs.");
            Console.WriteLine("A " + duck.Type + " has " + duck.Legs + " legs.");

            MultipleLegs(dog, duck);
            Console.WriteLine("A " + dog.Type + " has " + dog.Legs + " legs.");
            Console.WriteLine("A " + duck.Type + " has " + duck.Legs + " legs.");

            Console.ReadLine();
        }
    }

    class PetClass
    {
        public int Legs;
        public PetType Type;
        public string Name;
        public bool HasFur;
    }

    struct PetStruct
    {
        public int Legs;
        public PetType Type;
        public string Name;
        public bool HasFur;
    }

    enum PetType 
    { 
        Dog, Duck 
    }
}
