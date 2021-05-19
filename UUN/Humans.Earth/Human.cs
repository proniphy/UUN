using System;
using System.Collections.Generic;
using System.Text;

namespace Humans.Earth
{
    internal abstract class Human
    {
        bool ExpressOppinion(string theme)
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
