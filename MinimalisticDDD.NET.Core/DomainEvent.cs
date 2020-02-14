using MinimalisticDDD.NET.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinimalisticDDD.NET.Core
{
    public class DomainEvent<TAggregate, TIdentity, TAggregateEvent> : IDomainEvent<TAggregate, TIdentity, TAggregateEvent>
        where TAggregate : IAggregate<TIdentity>
        where TIdentity : IIdentity
        where TAggregateEvent : IAggregateEvent<TAggregate, TIdentity>
    {
        public TIdentity AggregateIdentity { get; }
        public TAggregateEvent AggregateEvent { get; }

        public DomainEvent(
            TIdentity aggregateIdentity,
            TAggregateEvent aggregateEvent)
        {
            if (aggregateIdentity == null) throw new ArgumentNullException(nameof(aggregateIdentity));

            AggregateIdentity = aggregateIdentity;
            AggregateEvent = aggregateEvent;
        }
    }
}
