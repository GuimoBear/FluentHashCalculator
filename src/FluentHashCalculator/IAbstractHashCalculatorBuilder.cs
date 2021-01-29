using FluentHashCalculator.Contexts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FluentHashCalculator
{
    public interface IAbstractHashCalculatorBuilder<T> where T : class
    {
        SerializationContext Context { get; }

        IAbstractHashCalculatorBuilder<T> And { get; }

        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, bool?>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, bool>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, byte?>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, byte>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, char?>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, char>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, DateTime?>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, DateTime>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, decimal?>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, decimal>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, double?>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, double>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, float?>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, float>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, Guid?>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, Guid>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, int?>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, int>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, long?>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, long>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, sbyte?>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, sbyte>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, short?>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, short>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, string>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, string>> expression, Encoding encoding, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, TimeSpan?>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, TimeSpan>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, uint?>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, uint>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, ulong?>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, ulong>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, ushort?>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, ushort>> expression, bool? ignoreError = null);

        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<bool?>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<bool>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<byte?>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<byte>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<char?>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<char>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<DateTime?>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<DateTime>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<decimal?>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<decimal>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<double?>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<double>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<float?>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<float>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<Guid?>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<Guid>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<int?>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<int>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<long?>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<long>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<sbyte?>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<sbyte>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<short?>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<short>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<string>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<string>>> expression, Encoding encoding, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<TimeSpan?>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<TimeSpan>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<uint?>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<uint>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ulong?>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ulong>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ushort?>>> expression, bool? ignoreError = null);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ushort>>> expression, bool? ignoreError = null);
    }
}