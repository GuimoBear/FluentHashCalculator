using System;
using System.Linq.Expressions;
using UnicityCalculator.Internal;
using UnicityCalculator.Tests.Fakes;
using Xunit;

namespace UnicityCalculator.Tests
{
    public class AccessorCacheTests
    {
        [Fact]
        public void UsingSameExpressionWhenGetCachedAccessorMoreThanOneTimeThenCachedTypesEqualsToOne()
        {
            Expression<Func<AnotherEntity, int>> expression1 = e => e.Id;
            var member1 = expression1.GetMember();
            var builder1 = AccessorCache<AnotherEntity>.GetCachedAccessor(member1, expression1);

            Assert.Single(AccessorCache<AnotherEntity>._cache);

            Expression<Func<AnotherEntity, int>> expression2 = e => e.Id;
            var member2 = expression2.GetMember();
            var builder2 = AccessorCache<AnotherEntity>.GetCachedAccessor(member2, expression2);

            Assert.Single(AccessorCache<AnotherEntity>._cache);

            Expression<Func<AnotherEntity, int>> expression3 = e => e.Id;
            var member3 = expression3.GetMember();
            var builder3 = AccessorCache<AnotherEntity>.GetCachedAccessor(member3, expression3);

            Assert.Single(AccessorCache<AnotherEntity>._cache);

            Expression<Func<AnotherEntity, DateTime>> expression4 = e => e.Birthday;
            var member4 = expression4.GetMember();
            var builder4 = AccessorCache<AnotherEntity>.GetCachedAccessor(member4, expression4);

            Assert.Equal(2, AccessorCache<AnotherEntity>._cache.Count);

            Expression<Func<AnotherEntity, string>> expression5 = e => e.Name;
            var member5 = expression5.GetMember();
            var builder5 = AccessorCache<AnotherEntity>.GetCachedAccessor(member5, expression5);

            Assert.Equal(3, AccessorCache<AnotherEntity>._cache.Count);

            Expression<Func<AnotherEntity, int>> expression6 = e => e.Age();
            var member6 = expression6.GetMember();
            var builder6 = AccessorCache<AnotherEntity>.GetCachedAccessor(member6, expression6);

            Assert.Equal(3, AccessorCache<AnotherEntity>._cache.Count);
        }

        [Fact]
        public void KeyTests()
        {
            Expression<Func<Entity, int>> expression 
                = e => e.Id;

            var member = expression.GetMember();

            var key = new AccessorCache<Entity>.Key(member, expression);

            Assert.False(key.Equals(null), "When parameter is null then equal return false");
            Assert.True(key.Equals(key), "When parameter is same instance then equal return true");
            Assert.False(key.Equals(""), "When parameter has different type then equal return false");

            Expression<Func<Entity, int>> expression2
                = e => e.Id;

            var member2 = expression.GetMember();

            Assert.True(key.Equals(new AccessorCache<Entity>.Key(member2, expression2)), "When parameter is different instance but from same property then equal return true");
        }
    }
}
