using System;
namespace ECS.Legacy
{
    public interface IHeater
    {
        public void TurnOn();
        public void TurnOff();
        public bool RunSelfTest();
    }
}
