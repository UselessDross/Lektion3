using System;
using System.Text;

namespace ECS.Legacy
{
    public class ECS
    {
        private int _heaterThreshold;
        private int _windowThreshold;
        private readonly ITempSensor _tempSensor;
        private readonly IHeater _heater;
        private readonly IWindow _window;

        public ECS(int heaterThreshold, int windowThreshold, ITempSensor tempSensor, IHeater heater, IWindow window)
        {
            _tempSensor = tempSensor;
            _heater = heater;
            _window = window;
            SetThreshold(heaterThreshold, windowThreshold);
        }

        public ECS(int heaterThreshold, int windowThreshold) : this(heaterThreshold, windowThreshold, new TempSensor(), new Heater(), new Window()) { }

        public string Regulate()
        {
            var t = _tempSensor.GetTemp();
            StringBuilder sb = new StringBuilder($"Temperatur measured was {t}");
            if (t < _heaterThreshold)
            {
                sb.Append(_heater.TurnOn());
                sb.Append(_window.Close());
            }
            else if (t < _windowThreshold)
            {
                sb.Append(_heater.TurnOff());
                sb.Append(_window.Close());
            }
            else
            {
                sb.Append(_heater.TurnOff());
                sb.Append(_window.Open());
            }
            return sb.ToString();
        }

        public void SetThreshold(int heaterThreshold, int windowThreshold)
        {
            if (heaterThreshold > windowThreshold) throw new ArgumentOutOfRangeException(nameof(heaterThreshold), $"Tried telling ECS to turn on the heater and open the window at temperatures with ]{windowThreshold}; {heaterThreshold}[");

            _heaterThreshold = heaterThreshold;
            _windowThreshold = windowThreshold;
        }

        public int GetHeaterThreshold() => _heaterThreshold;
        public int GetWindowThreshold() => _windowThreshold;

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }
    }
}
