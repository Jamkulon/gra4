﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GRA.Controllers.ViewModel.MissionControl
{
    public class SystemInformationViewModel
    {
        public string Assembly { get; set; }
        public string Version { get; set; }
        public string Migration { get; set; }
        public Dictionary<string, string> Assemblies { get; set; }
        public string Instance { get; set; }
        public string Deploy { get; set; }
    }
}
