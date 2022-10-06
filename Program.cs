using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product sınıfından yeni bir değişken türet ve içini veri ile doldur. 
            Product product1 = new Product();
            product1.ProductName = "Ürün1 adı";
            product1.Price = 11;
            product1.Specs = "Özellikler";

            Product product2 = new Product();
            product2.ProductName = "Ürün2 adı";
            product2.Price = 15;
            product2.Specs = "Özellikler";

            Product product3 = new Product();
            product3.ProductName = "Ürün3 adı";
            product3.Price = 9;
            product3.Specs = "Özellikler";

            //products isminde bir Product Array sınıfı oluştur. Buna product değişkenlerini ekle. 
            Product[] products = new Product[] {product1,product2,product3 };

            //Tüm ürünleri döndür ve ekrana yaz.
            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName + " " +product.Price + " " +product.Specs);
            }

            //Ürün sayısını for döngüsü ile göster.
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName+ products[i].Specs);
            }

            //Ürün sayısı 0 dan başlayıp tüm ürünleri dönene kadar ekrana yaz.
            int UrunSayi = 0;
            while (UrunSayi<products.Length)
            {
                Console.WriteLine(products[UrunSayi].ProductName + products[UrunSayi].Price);
                UrunSayi++;
            }

            Console.WriteLine("Hello World!");
        }
    }
    //Ürünler Sınıfı 
    class Product 
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Specs { get; set; }
    }
}
