﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoko.Models.Server;

namespace Shoko.Models.Client
{
    public class CL_AniDB_GroupStatus : AniDB_GroupStatus
    {
        public bool UserCollecting { get; set; }
        public int FileCount { get; set; }
    }
}
