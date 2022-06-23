using Microsoft.Extensions.DependencyInjection;
using NextFilm.DataAccess;
using NextFilm.DataAccess.Models;
using NextFilm.Services.DataServices;
using NextFilm.Services.UserService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NextFilm.WPF
{

    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IServiceProvider serviceProvider = CreateServiceProvider();

            //Window window = serviceProvider.GetRequiredService<MainWindow>();
            //window.Show();
        }

        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();

            /*
            services.AddSingleton<UnitOfWork>();
            services.AddSingleton<IDataService<BaseModel>, GenericDataService<BaseModel>>();
            services.AddSingleton<IDataService<User>, GenericDataService<User>>();

            services.AddSingleton<IUserService, UserService>();
            */

            return services.BuildServiceProvider();
            
        }
    }
}
