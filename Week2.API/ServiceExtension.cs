using Week2.API.Repository;

namespace Week2.API
{
    public static class ServiceExtension
    {
        public static void AddServiceAndRepository(this IServiceCollection services)
        {
            // Idyi guid ile tanımladığım ve her seferinde benzersiz bir id çıkarttığı için burada singleton olarak tanımladım. Diğer türlü id ye göre işlem yapıldığında farklı id verdiği için ilk requestdeki id yi siliyordu.
            services.AddSingleton<IProductRepository, ProductRepository>();
        }
    }
}
