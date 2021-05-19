using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Tools.Contracts
{
    public interface IAmbassador
    {
        bool Vote();
        void Speak();
    }
}
