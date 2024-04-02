﻿using Faster.Map.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faster.Map.RobinhoodMap.Tests
{
    public class RobinhoodStringWrapperTests
    {

        [Fact]
        public void Emplace_StringWrapper_Should_Return_Correct_String()
        {
            // Assign
            var map = new RobinhoodMap<StringWrapper, StringWrapper>();

            map.Emplace("one", "Nine");          

            // Act
            map.Get("one", out var result); ;

            // Assert
            Assert.Equal("Nine", result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        [InlineData(1000000)]
        public void Get_StringsWrapper_Return_Succesful(uint amount)
        {
            // Arrange
            var map = new RobinhoodMap<StringWrapper, StringWrapper>();

            for (uint i = 0; i < amount; i++)
            {
                map.Emplace(i.ToString(), Guid.NewGuid().ToString());
            }

            for (uint i = 0; i < amount; i++)
            {
                // Act
                var result = map.Get(i.ToString(), out var _);
                if (!result)
                {
                    // Assert
                    Assert.Fail();
                }
            }
        }

    }
}
