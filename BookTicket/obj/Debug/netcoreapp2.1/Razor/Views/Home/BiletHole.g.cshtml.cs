#pragma checksum "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\Home\BiletHole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61c1b60079b8e05b0a08386dbb532732eb4e129d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BiletHole), @"mvc.1.0.view", @"/Views/Home/BiletHole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/BiletHole.cshtml", typeof(AspNetCore.Views_Home_BiletHole))]
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
#line 1 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\_ViewImports.cshtml"
using BookTicket;

#line default
#line hidden
#line 2 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\_ViewImports.cshtml"
using BookTicket.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61c1b60079b8e05b0a08386dbb532732eb4e129d", @"/Views/Home/BiletHole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea31a4893e22a04b97cb724226b5ac32d816e436", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BiletHole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ticket>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TicketStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\Home\BiletHole.cshtml"
  
    ViewData["Title"] = "BiletHole";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("sections", async() => {
                BeginContext(140, 1114, true);
                WriteLiteral(@"

    <script>

        $("".userfree"").click(function () {
            
            $(this).toggleClass(""userfree"");
            $(this).toggleClass(""userchoose"");
            $(""#price"").toggleClass(""d-none"");
            $(""#price"").toggleClass(""d-inline"");
            if ($(this).hasClass(""userchoose"")) {
                $(""#submit"").removeClass(""btn-danger"");
                $(""#submit"").removeClass(""disabled"");
                $(""#submit"").addClass(""btn-primary"");
                $(""#submit"").val(""Bilet Seçtiniz"");

                if ($("".ticket"").hasClass(""userchoose"")) {
                    var result = $(this).val();
                    $(""#submit"").val(result);
                }
                else {
                    console.log(""seçili eleman yok!"")
                }
               
               
            }
            else {
                $(""#submit"").addClass(""btn-danger"");
                $(""#submit"").addClass(""disabled"");
                $(""#submit"").remo");
                WriteLiteral("veClass(\"btn-primary\");\r\n            }\r\n            \r\n        })\r\n\r\n     \r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(1257, 103, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12 col-md-4\">\r\n            ");
            EndContext();
            BeginContext(1361, 48, false);
#line 49 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\Home\BiletHole.cshtml"
       Write(await Component.InvokeAsync("SliderFirstSlider"));

#line default
#line hidden
            EndContext();
            BeginContext(1409, 343, true);
            WriteLiteral(@"
        </div>
        <div class=""col-12 col-md-4"">
            <div class=""text-center""> <span class=""userchoose mx-2""> Seçili Koltuk</span> <span class=""userfull mx-2"">Dolu Koltuk</span> <span class="" userfree mx-2""> Boş Koltuk</span></div>

            <div class=""text-danger text-center""><strong>* 1 Bilet Seçiniz.</strong></div>
");
            EndContext();
#line 55 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\Home\BiletHole.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
            BeginContext(1816, 89, true);
            WriteLiteral("            <div class=\"text-center\"><strong class=\"text-success mt-3 mx-5\">Hoşgeldiniz, ");
            EndContext();
            BeginContext(1906, 18, false);
#line 57 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\Home\BiletHole.cshtml"
                                                                                    Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1924, 25, true);
            WriteLiteral("</strong> <br /></div> \r\n");
            EndContext();
#line 58 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\Home\BiletHole.cshtml"
            }
            else
            {


            }

#line default
#line hidden
            BeginContext(2016, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 66 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\Home\BiletHole.cshtml"
             foreach (var item in Model)
            {
                

#line default
#line hidden
#line 68 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\Home\BiletHole.cshtml"
                 if (item.FullorEmpty == false)
                {

#line default
#line hidden
            BeginContext(2145, 27, true);
            WriteLiteral("                    <button");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2172, "\"", 2199, 1);
#line 70 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\Home\BiletHole.cshtml"
WriteAttributeValue("", 2180, item.BiletNumberId, 2180, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2200, "\"", 2226, 1);
#line 70 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\Home\BiletHole.cshtml"
WriteAttributeValue("", 2207, item.BiletNumberId, 2207, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2227, 136, true);
            WriteLiteral(" id=\"ticket\" class=\"userfree ticket bg-transparent border-0\"></button>\r\n                    <input type=\"hidden\" class=\"ticket2\" name=\"\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2363, "\"", 2390, 1);
#line 71 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\Home\BiletHole.cshtml"
WriteAttributeValue("", 2371, item.BiletNumberId, 2371, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2391, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 72 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\Home\BiletHole.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2456, 52, true);
            WriteLiteral("                    <span class=\"userfull\"></span>\r\n");
            EndContext();
#line 76 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\Home\BiletHole.cshtml"

                }

#line default
#line hidden
#line 77 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\Home\BiletHole.cshtml"
                 

            }

#line default
#line hidden
            BeginContext(2546, 22, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n            ");
            EndContext();
            BeginContext(2568, 282, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69a479954f0c4e75a306b865e2ca0ad8", async() => {
                BeginContext(2614, 20, true);
                WriteLiteral("\r\n\r\n                ");
                EndContext();
                BeginContext(2634, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2271a0d7a87d4c3493c0963cc70d09bf", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 87 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\Home\BiletHole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2687, 156, true);
                WriteLiteral("\r\n\r\n\r\n                <button class=\"btn btn-danger disabled mt-5 w-100\" value=\"\" name=\"BiletNumberId\" id=\"submit\">Bilet Satın Al</button>\r\n\r\n\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2850, 289, true);
            WriteLiteral(@"


        </div>


        
        <div class=""col-12 col-md-4 mt-5 border"">
            <div class=""d-none mt-5"" id=""price"">
                <strong> Bilet Fiyatı : 14TL</strong>

            </div>
        </div>
       

    </div>
</div>
<div class=""user""></div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
