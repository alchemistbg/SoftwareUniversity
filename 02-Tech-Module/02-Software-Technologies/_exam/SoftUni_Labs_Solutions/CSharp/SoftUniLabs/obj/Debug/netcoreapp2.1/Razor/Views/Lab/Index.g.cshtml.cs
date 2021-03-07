#pragma checksum "D:\___exam\SoftUni_Labs_Solutions\CSharp\SoftUniLabs\Views\Lab\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44fe80c4927cd17da27fb55e377d87c57510bc02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lab_Index), @"mvc.1.0.view", @"/Views/Lab/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lab/Index.cshtml", typeof(AspNetCore.Views_Lab_Index))]
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
#line 1 "D:\___exam\SoftUni_Labs_Solutions\CSharp\SoftUniLabs\Views\_ViewImports.cshtml"
using SoftUniLabs;

#line default
#line hidden
#line 2 "D:\___exam\SoftUni_Labs_Solutions\CSharp\SoftUniLabs\Views\_ViewImports.cshtml"
using SoftUniLabs.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44fe80c4927cd17da27fb55e377d87c57510bc02", @"/Views/Lab/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5768b016bc1f66cf9a56ce780878fe9e94860d93", @"/Views/_ViewImports.cshtml")]
    public class Views_Lab_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\___exam\SoftUni_Labs_Solutions\CSharp\SoftUniLabs\Views\Lab\Index.cshtml"
  
    ViewData["Title"] = "SoftUni Labs";

#line default
#line hidden
            BeginContext(75, 574, true);
            WriteLiteral(@"<div class=""wrapper"">
    <div class=""lab-create"">
        <div class=""create-header"">
            SoftUni Labs
        </div>
    </div>
    <br />
    <div class=""button-holder"">
        <a type=""button"" href=""/create"" class=""log-button"">Create Lab</a>
    </div>
    <div class=""content"">
        <div class=""header"">
            <div class=""lab-label"">Name</div>
            <div class=""lab-label"">Capacity</div>
            <div class=""lab-label"">Status</div>
            <div class=""lab-label"">Actions</div>
        </div>
        <div class=""main"">
");
            EndContext();
#line 24 "D:\___exam\SoftUni_Labs_Solutions\CSharp\SoftUniLabs\Views\Lab\Index.cshtml"
             foreach (var lab in Model.ToList())
            {

#line default
#line hidden
            BeginContext(714, 103, true);
            WriteLiteral("                <div class=\"lab\">\r\n                    <div class=\"lab-name\">\r\n                        ");
            EndContext();
            BeginContext(819, 8, false);
#line 28 "D:\___exam\SoftUni_Labs_Solutions\CSharp\SoftUniLabs\Views\Lab\Index.cshtml"
                    Write(lab.Name);

#line default
#line hidden
            EndContext();
            BeginContext(828, 98, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"lab-name\">\r\n                        ");
            EndContext();
            BeginContext(928, 12, false);
#line 31 "D:\___exam\SoftUni_Labs_Solutions\CSharp\SoftUniLabs\Views\Lab\Index.cshtml"
                    Write(lab.Capacity);

#line default
#line hidden
            EndContext();
            BeginContext(941, 98, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"lab-name\">\r\n                        ");
            EndContext();
            BeginContext(1041, 10, false);
#line 34 "D:\___exam\SoftUni_Labs_Solutions\CSharp\SoftUniLabs\Views\Lab\Index.cshtml"
                    Write(lab.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1052, 101, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"lab-actions\">\r\n                        ");
            EndContext();
            BeginContext(1154, 91, false);
#line 37 "D:\___exam\SoftUni_Labs_Solutions\CSharp\SoftUniLabs\Views\Lab\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", "Lab", new { id = lab.Id }, new { @class = "edit-button" }));

#line default
#line hidden
            EndContext();
            BeginContext(1245, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1272, 98, false);
#line 38 "D:\___exam\SoftUni_Labs_Solutions\CSharp\SoftUniLabs\Views\Lab\Index.cshtml"
                   Write(Html.ActionLink("Archive", "Delete", "Lab", new { id = lab.Id }, new { @class = "delete-button" }));

#line default
#line hidden
            EndContext();
            BeginContext(1370, 54, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 41 "D:\___exam\SoftUni_Labs_Solutions\CSharp\SoftUniLabs\Views\Lab\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1439, 34, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab>> Html { get; private set; }
    }
}
#pragma warning restore 1591