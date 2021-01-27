using FluentAssertions;
using FluentHashCalculator.Internal;
using FluentHashCalculator.Tests.Fakes;
using System;
using System.Linq.Expressions;
using Xunit;

namespace FluentHashCalculator.Tests
{
    public class ExtensionTests
    {
		[Fact]
		public void Should_extract_member_from_member_expression()
		{
			Expression<Func<Entity, string>> expression = entity => entity.Name;
			var member = expression.GetMember();
			member.Name.Should().BeEquivalentTo("Name");
		}

		[Fact]
		public void Should_return_null_for_non_member_expressions()
		{
			Expression<Func<Entity, string>> expression = entity => "Foo";
			expression.GetMember().Should().BeNull();
		}
	}
}
