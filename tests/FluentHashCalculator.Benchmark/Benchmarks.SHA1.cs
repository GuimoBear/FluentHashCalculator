using BenchmarkDotNet.Attributes;
using System.ComponentModel;

namespace FluentHashCalculator.Benchmark
{
    [Description("SHA1")]
    public class SHA1FluentHashCalculatorBenchmark : BenchmarkBase<byte[]>
    {
        [GlobalSetup]
        public override void GlobalSetup()
            => base.GlobalSetup();

        [Benchmark]
        public byte[] Compute()
            => calculator.Compute(entity);

        protected override IAbstractHashCalculator<Entity, byte[]> Create()
        {
            var calculator = new AbstractHashCalculatorBuilder<Entity>.SHA1();

            Configure(calculator);
            return calculator;
        }
    }
}
