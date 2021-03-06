#pragma checksum "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eead93f9a847057b1ddc4891cf112631de4d362d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
    public partial class MovieList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
 if (Movies == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
     if (NullTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 5 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
         NullTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 5 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
                     
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "        <img src=\"https://media0.giphy.com/media/3oEjI6SIIHBdRxXI40/giphy.gif\">\r\n");
#nullable restore
#line 10 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
     
}
else if (Movies.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
     if (EmptyTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, 
#nullable restore
#line 16 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
         EmptyTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 16 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
                      
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "There are no records to show");
#nullable restore
#line 20 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
                                                 
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
     
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "checkbox");
            __builder.AddAttribute(7, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
                                  displayButtons

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => displayButtons = __value, displayButtons));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 27 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
     foreach (var movie in Movies)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "        ");
            __builder.OpenComponent<BlazorMovies.Client.Shared.MovieItem>(11);
            __builder.AddAttribute(12, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorMovies.Shared.Entities.Movie>(
#nullable restore
#line 29 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
                          movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "DisplayButtons", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
                                                 displayButtons

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "DeleteMovie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorMovies.Shared.Entities.Movie>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorMovies.Shared.Entities.Movie>(this, 
#nullable restore
#line 29 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
                                                                              DeleteMovie

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 30 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\dev\_private\BlazorMovies\BlazorMovies\Client\Shared\MovieList.razor"
       
    [Parameter] public List<Movie> Movies { get; set; }
    [Parameter] public RenderFragment NullTemplate { get; set; }
    [Parameter] public RenderFragment EmptyTemplate { get; set; }
    bool displayButtons = false;

    void DeleteMovie(Movie movie)
    {
        Movies.Remove(movie);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
