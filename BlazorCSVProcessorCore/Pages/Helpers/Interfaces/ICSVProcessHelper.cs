﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace BlazorCSVProcessorCore.Pages.Helpers.Interfaces
{
    interface ICSVProcessHelper
    {
        Task ReaderHelper(Stream stream,List<string> list); 
    }
}
