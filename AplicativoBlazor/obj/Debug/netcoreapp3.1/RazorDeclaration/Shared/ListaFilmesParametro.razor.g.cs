#pragma checksum "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\Shared\ListaFilmesParametro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d95e710777de7bc4a231c46101cc363510d47fb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "E:\Projetos Git C#\AplicativoBlazor\AplicativoBlazor\Shared\ListaFilmesParametro.razor"
      
    [Parameter] public string filmeLike { get; set; }
    List<Filmes> filmes;

    protected override void OnInitialized() {
        filmes = new List<Filmes>() {
        new Filmes() { Nome = "Nome do filme", Lancamento = new DateTime(2019,04,17)},
        new Filmes() { Nome = "Nome do filme2", Lancamento = new DateTime(2017, 04, 17) },
        new Filmes() { Nome = "Nome do filme3", Lancamento = new DateTime(2020, 04, 17) }
    };
        base.OnInitialized();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
