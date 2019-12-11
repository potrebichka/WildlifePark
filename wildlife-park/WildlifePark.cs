using System;
using WildLifePark.Models;

namespace WildLifePark 
{
    public class Program 
    {
        public static void Main() 
        {
            Console.WriteLine("Welcome to Wildlife Park!");
            ListOfAnimals listOfAnimals = new ListOfAnimals();
            while (true) 
            {
                Console.WriteLine("Enter desirable option [add/remove/track/animal list/quit]");
                
                string answer = Console.ReadLine();
                if (answer == "add") 
                {
                    Console.WriteLine("Enter species: ");
                    string species = Console.ReadLine();
                    Console.WriteLine("Enter name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter age: ");
                    int age = int.Parse(Console.ReadLine());
                    listOfAnimals.AddAnimal(species, name, age);
                } 
                else if (answer == "remove") 
                {
                    Console.WriteLine("What property do you want to use to remove animal? [id, name, species]");
                    string removeAnswer = Console.ReadLine();
                    if (removeAnswer == "id") 
                    {
                        int idToRemove = int.Parse(Console.ReadLine());
                        if (listOfAnimals.RemoveAnimalById(idToRemove))
                        {
                            Console.WriteLine("Animal with id " + idToRemove + " was deleted successfully.");
                        } 
                        else 
                        {
                            Console.WriteLine("No animals with id " + idToRemove + " were found.");
                        }
                    } 
                    else if (removeAnswer == "name") {
                        string nameToRemove = Console.ReadLine();
                        if (listOfAnimals.RemoveAnimalByName(nameToRemove))
                        {
                            Console.WriteLine("Animal with name " + nameToRemove + " was deleted successfully.");
                        } 
                        else 
                        {
                            Console.WriteLine("No animals with name " + nameToRemove + " were found.");
                        }
                    } 
                    else if (removeAnswer == "species") {
                        string speciesToRemove = Console.ReadLine();
                        if (listOfAnimals.RemoveAnimalBySpecies(speciesToRemove))
                        {
                            Console.WriteLine("Animal with species " + speciesToRemove + " was deleted successfully.");
                        } 
                        else 
                        {
                            Console.WriteLine("No animals with species " + speciesToRemove + " were found.");
                        }
                    } else {
                        Console.WriteLine("Something went wrong!");
                    }
                }
                else if (answer == "track") 
                {
                    Console.WriteLine("What property do you want to use to track animal? [id, name, species]");
                    string findAnswer = Console.ReadLine();
                    if (findAnswer == "id") 
                    {
                        int idToFind = int.Parse(Console.ReadLine());
                        Console.WriteLine(listOfAnimals.FindAnimalById(idToFind));
                    } 
                        else if (findAnswer == "name") {
                        string nameToFind = Console.ReadLine();
                        Console.WriteLine(listOfAnimals.FindAnimalByName(nameToFind));
                    } 
                    else if (findAnswer == "species") {
                        string speciesToFind = Console.ReadLine();
                        Console.WriteLine(listOfAnimals.FindAnimalsBySpecies(speciesToFind));
                    } else {
                        Console.WriteLine("Something went wrong!");
                    }
                }
                else if (answer == "animal list") 
                {
                    Console.WriteLine(listOfAnimals.GetListOfAnimals());
                } 
                else if (answer == "quit") 
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Wrong command.");
                }
            }

            Console.WriteLine("Good-Bye");
        }
    }
}