using Microsoft.Extensions.DependencyInjection;
using School.Data.Entities;
using School.Infrastructure.Repositories;
using School.Infrastructure.UnitOfWork;

namespace School.Infrastructure
{
	public static class ModuleInfrastructureDependencies
	{
		public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
		{
			services.AddTransient<IStudentRepository, StudentRepository>();
			return services;
		}
	}
}
