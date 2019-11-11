#pragma checksum "C:\Users\Eliza\source\repos\CelebrationAPI\CelebrationAPI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e340bb189dd0f0e083b234817046c6552c2bbec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Eliza\source\repos\CelebrationAPI\CelebrationAPI\Views\_ViewImports.cshtml"
using CelebrationAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eliza\source\repos\CelebrationAPI\CelebrationAPI\Views\_ViewImports.cshtml"
using CelebrationAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e340bb189dd0f0e083b234817046c6552c2bbec", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"761fa45a2a44fed7abae8fe641c2a5c033ad9b76", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MovieDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Eliza\source\repos\CelebrationAPI\CelebrationAPI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e340bb189dd0f0e083b234817046c6552c2bbec4322", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n");
                WriteLiteral(@"

    <style>
        * {
            outline: none;
        }

        html, body {
            height: 100%;
            min-height: 100%;
        }

        body {
            margin: 0;
            background-image: url(""Images/329633.jpg"");
        }

        .bg-image {
            /* The image used */
            background-image: url(""Images/Avengers.jpg"");
            /* Add the blur effect */
            filter: blur(8px);
            -webkit-filter: blur(8px);
            /* Full height */
            height: 100%;
            /* Center and scale the image nicely */
            background-position: center;
            background-repeat: no-repeat;
            background-size: cover;
        }

        .tb {
            display: table;
            width: 100%;
        }

        .td {
            display: table-cell;
            vertical-align: middle;
        }

        input, button {
            color: #fff;
            font-family: Nunito;
            ");
                WriteLiteral(@"padding: 0;
            margin: 0;
            border: 0;
            background-color: transparent;
        }

        #cover {
            position: absolute;
            top: 50%;
            left: 0;
            right: 0;
            width: 550px;
            padding: 35px;
            margin: -83px auto 0 auto;
            background-color: #ff7575;
            border-radius: 20px;
            box-shadow: 0 10px 40px #ff7c7c, 0 0 0 20px #ffffffeb;
            transform: scale(0.6);
        }

        form {
            height: 96px;
        }

        input[type=""text""] {
            width: 100%;
            height: 96px;
            font-size: 40px;
            line-height: 1;
        }

            input[type=""text""]::placeholder {
                color: #e16868;
            }

        #s-cover {
            width: 1px;
            padding-left: 35px;
        }

        button {
            position: relative;
            display: block;
            width: 84p");
                WriteLiteral(@"x;
            height: 96px;
            cursor: pointer;
        }

        #s-circle {
            position: relative;
            top: -8px;
            left: 0;
            width: 43px;
            height: 43px;
            margin-top: 0;
            border-width: 15px;
            border: 15px solid #fff;
            background-color: transparent;
            border-radius: 50%;
            transition: 0.5s ease all;
        }

        button span {
            position: absolute;
            top: 68px;
            left: 50px;
            display: block;
            width: 45px;
            height: 15px;
            background-color: transparent;
            border-radius: 10px;
            transform: rotateZ(52deg);
            transition: 0.5s ease all;
        }

            button span:before, button span:after {
                content: '';
                position: absolute;
                bottom: 0;
                right: 0;
                width: 45px;
     ");
                WriteLiteral(@"           height: 15px;
                background-color: #fff;
                border-radius: 10px;
                transform: rotateZ(0);
                transition: 0.5s ease all;
            }

        #s-cover:hover #s-circle {
            top: -1px;
            width: 67px;
            height: 15px;
            border-width: 0;
            background-color: #fff;
            border-radius: 20px;
        }

        #s-cover:hover span {
            top: 50%;
            left: 56px;
            width: 25px;
            margin-top: -9px;
            transform: rotateZ(0);
        }

        #s-cover:hover button span:before {
            bottom: 11px;
            transform: rotateZ(52deg);
        }

        #s-cover:hover button span:after {
            bottom: -11px;
            transform: rotateZ(-52deg);
        }

        #s-cover:hover button span:before, #s-cover:hover button span:after {
            right: -6px;
            width: 40px;
            background-c");
                WriteLiteral("olor: #fff;\r\n        }\r\n    </style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e340bb189dd0f0e083b234817046c6552c2bbec9695", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"bg-image\"></div>\r\n    <div id=\"cover\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e340bb189dd0f0e083b234817046c6552c2bbec10029", async() => {
                    WriteLiteral(@"
            <div class=""tb"">
                <div class=""td"">
                    <input type=""text"" name=""Title"" placeholder=""Search for Movies"" required />
                </div>
                <div class=""td"" id=""s-cover"">
                    <button type=""submit"">
                        <div id=""s-circle""></div>
                        <span></span>
                    </button>
                </div>
            </div>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591