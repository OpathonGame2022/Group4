#pragma checksum "D:\Opathon\Sample-OpathonWorkshop2022-main\Sample-OpathonWorkshop2022-main\Day2\Sample_NCF\src\back-end\Extensions\Senparc.Xncf.WeixinManagerBase\Areas\Admin\Pages\WeixinManagerBase\DatabaseSample.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33914e7a8a65aa542953197faf27cd14b94102a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Pages_WeixinManagerBase_DatabaseSample), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/WeixinManagerBase/DatabaseSample.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Admin/Pages/WeixinManagerBase/DatabaseSample.cshtml", typeof(AspNetCore.Areas_Admin_Pages_WeixinManagerBase_DatabaseSample), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33914e7a8a65aa542953197faf27cd14b94102a2", @"/Areas/Admin/Pages/WeixinManagerBase/DatabaseSample.cshtml")]
    public class Areas_Admin_Pages_WeixinManagerBase_DatabaseSample : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Opathon\Sample-OpathonWorkshop2022-main\Sample-OpathonWorkshop2022-main\Day2\Sample_NCF\src\back-end\Extensions\Senparc.Xncf.WeixinManagerBase\Areas\Admin\Pages\WeixinManagerBase\DatabaseSample.cshtml"
  
    ViewData["Title"] = "数据库操作示例";
    Layout = "_Layout_Vue";

#line default
#line hidden
            BeginContext(157, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("HeaderContent", async() => {
                BeginContext(181, 609, true);
                WriteLiteral(@"
    <style>
       .extensionAreaTemplate .box {
            margin: 30px auto;
            text-align: center;
            padding: 80px;
        }
      .extensionAreaTemplate  .el-menu {
            min-height: 400px;
        }
       .extensionAreaTemplate .el-menu-item a {
            display: block;
            color: inherit;
            text-decoration: none;
        }

        .extensionAreaTemplate .el-menu-item a i {
            margin-right: 5px;
            width: 24px;
            text-align: center;
            font-size: 18px;
            vertical-align: middle;
        }
    </style>
");
                EndContext();
            }
            );
            BeginContext(792, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("breadcrumbs", async() => {
                BeginContext(815, 155, true);
                WriteLiteral("\n    <el-breadcrumb-item>扩展模块</el-breadcrumb-item>\n    <el-breadcrumb-item>微信公众号</el-breadcrumb-item>\n    <el-breadcrumb-item>数据库操作示例</el-breadcrumb-item>\n");
                EndContext();
            }
            );
            BeginContext(972, 494, true);
            WriteLiteral(@"
<div class=""extensionAreaTemplate"">
    <el-container>
        <el-header class=""module-header"">
            <span class=""start-title""> <i class=""fa fa-dot-circle-o""></i>&nbsp;<span class=""module-header-v"">数据库操作示例</span></span>
        </el-header>
        <el-container v-if=""moduleData"">
            <el-aside width=""200px"">
                <el-menu background-color=""#304156"" default-active=""2""
                         text-color=""#bfcbd9"" active-text-color=""#409eff"">
                    ");
            EndContext();
            BeginContext(1468, 36, false);
#line 49 "D:\Opathon\Sample-OpathonWorkshop2022-main\Sample-OpathonWorkshop2022-main\Day2\Sample_NCF\src\back-end\Extensions\Senparc.Xncf.WeixinManagerBase\Areas\Admin\Pages\WeixinManagerBase\DatabaseSample.cshtml"
                Write(await Html.PartialAsync("_SideMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(1505, 269, true);
            WriteLiteral(@"
                </el-menu>
            </el-aside>
            <el-main>
                <h4>{{moduleData.xncfModuleDto.description}}</h4>
                <br />
                <h4>安装时间：{{formaTableTime(moduleData.colorDto.addTime)}}</h4>
                <h3>当前数据库类型：");
            EndContext();
            BeginContext(1775, 26, false);
#line 56 "D:\Opathon\Sample-OpathonWorkshop2022-main\Sample-OpathonWorkshop2022-main\Day2\Sample_NCF\src\back-end\Extensions\Senparc.Xncf.WeixinManagerBase\Areas\Admin\Pages\WeixinManagerBase\DatabaseSample.cshtml"
                       Write(Model.MultipleDatabaseType);

#line default
#line hidden
            EndContext();
            BeginContext(1801, 99, true);
            WriteLiteral("</h3>\n                <div class=\"box\" :style=\"{backgroundColor}\">\n\n                    <el-button ");
            EndContext();
            BeginContext(1901, 112, true);
            WriteLiteral("@click=\"changeColor(\'Brighten\')\"><i class=\"fa fa-tachometer\"></i> 变亮</el-button>\n                    <el-button ");
            EndContext();
            BeginContext(2014, 118, true);
            WriteLiteral("@click=\"changeColor(\'Darken\')\" type=\"info\"><i class=\"fa fa-moon-o\"></i> 变暗</el-button>\n                    <el-button ");
            EndContext();
            BeginContext(2133, 186, true);
            WriteLiteral("@click=\"changeColor(\'Random\')\" type=\"success\"><i class=\"fa fa-sun-o\"></i> 随机</el-button>\n                </div>\n            </el-main>\n        </el-container>\n    </el-container>\n</div>\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2336, 1173, true);
                WriteLiteral(@"
    <script>
        var app = new Vue({
            el: ""#app"",
            data() {
                return {
                    moduleData: null,
                    uid: ''
                };
            },
            computed: {
                backgroundColor() {
                    let rgba = `rgba(${this.moduleData.colorDto.red},${this.moduleData.colorDto.green},${this.moduleData.colorDto.blue},1)`
                    return rgba;
                }
            },
            mounted() {
                this.getDetail();
            },
            methods: {
                async getDetail() {
                    this.uid = resizeUrl().uid
                    const res = await service.get('/Admin/WeixinManagerBase/DatabaseSample?handler=Detail&uid=' + this.uid);
                    this.moduleData = res.data.data;
                },
                // 改变颜色
                async changeColor(param) {
                    const res = await service.get('/Admin/WeixinManagerBase/DatabaseSample?handler=' + ");
                WriteLiteral("param + \'&uid=\' + this.uid);\n                    this.moduleData.colorDto = res.data.data;\n                }\n            }\n        });\n    </script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Senparc.Xncf.WeixinManagerBase.Areas.WeixinManagerBase.Pages.DatabaseSample> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Senparc.Xncf.WeixinManagerBase.Areas.WeixinManagerBase.Pages.DatabaseSample> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Senparc.Xncf.WeixinManagerBase.Areas.WeixinManagerBase.Pages.DatabaseSample>)PageContext?.ViewData;
        public Senparc.Xncf.WeixinManagerBase.Areas.WeixinManagerBase.Pages.DatabaseSample Model => ViewData.Model;
    }
}
#pragma warning restore 1591
