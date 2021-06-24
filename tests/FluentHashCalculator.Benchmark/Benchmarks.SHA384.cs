using BenchmarkDotNet.Attributes;
using System.ComponentModel;

namespace FluentHashCalculator.Benchmark
{
    [Description("SHA384")]
    public class SHA384FluentHashCalculatorBenchmark : BenchmarkBase<byte[]>
    {
        [GlobalSetup]
        public override void GlobalSetup()
        {
            base.GlobalSetup();
        }

        [Benchmark]
        public byte[] Compute()
            => calculator.Compute(entity);

        /*
        [Benchmark]
        public byte[] CreateAndCompute()
        {
            var calc = create();
            return calc.Compute(entity);
        }
        */

        protected override IAbstractHashCalculator<Entity, byte[]> Create()
        {
            var calculator = new AbstractHashCalculatorBuilder<Entity>.SHA384();
            Configure(calculator);
            return calculator;
        }
    }
}
