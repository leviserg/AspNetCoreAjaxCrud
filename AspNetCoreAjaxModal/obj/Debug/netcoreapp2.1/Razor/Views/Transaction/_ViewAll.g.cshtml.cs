#pragma checksum "D:\SergeyDocs\csharp_prjs\AspNetCoreAjaxModal\AspNetCoreAjaxModal\Views\Transaction\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08a5449a59d287e1811eb3399d3c15b39558bad2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction__ViewAll), @"mvc.1.0.view", @"/Views/Transaction/_ViewAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transaction/_ViewAll.cshtml", typeof(AspNetCore.Views_Transaction__ViewAll))]
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
#line 1 "D:\SergeyDocs\csharp_prjs\AspNetCoreAjaxModal\AspNetCoreAjaxModal\Views\_ViewImports.cshtml"
using AspNetCoreAjaxModal;

#line default
#line hidden
#line 2 "D:\SergeyDocs\csharp_prjs\AspNetCoreAjaxModal\AspNetCoreAjaxModal\Views\_ViewImports.cshtml"
using AspNetCoreAjaxModal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08a5449a59d287e1811eb3399d3c15b39558bad2", @"/Views/Transaction/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72669d3ae5ed3c610ed6aa0f7c4a06a5a981f4e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AspNetCoreAjaxModal.Models.TransactionModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowSearchResults", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return ajaxSearch(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return ajaxDelete(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 41, true);
            WriteLiteral("    <div class=\"row pb-2 mb-2\">\r\n        ");
            EndContext();
            BeginContext(106, 621, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be4cf5357bd440e8afe311de5fa6c794", async() => {
                BeginContext(230, 490, true);
                WriteLiteral(@"
            <div class=""form-group"">
                <label for=""SearchPhrase"" class=""control-label""></label>
                <input name=""SearchPhrase"" class=""form-control"" />
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Search"" class=""btn btn-default mx-3"" />
                <a href=""/"" class=""btn btn-default mx-3"">Reset filter</a>
            </div>
            <span id=""filtered"" class=""ml-2"">filtered</span>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(727, 138, true);
            WriteLiteral("\r\n    </div>\r\n    <table class=\"table table-responsive-sm\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(866, 51, false);
#line 19 "D:\SergeyDocs\csharp_prjs\AspNetCoreAjaxModal\AspNetCoreAjaxModal\Views\Transaction\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.BeneficiaryName));

#line default
#line hidden
            EndContext();
            BeginContext(917, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(985, 40, false);
#line 22 "D:\SergeyDocs\csharp_prjs\AspNetCoreAjaxModal\AspNetCoreAjaxModal\Views\Transaction\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.Bank));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1093, 42, false);
#line 25 "D:\SergeyDocs\csharp_prjs\AspNetCoreAjaxModal\AspNetCoreAjaxModal\Views\Transaction\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1135, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1203, 55, false);
#line 28 "D:\SergeyDocs\csharp_prjs\AspNetCoreAjaxModal\AspNetCoreAjaxModal\Views\Transaction\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.TransactionDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 117, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    <button class=\"btn btn-info text-center btn-block\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1375, "\"", 1493, 5);
            WriteAttributeValue("", 1385, "OpenModal(\'", 1385, 11, true);
#line 31 "D:\SergeyDocs\csharp_prjs\AspNetCoreAjaxModal\AspNetCoreAjaxModal\Views\Transaction\_ViewAll.cshtml"
WriteAttributeValue("", 1396, Url.Action("AddOrEdit","Transaction",new { id = 0 },Context.Request.Scheme), 1396, 76, false);

#line default
#line hidden
            WriteAttributeValue("", 1472, "\',", 1472, 2, true);
            WriteAttributeValue(" ", 1474, "\'New", 1475, 5, true);
            WriteAttributeValue(" ", 1479, "Transaction\')", 1480, 14, true);
            EndWriteAttribute();
            BeginContext(1494, 270, true);
            WriteLiteral(@">
                        <!--<i class=""fa fa-calendar-plus-o mr-2""></i>Create New-->
                        <i class=""fa fa-credit-card mr-2""></i>Create New
                    </button>
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 39 "D:\SergeyDocs\csharp_prjs\AspNetCoreAjaxModal\AspNetCoreAjaxModal\Views\Transaction\_ViewAll.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1821, 101, true);
            WriteLiteral("                <tr class=\"py-0 my-0 text-small\">\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1923, 50, false);
#line 43 "D:\SergeyDocs\csharp_prjs\AspNetCoreAjaxModal\AspNetCoreAjaxModal\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BeneficiaryName));

#line default
#line hidden
            EndContext();
            BeginContext(1973, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2053, 48, false);
#line 46 "D:\SergeyDocs\csharp_prjs\AspNetCoreAjaxModal\AspNetCoreAjaxModal\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Bank.BankName));

#line default
#line hidden
            EndContext();
            BeginContext(2101, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2181, 41, false);
#line 49 "D:\SergeyDocs\csharp_prjs\AspNetCoreAjaxModal\AspNetCoreAjaxModal\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2222, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2302, 54, false);
#line 52 "D:\SergeyDocs\csharp_prjs\AspNetCoreAjaxModal\AspNetCoreAjaxModal\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TransactionDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(2356, 135, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <button class=\"btn btn-secondary px-2\" style=\"width:49%\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2491, "\"", 2617, 4);
            WriteAttributeValue("", 2501, "OpenModal(\'", 2501, 11, true);
#line 55 "D:\SergeyDocs\csharp_prjs\AspNetCoreAjaxModal\AspNetCoreAjaxModal\Views\Transaction\_ViewAll.cshtml"
WriteAttributeValue("", 2512, Url.Action("AddOrEdit","Transaction", new { id = item.TransactionId }, Context.Request.Scheme), 2512, 95, false);

#line default
#line hidden
            WriteAttributeValue("", 2607, "\',", 2607, 2, true);
            WriteAttributeValue(" ", 2609, "\'Edit\')", 2610, 8, true);
            EndWriteAttribute();
            BeginContext(2618, 129, true);
            WriteLiteral(">\r\n                            <i class=\"fa fa-pencil mr-2\"></i>Edit\r\n                        </button>\r\n                        ");
            EndContext();
            BeginContext(2747, 261, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1ba9d241b78413c94a8f15dd0da8e99", async() => {
                BeginContext(2861, 140, true);
                WriteLiteral("\r\n                            <input type=\"submit\" class=\"btn btn-danger px-2\" value=\"Delete\" style=\"width:49%\" />\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "D:\SergeyDocs\csharp_prjs\AspNetCoreAjaxModal\AspNetCoreAjaxModal\Views\Transaction\_ViewAll.cshtml"
                                                    WriteLiteral(item.TransactionId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3008, 385, true);
            WriteLiteral(@"
                        <!--
                            <button class=""btn btn-danger px-2"" style=""width:49%"" onclick=""DeleteRequest(new { id = item.TransactionId })"">
                                <i class=""fa fa-bitbucket mr-2""></i>Delete
                            </button>
                        -->
                        <!--<a asp-action=""AddOrEdit"" asp-route-id=""");
            EndContext();
            BeginContext(3394, 18, false);
#line 66 "D:\SergeyDocs\csharp_prjs\AspNetCoreAjaxModal\AspNetCoreAjaxModal\Views\Transaction\_ViewAll.cshtml"
                                                               Write(item.TransactionId);

#line default
#line hidden
            EndContext();
            BeginContext(3412, 126, true);
            WriteLiteral("\">Edit</a>-->\r\n                        <!--<a class=\"btn btn-danger px-2\" style=\"width:48%\" asp-action=\"Delete\" asp-route-id=\"");
            EndContext();
            BeginContext(3539, 18, false);
#line 67 "D:\SergeyDocs\csharp_prjs\AspNetCoreAjaxModal\AspNetCoreAjaxModal\Views\Transaction\_ViewAll.cshtml"
                                                                                                          Write(item.TransactionId);

#line default
#line hidden
            EndContext();
            BeginContext(3557, 67, true);
            WriteLiteral("\">Delete</a>-->\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 70 "D:\SergeyDocs\csharp_prjs\AspNetCoreAjaxModal\AspNetCoreAjaxModal\Views\Transaction\_ViewAll.cshtml"
                }

#line default
#line hidden
            BeginContext(3643, 38, true);
            WriteLiteral("            </tbody>\r\n        </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AspNetCoreAjaxModal.Models.TransactionModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
