namespace Product
{
    public enum ProductType
    {
        Electronics,
        Clothing,
        Books,
        Groceries
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProductCatalog catalog = new ProductCatalog();
            catalog.Add(new Product("Laptop", 1500, ProductType.Electronics));
            catalog.Add(new Product("T-shirt", 20, ProductType.Clothing));
            catalog.Add(new Product("Harry Potter", 10, ProductType.Books));
            catalog.Add(new Product("Apple", 2, ProductType.Groceries));

            Console.WriteLine("All products:");
            foreach (var product in catalog.GetAll())
            {
                if (product != null)
                    Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Type: {product.Type}");
            }
            Console.WriteLine("\nElectronics products:");
            foreach (var product in catalog.GetAllProductsByType(ProductType.Electronics))
            {
                if (product != null)
                    Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Type: {product.Type}");
            }
        }
    }
}