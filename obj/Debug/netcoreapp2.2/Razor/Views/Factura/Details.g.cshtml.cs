#pragma checksum "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7d5f6936f19d7dd800dc88c409974329413e1ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Factura_Details), @"mvc.1.0.view", @"/Views/Factura/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Factura/Details.cshtml", typeof(AspNetCore.Views_Factura_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/_ViewImports.cshtml"
using prjMaestroDetalle;

#line default
#line hidden
#line 2 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/_ViewImports.cshtml"
using prjMaestroDetalle.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7d5f6936f19d7dd800dc88c409974329413e1ca", @"/Views/Factura/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"004402bfff3303496a2a5b2cb75f066ebe1635a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Factura_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjMaestroDetalle.Models.DetalleFactura>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
  
    ViewData["Title"] = "Detalle Factura";

#line default
#line hidden
            BeginContext(114, 99, true);
            WriteLiteral("<section class=\"contenedor\">\r\n\r\n    <h1>Factura</h1>\r\n\r\n    <strong><label>Fecha:</label></strong> ");
            EndContext();
            BeginContext(214, 17, false);
#line 10 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
                                      Write(ViewData["Fecha"]);

#line default
#line hidden
            EndContext();
            BeginContext(231, 65, true);
            WriteLiteral("\r\n\r\n    <br/>\r\n    <strong><label>No. Factura:</label></strong>  ");
            EndContext();
            BeginContext(297, 21, false);
#line 13 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
                                             Write(ViewData["IdFactura"]);

#line default
#line hidden
            EndContext();
            BeginContext(318, 58, true);
            WriteLiteral("\r\n    <br/>\r\n    <strong><label>Cliente:</label></strong> ");
            EndContext();
            BeginContext(377, 19, false);
#line 15 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
                                        Write(ViewData["Cliente"]);

#line default
#line hidden
            EndContext();
            BeginContext(396, 69, true);
            WriteLiteral("\r\n    <br/>\r\n    <strong><label>Condicion de pago:</label></strong>  ");
            EndContext();
            BeginContext(466, 25, false);
#line 17 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
                                                   Write(ViewData["CondicionPago"]);

#line default
#line hidden
            EndContext();
            BeginContext(491, 72, true);
            WriteLiteral("\r\n    <br/>\r\n    <strong><label>Cantidad de Articulos:</label></strong> ");
            EndContext();
            BeginContext(564, 28, false);
#line 19 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
                                                      Write(ViewData["CantidadArticulo"]);

#line default
#line hidden
            EndContext();
            BeginContext(592, 291, true);
            WriteLiteral(@"
    <br/> <br/>
     























    <h1>Detalle de factura</h1>

    <table class=""table"">
        <thead>
            <tr>
                <th>
                    No. Factura
                </th>

                <th>
                    ");
            EndContext();
            BeginContext(884, 44, false);
#line 55 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Articulo));

#line default
#line hidden
            EndContext();
            BeginContext(928, 69, true);
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(998, 44, false);
#line 59 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 69, true);
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1112, 41, false);
#line 63 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ITBIs));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 197, true);
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    Precio\r\n                </th>\r\n              \r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 74 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1386, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1447, 45, false);
#line 77 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Factura.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1492, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1562, 50, false);
#line 81 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Articulo.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1612, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1682, 43, false);
#line 85 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(1725, 70, true);
            WriteLiteral("\r\n                </td> \r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1796, 40, false);
#line 89 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.ITBIs));

#line default
#line hidden
            EndContext();
            BeginContext(1836, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1906, 40, false);
#line 93 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1946, 84, true);
            WriteLiteral("\r\n                </td>\r\n               \r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2030, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7d5f6936f19d7dd800dc88c409974329413e1ca11215", async() => {
                BeginContext(2075, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 97 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2085, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2109, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7d5f6936f19d7dd800dc88c409974329413e1ca13561", async() => {
                BeginContext(2157, 8, true);
                WriteLiteral("Detalles");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 98 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2169, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2193, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7d5f6936f19d7dd800dc88c409974329413e1ca15912", async() => {
                BeginContext(2240, 8, true);
                WriteLiteral("Eliminar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 99 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2252, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 102 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Factura/Details.cshtml"
    }

#line default
#line hidden
            BeginContext(2303, 89, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <a href=\"/Factura/index\">Volver atras</a>\r\n</section>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prjMaestroDetalle.Models.DetalleFactura>> Html { get; private set; }
    }
}
#pragma warning restore 1591
