using BlazorAppFromScratch.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppFromScratch.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        private string myName = "Counter Component";
        [Inject]
        private IMyNameService _myNameService { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            myName = _myNameService.GetMyName();
        }
        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
