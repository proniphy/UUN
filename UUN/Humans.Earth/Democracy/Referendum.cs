using Humans.Earth.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Humans.Earth.Democracy
{
    struct Referendum : IElections
    {
        public string Question { get; set; }
        public List<Citizen> Electorate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Referendum(string question)
        {
            Question = question;
        }

        public void OrganizeElections()
        {
            throw new NotImplementedException();
        }
    }
}
