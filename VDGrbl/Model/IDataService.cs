﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VDGrbl.Model
{
    public interface IDataService
    {
        void GetData(Action<SerialPortSettingsModel, Exception> callback);

    }
}
