#pragma checksum "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91c649d80222dcfec349850714bec78cbf7e9edc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Index.cshtml", typeof(AspNetCore.Views_Post_Index))]
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
#line 1 "/Users/jackal/Projects/Coinrr/Views/_ViewImports.cshtml"
using Coinrr;

#line default
#line hidden
#line 2 "/Users/jackal/Projects/Coinrr/Views/_ViewImports.cshtml"
using Coinrr.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91c649d80222dcfec349850714bec78cbf7e9edc", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97b4a771e626fbea652345ab41d616a4e67cb771", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Coinrr.Models.Post.PostIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Coin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Topic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-back"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-newReply"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 163, true);
            WriteLiteral("\n<div class=\"container body-content\">\n    <div class=\"row postHeader\">\n        <div class=\"postHeading\">\n            <span class=\"postIndexTitle\">\n                ");
            EndContext();
            BeginContext(205, 11, false);
#line 7 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(216, 72, true);
            WriteLiteral("\n            </span>\n            <span id=\"headingBtn\">\n                ");
            EndContext();
            BeginContext(288, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e491d5cd61934d939de1037adcbc47d6", async() => {
                BeginContext(382, 29, true);
                WriteLiteral("\n                    Back to ");
                EndContext();
                BeginContext(412, 14, false);
#line 11 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
                       Write(Model.CoinName);

#line default
#line hidden
                EndContext();
                BeginContext(426, 17, true);
                WriteLiteral("\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
                                                              WriteLiteral(Model.CoinId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(447, 185, true);
            WriteLiteral("\n            </span>\n        </div> \n    </div>\n\n\n    <div class=\"row\" id=\"postIndexContent\">\n        <div class=\"col-md-3 postAuthorContainer\">\n            <div class=\"postAuthorImage\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 632, "\"", 685, 4);
            WriteAttributeValue("", 640, "background-image:", 640, 17, true);
            WriteAttributeValue(" ", 657, "url(", 658, 5, true);
#line 20 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
WriteAttributeValue("", 662, Model.AuthorImageUrl, 662, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 683, ");", 683, 2, true);
            EndWriteAttribute();
            BeginContext(686, 20, true);
            WriteLiteral("></div>\n            ");
            EndContext();
            BeginContext(706, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39f68afe29784b949fed75597ce6f29f", async() => {
                BeginContext(785, 17, true);
                WriteLiteral("\n                ");
                EndContext();
                BeginContext(803, 16, false);
#line 22 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
           Write(Model.AuthorName);

#line default
#line hidden
                EndContext();
                BeginContext(819, 13, true);
                WriteLiteral("\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
                                                              WriteLiteral(Model.AuthorId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(836, 36, true);
            WriteLiteral("\n            <span class=\"postData\">");
            EndContext();
            BeginContext(873, 13, false);
#line 24 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
                              Write(Model.Created);

#line default
#line hidden
            EndContext();
            BeginContext(886, 8, true);
            WriteLiteral("</span>\n");
            EndContext();
#line 25 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
             if (Model.IsAuthorAdmin)
            {

#line default
#line hidden
            BeginContext(946, 59, true);
            WriteLiteral("                <span class=\"isAdmin smaller\">Admin</span>\n");
            EndContext();
#line 28 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1019, 121, true);
            WriteLiteral("        </div>\n        <div class=\"col-md-9 postContentContainer\">\n            <div class=\"postContent\">\n                ");
            EndContext();
            BeginContext(1141, 27, false);
#line 32 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
           Write(Html.Raw(Model.PostContent));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 93, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n    <div class=\"row\" id=\"replyDivider\"></div>\n\n");
            EndContext();
#line 38 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
     if(User.Identity.IsAuthenticated)
    {

#line default
#line hidden
            BeginContext(1306, 61, true);
            WriteLiteral("        <div class=\"row\">\n            <span>\n                ");
            EndContext();
            BeginContext(1367, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c426fc41a3c54abe8d200a9a34a2da7c", async() => {
                BeginContext(1463, 48, true);
                WriteLiteral("\n                    Post Reply\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
                                                                WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1515, 36, true);
            WriteLiteral("\n            </span>\n        </div>\n");
            EndContext();
#line 47 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1557, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 49 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
     if (Model.Replies.Any())
    {
        foreach(var reply in Model.Replies)
        {

#line default
#line hidden
            BeginContext(1648, 151, true);
            WriteLiteral("            <div class=\"row replyContent\">\n                <div class=\"col-md-3 replyAuthorContainer\">\n                    <div class=\"postAuthorImage\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1799, "\"", 1851, 4);
            WriteAttributeValue("", 1807, "background-image:", 1807, 17, true);
            WriteAttributeValue(" ", 1824, "url(", 1825, 5, true);
#line 55 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
WriteAttributeValue("", 1829, reply.AuthorImageUrl, 1829, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 1850, ")", 1850, 1, true);
            EndWriteAttribute();
            BeginContext(1852, 28, true);
            WriteLiteral("></div>\n                    ");
            EndContext();
            BeginContext(1880, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a8cc290f92c4d889d5b75282a0b65a2", async() => {
                BeginContext(1959, 25, true);
                WriteLiteral("\n                        ");
                EndContext();
                BeginContext(1985, 16, false);
#line 57 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
                   Write(reply.AuthorName);

#line default
#line hidden
                EndContext();
                BeginContext(2001, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
                                                                      WriteLiteral(reply.AuthorId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2026, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 59 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
                     if (reply.IsAuthorAdmin)
                    {

#line default
#line hidden
            BeginContext(2095, 96, true);
            WriteLiteral("                        <div class=\"isAdmin smaller\">Admin</div>\n                        <br />\n");
            EndContext();
#line 63 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2213, 26, true);
            WriteLiteral("                    <span>");
            EndContext();
            BeginContext(2240, 13, false);
#line 64 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
                     Write(reply.Created);

#line default
#line hidden
            EndContext();
            BeginContext(2253, 162, true);
            WriteLiteral("</span>\n                </div>\n                <div class=\"col-md-9 replyContentContainer\">\n                    <div class=\"postContent\">\n                        ");
            EndContext();
            BeginContext(2416, 28, false);
#line 68 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
                   Write(Html.Raw(reply.ReplyContent));

#line default
#line hidden
            EndContext();
            BeginContext(2444, 70, true);
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 72 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(2545, 137, true);
            WriteLiteral("        <div class=\"noPosts\">\n            <h3>\n                There are no replies to this post.<br />\n            </h3>\n        </div>\n");
            EndContext();
#line 81 "/Users/jackal/Projects/Coinrr/Views/Post/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2688, 775, true);
            WriteLiteral(@"</div>

<link href=""https://cdn.quilljs.com/1.3.6/quill.snow.css"" rel=""stylesheet"">

<!-- Create the editor container -->
<div id=""editor"">
  <p>Hello World!</p>
  <p>Some initial <strong>bold</strong> text</p>
  <p><br></p>
</div>

<!-- Include the Quill library -->
<script src=""https://cdn.quilljs.com/1.3.6/quill.js""></script>

<!-- Initialize Quill editor -->
<script>
        var quill = new Quill('#editor-container', {
            modules: {
                toolbar: [
                    ['bold', 'italic'],
                    ['link', 'blockquote', 'code-block', 'image'],
                    [{ list: 'ordered' }, { list: 'bullet' }]
                ]
            },
            placeholder: 'Compose an epic...',
            theme: 'snow'
        });


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Coinrr.Models.Post.PostIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
