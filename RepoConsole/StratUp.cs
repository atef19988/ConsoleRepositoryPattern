using console.efff;
using console.efff.Models;
using Microsoft.Extensions.DependencyInjection;
using Rrep.Core.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoConsole
{
    public class StratUp <T>
    {

        private static IServiceProvider CongigrtionServices()
        {

            var services = new ServiceCollection()
                .AddScoped<IRepo<Peron>,BaseRepo<Peron>>() 
                .AddScoped<IRepo<Car>, BaseRepo<Car>>()
                .BuildServiceProvider() ;  
            return services;
        }
        public static T Services()
        {
            return CongigrtionServices().GetRequiredService<T>();
        }

    }
}
