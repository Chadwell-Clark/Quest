using System;
using System.Collections.Generic;


// Every class in the program is defined within the "Quest" namespace
// Classes within the same namespace refer to one another without a "using" statement
namespace Quest
{

    public class Robe
    {
        //Mutable properties
        public List<string> Colors { get; set; }
        public int Length { get; set; }

        public Robe()
        {
            Colors = new List<string>();
        }

    }
}