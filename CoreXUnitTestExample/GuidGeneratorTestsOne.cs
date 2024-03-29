﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CoreXUnitTestExample
{
    [CollectionDefinition("Guid generator")]
    public class GuidGeneratorDefinition : ICollectionFixture<GuidGenerator>
    {
        [Collection("Guid generator")]
        public class GuidGeneratorTestsOne
        {
            private readonly GuidGenerator _guidGenerator;
            private readonly ITestOutputHelper _output;

            public GuidGeneratorTestsOne(ITestOutputHelper output, GuidGenerator guidGenerator)
            {
                _output = output;
                _guidGenerator = guidGenerator;
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

        [Collection("Guid generator")]
        public class GuidGeneratorTestsTwo
        {
            private readonly GuidGenerator _guidGenerator;
            private readonly ITestOutputHelper _output;

            public GuidGeneratorTestsTwo(ITestOutputHelper output, GuidGenerator guidGenerator)
            {
                _output = output;
                _guidGenerator = guidGenerator;
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
}
