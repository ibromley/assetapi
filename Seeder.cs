using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;



using AssetApi.Models;

public static class Seeder {
    public static void writeJson(string jsonData, IServiceProvider serviceProvider) {

        List<AssetItem> events = JsonConvert.DeserializeObject<List<AssetItem>>(jsonData);
        using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<AssetContext>();
            if (!context.AssetItems.Any()) {
                
                foreach (AssetItem item in events) {
                    context.AssetItems.Add(item);
                }

                context.SaveChanges();
            }
        }
    }
}