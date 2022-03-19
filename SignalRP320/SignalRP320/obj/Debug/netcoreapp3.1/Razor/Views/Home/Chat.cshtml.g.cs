#pragma checksum "C:\Users\hp\Source\Repos\SignalRP320\SignalRP320\Views\Home\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e4c8f46ef16817f5c0550116b591679b956e4b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Chat), @"mvc.1.0.view", @"/Views/Home/Chat.cshtml")]
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
#line 1 "C:\Users\hp\Source\Repos\SignalRP320\SignalRP320\Views\_ViewImports.cshtml"
using SignalRP320;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Source\Repos\SignalRP320\SignalRP320\Views\_ViewImports.cshtml"
using SignalRP320.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Source\Repos\SignalRP320\SignalRP320\Views\_ViewImports.cshtml"
using SignalRP320.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e4c8f46ef16817f5c0550116b591679b956e4b8", @"/Views/Home/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6427be2045fbada81caae17c2a4bb68c853ec577", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\Source\Repos\SignalRP320\SignalRP320\Views\Home\Chat.cshtml"
  
    ViewData["Title"] = "Chat";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Chat</h1>
<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-8"">
            <div class=""container"">
                <div class=""row"">&nbsp;</div>
                <div class=""row"">
                    <div class=""col-4""><input type=""hidden"" id=""singleUserId"" name=""singleUserId""");
            BeginWriteAttribute("value", " value=\"", 375, "\"", 383, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></div>
                </div>
                <div class=""row"">
                    <div class=""col-2"">Message</div>
                    <div class=""col-4""><input type=""text"" id=""messageInput"" /></div>
                </div>
                <div class=""row"">&nbsp;</div>
                <div class=""row"">
                    <div class=""col-6"">
                        <input type=""button"" id=""sendButton"" value=""Send Message"" />
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-12"">
                    <hr />
                </div>
            </div>
            <div class=""row"">
                <div class=""col-6"">
                    <ul id=""messagesList""></ul>
                </div>
            </div>
        </div>
        <div class=""col-lg-4"">
            <ul class=""list-group"">
");
#nullable restore
#line 39 "C:\Users\hp\Source\Repos\SignalRP320\SignalRP320\Views\Home\Chat.cshtml"
                 foreach (var user in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item user-item\"><span");
            BeginWriteAttribute("id", " id=\"", 1410, "\"", 1423, 1);
#nullable restore
#line 41 "C:\Users\hp\Source\Repos\SignalRP320\SignalRP320\Views\Home\Chat.cshtml"
WriteAttributeValue("", 1415, user.Id, 1415, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=", 1424, "", 1482, 1);
#nullable restore
#line 41 "C:\Users\hp\Source\Repos\SignalRP320\SignalRP320\Views\Home\Chat.cshtml"
WriteAttributeValue("", 1431, user.ConnectionId==null?"bg-offline":"bg-online", 1431, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:15px;height:15px; border-radius:50%; display:inline-block; \"></span>");
#nullable restore
#line 41 "C:\Users\hp\Source\Repos\SignalRP320\SignalRP320\Views\Home\Chat.cshtml"
                                                                                                                                                                                                                Write(user.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 42 "C:\Users\hp\Source\Repos\SignalRP320\SignalRP320\Views\Home\Chat.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e4c8f46ef16817f5c0550116b591679b956e4b87140", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        var connection = new signalR.HubConnectionBuilder().withUrl(""/chatHub"").build();
        connection.start()
        console.log(connection)
        $(""#sendButton"").click(function () {
            var singleUser = $(""#singleUserId"").val();
            var message = $(""#messageInput"").val()
            connection.invoke(""SendMessage"", singleUser, message)
        })
        $("".user-item"").click(function () {
            let userId = $(this).children("":first"").attr(""id"")
            $(""#singleUserId"").val(userId)
        })
        connection.on(""ReceiveMessage"", function (user, message,data) {
            var li = document.createElement(""li"");
            li.innerHTML = user + "":"" + message + "" "" + data
            document.getElementById(""messagesList"").appendChild(li);
        })
        connection.on(""UserConnected"", function (Id) {
            let elm = document.getElementById(Id)
            elm.classList.remove(""bg-offline"")
            elm.classList.add(""bg-o");
                WriteLiteral("nline\")\r\n        })\r\n        connection.on(\"UserDisConnected\", function (Id) {\r\n            let elm = document.getElementById(Id)\r\n            elm.classList.remove(\"bg-online\")\r\n            elm.classList.add(\"bg-offline\")\r\n        })\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
