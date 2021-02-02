using FluentHashCalculator.Contexts;
using FluentHashCalculator.Internal;
using Microsoft.IO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace FluentHashCalculator.Benchmark.Calculators
{
    public abstract partial class AbstractHashCalculatorBuilder<T> : IAbstractHashCalculatorBuilder<T>
        where T : class
    {
        protected static readonly RecyclableMemoryStreamManager manager = new RecyclableMemoryStreamManager();

        private readonly List<Func<T, object>> getters
            = new List<Func<T, object>>();
        private readonly Dictionary<int, SerializationContext> contexts
            = new Dictionary<int, SerializationContext>();

        public SerializationContext Context { get; } = new SerializationContext();

        public IAbstractHashCalculatorBuilder<T> And => this;

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, bool>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, bool?>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, DateTime>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, DateTime?>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, TimeSpan>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, TimeSpan?>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, char>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, char?>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, string>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value, Encoding = Context.Encoding });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, string>> expression, Encoding encoding, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value, Encoding = encoding });
            else
                contexts.Add(getters.Count - 1, new SerializationContext { Encoding = encoding });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, Guid>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, Guid?>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<bool>>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<bool?>>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<DateTime>>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<DateTime?>>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<TimeSpan>>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<TimeSpan?>>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<char>>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<char?>>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<string>>> expression, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value, Encoding = Context.Encoding });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<string>>> expression, Encoding encoding, bool? ignoreError = null)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            if (ignoreError.HasValue)
                contexts.Add(getters.Count - 1, new SerializationContext { IgnoreErrors = ignoreError.Value, Encoding = encoding });
            else
                contexts.Add(getters.Count - 1, new SerializationContext { Encoding = encoding });
            return this;
        }

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<Guid>>> expression, bool? ignoreError = null)
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

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<Guid?>>> expression, bool? ignoreError = null)
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

        protected IEnumerable<(object, SerializationContext)> ValuesFor(T instance)
        {
            int index = 0;
            foreach (var accessor in getters)
            {
                var context = getContext(index++);
                object value = null;
                if (context.IgnoreErrors)
                {
                    try { value = accessor(instance); } catch { }
                }
                else
                {
                    value = accessor(instance);
                }
                yield return (value, context);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private SerializationContext getContext(int index)
            => contexts.TryGetValue(index, out var ctx) ? ctx : Context;

    }
}
