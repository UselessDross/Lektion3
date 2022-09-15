using ECS.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Test
{
    public class DummyTemp : ITempSensor
    {
        public int globalTemp;
        public DummyTemp(int globalTemp)
        {
            this.globalTemp = globalTemp;
        }

        public int GetTemp()
        {
            return globalTemp;
        }
    }
}
