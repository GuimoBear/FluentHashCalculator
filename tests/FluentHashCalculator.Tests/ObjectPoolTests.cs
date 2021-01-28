using FluentAssertions;
using FluentHashCalculator.Internal;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace FluentHashCalculator.Tests
{
    public class ObjectPoolTests
    {
        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        public void UsingParallelWithNRunnersWhenAcquireThenCountOfInstancesIsTheSameOfParallelRunnersCount(int maxParallelRunners)
        {
            var sut = new ObjectPool<IDisposable>(() => Mock.Of<IDisposable>());
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
