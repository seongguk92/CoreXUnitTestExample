using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CoreXUnitTestExample
{
    public class GuidGeneratorTestsOne : IClassFixture<GuidGenerator>, IDisposable
    {
        private readonly GuidGenerator _guidGenerator;
        private readonly ITestOutputHelper _output;

        public GuidGeneratorTestsOne(ITestOutputHelper output, GuidGenerator guidGenerator)
        {
            _output = output;
            _guidGenerator = guidGenerator;
        }

        public void Dispose()
        {
            _output.WriteLine("The class was disposed");
        }

        [Fact]
        public void GuidTestOne()
        {
            var guid = _guidGenerator.RandomGuid;
            _output.WriteLine($"The guid was: {guid}");
        }
        [Fact]
        public void GuidTestTwo()
        {
            var guid = _guidGenerator.RandomGuid;
            _output.WriteLine($"The guid was: {guid}");
        }
    }
}
