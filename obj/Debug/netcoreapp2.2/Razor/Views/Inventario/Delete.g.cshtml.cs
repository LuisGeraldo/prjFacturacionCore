#pragma checksum "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Inventario/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8421f37317ff94080564752008bb0500a8c60a13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventario_Delete), @"mvc.1.0.view", @"/Views/Inventario/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inventario/Delete.cshtml", typeof(AspNetCore.Views_Inventario_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8421f37317ff94080564752008bb0500a8c60a13", @"/Views/Inventario/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"004402bfff3303496a2a5b2cb75f066ebe1635a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventario_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<prjMaestroDetalle.Models.Inventario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Inventario/Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(88, 245, true);
            WriteLiteral("\r\n<section class=\"contenedor\">\r\n    <h1>Eliminar</h1>\r\n\r\n    <h3>Estas seguro que quieres elminar esto?</h3>\r\n    <div>\r\n        <h4>Inventario</h4>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(334, 44, false);
#line 16 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Inventario/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Articulo));

#line default
#line hidden
            EndContext();
            BeginContext(378, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(454, 47, false);
#line 19 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Inventario/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Articulo.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(501, 82, true);
            WriteLiteral("\r\n            </dd class>\r\n\r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(584, 46, false);
#line 23 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Inventario/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Existencia));

#line default
#line hidden
            EndContext();
            BeginContext(630, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(706, 42, false);
#line 26 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Inventario/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Existencia));

#line default
#line hidden
            EndContext();
            BeginContext(748, 165, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                Precio de compra\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(914, 44, false);
#line 32 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Inventario/Delete.cshtml"
           Write(Html.DisplayFor(model => model.PrecioCompra));

#line default
#line hidden
            EndContext();
            BeginContext(958, 164, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                Precio de venta\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1123, 43, false);
#line 38 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Inventario/Delete.cshtml"
           Write(Html.DisplayFor(model => model.PrecioVenta));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 74, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1241, 41, false);
#line 41 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Inventario/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ITBIs));

#line default
#line hidden
            EndContext();
            BeginContext(1282, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1358, 37, false);
#line 44 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Inventario/Delete.cshtml"
           Write(Html.DisplayFor(model => model.ITBIs));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 54, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        \r\n        ");
            EndContext();
            BeginContext(1449, 229, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8421f37317ff94080564752008bb0500a8c60a138971", async() => {
                BeginContext(1475, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1489, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8421f37317ff94080564752008bb0500a8c60a139362", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 49 "/home/luisgeraldo/visual studio/prjDominicoMaestroDetalle/prjMaestroDetalle/Views/Inventario/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1525, 93, true);
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-danger\" /> |\r\n            ");
                EndContext();
                BeginContext(1618, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8421f37317ff94080564752008bb0500a8c60a1311279", async() => {
                    BeginContext(1640, 17, true);
                    WriteLiteral("Volver a la lista");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1661, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1678, 24, true);
            WriteLiteral("\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<prjMaestroDetalle.Models.Inventario> Html { get; private set; }
    }
}
#pragma warning restore 1591
