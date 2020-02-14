using MinimalisticDDD.NET.Interfaces;

namespace MinimalisticDDD.NET.Core
{
    public class Aggregate<TIdentity> : IAggregate<TIdentity> where TIdentity : IIdentity
    {
        public TIdentity Id { get; }
    }
}
