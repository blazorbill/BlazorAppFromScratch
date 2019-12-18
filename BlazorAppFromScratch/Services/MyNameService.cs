using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppFromScratch.Services
{
    public class MyNameService : IMyNameService
    {
        public string GetMyName()
        {
            return "Bill's Counter Component";
        }
    }
}
