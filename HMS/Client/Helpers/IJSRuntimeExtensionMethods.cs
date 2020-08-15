using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMS.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime jS ,string message)
        {
            await jS.InvokeVoidAsync("console.log", "example message");
            return await jS.InvokeAsync<bool>("confirm",message);
        }
        public static async ValueTask MyFunction(this IJSRuntime jS ,string message)
        {
            await jS.InvokeVoidAsync("my_function",message);
        }
    }
}
