using Senparc.CO2NET;
using Senparc.CO2NET.WebApi;
using Senparc.Ncf.Core.AppServices;
using Senparc.Ncf.Core.Exceptions;
using Opathon.Xncf.WeixinManagerWxOpen.OHS.Local.PL;
using System;
using System.Threading.Tasks;
using Senparc.Weixin.WxOpen.Entities;
using System.Text;
using Senparc.Weixin.WxOpen.AdvancedAPIs.WxApp.WxAppJson;
using Senparc.CO2NET.Helpers;
using Senparc.Weixin.WxOpen.AdvancedAPIs.Sns;
using Senparc.Weixin.WxOpen.Containers;
using Senparc.Weixin;

namespace Opathon.Xncf.WeixinManagerWxOpen.OHS.Local.AppService
{
    public class ApiAppService : AppServiceBase
    {
        public ApiAppService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        /*
         * 使用 [ApiBind] 可将任意方法或类快速创建动态 WebApi。
         * 在 DDD 系统中，出于安全和防腐考虑，建议只在 AppService 上使用。
         * 当 AppService 上添加 [ApiBind] 标签满足不了需求时，仍然可以手动创建 ApiController。
         */

        /// <summary>
        /// 将 AppService 暴露为 WebApi
        /// </summary>
        /// <returns></returns>
        [ApiBind]
        public async Task<AppResponseBase<int>> MyApi()
        {
            return await this.GetResponseAsync<AppResponseBase<int>, int>(async (response, logger) =>
            {
                await Task.Delay(100);
                return 200;
            });
        }


        [ApiBind(ApiRequestMethod = ApiRequestMethod.Post)]
        public async Task<AppResponseBase<string>> DecryptAESAsync(string Key, string IV, string EncodedData)
        {
            return await this.GetResponseAsync<AppResponseBase<string>, string>(async (response, logger) =>
            {
                try
                {
                    //AESDecrypt
                    var decstr = EncryptHelper.AESDecrypt(Convert.FromBase64String(EncodedData), Encoding.UTF8.GetBytes(IV), Key);
                    var result = Encoding.UTF8.GetString(decstr);
                    return result;
                }
                catch (Exception ex)
                {
                    logger.Append(ex.Message);
                    logger.Append(ex.StackTrace);
                    logger.SaveLogs("解密失败");

                    response.Success = false;
                    return ex.Message;
                }
            });
        }

        /// <summary>
        /// 自定义 Post 类型和复杂参数，同时测试异常抛出和自定义状态码
        /// </summary>
        /// <returns></returns>
        [ApiBind(ApiRequestMethod = ApiRequestMethod.Post)]
        public async Task<StringAppResponse> MyCustomApi(Api_MyCustomApiRequest request)
        {
            //StringAppResponse 是 AppResponseBase<string> 的快捷写法
            return await this.GetResponseAsync<StringAppResponse, string>(async (response, logger) =>
            {
                throw new NcfExceptionBase($"抛出异常测试，传输参数：{request.FirstName} {request.LastName}");
                response.StateCode = 100;
            },
            exceptionHandler: (ex, response, logger) =>
            {
                logger.Append($"正在处理异常，信息：{ex.Message}");
            },
            afterFunc: (response, logger) =>
            {
                if (response.Success != true)
                {
                    response.StateCode = 101;
                }
            });
        }
    }
}
