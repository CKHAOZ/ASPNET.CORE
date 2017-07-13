using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void Test2()
        {
            // Únicamente se puede tener un assert por prueba
            Assert.Equal(15, 15);
            
            Assert.Equal("Algo", "Algo");

            Assert.Equal("Algo", "algo");

            Assert.Equal(1, 2);
            
            Assert.Equal("Algo", "algo2");
        }
    }
}
