#pragma checksum "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42f11f2c52ff2e658e61f6c5caace4347c07ca48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_DynamicAttributeTagHelpers_Runtime), @"default", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml")]
namespace Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles
{
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42f11f2c52ff2e658e61f6c5caace4347c07ca48", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml")]
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_DynamicAttributeTagHelpers_Runtime
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
        private global::TestNamespace.InputTagHelper __TestNamespace_InputTagHelper;
        #pragma warning disable 1998
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "test", async() => {
            }
            );
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "unbound", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 51, "prefix", 51, 6, true);
#nullable restore
#line 3 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
AddHtmlAttributeValue(" ", 57, DateTime.Now, 58, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "test", async() => {
            }
            );
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "unbound", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 95, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 5 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
                 if (true) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line (5,31)-(5,43) 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
Write(string.Empty);

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
                                           } else { 

#line default
#line hidden
#nullable disable
#nullable restore
#line (5,54)-(5,59) 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
Write(false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
                                                           }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 95, 44, false);
            AddHtmlAttributeValue(" ", 139, "suffix", 140, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "test", async() => {
            }
            );
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("prefix ");
#nullable restore
#line (7,23)-(7,35) 13 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
WriteLiteral(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral(" suffix");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __TestNamespace_InputTagHelper.Bound = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("bound", __TestNamespace_InputTagHelper.Bound, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "unbound", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 206, "prefix", 206, 6, true);
#nullable restore
#line 7 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
AddHtmlAttributeValue(" ", 212, DateTime.Now, 213, 13, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 226, "suffix", 227, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "test", async() => {
            }
            );
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line (9,16)-(9,29) 13 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
WriteLiteral(long.MinValue);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
                              if (true) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line (9,44)-(9,56) 13 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
WriteLiteral(string.Empty);

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
                                                        } else { 

#line default
#line hidden
#nullable disable
#nullable restore
#line (9,67)-(9,72) 13 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
WriteLiteral(false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
                                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line (9,76)-(9,88) 13 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
WriteLiteral(int.MaxValue);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __TestNamespace_InputTagHelper.Bound = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("bound", __TestNamespace_InputTagHelper.Bound, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "unbound", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 10 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
AddHtmlAttributeValue("", 347, long.MinValue, 347, 14, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 361, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 10 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
                                if (true) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line (10,46)-(10,58) 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
Write(string.Empty);

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
                                                          } else { 

#line default
#line hidden
#nullable disable
#nullable restore
#line (10,69)-(10,74) 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
Write(false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
                                                                          }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 362, 44, false);
#nullable restore
#line 10 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
AddHtmlAttributeValue(" ", 406, int.MaxValue, 407, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "test", async() => {
            }
            );
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "unbound", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 12 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
AddHtmlAttributeValue("", 444, long.MinValue, 444, 14, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
AddHtmlAttributeValue(" ", 458, DateTime.Now, 459, 13, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 472, "static", 473, 7, true);
            AddHtmlAttributeValue("    ", 479, "content", 483, 11, true);
#nullable restore
#line 12 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
AddHtmlAttributeValue(" ", 490, int.MaxValue, 491, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "test", async() => {
            }
            );
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "unbound", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 528, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 14 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
                 if (true) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line (14,31)-(14,43) 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
Write(string.Empty);

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
                                           } else { 

#line default
#line hidden
#nullable disable
#nullable restore
#line (14,54)-(14,59) 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
Write(false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
                                                           }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 528, 44, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
