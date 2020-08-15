using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HMS.Client.Pages
{
    public partial class Counter
    {
        [Inject] IJSRuntime jS { get; set; }
        private int currentCount = 0;
        private static int currentCountStatic = 0;
        [JSInvokable]
        public async Task IncrementCount()
        {
            currentCount++;
            currentCountStatic++;
            await jS.InvokeVoidAsync("dotnetStaticInvocation");
        }
        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
        private async Task IncrementCountJavaScript()
        {
            await jS.InvokeVoidAsync("dotnetInstanceInvocation", DotNetObjectReference.Create(this));
        }
    }
}
