using FluentHashCalculator.Contexts;
using FluentHashCalculator.Internal;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculatorBuilder<T> : IAbstractHashCalculatorBuilder<T>
        where T : class
    {
        private readonly List<Func<T, object>> getters
            = new List<Func<T, object>>();
        private readonly IDictionary<int, SerializationContext> contexts
            = new Dictionary<int, SerializationContext>();

        public SerializationContext Context { get; } = new SerializationContext();

        public IAbstractHashCalculatorBuilder<T> And => this;

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

        public IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, string?>> expression, Encoding encoding)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            contexts.Add(getters.Count - 1, new SerializationContext { Encoding = encoding });
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

        public IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<string?>>> expression, Encoding encoding)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var member = expression.GetMember();
            var compiled = AccessorCache<T>.GetCachedAccessor(member, expression);
            getters.Add(compiled.CoerceToNonGeneric());
            contexts.Add(getters.Count - 1, new SerializationContext { Encoding = encoding });
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

        protected IEnumerable<(object, SerializationContext)> ValuesFor(T instance)
        {
            int index = 0;
            foreach (var accessor in getters)
                yield return 
                (
                    accessor(instance), 
                    contexts.TryGetValue(index++, out var context) ? context : Context
                );
        }
    }
}
