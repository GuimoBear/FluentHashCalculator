using System;
using System.Linq.Expressions;

namespace UnicityCalculator
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
    }
}