﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDiseno.Singleton
{
    public class Log
    {
        public static readonly Log _instance = new Log();
        private string _path = "log.txt";
        public static Log Instance
        {
            get
            {
                return _instance;
            }
        }
        private Log()
        {
        }

        public void Save(string message) 
        {
            File.AppendAllText(_path,message + Environment.NewLine);
        }

    }
}
