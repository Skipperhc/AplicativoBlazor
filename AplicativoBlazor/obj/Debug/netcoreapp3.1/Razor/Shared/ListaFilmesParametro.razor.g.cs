#pragma checksum "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\Shared\ListaFilmesParametro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "182ae519c48b279131af322222f25b8efb7f89ac"
// <auto-generated/>
#pragma warning disable 1591
namespace AplicativoBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\_Imports.razor"
using AplicativoBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\_Imports.razor"
using AplicativoBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\Shared\ListaFilmesParametro.razor"
using AplicativoBlazor.Data;

#line default
#line hidden
#nullable disable
    public partial class ListaFilmesParametro : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n");
#nullable restore
#line 4 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\Shared\ListaFilmesParametro.razor"
     for (int i = 0; i < filmes.Count; i++) {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\Shared\ListaFilmesParametro.razor"
         if(filmes[i].Nome.Contains(filmeLike)) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "            ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "background-color:" + " " + (
#nullable restore
#line 6 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\Shared\ListaFilmesParametro.razor"
                                            i % 2 == 0 ?  "lightblue" : "lightyellow"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\r\n                ");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, 
#nullable restore
#line 7 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\Shared\ListaFilmesParametro.razor"
                     i+1

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, ". Título: ");
            __builder.AddContent(9, 
#nullable restore
#line 7 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\Shared\ListaFilmesParametro.razor"
                                    filmes[i].Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "p");
            __builder.AddMarkupContent(12, "Lançamento: ");
            __builder.AddContent(13, 
#nullable restore
#line 8 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\Shared\ListaFilmesParametro.razor"
                                filmes[i].Lancamento.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                <hr>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 11 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\Shared\ListaFilmesParametro.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\Shared\ListaFilmesParametro.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\Shared\ListaFilmesParametro.razor"
      
    [Parameter] public string filmeLike { get; set; }
    List<Filme> filmes;

    protected override void OnInitialized() {
        filmes = new List<Filme>() {
        new Filme() { Nome = "Nome do filme", Lancamento = new DateTime(2019,04,17)},
        new Filme() { Nome = "Nome do filme2", Lancamento = new DateTime(2017, 04, 17)},
        new Filme() { Nome = "Nome do filme3", Lancamento = new DateTime(2020, 04, 17)}
    };
        base.OnInitialized();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
