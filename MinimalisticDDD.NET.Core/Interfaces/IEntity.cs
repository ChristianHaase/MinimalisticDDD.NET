using System;
using System.Collections.Generic;
using System.Text;

namespace MinimalisticDDD.NET.Core.Interfaces
{
    public interface IEntity
    { }

    public interface IEntity<TIdentity> : IEntity
        where TIdentity : IIdentity
    {
        TIdentity Id { get; }
    }
}
