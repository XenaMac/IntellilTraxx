﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LATATrax.Messages
{
    public class GPSData
    {
        public string messageType { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public double dir { get; set; }
        public double spd { get; set; }
    }
}