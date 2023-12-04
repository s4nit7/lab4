using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.TrafficSimulation
{
    public interface IDriveable
    {
        void Move(double speed);
        void Stop();
    }
}

