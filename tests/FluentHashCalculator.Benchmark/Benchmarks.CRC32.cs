using BenchmarkDotNet.Attributes;
using System.ComponentModel;

namespace FluentHashCalculator.Benchmark
{
    [Description("CRC32")]
    public class CRC32FluentHashCalculatorBenchmark : BenchmarkBase<uint>
    {
        [GlobalSetup]
        public override void GlobalSetup()
            => base.GlobalSetup();

        [Benchmark()]
        public uint Compute()
            => calculator.Compute(entity);

        protected override IAbstractHashCalculator<Entity, uint> Create()
        {
            var calculator = new AbstractHashCalculatorBuilder<Entity>.CRC32();

            Configure(calculator);
            return calculator;
        }
    }
}
