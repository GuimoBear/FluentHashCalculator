using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentHashCalculator
{
    internal class AbstractHashCalculatorBuilderComplexTypeList<T, TComplex> : IAbstractHashCalculatorBuilderComplexType<T, TComplex>
        where T : class
        where TComplex : class
    {
        private readonly AbstractHashCalculatorBuilder<T> parent;
        private readonly Func<object, object> accessor;
        private readonly bool? ignoreError;

        public AbstractHashCalculatorBuilderComplexTypeList(AbstractHashCalculatorBuilder<T> parent, Func<object, object> accessor, bool? ignoreError = null)
        {
            this.parent = parent;
            this.accessor = accessor;
            this.ignoreError = ignoreError;
        }

        private IEnumerable<TComplex> GetList(T instance)
        {
            var obj = accessor(instance);
            if (obj is null)
                throw new NullReferenceException();
            return obj as IEnumerable<TComplex>;
        }

        public IAbstractHashCalculatorBuilder<T> WithCRC16(Action<IAbstractHashCalculatorBuilder<TComplex>> configurer)
        {
            var calculator = new AbstractHashCalculatorBuilder<TComplex>.CRC16();
            configurer(calculator);
            parent.UsingEach(instance => GetList(instance).SelectMany(prop => BitConverter.GetBytes(calculator.Compute(prop))), ignoreError);
            return parent;
        }

        public IAbstractHashCalculatorBuilder<T> WithCRC32(Action<IAbstractHashCalculatorBuilder<TComplex>> configurer)
        {
            var calculator = new AbstractHashCalculatorBuilder<TComplex>.CRC32();
            configurer(calculator);
            parent.UsingEach(instance => GetList(instance).SelectMany(prop => BitConverter.GetBytes(calculator.Compute(prop))), ignoreError);
            return parent;
        }

        public IAbstractHashCalculatorBuilder<T> WithCRC64(Action<IAbstractHashCalculatorBuilder<TComplex>> configurer)
        {
            var calculator = new AbstractHashCalculatorBuilder<TComplex>.CRC64();
            configurer(calculator);
            parent.UsingEach(instance => GetList(instance).SelectMany(prop => BitConverter.GetBytes(calculator.Compute(prop))), ignoreError);
            return parent;
        }

        public IAbstractHashCalculatorBuilder<T> WithMD5(Action<IAbstractHashCalculatorBuilder<TComplex>> configurer)
        {
            var calculator = new AbstractHashCalculatorBuilder<TComplex>.MD5();
            configurer(calculator);
            parent.UsingEach(instance => GetList(instance).SelectMany(prop => calculator.Compute(prop)), ignoreError);
            return parent;
        }

        public IAbstractHashCalculatorBuilder<T> WithSHA1(Action<IAbstractHashCalculatorBuilder<TComplex>> configurer)
        {
            var calculator = new AbstractHashCalculatorBuilder<TComplex>.SHA1();
            configurer(calculator);
            parent.UsingEach(instance => GetList(instance).SelectMany(prop => calculator.Compute(prop)), ignoreError);
            return parent;
        }

        public IAbstractHashCalculatorBuilder<T> WithSHA256(Action<IAbstractHashCalculatorBuilder<TComplex>> configurer)
        {
            var calculator = new AbstractHashCalculatorBuilder<TComplex>.SHA256();
            configurer(calculator);
            parent.UsingEach(instance => GetList(instance).SelectMany(prop => calculator.Compute(prop)), ignoreError);
            return parent;
        }

        public IAbstractHashCalculatorBuilder<T> WithSHA384(Action<IAbstractHashCalculatorBuilder<TComplex>> configurer)
        {
            var calculator = new AbstractHashCalculatorBuilder<TComplex>.SHA384();
            configurer(calculator);
            parent.UsingEach(instance => GetList(instance).SelectMany(prop => calculator.Compute(prop)), ignoreError);
            return parent;
        }

        public IAbstractHashCalculatorBuilder<T> WithSHA512(Action<IAbstractHashCalculatorBuilder<TComplex>> configurer)
        {
            var calculator = new AbstractHashCalculatorBuilder<TComplex>.SHA512();
            configurer(calculator);
            parent.UsingEach(instance => GetList(instance).SelectMany(prop => calculator.Compute(prop)), ignoreError);
            return parent;
        }
    }
}
