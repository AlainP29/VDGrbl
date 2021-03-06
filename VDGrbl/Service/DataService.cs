﻿using System;
using VDLaser.Model;

namespace VDLaser.Service
{
    public class DataService : IDataService
    {
        public void GetSerialPortSetting(Action<SerialPortSettingItems, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new SerialPortSettingItems("Port Settings");
            callback?.Invoke(item, null);
        }
        public void GetGCode(Action<GCodeModel, Exception> callback)
        {
            var item = new GCodeModel("G-Code file");
            callback?.Invoke(item, null);
        }
        public void GetGraphic(Action<GraphicItems, Exception> callback)
        {
            var item = new GraphicItems("Graphic");
            callback?.Invoke(item, null);
        }
        public void GetConsole(Action<ConsoleModel, Exception> callback)
        {
            var item = new ConsoleModel("Console");
            callback?.Invoke(item, null);
        }
        public void GetJogging(Action<JoggingModel, Exception> callback)
        {
            var item=new JoggingModel("Jog");
            callback?.Invoke(item, null);
        }
    }
}