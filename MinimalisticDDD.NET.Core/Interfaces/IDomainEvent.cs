using System;
using System.Collections.Generic;
using System.Text;

namespace MinimalisticDDD.NET.Core.Interfaces
{
    public interface IDomainEvent
    { }

    public interface IDomainEvent<TAggregate, TIdentity> : IDomainEvent
        where TAggregate : IAggregate<TIdentity>
        where TIdentity : IIdentity
    {
        TIdentity AggregateIdentity { get; }
    }

    public interface IDomainEvent<TAggregate, TIdentity, TAggregateEvent> : IDomainEvent<TAggregate, TIdentity>
        where TAggregate : IAggregate<TIdentity>
        where TIdentity : IIdentity
        where TAggregateEvent : IAggregateEvent<TAggregate, TIdentity>
    {
        TAggregateEvent AggregateEvent { get; }
    }
}
