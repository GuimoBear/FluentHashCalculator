using FluentHashCalculator.Contexts;
using FluentHashCalculator.Internal;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculatorBuilder<T> : IAbstractHashCalculatorBuilder<T>
        where T : class
    {
        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, byte>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, byte?>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, sbyte>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, sbyte?>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, short>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, short?>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, ushort>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, ushort?>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, int>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, int?>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, uint>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, uint?>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, long>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, long?>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, ulong>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, ulong?>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<byte>>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<byte?>>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<sbyte>>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<sbyte?>>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<short>>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<short?>>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ushort>>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ushort?>>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<int>>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<int?>>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<uint>>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<uint?>>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<long>>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<long?>>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ulong>>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ulong?>>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value });
            return this;
        }
    }
}
