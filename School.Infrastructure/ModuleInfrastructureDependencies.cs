using Microsoft.Extensions.DependencyInjection;
using School.Infrastructure.Generics;
using School.Infrastructure.Repositories;
using School.Infrastructure.UnitOfWork;

namespace School.Infrastructure
{
	public static class ModuleInfrastructureDependencies
	{
		public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
		{
			services.AddTransient<IStudentRepository, StudentRepository>();
			services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
			return services;
		}
	}
}
