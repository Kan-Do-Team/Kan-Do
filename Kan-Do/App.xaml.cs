using Kan_Do.Domain.Models;
using Kan_Do.Domain.Services;
using Kan_Do.Domain.Services.AuthenticationServices;
using Kan_Do.EntityFramework;
using Kan_Do.EntityFramework.Services;
using Kan_Do.WPF.State;
using Kan_Do.WPF.State.Authenticators;
using Kan_Do.WPF.State.Navigators;
using Kan_Do.WPF.State.SaveState;
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
            services.AddSingleton<ISaveStateService, SaveStateService>();
            services.AddSingleton<IAccountService, AccountDataService> ();
            services.AddSingleton<IBoardService, BoardDataService>();
            services.AddSingleton<IColumnService, ColumnDataService>();
            services.AddSingleton<ICardService, CardDataService>();
            services.AddSingleton<IDataService<Account>, AccountDataService>();
            services.AddSingleton<IDataService<Board>, BoardDataService>();
            services.AddSingleton<IDataService<Column>, ColumnDataService>();
            services.AddSingleton<IDataService<Card>, CardDataService>();

            services.AddSingleton<IPasswordHasher, PasswordHasher>();

            services.AddSingleton<IKanDoViewModelFactory, KanDoViewModelFactory>();
            services.AddSingleton<HomeViewModel>();

            

            services.AddSingleton<CreateViewModel<HomeViewModel>>(services =>
            {
                //return () => new HomeViewModel(services.GetRequiredService<INavigator>());
                return () => services.GetRequiredService<HomeViewModel>();
            });

            services.AddSingleton<CreateViewModel<KanbanBoardViewModel>>(services =>
            {
               // return () => new KanbanBoardViewModel(services.GetRequiredService<INavigator>());
                return () => services.GetRequiredService<KanbanBoardViewModel>();
            });

            services.AddSingleton<ViewModelDelegateRenavigator<LoginPageViewModel>>();

            services.AddSingleton<CreateViewModel<RegisterViewModel>>(services =>
            {
                return () => new RegisterViewModel(
                    services.GetRequiredService<IAuthenticator>(),
                    services.GetRequiredService<ViewModelDelegateRenavigator<LoginPageViewModel>>(),
                    services.GetRequiredService<ViewModelDelegateRenavigator<LoginPageViewModel>>());
            });

            services.AddSingleton<ViewModelDelegateRenavigator<HomeViewModel>>();
            services.AddSingleton<ViewModelDelegateRenavigator<KanbanBoardViewModel>>();
            services.AddSingleton<ViewModelDelegateRenavigator<RegisterViewModel>>();

            services.AddSingleton<CreateViewModel<KanbanBoardViewModel>>(services =>
            {
                return () => new KanbanBoardViewModel(
                    services.GetRequiredService<IAuthenticator>(),
                    services.GetRequiredService<ISaveState>());
            });

            services.AddSingleton<CreateViewModel<LoginPageViewModel>>(services =>
            {
                return () => new LoginPageViewModel(
                    services.GetRequiredService<IAuthenticator>(),
                    services.GetRequiredService<ViewModelDelegateRenavigator<HomeViewModel>>(),
                    services.GetRequiredService<ViewModelDelegateRenavigator<RegisterViewModel>>());
            });

            services.AddScoped<INavigator, Navigator>();
            services.AddScoped<IAuthenticator, Authenticator>();
            services.AddScoped<ISaveState, SaveState>();
            services.AddScoped<MainViewModel>();
            services.AddScoped<MainWindow>(s => new MainWindow(s.GetRequiredService<MainViewModel>()));
            return services.BuildServiceProvider();
        }
    }
}
