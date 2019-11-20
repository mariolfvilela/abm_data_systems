using System;
using abm_data_systems.Application.Interfaces;
using abm_data_systems.Application.Services;
using abm_data_systems.Domain.Interfaces.Repositories;
using abm_data_systems.Domain.Interfaces.Services;
using abm_data_systems.Domain.Services;
using abm_data_systems.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace abm_data_systems.CrossCutting.IoC
{
    public class InjetorDependency
    {
        public static void Registrar(IServiceCollection svcCollection)
        {

            //Aplicação
            svcCollection.AddTransient(typeof(IAppServicoBase<,>), typeof(AppServiceBase<,>));
            svcCollection.AddTransient<IUserAppService, UserAppService>();


            //Domínio
            svcCollection.AddTransient(typeof(IServiceBase<>), typeof(ServiceBase<>));
            svcCollection.AddTransient<IUserService, UserService>();

            //Repositorio
            svcCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            svcCollection.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            svcCollection.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
