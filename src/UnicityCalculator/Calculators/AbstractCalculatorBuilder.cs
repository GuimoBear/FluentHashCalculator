using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnicityCalculator.Internal;

namespace UnicityCalculator
{
    public abstract partial class AbstractCalculatorBuilder<T> : IAbstractCalculatorBuilder<T>
        where T : class
    {
        private readonly List<Func<T, object>> getters
            = new List<Func<T, object>>();

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, bool>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, bool?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, byte>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, byte?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, sbyte>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, sbyte?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, short>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, short?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, ushort>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, ushort?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, int>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, int?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, uint>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, uint?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, long>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, long?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, ulong>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, ulong?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, float>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, float?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, double>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, double?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, decimal>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, decimal?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, DateTime>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, DateTime?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, TimeSpan>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, TimeSpan?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, char>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, char?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, string?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, Guid>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractCalculatorBuilder<T> Using(Expression<Func<T, Guid?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        protected IEnumerable<object> ValuesFor(T instance)
        {
            foreach (var accessor in getters)
                yield return accessor(instance);
        }
    }
}
