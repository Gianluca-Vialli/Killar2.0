#pragma checksum "C:\Users\Ufo\Desktop\Killar2.0\Views\Users\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8e54855511a2c1e2354b0d3da355915b13bd993"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_UserProfile), @"mvc.1.0.view", @"/Views/Users/UserProfile.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Ufo\Desktop\Killar2.0\Views\_ViewImports.cshtml"
using Killar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ufo\Desktop\Killar2.0\Views\_ViewImports.cshtml"
using Killar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8e54855511a2c1e2354b0d3da355915b13bd993", @"/Views/Users/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb2aebbec4851d18054b903206198c868fbf9425", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Users_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Users>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ufo\Desktop\Killar2.0\Views\Users\UserProfile.cshtml"
  
    ViewData["Title"] = "Seu Perfil";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8e54855511a2c1e2354b0d3da355915b13bd9933648", async() => {
                WriteLiteral("\r\n\r\n    <main role=\"main\"");
                BeginWriteAttribute("class", " class=\"", 121, "\"", 129, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 10 "C:\Users\Ufo\Desktop\Killar2.0\Views\Users\UserProfile.cshtml"
         foreach (Users u in Model)
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"container col-md-8 profileContainer p-5 border-primary\">\r\n\r\n                <h1 class=\" text-center mb-4\">Olá ");
#nullable restore
#line 15 "C:\Users\Ufo\Desktop\Killar2.0\Views\Users\UserProfile.cshtml"
                                             Write(u.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@", <span> este são seus dados.</span></h1>

                <hr class=""mb-4 mt-3"">

                <img class=""rounded-circle mb-2 border-primary"" src=""../images/perfil.png"" alt=""Imagem de perfil"">

                <div class="" mt-3 mb-3"">

                    <a class=""btn btn-md btn-primary buttonProfile""");
                BeginWriteAttribute("href", " href=\"", 640, "\"", 678, 2);
                WriteAttributeValue("", 647, "/Users/UserProfileEdit?Id=", 647, 26, true);
#nullable restore
#line 23 "C:\Users\Ufo\Desktop\Killar2.0\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 673, u.Id, 673, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i\r\n                        class=\"fa-solid fa-user-pen\"></i> Editar Perfil</a>\r\n\r\n                    <a class=\"btn btn-md btn-primary buttonProfile\"");
                BeginWriteAttribute("href", " href=\"", 830, "\"", 863, 2);
                WriteAttributeValue("", 837, "/Users/UserDelete?Id=", 837, 21, true);
#nullable restore
#line 26 "C:\Users\Ufo\Desktop\Killar2.0\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 858, u.Id, 858, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><i
                        class=""fa-solid fa-user-xmark""></i> Excluir Perfil</a>

                </div>

                <hr class=""mb-4"">

                <div class=""row"">

                    <div class=""col-md-6"">

                        <label");
                BeginWriteAttribute("for", " for=\"", 1127, "\"", 1133, 0);
                EndWriteAttribute();
                WriteLiteral(">Nome:</label>\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1201, "\"", 1222, 1);
#nullable restore
#line 38 "C:\Users\Ufo\Desktop\Killar2.0\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 1215, u.Name, 1215, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 1269, "\"", 1275, 0);
                EndWriteAttribute();
                WriteLiteral(">Nick Wr(aaaa#0000):</label>\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1357, "\"", 1381, 1);
#nullable restore
#line 41 "C:\Users\Ufo\Desktop\Killar2.0\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 1371, u.LoginWr, 1371, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 1428, "\"", 1434, 0);
                EndWriteAttribute();
                WriteLiteral(">Nick Name</label>\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1506, "\"", 1532, 1);
#nullable restore
#line 44 "C:\Users\Ufo\Desktop\Killar2.0\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 1520, u.LoginName, 1520, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 1579, "\"", 1585, 0);
                EndWriteAttribute();
                WriteLiteral(">Data de Nascimento:</label>\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1667, "\"", 1716, 1);
#nullable restore
#line 47 "C:\Users\Ufo\Desktop\Killar2.0\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 1681, u.BirthDate.ToString("dd/MM/yyyy"), 1681, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n\r\n                    </div>\r\n\r\n                    <div class=\" col-md-6\">\r\n\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 1840, "\"", 1846, 0);
                EndWriteAttribute();
                WriteLiteral(">Sua senha:</label>\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1919, "\"", 1951, 1);
#nullable restore
#line 54 "C:\Users\Ufo\Desktop\Killar2.0\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 1933, u.CheckedPassword, 1933, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 1998, "\"", 2004, 0);
                EndWriteAttribute();
                WriteLiteral(">Elo Atual:</label>\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2077, "\"", 2098, 1);
#nullable restore
#line 57 "C:\Users\Ufo\Desktop\Killar2.0\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 2091, u.Lane, 2091, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 2145, "\"", 2151, 0);
                EndWriteAttribute();
                WriteLiteral(">Lane Principal:</label>\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2229, "\"", 2249, 1);
#nullable restore
#line 60 "C:\Users\Ufo\Desktop\Killar2.0\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 2243, u.Elo, 2243, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 2296, "\"", 2302, 0);
                EndWriteAttribute();
                WriteLiteral(">Tipo:</label>\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2370, "\"", 2402, 1);
#nullable restore
#line 63 "C:\Users\Ufo\Desktop\Killar2.0\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 2384, u.Tipo.ToString(), 2384, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n\r\n                    </div>\r\n\r\n                </div>\r\n\r\n\r\n            </div>\r\n");
#nullable restore
#line 71 "C:\Users\Ufo\Desktop\Killar2.0\Views\Users\UserProfile.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </main>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Users>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
