using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.WriteLine("Type: Yes or No?");
            string noiseChoice = Console.ReadLine().ToUpper();
            if (noiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if we do't leave our room!\n THE END.");
            }
            else
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");

                Console.WriteLine("Select Open or Knock");
                string doorChoice = Console.ReadLine().ToUpper();
                if (doorChoice == "KNOCK")
                {
                    Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"\"Poor people have it. Rich people need it. If you eat you die. What is is?");
                    Console.WriteLine("Type your answer: ");
                    string riddleAnswer = Console.ReadLine().ToUpper();
                    if (riddleAnswer == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door.\n THE END");
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open.\n THE END");
                    }
                }
                else
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it");
                    Console.WriteLine("Enter a number (1 - 3): ");
                    string keyChoice = Console.ReadLine().ToUpper();

                    switch (keyChoice)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky Choice!! The door opens and NOTHING is there. Strange...\nTHE END.");
                            break;
                        case "2":
                            Console.WriteLine("You choose the second key. The door doesn't open\nTHE END.");
                            break;
                        case "3":
                            Console.WriteLine("You choose the third key. The door doesn't open\nTHE END.");
                            break;
                    }
                }
            }
        }
    }
}
