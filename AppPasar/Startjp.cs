using AppPasar.Application.ProductServce;
using AppPasar.Application.SupplierService;
using AppPasar.ConfigProfile;
using AppPasar.Context;
using AppPasar.Views.ProductViews;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasar
{
    public class Startjp
    {
        IConfigurationRoot Configuration { get; }
        public IServiceProvider Provider { get; }
        public Startjp()
        {
            Provider = ConfigureServices();
        }

        private IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ConfigurationProfile());
            });

            var mapper = config.CreateMapper();

            services.AddSingleton(mapper);
            services.AddSingleton<IProductAppService, ProductAppService>();
            services.AddSingleton<ISupplierAppService, SupplierAppService>();

            services.AddDbContext<PasatContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DBConnection"), builder =>
                                        builder.MigrationsAssembly("migration.presentence"));
            }, ServiceLifetime.Singleton);

            services.AddSingleton<ProductView>();


            return services.BuildServiceProvider();

        }
    }
}
