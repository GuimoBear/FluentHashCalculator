using BenchmarkDotNet.Attributes;
using System.ComponentModel;

namespace FluentHashCalculator.Benchmark
{
    [Description("SHA1 Without Pool and AppendData")]
    public class SHA1FluentHashCalculatorWithoutPoolAndAppendDataBenchmark : BenchmarkBase<byte[]>
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
            var calculator = new Calculators.AbstractHashCalculatorBuilder<Entity>.SHA1WithoutAppendData();
            Configure(calculator);
            return calculator;
        }
    }
}
