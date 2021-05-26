using System;
using System.Collections.Generic;
using System.Text;

namespace Humans.Earth
{
    internal abstract class Human
    {
        internal abstract string Name { get; set; }
        internal abstract void Speak();

        bool ExpressOpinion(string theme)
        {
            bool result = false;
            if (theme.Length > 100)
            {
                result = true;
            }

            return result;
        }
    }
}
