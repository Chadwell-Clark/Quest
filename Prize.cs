using System;

namespace Quest


{
    public class Prize
    {
        private string _text { get; set; }

        public Prize(string prize)
        {
            _text = prize;
        }

        public void ShowPrize(Adventurer adventurer)
        {
            Console.WriteLine("You Win ...");
            if (adventurer.Awesomeness > 0)
            {
                for (int i = 0; i <= adventurer.Awesomeness; i++)
                {
                    Console.WriteLine(_text);
                }
            }
            else
            {
                Console.WriteLine("You are a scourge to the face of the earth and the creatures therewithin!!");
            }

        }
    }
}