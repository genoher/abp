// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;
using Volo.Abp.SettingManagement;

// ReSharper disable once CheckNamespace
namespace Volo.Abp.SettingManagement;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(ITimeZoneSettingsAppService), typeof(TimeZoneSettingsClientProxy))]
public partial class TimeZoneSettingsClientProxy : ClientProxyBase<ITimeZoneSettingsAppService>, ITimeZoneSettingsAppService
{
    public virtual async Task<string> GetAsync()
    {
        return await RequestAsync<string>(nameof(GetAsync));
    }

    public virtual async Task<List<NameValue>> GetTimezonesAsync()
    {
        return await RequestAsync<List<NameValue>>(nameof(GetTimezonesAsync));
    }

    public virtual async Task UpdateAsync(string timezone)
    {
        await RequestAsync(nameof(UpdateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), timezone }
        });
    }
}