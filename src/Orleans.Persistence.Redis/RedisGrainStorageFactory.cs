﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Orleans.Storage;
using System;

namespace Orleans.Persistence
{
    /// <summary>
    /// Factory used to create instances of Redis grain storage.
    /// </summary>
    public static class RedisGrainStorageFactory
    {
        /// <summary>
        /// Creates a grain storage instance.
        /// </summary>
        public static IGrainStorage Create(IServiceProvider services, string name)
        {
            IOptionsSnapshot<RedisStorageOptions> optionsSnapshot = services.GetRequiredService<IOptionsSnapshot<RedisStorageOptions>>();
            return ActivatorUtilities.CreateInstance<RedisGrainStorage>(services, optionsSnapshot.Get(name), name);
        }
    }
}
