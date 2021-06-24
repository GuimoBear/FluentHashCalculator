namespace FluentHashCalculator.Internal
{
    using FluentHashCalculator.Internal.Utils;
    using System;
    using System.Collections.Concurrent;
    using System.Linq.Expressions;
    using System.Reflection;

    /// <summary>
    /// Member accessor cache.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class AccessorCache<T>
	{
		internal static readonly ConcurrentDictionary<Key, Delegate> _cache = new ConcurrentDictionary<Key, Delegate>();

		/// <summary>
		/// Gets an accessor func based on an expression
		/// </summary>
		/// <typeparam name="TProperty"></typeparam>
		/// <param name="member">The member represented by the expression</param>
		/// <param name="expression"></param>
		/// <param name="bypassCache"></param>
		/// <returns>Accessor func</returns>
		public static Func<T, TProperty> GetCachedAccessor<TProperty>(MemberInfo member, Expression<Func<T, TProperty>> expression)
		{
			if (member == null)
			{
				return expression.Compile();
			}

			var key = new Key(member, expression);
			return (Func<T, TProperty>)_cache.GetOrAdd(key, k => expression.Compile());
		}

		internal class Key : IEquatable<Key>
		{
			private readonly MemberInfo _memberInfo;
			private readonly int _hashCode;

			public Key(MemberInfo member, Expression expression)
			{
				_memberInfo = member;
				_hashCode = ExpressionEqualityComparer.Instance.GetHashCode(expression);
			}

			public bool Equals(Key other)
			{
				return !ReferenceEquals(other, null) && Equals(_memberInfo, other._memberInfo) && _hashCode == other._hashCode;
			}

			public override int GetHashCode()
			{
				unchecked
				{
					return HashCode.Combine(_memberInfo.GetHashCode(), _hashCode);
				}
			}
        }
	}
}
