using MinimalisticDDD.NET.Interfaces;
using System;

namespace MinimalisticDDD.NET.Core
{
    public abstract class Identity<T> : SingleValueObject<Guid>, IIdentity
        where T : Identity<T>
    {
        protected Identity(Guid value) : base(value)
        { }

        public static T New => With(Guid.NewGuid());

        public static T With(Guid value)
        {
            return (T)Activator.CreateInstance(typeof(T), value);
        }
    }
}
