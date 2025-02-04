﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWithASPNET5.Hypermedia
{
    public class HyperMediaLink
    {
        public string Rel { get; set; }
        public string Href {
                get {
                object _lock = new object();
                lock (_lock)
                {
                    StringBuilder sb = new StringBuilder(href);
                    return sb.Replace("%2F", "/").ToString();
                }
                    }
                set { href = value; } }
        private string href { get; set; }
        public string Type { get; set; }
        public string Action { get; set; }
    }
}
