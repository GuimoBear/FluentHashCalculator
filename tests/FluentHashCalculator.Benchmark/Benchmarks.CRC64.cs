using BenchmarkDotNet.Attributes;
using System.ComponentModel;

namespace FluentHashCalculator.Benchmark
{
    [Description("CRC64")]
    public class CRC64FluentHashCalculatorBenchmark : BenchmarkBase<ulong>
    {
        [GlobalSetup]
        public override void GlobalSetup()
            => base.GlobalSetup();

        [Benchmark]
        public ulong Compute()
            => calculator.Compute(entity);

        protected override IAbstractHashCalculator<Entity, ulong> Create()
        {
            var calculator = new AbstractHashCalculatorBuilder<Entity>.CRC64();

            Configure(calculator);
            return calculator;
        }
    }
}
