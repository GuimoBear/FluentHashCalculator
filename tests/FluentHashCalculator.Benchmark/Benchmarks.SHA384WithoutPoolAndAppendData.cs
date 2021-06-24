using BenchmarkDotNet.Attributes;
using System.ComponentModel;

namespace FluentHashCalculator.Benchmark
{
    [Description("SHA384 Without Pool and AppendData")]
    public class SHA384FluentHashCalculatorWithoutPoolAndAppendDataBenchmark : BenchmarkBase<byte[]>
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
            var calculator = new Calculators.AbstractHashCalculatorBuilder<Entity>.SHA384WithoutAppendData();
            Configure(calculator);
            return calculator;
        }
    }
}
