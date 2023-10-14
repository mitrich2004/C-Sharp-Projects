using System;

namespace ContosoPets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the ourAnimals array will store the following: 
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";
            string suggestedDonation = "";

            // variables that support data entry
            int maxPets = 8;
            string readResult;
            string menuSelection = "";
            decimal decimalDonation = 0.00m;

            // array used to store runtime data, there is no persisted data
            string[,] ourAnimals = new string[maxPets, 7];

            // create some initial ourAnimals array entries
            for (int i = 0; i < maxPets; i++)
            {
                switch (i)
                {
                    case 0:
                        animalSpecies = "dog";
                        animalID = "d1";
                        animalAge = "2";
                        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                        animalNickname = "lola";
                        suggestedDonation = "85.00";
                        break;
                    case 1:
                        animalSpecies = "dog";
                        animalID = "d2";
                        animalAge = "9";
                        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        animalNickname = "loki";
                        suggestedDonation = "49.99";
                        break;
                    case 2:
                        animalSpecies = "cat";
                        animalID = "c3";
                        animalAge = "1";
                        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                        animalPersonalityDescription = "friendly";
                        animalNickname = "Puss";
                        suggestedDonation = "40.00";
                        break;
                    case 3:
                        animalSpecies = "cat";
                        animalID = "c4";
                        animalAge = "?";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        suggestedDonation = "";
                        break;
                    default:
                        animalSpecies = "";
                        animalID = "";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        suggestedDonation = "";
                        break;
                }

                ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Species: " + animalSpecies;
                ourAnimals[i, 2] = "Age: " + animalAge;
                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

                if (!decimal.TryParse(suggestedDonation, out decimalDonation))
                {
                    decimalDonation = 45.00m;
                }

                ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
            }

            do
            {
                // display the top-level menu options
                Console.Clear();

                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. List all of our current pet information");
                Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
                Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
                Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
                Console.WriteLine(" 5. Edit an animal’s age");
                Console.WriteLine(" 6. Edit an animal’s personality description");
                Console.WriteLine(" 7. Display all cats with a specified characteristic");
                Console.WriteLine(" 8. Display all dogs with a specified characteristic");
                Console.WriteLine();
                Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

                readResult = Console.ReadLine();

                if (readResult != null)
                {
                    menuSelection = readResult.ToLower();
                }
                
                switch (menuSelection)
                {
                    case "1":
                        // List all of our current pet information
                        for (int i = 0; i < maxPets; ++i)
                        {
                            if (ourAnimals[i, 0] != "ID #: ")
                            {
                                Console.WriteLine();
                                for (int j = 0; j < 7; ++j)
                                {
                                    Console.WriteLine(ourAnimals[i, j]);
                                }
                            }
                        }
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    case "2":
                        // Add a new animal friend to the ourAnimals array
                        string anotherPet = "y";
                        int petCount = 0;
                        for (int i = 0; i < maxPets; ++i)
                        {
                            if (ourAnimals[i, 0] != "ID #: ")
                            {
                                petCount += 1;
                            }
                        }

                        if (petCount < maxPets)
                        {
                            Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
                        }

                        while (anotherPet == "y" && petCount < maxPets)
                        {
                            bool validEntry = false;

                            do
                            {
                                Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                                readResult = Console.ReadLine();

                                if (readResult != null)
                                {
                                    animalSpecies = readResult.Trim().ToLower();

                                    if (animalSpecies == "cat" || animalSpecies == "dog")
                                    {
                                        validEntry = true;
                                    }
                                }
                            } while (!validEntry);

                            animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                            validEntry = false;
                            do
                            {
                                int petAge; 

                                Console.WriteLine("Enter the pet's age or enter ? if unknown");
                                readResult = Console.ReadLine();

                                if (readResult != null)
                                {
                                    animalAge = readResult;

                                    if (animalAge != "?")
                                    {
                                        validEntry = int.TryParse(animalAge, out petAge);
                                    }
                                    else
                                    {
                                        validEntry = true;
                                    }
                                }
                            } while (!validEntry);

                            do
                            {
                                Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalPhysicalDescription = readResult.Trim().ToLower();
                                       
                                    if (animalPhysicalDescription == "")
                                    {
                                        animalPhysicalDescription = "tbd";
                                    }
                                }
                            } while (animalPhysicalDescription == "");

                            do
                            {
                                Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalPersonalityDescription = readResult.Trim().ToLower(); 

                                    if (animalPersonalityDescription == "")
                                    {
                                        animalPersonalityDescription = "tbd";
                                    }
                                }
                            } while (animalPersonalityDescription == "");

                            do
                            {
                                Console.WriteLine("Enter a nickname for the pet");
                                readResult = Console.ReadLine();

                                if (readResult != null)
                                {
                                    animalNickname = readResult.Trim().ToLower();

                                    if (animalNickname == "")
                                    {
                                        animalNickname = "tbd";
                                    }
                                }
                            } while (animalNickname == "");

                            ourAnimals[petCount, 0] = "ID #: " + animalID;
                            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                            ourAnimals[petCount, 2] = "Age: " + animalAge;
                            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;
                            
                            petCount += 1;

                            if (petCount < maxPets)
                            {
                                Console.WriteLine("Do you want to enter info for another pet (y/n)");

                                do
                                {
                                    readResult = Console.ReadLine();
                                    if (readResult != null)
                                    {
                                        anotherPet = readResult.Trim().ToLower();
                                    }
                                } while (anotherPet != "y" && anotherPet != "n");
                            }
                        }

                        if (petCount >= maxPets)
                        {
                            Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                            Console.WriteLine("Press the Enter key to continue.");
                            readResult = Console.ReadLine();
                        }

                        break;
                    case "3":
                        // Ensure animal ages and physical descriptions are complete
                        for (int i = 0; i < maxPets; ++i)
                        {
                            if (ourAnimals[i, 0] != "ID #: ")
                            {
                                if (ourAnimals[i, 2] == "Age: ?")
                                {
                                    int petAge = 0;
                                    bool validResult = false;
                                    do
                                    {
                                        Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
                                        readResult = Console.ReadLine();

                                        if (readResult != null)
                                        {
                                            validResult = int.TryParse(readResult, out petAge);
                                        }

                                    } while (!validResult);

                                    ourAnimals[i, 2] = "Age: " + petAge.ToString();
                                }

                                if (ourAnimals[i, 4] == "Physical description: " || ourAnimals[i, 4] == "Physical description: tbd")
                                {
                                    bool validResult = false;
                                    do
                                    {
                                        Console.WriteLine($"Enter a physical description for {ourAnimals[i, 0]} (size, color, breed, gender, weight, housebroken)");
                                        readResult = Console.ReadLine();

                                        if (readResult != null)
                                        {
                                            animalPhysicalDescription = readResult.Trim().ToLower();

                                            validResult = animalPhysicalDescription != "";
                                        }

                                    } while (!validResult);

                                    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                                }
                            }
                        }
                        Console.WriteLine("Age and physical description fields are complete for all of our friends.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    case "4":
                        // Ensure animal nicknames and personality descriptions are complete
                        for (int i = 0; i < maxPets; ++i)
                        {
                            if (ourAnimals[i, 0] != "ID #: ")
                            {
                                if (ourAnimals[i, 3] == "Nickname: " || ourAnimals[i, 3] == "Nickname: tbd")
                                {
                                    bool validResult = false;
                                    do
                                    {
                                        Console.WriteLine($"Enter a nickname for {ourAnimals[i, 0]}");
                                        readResult = Console.ReadLine();

                                        if (readResult != null)
                                        {
                                            animalNickname = readResult.Trim().ToLower();

                                            validResult = animalNickname != "";
                                        }

                                    } while (!validResult);

                                    ourAnimals[i, 3] = "Nickname: " + animalNickname;
                                }

                                if (ourAnimals[i, 5] == "Personality: " || ourAnimals[i, 5] == "Personality: tbd")
                                {
                                    bool validResult = false;
                                    do
                                    {
                                        Console.WriteLine($"Enter a personality description for {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level)");
                                        readResult = Console.ReadLine();

                                        if (readResult != null)
                                        {
                                            animalPersonalityDescription = readResult.Trim().ToLower();

                                            validResult = animalPersonalityDescription != "";
                                        }

                                    } while (!validResult);

                                    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
                                }
                            }
                        }
                        Console.WriteLine("Nickname and personality description fields are complete for all of our friends.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    case "5":
                        //Edit an animal's age
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    case "6":
                        //Edit an animal's personality description
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    case "7":
                        //Display all cats with a specified characteristic
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    case "8":
                        //Display all dogs with a specified characteristic
                        string dogCharacteristic = "";

                        while (dogCharacteristic == "")
                        {
                            Console.WriteLine($"\nEnter one desired dog characteristics to search for");
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                dogCharacteristic = readResult.Trim().ToLower();
                            }
                        }

                        string dogDescription = "";
                        bool noMatchesFound = true;

                        for (int i = 0; i < maxPets; ++i)
                        {
                            if (ourAnimals[i, 1].Contains("dog"))
                            {
                                dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];

                                if (dogDescription.Contains(dogCharacteristic))
                                {
                                    noMatchesFound = false;

                                    Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match!");
                                    Console.WriteLine(dogDescription);
                                }
                            }
                        }

                        if (noMatchesFound)
                        {
                            Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristic);
                        }

                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                }

            } while (menuSelection != "exit");
        }
    }
}
