﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentHashCalculator
{
    internal class AbstractHashCalculatorBuilderComplexType<T, TComplex> : IAbstractHashCalculatorBuilderComplexType<T, TComplex>
        where T : class
        where TComplex : class
    {
        private readonly AbstractHashCalculatorBuilder<T> parent;
        private readonly Func<object, object> accessor;
        private readonly bool? ignoreError;

        public AbstractHashCalculatorBuilderComplexType(AbstractHashCalculatorBuilder<T> parent, Func<object, object> accessor, bool? ignoreError = null)
        {
            this.parent = parent;
            this.accessor = accessor;
            this.ignoreError = ignoreError;
        }

        public IAbstractHashCalculatorBuilder<T> WithCRC16(Action<IAbstractHashCalculatorBuilder<TComplex>> configurer)
        {
            var calculator = new AbstractHashCalculatorBuilder<TComplex>.CRC16();
            calculator.Context.IgnoreErrors = parent.Context.IgnoreErrors;
            calculator.Context.Encoding = parent.Context.Encoding;
            configurer(calculator);
            parent.UsingEach(instance => BitConverter.GetBytes(calculator.Compute(accessor(instance) as TComplex)), ignoreError);
            return parent;
        }

        public IAbstractHashCalculatorBuilder<T> WithCRC32(Action<IAbstractHashCalculatorBuilder<TComplex>> configurer)
        {
            var calculator = new AbstractHashCalculatorBuilder<TComplex>.CRC32();
            calculator.Context.IgnoreErrors = parent.Context.IgnoreErrors;
            calculator.Context.Encoding = parent.Context.Encoding;
            configurer(calculator);
            parent.UsingEach(instance => BitConverter.GetBytes(calculator.Compute(accessor(instance) as TComplex)), ignoreError);
            return parent;
        }

        public IAbstractHashCalculatorBuilder<T> WithCRC64(Action<IAbstractHashCalculatorBuilder<TComplex>> configurer)
        {
            var calculator = new AbstractHashCalculatorBuilder<TComplex>.CRC64();
            calculator.Context.IgnoreErrors = parent.Context.IgnoreErrors;
            calculator.Context.Encoding = parent.Context.Encoding;
            configurer(calculator);
            parent.UsingEach(instance => BitConverter.GetBytes(calculator.Compute(accessor(instance) as TComplex)), ignoreError);
            return parent;
        }

        public IAbstractHashCalculatorBuilder<T> WithMD5(Action<IAbstractHashCalculatorBuilder<TComplex>> configurer)
        {
            var calculator = new AbstractHashCalculatorBuilder<TComplex>.MD5();
            calculator.Context.IgnoreErrors = parent.Context.IgnoreErrors;
            calculator.Context.Encoding = parent.Context.Encoding;
            configurer(calculator);
            parent.UsingEach(instance => calculator.Compute(accessor(instance) as TComplex), ignoreError);
            return parent;
        }

        public IAbstractHashCalculatorBuilder<T> WithSHA1(Action<IAbstractHashCalculatorBuilder<TComplex>> configurer)
        {
            var calculator = new AbstractHashCalculatorBuilder<TComplex>.SHA1();
            calculator.Context.IgnoreErrors = parent.Context.IgnoreErrors;
            calculator.Context.Encoding = parent.Context.Encoding;
            configurer(calculator);
            parent.UsingEach(instance => calculator.Compute(accessor(instance) as TComplex), ignoreError);
            return parent;
        }

        public IAbstractHashCalculatorBuilder<T> WithSHA256(Action<IAbstractHashCalculatorBuilder<TComplex>> configurer)
        {
            var calculator = new AbstractHashCalculatorBuilder<TComplex>.SHA256();
            calculator.Context.IgnoreErrors = parent.Context.IgnoreErrors;
            calculator.Context.Encoding = parent.Context.Encoding;
            configurer(calculator);
            parent.UsingEach(instance => calculator.Compute(accessor(instance) as TComplex), ignoreError);
            return parent;
        }

        public IAbstractHashCalculatorBuilder<T> WithSHA384(Action<IAbstractHashCalculatorBuilder<TComplex>> configurer)
        {
            var calculator = new AbstractHashCalculatorBuilder<TComplex>.SHA384();
            calculator.Context.IgnoreErrors = parent.Context.IgnoreErrors;
            calculator.Context.Encoding = parent.Context.Encoding;
            configurer(calculator);
            parent.UsingEach(instance => calculator.Compute(accessor(instance) as TComplex), ignoreError);
            return parent;
        }

        public IAbstractHashCalculatorBuilder<T> WithSHA512(Action<IAbstractHashCalculatorBuilder<TComplex>> configurer)
        {
            var calculator = new AbstractHashCalculatorBuilder<TComplex>.SHA512();
            calculator.Context.IgnoreErrors = parent.Context.IgnoreErrors;
            calculator.Context.Encoding = parent.Context.Encoding;
            configurer(calculator);
            parent.UsingEach(instance => calculator.Compute(accessor(instance) as TComplex), ignoreError);
            return parent;
        }
    }
}
