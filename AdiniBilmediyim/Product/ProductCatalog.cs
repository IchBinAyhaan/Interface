

namespace Product
{
    internal class ProductCatalog
    {
        private Product[] products = new Product[10];
        private int count = 0;

        public void Add(Product product)
        {
            if (count < products.Length)
            {
                products[count++] = product;
            }
            else
            {
                Console.WriteLine("Product catalog is full.");
            }
        }

        public Product[] GetAll()
        {
            return products;
        }

        public Product[] GetAllProductsByType(ProductType type)
        {
            Product[] productsOfType = new Product[products.Length];
            int index = 0;

            foreach (var product in products)
            {
                if (product != null && product.Type == type)
                {
                    productsOfType[index++] = product;
                }
            }

            Array.Resize(ref productsOfType, index);
            return productsOfType;
        }
    }
}
