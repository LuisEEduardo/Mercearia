using System;

namespace Mercearia.SharedContext
{
    public abstract class Base
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}