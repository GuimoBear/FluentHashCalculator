using BenchmarkDotNet.Attributes;
using System.ComponentModel;

namespace FluentHashCalculator.Benchmark
{
    [Description("CRC16")]
    public class CRC16FluentHashCalculatorBenchmark : BenchmarkBase<ushort>
    {
        [GlobalSetup]
        public override void GlobalSetup()
            => base.GlobalSetup();

        [Benchmark(Description = "Compute")]
        public ushort Compute()
            => calculator.Compute(entity);

        protected override IAbstractHashCalculator<Entity, ushort> Create()
        {
            var calculator = new AbstractHashCalculatorBuilder<Entity>.CRC16();

            Configure(calculator);
            return calculator;
        }
    }
}
