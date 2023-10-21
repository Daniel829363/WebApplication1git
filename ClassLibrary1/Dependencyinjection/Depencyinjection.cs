using BLL.Services;
using BLL.Services.interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Depencyinjection
{
    public static class Depencyinjection
    {
        public static void AddServices(IServiceCollection service)
        {
            service.AddTransient<IHomeServices, HomeServices>();
        }
    }
}
