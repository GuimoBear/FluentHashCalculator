﻿namespace UnicityCalculator
{
    public interface IAbstractCalculator<T, TComputedType> : IAbstractCalculatorBuilder<T>, ICalculator<T, TComputedType>
        where T: class
    {

    }
}
