using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

namespace MHZ_Tester.Shared;

public static class DependencyInjection
{
    public static IServiceCollection AddSharedServices(this IServiceCollection services)
    {
        // Services


        // ViewModels
        services.AddSingleton<ViewModels.DeviceStatusViewModel>();

        return services;
    }
}
