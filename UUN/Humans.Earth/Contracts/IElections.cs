using System;
using System.Collections.Generic;
using System.Text;

namespace Humans.Earth.Contracts
{
    interface IElections
    {
        List<Citizen> Electorate { get; set; }

        void OrganizeElections();
    }
}
