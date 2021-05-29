using System;
using System.Collections.Generic;
using System.Threading;

// Every class in the program is defined within the "Quest" namespace
// Classes within the same namespace refer to one another without a "using" statement
namespace Quest
{
    class Program

    {
        static void Main(string[] args)
        {

            // Make a new "Adventurer" object using the "Adventurer" class
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("What is yon name Adventurer?: ");
            string name = Console.ReadLine();
            int awesomeupgrade = 0;

            AdventureQuest(name, awesomeupgrade);


            // Console.Write($"Would you like to play again? ('Yes' or 'No') ");
            // string playAgain = Console.ReadLine().ToLower();
            // while (playAgain != "yes" && playAgain != "no")
            // {
            //     Console.Write($"Would you like to play again? ('Yes' or 'No') ");
            //     playAgain = Console.ReadLine().ToLower();
            // }


            // if (playAgain == "yes")
            // {
            //     AdventureQuest(name);
            // }
            // else
            // {
            //     Console.WriteLine("Your quest has ended! Be gone with you then... ");
            // }
        }

        static void AdventureQuest(string name, int awesomeupgrade)
        {
            // Create a few challenges for our Adventurer's quest
            // The "Challenge" Constructor takes three arguments
            //   the text of the challenge
            //   a correct answer
            //   a number of awesome points to gain or lose depending on the success of the challenge
            Challenge twoPlusTwo = new Challenge("2 + 2?", 4, 10);
            Challenge theAnswer = new Challenge(
                "What's the answer to life, the universe and everything?", 42, 25);
            Challenge whatSecond = new Challenge(
                "What is the current second?", DateTime.Now.Second, 50);

            int randomNumber = new Random().Next() % 10;

            Challenge guessRandom = new Challenge("What number am I thinking of?", randomNumber, 25);

            Challenge favoriteBeatle = new Challenge(
                @"Who's your favorite Beatle?
    1) John
    2) Paul
    3) George
    4) Ringo
",
                4, 20
            );

            // "Awesomeness" is like our Adventurer's current "score"
            // A higher Awesomeness is better

            // Here we set some reasonable min and max values.
            //  If an Adventurer has an Awesomeness greater than the max, they are truly awesome
            //  If an Adventurer has an Awesomeness less than the min, they are terrible
            int minAwesomeness = 0;
            int maxAwesomeness = 200;

            //Create a new instance of the robe class and set its properties
            Robe fuligin = new Robe();
            fuligin.Colors.Add("Darker than Black");
            fuligin.Colors.Add("Blood red trimmed");
            fuligin.Length = 42;

            Hat fedora = new Hat();
            fedora.ShininessLevel = 7;

            Prize prize = new Prize("a three day old herring");
            // prize = "a herring";



            // // Make a new "Adventurer" object using the "Adventurer" class
            // Console.Write("What is yon name Adventurer?: ");
            // string name = Console.ReadLine();

            // int correctChallenges = new int();
            // correctChallenges = 0;

            Adventurer theAdventurer = new Adventurer(name, fuligin, fedora, awesomeupgrade);
            Console.WriteLine(theAdventurer.GetDescription());
            Console.WriteLine($"Your awesomeness is {theAdventurer.Awesomeness}");
            Thread.Sleep(2000);


            // A list of challenges for the Adventurer to complete
            // Note we can use the List class here because have the line "using System.Collections.Generic;" at the top of the file.
            List<Challenge> challenges = new List<Challenge>()
            {
                twoPlusTwo,
                theAnswer,
                whatSecond,
                guessRandom,
                favoriteBeatle
            };

            List<int> randomInts = new List<int>();
            Random r = new Random();

            while (randomInts.Count < 3)
            {
                int singleInt = r.Next(challenges.Count - 1);
                if (!randomInts.Contains(singleInt))
                {
                    randomInts.Add(singleInt);
                }
            }
            // Loop through  the random challenges and subject the Adventurer to them
            for (int i = 0; i < randomInts.Count; i++)


            {

                challenges[randomInts[i]].RunChallenge(theAdventurer);
            }

            prize.ShowPrize(theAdventurer);
            Thread.Sleep(2000);


            // This code examines how Awesome the Adventurer is after completing the challenges
            // And praises or humiliates them accordingly
            if (theAdventurer.Awesomeness >= maxAwesomeness)
            {
                Console.WriteLine("YOU DID IT! You are truly awesome!");
                Console.WriteLine($"Your awesomeness is {theAdventurer.Awesomeness}");
                Thread.Sleep(2000);

            }
            else if (theAdventurer.Awesomeness <= minAwesomeness)
            {
                Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
                Console.WriteLine($"Your awesomeness is {theAdventurer.Awesomeness}");
                Thread.Sleep(2000);

            }
            else
            {
                Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
                Console.WriteLine($"Your awesomeness is {theAdventurer.Awesomeness}");
                Thread.Sleep(2000);
            }
            Console.Clear();
            Console.Write($"Would you like to play again? ('Yes' or 'No') ");
            string playAgain = Console.ReadLine().ToLower();
            while (playAgain != "yes" && playAgain != "no")
            {
                Console.Write($"Would you like to play again? ('Yes' or 'No') ");
                playAgain = Console.ReadLine().ToLower();
            }


            if (playAgain == "yes")
            {
                awesomeupgrade = theAdventurer.CorrectChallenges * 10;
                AdventureQuest(name, awesomeupgrade);

            }
            else
            {
                Console.WriteLine("Your quest has ended! Be gone with you then... ");
            }
        }
    }
}
