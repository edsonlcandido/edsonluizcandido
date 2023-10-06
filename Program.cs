namespace edsonluizcandido
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
            });

            var app = builder.Build();
            
            IHostEnvironment hostEnvironment = app.Services.GetRequiredService<IHostEnvironment>();

            if (hostEnvironment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();

            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}