#pragma checksum "C:\Users\Ekene\Desktop\My Project\DevForum\DevelopersForum\Views\Profile\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f2e8d60d0b49e8d8427f9e9b57ff1257f6eb72c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Detail), @"mvc.1.0.view", @"/Views/Profile/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/Detail.cshtml", typeof(AspNetCore.Views_Profile_Detail))]
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
#line 1 "C:\Users\Ekene\Desktop\My Project\DevForum\DevelopersForum\Views\_ViewImports.cshtml"
using DevelopersForum;

#line default
#line hidden
#line 2 "C:\Users\Ekene\Desktop\My Project\DevForum\DevelopersForum\Views\_ViewImports.cshtml"
using DevelopersForum.Models;

#line default
#line hidden
#line 1 "C:\Users\Ekene\Desktop\My Project\DevForum\DevelopersForum\Views\Profile\Detail.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f2e8d60d0b49e8d8427f9e9b57ff1257f6eb72c", @"/Views/Profile/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b2dd951a252cbffdc9174ac72f95bae8cd995a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevelopersForum.ViewModels.Profile.ProfileModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-2 col-form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control custom-file-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadPhoto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(94, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(147, 302, true);
            WriteLiteral(@"
<div class=""container body-content"">
    <div class=""row sectionHeader"">
        <div class=""sectionHeading col-md-12"">
            User Profile
        </div>       
    </div>
    <div class=""row"" id=""forumIndexContent"">
        <div class=""col-md-4"">
            <div id=""userProfileImage""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 449, "\"", 502, 4);
            WriteAttributeValue("", 457, "background-image:", 457, 17, true);
            WriteAttributeValue(" ", 474, "url(", 475, 5, true);
#line 14 "C:\Users\Ekene\Desktop\My Project\DevForum\DevelopersForum\Views\Profile\Detail.cshtml"
WriteAttributeValue("", 479, Model.ProfileImageUrl, 479, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 501, ")", 501, 1, true);
            EndWriteAttribute();
            BeginContext(503, 9, true);
            WriteLiteral("></div>\r\n");
            EndContext();
#line 15 "C:\Users\Ekene\Desktop\My Project\DevForum\DevelopersForum\Views\Profile\Detail.cshtml"
             if (User.Identity.Name == Model.UserName)
            { 

#line default
#line hidden
            BeginContext(584, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(600, 1286, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f2e8d60d0b49e8d8427f9e9b57ff1257f6eb72c7202", async() => {
                BeginContext(700, 76, true);
                WriteLiteral("\r\n                    <div class=\"form-group row\">\r\n                        ");
                EndContext();
                BeginContext(776, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f2e8d60d0b49e8d8427f9e9b57ff1257f6eb72c7662", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 19 "C:\Users\Ekene\Desktop\My Project\DevForum\DevelopersForum\Views\Profile\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ImageUpload);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(845, 138, true);
                WriteLiteral("\r\n                        <div class=\"col-md-10\">\r\n                            <div class=\"custom-file\">\r\n                                ");
                EndContext();
                BeginContext(983, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9f2e8d60d0b49e8d8427f9e9b57ff1257f6eb72c9514", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 22 "C:\Users\Ekene\Desktop\My Project\DevForum\DevelopersForum\Views\Profile\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ImageUpload);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1053, 290, true);
                WriteLiteral(@"
                                <label class=""custom-file-label"">Choose photo...</label>
                            </div>
                        </div>
                    </div>
                    <button type=""submit"" id=""btn-profile"" class=""btn btn-primary"">Submit</button>

");
                EndContext();
                DefineSection("Scripts", async() => {
                    BeginContext(1381, 479, true);
                    WriteLiteral(@"
                        <script>
                            $(document).ready(function () {
                                $('.custom-file-input').on(""change"", function () {
                                    var fileName = $(this).val().split(""\\"").pop();
                                    $(this).next('.custom-file-label').html(fileName);
                                });
                            });
                        </script>
                    ");
                    EndContext();
                }
                );
                BeginContext(1863, 16, true);
                WriteLiteral("                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1886, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "C:\Users\Ekene\Desktop\My Project\DevForum\DevelopersForum\Views\Profile\Detail.cshtml"

            }

#line default
#line hidden
            BeginContext(1905, 80, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-md-8\">\r\n            <span id=\"userName\">");
            EndContext();
            BeginContext(1986, 14, false);
#line 44 "C:\Users\Ekene\Desktop\My Project\DevForum\DevelopersForum\Views\Profile\Detail.cshtml"
                           Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2000, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 45 "C:\Users\Ekene\Desktop\My Project\DevForum\DevelopersForum\Views\Profile\Detail.cshtml"
             if (@Model.IsAdmin)
            {

#line default
#line hidden
            BeginContext(2058, 161, true);
            WriteLiteral("                <span class=\"isAdmin\" style=\"display: inline-block; padding: 3px;background-color: #FFEB38; color:#000;font-family:\'Roboto Mono\';\">Admin</span>\r\n");
            EndContext();
#line 48 "C:\Users\Ekene\Desktop\My Project\DevForum\DevelopersForum\Views\Profile\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(2234, 50, true);
            WriteLiteral("            <span id=\"userRating\">Current Rating: ");
            EndContext();
            BeginContext(2285, 16, false);
#line 49 "C:\Users\Ekene\Desktop\My Project\DevForum\DevelopersForum\Views\Profile\Detail.cshtml"
                                             Write(Model.UserRating);

#line default
#line hidden
            EndContext();
            BeginContext(2301, 54, true);
            WriteLiteral("</span>\r\n            <span id=\"userEmailLabel\">Email: ");
            EndContext();
            BeginContext(2356, 11, false);
#line 50 "C:\Users\Ekene\Desktop\My Project\DevForum\DevelopersForum\Views\Profile\Detail.cshtml"
                                        Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2367, 63, true);
            WriteLiteral("</span>\r\n            <span id=\"userCreatedLabel\">Member Since: ");
            EndContext();
            BeginContext(2431, 17, false);
#line 51 "C:\Users\Ekene\Desktop\My Project\DevForum\DevelopersForum\Views\Profile\Detail.cshtml"
                                                 Write(Model.MemberSince);

#line default
#line hidden
            EndContext();
            BeginContext(2448, 45, true);
            WriteLiteral("</span>\r\n        </div>\r\n    </div>  \r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUsers> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevelopersForum.ViewModels.Profile.ProfileModel> Html { get; private set; }
    }
}
#pragma warning restore 1591