using System;
using System.Collections.Generic;
using System.Text;

namespace MinimalisticDDD.NET.Core.Interfaces
{
    public interface IAggregateEvent
    { }

    public interface IAggregateEvent<TAggregate, TIdentity> : IAggregateEvent
        where TAggregate : IAggregate<TIdentity>
        where TIdentity : IIdentity
    {
        
    }
}
