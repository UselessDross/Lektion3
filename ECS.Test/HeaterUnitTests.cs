using ECS.Legacy;
using System;
namespace ECS.Test
{
    public class HeaterUnitTests
    {
        IHeater _heater;

        [SetUp]
        public void Setup()
        {
            _heater = new Heater();
        }

        [Test]
        public void TurnOn()
        {
            Assert.That(_heater.TurnOn(), Is.EqualTo("Heater is on"));
        }
        [Test]
        public void TurnOff()
        {
            Assert.That(_heater.TurnOff(), Is.EqualTo("Heater is off"));
        }
    }
}