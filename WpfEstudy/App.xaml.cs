using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using WpfEstudy.Infrastructure.Context;
using WpfEstudy.Domain.Interface.Repository;
using WpfEstudy.Infrastructure.Repository;
using WpfEstudy.Domain.Interface.Service;
using WpfEstudy.Service.Servicos;
using AutoMapper;
using WpfEstudy.Domain.Entity;
using WpfEstudy.Domain.DTO;

namespace WpfEstudy.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }
        public IConfiguration Configuration { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            Configuration = builder.Build();

            var services = new ServiceCollection();
            ConfigureServices(services);

            ServiceProvider = services.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<WpfEstudyDBContext>(option =>
                    option.UseNpgsql("Host=localhost; Port=5432; Database=MinhaVidaFinanceira; User Id=; Password="),
                    ServiceLifetime.Scoped);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Pessoa, PessoaDTO>().ReverseMap();
            });
            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddTransient<IPessoaService, PessoaServico>();

            services.AddTransient(typeof(MainWindow));            
        }
    }
}
