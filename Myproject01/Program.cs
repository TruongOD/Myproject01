using Microsoft.EntityFrameworkCore;
using Myproject01.Infrastructure.Dependencies;

namespace Myproject01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Configuration.AddEnvironmentVariables();
            var connectionString = builder.Configuration.GetConnectionString("dbConnect");
            builder.Services.AddDbContextPool<MyProjetContext>(option => option.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            IoC.Register(builder.Services, builder.Configuration);

            #region [Auto mapper]
            AutoMapperInitiator.Register(builder.Services);
            #endregion

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}