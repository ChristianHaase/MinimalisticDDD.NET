using MinimalisticDDD.NET.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinimalisticDDD.NET.Core
{
    public class Entity<TIdentity> : ValueObject, IEntity<TIdentity>
        where TIdentity : IIdentity
    {
        public TIdentity Id { get; }

        protected Entity(TIdentity id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            Id = id;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Id;
        }
    }
}
