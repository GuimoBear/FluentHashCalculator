using System;
using System.Linq.Expressions;
using FluentAssertions;
using FluentHashCalculator.Internal;
using FluentHashCalculator.Tests.Fakes;
using Xunit;

namespace FluentHashCalculator.Tests
{
    public class AccessorCacheTests
    {
        [Fact]
        public void UsingSameExpressionWhenGetCachedAccessorMoreThanOneTimeThenCachedTypesEqualsToOne()
        {
            Expression<Func<AnotherEntity, int>> expression1 = e => e.Id;
            var member1 = expression1.GetMember();
            var builder1 = AccessorCache<AnotherEntity>.GetCachedAccessor(member1, expression1);

            AccessorCache<AnotherEntity>._cache.Values.Count
                .Should().BeGreaterOrEqualTo(1);

            Expression<Func<AnotherEntity, int>> expression2 = e => e.Id;
            var member2 = expression2.GetMember();
            var builder2 = AccessorCache<AnotherEntity>.GetCachedAccessor(member2, expression2);

            AccessorCache<AnotherEntity>._cache.Values.Count
                .Should().BeGreaterOrEqualTo(1);

            Expression<Func<AnotherEntity, int>> expression3 = e => e.Id;
            var member3 = expression3.GetMember();
            var builder3 = AccessorCache<AnotherEntity>.GetCachedAccessor(member3, expression3);

            AccessorCache<AnotherEntity>._cache.Values.Count
                .Should().BeGreaterOrEqualTo(1);

            Expression<Func<AnotherEntity, DateTime>> expression4 = e => e.Birthday;
            var member4 = expression4.GetMember();
            var builder4 = AccessorCache<AnotherEntity>.GetCachedAccessor(member4, expression4);

            AccessorCache<AnotherEntity>._cache.Values.Count
                .Should().BeGreaterOrEqualTo(2);

            Expression<Func<AnotherEntity, string>> expression5 = e => e.Name;
            var member5 = expression5.GetMember();
            var builder5 = AccessorCache<AnotherEntity>.GetCachedAccessor(member5, expression5);

            AccessorCache<AnotherEntity>._cache.Values.Count
                .Should().BeGreaterOrEqualTo(3);

            Expression<Func<AnotherEntity, int>> expression6 = e => e.Age();
            var member6 = expression6.GetMember();
            var builder6 = AccessorCache<AnotherEntity>.GetCachedAccessor(member6, expression6);


            Expression<Func<bool, bool>> expression7 = value => !value;
            var member7 = expression7.GetMember();
            var builde7 = AccessorCache<bool>.GetCachedAccessor(member7, expression7);

            AccessorCache<bool>._cache.Values.Count
                .Should().BeGreaterOrEqualTo(0);
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

        [Fact]
        public void Equality_comparison_check()
        {
            Expression<Func<Entity, string>> expr1 = x => x.Name;
            Expression<Func<Entity, string>> expr2 = x => x.Name;
            Expression<Func<Entity, string>> expr3 = x => x.LastName;

            var member1 = expr1.GetMember();
            var member2 = expr2.GetMember();
            var member3 = expr3.GetMember();

            Assert.Equal(member1, member2);
            Assert.NotEqual(member1, member3);
        }

        [Fact]
        public void Identifies_if_memberexp_acts_on_model_instance()
        {
            DoStuffToEntity(null).Should().BeNull();
            Expression<Func<Entity, string>> expr1 = x => DoStuffToEntity(x).Name;
            Expression<Func<Entity, string>> expr2 = x => x.Name;

            expr1.GetMember().Should().BeNull();
            expr2.GetMember().Should().NotBeNull();
        }

        [Fact]
        public void Gets_member_for_nested_property()
        {
            Expression<Func<Entity, string>> expr1 = x => x.Another.Name;
            expr1.GetMember().Should().NotBeNull();
        }

        private Entity DoStuffToEntity(Entity e)
        {
            return e;
        }
    }
}
