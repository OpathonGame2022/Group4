#pragma checksum "D:\Opathon\Sample-OpathonWorkshop2022-main\Sample-OpathonWorkshop2022-main\Day2\Sample_NCF\src\back-end\Extensions\Senparc.Xncf.WeixinManagerMP\Areas\Admin\Pages\WeixinManagerMP\DatabaseSample.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5d193d1438f586d9d404554ef7093ce67d4e11e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Pages_WeixinManagerMP_DatabaseSample), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/WeixinManagerMP/DatabaseSample.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Admin/Pages/WeixinManagerMP/DatabaseSample.cshtml", typeof(AspNetCore.Areas_Admin_Pages_WeixinManagerMP_DatabaseSample), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5d193d1438f586d9d404554ef7093ce67d4e11e", @"/Areas/Admin/Pages/WeixinManagerMP/DatabaseSample.cshtml")]
    public class Areas_Admin_Pages_WeixinManagerMP_DatabaseSample : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Opathon\Sample-OpathonWorkshop2022-main\Sample-OpathonWorkshop2022-main\Day2\Sample_NCF\src\back-end\Extensions\Senparc.Xncf.WeixinManagerMP\Areas\Admin\Pages\WeixinManagerMP\DatabaseSample.cshtml"
  
    ViewData["Title"] = "数据库操作示例";
    Layout = "_Layout_Vue";

#line default
#line hidden
            BeginContext(153, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("HeaderContent", async() => {
                BeginContext(177, 609, true);
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
            BeginContext(788, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("breadcrumbs", async() => {
                BeginContext(811, 159, true);
                WriteLiteral("\n    <el-breadcrumb-item>扩展模块</el-breadcrumb-item>\n    <el-breadcrumb-item>微信公众号管理模块</el-breadcrumb-item>\n    <el-breadcrumb-item>数据库操作示例</el-breadcrumb-item>\n");
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
#line 49 "D:\Opathon\Sample-OpathonWorkshop2022-main\Sample-OpathonWorkshop2022-main\Day2\Sample_NCF\src\back-end\Extensions\Senparc.Xncf.WeixinManagerMP\Areas\Admin\Pages\WeixinManagerMP\DatabaseSample.cshtml"
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
#line 56 "D:\Opathon\Sample-OpathonWorkshop2022-main\Sample-OpathonWorkshop2022-main\Day2\Sample_NCF\src\back-end\Extensions\Senparc.Xncf.WeixinManagerMP\Areas\Admin\Pages\WeixinManagerMP\DatabaseSample.cshtml"
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
                BeginContext(2336, 1169, true);
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
                    const res = await service.get('/Admin/WeixinManagerMP/DatabaseSample?handler=Detail&uid=' + this.uid);
                    this.moduleData = res.data.data;
                },
                // 改变颜色
                async changeColor(param) {
                    const res = await service.get('/Admin/WeixinManagerMP/DatabaseSample?handler=' + para");
                WriteLiteral("m + \'&uid=\' + this.uid);\n                    this.moduleData.colorDto = res.data.data;\n                }\n            }\n        });\n    </script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Senparc.Xncf.WeixinManagerMP.Areas.WeixinManagerMP.Pages.DatabaseSample> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Senparc.Xncf.WeixinManagerMP.Areas.WeixinManagerMP.Pages.DatabaseSample> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Senparc.Xncf.WeixinManagerMP.Areas.WeixinManagerMP.Pages.DatabaseSample>)PageContext?.ViewData;
        public Senparc.Xncf.WeixinManagerMP.Areas.WeixinManagerMP.Pages.DatabaseSample Model => ViewData.Model;
    }
}
#pragma warning restore 1591
