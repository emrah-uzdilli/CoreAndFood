#pragma checksum "C:\Users\adssa\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5be9e7bc08dafa9177e3df23ad012b24e16e868b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5be9e7bc08dafa9177e3df23ad012b24e16e868b", @"/Views/Category/Index.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoreAndFood.Data.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\adssa\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
  

    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2> Categori List </h2>\r\n<br />\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Category Name</th>\r\n        <th>Status</th>\r\n        <th>Delete</th>\r\n        <th>update</th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\adssa\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 22 "C:\Users\adssa\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
   Write(x.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 23 "C:\Users\adssa\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
   Write(x.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\adssa\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
   Write(x.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 498, "\"", 543, 2);
            WriteAttributeValue("", 505, "/Category/CategoryDelete/", 505, 25, true);
#nullable restore
#line 25 "C:\Users\adssa\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
WriteAttributeValue("", 530, x.CategoryID, 530, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 595, "\"", 637, 2);
            WriteAttributeValue("", 602, "/Category/CategoryGet/", 602, 22, true);
#nullable restore
#line 26 "C:\Users\adssa\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
WriteAttributeValue("", 624, x.CategoryID, 624, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n\r\n</tr>\r\n");
#nullable restore
#line 29 "C:\Users\adssa\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n<a href=\"/Category/CategoryAdd\" class=\"btn btn-primary\">New Category</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoreAndFood.Data.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591