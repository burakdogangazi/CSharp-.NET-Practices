#pragma checksum "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23aabf2b2330c66838f72b97bbd7bc51a2161ce0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RazorDemo), @"mvc.1.0.view", @"/Views/Home/RazorDemo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23aabf2b2330c66838f72b97bbd7bc51a2161ce0", @"/Views/Home/RazorDemo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25bda2e106e0b4837b4cb6e7f0a903c737f91db3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RazorDemo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetCoreMvcIntroduction.Models.EmployeeListViewModel>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
  // Razor Kod bloğu denir
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23aabf2b2330c66838f72b97bbd7bc51a2161ce03255", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index2</title>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23aabf2b2330c66838f72b97bbd7bc51a2161ce04319", async() => {
                WriteLiteral(@"

    <!-- Razor dinamik yapılar ile html sitesi kurmaya işimize yarar.-->

    <p>

        <a asp-aciton=""Create""> Create New </a>


    </p>

    <table class=""table"">
        <thead>

            <tr>
                <th>
                    Id
                </th>

                <th>
                    FirstName
                </th>

                <th>
                    LastName
                </th>

                <th>
                    City Id
                </th>
            </tr>


        </thead>

        <tbody>

");
#nullable restore
#line 52 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
             foreach (var item in Model.Employees)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 55 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 56 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 57 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
                   Write(item.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 58 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
                   Write(item.CityId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 60 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </tbody>\r\n    </table>\r\n\r\n    I am ");
                WriteLiteral("@home razor sanmasın diye iki tane ");
                WriteLiteral("@ kullandık\r\n\r\n    <p>");
#nullable restore
#line 68 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
  Write(DateTime.Now);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 70 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
      var date = DateTime.Now - TimeSpan.FromDays(3);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <p>3 days ago was ");
#nullable restore
#line 72 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
                 Write(date);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n\r\n    <!-- Razor kod blogğundan faydalandık {}-->\r\n\r\n");
#nullable restore
#line 76 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
      
        var number = 10;

    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <p>");
#nullable restore
#line 81 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
  Write(number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 83 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
     if (number < 10)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>Less than 10</p>\r\n");
#nullable restore
#line 86 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
    }

    else if (number == 10)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p> Your number is equals to 10</p>\r\n");
#nullable restore
#line 91 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
    }

    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p> Your number is greater than 10</p>\r\n");
#nullable restore
#line 96 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 99 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
     switch (number)
    {
        case 10:

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p> Your number is equals to 10</p>\r\n");
#nullable restore
#line 103 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
            break;
        case 20:

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p> Your number is equals to 20</p>\r\n");
#nullable restore
#line 106 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
            break;
        default:

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p> Unknown </p>\r\n");
#nullable restore
#line 109 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
            break;

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 113 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
     for (int i = 0; i < Model.Employees.Count; i++)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br>\r\n");
#nullable restore
#line 116 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
   Write(Model.Employees[i].FirstName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
                                     

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 120 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
       var counter = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
     while (counter < Model.Employees.Count)
    {


#line default
#line hidden
#nullable disable
                WriteLiteral("        <br>\r\n");
#nullable restore
#line 125 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
   Write(Model.Employees[counter].FirstName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
                                           
        counter++;

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 130 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
       var counter2 = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
     do
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br>\r\n");
#nullable restore
#line 134 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
   Write(Model.Employees[counter2].FirstName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
                                            
        counter2++;

    } while (counter2 < Model.Employees.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 139 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
     try
    {

    }
    catch (ArgumentNullException argumentNulleException)
    {

        throw;
    }

    catch (Exception exception)
    {

        throw;
    }
    
    finally
    {

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 160 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"text\"");
                BeginWriteAttribute("id", " id =\"", 2749, "\"", 2755, 0);
                EndWriteAttribute();
                WriteLiteral("name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 2767, "\"", 2775, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <button type=\"submit\"></button>\r\n");
#nullable restore
#line 164 "C:\Users\Burak\source\repos\C#Yeni\AspNetCoreMvcIntroduction\AspNetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCoreMvcIntroduction.Models.EmployeeListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
