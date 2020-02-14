using MinimalisticDDD.NET.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace MinimalisticDDD.NET.Core
{
    public abstract class SingleValueObject<T> : ValueObject, IComparable, ISingleValueObject
        where T : IComparable
    {
        private static readonly Type Type = typeof(T);
        private static readonly TypeInfo TypeInfo = typeof(T).GetTypeInfo();

        public T Value { get; }

        protected SingleValueObject(T value)
        {
            if (TypeInfo.IsEnum && !Enum.IsDefined(Type, value))
                throw new ArgumentException($"{value} is not defined in enum {Type}");

            Value = value;
        }

        public int CompareTo(object obj)
        {
            if (ReferenceEquals(null, obj)) throw new ArgumentNullException(nameof(obj));

            var other = (SingleValueObject<T>)obj;
            if (other == null)
                throw new ArgumentException($"Cannot compare {GetType()} and {obj.GetType()}");

            return Value.CompareTo(other.Value);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public object GetValue()
        {
            return Value;
        }
    }
}
