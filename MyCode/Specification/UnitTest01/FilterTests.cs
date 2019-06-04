using CommonLib;
using FluentAssertions;
using System;
using System.Linq;
using Xunit;

namespace UnitTest01
{
    public class FilterTests
    {
        [Fact]
        public void Basic_Filter_Test()
        {
            string[] lines =
            {
                "Abc",
                "Heis",
                "Ab",
                "Hei"
            };
            var lf = new LineFilter();
            var prefixSpecification = new StartWithSpecification("He");
            var result = lf.Filter(lines, prefixSpecification);
            result.Count().Should().Be(2);
        }
    }
}
