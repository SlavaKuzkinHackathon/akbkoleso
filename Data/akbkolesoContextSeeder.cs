using System.Linq;

namespace akbkoleso.Data
{
    public static class akbkolesoContextSeeder
    {
        public static void Seed(akbkolesoContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(SampleData.GetDefaultProducts());
                context.SaveChanges();
            }
        }
    }
}