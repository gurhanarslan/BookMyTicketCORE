#pragma checksum "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\TicketAdmin\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eabd409a687b2cd90be5815a13561d99a5f47b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TicketAdmin_UserList), @"mvc.1.0.view", @"/Views/TicketAdmin/UserList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TicketAdmin/UserList.cshtml", typeof(AspNetCore.Views_TicketAdmin_UserList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eabd409a687b2cd90be5815a13561d99a5f47b4", @"/Views/TicketAdmin/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea31a4893e22a04b97cb724226b5ac32d816e436", @"/Views/_ViewImports.cshtml")]
    public class Views_TicketAdmin_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\TicketAdmin\UserList.cshtml"
  
    ViewData["Title"] = "UserList";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(133, 221, true);
            WriteLiteral("\r\n\r\n<table class=\"table table-bordered table-striped\" >\r\n    <thead>\r\n        <tr>\r\n            <th>User Id</th>\r\n            <th>User Name</th>\r\n            <th>User Email</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 17 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\TicketAdmin\UserList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(403, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(442, 7, false);
#line 20 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\TicketAdmin\UserList.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(449, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(477, 13, false);
#line 21 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\TicketAdmin\UserList.cshtml"
               Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(490, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(518, 10, false);
#line 22 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\TicketAdmin\UserList.cshtml"
               Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(528, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 24 "C:\Users\gurhan\source\repos\BookTicket\BookTicket\Views\TicketAdmin\UserList.cshtml"
        }

#line default
#line hidden
            BeginContext(565, 31, true);
            WriteLiteral("       \r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
