#pragma checksum "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "553381586a4b57de46828923488f59f871bc13bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\_ViewImports.cshtml"
using NackowskisMax;

#line default
#line hidden
#line 2 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\_ViewImports.cshtml"
using NackowskisMax.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"553381586a4b57de46828923488f59f871bc13bf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f541985f2dc74db33f8d45fb6926e71c2ce474ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AuctionItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("auctionForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("js-auctionForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("js-deleteAuctionForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("bidForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("js-createBidForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(27, 1213, true);
            WriteLiteral(@"
<style>
    /*.odd {
        background-color: #f9f9f9;
    }*/

    .marranTable {
        margin-right: auto;
        margin-left: auto;
        display: block;
        width: 80%;
    }

    .redText {
        color: red;
        font-weight: bold;
    }

    input[type='number'] {
        -moz-appearance: textfield;
    }

    input::-webkit-outer-spin-button,
    input::-webkit-inner-spin-button {
        -webkit-appearance: none;
    }

    .notValidPrice {
        border: solid;
        border-color: red !important;
    }

    .isValidPrice {
        border: solid;
        border-color: lightgreen !important;
    }

    .notValidPrice:focus {
        border: solid;
        border-color: red !important;
        -webkit-box-shadow: none !important;
        box-shadow: none;
    }

    .isValidPrice:focus {
        border:solid;
        border-color:lightgreen !important;
        -webkit-box-shadow:none !important;
        box-shadow:none;

    }

</sty");
            WriteLiteral("le>\r\n\r\n\r\n<section>\r\n    <div class=\"container\" style=\"padding-top:80px\">\r\n        <h2 class=\"text-center text-uppercase  text-dark\">Auction list:</h2>\r\n        <hr class=\"star-dark mb-5\">\r\n");
            EndContext();
#line 61 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml"
          
            var currentUser = "";
            var isAdmin = false;

            if (User.IsInRole("Admin"))
            {
                isAdmin = true;
            }

            if (User.Identity.Name != null)
            {

                currentUser = User.Identity.Name;
            }
        

#line default
#line hidden
            BeginContext(1568, 578, true);
            WriteLiteral(@"        <div class=""row marranTable"">

            <table id=""example"" class=""display"" style=""width:100%"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Titel</th>
                        <th>Description</th>
                        <th>StartDate</th>
                        <th>EndDate</th>
                        <th>Estimate</th>
                        <th>CreatedBy</th>
                        <th>Active</th>

                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 93 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml"
                     foreach (var item in Model)
                    {
                        var serializedItems = Newtonsoft.Json.JsonConvert.SerializeObject(item);

#line default
#line hidden
            BeginContext(2317, 39, true);
            WriteLiteral("                        <tr data-item=\"");
            EndContext();
            BeginContext(2357, 15, false);
#line 96 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml"
                                  Write(serializedItems);

#line default
#line hidden
            EndContext();
            BeginContext(2372, 13, true);
            WriteLiteral("\" data-bids=\"");
            EndContext();
            BeginContext(2386, 14, false);
#line 96 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml"
                                                               Write(item.OfferList);

#line default
#line hidden
            EndContext();
            BeginContext(2400, 36, true);
            WriteLiteral("\">\r\n                            <td>");
            EndContext();
            BeginContext(2437, 7, false);
#line 97 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2444, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2484, 10, false);
#line 98 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2494, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2534, 16, false);
#line 99 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml"
                           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2550, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2590, 34, false);
#line 100 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml"
                           Write(item.StartDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2624, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2664, 32, false);
#line 101 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml"
                           Write(item.EndDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2696, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2736, 13, false);
#line 102 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml"
                           Write(item.Estimate);

#line default
#line hidden
            EndContext();
            BeginContext(2749, 43, true);
            WriteLiteral(" SEK</td>\r\n                            <td>");
            EndContext();
            BeginContext(2793, 14, false);
#line 103 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml"
                           Write(item.CreatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(2807, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2847, 11, false);
#line 104 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml"
                           Write(item.Active);

#line default
#line hidden
            EndContext();
            BeginContext(2858, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 106 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2919, 489, true);
            WriteLiteral(@"                </tbody>
                <tfoot>
                    <tr>
                        <th>Id</th>
                        <th>Titel</th>
                        <th>Beskrivning</th>
                        <th>StartDate</th>
                        <th>EndDate</th>
                        <th>Estimate</th>
                        <th>CreatedBy</th>
                        <th>Active</th>
                    </tr>
                </tfoot>
            </table>
");
            EndContext();
#line 121 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml"
             if (User.IsInRole("Admin"))
            {

#line default
#line hidden
            BeginContext(3465, 646, true);
            WriteLiteral(@"                <a class=""btn btn-primary portfolio-item"" href=""#portfolio-modal-auction"" role=""button"" id=""js-createAuction"" data-url=""/Admin/Create"">
                    Create Auction
                </a>
                <a class=""btn btn-primary portfolio-item disabled"" href=""#portfolio-modal-auction"" role=""button"" id=""js-editAuction"" data-url=""/Admin/Edit"">
                    Edit
                </a>
                <a class=""btn btn-danger portfolio-item disabled float-right"" href=""#portfolio-modal-deleteAuction"" role=""button"" id=""js-deleteAuction"" data-url=""/Admin/Delete"">
                    Delete
                </a>
");
            EndContext();
#line 132 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml"
            }
            else if (User.IsInRole("Regular"))
            {

#line default
#line hidden
            BeginContext(4189, 427, true);
            WriteLiteral(@"                <a class=""btn btn-primary portfolio-item"" href=""#portfolio-modal-auction"" role=""button"" id=""js-createAuction"" data-url=""/Auction/Create"">
                    Create Auction
                </a>
                <a class=""btn btn-secondary portfolio-item"" href=""#portfolio-modal-auctionOffers"" role=""button"" id=""js-showBids"" data-url=""/Auction/CreateBid"">
                    Show bids
                </a>
");
            EndContext();
            BeginContext(4618, 231, true);
            WriteLiteral("                <a class=\"btn btn-danger portfolio-item disabled float-right\" href=\"#portfolio-modal-deleteAuction\" role=\"button\" id=\"js-deleteAuction\" data-url=\"/Auction/Delete\">\r\n                    Delete\r\n                </a>\r\n");
            EndContext();
#line 145 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(4864, 666, true);
            WriteLiteral(@"





        </div>
        <hr class=""star-dark mb-5"">
    </div>
</section>


<!-- Auction Modal -->
<div class=""portfolio-modal mfp-hide"" id=""portfolio-modal-auction"">
    <div class=""portfolio-modal-dialog bg-white"">
        <a class=""close-button d-none d-md-block portfolio-modal-dismiss"" href=""#"">
            <i class=""fa fa-3x fa-times""></i>
        </a>
        <div class=""container text-center"">
            <div class=""row"">
                <div class=""col-lg-8 mx-auto"">
                    <h2 class=""text-secondary text-uppercase mb-0"" id=""modalTitle""></h2>
                    <hr class=""star-dark mb-5"">
                    ");
            EndContext();
            BeginContext(5530, 3819, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dc048c5934d407aa63d83535fd806f1", async() => {
                BeginContext(5599, 1136, true);
                WriteLiteral(@"
                        <input type=""hidden"" name=""Id"" id=""js-auctionId"" required=""required"" value="""" />
                        <input type=""hidden"" name=""GroupId"" required=""required"" value=""1000"" />
                        <div class=""control-group"">
                            <div class=""form-group"">
                                <input class=""form-control"" name=""title"" id=""js-auctionTitel"" type=""text"" placeholder=""Titel"" required=""required"" data-validation-required-message=""Please enter titel."" aria-invalid=""false"">
                            </div>
                        </div>
                        <div class=""control-group"">
                            <div class=""form-group"">
                                <input class=""form-control"" name=""description"" id=""js-auctionDescription"" type=""text"" placeholder=""Description"" required=""required"" data-validation-required-message=""Please enter a description."" aria-invalid=""false"">
                            </div>
                        </d");
                WriteLiteral("iv>\r\n                        <div class=\"control-group\">\r\n                            <div class=\"form-group\">\r\n");
                EndContext();
                BeginContext(6910, 856, true);
                WriteLiteral(@"
                                <div class=""input-group date"" id=""js-startDate"" data-target-input=""nearest"">
                                    <input name=""startDate"" id=""js-startDateInput"" type=""text"" class=""form-control datetimepicker-input"" data-target=""#js-startDate"" required=""required"" data-validation-required-message=""Please enter a start date"" />
                                    <div class=""input-group-append"" data-target=""#js-startDate"" data-toggle=""datetimepicker"">
                                        <div class=""input-group-text""><i class=""fa fa-calendar""></i></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""control-group"">
                            <div class=""form-group"">
");
                EndContext();
                BeginContext(7935, 1321, true);
                WriteLiteral(@"
                                <div class=""input-group date"" id=""js-endDate"" data-target-input=""nearest"">
                                    <input type=""text"" id=""js-endDateInput"" name=""endDate"" class=""form-control datetimepicker-input"" data-target=""#js-endDate"" required=""required"" data-validation-required-message=""Please enter a end date"" />
                                    <div class=""input-group-append"" data-target=""#js-endDate"" data-toggle=""datetimepicker"">
                                        <div class=""input-group-text""><i class=""fa fa-calendar""></i></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""control-group"">
                            <div class=""form-group"">
                                <input class=""form-control"" name=""estimate"" id=""js-auctionEstimate"" type=""number"" placeholder=""Estimate"" required=""required"" data-validation-require");
                WriteLiteral(@"d-message=""Please enter a estimate."" aria-invalid=""false"">
                            </div>
                        </div>
                        <hr class=""star-dark mb-5"">
                        <input class=""btn btn-primary btn-lg float-left rounded-pill "" type=""submit"" value=""Save"">
");
                EndContext();
                BeginContext(9322, 20, true);
                WriteLiteral("                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9349, 983, true);
            WriteLiteral(@"
                    <a class=""btn btn-danger btn-lg rounded-pill portfolio-modal-dismiss float-right"" href=""#"">
                        <i class=""fa fa-close""></i>
                        Close
                    </a>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""portfolio-modal mfp-hide"" id=""portfolio-modal-deleteAuction"">
    <div class=""portfolio-modal-dialog bg-white"">
        <a class=""close-button d-none d-md-block portfolio-modal-dismiss"" href=""#"" onclick=""window.location.reload(true);"">
            <i class=""fa fa-3x fa-times""></i>
        </a>
        <div class=""container text-center"">
            <div class=""row"">
                <div class=""col-lg-8 mx-auto"">
                    <h3 class=""text-secondary text-uppercase mb-0"" id=""modalTitle"">Bids</h3>
                    <hr class=""star-dark mb-5"">
                    <h4 class=""text-dark"">This action cannot be undone</h4>
                    ");
            EndContext();
            BeginContext(10332, 327, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d11c57e33dda4350bc6a6a52062fe9ee", async() => {
                BeginContext(10407, 245, true);
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"Id\" id=\"js-auctionId\" required=\"required\" value=\"\" />\r\n                        <input class=\"btn btn-danger btn-lg float-left rounded-pill \" type=\"submit\" value=\"Delete\">\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10659, 1049, true);
            WriteLiteral(@"
                    <a class=""btn btn-default btn-outline-primary btn-lg rounded-pill portfolio-modal-dismiss float-right"" href=""#"">
                        <i class=""fa fa-close""></i>
                        Cancel
                    </a>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""portfolio-modal mfp-hide"" id=""portfolio-modal-auctionOffers"">
    <div class=""portfolio-modal-dialog bg-white"">
        <a class=""close-button d-none d-md-block portfolio-modal-dismiss"" href=""#"" onclick=""window.location.reload(true);"">
            <i class=""fa fa-3x fa-times""></i>
        </a>
        <div class=""container text-center"">
            <div class=""row"">
                <div class=""col-lg-8 mx-auto"">
                    <h3 class=""text-secondary text-uppercase mb-0"" id=""modalTitle"">Bids:</h3>
                    <hr class=""star-dark mb-5"">
                    <ul id=""js-bidList"">

                    </ul>
                    <hr class=""star-dark mb-");
            WriteLiteral("5\">\r\n                    ");
            EndContext();
            BeginContext(11708, 707, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e944d86ba25a43f7bb332a99209d7619", async() => {
                BeginContext(11775, 633, true);
                WriteLiteral(@"
                        <input type=""hidden"" name=""AuctionId"" id=""js-auctionId"" required=""required"" value="""" />
                        <div class=""control-group"">
                            <div class=""form-group"">
                                <input id=""js-bidInput"" class=""form-control"" type=""number"" name=""Sum"" required=""required"" placeholder=""Input bid here!"" />
                            </div>
                        </div>
                        <input id=""js-bidSubmit"" class=""btn btn-primary btn-lg float-left rounded-pill disabled"" type=""submit"" value=""Place Bid"" disabled=""disabled"">
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12415, 329, true);
            WriteLiteral(@"
                    <a class=""btn btn-default btn-outline-primary btn-lg rounded-pill portfolio-modal-dismiss float-right"" href=""#"">
                        <i class=""fa fa-close""></i>
                        Cancel
                    </a>
                </div>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(12761, 85, true);
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            var currUser = \'");
                EndContext();
                BeginContext(12847, 11, false);
#line 286 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml"
                       Write(currentUser);

#line default
#line hidden
                EndContext();
                BeginContext(12858, 31, true);
                WriteLiteral("\';\r\n            var isAdmin = \'");
                EndContext();
                BeginContext(12890, 7, false);
#line 287 "C:\Users\maxma\source\repos\NackowskisMax\NackowskisMax\Views\Home\Index.cshtml"
                      Write(isAdmin);

#line default
#line hidden
                EndContext();
                BeginContext(12897, 6878, true);
                WriteLiteral(@"';

            if (currUser !== '') {
                //doo it
            }

            // Setup - add a text input to each footer cell
            $('#example tfoot th').each(function () {
                var title = $(this).text();
                if (title === ""Titel"") {
                    $(this).html('<input type=""text"" placeholder=""Search title"" />');
                } else if (title === ""Beskrivning"") {
                    $(this).html('<input type=""text"" placeholder=""Search description"" />');
                }
            });


            var table = $('#example').DataTable();
            $("".dataTables_filter"").hide();

            // Apply the search
            table.columns().every(function () {
                var that = this;

                $('input', this.footer()).on('keyup change', function () {
                    if (that.search() !== this.value) {
                        that
                            .search(this.value)
                            .dra");
                WriteLiteral(@"w();
                    }
                });
            });


            $('#example tbody').on('click', 'tr', function () {
                if ($(this).hasClass('selected')) {
                    $(this).removeClass('selected');
                    $('#js-editAuction').addClass(""disabled"");
                    $('#js-deleteAuction').addClass(""disabled"");
                }
                else {
                    var items = $(this).data(""item"");

                    table.$('tr.selected').removeClass('selected');
                    $(this).addClass('selected');
                    $('#newAuction').val($(this).closest('tr').children('td:first').text());
                    $('#deleteAuction').val($(this).closest('tr').children('td:first').text());
                    if (isAdmin === 'True' || currUser === items.SkapadAv ) {

                    $('#js-deleteAuction').removeClass(""disabled"");
                    } else {
                        $('#js-deleteAuction').addClass(""dis");
                WriteLiteral(@"abled"");
                    }
                    $('#js-editAuction').removeClass(""disabled"");
                    //var items = $(this).data(""item"");
                    //console.log(items.Titel);
                }
            });

            //EDIT AUCTION
            $(""#js-editAuction"").on('click', function () {
                var items = table.$('tr.selected').data(""item"");
                var startDate = items.StartDatum;
                var endDate = items.SlutDatum;
                var url = $(this).attr('data-url');

                //endDate = endDate.substring(0, endDate.indexOf('T'));
                //startDate = startDate.substring(0, startDate.indexOf('T'));

                //console.log(items);

                //Ändra modal titlen
                $('#modalTitle').text(""Edit Auction"");

                //Ge inputsen rätt värden
                $('#js-auctionForm').attr('action', url);
                $('#js-auctionId').val(parseInt(items.AuktionID));
           ");
                WriteLiteral(@"     $(""#js-auctionTitel"").val(items.Titel);
                $(""#js-auctionDescription"").val(items.Beskrivning);
                $(""#js-startDateInput"").val(startDate);
                $(""#js-endDateInput"").val(endDate);
                $('#js-auctionEstimate').val(parseInt(items.Utropspris));

            });

            //CREATE NEW AUCTION
            $(""#js-createAuction"").on('click', function () {

                var url = $(this).attr('data-url');
                //Ändra modal titlen
                $('#modalTitle').text(""Create Auction"");
                $('#js-auctionForm').attr('action', url);
                $('#js-auctionId').val('');
                $(""#js-auctionTitel"").val('');
                $(""#js-auctionDescription"").val('');
                $(""#js-startDate"").val('');
                $(""#js-endDate"").val('');
                $('#js-auctionEstimate').val('');

            });

            //CREATE NEW BID
            $('#js-showBids').on('click', function () {
   ");
                WriteLiteral(@"             $(""ul"").empty();
                $('#js-bidSubmit').addClass(""disabled"");
                var items = table.$('tr.selected').data(""item"");
                var url = $(this).attr('data-url');
                if (items.OfferList.length > 0) {

                    $.each(items.OfferList, function (index, value) {

                        $('#js-bidList').prepend('<li value=""'+value.Summa+'""><p> Bid: ' + value.Summa + 'kr Bidder: ' + value.Budgivare + '</p></li>');

                    });


                    $(""li p"").first().addClass(""redText"");
                    $(""li"").first().addClass(""js-highestBid"");

                };

                $('#js-createBidForm').attr('action', url);
                $('#js-auctionId').val(parseInt(items.AuktionID));
            });

            //Validering på inputen
            $('#js-bidInput').keyup(function(){
                //console.log($(""#js-bidInput"").val());
                
                var inputValue = $(this).val();");
                WriteLiteral(@"
                var highestBid = $('.js-highestBid').first().val();

                if (inputValue > highestBid || highestBid === undefined) {
                    $(this).addClass(""isValidPrice"");
                    $(this).removeClass(""notValidPrice"");
                    $('#js-bidSubmit').removeClass(""disabled"");
                    $('#js-bidSubmit').removeAttr(""disabled"");

                } else if (highestBid >= inputValue) {
                    $(this).addClass(""notValidPrice"");
                    $(this).removeClass(""isValidPrice"");
                    $('#js-bidSubmit').addClass(""disabled"");
                    $('#js-bidSubmit').attr('disabled',""disabled"");
                }

            });

            //DELETE AUCTION
            $(""#js-deleteAuction"").on('click', function () {
                var items = table.$('tr.selected').data(""item"");
                var url = $(this).attr('data-url');

                $('#js-auctionId').val(parseInt(items.AuktionID));
         ");
                WriteLiteral(@"       //Ge urlen till modalens form
                $('#js-deleteAuctionForm').attr('action', url);
            });

            //DATETIME PICKER
            $('#js-startDate').datetimepicker({ format: ""YYYY-MM-DD HH:mm""});
            $('#js-endDate').datetimepicker({
                useCurrent: false,
                format: ""YYYY-MM-DD HH:mm""
            });
            $(""#js-startDate"").on(""change.datetimepicker"", function (e) {
                $('#js-endDate').datetimepicker('minDate', e.date);
            });
            $(""#js-endDate"").on(""change.datetimepicker"", function (e) {
                $('#js-startDate').datetimepicker('maxDate', e.date);
            });



        });
    </script>

");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AuctionItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
