using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FluentHashCalculator
{
    public interface IAbstractHashCalculatorBuilder<T> where T : class
    {
        IAbstractHashCalculatorBuilder<T> And { get; }

        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, bool?>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, bool>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, byte?>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, byte>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, char?>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, char>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, DateTime?>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, DateTime>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, decimal?>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, decimal>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, double?>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, double>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, float?>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, float>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, Guid?>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, Guid>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, int?>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, int>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, long?>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, long>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, sbyte?>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, sbyte>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, short?>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, short>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, string>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, TimeSpan?>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, TimeSpan>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, uint?>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, uint>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, ulong?>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, ulong>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, ushort?>> expression);
        IAbstractHashCalculatorBuilder<T> Using(Expression<Func<T, ushort>> expression);


        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<bool?>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<bool>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<byte?>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<byte>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<char?>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<char>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<DateTime?>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<DateTime>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<decimal?>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<decimal>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<double?>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<double>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<float?>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<float>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<Guid?>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<Guid>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<int?>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<int>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<long?>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<long>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<sbyte?>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<sbyte>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<short?>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<short>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<string>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<TimeSpan?>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<TimeSpan>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<uint?>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<uint>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ulong?>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ulong>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ushort?>>> expression);
        IAbstractHashCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ushort>>> expression);
    }
}