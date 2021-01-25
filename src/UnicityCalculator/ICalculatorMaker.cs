using System;
using System.Linq.Expressions;

namespace UnicityCalculator
{
    public interface ICalculatorMaker<T> where T : class
    {
        UnicityCalculator<T> Using(Expression<Func<T, bool?>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, bool>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, byte?>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, byte>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, char?>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, char>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, DateTime?>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, DateTime>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, decimal?>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, decimal>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, double?>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, double>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, float?>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, float>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, Guid?>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, Guid>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, int?>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, int>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, long?>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, long>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, sbyte?>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, sbyte>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, short?>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, short>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, string>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, TimeSpan?>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, TimeSpan>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, uint?>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, uint>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, ulong?>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, ulong>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, ushort?>> expression);
        UnicityCalculator<T> Using(Expression<Func<T, ushort>> expression);
    }
}