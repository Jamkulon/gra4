﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRA.Controllers.ViewModel.Shared
{
    public class ProgramViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool AskAge { get; set; }
        public bool AskSchool { get; set; }
        public int? AgeMaximum { get; set; }
        public int? AgeMinimum { get; set; }
    }
}
