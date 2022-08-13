using MVCTekrar_0.Models.LogContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTekrar_0.DesignPatterns.SingletonPattern
{
    public class LogDBTool
    {
        LogDBTool() { }

        static MyLogContext _dbInstance;

        public static MyLogContext DBInstance
        {
            get
            {
                if (_dbInstance == null) _dbInstance = new MyLogContext();

                return _dbInstance;
            }
        }
    }
}