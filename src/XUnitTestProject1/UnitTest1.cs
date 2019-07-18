using System;
using Xunit;
using Supermarket.API.Controllers;
using Supermarket.API.Resources;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<string> string1 = new List<string>();
            string1.Add("asd");
            string1.Add("asdasd");
            ErrorResource test1 = new ErrorResource(string1);

            Assert.Equal(4, test1.soma(2, 2));
        }
    }
}
