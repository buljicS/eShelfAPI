namespace eShelfAPI.Extensions
{
    public static class MiddlewareExtension
    {
        public static IApplicationBuilder InjectMiddlewares(this IApplicationBuilder app) 
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseAuthorization();

            return app;
        }
    }
}
