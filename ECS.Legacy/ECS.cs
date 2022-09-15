using System;

namespace ECS.Legacy
{
    public class ECS
    {
        private int _threshold;
        private readonly TempSensor _tempSensor;
        private readonly Heater _heater;

        public ECS(int thr)
        {
            SetThreshold(thr);
            _tempSensor = new TempSensor();
            _heater = new Heater();
        }

        public string Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();
            return $"Temperatur measured was {t}";

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }


    }
}
