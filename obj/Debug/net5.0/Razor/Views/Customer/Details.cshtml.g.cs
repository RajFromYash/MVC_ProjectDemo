#pragma checksum "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Customer\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3df6411d53a2d439a3bfffd08ba732b34938a902da85fcd369331b6d4a269862"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Details), @"mvc.1.0.view", @"/Views/Customer/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3df6411d53a2d439a3bfffd08ba732b34938a902da85fcd369331b6d4a269862", @"/Views/Customer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4150ef6c570f9003ef4575243952c80d49f0ee15c6e3a38d1485492c71a0e53f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_InMemory_CRUD_Demo.Models.Customer>
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
            WriteLiteral(" \r\n<h1>Details</h1>\r\n \r\n<div>\r\n<h4>Customer</h4>\r\n<hr />\r\n<dl class=\"row\">\r\n<dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 10 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Customer\Details.cshtml"
             Html.DisplayNameFor(model => model.CustomerId)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</dt>\r\n<dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 13 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Customer\Details.cshtml"
             Html.DisplayFor(model => model.CustomerId)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</dd>\r\n<dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 16 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Customer\Details.cshtml"
             Html.DisplayNameFor(model => model.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</dt>\r\n<dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 19 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Customer\Details.cshtml"
             Html.DisplayFor(model => model.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</dd>\r\n<dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 22 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Customer\Details.cshtml"
             Html.DisplayNameFor(model => model.Address)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</dt>\r\n<dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 25 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Customer\Details.cshtml"
             Html.DisplayFor(model => model.Address)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</dd>\r\n<dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 28 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Customer\Details.cshtml"
             Html.DisplayNameFor(model => model.DOB)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</dt>\r\n<dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 31 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Customer\Details.cshtml"
             Html.DisplayFor(model => model.DOB)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</dd>\r\n<dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 34 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Customer\Details.cshtml"
             Html.DisplayNameFor(model => model.PAN_Number)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</dt>\r\n<dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 37 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Customer\Details.cshtml"
             Html.DisplayFor(model => model.PAN_Number)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</dd>\r\n</dl>\r\n</div>\r\n<div>\r\n    ");
            Write(
#nullable restore
#line 42 "D:\.Net\MVC\MVC_InMemory_CRUD_Demo\Views\Customer\Details.cshtml"
     Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" |\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3df6411d53a2d439a3bfffd08ba732b34938a902da85fcd369331b6d4a2698627198", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_InMemory_CRUD_Demo.Models.Customer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
