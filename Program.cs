using Administration.Model;
using System.Net.Mail;

namespace Administration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            using (var myDBContext = new MyDBContext())
            {
                //Zorg dat elk Product precies één ProductCategorie toegewezen krijgt
                //Maak enkele producten en categorieën aan en bewaar die in je databank

                var productCategorie1 = new ProductCategorie { Naam = "Electronics" };
                var productCategorie2 = new ProductCategorie { Naam = "Clothing" };
                var productCategorie3 = new ProductCategorie { Naam = "Food" };

                var product1 = new Product { Naam = "Laptop", Omschrijving = "Powerful laptop", ProductCategorie = productCategorie1 };
                var product2 = new Product { Naam = "Smartphone", Omschrijving = "Modern smartphone", ProductCategorie = productCategorie1 };
                var product3 = new Product { Naam = "T-shirt", Omschrijving = "Cotton T-shirt", ProductCategorie = productCategorie2 };
                var product4 = new Product { Naam = "Pizza", Omschrijving = "Delicious pizza", ProductCategorie = productCategorie3 };
                var product5 = new Product { Naam = "Ice Cream", Omschrijving = "Tasty ice cream", ProductCategorie = productCategorie3 };

                myDBContext.ProductCategorieen.AddRange(productCategorie1, productCategorie2, productCategorie3);
                myDBContext.Producten.AddRange(product1, product2, product3, product4, product5);

                myDBContext.SaveChanges();
            }
        }
    }
}