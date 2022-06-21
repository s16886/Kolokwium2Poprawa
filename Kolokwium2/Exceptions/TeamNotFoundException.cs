using System;

namespace Kolokwium2.Exceptions
{
    public class TeamNotFoundException : Exception
    {
        public TeamNotFoundException() : base("TeamNotFound") { }
    }
}
