using System;
using System.Threading;

namespace Quest
{
    // An instance of the Challenge class is an occurrence of a single challenge
    public class Challenge
    {
        // These private fields hold the "state" of an individual challenge object.
        // The values stored in these fields are not accessible outside the class,
        //  but can be used by methods or properties within the class
        private string _text;
        private int _correctAnswer;
        private int _awesomenessChange;


        // A constructor for the Challenge
        // We can tell it's a constructor because it has the same name as the class 
        //   and it doesn't specify a return type
        // Note the constructor parameters and what is done with them
        public Challenge(string text, int correctAnswer, int awesomenessChange)
        {
            _text = text;
            _correctAnswer = correctAnswer;
            _awesomenessChange = awesomenessChange;
        }

        // This method will take an Adventurer object and make that Adventurer perform the challenge
        public void RunChallenge(Adventurer adventurer)
        {
            Console.Clear();
            Console.Write($"{_text}: ");
            string answer = Console.ReadLine();
            Console.WriteLine("");

            int numAnswer;
            bool isNumber = int.TryParse(answer, out numAnswer);

            Console.WriteLine();
            if (isNumber && numAnswer == _correctAnswer)
            {
                Console.WriteLine("Well Done!");

                // Note how we access an Adventurer object's property
                adventurer.Awesomeness += _awesomenessChange;

                Console.WriteLine($"Awesomness: {adventurer.Awesomeness}");
                adventurer.CorrectChallenges++;
                Console.WriteLine($"Number Correct: {adventurer.CorrectChallenges}");
                Thread.Sleep(1800);


            }
            else
            {
                Console.WriteLine("You have failed the challenge, there will be consequences.");
                adventurer.Awesomeness -= _awesomenessChange;
                Console.WriteLine($"Awesomness: {adventurer.Awesomeness}");

                Console.WriteLine($"Number Correct: {adventurer.CorrectChallenges}");
                Thread.Sleep(1800);
            }

            // Note how we call an Adventurer object's method
            Console.WriteLine(adventurer.GetAdventurerStatus());
            Console.WriteLine();
        }
    }
}
