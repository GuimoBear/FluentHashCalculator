using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentHashCalculator.Internal;

namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculatorBuilder<T> : IAbstractHashCalculatorBuilder<T>
        where T : class
    {
        private readonly List<Func<T, object>> getters
            = new List<Func<T, object>>();

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, bool>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, bool?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, byte>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, byte?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, sbyte>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, sbyte?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, short>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, short?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, ushort>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, ushort?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, int>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, int?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, uint>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, uint?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, long>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, long?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, ulong>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, ulong?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, float>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, float?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, double>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, double?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, decimal>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, decimal?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, DateTime>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, DateTime?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, TimeSpan>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, TimeSpan?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, char>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, char?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, string?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, Guid>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, Guid?>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<bool>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<bool?>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<byte>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<byte?>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<sbyte>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<sbyte?>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<short>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<short?>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ushort>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ushort?>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<int>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<int?>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<uint>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<uint?>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<long>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<long?>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ulong>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ulong?>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<float>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<float?>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<double>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<double?>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<decimal>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<decimal?>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<DateTime>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<DateTime?>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<TimeSpan>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<TimeSpan?>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<char>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<char?>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<string?>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<Guid>>> expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<Guid?>>> expression)
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
