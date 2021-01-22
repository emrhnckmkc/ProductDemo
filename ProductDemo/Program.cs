using System;

namespace ProductDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products();

            product1.productType = "Computer";
            product1.productName = "Monster Notebook";
            product1.productStock = 999;

            Products product2 = new Products();

            product2.productType = "Smart Phone";
            product2.productName = "iPhone 11";
            product2.productStock = 99;

            Products product3 = new Products();

            product3.productType = "Headphone";
            product3.productName = "JBL Headphone";
            product3.productStock = 9999;

            Products[] products = new Products[] { product1, product2, product3 };

            Console.WriteLine(product1.productType + " >> " + product1.productName + " > " + product1.productStock);

            for (int i = 0; i < products.Length; i++)

            {
                Console.WriteLine("Ürün Çeşidi:" + products[i].productType);
                Console.WriteLine("Ürün Adı:" + products[i].productName);
                Console.WriteLine("Ürün Stoğu:" + products[i].productStock);

            }

            foreach (var product in products)

            {
                Console.WriteLine("Ürün Çeşidi:" + product.productType);
                Console.WriteLine("Ürün Adı:" + product.productName);
                Console.WriteLine("Ürün Stoğu:" + product.productStock);
            }

            int whileLoop = 0;
            while (whileLoop < products.Length)

            {
                Console.WriteLine("Ürün Çeşidi: " + products[whileLoop].productType);
                Console.WriteLine("Ürün Adı: " + products[whileLoop].productName);
                Console.WriteLine("Ürün Stoğu: "  + products[whileLoop].productStock);
                whileLoop++;
            }

            Console.WriteLine("All products have listed with for, foreach and while loops.");
        }
    }
}
