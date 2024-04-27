using Microsoft.Extensions.DependencyInjection;
using School.Service.Repositories;
using School.Service.UnitOfWork;

namespace School.Service
{
	public static class ModuleServiceDependencies
	{
		public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
		{
			services.AddTransient<IStudentService, StudentService>();
			return services;
		}
	}
}
