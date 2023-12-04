﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface IConnectable
    {
        void Disconnect(Computer target);
        void TransmitData(string data, Computer target);
    }
}
