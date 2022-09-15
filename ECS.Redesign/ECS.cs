using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Redesign
{
    public class ECS
    {
        private int _threshold;
        private TempSensor _tempSensor;
        private Heater _heater;

        public void Regulate()
        {
            throw new System.NotImplementedException();
        }

        public void SetThreshold(int thr)
        {
            throw new System.NotImplementedException();
        }

        public int GetThreshold()
        {
            throw new System.NotImplementedException();
        }

        public int GetCurTemp()
        {
            throw new System.NotImplementedException();
        }

        public bool RunSelfTest()
        {
            throw new System.NotImplementedException();
        }
    }
}