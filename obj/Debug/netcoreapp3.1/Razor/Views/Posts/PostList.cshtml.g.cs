#pragma checksum "D:\Workspace\Killar\Views\Posts\PostList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "617fb499778750ab04e3f9c320ff6eba02037278"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_PostList), @"mvc.1.0.view", @"/Views/Posts/PostList.cshtml")]
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
#line 1 "D:\Workspace\Killar\Views\_ViewImports.cshtml"
using Killar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\Killar\Views\_ViewImports.cshtml"
using Killar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"617fb499778750ab04e3f9c320ff6eba02037278", @"/Views/Posts/PostList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb2aebbec4851d18054b903206198c868fbf9425", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Posts_PostList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Posts>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Nome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Conteudo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "8", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
  
    ViewData["Title"] = "Listagem De Usuários Cadastrados";

    int postsPerPage = Int32.Parse(ViewData["postsPerPage"].ToString());
    int currentPage = Int32.Parse(ViewData["currentPage"].ToString());
    int postsNumberPerPage = (Model.Count < postsPerPage ? Model.Count : postsPerPage);

    int pagesTotalNumber = 0;

    if (postsNumberPerPage > 0)
    {
        pagesTotalNumber = Model.Count / postsNumberPerPage + (Model.Count % postsNumberPerPage == 0 ? 0 : 1);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "617fb499778750ab04e3f9c320ff6eba020372786238", async() => {
                WriteLiteral(@"

    <main role=""main userFormList-container"">

        <div class=""container-fluid "">

            <div class=""row"">

                <div class=""col-md-10 col-xl-10 col-lg-10 col-sm-10 userFormList"">
                    
                    <div class=""row"">
                        <div class=""col-md-12"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "617fb499778750ab04e3f9c320ff6eba020372786855", async() => {
                    WriteLiteral(@"

                                <div class=""form-group mb-3 md-12"">

                                    <p style=""float:left; margin-right:10px;"">
                                        <!-- *********** Retirar estilos in-line *********** -->

                                        <label style=""color: #fff; margin-left: -250px; font-weigth: bold;""");
                    BeginWriteAttribute("for", "\r\n                                            for=\"", 1326, "\"", 1377, 0);
                    EndWriteAttribute();
                    WriteLiteral(">Filtrar Por:</label>\r\n\r\n                                        <select name=\"FilterType\" class=\"form-control mb-3\">\r\n                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "617fb499778750ab04e3f9c320ff6eba020372787868", async() => {
                        WriteLiteral("Autor");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "617fb499778750ab04e3f9c320ff6eba020372789198", async() => {
                        WriteLiteral("Conteúdo");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                        </select>\r\n\r\n                                        <label style=\"color: #fff; margin-left: -190px; font-weigth: bold;\"");
                    BeginWriteAttribute("for", "\r\n                                            for=\"", 1826, "\"", 1877, 0);
                    EndWriteAttribute();
                    WriteLiteral(">Quantidade a Exibir:</label>\r\n\r\n                                        <select class=\"form-control mb-3\" name=\"itemsPerPage\" id=\"itemsPerPage\">\r\n\r\n                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "617fb499778750ab04e3f9c320ff6eba0203727811069", async() => {
                        WriteLiteral("/8");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "617fb499778750ab04e3f9c320ff6eba0203727812397", async() => {
                        WriteLiteral(" Todos os Posts");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
                                              WriteLiteral(Model.Count);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"

                                        </select>

                                        <input type=""text"" class=""btn btn-md btn-light text-justify mr-3""
                                            placeholder=""Busque por Postagens"" name=""Filter"" class=""form-control"" />
                                        <button class=""btn btn-md btn-dark""
                                            type=""submit"">Pesquisar</button>

                                    </p>

                                </div>

                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n");
#nullable restore
#line 68 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
                         if (Model.Count != 0)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <table class="" table table-responsive table-bordered table-striped table-light text-center"">

                                <thead class=""thead-dark text-center"">

                                    <tr>

                                        <th>Id</th>
                                        <th>Autor</th>
                                        <th>Data da Postagem</th>
                                        <th>Conteúdo</th>

                                    </tr>

                                </thead>

                                <tbody class=""text-justify"">

");
#nullable restore
#line 88 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
                                     for (int i = (currentPage - 1) * postsNumberPerPage; i < (postsNumberPerPage *
                                   currentPage < Model.Count ? postsNumberPerPage * currentPage : Model.Count); i++)
                                    {
                                        var stringLength = @Model[i].Content.Length;
                                        var indexOf = @Model[i].Content.IndexOf("");
                                        var subIndex = @Model[i].Content.Substring(indexOf, @Model[i].Content.Length / 2);

                                        if (stringLength >= 150){
                                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <tr>\r\n\r\n                                                <td>");
#nullable restore
#line 99 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
                                               Write(Model[i].Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 100 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
                                               Write(Model[i].Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 101 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
                                               Write(Model[i].PostDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 102 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
                                               Write(subIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                                                <td><a");
                BeginWriteAttribute("href", " href=\"", 4588, "\"", 4626, 2);
                WriteAttributeValue("", 4595, "/Posts/PostEdit?id=", 4595, 19, true);
#nullable restore
#line 104 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
WriteAttributeValue("", 4614, Model[i].Id, 4614, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i\r\n                                                    class=\"fa-solid fa-user-pen\"></i></a></td>\r\n                                                <td><a");
                BeginWriteAttribute("href", " href=\"", 4782, "\"", 4822, 2);
                WriteAttributeValue("", 4789, "/Posts/PostDelete?id=", 4789, 21, true);
#nullable restore
#line 106 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
WriteAttributeValue("", 4810, Model[i].Id, 4810, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i\r\n                                                    class=\"fa-solid fa-user-xmark\"></i></a>\r\n                                                </td>\r\n\r\n                                            </tr>\r\n");
#nullable restore
#line 111 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
                                            
                                        }else{
                                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <tr>\r\n                                                \r\n                                                <td>");
#nullable restore
#line 116 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
                                               Write(Model[i].Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 117 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
                                               Write(Model[i].Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 118 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
                                               Write(Model[i].PostDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 119 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
                                               Write(Model[i].Content);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                                                <td><a");
                BeginWriteAttribute("href", " href=\"", 5624, "\"", 5662, 2);
                WriteAttributeValue("", 5631, "/Posts/PostEdit?id=", 5631, 19, true);
#nullable restore
#line 121 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
WriteAttributeValue("", 5650, Model[i].Id, 5650, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i\r\n                                                    class=\"fa-solid fa-user-pen\"></i></a></td>\r\n                                                <td><a");
                BeginWriteAttribute("href", " href=\"", 5818, "\"", 5858, 2);
                WriteAttributeValue("", 5825, "/Posts/PostDelete?id=", 5825, 21, true);
#nullable restore
#line 123 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
WriteAttributeValue("", 5846, Model[i].Id, 5846, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i\r\n                                                    class=\"fa-solid fa-user-xmark\"></i></a>\r\n                                                </td>\r\n\r\n                                            </tr>\r\n");
#nullable restore
#line 128 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"

                                        }

                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </tbody>\r\n\r\n                            </table>\r\n");
                WriteLiteral("                            <div class=\"filterButton-container\">\r\n\r\n                                <p>Páginas : </p>\r\n\r\n");
#nullable restore
#line 141 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
                                 for (int i = 1; i <= pagesTotalNumber; i++)
                                { // paginação cria os links para as páginas

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <a class=\"btn btn-sm btn-outline-primary\"");
                BeginWriteAttribute("href", " href=\"", 6591, "\"", 6628, 2);
                WriteAttributeValue("", 6598, "/Posts/PostList?currentPage=", 6598, 28, true);
#nullable restore
#line 143 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
WriteAttributeValue("", 6626, i, 6626, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 143 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
                                                                                                               Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 144 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"

                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 148 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <strong class=\"text-center\">Nenhum registro encontrado</strong>\r\n");
#nullable restore
#line 153 "D:\Workspace\Killar\Views\Posts\PostList.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>

                    <div style=""margin-top: 45px;"">
                        <a class=""btn btn-lg btn-dark"" href=""/Users/RegisterUser"">Cadastrar um novo usuario</a>
                    </div>

                </div>

            </div>

    </main>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Posts>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
