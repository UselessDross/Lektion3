namespace ECS.Legacy
{
    public class Heater : IHeater
    {
        public string TurnOn()
        {
            return "Heater is on";
        }

        public string TurnOff()
        {
            return "Heater is off";
        }

     
    }
}