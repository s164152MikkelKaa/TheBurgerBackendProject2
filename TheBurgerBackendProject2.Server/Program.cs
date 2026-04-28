
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Supabase;
using System.Text;
using TheBurgerBackendProject2.Server.Data;

namespace TheBurgerBackendProject2.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // After several weeks of this project it is now clear, Supabase is better to use without a seperate backend.
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
            });// Needs to be tested */

            builder.Services.AddAuthorization();

            /*var keyBytes = Encoding.UTF8.GetBytes(builder.Configuration["Authentication:JwtSecret"]!);

            builder.Services.AddAuthentication().AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(keyBytes),
                    ValidAudience = builder.Configuration["Authentication:ValidAudience"],
                    ValidIssuer = builder.Configuration["Authentication:ValidIssuer"]
                };
            });// JwtSecret is outdated, use anyways? */

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            /*builder.Services.AddScoped<Supabase.Client>(TheDBClient =>
                new Supabase.Client(
                    builder.Configuration["Supabase:TheUrl"],
                    builder.Configuration["Supabase:TheKey"],
                    new SupabaseOptions
                    {
                        AutoRefreshToken = true,
                        AutoConnectRealtime = true
                    }));// Atempting DbContext instead */

            var app = builder.Build();

            app.UseDefaultFiles();
            app.MapStaticAssets();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.MapFallbackToFile("/index.html");

            app.Run();
        }
    }
}
