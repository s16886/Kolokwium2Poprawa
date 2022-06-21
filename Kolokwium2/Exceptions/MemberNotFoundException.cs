using System;

namespace Kolokwium2.Exceptions
{
    public class MemberNotFoundException : Exception
    {
        public MemberNotFoundException() : base("MemberNotFound") { }
    }
}
