namespace UnicityCalculator.Internal
{
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

		internal class Key
		{
			private readonly MemberInfo _memberInfo;
			private readonly string _expressionDebugView;

			public Key(MemberInfo member, Expression expression)
			{
				_memberInfo = member;
				_expressionDebugView = expression.ToString();
			}

			protected bool Equals(Key other)
			{
				return Equals(_memberInfo, other._memberInfo) && string.Equals(_expressionDebugView, other._expressionDebugView);
			}

			public override bool Equals(object obj)
			{
				if (ReferenceEquals(null, obj)) return false;
				if (ReferenceEquals(this, obj)) return true;
				if (obj.GetType() != GetType()) return false;
				return Equals((Key)obj);
			}

			public override int GetHashCode()
			{
				unchecked
				{
					return ((_memberInfo != null ? _memberInfo.GetHashCode() : 0) * 397) ^ (_expressionDebugView != null ? _expressionDebugView.GetHashCode() : 0);
				}
			}
		}
	}
}
