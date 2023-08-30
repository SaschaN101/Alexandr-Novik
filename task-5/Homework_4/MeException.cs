using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class MeException : Exception
    {
        public MeException(string message) : base(message) { }
    }
}
