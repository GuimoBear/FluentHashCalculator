using FluentHashCalculator.Contexts;
using FluentHashCalculator.Internal;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FluentHashCalculator.Benchmark.Calculators
{
    public abstract partial class AbstractHashCalculatorBuilder<T> : IAbstractHashCalculatorBuilder<T>
        where T : class
    {
        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, float>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, float?>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, double>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, double?>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, decimal>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, decimal?>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<float>>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<float?>>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<double>>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<double?>>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<decimal>>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<decimal?>>> expression, bool? ignoreError = null)
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
