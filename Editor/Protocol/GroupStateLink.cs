﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packages.tour_creator.Editor.Protocol
{
    [Serializable]
    class GroupStateLink : StateItem
    {
        public string title;
        public List<string> stateIds;
    }
}
