﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HelloShop.ServiceDefaults.Extensions;

public static class ModelBindingExtensionns
{
    public static IServiceCollection AddModelMapper(this IServiceCollection services, Assembly? assembly = null)
    {
        assembly ??= Assembly.GetCallingAssembly();

        services.AddAutoMapper(assembly);

        return services;
    }
}
