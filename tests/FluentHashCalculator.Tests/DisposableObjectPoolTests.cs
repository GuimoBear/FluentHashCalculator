using FluentAssertions;
using FluentHashCalculator.Internal;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace FluentHashCalculator.Tests
{
    public class DisposableObjectPoolTests
    {
        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        public void UsingParallelWithNRunnersWhenAcquireThenCountOfInstancesIsTheSameOfParallelRunnersCount(int maxParallelRunners)
        {
            var moq = Mock.Of<IDisposable>();
            var sut = new DisposableObjectPool<IDisposable>(() => moq);
            var loopResult = Parallel.For(0, 12, new ParallelOptions { MaxDegreeOfParallelism = maxParallelRunners }, _ =>
            {
                using (sut.Acquire())
                {
                    Thread.Sleep(5);
                }
            });
            
            sut._objects
                .Should()
                .HaveCountLessOrEqualTo(maxParallelRunners);
        }
    }
}
