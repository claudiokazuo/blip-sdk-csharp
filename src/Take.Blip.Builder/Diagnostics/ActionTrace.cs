﻿using Newtonsoft.Json.Linq;
using System;

namespace Take.Blip.Builder.Diagnostics
{
    public class ActionTrace : Trace
    {
        public ActionTrace()
        {
            Timestamp = DateTimeOffset.UtcNow;
        }

        public int Order { get; set; }

        public string Type { get; set; }

        public DateTimeOffset Timestamp { get; set; }

        public JObject ParsedSettings { get; set; }
    }
}