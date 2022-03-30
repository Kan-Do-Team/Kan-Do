using Kan_Do.Domain.Models;
using Kan_Do.Domain.Services;
using Kan_Do.Domain.Services.AuthenticationServices;
using Kan_Do.EntityFramework;
using Kan_Do.EntityFramework.Services;
using Kan_Do.WPF.State.Authenticators;
using Kan_Do.WPF.State.Navigators;
using Kan_Do.WPF.ViewModels;
using Kan_Do.WPF.ViewModels.Factories;
using Microsoft.AspNet.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Kan_Do.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IServiceProvider serviceProvider = CreateServiceProvider();


            //IAuthenticationService authentication = serviceProvider.GetRequiredService<IAuthenticationService>();
            //authentication.Register("FirstNamenext", "LastNamenext", "fakemailnext", "test00next", "test00next");
            //authentication.Login("test123", "password");

            

            Window window = serviceProvider.GetRequiredService<MainWindow>();
            window.Show();

            base.OnStartup(e);
        }

        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<KanDoDbContextFactory>();
            services.AddSingleton<IAuthenticationService, AuthenticationService>();
            services.AddSingleton<IAccountService, AccountDataService> ();
            services.AddSingleton<IDataService<Account>, AccountDataService>();

            services.AddSingleton<IPasswordHasher, PasswordHasher>();

            services.AddSingleton<IRootKanDoViewModelFactory, RootKanDoViewModelFactory>();
            services.AddSingleton<IKanDoViewModelFactory<HomeViewModel>, HomeViewModelFactory>();
            services.AddSingleton<IKanDoViewModelFactory<KanbanBoardViewModel>, KanbanBoardViewModelFactory>();

            services.AddSingleton<IKanDoViewModelFactory<LoginPageViewModel>>((services) => 
                new LoginPageViewModelFactory(services.GetRequiredService<IAuthenticator>(),
                new ViewModelFactoryRenavigator<HomeViewModel>(services.GetRequiredService<INavigator>(),
                services.GetRequiredService<IKanDoViewModelFactory<HomeViewModel>>())));



            services.AddScoped<INavigator, Navigator>();
            services.AddScoped<IAuthenticator, Authenticator>();
            services.AddScoped<MainViewModel>();
            services.AddScoped<MainWindow>(s => new MainWindow(s.GetRequiredService<MainViewModel>()));
            return services.BuildServiceProvider();
        }
    }
}
