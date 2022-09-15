using ECS.Legacy;
using System;
namespace ECS.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            ECS UUT = new ECS();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}