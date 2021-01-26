﻿namespace UnicityCalculator
{
    public interface ICalculator<T, TComputedType>
        where T: class
    {
        TComputedType Compute(T instance);
    }
}
