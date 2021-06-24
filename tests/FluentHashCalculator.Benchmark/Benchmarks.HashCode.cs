using BenchmarkDotNet.Attributes;
using System.ComponentModel;

namespace FluentHashCalculator.Benchmark
{
    [Description("HashCode")]
    public class HashCodeFluentHashCalculatorBenchmark : BenchmarkBase<int>
    {
        [GlobalSetup]
        public override void GlobalSetup()
            => base.GlobalSetup();

        [Benchmark]
        public int Compute()
            => calculator.Compute(entity);

        protected override IAbstractHashCalculator<Entity, int> Create()
        {
            var calculator = new AbstractHashCalculatorBuilder<Entity>.HashCode();

            Configure(calculator);
            return calculator;
        }
    }
}
