#pragma checksum "F:\Software project\IPC - Copy Standard\Views\Account\ClerkDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b94eda5308ecc7fe69227cc8df6ced13e979e98c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ClerkDashboard), @"mvc.1.0.view", @"/Views/Account/ClerkDashboard.cshtml")]
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
#line 1 "F:\Software project\IPC - Copy Standard\Views\_ViewImports.cshtml"
using IPC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Software project\IPC - Copy Standard\Views\_ViewImports.cshtml"
using IPC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b94eda5308ecc7fe69227cc8df6ced13e979e98c", @"/Views/Account/ClerkDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25c64facbdcffbe6c4c28120e642ba835cab5703", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_ClerkDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPC.ViewModels.RedBoxLayoutViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/common.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Software project\IPC - Copy Standard\Views\Account\ClerkDashboard.cshtml"
   Layout = "_RedBoxLayout";



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b94eda5308ecc7fe69227cc8df6ced13e979e98c6002", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b94eda5308ecc7fe69227cc8df6ced13e979e98c6268", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b94eda5308ecc7fe69227cc8df6ced13e979e98c7447", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b94eda5308ecc7fe69227cc8df6ced13e979e98c9330", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 17 "F:\Software project\IPC - Copy Standard\Views\Account\ClerkDashboard.cshtml"
     if (ViewBag.Message != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script type=\"text/javascript\">\r\n            window.onload = function () {\r\n                alert(\"");
#nullable restore
#line 21 "F:\Software project\IPC - Copy Standard\Views\Account\ClerkDashboard.cshtml"
                  Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n            };\r\n        </script>\r\n");
#nullable restore
#line 24 "F:\Software project\IPC - Copy Standard\Views\Account\ClerkDashboard.cshtml"

    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <div class=""redbox"">

    </div>



    <h3 style=""color:#160B5B; position: absolute; top: 60px; left: 20px"">Clerk's Dashboard</h3>

    <div class=""card"" style=""width:95%;margin:auto"">
        <div class=""card-header"">

        </div>
        <div class=""card-body"" style=""display: flex; align-items: center; margin: auto;  "">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b94eda5308ecc7fe69227cc8df6ced13e979e98c10791", async() => {
                    WriteLiteral(@"
                <table class=""table-bordered"" style=""width:1000px"">
                    <tr>
                        <td>
                            <div class=""row"" style=""margin:20px "">
                                <label class=""col-sm"">MRN<span style=""color:red"">(MRN)</span></label>
                                <textarea class=""form-control"" asp-page=""ClerkDashboard"" type=""number"" id=""mrn"">");
#nullable restore
#line 45 "F:\Software project\IPC - Copy Standard\Views\Account\ClerkDashboard.cshtml"
                                                                                                           Write(Model.patient.PatientId);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</textarea>
                            </div>
                        </td>

                        <td>
                            <div class=""row"" style=""margin:20px"">
                                <label class=""col-sm"">Name<span style=""color:red"">(PTN)</span></label>
                                <textarea class=""form-control "" type=""text"" id=""name"">");
#nullable restore
#line 52 "F:\Software project\IPC - Copy Standard\Views\Account\ClerkDashboard.cshtml"
                                                                                 Write(Model.patient.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</textarea>
                            </div>

                        </td>
                        <td>
                            <div class=""row"" style=""margin:20px"">
                                <label class=""col-sm"">Date of Birth<span style=""color:red"">(DOB)</span></label>
                                <textarea class=""form-control"" type=""text"" id=""address"">");
#nullable restore
#line 59 "F:\Software project\IPC - Copy Standard\Views\Account\ClerkDashboard.cshtml"
                                                                                   Write(Model.patient.Dob);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</textarea>
                            </div>

                        </td>
                        <td>
                            <div class=""row"" style=""margin:20px"">
                                <label class=""col-sm"">NIC<span style=""color:red"">(NIC)</span></label>
                                <textarea class=""form-control"" type=""text"" id=""nic"">");
#nullable restore
#line 66 "F:\Software project\IPC - Copy Standard\Views\Account\ClerkDashboard.cshtml"
                                                                               Write(Model.patient.Nic);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</textarea>
                            </div>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class=""row"" style=""margin:20px"">
                                <label class=""col-sm"">TP<span style=""color:red"">(TP)</span></label>
                                <textarea class=""form-control"" type=""text"" id=""telephone"">");
#nullable restore
#line 75 "F:\Software project\IPC - Copy Standard\Views\Account\ClerkDashboard.cshtml"
                                                                                     Write(Model.patient.Tp);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</textarea>
                            </div>

                        </td>
                        <td>
                            <div class=""row"" style=""margin:20px"">
                                <label class=""col-sm""> District <span style=""color:red"">(DIS)</span></label>
                                <textarea class=""form-control"" type=""text"" id=""district"">");
#nullable restore
#line 82 "F:\Software project\IPC - Copy Standard\Views\Account\ClerkDashboard.cshtml"
                                                                                    Write(Model.patient.District);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</textarea>
                            </div>

                        </td>

                        <td>
                            <div class=""row"" style=""margin:20px"">
                                <label class=""col-sm"">Blood Group<span style=""color:red"">(BG)</span></label>
                                <textarea class=""form-control "" type=""text"" id=""BG"">");
#nullable restore
#line 90 "F:\Software project\IPC - Copy Standard\Views\Account\ClerkDashboard.cshtml"
                                                                               Write(Model.patient.Bloodgrp);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</textarea>
                            </div>

                        </td>
                        <td>
                            <div class=""row"" style=""margin:20px"">
                                <label class=""col-sm"">EMAIL<span style=""color:red"">(EM)</span></label>
                                <textarea class=""form-control"" type=""text"" id=""email"">");
#nullable restore
#line 97 "F:\Software project\IPC - Copy Standard\Views\Account\ClerkDashboard.cshtml"
                                                                                 Write(Model.patient.Email);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</textarea>
                            </div>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class=""row"" style=""margin:20px"">
                                <label class=""col-sm"">Gender<span style=""color:red"">(GEN)</span></label>
                                <textarea class=""form-control"" type=""text"" id=""gender"">");
#nullable restore
#line 106 "F:\Software project\IPC - Copy Standard\Views\Account\ClerkDashboard.cshtml"
                                                                                  Write(Model.patient.Gender);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</textarea>
                            </div>
                        </td>
                        <td>
                            <div class=""row"" style=""margin:20px"">
                                <label class=""col-sm""> Occupation <span style=""color:red"">(OCC)</span></label>
                                <textarea class=""form-control "" type=""text"" id=""occupation"">");
#nullable restore
#line 112 "F:\Software project\IPC - Copy Standard\Views\Account\ClerkDashboard.cshtml"
                                                                                       Write(Model.patient.Occupation);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</textarea>
                            </div>

                        </td>

                        <td colspan=""2"">
                            <div class=""row"" style=""margin:20px"">
                                <label class=""col-sm""> Address <span style=""color:red"">(ADR)</span></label>
                                <textarea class=""form-control "" type=""text"" id=""Address"">");
#nullable restore
#line 120 "F:\Software project\IPC - Copy Standard\Views\Account\ClerkDashboard.cshtml"
                                                                                    Write(Model.patient.Address);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</textarea>\r\n                            </div>\r\n\r\n                        </td>\r\n\r\n                    </tr>\r\n                </table>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n        <div class=\"card-footer\">\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n    <br />\r\n    <br />\r\n    <br />\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPC.ViewModels.RedBoxLayoutViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
