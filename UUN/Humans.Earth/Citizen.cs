using Humans.Earth.Democracy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Humans.Earth
{
    internal class Citizen : Human
    {
        internal string Town { get; set; }
        internal override string Name { get; set; }
        public Citizen(string name)
        {
            Name = name;
        }

        internal override void Speak()
        {
            Console.WriteLine($"Citizen {Name} is speaking...");
        }

        internal bool ReferendumVote(Referendum referendum)
        {
            bool vote = false;
            if (referendum.Question.Length > 15)
            {
                vote = true;
            }

            return vote;
        }
    }
}
