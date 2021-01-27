using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FluentHashCalculator
{
    public interface IAbstractCalculatorBuilder<T> where T : class
    {
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, bool?>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, bool>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, byte?>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, byte>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, char?>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, char>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, DateTime?>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, DateTime>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, decimal?>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, decimal>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, double?>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, double>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, float?>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, float>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, Guid?>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, Guid>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, int?>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, int>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, long?>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, long>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, sbyte?>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, sbyte>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, short?>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, short>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, string>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, TimeSpan?>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, TimeSpan>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, uint?>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, uint>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, ulong?>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, ulong>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, ushort?>> expression);
        IAbstractCalculatorBuilder<T> Using(Expression<Func<T, ushort>> expression);


        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<bool?>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<bool>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<byte?>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<byte>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<char?>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<char>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<DateTime?>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<DateTime>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<decimal?>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<decimal>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<double?>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<double>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<float?>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<float>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<Guid?>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<Guid>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<int?>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<int>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<long?>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<long>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<sbyte?>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<sbyte>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<short?>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<short>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<string>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<TimeSpan?>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<TimeSpan>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<uint?>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<uint>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ulong?>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ulong>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ushort?>>> expression);
        IAbstractCalculatorBuilder<T> UsingEach(Expression<Func<T, IEnumerable<ushort>>> expression);
    }
}