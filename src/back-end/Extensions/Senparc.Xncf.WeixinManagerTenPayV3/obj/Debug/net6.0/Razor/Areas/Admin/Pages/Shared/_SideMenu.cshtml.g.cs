#pragma checksum "D:\Opathon\Sample-OpathonWorkshop2022-main\Sample-OpathonWorkshop2022-main\Day2\Sample_NCF\src\back-end\Extensions\Senparc.Xncf.WeixinManagerTenPayV3\Areas\Admin\Pages\Shared\_SideMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ba819558f974d36d311ede686514b63641658c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Senparc.Xncf.WeixinManagerTenPayV3.Areas.MyApps.Pages.Areas_Admin_Pages_Shared__SideMenu), @"mvc.1.0.view", @"/Areas/Admin/Pages/Shared/_SideMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Pages/Shared/_SideMenu.cshtml", typeof(Senparc.Xncf.WeixinManagerTenPayV3.Areas.MyApps.Pages.Areas_Admin_Pages_Shared__SideMenu))]
namespace Senparc.Xncf.WeixinManagerTenPayV3.Areas.MyApps.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "D:\Opathon\Sample-OpathonWorkshop2022-main\Sample-OpathonWorkshop2022-main\Day2\Sample_NCF\src\back-end\Extensions\Senparc.Xncf.WeixinManagerTenPayV3\Areas\Admin\Pages\Shared\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Razor;

#line default
#line hidden
#line 3 "D:\Opathon\Sample-OpathonWorkshop2022-main\Sample-OpathonWorkshop2022-main\Day2\Sample_NCF\src\back-end\Extensions\Senparc.Xncf.WeixinManagerTenPayV3\Areas\Admin\Pages\Shared\_ViewImports.cshtml"
using System.Web.Mvc;

#line default
#line hidden
#line 4 "D:\Opathon\Sample-OpathonWorkshop2022-main\Sample-OpathonWorkshop2022-main\Day2\Sample_NCF\src\back-end\Extensions\Senparc.Xncf.WeixinManagerTenPayV3\Areas\Admin\Pages\Shared\_ViewImports.cshtml"
using Senparc.CO2NET.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ba819558f974d36d311ede686514b63641658c7", @"/Areas/Admin/Pages/Shared/_SideMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f3a82bb4d5c1348ea049c9db090f71a612373c5", @"/Areas/Admin/Pages/Shared/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_Shared__SideMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 365, true);
            WriteLiteral(@"    <el-menu-item index=""1"">
        <a :href=""'/Admin/WeixinManagerTenPayV3/Index?uid='+moduleData.xncfModuleDto.uid""><i class=""fa fa-laptop""></i>首页</a>
    </el-menu-item>
    <el-menu-item index=""2"">
        <a :href=""'/Admin/WeixinManagerTenPayV3/DatabaseSample?uid='+moduleData.xncfModuleDto.uid""><i class=""fa fa-bookmark-o""></i>数据库操作示例</a>
    </el-menu-item>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
