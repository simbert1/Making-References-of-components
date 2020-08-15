#pragma checksum "C:\Users\SIMBA\source\repos\HMS\HMS\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2576688d66ea12b03302605280969b7babfe61b6"
// <auto-generated/>
#pragma warning disable 1591
namespace HMS.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using HMS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using HMS.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using HMS.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using HMS.Shared.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n        ");
            __builder.AddMarkupContent(2, "<h1>\r\n            Books\r\n        </h1>\r\n       \r\n       ");
            __builder.OpenComponent<HMS.Client.Shared.BookList>(3);
            __builder.AddAttribute(4, "book", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<HMS.Client.Helpers.Books>>(
#nullable restore
#line 9 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\Pages\Index.razor"
                        book 

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n          \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\Pages\Index.razor"
                          AddNewBook

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(11, "\r\n            Add a new movie\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\Pages\Index.razor"
 
    /// <summary>
    /// create a list of books
    /// </summary>
    private List<Books> book;
    private Dictionary<string, object> dummyTextboxParameters = new Dictionary<string, object>() { { "placeholder","book name"},{ "disabled","true"} };
    protected async  override Task   OnInitializedAsync()
    {
        //await Task.Delay(2000);
        book = new List<Books>()
        {
            new Books()
             {
                Tittle = "Harry Potter",
                ReleaseDate = new DateTime(2008, 9, 8)
            },
             new Books()
             {
                Tittle = "Django",
                ReleaseDate = new DateTime(2009, 7, 8)
            },
              new Books()
             {
                Tittle = "40 Laws of Power",
                ReleaseDate = new DateTime(2018, 4, 8)
            }
        };
    }

    private void AddNewBook()
    {
        book.Add(new Books()
        {
            Tittle = "Imperial aflication",
            ReleaseDate = new DateTime(2009, 7, 8)
        });
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
