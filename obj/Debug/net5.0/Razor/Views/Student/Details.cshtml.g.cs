#pragma checksum "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Student\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c540f668976b4d8493c85c31f2468086b9222acf100d5f9a4129756010ebf957"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Details), @"mvc.1.0.view", @"/Views/Student/Details.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\_ViewImports.cshtml"
using MVC_InMemory_CRUD_Demo

#nullable disable
    ;
#nullable restore
#line 2 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\_ViewImports.cshtml"
using MVC_InMemory_CRUD_Demo.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c540f668976b4d8493c85c31f2468086b9222acf100d5f9a4129756010ebf957", @"/Views/Student/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4150ef6c570f9003ef4575243952c80d49f0ee15c6e3a38d1485492c71a0e53f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_InMemory_CRUD_Demo.Models.Student>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n<h1>Details</h1>\r\n \r\n<div>\r\n<h4>Student</h4>\r\n<hr />\r\n<dl class=\"row\">\r\n<dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 10 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Student\Details.cshtml"
             Html.DisplayNameFor(model => model.Id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</dt>\r\n<dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 13 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Student\Details.cshtml"
             Html.DisplayFor(model => model.Id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</dd>\r\n<dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 16 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Student\Details.cshtml"
             Html.DisplayNameFor(model => model.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</dt>\r\n<dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 19 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Student\Details.cshtml"
             Html.DisplayFor(model => model.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</dd>\r\n<dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 22 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Student\Details.cshtml"
             Html.DisplayNameFor(model => model.Marks)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</dt>\r\n<dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 25 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Student\Details.cshtml"
             Html.DisplayFor(model => model.Marks)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</dd>\r\n</dl>\r\n</div>\r\n<div>\r\n    ");
            Write(
#nullable restore
#line 30 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Student\Details.cshtml"
     Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" |\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c540f668976b4d8493c85c31f2468086b9222acf100d5f9a4129756010ebf9575872", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_InMemory_CRUD_Demo.Models.Student> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
