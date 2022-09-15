
using ECS.Legacy;
using System;
namespace ECS.Test
{
    public class Tests 
    {
        ECS.Legacy.ECS UUT;
        [SetUp]
        public void Setup()
        {
            UUT = new(13, 20);
        }

        [TestCase(4, 4)]
        [TestCase(5, 5)]
        [TestCase(11, 11)]
        public void SetThreshold_TestCorracte(int a, int result)
        {
            UUT.SetThreshold(a, 20);
            Assert.That(UUT.GetHeaterThreshold(), Is.EqualTo(result));
        }

        [TestCase(3, 2, 3)]
        [TestCase(5, 2, 5)]
        [TestCase(9, 2, 9)]
        public void ragolator_overThresholdTestCorrect(int a, int b, int result)
        {
            var testheat = new Heater();
            var TestTemp = new DummyTemp(a);
            var testWindow = new Window();
            ECS.Legacy.ECS UUT = new(b, 20, TestTemp, testheat, testWindow);
            
            Assert.That(UUT.Regulate(), Is.EqualTo($"Temperatur measured was {result}\r\nHeater is off\r\nWindow is closed\r\n"));
        }

        [TestCase(3, 9, 3)]
        [TestCase(5, 9, 5)]
        [TestCase(7, 9, 7)]
        public void ragolator_UnderThresholdTestCorrect(int a, int b, int result)
        {
            var testheat = new Heater();
            var TestTemp = new DummyTemp(a);
            var testWindow = new Window();
            ECS.Legacy.ECS UUT = new(b, 20, TestTemp, testheat, testWindow);

            Assert.That(UUT.Regulate(), Is.EqualTo($"Temperatur measured was {result}\r\nHeater is on\r\nWindow is closed\r\n"));
        }

        [TestCase(3, 3)]
        [TestCase(5,5)]
        [TestCase(7,7)]
        public void GetCurTemp_IsCorrect(int a, int result)
        {
            var testheat = new Heater();
            var TestTemp = new DummyTemp(a);
            var testWindow = new Window();
            ECS.Legacy.ECS UUT = new(5, 20, TestTemp, testheat, testWindow);
            
            Assert.That(UUT.GetCurTemp(), Is.EqualTo(result));
        }


    }
}